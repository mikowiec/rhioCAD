using System.Drawing;
using PartModellingUi.Views;

namespace MetaActionTests.VisualTestSuite.Dependencies
{
    partial class OccVisualForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiviewTableLayoutPanel = new MultiView();
            this.multiviewTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiviewTableLayoutPanel
            // 
            this.multiviewTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.multiviewTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiviewTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.multiviewTableLayoutPanel.Name = "multiviewTableLayoutPanel";
            this.multiviewTableLayoutPanel.Size = new System.Drawing.Size(284, 262);
            this.multiviewTableLayoutPanel.TabIndex = 1;
            // 
            // OccVisualForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.multiviewTableLayoutPanel);
            this.Name = "OccVisualForm";
            this.Text = "OccVisualForm";
            this.multiviewTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MultiView multiviewTableLayoutPanel;
    }
}