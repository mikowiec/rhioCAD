#region Usings

using System;
using System.Windows.Forms;
using Naro.Infrastructure.Interface.Views;
using Naro.Infrastructure.Interface.Views.Timers;
using PartModellingUi.Views;
using TreeData.Capabilities;

#endregion

namespace MetaActionFakesInterface.Stubs
{
    public class MultiViewStub : IOccContainerMultiView
    {
        public MultiViewStub(CapabilitiesCollection globalCapabitities)
        {
            ContextManager = new ContextMenuManager(globalCapabitities);
        }

        #region IOccContainerMultiView Members

        public LayoutTypes ViewLayout
        {
            get { return LayoutTypes.Single; }
            set { }
        }

        public Int32 VisibleViewCount
        {
            get { return 1; }
        }

        public Int32 TotalViewCount
        {
            get { return 1; }
        }

        public Control GetView(Int32 viewNumber)
        {
            return new Control();
        }

        public Control GetActiveView()
        {
            return new Control();
        }

        public Int32 GetActiveViewNumber()
        {
            return 0;
        }

        public void LayoutSplit(LayoutTypes newLayoutView)
        {
        }

        public bool ActiveControlFocused()
        {
            return true;
        }

        public IContextMenuManager ContextManager { get; set; }

        #endregion

        public TimerTaskManager GetTimer()
        {
            return null;
        }
    }
}