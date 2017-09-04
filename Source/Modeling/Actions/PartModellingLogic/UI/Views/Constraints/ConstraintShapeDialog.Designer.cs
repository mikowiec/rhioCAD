using Glass;
using ShapeFunctionsInterface.Utils;

namespace PartModellingLogic.UI.Views.Constraints
{
    sealed partial class ConstraintShapeDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listConstraints = new System.Windows.Forms.ListBox();
            this.shapeNameControl = new PartModellingLogic.UI.Views.Constraints.ShapePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new Glass.GlassButton();
            this.valuePanel = new System.Windows.Forms.Panel();
            this.removeButton = new Glass.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new Glass.GlassButton();
            this.glassPanel2 = new Glass.GlassPanel();
            this.groupBox1.SuspendLayout();
            this.valuePanel.SuspendLayout();
            this.glassPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listConstraints);
            this.groupBox1.Controls.Add(this.valuePanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply Constraint";
            // 
            // listConstraints
            // 
            this.listConstraints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listConstraints.FormattingEnabled = true;
            this.listConstraints.ItemHeight = 20;
            this.listConstraints.Location = new System.Drawing.Point(3, 16);
            this.listConstraints.Name = "listConstraints";
            this.listConstraints.Size = new System.Drawing.Size(470, 184);
            this.listConstraints.TabIndex = 0;
            this.listConstraints.SelectedIndexChanged += new System.EventHandler(this.ListConstraintsSelectedIndexChanged);
            // 
            // shapeNameControl
            // 
            this.shapeNameControl.Builder = null;
            this.shapeNameControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeNameControl.Location = new System.Drawing.Point(0, 0);
            this.shapeNameControl.Name = "shapeNameControl";
            this.shapeNameControl.Size = new System.Drawing.Size(476, 40);
            this.shapeNameControl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value:";
            this.label2.Visible = false;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(64, 10);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(294, 20);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.Visible = false;
            this.valueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueTextBoxKeyDown);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.BackColor = System.Drawing.Color.DimGray;
            this.applyButton.Location = new System.Drawing.Point(373, 10);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(88, 26);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "&Apply";
            this.applyButton.Visible = false;
            this.applyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // valuePanel
            // 
            this.valuePanel.Controls.Add(this.applyButton);
            this.valuePanel.Controls.Add(this.valueTextBox);
            this.valuePanel.Controls.Add(this.label2);
            this.valuePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.valuePanel.Location = new System.Drawing.Point(3, 118);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.Size = new System.Drawing.Size(470, 44);
            this.valuePanel.TabIndex = 1;
            this.valuePanel.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.DimGray;
            this.removeButton.Location = new System.Drawing.Point(276, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 26);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "&Remove";
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Constraints marked with star already exist";
            this.label1.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(376, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 26);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "&Close";
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // glassPanel2
            // 
            this.glassPanel2.BackColor = System.Drawing.Color.Gray;
            this.glassPanel2.Controls.Add(this.closeButton);
            this.glassPanel2.Controls.Add(this.label1);
            this.glassPanel2.Controls.Add(this.removeButton);
            this.glassPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.glassPanel2.Location = new System.Drawing.Point(0, 205);
            this.glassPanel2.Name = "glassPanel2";
            this.glassPanel2.Size = new System.Drawing.Size(476, 50);
            this.glassPanel2.TabIndex = 7;
            this.glassPanel2.Visible = false;
            // 
            // ConstraintShapeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeNameControl);
            this.Controls.Add(this.glassPanel2);
            this.Name = "ConstraintShapeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Constraint Shape";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.ConstraintShapeDialogDeactivate);
            this.Shown += new System.EventHandler(this.ConstraintShapeDialogShown);
            this.Activated += new System.EventHandler(this.ConstraintShapeDialogActivated);
            this.groupBox1.ResumeLayout(false);
            this.valuePanel.ResumeLayout(false);
            this.valuePanel.PerformLayout();
            this.glassPanel2.ResumeLayout(false);
            this.glassPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ShapePicker shapeNameControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listConstraints;
        private System.Windows.Forms.Panel valuePanel;
        private GlassButton applyButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private GlassButton removeButton;
        private System.Windows.Forms.Label label1;
        private GlassButton closeButton;
        private GlassPanel glassPanel2;


    }
}