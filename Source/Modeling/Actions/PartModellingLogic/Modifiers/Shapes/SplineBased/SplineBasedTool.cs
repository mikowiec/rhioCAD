#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using Naro.Infrastructure.Interface.AppUtils;
using NaroConstants.Names;
using NaroSetup;
using NaroSetup.Pages.Solver;
using PartModellingUi.Views.Tools;
using ShapeFunctionsInterface.Functions;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Shapes.SplineBased
{
    internal class SplineBasedTool : DrawingLiveShape
    {
        private double _zoom;

        protected SplineBasedTool(string modifierName) : base(modifierName)
        {
        }

        public override void OnActivate()
        {
            base.OnActivate();
            var fastAccessTools = new SplineFastAccessTools(ActionsGraph);
            RibbonPanel.Children.Add(fastAccessTools);

            GetOptions();
            InitSession();
        }

        protected void GetOptions()
        {
            var optionsSetup = ActionsGraph[InputNames.OptionsSetupInput].Get<OptionsSetup>();
            var optionsSection = optionsSetup.UpdateSectionNode(OptionSectionNames.SolverPageTitle);
            var precision = optionsSection.GetDoubleValue((int) HinterOptionFields.PointMatch);
            _zoom = CoreGlobalPreferencesSingleton.Instance.ZoomLevel*precision;
        }

        protected void DrawPreviewPoint(Point3D pointInSpline)
        {
            var sphere = new NodeBuilder(Document, FunctionNames.Sphere);
            sphere[0].TransformedPoint3D = pointInSpline;
            sphere[1].Real = _zoom*2/3;
            sphere.ExecuteFunction();
        }

        protected static List<Point3D> ExtractSplineAllPoints(NodeBuilder builder)
        {
            var result = new List<Point3D>();
            var pointCount = builder[0].Integer;
            for (var i = 1; i <= pointCount; i++)
                result.Add(builder[i].TransformedPoint3D);
            return result;
        }

        protected bool ArePointsOutOfZoomRange(Point3D splineIntermediaryPoint, Point3D mousePoint)
        {
            return splineIntermediaryPoint.Distance(mousePoint) > _zoom;
        }

        protected static bool BuildSplineFromPoints(Document document, IList<Point3D> pointList)
        {
            var builder = new NodeBuilder(document, FunctionNames.SplinePath);
            builder[0].Integer = pointList.Count;
            var dependency = builder.Node.Get<FunctionInterpreter>().Dependency;
            for (var i = 1; i <= pointList.Count; i++)
            {
                dependency.AddAttributeType(InterpreterNames.Point3D);
                builder[i].TransformedPoint3D = pointList[i - 1];
            }
            return builder.ExecuteFunction();
        }
    }
}