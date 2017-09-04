#region Usings

using System;
using System.Drawing;
using Naro.PartModeling;
using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using NaroSetup;

using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace ShapeFunctionsInterface.Utils
{
    public class NodeBuilder
    {
        #region Constructor

        public NodeBuilder(Node node)
        {
            _lastExecute = false;
            _node = node;
        }

        public NodeBuilder(Document document, string functionName, string displayName)
        {
            _lastExecute = false;
            _node = document.Root.AddNewChild();
            SetNewNode(document, functionName, displayName);
        }

        public NodeBuilder(Document document, string functionName)
        {
            _lastExecute = false;
            _node = document.Root.AddNewChild();
            SetNewNode(document, functionName, functionName);
        }

        #endregion

        #region Properties

        private readonly Node _node;
        private bool _lastExecute;

        public FunctionDependency Dependency
        {
            get { return Node.Get<FunctionInterpreter>().Dependency; }
        }

        public Node Node
        {
            get { return _node; }
        }

        public int Count
        {
            get { return Dependency.Count; }
        }

        public FunctionDependency.DependencyNode this[int childId]
        {
            get { return Dependency[childId]; }
        }

        public TopoDSShape TransformedShape
        {
            get { return Shape.Located(new TopLocLocation(Transformation)); }
        }

        public TopoDSShape Shape
        {
            get
            {
                var namedShapeInterpreter = Node.Get<NamedShapeInterpreter>();
                var functionInterpreter = Node.Get<FunctionInterpreter>();
                if (functionInterpreter == null)
                    return null;
                if (namedShapeInterpreter == null)
                {
                    try
                    {
                        if (!ExecuteFunction())
                            return null;
                    }
                    catch
                    {
                        return null;
                    }
                    namedShapeInterpreter = Node.Get<NamedShapeInterpreter>();
                }
                return namedShapeInterpreter == null ? null : namedShapeInterpreter.Shape;
            }
        }

        public AISInteractiveObject Interactive
        {
            get
            {
                var namedShapeInterpreter = Node.Get<InteractiveShapeInterpreter>();
                var functionInterpreter = Node.Get<FunctionInterpreter>();
                if (functionInterpreter == null)
                    return null;
                if (namedShapeInterpreter == null)
                {
                    try
                    {
                        if (!ExecuteFunction())
                            return null;
                    }
                    catch
                    {
                        return null;
                    }
                    namedShapeInterpreter = Node.Get<InteractiveShapeInterpreter>();
                }
                return namedShapeInterpreter == null ? null : namedShapeInterpreter.Interactive;
            }
        }

        public string FunctionName
        {
            get { return FunctionUtils.GetFunctionName(Node); }
        }

        public string ShapeName
        {
            get { return Node.Set<StringInterpreter>().Value; }
            set { Node.Set<StringInterpreter>().Value = value; }
        }

        public Color Color
        {
            get { return Node.Set<DrawingAttributesInterpreter>().Color; }
            set { Node.Set<DrawingAttributesInterpreter>().Color = value; }
        }

        public Double Transparency
        {
            get { return Node.Set<DrawingAttributesInterpreter>().Transparency; }
            set { Node.Set<DrawingAttributesInterpreter>().Transparency = value; }
        }

        public AISDisplayMode DisplayMode
        {
            get { return Node.Set<DrawingAttributesInterpreter>().DisplayMode; }
            set { Node.Set<DrawingAttributesInterpreter>().DisplayMode = value; }
        }

        public bool EnableSelection
        {
            get { return Node.Set<DrawingAttributesInterpreter>().EnableSelection; }
            set { Node.Set<DrawingAttributesInterpreter>().EnableSelection = value; }
        }

        public ObjectVisibility Visibility
        {
            get { return _node.Set<DrawingAttributesInterpreter>().Visibility; }
            set { _node.Set<DrawingAttributesInterpreter>().Visibility = value; }
        }

        public gpTrsf Transformation
        {
            get { return Node.Get<TransformationInterpreter>().CurrTransform; }
            set { Node.Set<TransformationInterpreter>().CurrTransform = value; }
        }

        public gpPnt Pivot
        {
            get { return Node.Get<TransformationInterpreter>().Pivot; }
            set { Node.Set<TransformationInterpreter>().Pivot = value; }
        }

        public gpPnt Translate
        {
            get { return Node.Get<TransformationInterpreter>().Translate; }
            set { Node.Set<TransformationInterpreter>().Translate = value; }
        }

        public gpPnt Rotate
        {
            set { Node.Set<TransformationInterpreter>().Rotate = value; }
        }

        public double Scale
        {
            get { return Node.Get<TransformationInterpreter>().Scale; }
            set { Node.Set<TransformationInterpreter>().Scale = value; }
        }

        public bool LastExecute
        {
            get { return _lastExecute; }
            private set { _lastExecute = value; }
        }

        public ShapeBoundBox BoundingBox
        {
            get { return Visibility == ObjectVisibility.Hidden ? null : ShapeUtils.ExtractBoundingBox(Shape); }
        }

        public bool ExecuteFunction()
        {
            var fi = Node.Get<FunctionInterpreter>();
            LastExecute = fi != null && fi.Execute();
            return LastExecute;
        }

        #endregion

        #region Methods

        private void SetNewNode(Document document, string functionName, string displayName)
        {
            Node.Set<FunctionInterpreter>().Name = functionName;
            var numbering = document.Root.Set<DocumentContextInterpreter>().Numbering;
            Node.Set<StringInterpreter>().Value = numbering.GetNextIndexName(displayName);
            Visibility = ObjectVisibility.ToBeDisplayed;

            var root = Node.Root;
            var currentLayer = root.Set<LayerContainerInterpreter>().CurrentLayer;
            Node.Set<LayerVisibilityInterpreter>().TagIndex = currentLayer;

            var actionsGraph = document.Root.Get<ActionGraphInterpreter>().ActionsGraph;
            var optionsSetup = actionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var defaultDrawOptions = optionsSetup.UpdateSectionNode(OptionSectionNames.Background);
            Color = defaultDrawOptions.GetColorValue(1);
        }

        #endregion

        #region Data members

        #endregion
    }
}