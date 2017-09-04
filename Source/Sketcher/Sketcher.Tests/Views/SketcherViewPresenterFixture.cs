using System;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using NaroCAD.Sketcher;
using NUnit.Framework;

namespace NaroCAD.Sketcher.Views
{
    /// <summary>
    /// Summary description for SketcherViewPresenterTestFixture
    /// </summary>
    [TestFixture]
    public class SketcherViewPresenterTestFixture
    {
        public SketcherViewPresenterTestFixture()
        {
        }

    }

    class MockSketcherView : ISketcherView
    {
        public Control GetView()
        {
            return new Control();
        }
    }
}
