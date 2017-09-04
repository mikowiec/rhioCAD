using System.Collections.Generic;
using System.Drawing;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.AppUtils;
using NaroBasicPipes.Actions;
using NaroConstants.Names;
using NaroPipes.Constants;
using NaroSetup;
using NaroSetup.Pages.Solver;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

namespace PartModellingLogic.Modifiers.Shapes
{
    class GuardPointFromMovingAction : DrawingLiveShape
    {
        private readonly Dictionary<int, bool > _referencedNodes;
        private double _zoom;

        public GuardPointFromMovingAction()
            : base(ModifierNames.GuardPointFromMovingAction)
        {
            _referencedNodes =new Dictionary<int, bool>();
        }

        private void GetOptions()
        {
            var optionsSetup = ActionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            var precision = optionsSection.GetDoubleValue((int)HinterOptionFields.PointMatch);
            _zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel * precision;
        }
        public override void OnActivate()
        {
            base.OnActivate();
            GetOptions();
            var documentGraph = Document.Root.Get<DocumentContextInterpreter>().ShapesGraph;
            var sketchCreator = new SketchCreator(Document);
            var sketchNode = sketchCreator.CurrentSketch;
            var linkedPoints = documentGraph.GetReferredByNodes(sketchNode);
            _referencedNodes.Clear();

            var constraints = new List<int>();
            foreach (var child in Document.Root.Children)
            {
                var nb = new NodeBuilder(child.Value);
                if (nb.FunctionName == Constraint2DNames.PositionToCenterFunction)
                {
                    constraints.Add(nb.Dependency[0].ReferenceBuilder.Node.Index);
                }
            }
        
            foreach (var node in linkedPoints)
            {
                var builder = new NodeBuilder(node);
                if (builder.FunctionName != FunctionNames.Point)
                    continue;
                _referencedNodes[node.Index] = constraints.Contains(node.Index);
            }

            DrawPreviewPoints();
        }


        private void DrawPreviewPoint(Point3D pointInSpline, bool isPreview)
        {
            var sphere = new NodeBuilder(AnimationDocument, FunctionNames.Sphere);
            sphere[0].TransformedPoint3D = pointInSpline;
            sphere[1].Real = _zoom * 2 / 3;
            sphere.Color = isPreview ? Color.DeepPink : Color.Blue;
            sphere.ExecuteFunction();
        }

        void DrawPreviewPoints()
        {
            InitAnimateSession();
            var root = Document.Root;
            
            foreach (var index in _referencedNodes)
            {
                var builder = new NodeBuilder(root[index.Key]);
                DrawPreviewPoint(builder[1].TransformedPoint3D, _referencedNodes[index.Key]);
            }
        }

        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
        {
            base.OnMouseDownAction(mouseData);
            var matchingPoint = -1;
            var root = Document.Root;
            foreach (var index in _referencedNodes.Keys)
            {
                var node = root[index];
                var builder = new NodeBuilder(node);
                if(builder[1].TransformedPoint3D.Distance(mouseData.Point) < _zoom)
                {
                    matchingPoint = index;
                    break;
                }
            }
            if (matchingPoint == -1) return;
            _referencedNodes[matchingPoint] = !_referencedNodes[matchingPoint];
            DrawPreviewPoints();
        }

        public override void OnDeactivate()
        {
            InitSession();
            var root = Document.Root;

            var affectedPoints = new Dictionary<int, int>();
            // var constraintNodes = new List<int>();
            foreach (var child in Document.Root.Children)
            {
                var nb = new NodeBuilder(child.Value);
                if (nb.FunctionName == Constraint2DNames.PositionToCenterFunction)
                {
                    affectedPoints.Add(nb.Dependency[0].ReferenceBuilder.Node.Index, nb.Node.Index);
                }
            }

            foreach (var node in _referencedNodes)
            {
                if (!affectedPoints.ContainsKey(node.Key))
                {
                    if (!node.Value) continue;
                    var pointBuilder = new NodeBuilder(root[node.Key]);
                    var builder = new NodeBuilder(Document, Constraint2DNames.PositionToCenterFunction);
                    builder[0].ReferenceBuilder = pointBuilder;
                    builder[1].Real = pointBuilder[1].TransformedPoint3D.X;
                    builder[2].Real = pointBuilder[1].TransformedPoint3D.Y;
                    builder.ExecuteFunction();
                }
            }

            foreach(var node in affectedPoints)
            {
                if(_referencedNodes[node.Key] == false)
                {
                    Document.Root.Remove(node.Value);
                }
            }
            Document.Commit("Added point constraints");

            base.OnDeactivate();
        }
    }
}
