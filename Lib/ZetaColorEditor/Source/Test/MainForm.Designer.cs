namespace Test
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
			this.launchColorEditorButton = new System.Windows.Forms.Button();
			this.colorPanel = new System.Windows.Forms.Panel();
			this.propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.infoLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// launchColorEditorButton
			// 
			this.launchColorEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.launchColorEditorButton.Location = new System.Drawing.Point( 12, 12 );
			this.launchColorEditorButton.Name = "launchColorEditorButton";
			this.launchColorEditorButton.Size = new System.Drawing.Size( 415, 96 );
			this.launchColorEditorButton.TabIndex = 0;
			this.launchColorEditorButton.Text = "Launch color editor";
			this.launchColorEditorButton.UseVisualStyleBackColor = true;
			this.launchColorEditorButton.Click += new System.EventHandler( this.launchColorEditorButton_Click );
			// 
			// colorPanel
			// 
			this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorPanel.BackColor = System.Drawing.Color.FromArgb( ((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))) );
			this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorPanel.Location = new System.Drawing.Point( 12, 114 );
			this.colorPanel.Name = "colorPanel";
			this.colorPanel.Size = new System.Drawing.Size( 415, 54 );
			this.colorPanel.TabIndex = 1;
			// 
			// propertyGrid
			// 
			this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGrid.HelpVisible = false;
			this.propertyGrid.Location = new System.Drawing.Point( 12, 187 );
			this.propertyGrid.Name = "propertyGrid";
			this.propertyGrid.Size = new System.Drawing.Size( 415, 203 );
			this.propertyGrid.TabIndex = 2;
			this.propertyGrid.ToolbarVisible = false;
			// 
			// infoLinkLabel
			// 
			this.infoLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.infoLinkLabel.AutoSize = true;
			this.infoLinkLabel.Location = new System.Drawing.Point( 226, 399 );
			this.infoLinkLabel.Name = "infoLinkLabel";
			this.infoLinkLabel.Size = new System.Drawing.Size( 201, 13 );
			this.infoLinkLabel.TabIndex = 3;
			this.infoLinkLabel.TabStop = true;
			this.infoLinkLabel.Text = "Developed 2009 by zeta software GmbH";
			this.infoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.infoLinkLabel_LinkClicked );
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 439, 421 );
			this.Controls.Add( this.infoLinkLabel );
			this.Controls.Add( this.propertyGrid );
			this.Controls.Add( this.colorPanel );
			this.Controls.Add( this.launchColorEditorButton );
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size( 455, 457 );
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zeta Color Editor test form";
			this.Load += new System.EventHandler( this.mainForm_Load );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button launchColorEditorButton;
		private System.Windows.Forms.Panel colorPanel;
		private System.Windows.Forms.PropertyGrid propertyGrid;
		private System.Windows.Forms.LinkLabel infoLinkLabel;
	}
}

