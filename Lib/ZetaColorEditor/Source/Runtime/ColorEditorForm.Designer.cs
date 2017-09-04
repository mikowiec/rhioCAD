namespace ZetaColorEditor.Runtime
{
	partial class ColorEditorForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ColorEditorForm ) );
			this.colorEditorControl = new ZetaColorEditor.Runtime.ColorEditorUserControl();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonNoColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// colorEditorControl
			// 
			this.colorEditorControl.AccessibleDescription = null;
			this.colorEditorControl.AccessibleName = null;
			resources.ApplyResources( this.colorEditorControl, "colorEditorControl" );
			this.colorEditorControl.BackgroundImage = null;
			this.colorEditorControl.ExternalColorEditorInformationProvider = null;
			this.colorEditorControl.Font = null;
			this.colorEditorControl.MinimumSize = new System.Drawing.Size( 372, 398 );
			this.colorEditorControl.Name = "colorEditorControl";
			this.colorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.colorEditorControl.NeedUpdateUI += new System.EventHandler( this.colorEditorUserControl1_NeedUpdateUI );
			// 
			// buttonCancel
			// 
			this.buttonCancel.AccessibleDescription = null;
			this.buttonCancel.AccessibleName = null;
			resources.ApplyResources( this.buttonCancel, "buttonCancel" );
			this.buttonCancel.BackgroundImage = null;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = null;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.AccessibleDescription = null;
			this.buttonOK.AccessibleName = null;
			resources.ApplyResources( this.buttonOK, "buttonOK" );
			this.buttonOK.BackgroundImage = null;
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = null;
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler( this.buttonOK_Click );
			// 
			// buttonNoColor
			// 
			this.buttonNoColor.AccessibleDescription = null;
			this.buttonNoColor.AccessibleName = null;
			resources.ApplyResources( this.buttonNoColor, "buttonNoColor" );
			this.buttonNoColor.BackgroundImage = null;
			this.buttonNoColor.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonNoColor.Font = null;
			this.buttonNoColor.Name = "buttonNoColor";
			this.buttonNoColor.UseVisualStyleBackColor = true;
			this.buttonNoColor.Click += new System.EventHandler( this.buttonNoColor_Click );
			// 
			// ColorEditorForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.CancelButton = this.buttonCancel;
			this.Controls.Add( this.buttonNoColor );
			this.Controls.Add( this.buttonOK );
			this.Controls.Add( this.buttonCancel );
			this.Controls.Add( this.colorEditorControl );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColorEditorForm";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler( this.colorEditorForm_Load );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.colorEditorForm_FormClosing );
			this.ResumeLayout( false );

		}

		#endregion

		private ColorEditorUserControl colorEditorControl;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonNoColor;
	}
}