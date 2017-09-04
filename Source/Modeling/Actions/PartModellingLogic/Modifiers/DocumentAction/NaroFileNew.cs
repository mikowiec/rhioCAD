#region Usings

using System.Windows.Forms;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Library.Actions.DocumentAction;
using Naro.Infrastructure.Library.DocumentHelpers;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.V3d;
using NaroPipes.Constants;


#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class NaroFileNew : DocumentActionBase
    {
        private readonly string _fileName = NaroAppConstantNames.NewFileName;

        public NaroFileNew()
            : base(ModifierNames.NewFile)
        {
            DependsOn(InputNames.FileSaveDialog);
            DependsOn(InputNames.SelectionContainerPipe);
        }

        public override void OnActivate()
        {
            base.OnActivate();
            if (Document.HistoryCount <= 0)
            {
                LoadDefaultTemplate();
                return;
            }
            var result = NaroMessage.Show(
                @"Do you want to save your work?",
                @"NaroCAD",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Cancel)
            {
                BackToNeutralModifier();
                return;
            }
            if (result == DialogResult.No)
            {
                LoadDefaultTemplate();
                return;
            }

            const string inputName = InputNames.FileSaveDialog;
            Send(inputName, NotificationNames.SetFilter,
                 "Naro Xml Document (*.naroxml)|*.naroxml|STEP Files|*.step");
            Send(inputName, NotificationNames.ShowSaveAs);
            var fileName = GetData(inputName, NotificationNames.GetFile);
            SaveCommonCodes.SaveToFile(fileName, Document);
            
            LoadDefaultTemplate();
        }

        private void LoadDefaultTemplate()
        {
            Document.LoadFromXml(_fileName);
            Document.ResetHistory();
            Inputs[InputNames.SelectionContainerPipe].Send(NotificationNames.SwitchSelectionMode,
                                                         TopAbsShapeEnum.TopAbs_SOLID);
            var data = GetData<ViewInput.Items>(InputNames.View, NotificationNames.GetValue);
            data.View.SetProj(V3dTypeOfOrientation.V3d_XposYnegZpos);
            UpdateView();
            RebuildTreeView();
            ResetTransformationInfo();
            // We need to make sure the Sketch editing is not left open between files
            EndSketch();
            BackToNeutralModifier();
        }
    }
}