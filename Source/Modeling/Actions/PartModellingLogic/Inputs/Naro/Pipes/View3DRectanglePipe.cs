#region Usings

using System;
using System.Drawing;
using System.Windows.Forms;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Actions;

#endregion

namespace PartModellingLogic.Inputs.Naro.Pipes
{
    public class View3DRectanglePipe : PipeBase
    {
        private Form _f;
        private bool _firstPoint = true;
        private bool _previousMouseDown;
        private int _xMin, _yMin;

        public View3DRectanglePipe(Control control)
            : base(InputNames.View3DRectanglePipe)
        {
            Window = control;
        }

        private Control Window { get; set; }

        public override void OnRegister()
        {
            DependsOn(InputNames.MouseEventsInput, SourceMouseHandle);
        }

        private void SourceMouseHandle(DataPackage mouseData)
        {
            var data = mouseData.Get<MouseEventData>();
            MouseEventHandler(data);
        }

        private void MouseEventHandler(MouseEventData mouseData)
        {
            if (mouseData.MouseDown != _previousMouseDown)
                OnMouseClick3DAction(mouseData);
            else
                OnMouseMove3DAction(mouseData);

            _previousMouseDown = mouseData.MouseDown;
        }

        /// <summary>
        ///   Receives click events. Called at mouse down and at mouse up.
        /// </summary>
        /// <param name = "mouseData"></param>
        private void OnMouseClick3DAction(MouseEventData mouseData)
        {
            // Filter mouse up events
            if (!mouseData.MouseDown)
                return;

            var coordinate = new Point(mouseData.X, mouseData.Y);

            UpdateCoordinate(coordinate);
        }

        private void UpdateCoordinate(Point coordinate)
        {
            if (_firstPoint)
            {
                _xMin = coordinate.X;
                _yMin = coordinate.Y;
                _firstPoint = false;
                return;
            }

            // We have two points
            var position = new RectanglePosition(_xMin, _yMin, coordinate.X, coordinate.Y);
            AddData(position);
            _firstPoint = true;
            SetupForm();
        }

        private static Point ToScreen(Control c, int x, int y)
        {
            return c.PointToScreen(new Point(x, y));
        }

        private static Point ToClient(Control c, int x, int y)
        {
            return c.PointToClient(new Point(x, y));
        }

        /// <summary>
        ///   Receives mouse move events. The mouse move can be made having a button pressed or not
        /// </summary>
        /// <param name = "mouseData"></param>
        private void OnMouseMove3DAction(MouseEventData mouseData)
        {
            // Clear the previous rectangle
            if (_firstPoint)
                return;

            var coordinate = new Point(mouseData.X, mouseData.Y);
            UpdateRectangleCoordinate(coordinate);
        }

        private void UpdateRectangleCoordinate(Point coordinate)
        {
            var x = Math.Min(_xMin, coordinate.X);
            var y = Math.Min(_yMin, coordinate.Y);
            var width = Math.Abs(_xMin - coordinate.X);
            var height = Math.Abs(_yMin - coordinate.Y);

            var screenPos = ToScreen(Window, x, y);

            _f.Left = screenPos.X;
            _f.Top = screenPos.Y;
            _f.Width = width;
            _f.Height = height;
            _f.Show();
        }

        private void SetupForm()
        {
            if (_f != null)
                _f.Dispose();
            _f = new Form
                     {
                         FormBorderStyle = FormBorderStyle.None,
                         Opacity = 0.3,
                         ShowInTaskbar = false,
                         ShowIcon = false
                     };
            _f.MouseMove += FMouseMove;
            _f.MouseUp += FMouseUp;
            _f.Paint += FPaint;
        }

        private void FMouseUp(object sender, MouseEventArgs e)
        {
            var point = new Point(e.X, e.Y);
            var clientCoordinate = GetClientCoordinate(point);
            UpdateCoordinate(clientCoordinate);
        }

        private static void FPaint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;
            gr.Clear(Color.DarkGray);
        }

        private void FMouseMove(object sender, MouseEventArgs e)
        {
            var point = new Point(e.X, e.Y);
            var clientCoordinate = GetClientCoordinate(point);
            UpdateRectangleCoordinate(clientCoordinate);
        }

        private Point GetClientCoordinate(Point point)
        {
            var screenCoordinate = ToScreen(_f, point.X, point.Y);
            return ToClient(Window, screenCoordinate.X, screenCoordinate.Y);
        }

        public override void OnConnect()
        {
            base.OnConnect();
            _firstPoint = true;
            SetupForm();
        }

        public override void OnDisconnect()
        {
            if (_f != null)
            {
                _f.Dispose();
                _f = null;
            }
            _firstPoint = false;
        }

        #region Nested type: RectanglePosition

        public class RectanglePosition
        {
            public RectanglePosition(int x1, int y1, int x2, int y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }

            public int X1 { get; private set; }
            public int Y1 { get; private set; }
            public int X2 { get; private set; }
            public int Y2 { get; private set; }
        }

        #endregion
    }
}