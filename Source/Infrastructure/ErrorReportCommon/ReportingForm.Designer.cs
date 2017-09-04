/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */
namespace ErrorReportCommon
{
	partial class ReportingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingForm));
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.button1 = new Glass.GlassButton();
            this.button2 = new Glass.GlassButton();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.labelDetails = new System.Windows.Forms.Label();
            this.filesButton = new Glass.GlassButton();
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRestart.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRestart.Checked = true;
            this.checkBoxRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRestart.Location = new System.Drawing.Point(12, 261);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(315, 24);
            this.checkBoxRestart.TabIndex = 0;
            this.checkBoxRestart.Text = "&Restart NaroCAD after reporting";
            this.checkBoxRestart.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(276, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Submit";
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(183, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Close";
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(12, 43);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(351, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 22);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "&Issue title:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.LabelTitleClick);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDetails.Location = new System.Drawing.Point(12, 108);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(351, 142);
            this.textBoxDetails.TabIndex = 2;
            // 
            // labelDetails
            // 
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Location = new System.Drawing.Point(12, 80);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(100, 22);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "&Details:";
            this.labelDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDetails.Click += new System.EventHandler(this.LabelDetailsClick);
            // 
            // filesButton
            // 
            this.filesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filesButton.BackColor = System.Drawing.Color.DimGray;
            this.filesButton.Image = ((System.Drawing.Image)(resources.GetObject("filesButton.Image")));
            this.filesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filesButton.Location = new System.Drawing.Point(12, 287);
            this.filesButton.Name = "filesButton";
            this.filesButton.Size = new System.Drawing.Size(100, 29);
            this.filesButton.TabIndex = 1;
            this.filesButton.Text = "&Files";
            this.filesButton.Click += new System.EventHandler(this.FilesButtonClick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 328);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error report";
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.Label labelDetails;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxDetails;
		private System.Windows.Forms.TextBox textBoxTitle;
		private Glass.GlassButton button2;
        private Glass.GlassButton button1;
	    private System.Windows.Forms.CheckBox checkBoxRestart;
        private Glass.GlassButton filesButton;
        private System.Diagnostics.Process process1;
	}
}
