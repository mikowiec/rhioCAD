namespace ZetaColorEditor.Runtime.InternalControls
{
	partial class CustomColorEditorUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( CustomColorEditorUserControl ) );
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.gControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.rControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.sControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.hControl = new ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.htmlTextBox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.currentColorPanel = new System.Windows.Forms.Panel();
			this.colorControl = new ZetaColorEditor.Runtime.InternalControls.CustomColors.ColorAreaAndSliderUserControl();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rControl)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hControl)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			resources.ApplyResources( this.groupBox1, "groupBox1" );
			this.groupBox1.Controls.Add( this.bControl );
			this.groupBox1.Controls.Add( this.gControl );
			this.groupBox1.Controls.Add( this.rControl );
			this.groupBox1.Controls.Add( this.label3 );
			this.groupBox1.Controls.Add( this.label2 );
			this.groupBox1.Controls.Add( this.label1 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// bControl
			// 
			resources.ApplyResources( this.bControl, "bControl" );
			this.bControl.Maximum = new decimal( new int[] {
            255,
            0,
            0,
            0} );
			this.bControl.Name = "bControl";
			this.bControl.Value = new decimal( new int[] {
            255,
            0,
            0,
            0} );
			this.bControl.ValueChanged += new System.EventHandler( this.bControl_ValueChanged );
			// 
			// gControl
			// 
			resources.ApplyResources( this.gControl, "gControl" );
			this.gControl.Maximum = new decimal( new int[] {
            255,
            0,
            0,
            0} );
			this.gControl.Name = "gControl";
			this.gControl.ValueChanged += new System.EventHandler( this.gControl_ValueChanged );
			// 
			// rControl
			// 
			resources.ApplyResources( this.rControl, "rControl" );
			this.rControl.Maximum = new decimal( new int[] {
            255,
            0,
            0,
            0} );
			this.rControl.Name = "rControl";
			this.rControl.ValueChanged += new System.EventHandler( this.rControl_ValueChanged );
			// 
			// label3
			// 
			resources.ApplyResources( this.label3, "label3" );
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources( this.label2, "label2" );
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources( this.label1, "label1" );
			this.label1.Name = "label1";
			// 
			// groupBox2
			// 
			resources.ApplyResources( this.groupBox2, "groupBox2" );
			this.groupBox2.Controls.Add( this.lControl );
			this.groupBox2.Controls.Add( this.sControl );
			this.groupBox2.Controls.Add( this.hControl );
			this.groupBox2.Controls.Add( this.label4 );
			this.groupBox2.Controls.Add( this.label5 );
			this.groupBox2.Controls.Add( this.label9 );
			this.groupBox2.Controls.Add( this.label8 );
			this.groupBox2.Controls.Add( this.label7 );
			this.groupBox2.Controls.Add( this.label6 );
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// lControl
			// 
			resources.ApplyResources( this.lControl, "lControl" );
			this.lControl.Name = "lControl";
			this.lControl.ValueChanged += new System.EventHandler( this.lControl_ValueChanged );
			// 
			// sControl
			// 
			resources.ApplyResources( this.sControl, "sControl" );
			this.sControl.Name = "sControl";
			this.sControl.ValueChanged += new System.EventHandler( this.sControl_ValueChanged );
			// 
			// hControl
			// 
			resources.ApplyResources( this.hControl, "hControl" );
			this.hControl.Maximum = new decimal( new int[] {
            360,
            0,
            0,
            0} );
			this.hControl.Name = "hControl";
			this.hControl.ValueChanged += new System.EventHandler( this.hControl_ValueChanged );
			// 
			// label4
			// 
			resources.ApplyResources( this.label4, "label4" );
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources( this.label5, "label5" );
			this.label5.Name = "label5";
			// 
			// label9
			// 
			resources.ApplyResources( this.label9, "label9" );
			this.label9.Name = "label9";
			// 
			// label8
			// 
			resources.ApplyResources( this.label8, "label8" );
			this.label8.Name = "label8";
			// 
			// label7
			// 
			resources.ApplyResources( this.label7, "label7" );
			this.label7.Name = "label7";
			// 
			// label6
			// 
			resources.ApplyResources( this.label6, "label6" );
			this.label6.Name = "label6";
			// 
			// htmlTextBox
			// 
			resources.ApplyResources( this.htmlTextBox, "htmlTextBox" );
			this.htmlTextBox.Name = "htmlTextBox";
			this.htmlTextBox.TextChanged += new System.EventHandler( this.htmlTextBox_TextChanged );
			// 
			// groupBox3
			// 
			resources.ApplyResources( this.groupBox3, "groupBox3" );
			this.groupBox3.Controls.Add( this.htmlTextBox );
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// currentColorPanel
			// 
			resources.ApplyResources( this.currentColorPanel, "currentColorPanel" );
			this.currentColorPanel.Name = "currentColorPanel";
			// 
			// colorControl
			// 
			resources.ApplyResources( this.colorControl, "colorControl" );
			this.colorControl.Name = "colorControl";
			this.colorControl.SelectedColor = System.Drawing.Color.FromArgb( ((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))) );
			this.colorControl.ColorChanged += new System.EventHandler( this.colorControl_ColorChanged );
			this.colorControl.ValueChangedByUser += new System.EventHandler( this.colorControl_ValueChangedByUser );
			// 
			// groupBox4
			// 
			resources.ApplyResources( this.groupBox4, "groupBox4" );
			this.groupBox4.Controls.Add( this.currentColorPanel );
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// CustomColorEditorUserControl
			// 
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.colorControl );
			this.Controls.Add( this.groupBox4 );
			this.Controls.Add( this.groupBox3 );
			this.Controls.Add( this.groupBox2 );
			this.Controls.Add( this.groupBox1 );
			this.Name = "CustomColorEditorUserControl";
			this.Load += new System.EventHandler( this.customColorEditorUserControl_Load );
			this.groupBox1.ResumeLayout( false );
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rControl)).EndInit();
			this.groupBox2.ResumeLayout( false );
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hControl)).EndInit();
			this.groupBox3.ResumeLayout( false );
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl rControl;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl bControl;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl gControl;
		private System.Windows.Forms.GroupBox groupBox2;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl lControl;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl sControl;
		private ZetaColorEditor.Runtime.Helper.ExtendedNumericUpDownControl hControl;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox htmlTextBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel currentColorPanel;
		private ZetaColorEditor.Runtime.InternalControls.CustomColors.ColorAreaAndSliderUserControl colorControl;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}
