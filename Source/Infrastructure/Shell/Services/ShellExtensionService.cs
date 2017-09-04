/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI;
using Naro.Infrastructure.Interface.Services;
using TreeData.NaroData;
using System;
using Microsoft.Practices.CompositeUI.EventBroker;
using Naro.Infrastructure.Interface;

namespace Naro.Infrastructure.Shell
{
    class ShellExtensionService : IShellExtensionService
    {
        private WorkItem _workItem;
        private ShellForm _shellForm;
        private List<ToolStrip> _toolstrips = new List<ToolStrip>();

        public ShellExtensionService([ServiceDependency] WorkItem workItem)
        {
            _workItem = workItem;
            _shellForm = _workItem.Items.Get<ShellForm>("ShellForm");
        }

        /// <summary>
        /// Adds a toolstrip on the Shell.
        /// </summary>
        /// <param name="toolStrip"></param>
        /// <param name="visible"></param>
        /// <returns></returns>
        public bool AddToolstrip(ToolStrip toolStrip, bool visible)
        {
            if (_shellForm == null)
            {
                return false;
            }

            ToolStrip foundToolstrip = _toolstrips.Find(delegate(ToolStrip ts)
                                 {
                                     if (ts.Name == toolStrip.Name)
                                     {
                                         return true;
                                     }
                                     return false;
                                 }
                );
            if (foundToolstrip != null)
            {
                return false;
            }

            _shellForm.topPanel.SuspendLayout();

            // Add the toolstrip on the Shell
            toolStrip.Dock = DockStyle.Left;
            toolStrip.Visible = visible;
            toolStrip.Location = new Point(_shellForm.topPanel.Left, _shellForm.topPanel.Top);
            _toolstrips.Add(toolStrip);

            _shellForm.topPanel.Controls.Clear();
            foreach (ToolStrip ts in _toolstrips)
            {
                _shellForm.topPanel.Controls.Add(ts);
            }

            _shellForm.topPanel.ResumeLayout();

            return true;
        }

        /// <summary>
        /// Shows a toolstrip on the Shell.
        /// </summary>
        /// <param name="toolStrip"></param>
        /// <returns></returns>
        public bool ShowToolstrip(ToolStrip toolStrip)
        {
            if (_shellForm == null)
            {
                return false;
            }

            _shellForm.topPanel.SuspendLayout();

            Control[] ctrls = _shellForm.topPanel.Controls.Find(toolStrip.Name, true);
            foreach (Control ctrl in ctrls)
            {
                ctrl.Dock = DockStyle.Left;
                ctrl.Visible = true;
            }

            _shellForm.topPanel.ResumeLayout();

            return true;
        }

        /// <summary>
        /// Hides a toolstrip from the Shell.
        /// </summary>
        /// <param name="toolStrip"></param>
        /// <returns></returns>
        public bool HideToolstrip(ToolStrip toolStrip)
        {
            if (_shellForm == null)
            {
                return false;
            }

            _shellForm.topPanel.SuspendLayout();

            Control[] ctrls = _shellForm.topPanel.Controls.Find(toolStrip.Name, true);
            foreach (Control ctrl in ctrls)
            {
                ctrl.Visible = false;
            }

            _shellForm.topPanel.ResumeLayout();

            return true;
        }


        public void SetUndoEventsList(List<string> eventList)
        {
            var enabled = eventList.Count > 0;
            _shellForm.undo.Enabled = enabled;
            _shellForm.undoStripDropDownButton.DropDownItems.Clear();
            foreach (var eventName in eventList)
            {
                var toolStrip = new ToolStripMenuItem(eventName);
                toolStrip.Click += new System.EventHandler(undoToolStrip_Click);
                _shellForm.undoStripDropDownButton.DropDownItems.Add(toolStrip);
            }
        }

        void undoToolStrip_Click(object sender, System.EventArgs e)
        {
            int pos = 0;
            foreach (var toolItem in _shellForm.undoStripDropDownButton.DropDownItems)
            {
                pos++;
                if (sender == toolItem)
                {
                    break;
                }                
            }
            for (int i = 0; i < pos; i++)
            {
                _document.Undo();
            }
            UpdateUndoRedoList();
            ShowProperties();
        }

        void ShowProperties()
        {
            _workItem.EventTopics[Constants.EventTopicNames.RepaintView].Fire(this, EventArgs.Empty, _workItem, PublicationScope.Global);
            _workItem.EventTopics[Constants.EventTopicNames.ShowProperties].Fire(this, EventArgs.Empty, _workItem, PublicationScope.Global);
        }


        void redoToolStrip_Click(object sender, System.EventArgs e)
        {
            int pos = 0;
            foreach (var toolItem in _shellForm.redoStripDropDownButton.DropDownItems)
            {
                pos++;
                if (sender == toolItem)
                {
                    break;
                }
            }
            for (int i = 0; i < pos; i++)
            {
                _document.Redo();
            }
            ShowProperties();
            UpdateUndoRedoList();
        }

        void SetRedoEventsList(List<string> eventList)
        {
            var enabled = eventList.Count > 0;
            _shellForm.redo.Enabled = enabled;
            _shellForm.redoStripDropDownButton.DropDownItems.Clear();
            foreach (var eventName in eventList)
            {
                var toolStrip = new ToolStripMenuItem(eventName);
                toolStrip.Click += new System.EventHandler(redoToolStrip_Click);
                _shellForm.redoStripDropDownButton.DropDownItems.Add(toolStrip);
            }
        }

        Document _document;

        public void SetDocument(Document document)
        {
            _document = document;
            UpdateUndoRedoList();
        }

        public void UpdateUndoRedoList()
        {
            SetUndoEventsList(_document.UndoList);
            SetRedoEventsList(_document.RedoList);
        }
    }
}
