namespace NaroPipes.Constants
{
    public static class ModifierNames
    {
        public const string GuardPointFromMovingAction = "GuardPointFromMovingAction";
        public const string FourLinesRectangle = "FourLinesRectangle";
        public const string ThreePointsRectangle = "ThreePointsRectangle";
        public const string SketchConstraintMapper = "SketchConstraintMapper";
        public const string AddSelectedTool = "AddSelectedTool";


        //-----Sketch tab-----

        public const string Cursor = "Cursor";
        public const string Point3D = "Point3D";
        public const string RectangleTwoPoints = "RectangleTwoPoints";
       // public const string RectangleThreePoints = "RectangleThreePoints";
        public const string Parallelogram = "Parallelogram";
        public const string Line3D = "Line3D";
        public const string LineInPolylineMode = "LineInPolylineMode";
        public const string LinesSetAngle = "LinesSetAngle";
        public const string Polyline = "Polyline";
        public const string LineNormal = "LineNormal";
        public const string ParallelLine = "ParallelLine";
        public const string HorizontalLine = "HorizontalLine";
        public const string VerticalLine = "VerticalLine";
        public const string DrawCircle = "DrawCircle";
        public const string Ellipse = "Ellipse";
        public const string ArcCenterStartEnd = "Arc";
        public const string ArcStartEndRadius = "ArcStartEndRadius";
        public const string Dimension = "Dimension";

        public const string Trim = "Trim";

        public const string StartSketch = "StartSketch";
        public const string EndSketch = "EndSketch";

        // Spline
        public const string Spline = "Spline";
        public const string InterpolatedSpline = "InterpolatedSpline";
        public const string ControlPointSpline = "ControlPointSpline";
        public const string SplitSpline = "SplitSpline";
        public const string CombineSplines = "CombineSplines";

        //-----Solid tab-----

        public const string Box = "Box";
        public const string Sphere = "Sphere";
        public const string Cylinder = "Cylinder";
        public const string Cone = "Cone";
        public const string Torus = "Torus";

        //-----Features tab-----

        public const string Extrude = "Extrude";
        public const string Cut = "Cut";
        public const string Pipe = "Pipe";
        public const string Revolve = "Revolve";
        public const string Fillet = "Fillet";
        public const string Chamfer = "Chamfer";
        public const string Fillet2D = "Fillet2D";
        public const string Chamfer2D = "Chamfer2D";
        public const string Sew = "Sew";
        public const string AngleDraft = "AngleDraft";
        public const string AngleDraftEnhanced = "AngleDraftEnhanced";
        public const string CircularPattern = "CircularPattern";
        public const string ArrayPattern = "ArrayPattern";

        //-----Boolean tab-----

        public const string BooleanAdd = "BooleanAdd";
        public const string BooleanIntersect = "BooleanIntersect";
        public const string BooleanSubstract = "BooleanSubstract";

        //-----Tools tab-----

        public const string Translate = "Translate";
        public const string Copy = "Copy";
        public const string MeasureDistance = "MeasureDistance";
        public const string RotateAroundAxis = "RotateAroundAxis";
        public const string PatternLinearCircular = "PatternLinearCircular";
        public const string Offset = "Offset";
        public const string Offset3D = "Offset3D";
        public const string MirrorPoint = "MirrorPoint";
        public const string MirrorLine = "MirrorLine";
        public const string MirrorPlane = "MirrorPlane";

        //-----Orientation tab-----

        public const string Reset = "Reset";
        public const string Axo = "Axo";
        public const string Front = "Front";
        public const string Top = "Top";
        public const string Left = "Left";
        public const string Bottom = "Bottom";
        public const string Right = "Right";
        public const string Back = "Back";

        //-----View tab-----

        public const string ViewDynamicZooming = "ViewDynamicZooming";
        public const string ViewZoomWindow = "ViewZoomWindow";
        public const string FitAll = "FitAll";
        public const string ViewDynamicPanning = "ViewDynamicPanning";
        public const string ViewGlobalPanning = "ViewGlobalPanning";
        public const string DynamicRotation = "DynamicRotation";

        //-----Constraints tab-----

        public const string ConstraintShapeAction = "ConstraintShapeAction";
        public const string PointToPointConstraint = "PointToPointConstraint";
        public const string PointToEdgeConstraint = "PointToEdgeConstraint";

        //-----Auto Apply tab-----

        public const string CopyDeepTools = "CopyDeepTools";
        public const string SynchronizeToolValues = "SynchronizeToolValues";
        public const string ApplyOneToolOnAnother = "ApplyOneToolOnAnother";

        //-----Draw Area tab------
        public const string DefineDrawingPlane = "DefineDrawingPlane";

        public const string BlockPlane = "BlockPlane";
        public const string UnblockPlane = "UnblockPlane";

        //-----Other-----

        public const string NaroExit = "NaroExit";
        public const string NaroRestart = "NaroRestart";
        public const string EditingAction = "EditingAction";
        public const string NaroDocumentCut = "NaroDocumentCut";
        public const string NaroDocumentCopy = "NaroDocumentCopy";
        public const string NaroDocumentPaste = "NaroDocumentPaste";
        public const string StartUp = "StartUp";
        public const string None = "None";
        public const string Direction = "Direction";
        public const string Delete = "Delete";
        public const string SplineAddPoint = "SplineAddPoint";
        public const string MakeFace = "Face";
        public const string ExplodeFace = "ExplodeFace";
        public const string HiddenOn = "HiddenOn";
        public const string HiddenOff = "HiddenOff";
        public const string AddConstraint = "AddConstraint";


        public const string Redo = "Redo";
        public const string Undo = "Undo";
        public const string SunflowRender = "SunflowRender";
        public const string OptionsDialogManager = "OptionsDialogManager";
        public const string EdgeDistanceConstraint = "EdgeDistanceConstraint";
        public const string DeleteHidden = "DeleteHidden";
        public const string HandleDragging = "HandleDragging";

        //File Management
        public const string ExportToStep = "ExportToStep";
        public const string ImportFromStep = "ImportFromStep";
        public const string ImportFromBrep = "ImportFromBrep";
        public const string ImportFromNaroXml = "ImportFromNaroXml";
        public const string ExportToNaroXml = "ExportToNaroXml";

        public const string NewFile = "NewFile";
        public const string FileOpen = "FileOpen";
        public const string FileSave = "FileSave";
        public const string FileSaveAs = "FileSaveAs";
    }
}