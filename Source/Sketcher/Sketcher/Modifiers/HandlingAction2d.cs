
using System.Collections.Generic;
using Naro.Infrastructure.Interface;
using Naro.Sketcher.Constants;
using Naro.Sketcher.Inputs;
using OCNaroWrappers;

namespace Naro.Sketcher.Modifiers
{
    public class HandlingAction2d : Action3d
    {
        protected OCV2d_View View2d { get; set; }
        protected OCV2d_Viewer Viewer2d { get; set; }

        public HandlingAction2d(string name)
            : base(name, new List<string>() { ActionNames.View2dInput})
        {
        }

        protected override void OnReceiveInputData(string inputName, object data)
        {
            if (inputName == ActionNames.View2dInput)
            {
                if (View2d == null)
                {
                    View2d = data as OCV2d_View;
                }
                else
                {
                    Viewer2d = data as OCV2d_Viewer;
                }
            }
        }
    }
}
