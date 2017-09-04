using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using NaroCAD.PartModeling;
using NUnit.Framework;

namespace NaroCAD.PartModeling.Views
{
    /// <summary>
    /// Summary description for MultiViewPresenterTestFixture
    /// </summary>
    [TestFixture]
    public class MultiViewPresenterTestFixture
    {
        public MultiViewPresenterTestFixture()
        {
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
    }

    class MockMultiView : IMultiView
    {
        private LayoutTypes viewLayout = LayoutTypes.Single;

        public LayoutTypes ViewLayout
        {
            get
            {
                return viewLayout;
            }
            set
            {
                viewLayout = value;
            }
        }

        public Int32 ViewCount
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns a handle to one of the four controls displayed on the form.
        /// </summary>
        /// <param name="viewNumber">The number of the custom control to which the handle is needed.</param>
        /// <returns></returns>
        public Control GetView(Int32 viewNumber)
        {
            return null;
        }

        /// <summary>
        /// Returns the View currently selected.
        /// </summary>
        /// <returns></returns>
        public Control GetActiveView()
        {
            return null;
        }

        public Int32 GetActiveViewNumber()
        {
            return 0;
        }

        public void LayoutSplit(LayoutTypes newLayoutView)
        {
        }
    }
}

