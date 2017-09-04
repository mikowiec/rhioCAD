#region Usings

using System;
using System.Diagnostics;
using System.Windows.Forms;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.WNT;

#endregion

namespace Naro.PartModeling
{
    public static class OccInitialize
    {
        /// <summary>
        ///   Initializes the OpenCascade views and assigns them View handles.
        /// </summary>
        public static void Setup(ref Graphic3dWNTGraphicDevice device,
                                 ref V3dViewer viewer,
                                 ref AISInteractiveContext context,
                                 out V3dView view,
                                 Control attachedView)
        {
            // Initialize the Device
            try
            {
                device = new Graphic3dWNTGraphicDevice();
                Debug.Assert(device != null);
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
            }

            // Create the V3d Viewer
            try
            {
                //Quantity_Color color = new Quantity_Color(70 / 255.0, 82 / 255.0, 102 / 255.0, Quantity_TypeOfColor.Quantity_T_RGB);
                viewer = new V3dViewer(device, "Visu3D", "", 1000, V3dTypeOfOrientation.V3d_XposYnegZpos,
                                          QuantityNameOfColor.Quantity_NOC_GRAY30,
                                          V3dTypeOfVisualization.V3d_ZBUFFER, V3dTypeOfShadingModel.V3d_GOURAUD,
                                          V3dTypeOfUpdate.V3d_WAIT, true, true,
                                          V3dTypeOfSurfaceDetail.V3d_TEX_NONE);

                Debug.Assert(viewer != null);
                if (CreateLights(viewer))
                    viewer.SetLightOn();
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
            }

            // Create the Interactive Context
            try
            {
                context = new AISInteractiveContext(viewer);
                Debug.Assert(context != null);
                context.HilightColor =  QuantityNameOfColor.Quantity_NOC_RED;
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
            }

            // Create an OpenCascade view for each visible Custom controls
            CreateView(device, viewer, out view, attachedView);

            //PaintBackground(view, Color.LightBlue, Color.Blue);

            SetVisualMode(context);
        }

        private static bool CreateLights(V3dViewer viewer)
        {
            var ambientLight = new V3dAmbientLight(viewer, QuantityNameOfColor.Quantity_NOC_GRAY50);
            Debug.Assert(ambientLight != null);

            var directionalLight = new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_XnegYnegZneg,
                                                              QuantityNameOfColor.Quantity_NOC_GRAY75, false);
            Debug.Assert(directionalLight != null);

            var directionalLight1 = new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Xpos,
                                                               QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight1 != null);
            var directionalLight2 = new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Ypos,
                                                               QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight2 != null);
            var directionalLight3 = new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Zpos,
                                                               QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight3 != null);

            return true;
        }

        private static void CreateView(WNTGraphicDevice device, V3dViewer viewer, out V3dView view,
                                       Control attachedView)
        {
            // Assign to each Custom control an OpenCascade View

            view = null;
            for (var i = 0; i < 1; i++)
            {
                view = viewer.CreateView;
                Debug.Assert(view != null);
                view.SetDegenerateModeOn();
                view.Transparency = true;

                view.SurfaceDetail = V3dTypeOfSurfaceDetail.V3d_TEX_ALL;

                // Attach to the OpenCascade view a Custom control
                var control = attachedView;
                if (control == null) continue;
                //IntPtr attachedViewHandle = (attachedView as Form).Handle;
                var aWntWindow = new WNTWindow(device, control.Handle, QuantityNameOfColor.Quantity_NOC_MATRAGRAY);
                Debug.Assert(aWntWindow != null);

               // view.Window = aWntWindow;
                view.TriedronDisplay(AspectTypeOfTriedronPosition.Aspect_TOTP_LEFT_LOWER,
                                        QuantityNameOfColor.Quantity_NOC_WHITE, 0.02,
                                        V3dTypeOfVisualization.V3d_WIREFRAME);

                if (!aWntWindow.IsMapped)
                    aWntWindow.Map();
                //view[i].SetAntialiasingOn();
                //view[i].Redraw();
                view.MustBeResized();
            }
        }

        private static void SetVisualMode(AISInteractiveContext context)
        {
            if (context == null) return;
            context.SetDisplayMode(AISDisplayMode.AIS_Shaded, true);
        }
    }
}