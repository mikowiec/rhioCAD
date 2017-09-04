#region Usings

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ErrorReportCommon.Messages;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.WNT;
using NaroPipes.Actions;
using NaroSetup;
using NaroSetup.Pages.Rendering.Logic;

using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.UI.Views.Rendering
{
    public partial class RenderDialog : Form
    {
        private readonly ActionsGraph _actionsGraph;
        private readonly AISInteractiveContext _context;
        private readonly SortedDictionary<int, int> _shapeShaderMapping = new SortedDictionary<int, int>();
        private readonly V3dPerspectiveView _view;
        private readonly V3dViewer _viewer;
        private Point3D _at;
        private Section _defaultValues;
        private Document _document;
        private Point3D _eye;
        private double _fov;
        private int _renderHeight;
        private int _renderWidth;
        private List<Shader> _shaders = new List<Shader>();
        private Point3D _up;

        public RenderDialog(ActionsGraph actionsGraph, Document document)
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            _actionsGraph = actionsGraph;
            _document = document;

            Setup(ref _viewer, ref _context, ref _view, previewPanel);
            DocumentSetup();
            UpdateViewParams();

            ReadOptionsConfig();

            ShapeComboUpdate();
        }

        private void UpdateViewParams()
        {
            double x = 0, y = 0, z = 0;
            _view.Eye(ref x, ref y, ref z);
            _eye = new Point3D(x, y, z);
            _view.At(ref x, ref y, ref z);
            _at = new Point3D(x, y, z);
            _view.Up(ref x, ref y, ref z);
            _up = new Point3D(x, y, z);
        }

        private void DocumentSetup()
        {
            _document.DumpToXml("renderscene.nxml");
            _document = new Document();
            _document.Root.Set<LayerContainerInterpreter>();
            _document.Root.Set<DocumentContextInterpreter>().Context = _context;
            _document.LoadFromXml("renderscene.nxml");
            FitAll();
            //_view.Update();
        }

        private void FitAll()
        {
            _view.FitAll(0.01, false, true);
            _view.ZFitAll(1);
            ViewRedraw();
        }

        private void ShapeComboUpdate()
        {
            comboBox1.BeginUpdate();
            comboBox1.Items.Clear();
            foreach (var node in _document.Root.Children.Values)
            {
                var shapeInterpreter = node.Get<TopoDsShapeInterpreter>();
                var treeVisibilityInterpreter = node.Get<TreeViewVisibilityInterpreter>();

                if (shapeInterpreter == null || shapeInterpreter.Shape == null
                    || treeVisibilityInterpreter != null)
                {
                    continue;
                }

                var interpreter = node.Get<StringInterpreter>();
                if (interpreter != null)
                {
                    comboBox1.Items.Add(node.Index + " - " + interpreter.Value);
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            comboBox1.EndUpdate();
        }

        private void GlassButton2Click(object sender, EventArgs e)
        {
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            optionsSetup.ShowOptions(OptionSectionNames.RenderingPageTitle);
            optionsSetup.UpdatedValue += ReadOptionsConfig;
        }

        private void GlassButton1Click(object sender, EventArgs e)
        {
            DoRenderLogic();
            try
            {
                var proc = new Process
                               {
                                   StartInfo =
                                       {
                                           FileName = "sunflow.exe",
                                           Arguments = "-o render.png render.sc",
                                           WindowStyle = ProcessWindowStyle.Normal
                                       }
                               };
                proc.Start();
            }
            catch (Exception ex)
            {
                NaroMessage.Show(ex.Message);
                return;
            }
            Close();
            WriteOptionsConfig();
        }

        private void ReadOptionsConfig()
        {
            var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            _defaultValues = optionsSetup.UpdateSectionNode("Rendering");

            _renderWidth = _defaultValues.Node[0][0].Set<IntegerInterpreter>().Value;
            _renderHeight = _defaultValues.Node[0][1].Set<IntegerInterpreter>().Value;
            _fov = _defaultValues.Node[0][2].Set<RealInterpreter>().Value;

            widthTextBox.Text = _renderWidth.ToString();
            heightTextBox.Text = _renderHeight.ToString();
            fovTextBox.Text = _fov.ToString();

            UpdateShaderListFromConfig();
            FillShaderPopup();
        }

        private void WriteOptionsConfig()
        {
            try
            {
                _defaultValues.Node[0][0].Set<IntegerInterpreter>().Value = Convert.ToInt32(widthTextBox.Text);
            }
            catch
            {
            }
            try
            {
                _defaultValues.Node[0][1].Set<IntegerInterpreter>().Value = Convert.ToInt32(heightTextBox.Text);
            }
            catch
            {
            }
            try
            {
                _defaultValues.Node[0][2].Set<RealInterpreter>().Value = Convert.ToDouble(fovTextBox.Text);
            }
            catch
            {
            }
        }

        private void FillShaderPopup()
        {
            comboBox2.BeginUpdate();
            comboBox2.Items.Clear();
            foreach (var shader in _shaders)
                comboBox2.Items.Add(shader.Name);
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
            comboBox2.EndUpdate();
        }

        private void UpdateShaderListFromConfig()
        {
            var shaderNode = _defaultValues.Node[1];
            var shaderCount = shaderNode.Set<IntegerInterpreter>().Value;
            _shaders = new List<Shader>();
            for (var i = 0; i < shaderCount; i++)
            {
                var shader = new Shader(shaderNode[i][0].Set<StringInterpreter>().Value)
                                 {
                                     Definition = shaderNode[i][1].Set<StringInterpreter>().Value
                                 };
                _shaders.Add(shader);
            }
        }

        public static string ExtractInvariantPoint(Point3D point)
        {
            return String.Format("{0} {1} {2}", point.X, point.Y, point.Z);
        }

        private static string ExtractInvariantDouble(double value)
        {
            return String.Format("{0}", value);
        }

        private void DoRenderLogic()
        {
            UpdateViewParams();
            var renderedNodes = new List<Node>();
            for (var i = 0; i < comboBox1.Items.Count; i++)
            {
                var seltext = comboBox1.Items[i].ToString();
                var selIndex = seltext.Substring(0, seltext.IndexOf('-'));
                var position = Convert.ToInt32(selIndex);
                renderedNodes.Add(_document.Root.Children[position]);
            }

            ReadOptionsConfig();
            // create a writer and open the file
            TextWriter tw = new StreamWriter("render.sc");

            //Set camera coordinates
            tw.WriteLine("%% camera");

            tw.WriteLine();
            tw.WriteLine("camera {");
            tw.WriteLine("type pinhole");
            tw.WriteLine("   eye    {0}", ExtractInvariantPoint(_eye));
            tw.WriteLine("   target     {0}", ExtractInvariantPoint(_at));
            tw.WriteLine("   up    {0}", ExtractInvariantPoint(_up));
            tw.WriteLine("   fov    {0}", ExtractInvariantDouble(_fov));
            tw.WriteLine("   aspect 1");
            tw.WriteLine("}");

            //set attribute images
            tw.WriteLine("image {");
            tw.WriteLine("resolution {0} {1} ", _renderWidth, _renderHeight);
            tw.WriteLine("aa 0 2");
            tw.WriteLine("}");

            //Add light to scene
            tw.WriteLine("light {");
            tw.WriteLine("type sunsky");
            tw.WriteLine("up 0 1 0");
            tw.WriteLine("east 0 0 1");
            tw.WriteLine("sundir -1 1 -1");
            tw.WriteLine("turbidity 2");
            tw.WriteLine("samples 32");
            tw.WriteLine("}");

            tw.WriteLine("light {");
            tw.WriteLine("type sunsky");
            tw.WriteLine("up 0 1 0");
            tw.WriteLine("east 0 0 1");
            tw.WriteLine("sundir 1 1 -1");
            tw.WriteLine("turbidity 2");
            tw.WriteLine("samples 32");
            tw.WriteLine("}");

            tw.WriteLine("light {");
            tw.WriteLine("type sunsky");
            tw.WriteLine("up 0 1 0");
            tw.WriteLine("east 0 0 1");
            tw.WriteLine("sundir 1 -1 -1");
            tw.WriteLine("turbidity 2");
            tw.WriteLine("samples 32");
            tw.WriteLine("}");

            //Set rendering attributes
            tw.WriteLine("accel bih");
            tw.WriteLine("filter mitchell");
            tw.WriteLine("bucket 32 row");

            //Adding Naro shaders
            foreach (var shader in _shaders)
            {
                tw.WriteLine(shader.SunflowDescription);
            }
            foreach (var node in renderedNodes)
            {
                if (node.Set<TopoDsShapeInterpreter>().Shape == null)
                {
                    continue;
                }
                var shape = node.Set<TopoDsShapeInterpreter>().Shape;
                var renderShape = new RenderShape(shape);
                var shaderId = 0;
                if (_shapeShaderMapping.ContainsKey(node.Index))
                    shaderId = _shapeShaderMapping[node.Index];
                tw.WriteLine(renderShape.GenerateMesh(
                    _shaders[shaderId].Name,
                    node.Set<StringInterpreter>().Value));
            }
            // close the stream
            tw.Close();
        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(fovTextBox.Text))
                {
                    return;
                }
                _fov = Double.Parse(fovTextBox.Text);
                if (_fov > 1)
                {
                    _view.Angle = _fov/2/180*Math.PI;
                    _view.Update();
                    var optionsSetup = _actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
                    optionsSetup.UpdateSectionNode("Rendering").SetValue(2, _fov);
                }
            }
            catch
            {
            }
        }

        #region OCC Init

        private bool _mouseDown;

        /// <summary>
        ///   Initializes the OpenCascade views and assigns them View handles.
        /// </summary>
        private static void Setup(ref V3dViewer viewer,
                                  ref AISInteractiveContext context,
                                  ref V3dPerspectiveView view,
                                  Control control)
        {
            // Initialize the Device
            var device = new Graphic3dWNTGraphicDevice();

            // Create the V3d Viewer
            //QuantityColor color = new QuantityColor(70 / 255.0, 82 / 255.0, 102 / 255.0, QuantityTypeOfColor.Quantity_TOC_RGB);
            viewer = new V3dViewer(device, "Preview", "Render", 1000, V3dTypeOfOrientation.V3d_XposYnegZpos,
                                      QuantityNameOfColor.Quantity_NOC_GRAY30,
                                      V3dTypeOfVisualization.V3d_ZBUFFER, V3dTypeOfShadingModel.V3d_GOURAUD,
                                      V3dTypeOfUpdate.V3d_WAIT, true, true, V3dTypeOfSurfaceDetail.V3d_TEX_NONE);

            if (CreateLights(viewer))
            {
                viewer.SetLightOn();
            }

            // Create the Interactive Context
            context = new AISInteractiveContext(viewer);

            // Create an OpenCascade view for each visible Custom controls
            view = CreateView(device, viewer, control);

            SetVisualMode(context);
        }


        private static bool CreateLights(V3dViewer viewer)
        {
            new V3dAmbientLight(viewer, QuantityNameOfColor.Quantity_NOC_GRAY50);
            new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_XnegYnegZneg,
                                       QuantityNameOfColor.Quantity_NOC_GRAY75, false);
            new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Xpos,
                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Ypos,
                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            new V3dDirectionalLight(viewer, V3dTypeOfOrientation.V3d_Zpos,
                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
            return true;
        }

        private static V3dPerspectiveView CreateView(WNTGraphicDevice device,
                                                        V3dViewer viewer,
                                                        Control control)
        {
            // Assign to each Custom control an OpenCascade View

            var view = new V3dPerspectiveView(viewer);

            view.SetDegenerateModeOn();
            view.Transparency = true;

            view.SurfaceDetail = V3dTypeOfSurfaceDetail.V3d_TEX_ALL;

            // Attach to the OpenCascade view a Custom control

            //IntPtr attachedViewHandle = (attachedView as Form).Handle;
            var aWntWindow = new WNTWindow(device, control.Handle, QuantityNameOfColor.Quantity_NOC_MATRAGRAY);

            view.SetWindow(aWntWindow);
            view.TriedronDisplay(
                AspectTypeOfTriedronPosition.Aspect_TOTP_LEFT_LOWER,
                QuantityNameOfColor.Quantity_NOC_WHITE,
                0.02,
                V3dTypeOfVisualization.V3d_WIREFRAME);

            if (!aWntWindow.IsMapped)
                aWntWindow.Map();
            //view.SetAntialiasingOn();
            view.Redraw();
            view.MustBeResized();
            view.Reset(true);

            return view;
        }

        private static void SetVisualMode(AISInteractiveContext context)
        {
            context.SetDisplayMode(AISDisplayMode.AIS_Shaded, true);
        }

        private void PreviewPanelPaint(object sender, PaintEventArgs e)
        {
            ViewRedraw();
        }

        private void ViewRedraw()
        {
            _view.Redraw();
        }

        private void PreviewPanelResize(object sender, EventArgs e)
        {
            _view.MustBeResized();
        }


        private void PreviewPanelMouseDown(object sender, MouseEventArgs e)
        {
            _view.StartRotation(e.X, e.Y, 0.0);
            _mouseDown = true;
        }

        private void PreviewPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
                _view.Rotation(e.X, e.Y);
        }

        private void PreviewPanelMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = !checkBox1.Checked;
        }

        #endregion
    }
}