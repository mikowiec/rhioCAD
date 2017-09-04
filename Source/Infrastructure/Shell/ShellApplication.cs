/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.EventBroker;
using Naro.Infrastructure.Interface.Constants;
using Naro.Infrastructure.Interface.Services;
using Naro.Infrastructure.Library;
using log4net;
using Naro.Infrastructure.Library.Services;
using CommandNames=Naro.Infrastructure.Shell.Constants.CommandNames;
using UIExtensionSiteNames=Naro.Infrastructure.Shell.Constants.UIExtensionSiteNames;

namespace Naro.Infrastructure.Shell
{
    /// <summary>
    /// Main application entry point class.
    /// Note that the class derives from CAB supplied base class FormShellApplication, and the 
    /// main form will be ShellForm, also created by default by this solution template
    /// </summary>
    class ShellApplication : SmartClientApplication<WorkItem, ShellForm>
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ShellApplication));

        /// <summary>
        /// Application entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("-------------------------- Started " + NaroAppConstantNames.AppName + " " + NaroAppConstantNames.Version + " session ---------------------------");

            #if (DEBUG)
                RunInDebugMode();
            #else
                RunInReleaseMode();
            #endif

            File.Delete(NaroAppConstantNames.GuardFileName);
        }

        private static void RunInDebugMode()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomainUnhandledException);
            Application.ThreadException += new ThreadExceptionEventHandler(ApplicationThreadException);

        	#if !SKIP_APP_EXCEPTION
        	try {
        	#endif
                Application.SetCompatibleTextRenderingDefault(false);
                //SplashForm.Instance.Show();
                new ShellApplication().Run();
        	#if !SKIP_APP_EXCEPTION
			}
			catch (Exception ex)
			{
                HandleException(ex);
			}
            #endif
        }
        

        private static void RunInReleaseMode()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomainUnhandledException);
            Application.ThreadException += new ThreadExceptionEventHandler(ApplicationThreadException);


            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.SetCompatibleTextRenderingDefault(false);
                SplashForm.Instance.Show();
                new ShellApplication().Run();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        /// <summary>
        /// Sets the extension site registration after the shell has been created.
        /// </summary>
        protected override void AfterShellCreated()
        {
            base.AfterShellCreated();

            RootWorkItem.Items.Add(this.Shell, "ShellForm");

            // Register services
            RootWorkItem.Services.AddNew<ShellExtensionService, IShellExtensionService>();
            RootWorkItem.Services.AddNew<ContextService, IContextService>();

            // Register the GUI controls
            RootWorkItem.Services.Get<IContextService>().PropertyWindow = Shell.PropertyWindow;
            RootWorkItem.Services.Get<IContextService>().ObjectsTreeWindow = Shell.ObjectsTreeWindow;
            RootWorkItem.Services.Get<IContextService>().CommandLineWindow = Shell.CommandLineWindow;
            RootWorkItem.Services.Get<IContextService>().HelpWindow = Shell.HelpWindow;

            // Undo redo commands
            IShellExtensionService extensionService = RootWorkItem.Services.Get<IShellExtensionService>();
            extensionService.AddToolstrip(Shell.UndoRedo, true);
            RootWorkItem.Commands[CommandNames.Undo].AddInvoker(Shell.undo, "Click");
            RootWorkItem.Commands[CommandNames.Redo].AddInvoker(Shell.redo, "Click");

            // Open Save commands
            RootWorkItem.Commands[CommandNames.Open].AddInvoker(Shell.openToolStripMenuItem, "Click");
            RootWorkItem.Commands[CommandNames.Save].AddInvoker(Shell.saveToolStripMenuItem, "Click");
            RootWorkItem.Commands[CommandNames.SaveAs].AddInvoker(Shell.saveAsToolStripMenuItem, "Click");

            RootWorkItem.Commands[CommandNames.Open].AddInvoker(Shell.openToolStripButton, "Click");
            RootWorkItem.Commands[CommandNames.Save].AddInvoker(Shell.saveToolStripButton,"Click");
            RootWorkItem.Commands[CommandNames.ExportToStep].AddInvoker(Shell.exportToolStripMenuItem, "Click");
            RootWorkItem.Commands[CommandNames.ImportFromStep].AddInvoker(Shell.importStepToolStripMenuItem, "Click");
            RootWorkItem.Commands[CommandNames.ImportFromBrep].AddInvoker(Shell.importBrepToolStripMenuItem, "Click");

            RootWorkItem.Commands[CommandNames.OptionsTools].AddInvoker(Shell.optionsToolStripMenuItem, "Click");

            // Register UIExtension sites

            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.MainMenu, this.Shell.mainMenuStrip);
            // The File menu
            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.FileToolStripMenuItem, this.Shell.fileToolStripMenuItem.DropDownItems);
            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.NewToolStripMenuItem, this.Shell.newToolStripMenuItem.DropDownItems);
            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.ImportToolStripMenuItem, this.Shell.importToolStripMenuItem.DropDownItems);
            // The View menu
            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.ViewToolStripMenuItem, this.Shell.viewToolStripMenuItem.DropDownItems);
            // The Insert menu
            RootWorkItem.UIExtensionSites.RegisterSite(UIExtensionSiteNames.InsertToolStripMenuItem, this.Shell.insertToolStripMenuItem.DropDownItems);
        }

        private static void AppDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        public static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        private static void HandleException(Exception ex)
        {
            if (ex == null)
                return;

            log.Error("Exception message: " + ex.Message + Environment.NewLine + " Stack trace: " + ex.StackTrace);               

            if (ex is EventTopicException)
            {
                var exceptions = (ex as EventTopicException).Exceptions;
                foreach (var exception in exceptions)
                {
                    log.Error("Exception message: " + exception.Message + Environment.NewLine + " Stack trace: " + exception.StackTrace);               
                }
            }

            //MessageBox.Show("An unhandled exception occurred, and the application is terminating. For more information, see your Application event log.");
            throw new Exception("Crash on Naro");
        }
    }
}
