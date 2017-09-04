using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Graphic3d;
using System.Reflection;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.WNT;

namespace OpenCascadeResearch
{
    public partial class Form1 : Form
    {
        private Int32 _xMin, _xMax, _yMin, _yMax;

        private Graphic3dWNTGraphicDevice device3d;
        
        private V3dViewer viewer3d;

        private AISInteractiveContext context3d;
        private V3dView view3d;
        OutputDebug _treeView = new OutputDebug();

        public Form1()
        {
            InitializeComponent();
            InitializeOpenCascade();

            LaunchTestCode();
        }

        #region Opencascade initialization

        /// <summary>
        /// Initializes the OpenCascade views and assigns them View handles.
        /// </summary>
        private void InitializeOpenCascade()
        {
            // Initialize the Devices
            device3d = new Graphic3dWNTGraphicDevice();

            // Create the V3d Viewer
            try
            {
                viewer3d = new V3dViewer(device3d, "Hello", "", 100, V3dTypeOfOrientation.V3d_XnegYpos, QuantityNameOfColor.Quantity_NOC_ALICEBLUE,
                    V3dTypeOfVisualization.V3d_ZBUFFER, V3dTypeOfShadingModel.V3d_GOURAUD, V3dTypeOfUpdate.V3d_WAIT, true, true, 
                    V3dTypeOfSurfaceDetail.V3d_TEX_ALL);
                // manual default
                Debug.Assert(viewer3d != null);
                if (CreateLights())
                    viewer3d.SetLightOn();
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
                throw;		//re-throw exception
            }
            // Create the 3D Interactive Context
            try
            {
                context3d = new AISInteractiveContext(this.viewer3d);
                Debug.Assert(context3d != null);
                if (context3d != null)
                {
                    //context3d.HilightColor = NameOfColor.Quantity_NOC_DARKSLATEGRAY;
                    //context3d.SelectionColor = NameOfColor.Quantity_NOC_WHITE;
                }
            }
            catch (Exception ex)
            {
                Debug.Assert(false, ex.Message);
                throw;			// re-throw exception
            }

            // create the 2D interactive context
            //try
            //{
            //    context2d = new AIS2D_InteractiveContext(this.viewer2d);
            //    Debug.Assert(context2d != null);
            //    if (context2d != null)
            //    {
            //        //context.HilightColor = NameOfColor.Quantity_NOC_DARKSLATEGRAY;
            //        //context.SelectionColor = NameOfColor.Quantity_NOC_WHITE;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.Assert(false, ex.Message);
            //    throw;			// re-throw exception
            //}

            // Create an OpenCascade view for each visible Custom controls
            CreateView3D();
            //CreateView2D();
            //SetVisualMode();

            //bool executeTemporaryCode = true;

            //if (executeTemporaryCode)
            //{
            // temporary code -------------------
            // Draw a box
            for (int i = 0; i < 500; i+=10)
            {
                var pnt = new gpPnt(i, i, i);
                //OCBRepPrimAPI_MakeBox box = new BRepPrimAPI_MakeBox(pnt, 100, 100, 100);
                var box = new BRepPrimAPIMakeBox(pnt, 50, 50, 50);
                var shape = new AISShape(box.Shape);
                context3d.Display(shape,false); // manual default
            }
            view3d.FitAll(0.01, false, true); // manual default
            // -----------------------------------
            //}

            // Build an XYZ axis trihedron and add it to Ocaf
            var coords = gp.ZOX;
            coords.Location = new gpPnt(0, 0, 0);
            var axis = new GeomAxis2Placement(coords);
            var trihedron = new AISTrihedron(axis) {Size = 200};
            context3d.Display(trihedron, false);
        }

        private bool CreateLights()
        {
            var ambientLight = new V3dAmbientLight(this.viewer3d, QuantityNameOfColor.Quantity_NOC_GRAY75);
            Debug.Assert(ambientLight != null);

            var directionalLight = new V3dDirectionalLight(this.viewer3d, V3dTypeOfOrientation.V3d_XnegYnegZneg, QuantityNameOfColor.Quantity_NOC_GRAY75, false);
            Debug.Assert(directionalLight != null);

            var directionalLight1 = new V3dDirectionalLight(this.viewer3d, V3dTypeOfOrientation.V3d_Xpos, QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight1 != null);
            var directionalLight2 = new V3dDirectionalLight(this.viewer3d, V3dTypeOfOrientation.V3d_Ypos, QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight2 != null);
            var directionalLight3 = new V3dDirectionalLight(this.viewer3d, V3dTypeOfOrientation.V3d_Zpos, QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            Debug.Assert(directionalLight3 != null);

            if ((ambientLight != null) && (directionalLight != null))
                return true;

            return false;
        }

        private bool CreateView3D()
        {
            if (viewer3d != null)
            {
                view3d = viewer3d.CreateView;
                    Debug.Assert(view3d != null);
                    if (view3d != null)
                    {
                        //view3d.SetDegenerateModeOn();
                        //view3d.SetTransparency(true);

                        //view3d.SetSurfaceDetail(OCV3d_TypeOfSurfaceDetail.V3d_TEX_ALL);

                        // Attach to the OpenCascade view a Custom control
                        Control control = ocView;// attachedView.GetView(i);
                        if (control != null)
                        {
                            //IntPtr attachedViewHandle = (attachedView as Form).Handle;
                            var aWNTWindow = new WNTWindow(device3d, control.Handle, QuantityNameOfColor.Quantity_NOC_MATRAGRAY); // manual default
                            Debug.Assert(aWNTWindow != null);
                            if (aWNTWindow != null)
                            {
                                view3d.Window =aWNTWindow;
                                view3d.TriedronDisplay(AspectTypeOfTriedronPosition.Aspect_TOTP_LEFT_LOWER, QuantityNameOfColor.Quantity_NOC_WHITE, 0.02, V3dTypeOfVisualization.V3d_WIREFRAME); // manual default

                                if (!aWNTWindow.IsMapped)
                                    aWNTWindow.Map();
                            }
                            view3d.Redraw();
                            view3d.MustBeResized();
                        }
                    }
                return true;
            }

            return false;
        }

        public void SetVisualMode()
        {
            if (context3d != null)
            {
                context3d.SetDisplayMode(AISDisplayMode.AIS_Shaded, true); // manual default
            }
        }

        //private void CreateView2D()
        //{
        //    WNT_Window aWNTWindow = new WNT_Window(device2d, this.Handle, Quantity_NameOfColor.Quantity_NOC_MATRAGRAY);
        //    //Standard_Integer w=1000, h=1000;
        //    //aWNTWindow->Size(w, h);
        //    if (!aWNTWindow.IsMapped()) 
        //        aWNTWindow.Map();

        //    WNT_WDriver aDriver = new WNT_WDriver(aWNTWindow);
        //    view2d = new V2d_View(aDriver, viewer2d, 0, 0, 50);
        //    view2d.Update();
        //}

        #endregion


        private void PaintHandler(object sender, PaintEventArgs e)
        {

        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            // Store the current mouse position
            //_xMin = e.X; _xMax = e.X;
            //_yMin = e.Y; _yMax = e.Y;
        }

        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            //context3d.MoveTo(e.X, e.Y, view3d);
        }

        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            //_xMax = e.X; _yMax = e.Y;
            //context3d.Select(true);
        }

        private void LaunchTestCode()
        {
            //context3d.UpdateCurrentViewer();
        }

        private void ocView_Paint(object sender, PaintEventArgs e)
        {
            if (viewer3d != null)
                viewer3d.Redraw();
            //if (view3d != null)
            //    view3d.Redraw();
        }

        
        Assembly _assembly;
        class MethodCallerContainer
        {
	        public Type type;
	        public MethodInfo mi;
        }
        
        List<MethodCallerContainer> _labelCandidates = 
        	new List<MethodCallerContainer>();

        private AISShape shape;

        private void ViewMouseDown(object sender, MouseEventArgs e)
        {
            // Store the current mouse position
            _xMin = e.X; _xMax = e.X;
            _yMin = e.Y; _yMax = e.Y;
        }

        private void ViewMouseUp(object sender, MouseEventArgs e)
        {
            _xMax = e.X; _yMax = e.Y;
            context3d.Select(true);
        }

        private void ViewMouseMove(object sender, MouseEventArgs e)
        {
            var pnt = new gpPnt(e.X + 10, e.Y + 20, 1);

            if (shape != null)
                context3d.Remove(shape, false);
            var box = new BRepPrimAPIMakeBox(pnt, 50, 50, 50);
            shape = new AISShape(box.Shape);
            context3d.Display(shape, true);

            //context3d.OpenLocalContext(true, true, false, false);
            //context3d.ActivateStandardMode(OCTopAbs_ShapeEnum.TopAbs_SOLID);
            context3d.MoveTo(e.X, e.Y, view3d);
            //context3d.CloseAllContexts(false);
        }
    }
}
