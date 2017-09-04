#region Usings

using Naro.Infrastructure.Library.Actions.DocumentAction;
using NaroBasicPipes.Inputs;
using NaroConstants.Names;
using NaroCppCore.Occ.V3d;
using NaroPipes.Actions;
using NaroPipes.Constants;

using PartModellingLogic.UI.Views.Rendering;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class SunflowRender : DocumentActionBase
    {
        public SunflowRender() : base(ModifierNames.SunflowRender)
        {
        }

        private V3dView View { get; set; }
        private V3dViewer Viewer { get; set; }

        protected override void OnReceiveInputData(string inputName, DataPackage data)
        {
            switch (inputName)
            {
                case InputNames.View:
                    {
                        var viewItems = data.Get<ViewInput.Items>();
                        View = viewItems.View;
                        Viewer = viewItems.Viewer;
                    }
                    break;
                default:
                    base.OnReceiveInputData(inputName, data);
                    break;
            }
        }


        public override void OnActivate()
        {
            double eyeX = 0;
            double eyeY = 0;
            double eyeZ = 0;
            double atX = 0;
            double atY = 0;
            double atZ = 0;

            double upX = 0;
            double upY = 0;
            double upZ = 0;

            View.Eye(ref eyeX, ref eyeY, ref eyeZ);
            View.At(ref atX, ref atY, ref atZ);
            View.Up(ref upX, ref upY, ref upZ);
            var render = new RenderDialog(ActionsGraph, Document);
            render.ShowDialog();
            BackToNeutralModifier();
        }
    }
}