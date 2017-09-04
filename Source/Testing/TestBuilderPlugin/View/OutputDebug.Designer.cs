/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */


using Glass;

namespace TestBuilderPlugin.View
{
	partial class OutputDebug
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new GlassPanel();
            this.refreshBtn = new Glass.GlassButton();
            this.ObjectsTreeList = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 31);
            this.panel1.TabIndex = 3;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(3, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "&Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtnClick);
            // 
            // ObjectsTreeList
            // 
            this.ObjectsTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectsTreeList.Location = new System.Drawing.Point(0, 31);
            this.ObjectsTreeList.Name = "ObjectsTreeList";
            this.ObjectsTreeList.Size = new System.Drawing.Size(284, 233);
            this.ObjectsTreeList.TabIndex = 4;
            // 
            // OutputDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.ObjectsTreeList);
            this.Controls.Add(this.panel1);
            this.Name = "OutputDebug";
            this.Text = "OutputDebug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutputDebugFormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private Glass.GlassButton refreshBtn;
		private Glass.GlassPanel panel1;
		private System.Windows.Forms.TreeView ObjectsTreeList;
		
	}
}
