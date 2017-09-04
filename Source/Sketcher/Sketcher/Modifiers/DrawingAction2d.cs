
using System.Collections.Generic;
using Naro.Infrastructure.Interface;
using Naro.Infrastructure.Library.Geometry;
using Naro.Sketcher.Constants;
using OCNaroWrappers;
using TreeData.NaroData;

namespace Naro.Sketcher.Modifiers
{
    public class DrawingAction2d : HandlingAction2d
    {
        protected Document _document;
        protected Mouse3dPosition _occMousePosition;
        protected OCAIS2D_InteractiveContext Context2d { get; set; }
        protected List<OCgp_Pnt> _points = new List<OCgp_Pnt>();

        public DrawingAction2d(string name) : base (name)
        {
            RegisterInput(ActionNames.Document);
            RegisterInput(ActionNames.Context2d);
            RegisterInput(ActionNames.SolverDrawerPipe);
            RegisterInput(ActionNames.EditDetectionPipe);
        }

        /// <summary>
        /// Register additional inputs to the ones inherited from the base class.
        /// </summary>
        /// <param name="inputName"></param>
        /// <param name="data"></param>
        protected override void OnReceiveInputData(string inputName, object data)
        {
        	switch (inputName)
        	{
        		case ActionNames.Document:
                	_document = data as Document;
        			break;
        		case ActionNames.SolverDrawerPipe:
        			_occMousePosition = data as Mouse3dPosition;
        			break;        			
        		case ActionNames.Context2d:
        			Context2d = data as OCAIS2D_InteractiveContext;
        			break;
        		default:
                	base.OnReceiveInputData(inputName, data);
                	break;
            }
        }

        /// <summary>
        /// Adds a point to the point list
        /// </summary>
        /// <param name="point"></param>
        public void AddToPointList(OCgp_Pnt point)
        {
            // The point is added only if the list is empty or if it is different
            // than the previously added point (check for the two point coincidence)
            if (_points.Count == 0)
            {
                _points.Add(point);
            }
            else if (!_points[_points.Count - 1].IsEqual(point, OCPrecision.Confusion()))
            {
                _points.Add(point);
            }
        }
    }
}
