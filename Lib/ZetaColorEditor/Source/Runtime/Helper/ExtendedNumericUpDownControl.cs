namespace ZetaColorEditor.Runtime.Helper
{
	using System;
	using System.Windows.Forms;

	public partial class ExtendedNumericUpDownControl :
		NumericUpDown
	{
		public ExtendedNumericUpDownControl()
		{
			InitializeComponent();

			if ( !DesignMode )
			{
				//				changeTimer.Start();
			}
		}

		//private decimal? _previousValue;

		private void changeTimer_Tick( object sender, EventArgs e )
		{
			//changeTimer.Stop();

			//if ( !_previousValue.HasValue || _previousValue != Value )
			//{
			//    _previousValue = Value;

			//    OnValueChangedByUser( EventArgs.Empty );
			//}

			//changeTimer.Start();
		}

		private void extendedNumericUpDownControl_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 )
			{
				OnValueChanged( EventArgs.Empty );
			}
		}
	}
}
