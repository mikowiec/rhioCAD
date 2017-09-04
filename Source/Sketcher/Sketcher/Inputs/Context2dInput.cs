
using Naro.Infrastructure.Interface;
using Naro.Sketcher.Constants;
using OCNaroWrappers;

namespace Naro.Sketcher.Inputs
{
    public class Context2dInput : InputBase
    {
        private OCAIS2D_InteractiveContext _context2d;

        public Context2dInput(OCAIS2D_InteractiveContext context2d)
            : base(ActionNames.Context2d)
        {
            _context2d = context2d;
        }

        public override void OnConnect()
        {
            AddData(_context2d);
        }
    }
}
