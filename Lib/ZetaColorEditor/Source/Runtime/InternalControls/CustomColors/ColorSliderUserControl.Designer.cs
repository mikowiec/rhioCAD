namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	partial class ColorSliderUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ColorSliderUserControl ) );
			this.arrowControl = new System.Windows.Forms.PictureBox();
			this.colorPanel = new ZetaColorEditor.Runtime.InternalControls.CustomColors.ColorSliderPanel();
			((System.ComponentModel.ISupportInitialize)(this.arrowControl)).BeginInit();
			this.SuspendLayout();
			// 
			// arrowControl
			// 
			this.arrowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.arrowControl.Image = ((System.Drawing.Image)(resources.GetObject( "arrowControl.Image" )));
			this.arrowControl.Location = new System.Drawing.Point( 23, 0 );
			this.arrowControl.Name = "arrowControl";
			this.arrowControl.Size = new System.Drawing.Size( 15, 14 );
			this.arrowControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.arrowControl.TabIndex = 1;
			this.arrowControl.TabStop = false;
			this.arrowControl.MouseMove += new System.Windows.Forms.MouseEventHandler( this.arrowControl_MouseMove );
			this.arrowControl.MouseClick += new System.Windows.Forms.MouseEventHandler( this.arrowControl_MouseClick );
			this.arrowControl.MouseDown += new System.Windows.Forms.MouseEventHandler( this.arrowControl_MouseDown );
			// 
			// colorPanel
			// 
			this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorPanel.Location = new System.Drawing.Point( 0, 0 );
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size( 17, 327 );
			this.colorPanel.TabIndex = 0;
			this.colorPanel.ValueChangedByUser += new System.EventHandler( this.colorPanel_ValueChangedByUser );
			this.colorPanel.MouseClick += new System.Windows.Forms.MouseEventHandler( this.colorPanel_MouseClick );
			this.colorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler( this.colorPanel_MouseDown );
			this.colorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler( this.colorPanel_MouseMove );
			// 
			// ColorSliderUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.colorPanel );
			this.Controls.Add( this.arrowControl );
			this.Name = "ColorSliderUserControl";
			this.Size = new System.Drawing.Size( 40, 327 );
			this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.colorSliderUserControl_MouseMove );
			this.MouseClick += new System.Windows.Forms.MouseEventHandler( this.colorSliderUserControl_MouseClick );
			this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.colorSliderUserControl_MouseDown );
			((System.ComponentModel.ISupportInitialize)(this.arrowControl)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox arrowControl;
		private ColorSliderPanel colorPanel;
	}
}
