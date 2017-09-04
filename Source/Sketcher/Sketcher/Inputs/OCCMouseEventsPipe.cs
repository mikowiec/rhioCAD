
using System;
using log4net;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using OCNaroWrappers;

namespace Naro.Sketcher.Inputs
{
    /// <summary>
    /// Pipe that receives as input mouse coordinates (screen coordinates) and generates
    /// as output space coordinates (OCC coordinates).
    /// </summary>
    public class OCCMouseEventsPipe : PipeBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(OCCMouseEventsPipe));

        private OCV2d_View _view2d;
        private OCV2d_Viewer _viewer2d;
        private bool _mouseDown = false;

        public OCCMouseEventsPipe(OCV2d_View view, OCV2d_Viewer viewer)
            : base(ActionNames.OCCMouseCoordinates)
        {
            _view2d = view;
            _viewer2d = viewer;
        }

        protected override void SourceOnData(object data)
        {
            var mouseData = data as MouseEventData;

            // Convert screen coordinates to space coordinates
            Double x = 0, y = 0;
            GeomUtils.TranslateCoordinatesToOCC(_view2d, _viewer2d, mouseData.X, mouseData.Y, ref x, ref y);

            // Notify the listeners that a new OCC coordinate wad generated
            AddData(new Mouse3dPosition(new OCgp_Pnt(x, y, 0), mouseData.MouseDown));

            // Logs the coordinates where a mouse down/up event is generated
            if (_mouseDown != mouseData.MouseDown)
            {
                log.DebugFormat("OCCMouseEventsPipe x:{0} y:{1} z:{2} mouse down:{3}", x, y, 0, mouseData.MouseDown);
                _mouseDown = mouseData.MouseDown;
            }
        }
    }
}
