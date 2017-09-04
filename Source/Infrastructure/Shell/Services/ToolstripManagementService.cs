/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

using System;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Naro.Infrastructure.Interface.Services;

namespace Naro.Infrastructure.Shell.Services
{
    public class ToolstripManagementService : IToolstripManagementService
    {
        private WorkItem _workItem;

        public ToolstripManagementService([ServiceDependency] WorkItem workItem)
        {
            _workItem = workItem;
        }

        public void ShowToolstrip(String toolstripName)
        {
            ShowToolstrip(toolstripName, true);
        }

        public void HideToolstrip(String toolstripName)
        {
            ShowToolstrip(toolstripName, false);
        }

        private void ShowToolstrip(String toolstripName, bool visible)
        {
            if (_workItem != null)
            {
                ShellForm shellForm = _workItem.Items.Get<ShellForm>("ShellForm");
                if (shellForm != null)
                {
                    // Show the toolstrip
                    Control[] controls = shellForm.topPanel.Controls.Find(toolstripName, true);
                    if (controls.Length == 1)
                    {
                        controls[0].Visible = visible;
                    }
                }
            }
        }
    }
}
