namespace ZetaColorEditor.Runtime
{
	partial class ColorEditorUserControl
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ColorEditorUserControl ) );
			this.tabControl = new System.Windows.Forms.TabControl();
			this.customColorsTabPage = new System.Windows.Forms.TabPage();
			this.customColorEditorControl = new ZetaColorEditor.Runtime.InternalControls.CustomColorEditorUserControl();
			this.webColorsTabPage = new System.Windows.Forms.TabPage();
			this.webColorEditorControl = new ZetaColorEditor.Runtime.InternalControls.WebColorEditorUserControl();
			this.browserSafeColorsTabPage = new System.Windows.Forms.TabPage();
			this.browserSafeColorEditorControl = new ZetaColorEditor.Runtime.InternalControls.BrowserSafeColorEditorUserControl();
			this.systemColorsTabPage = new System.Windows.Forms.TabPage();
			this.systemColorEditorControl = new ZetaColorEditor.Runtime.InternalControls.SystemColorEditorUserControl();
			this.schemeColorsTabPage = new System.Windows.Forms.TabPage();
			this.schemesColorEditorControl = new ZetaColorEditor.Runtime.InternalControls.SchemesColorEditorUserControl();
			this.tabPagesImageList = new System.Windows.Forms.ImageList( this.components );
			this.tabControl.SuspendLayout();
			this.customColorsTabPage.SuspendLayout();
			this.webColorsTabPage.SuspendLayout();
			this.browserSafeColorsTabPage.SuspendLayout();
			this.systemColorsTabPage.SuspendLayout();
			this.schemeColorsTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			resources.ApplyResources( this.tabControl, "tabControl" );
			this.tabControl.Controls.Add( this.customColorsTabPage );
			this.tabControl.Controls.Add( this.webColorsTabPage );
			this.tabControl.Controls.Add( this.browserSafeColorsTabPage );
			this.tabControl.Controls.Add( this.systemColorsTabPage );
			this.tabControl.Controls.Add( this.schemeColorsTabPage );
			this.tabControl.ImageList = this.tabPagesImageList;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler( this.tabControl_SelectedIndexChanged );
			// 
			// customColorsTabPage
			// 
			this.customColorsTabPage.Controls.Add( this.customColorEditorControl );
			resources.ApplyResources( this.customColorsTabPage, "customColorsTabPage" );
			this.customColorsTabPage.Name = "customColorsTabPage";
			this.customColorsTabPage.UseVisualStyleBackColor = true;
			// 
			// customColorEditorControl
			// 
			resources.ApplyResources( this.customColorEditorControl, "customColorEditorControl" );
			this.customColorEditorControl.Name = "customColorEditorControl";
			this.customColorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.customColorEditorControl.NeedUpdateUI += new System.EventHandler( this.customColorEditorControl_NeedUpdateUI );
			// 
			// webColorsTabPage
			// 
			this.webColorsTabPage.Controls.Add( this.webColorEditorControl );
			resources.ApplyResources( this.webColorsTabPage, "webColorsTabPage" );
			this.webColorsTabPage.Name = "webColorsTabPage";
			this.webColorsTabPage.UseVisualStyleBackColor = true;
			// 
			// webColorEditorControl
			// 
			resources.ApplyResources( this.webColorEditorControl, "webColorEditorControl" );
			this.webColorEditorControl.Name = "webColorEditorControl";
			this.webColorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.webColorEditorControl.NeedUpdateUI += new System.EventHandler( this.webColorEditorControl_NeedUpdateUI );
			// 
			// browserSafeColorsTabPage
			// 
			this.browserSafeColorsTabPage.Controls.Add( this.browserSafeColorEditorControl );
			resources.ApplyResources( this.browserSafeColorsTabPage, "browserSafeColorsTabPage" );
			this.browserSafeColorsTabPage.Name = "browserSafeColorsTabPage";
			this.browserSafeColorsTabPage.UseVisualStyleBackColor = true;
			// 
			// browserSafeColorEditorControl
			// 
			resources.ApplyResources( this.browserSafeColorEditorControl, "browserSafeColorEditorControl" );
			this.browserSafeColorEditorControl.Name = "browserSafeColorEditorControl";
			this.browserSafeColorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.browserSafeColorEditorControl.NeedUpdateUI += new System.EventHandler( this.browserSafeColorEditorControl_NeedUpdateUI );
			// 
			// systemColorsTabPage
			// 
			this.systemColorsTabPage.Controls.Add( this.systemColorEditorControl );
			resources.ApplyResources( this.systemColorsTabPage, "systemColorsTabPage" );
			this.systemColorsTabPage.Name = "systemColorsTabPage";
			this.systemColorsTabPage.UseVisualStyleBackColor = true;
			// 
			// systemColorEditorControl
			// 
			resources.ApplyResources( this.systemColorEditorControl, "systemColorEditorControl" );
			this.systemColorEditorControl.Name = "systemColorEditorControl";
			this.systemColorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.systemColorEditorControl.NeedUpdateUI += new System.EventHandler( this.systemColorEditorControl_NeedUpdateUI );
			// 
			// schemeColorsTabPage
			// 
			this.schemeColorsTabPage.Controls.Add( this.schemesColorEditorControl );
			resources.ApplyResources( this.schemeColorsTabPage, "schemeColorsTabPage" );
			this.schemeColorsTabPage.Name = "schemeColorsTabPage";
			this.schemeColorsTabPage.UseVisualStyleBackColor = true;
			// 
			// schemesColorEditorControl
			// 
			resources.ApplyResources( this.schemesColorEditorControl, "schemesColorEditorControl" );
			this.schemesColorEditorControl.Name = "schemesColorEditorControl";
			this.schemesColorEditorControl.SelectedColor = System.Drawing.Color.Empty;
			this.schemesColorEditorControl.NeedUpdateUI += new System.EventHandler( this.schemesColorEditorControl_NeedUpdateUI );
			// 
			// tabPagesImageList
			// 
			this.tabPagesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "tabPagesImageList.ImageStream" )));
			this.tabPagesImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.tabPagesImageList.Images.SetKeyName( 0, "colorwheel.png" );
			this.tabPagesImageList.Images.SetKeyName( 1, "brush1.png" );
			this.tabPagesImageList.Images.SetKeyName( 2, "window_colors.png" );
			this.tabPagesImageList.Images.SetKeyName( 3, "monitor_rgb.png" );
			this.tabPagesImageList.Images.SetKeyName( 4, "earth.png" );
			// 
			// ColorEditorUserControl
			// 
			resources.ApplyResources( this, "$this" );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.tabControl );
			this.MinimumSize = new System.Drawing.Size( 442, 398 );
			this.Name = "ColorEditorUserControl";
			this.Load += new System.EventHandler( this.colorEditorUserControl_Load );
			this.tabControl.ResumeLayout( false );
			this.customColorsTabPage.ResumeLayout( false );
			this.webColorsTabPage.ResumeLayout( false );
			this.browserSafeColorsTabPage.ResumeLayout( false );
			this.systemColorsTabPage.ResumeLayout( false );
			this.schemeColorsTabPage.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage customColorsTabPage;
		private System.Windows.Forms.TabPage webColorsTabPage;
		private System.Windows.Forms.TabPage systemColorsTabPage;
		private System.Windows.Forms.TabPage schemeColorsTabPage;
		private System.Windows.Forms.ImageList tabPagesImageList;
		private ZetaColorEditor.Runtime.InternalControls.CustomColorEditorUserControl customColorEditorControl;
		private ZetaColorEditor.Runtime.InternalControls.WebColorEditorUserControl webColorEditorControl;
		private ZetaColorEditor.Runtime.InternalControls.SystemColorEditorUserControl systemColorEditorControl;
		private ZetaColorEditor.Runtime.InternalControls.SchemesColorEditorUserControl schemesColorEditorControl;
		private System.Windows.Forms.TabPage browserSafeColorsTabPage;
		private ZetaColorEditor.Runtime.InternalControls.BrowserSafeColorEditorUserControl browserSafeColorEditorControl;
	}
}