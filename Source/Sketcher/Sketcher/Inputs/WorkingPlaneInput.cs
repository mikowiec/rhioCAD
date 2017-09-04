
using Naro.Infrastructure.Interface;
using Naro.Sketcher.Constants;
using OCNaroWrappers;

namespace Naro.Sketcher.Inputs
{
    public class WorkingPlaneInput : InputBase
    {
        private OCgp_Ax2 _ax2;

        public WorkingPlaneInput(OCgp_Ax2 ax2) : base(ActionNames.WorkingPlaneInput)
        {
            _ax2 = ax2;
        }

        public void AddWorkingPlane(OCgp_Ax2 ax2)
        {
            _ax2 = ax2;
            AddData(_ax2);
        }

        public override void OnConnect()
        {
            AddData(_ax2);
        }
    }
}
