#region Usings



#endregion

using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Quantity;

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public class CustomTrihedron
    {
        private readonly GeomAxis2Placement _axisPlacement;
        private readonly AISInteractiveContext _context;
        private AISAxis _xAxis;
        private AISAxis _yAxis;
        private AISAxis _zAxis;

        public CustomTrihedron(GeomAxis2Placement axisPlacement, AISInteractiveContext context)
        {
            _context = context;
            _axisPlacement = axisPlacement;

            BuildAxis(axisPlacement);
        }

        private void BuildAxis(GeomAxis2Placement axisPlacement)
        {
            _xAxis = new AISAxis(axisPlacement, AISTypeOfAxis.AIS_TOAX_XAxis)
                         {
                             Width = 2
                         };
            _xAxis.SetColor(QuantityNameOfColor.Quantity_NOC_RED);
            _yAxis = new AISAxis(axisPlacement, AISTypeOfAxis.AIS_TOAX_YAxis)
                         {
                             Width = 2
                         };
            _yAxis.SetColor(QuantityNameOfColor.Quantity_NOC_GREEN);
            _zAxis = new AISAxis(axisPlacement, AISTypeOfAxis.AIS_TOAX_ZAxis)
                         {
                             Width = 2
                         };
            _zAxis.SetColor(QuantityNameOfColor.Quantity_NOC_BLUE1);
        }

        public void Show()
        {
            _context.Display(_xAxis, false);
            _context.Display(_yAxis, false);
            _context.Display(_zAxis, false);
        }

        public void Hide()
        {
            _context.Remove(_xAxis, false);
            _context.Remove(_yAxis, false);
            _context.Remove(_zAxis, false);
        }

        public void SetAxisLength(double length)
        {
            var xAisDrawer = _xAxis.Attributes;
            var xDatumAspect = xAisDrawer.DatumAspect;
            xDatumAspect.SetAxisLength(length, length, length);
            //xAisDrawer.DatumAspect = (xDatumAspect);
            _xAxis.SetAxis2Placement(_axisPlacement, AISTypeOfAxis.AIS_TOAX_XAxis);

            var yAisDrawer = _yAxis.Attributes;
            var yDatumAspect = yAisDrawer.DatumAspect;
            yDatumAspect.SetAxisLength(length, length, length);
         //   yAisDrawer.SetDatumAspect(yDatumAspect);
            _yAxis.SetAxis2Placement(_axisPlacement, AISTypeOfAxis.AIS_TOAX_YAxis);

            var zAisDrawer = _zAxis.Attributes;
            var zDatumAspect = zAisDrawer.DatumAspect;
            zDatumAspect.SetAxisLength(length, length, length);
         //   zAisDrawer.SetDatumAspect(zDatumAspect);
            _zAxis.SetAxis2Placement(_axisPlacement, AISTypeOfAxis.AIS_TOAX_ZAxis);
        }
    }
}