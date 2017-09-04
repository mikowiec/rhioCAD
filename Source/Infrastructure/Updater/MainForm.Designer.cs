/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

namespace Updater
{
	partial class MainForm
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.optionsGroupBox = new System.Windows.Forms.GroupBox();
			this.buttonPanel.SuspendLayout();
			this.glassPanel1.SuspendLayout();
			this.optionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonPanel
			// 
			this.buttonPanel.BackColor = System.Drawing.Color.RoyalBlue;
			this.buttonPanel.Controls.Add(this.cancelButton);
			this.buttonPanel.Controls.Add(this.okButton);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 304);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(334, 50);
			this.buttonPanel.TabIndex = 8;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackColor = System.Drawing.Color.Silver;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FadeOnFocus = true;
			this.cancelButton.Location = new System.Drawing.Point(134, 12);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(88, 26);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.BackColor = System.Drawing.Color.Green;
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(234, 12);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(88, 26);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "&OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// glassPanel1
			// 
			this.glassPanel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.glassPanel1.Controls.Add(this.optionsGroupBox);
			this.glassPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glassPanel1.Location = new System.Drawing.Point(0, 0);
			this.glassPanel1.Name = "glassPanel1";
			this.glassPanel1.Size = new System.Drawing.Size(334, 304);
			this.glassPanel1.TabIndex = 9;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(13, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(177, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "&Check for updates automatically";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(35, 43);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(138, 17);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Text = "&Check for beta versions";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.ForeColor = System.Drawing.Color.Yellow;
			this.checkBox3.Location = new System.Drawing.Point(13, 81);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(157, 17);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Text = "&Automatically apply updates";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// optionsGroupBox
			// 
			this.optionsGroupBox.Controls.Add(this.checkBox3);
			this.optionsGroupBox.Controls.Add(this.checkBox2);
			this.optionsGroupBox.Controls.Add(this.checkBox1);
			this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.optionsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.optionsGroupBox.Name = "optionsGroupBox";
			this.optionsGroupBox.Size = new System.Drawing.Size(334, 304);
			this.optionsGroupBox.TabIndex = 0;
			this.optionsGroupBox.TabStop = false;
			this.optionsGroupBox.Text = "Options";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 354);
			this.Controls.Add(this.glassPanel1);
			this.Controls.Add(this.buttonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Naro update";
			this.buttonPanel.ResumeLayout(false);
			this.glassPanel1.ResumeLayout(false);
			this.optionsGroupBox.ResumeLayout(false);
			this.optionsGroupBox.PerformLayout();
			this.ResumeLayout(false);
		}
        private Glass.GlassPanel buttonPanel;
        private Glass.GlassButton cancelButton;
        private Glass.GlassButton okButton;
        private Glass.GlassPanel glassPanel1;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
	}
}
