namespace PartModellingLogic.UI.Views.Shapes
{
    partial class CutDialog
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
            this.glassPanel1 = new Glass.GlassPanel();
            this.buttonPanel = new Glass.GlassPanel();
            this.glassButton1 = new Glass.GlassButton();
            this.button1 = new Glass.GlassButton();
            this.cutDepthTextBox = new System.Windows.Forms.TextBox();
            this.cutTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.glassPanel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // glassPanel1
            // 
            this.glassPanel1.Controls.Add(this.buttonPanel);
            this.glassPanel1.Controls.Add(this.cutDepthTextBox);
            this.glassPanel1.Controls.Add(this.cutTypeComboBox);
            this.glassPanel1.Controls.Add(this.label2);
            this.glassPanel1.Controls.Add(this.label1);
            this.glassPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassPanel1.Location = new System.Drawing.Point(0, 0);
            this.glassPanel1.Name = "glassPanel1";
            this.glassPanel1.Size = new System.Drawing.Size(324, 142);
            this.glassPanel1.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Controls.Add(this.glassButton1);
            this.buttonPanel.Controls.Add(this.button1);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 92);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(324, 50);
            this.buttonPanel.TabIndex = 6;
            // 
            // glassButton1
            // 
            this.glassButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glassButton1.BackColor = System.Drawing.Color.Silver;
            this.glassButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.glassButton1.Location = new System.Drawing.Point(124, 12);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(88, 26);
            this.glassButton1.TabIndex = 1;
            this.glassButton1.Text = "&Cancel";
            this.glassButton1.Click += new System.EventHandler(this.GlassButton1Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "&OK";
            this.button1.Click += new System.EventHandler(this.Button1Click1);
            // 
            // cutDepthTextBox
            // 
            this.cutDepthTextBox.Location = new System.Drawing.Point(105, 47);
            this.cutDepthTextBox.Name = "cutDepthTextBox";
            this.cutDepthTextBox.Size = new System.Drawing.Size(100, 20);
            this.cutDepthTextBox.TabIndex = 5;
            this.cutDepthTextBox.Text = "100";
            this.cutDepthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cutDepthTextBox.TextChanged += new System.EventHandler(this.CutDepthTextBoxTextChanged);
            // 
            // cutTypeComboBox
            // 
            this.cutTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cutTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cutTypeComboBox.FormattingEnabled = true;
            this.cutTypeComboBox.Location = new System.Drawing.Point(105, 9);
            this.cutTypeComboBox.Name = "cutTypeComboBox";
            this.cutTypeComboBox.Size = new System.Drawing.Size(207, 21);
            this.cutTypeComboBox.TabIndex = 4;
            this.cutTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CutTypeComboBoxSelectedIndexChanged1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cut depth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cut type:";
            // 
            // CutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.glassButton1;
            this.ClientSize = new System.Drawing.Size(324, 142);
            this.Controls.Add(this.glassPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cut Preferences";
            this.TopMost = true;
            this.glassPanel1.ResumeLayout(false);
            this.glassPanel1.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Glass.GlassPanel glassPanel1;
        private Glass.GlassPanel buttonPanel;
        private Glass.GlassButton glassButton1;
        private Glass.GlassButton button1;
        private System.Windows.Forms.TextBox cutDepthTextBox;
        private System.Windows.Forms.ComboBox cutTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}