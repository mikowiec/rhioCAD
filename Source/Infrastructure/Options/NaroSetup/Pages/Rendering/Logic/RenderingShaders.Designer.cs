/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */


using ICSharpCode.TextEditor;

namespace NaroSetup.Pages.Rendering.Logic
{
	partial class RenderingShaders
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
            this.label3 = new System.Windows.Forms.Label();
            this.textEditorControl1 = new TextEditorControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.glassButton2 = new Glass.GlassButton();
            this.glassButton3 = new Glass.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.shaderNameLabel = new System.Windows.Forms.Label();
            this.previewButton = new Glass.GlassButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code:";
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(23, 104);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(448, 109);
            this.textEditorControl1.TabIndex = 3;
            this.textEditorControl1.Text = "   type shiny\r\n   diff { \"sRGB nonlinear\" 1 .33 .33 }\r\n   refl .5\r\n";
            this.textEditorControl1.TextChanged += new System.EventHandler(this.TextEditorControl1TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // glassButton2
            // 
            this.glassButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.glassButton2.Location = new System.Drawing.Point(396, 234);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(75, 23);
            this.glassButton2.TabIndex = 5;
            this.glassButton2.Text = "&Close";
            this.glassButton2.Click += new System.EventHandler(this.GlassButton2Click);
            // 
            // glassButton3
            // 
            this.glassButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.glassButton3.Location = new System.Drawing.Point(19, 234);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(75, 23);
            this.glassButton3.TabIndex = 5;
            this.glassButton3.Text = "&Remove";
            this.glassButton3.Click += new System.EventHandler(this.GlassButton3Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // shaderNameLabel
            // 
            this.shaderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.shaderNameLabel.Location = new System.Drawing.Point(90, 52);
            this.shaderNameLabel.Name = "shaderNameLabel";
            this.shaderNameLabel.Size = new System.Drawing.Size(377, 19);
            this.shaderNameLabel.TabIndex = 2;
            // 
            // previewButton
            // 
            this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previewButton.Location = new System.Drawing.Point(392, 52);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "&Preview";
            this.previewButton.Click += new System.EventHandler(this.PreviewButtonClick);
            // 
            // RenderingShaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 269);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.glassButton3);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textEditorControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shaderNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "RenderingShaders";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Rendering Shaders";
            this.Load += new System.EventHandler(this.RenderingShadersLoad);
            this.ResumeLayout(false);

		}
		private Glass.GlassButton glassButton3;
        private Glass.GlassButton glassButton2;
		private System.Windows.Forms.ComboBox comboBox1;
		private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shaderNameLabel;
        private Glass.GlassButton previewButton;
	}
}
