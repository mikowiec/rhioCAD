namespace ZetaColorEditor.Runtime.InternalControls.CustomColors
{
	partial class ColorAreaUserControl
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
			this.SuspendLayout();
			// 
			// ColorAreaUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Name = "ColorAreaUserControl";
			this.Paint += new System.Windows.Forms.PaintEventHandler( this.colorAreaUserControl_Paint );
			this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.colorAreaUserControl_MouseMove );
			this.Leave += new System.EventHandler( this.colorAreaUserControl_Leave );
			this.MouseClick += new System.Windows.Forms.MouseEventHandler( this.colorAreaUserControl_MouseClick );
			this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.colorAreaUserControl_MouseDown );
			this.Enter += new System.EventHandler( this.colorAreaUserControl_Enter );
			this.ResumeLayout( false );

		}

		#endregion
	}
}
