/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

namespace Updater
{
	partial class DownloadReady
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
			this.buttonPanel = new Glass.GlassPanel();
			this.cancelButton = new Glass.GlassButton();
			this.okButton = new Glass.GlassButton();
			this.glassPanel1 = new Glass.GlassPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPanel.SuspendLayout();
			this.glassPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPanel
			// 
			this.buttonPanel.BackColor = System.Drawing.Color.RoyalBlue;
			this.buttonPanel.Controls.Add(this.cancelButton);
			this.buttonPanel.Controls.Add(this.okButton);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 123);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(429, 50);
			this.buttonPanel.TabIndex = 11;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackColor = System.Drawing.Color.Silver;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FadeOnFocus = true;
			this.cancelButton.Location = new System.Drawing.Point(229, 12);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(88, 26);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "&Cancel";
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.Color.Green;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(329, 12);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(88, 26);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "&OK";
			// 
			// glassPanel1
			// 
			this.glassPanel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.glassPanel1.Controls.Add(this.label1);
			this.glassPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glassPanel1.Location = new System.Drawing.Point(0, 0);
			this.glassPanel1.Name = "glassPanel1";
			this.glassPanel1.Size = new System.Drawing.Size(429, 123);
			this.glassPanel1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(404, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "A new version have been downloaded, do you want to install it? \r\nPlease save what" +
			" did you work on to not have data loss!";
			// 
			// DownloadReady
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 173);
			this.Controls.Add(this.glassPanel1);
			this.Controls.Add(this.buttonPanel);
			this.Name = "DownloadReady";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Download Ready";
			this.buttonPanel.ResumeLayout(false);
			this.glassPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private Glass.GlassPanel glassPanel1;
		private Glass.GlassButton okButton;
		private Glass.GlassButton cancelButton;
        private Glass.GlassPanel buttonPanel;
	}
}
