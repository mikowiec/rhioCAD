
using Naro.Infrastructure.Interface;
using Naro.Sketcher.Constants;
using OCNaroWrappers;

namespace Naro.Sketcher.Inputs
{
    public class View2dInput : InputBase
    {
        OCV2d_View _view;
        OCV2d_Viewer _viewer;

        public View2dInput(OCV2d_View view, OCV2d_Viewer viewer)
            : base(ActionNames.View2dInput)
		{
            _view = view;
            _viewer = viewer;
		}
        
		public override void OnConnect()
		{
            AddData(_view);
            AddData(_viewer);
		}
    }
}
