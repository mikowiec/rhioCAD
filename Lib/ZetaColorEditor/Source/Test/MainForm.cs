namespace Test
{
	using System;
	using System.Diagnostics;
	using System.Windows.Forms;
	using ZetaColorEditor.Runtime;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

#if DEBUG
			ColorEditorForm.Test();
#endif
		}

		private void launchColorEditorButton_Click( object sender, EventArgs e )
		{
			using ( var form = new ColorEditorForm() )
			{
				// Must set the extender _first_, since it helps in lookup
				// of the selected color.
				form.ExternalColorEditorInformationProvider = new ExternalTestProvider();
				form.SelectedColor = colorPanel.BackColor;

				if ( form.ShowDialog( this ) == DialogResult.OK )
				{
					colorPanel.BackColor = form.SelectedColor;
				}
			}
		}

		private void mainForm_Load( object sender, EventArgs e )
		{
			propertyGrid.SelectedObject = new MyColor();
		}

		private void infoLinkLabel_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			Process.Start(@"http://www.zeta-producer.com");
		}
	}
}