namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	partial class ColorAreaAndSliderUserControl
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
			this.colorSliderControl = new ZetaColorEditor.Runtime.InternalControls.CustomColors.ColorSliderUserControl();
			this.colorAreaControl = new ZetaColorEditor.Runtime.InternalControls.CustomColors.ColorAreaUserControl();
			this.SuspendLayout();
			// 
			// colorSliderControl
			// 
			this.colorSliderControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorSliderControl.Location = new System.Drawing.Point( 397, 0 );
			this.colorSliderControl.Name = "colorSliderControl";
			this.colorSliderControl.Size = new System.Drawing.Size( 38, 417 );
			this.colorSliderControl.TabIndex = 3;
			this.colorSliderControl.ValueChangedByUser += new System.EventHandler( this.colorSliderControl_ValueChangedByUser );
			this.colorSliderControl.LightChanged += new System.EventHandler( this.colorSliderControl_BrightnessChanged );
			// 
			// colorAreaControl
			// 
			this.colorAreaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorAreaControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.colorAreaControl.Location = new System.Drawing.Point( 0, 0 );
			this.colorAreaControl.Name = "colorAreaControl";
			this.colorAreaControl.Size = new System.Drawing.Size( 382, 417 );
			this.colorAreaControl.TabIndex = 2;
			this.colorAreaControl.ValueChangedByUser += new System.EventHandler( this.colorAreaControl_ValueChangedByUser );
			this.colorAreaControl.HueSaturationChanged += new System.EventHandler( this.colorAreaControl_HueSaturationChanged );
			// 
			// ColorAreaAndSliderUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.colorSliderControl );
			this.Controls.Add( this.colorAreaControl );
			this.Name = "ColorAreaAndSliderUserControl";
			this.Size = new System.Drawing.Size( 435, 417 );
			this.ResumeLayout( false );

		}

		#endregion

		private ColorSliderUserControl colorSliderControl;
		private ColorAreaUserControl colorAreaControl;
	}
}
