#region Usings

using System;
using System.Windows.Forms;

#endregion

namespace PartModellingUi.Views
{
    public sealed partial class MultiViewPresenter
    {
        #region Delegates

        public delegate void EventDelegate(object sender, EventArgs e);

        public delegate void MouseEventDelegate(object sender, MouseEventArgs e);

        #endregion

        public MouseEventDelegate OnMouseDownHandler;
        public MouseEventDelegate OnMouseMoveHandler;
        public MouseEventDelegate OnMouseUpHandler;
        public MouseEventDelegate OnMouseWheelHandler;

        public EventDelegate OnPaintEvent;
        public EventDelegate OnResizeEvent;

        #region IDisposable Members

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion

        public void PaintHandler(PaintEventArgs e)
        {
            //Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Normal, new EventDelegate(PaintEvent));
        }

        public void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (OnMouseDownHandler != null)
                OnMouseDownHandler(sender, e);
            //WorkItem.EventTopics[EventTopicNames.MouseDownEvent].Fire(this, e, WorkItem, PublicationScope.Descendants);
        }

        public void MouseUpHandler(object sender, MouseEventArgs e)
        {
            if (OnMouseUpHandler != null)
                OnMouseUpHandler(sender, e);
            //WorkItem.EventTopics[EventTopicNames.MouseUpEvent].Fire(this, e, WorkItem, PublicationScope.Descendants);
        }

        public void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (OnMouseMoveHandler != null)
                OnMouseMoveHandler(sender, e);
            //WorkItem.EventTopics[EventTopicNames.MouseMoveEvent].Fire(this, e, WorkItem, PublicationScope.Descendants);
        }

        public void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            if (OnMouseWheelHandler != null)
                OnMouseWheelHandler(sender, e);
            //WorkItem.EventTopics[EventTopicNames.MouseWheelEvent].Fire(this, e, WorkItem, PublicationScope.Descendants);
        }

        public void ResizeHandler(object sender, EventArgs e)
        {
            if (OnResizeEvent != null)
                OnResizeEvent(null, null);
        }


        private void PaintEvent()
        {
            if (OnPaintEvent != null)
                OnPaintEvent(null, null);
        }

        private void ResizeEvent()
        {
            if (OnResizeEvent != null)
                OnResizeEvent(null, null);
        }


        public void OnViewReady()
        {
            //throw new NotImplementedException();
        }
    }
}