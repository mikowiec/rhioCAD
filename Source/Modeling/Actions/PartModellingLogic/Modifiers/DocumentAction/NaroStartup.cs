#region Usings

using System;
using System.IO;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using ErrorReportCommon;
using ErrorReportCommon.Messages;
using NaroCppCore.Occ.TopAbs;
using log4net;
using Naro.Infrastructure.Interface.AppUtils;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroSetup;

using PartModellingLogic.UI.Views.AutoSave;
using Resources.Infrastructure;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using Updater;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    internal class NaroStartup : DocumentActionBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (NaroStartup));

        public NaroStartup()
            : base(ModifierNames.StartUp)
        {
            DependsOn(InputNames.GeometricSolverPipe);
            DependsOn(InputNames.SelectionContainerPipe);
            DependsOn(InputNames.CurrentDocumentInput);
        }

        private bool RestoreAutoSavedFile()
        {
            var optionsSetup = ActionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var autoSaveSection = optionsSetup.UpdateSectionNode(OptionSectionNames.AutoSavePageTitle);
            if (autoSaveSection.GetBoolValue(0))
                //do not auto-restore if user have no auto-save
                return false;
            var intTemp = 0;
            StreamReader lockFile = null;
            if (!File.Exists(NaroAppConstantNames.GuardFileName))
            {
                return false;
            }
            try
            {
                lockFile = new StreamReader(NaroAppConstantNames.GuardFileName);
                intTemp = Convert.ToInt32(lockFile.ReadLine());
            }
            catch
            {
                Log.Info("Error on reading guard file");
            }
            finally
            {
                try
                {
                    if (lockFile != null) lockFile.Close();
                }
                catch
                {
                    Log.Info("Error on closing guard file");
                }
            }
            if (intTemp == 1)
            {
                var autoSaveDialog = new AutoSaveRestoreDialog();
                autoSaveDialog.ShowDialog();
                if (autoSaveDialog.DialogResult == DialogResult.OK)
                {
                    if (File.Exists(NaroAppConstantNames.AutoSaveFileName))
                    {
                        Document.LoadFromXml(NaroAppConstantNames.AutoSaveFileName);
                        return true;
                    }
                }
            }
            return false;
        }

        public override void OnActivate()
        {
            DefaultInterpreters.Setup();

            UpdaterSetup();


            var somethingLoaded = false;
            try
            {
                if (NaroStartInfo.Instance.Arguments.Length > 0)
                {
                    var fileName = NaroStartInfo.Instance.Arguments[0];
                    if (File.Exists(fileName))
                    {
                        Document.LoadFromXml(fileName);
                        somethingLoaded = true;
                    }
                    else
                        NaroMessage.Show(ExtensionsResources.File_not_found_on_disk);
                }
            }
            catch
            {
                NaroMessage.Show(ExtensionsResources.Invalid_file_to_load);
            }
            if (!somethingLoaded)
                RestoreAutoSavedFile();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                           TopAbsShapeEnum.TopAbs_SOLID);

            BackToNeutralModifier();
        }

        private void UpdaterSetup()
        {
            var optionsSetup = ActionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.Updater);

            var haveToUpdate = false;// optionsSection.GetBoolValue(0);
            var updateNightly = false;// optionsSection.GetBoolValue(1);

            var RibbonPanel = ActionsGraph[InputNames.FastToolbarInput].Get<StackPanel>();

            var uppdateLogic = new UpdateLogic(ActionsGraph, haveToUpdate, updateNightly, RibbonPanel);

            var updaterThread = new Thread(UpdateLogic.Main);
            updaterThread.SetApartmentState(ApartmentState.STA);
            updaterThread.Start(uppdateLogic);
        }

        public override void OnDeactivate()
        {
            ActionsGraph[InputNames.CurrentDocumentInput].Send(NotificationNames.SetData, ActionsGraph);
            Log.Info("Startup Time: " + (Environment.TickCount - CoreGlobalPreferencesSingleton.Instance.StartTime));
            base.OnDeactivate();
        }
    }
}