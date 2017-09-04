#region Usings

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

#endregion

namespace PartModellingUi.Views
{
    /// <summary>
    ///   Interaction logic for NotificationWindow.xaml
    /// </summary>
    public partial class NotificationWindow
    {
        public NotificationWindow(List<string> strings)
        {
            InitializeComponent();

            Title = strings[0];
            FirstRow.Text = strings[1];
            SecondRow.Text = strings[2];

            Left = SystemParameters.WorkArea.Width - Width;
            Top = SystemParameters.WorkArea.Height - Height;

            var timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}