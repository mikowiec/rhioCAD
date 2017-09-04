#region License

/*
 * NaroCAD project
 * http://www.narocad.com
 * 
 * This project is released under GPL v2 License. 
 * Other project licenses are of their respective owners
 */

#endregion

#region Usings

using Naro.Infrastructure.Interface.GeomHelpers;
using OCNaroWrappers;

#endregion

namespace Naro.Infrastructure.Library.GeomHelpers
{
    public class RectangularHandle : MagicShape
    {
        private OCAIS_InteractiveContext _context;
        private OCAIS_Shape _handleShape;
        private const int boxEdge = 2;
        OCTopoDS_Shape _handleTopoShape;

        public RectangularHandle()
        {
             _handleTopoShape = new OCBRepPrimAPI_MakeBox(new OCgp_Pnt(0, 0, 0), boxEdge, boxEdge, boxEdge).Shape();
        }

        public override GeometryType ShapeType
        {
            get { return GeometryType.RectangularHandle; }
        }

        public override void Show(OCAIS_InteractiveContext context, double x, double y, double z, OCgp_Dir direction)
        {
            if (_handleShape != null)
            {
                context.Remove(_handleShape, false);
            }

            _context = context;

            _handleTopoShape.Location(GeomUtils.BuildTranslation(new Point3D(0, 0, 0), new Point3D(x,x,z)));
            _handleShape = new OCAIS_Shape(_handleTopoShape);
            OCAIS_Shape shape = null;
            _handleShape.DownCast(ref shape);
            if (shape != null)
            {
                shape.Set(_handleTopoShape);
                _handleShape.Redisplay(false);
            }
            //var drawer = _helperLine.Attributes();
            //drawer.SetLineAspect(new OCPrs3d_LineAspect(OCQuantity_NameOfColor.Quantity_NOC_GRAY70,
            //                                            OCAspect_TypeOfLine.Aspect_TOL_DOT, 0.5));
            //_helperLine.SetTransparency(0.8);
        }

        public override void Hide()
        {
            if (_handleShape != null)
                _context.Remove(_handleShape, false);
        }
    }
}
