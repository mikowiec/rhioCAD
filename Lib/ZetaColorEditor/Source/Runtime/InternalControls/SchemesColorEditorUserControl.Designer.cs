namespace ZetaColorEditor.Runtime.InternalControls
{
	partial class SchemesColorEditorUserControl
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
			this.colorsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.schemesComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// colorsListView
			// 
			this.colorsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorsListView.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1} );
			this.colorsListView.FullRowSelect = true;
			this.colorsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.colorsListView.HideSelection = false;
			this.colorsListView.Location = new System.Drawing.Point( 0, 27 );
			this.colorsListView.MultiSelect = false;
			this.colorsListView.Name = "colorsListView";
			this.colorsListView.OwnerDraw = true;
			this.colorsListView.ShowGroups = false;
			this.colorsListView.ShowItemToolTips = true;
			this.colorsListView.Size = new System.Drawing.Size( 150, 123 );
			this.colorsListView.TabIndex = 1;
			this.colorsListView.UseCompatibleStateImageBehavior = false;
			this.colorsListView.View = System.Windows.Forms.View.Details;
			this.colorsListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler( this.colorsListView_DrawColumnHeader );
			this.colorsListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler( this.colorsListView_DrawItem );
			this.colorsListView.SelectedIndexChanged += new System.EventHandler( this.colorsListView_SelectedIndexChanged );
			this.colorsListView.SizeChanged += new System.EventHandler( this.colorsListView_SizeChanged );
			this.colorsListView.DoubleClick += new System.EventHandler( this.colorsListView_DoubleClick );
			this.colorsListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler( this.colorsListView_DrawSubItem );
			this.colorsListView.Click += new System.EventHandler( this.colorsListView_Click );
			// 
			// schemesComboBox
			// 
			this.schemesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.schemesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.schemesComboBox.FormattingEnabled = true;
			this.schemesComboBox.Location = new System.Drawing.Point( 0, 0 );
			this.schemesComboBox.MaxDropDownItems = 20;
			this.schemesComboBox.Name = "schemesComboBox";
			this.schemesComboBox.Size = new System.Drawing.Size( 150, 21 );
			this.schemesComboBox.TabIndex = 0;
			this.schemesComboBox.SelectedIndexChanged += new System.EventHandler( this.schemesComboBox_SelectedIndexChanged );
			// 
			// SchemesColorEditorUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.schemesComboBox );
			this.Controls.Add( this.colorsListView );
			this.Name = "SchemesColorEditorUserControl";
			this.Load += new System.EventHandler( this.schemesColorEditorUserControl_Load );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ListView colorsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox schemesComboBox;
	}
}
