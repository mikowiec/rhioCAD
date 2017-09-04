#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BooEvaluator.Boo;
using TreeData.AttributeInterpreter;

#endregion

namespace PropertyGridTabItems
{
    /// <summary>
    ///   Interaction logic for Point3DTemplate.xaml
    /// </summary>
    public partial class Point3DTemplate
    {
        #region Delegates

        public delegate void OnChangeValue();

        #endregion

        public OnChangeValue ChangeValueEvent;

        public Point3DTemplate()
        {
            InitializeComponent();
        }

        public Point3D Value
        {
            get
            {
                var x = TextBoxValue(textBoxX);
                var y = TextBoxValue(textBoxY);
                var z = TextBoxValue(textBoxZ);
                return new Point3D(x, y, z);
            }
            set
            {
                textBoxX.Text = String.Format("{0:0.##}", value.X);
                textBoxY.Text = String.Format("{0:0.##}", value.Y);
                textBoxZ.Text = String.Format("{0:0.##}", value.Z);
            }
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
          //  ApplyValue();
        }

        private static double TextBoxValue(TextBox textBox)
        {
            try
            {
                return BooEval.GetDouble(textBox.Text);
            }
            catch (Exception)
            {
                return 0.0;
            }
        }

        public void OnFocus()
        {
            textBoxX.Focus();
        }

        private void OnEnterDoChangeEvent(KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
                return;
            ApplyValue();
        }

        private void ApplyValue()
        {
            if (ChangeValueEvent == null)
                return;
            ChangeValueEvent();
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            
            OnEnterDoChangeEvent(e);
        }
    }
}