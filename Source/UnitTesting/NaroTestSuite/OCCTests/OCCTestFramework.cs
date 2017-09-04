#region Usings

using NUnit.Framework;

#endregion

namespace NaroTestSuite.OCCTests
{
    [TestFixture]
    public class OccTestFramework
    {
        //private Graphic3dWNTGraphicDevice _device3D;
        //private OCWNT_GraphicDevice _device2D;
        //private V3dViewer _viewer3D;
        //private AISInteractiveContext _context3D;
        //private V3dView _view3D;
        //private OCCTestForm _testForm3D;

        //private void SetUp()
        //{
        //    if (_testForm3D != null)
        //        return;

        //    _testForm3D = new OCCTestForm();

        //    _testForm3D.Show();

        //    InitializeOpenCascade();

        //    DefaultFunctions.Setup();
        //}

        ///// <summary>
        /////   Counts the GDI Objects and handles created by the graphic objects trying to detect leaks.
        /////   Tests repeated displaying and removing from display.
        ///// </summary>
        //[Test]
        //public void GdiCountSimpleTest()
        //{
        //    SetUp();

        //    var currentProcess = Process.GetCurrentProcess();

        //    // Get the handle count and the GDI count
        //    long initialHandles = currentProcess.HandleCount;
        //    long initialGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    // Check the handles and gdi count when displaying shapes
        //    AISInteractiveObject interactive = null;
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        if (interactive != null)
        //        {
        //            _context3D.Remove(interactive, true);
        //        }

        //        var shape = new BRepPrimAPIMakeBox(200.0, 150.0, 100.0).Shape();
        //        interactive = new AISShape(shape);
        //        _context3D.Display(interactive, true);
        //    }

        //    //
        //    long firstTestHandles = currentProcess.HandleCount;
        //    long firstTestGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    Assert.IsTrue(initialHandles == firstTestHandles, "Handles leaking");
        //    Assert.IsTrue((firstTestGdiObjects - initialGdiObjects) <= 10, "Gdi objects leaking");

        //    _context3D.RemoveAll(true);
        //}

        ///// <summary>
        /////   Counts the GDI Objects and handles created by the graphic objects trying to detect leaks.
        /////   The test creates a node containing a rectangle. The rectangle is dsplayed and then
        /////   selected and unselected repeateadely.
        ///// </summary>
        //[Test]
        //public void GdiCountInterpreterTest()
        //{
        //    SetUp();

        //    var currentProcess = Process.GetCurrentProcess();

        //    // Get the handle count and the GDI count
        //    long initialHandles = currentProcess.HandleCount;
        //    long initialGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    // Build a node that contains in the NamedShpe attribute a rectangle
        //    var ocafDocument = new Document();

        //    ocafDocument.Root.Set<StringInterpreter>().Value = "New Part";
        //    ocafDocument.Root.Set<DocumentContextInterpreter>().Context = _context3D;

        //    var rootLabel = ocafDocument.Root;

        //    var rectangle = Helpers.AddRectangleToTree(rootLabel, new gpPnt(0, 0, 0), new gpPnt(0, 0, 100),
        //                                               new gpPnt(100, 0, 0), true);

        //    var interpreter = rectangle.Get<NamedShapeInterpreter>();
        //    bool highlighted = false;

        //    // Display the rectangle built
        //    _context3D.Display(interpreter.Interactive, true);

        //    // Select and unselect the rectangle
        //    for (var i = 0; i < 1000; i++)
        //    {
        //        if (highlighted == false)
        //        {
        //            var interactiveObject = interpreter.Interactive;
        //            if (interactiveObject != null)
        //            {
        //                var status = _context3D.DisplayStatus(interactiveObject);
        //                //if (status == AISDisplayStatus.AIS_DS_Displayed)
        //                {
        //                    //_context3d.SetSelected(interactiveObject, true);
        //                    _context3D.SetCurrentObject(interactiveObject, true);
        //                    _context3D.SetSelectedCurrent();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            _context3D.ClearSelected(true);
        //        }

        //        highlighted = !highlighted;
        //    }

        //    // Get the counts after the execution
        //    long firstTestHandles = currentProcess.HandleCount;
        //    long firstTestGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    Assert.IsTrue(initialHandles == firstTestHandles, "Handles leaking");
        //    Assert.IsTrue((firstTestGdiObjects - initialGdiObjects) <= 10, "Gdi objects leaking");

        //    _context3D.RemoveAll(true);
        //}

        ///// <summary>
        /////   Tests is the context.MoveTo() generates Gdi leaks
        ///// </summary>
        //[Test]
        //public void MoveToGdiTests()
        //{
        //    SetUp();

        //    var currentProcess = Process.GetCurrentProcess();

        //    // Get the handle count and the GDI count
        //    long initialHandles = currentProcess.HandleCount;
        //    long initialGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    // Build a node that contains in the NamedShpe attribute a rectangle
        //    var ocafDocument = new Document();

        //    ocafDocument.Root.Set<StringInterpreter>().Value = "New Part";
        //    ocafDocument.Root.Set<DocumentContextInterpreter>().Context = _context3D;

        //    var rootLabel = ocafDocument.Root;

        //    var rectangle = Helpers.AddRectangleToTree(rootLabel, new gpPnt(0, 0, 0), new gpPnt(0, 0, 1000),
        //                                               new gpPnt(1000, 0, 0), true);

        //    var interpreter = rectangle.Get<NamedShapeInterpreter>();

        //    // Display the rectangle built
        //    _context3D.Display(interpreter.Interactive, true);

        //    // Select and unselect the rectangle
        //    for (int j = 0; j < 100; j++)
        //    {
        //        for (int i = 200; i < 600; i++)
        //        {
        //            _context3D.MoveTo(i, i - 100, _view3D);
        //            _context3D.Select(true);
        //        }
        //    }

        //    // Get the counts after the execution
        //    long firstTestHandles = currentProcess.HandleCount;
        //    long firstTestGdiObjects = Helpers.GetGuiResourcesGdiCount();

        //    Assert.IsTrue(initialHandles == firstTestHandles, "Handles leaking");
        //    Assert.IsTrue((firstTestGdiObjects - initialGdiObjects) <= 10, "Gdi objects leaking");

        //    _context3D.RemoveAll(true);
        //}

        ////[Test]
        //public void STEPLoadingTest()
        //{
        //    SetUp();

        //    // Load a STEP file and display it
        //    var aReader = new OCSTEPControl_Reader();
        //    var fileName = @"c:\screw.step";
        //    var status = aReader.ReadFile(fileName);

        //    Assert.IsTrue(status == OCIFSelect_ReturnStatus.IFSelect_RetDone, "Invalid return status");

        //    aReader.WS().MapReader().SetTraceLevel(2); // increase default trace level

        //    var failsonly = false;
        //    aReader.PrintCheckLoad(failsonly, OCIFSelect_PrintCount.IFSelect_ItemsByEntity);

        //    // Root transfers
        //    int nbr = aReader.NbRootsForTransfer();
        //    aReader.PrintCheckTransfer(failsonly, OCIFSelect_PrintCount.IFSelect_ItemsByEntity);
        //    for (int n = 1; n <= nbr; n++)
        //    {
        //        bool ok = aReader.TransferRoot(n);
        //    }

        //    // Collecting resulting entities
        //    int nbs = aReader.NbShapes();
        //    Assert.IsTrue(nbs > 0, "no shapes loaded");

        //    var aSequence = new TopToolsHSequenceOfShape();
        //    for (int i = 1; i <= nbs; i++)
        //    {
        //        aSequence.Append(aReader.Shape(i));
        //    }

        //    for (int i = 1; i <= aSequence.Length(); i++)
        //    {
        //        AISShape aisShape = new AISShape(aSequence.Value(i));
        //        _context3D.SetDisplayMode(aisShape, 1, false);
        //        _context3D.Display(aisShape, false);
        //        _context3D.SetCurrentObject(aisShape, false);
        //    }
        //    _context3D.UpdateCurrentViewer();
        //    _view3D.FitAll(0.01, false, true);

        //    Thread.Sleep(10000);
        //    _context3D.RemoveAll(true);

        //    var aWriter = new OCSTEPControl_Writer();

        //    for (int i = 1; i <= aSequence.Length(); i++)
        //    {
        //        status = aWriter.Transfer(aSequence.Value(i),
        //                                  OCSTEPControl_StepModelType.STEPControl_ShellBasedSurfaceModel, true);
        //        Assert.IsTrue(status == OCIFSelect_ReturnStatus.IFSelect_RetDone, "Invalid return status");
        //    }

        //    var outputFileName = @"c:\test.step";
        //    status = aWriter.Write(outputFileName);

        //    Assert.IsTrue(status == OCIFSelect_ReturnStatus.IFSelect_RetDone, "Invalid return status");
        //}

        //#region Opencascade initialization

        ///// <summary>
        /////   Initializes the OpenCascade views and assigns them View handles.
        ///// </summary>
        //private void InitializeOpenCascade()
        //{
        //    // Initialize the Devices
        //    try
        //    {
        //        _device3D = new Graphic3dWNTGraphicDevice();
        //        Debug.Assert(_device3D != null);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Assert(false, ex.Message);
        //        throw;
        //    }

        //    try
        //    {
        //        _device2D = new OCWNT_GraphicDevice(false, 0);
        //        Debug.Assert(_device2D != null);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Assert(false, ex.Message);
        //        throw;
        //    }

        //    // Create the V3d Viewer
        //    try
        //    {
        //        _viewer3D = new V3dViewer(_device3D, "Visu3D", "", 1000, V3dTypeOfOrientation.V3d_XposYnegZpos,
        //                                     QuantityNameOfColor.Quantity_NOC_GRAY30,
        //                                     V3dTypeOfVisualization.V3d_ZBUFFER, V3dTypeOfShadingModel.V3d_GOURAUD,
        //                                     V3dTypeOfUpdate.V3d_WAIT, true, true,
        //                                     V3dTypeOfSurfaceDetail.V3d_TEX_NONE);
        //        // manual default
        //        Debug.Assert(_viewer3D != null);
        //        if (_viewer3D != null)
        //        {
        //            if (CreateLights())
        //                _viewer3D.SetLightOn();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Assert(false, ex.Message);
        //        throw; //re-throw exception
        //    }

        //    // Create the 3D Interactive Context
        //    try
        //    {
        //        _context3D = new AISInteractiveContext(_viewer3D);
        //        Debug.Assert(_context3D != null);
        //        if (_context3D != null)
        //        {
        //            //_context3d.HilightColor = NameOfColor.Quantity_NOC_DARKSLATEGRAY;
        //            //_context3d.SelectionColor = NameOfColor.Quantity_NOC_WHITE;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.Assert(false, ex.Message);
        //        throw;
        //    }

        //    // Create an OpenCascade view for each test
        //    Create_view3d();
        //    SetVisualMode();

        //    // Build an XYZ axis trihedron and add it to the 3d view
        //    gpAx2 coords = gp.ZOX();
        //    coords.SetLocation(new gpPnt(0, 0, 0));
        //    GeomAxis2Placement axis = new GeomAxis2Placement(coords);
        //    AISTrihedron trihedron = new AISTrihedron(axis);
        //    trihedron.SetSize(200);

        //    _context3D.Display(trihedron, false);
        //}

        //private bool CreateLights()
        //{
        //    var ambientLight = new V3dAmbientLight(_viewer3D, QuantityNameOfColor.Quantity_NOC_GRAY75);
        //    Debug.Assert(ambientLight != null);

        //    var directionalLight = new V3dDirectionalLight(_viewer3D, V3dTypeOfOrientation.V3d_XnegYnegZneg,
        //                                                      QuantityNameOfColor.Quantity_NOC_GRAY75, false);
        //    Debug.Assert(directionalLight != null);

        //    var directionalLight1 = new V3dDirectionalLight(_viewer3D, V3dTypeOfOrientation.V3d_Xpos,
        //                                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
        //    Debug.Assert(directionalLight1 != null);
        //    var directionalLight2 = new V3dDirectionalLight(_viewer3D, V3dTypeOfOrientation.V3d_Ypos,
        //                                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
        //    Debug.Assert(directionalLight2 != null);
        //    var directionalLight3 = new V3dDirectionalLight(_viewer3D, V3dTypeOfOrientation.V3d_Zpos,
        //                                                       QuantityNameOfColor.Quantity_NOC_GRAY25, false);
        //    Debug.Assert(directionalLight3 != null);

        //    return true;
        //}

        //private bool Create_view3d()
        //{
        //    if (_viewer3D != null)
        //    {
        //        _view3D = _viewer3D.CreateView();
        //        Debug.Assert(_view3D != null);
        //        if (_view3D != null)
        //        {
        //            _view3D.SetDegenerateModeOn();
        //            _view3D.SetTransparency(true);

        //            _view3D.SetSurfaceDetail(V3dTypeOfSurfaceDetail.V3d_TEX_ALL);

        //            {
        //                IntPtr attachedViewHandle = _testForm3D.Handle;
        //                OCWNT_Window aWNTWindow = new OCWNT_Window(_device3D, attachedViewHandle,
        //                                                           QuantityNameOfColor.Quantity_NOC_MATRAGRAY);
        //                Debug.Assert(aWNTWindow != null);
        //                if (aWNTWindow != null)
        //                {
        //                    _view3D.SetWindow(aWNTWindow);
        //                    _view3D.TriedronDisplay(AspectTypeOfTriedronPosition.Aspect_TOTP_LEFT_LOWER,
        //                                            QuantityNameOfColor.Quantity_NOC_WHITE, 0.02,
        //                                            V3dTypeOfVisualization.V3d_WIREFRAME); // manual default

        //                    if (!aWNTWindow.IsMapped())
        //                        aWNTWindow.Map();
        //                }
        //                _view3D.Redraw();
        //                _view3D.MustBeResized();
        //            }
        //        }
        //        return true;
        //    }

        //    return false;
        //}

        //public void SetVisualMode()
        //{
        //    if (_context3D != null)
        //    {
        //        _context3D.SetDisplayMode(AISDisplayMode.AIS_Shaded, true);
        //    }
        //}

        //#endregion
    }
}