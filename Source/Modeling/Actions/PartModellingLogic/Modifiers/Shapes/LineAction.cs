//#region Usings

//using System;
//using MetaActionsInterface;
//using NaroBasicPipes.Actions;
//using NaroConstants.Names;
//using NaroPipes.Actions;
//using NaroPipes.Constants;
//using OccCode;
//using PartModellingLogic.Inputs.Naro.Infrastructure;
//using PartModellingLogic.Inputs.Naro.Pipes;
//using Resources.PartModelling;
//using ShapeFunctionsInterface.Utils;
//using TreeData.AttributeInterpreter;

//#endregion

//namespace PartModellingLogic.Modifiers.Shapes
//{
//    internal class LineAction : DrawingLiveShape
//    {
//        private Point3D _coordinate;

//        public LineAction()
//            : base(ModifierNames.Line3D)
//        {
//        }

//        public override void OnRegister()
//        {
//            base.OnRegister();
//            DependsOn(InputNames.CoordinateParser, OnCoordinateParser);
//        }

//        public override void OnActivate()
//        {
//            base.OnActivate();
//            ActionsGraph[InputNames.CoordinateParser].Send(CoordinatateParserNames.SetStage, ParserStage.Unknown);
//            Reset();
//        }

//        private void Reset()
//        {
//            Points.Clear();
//            AddNewEmptyPoint();
//            ShowHint(ModelingResources.LineStep1);
//        }

//        private void OnCoordinateParser(DataPackage data)
//        {
//            var text = (string) data.Data;
//            if (text.Contains(","))
//            {
//                _coordinate = CoordinateParser.ParsePointValue(text, _coordinate);
//                AddNewPoint(_coordinate);
//                return;
//            }
//            if (Points.Count == 1) return;
//            var firstPoint = Points[0];
//            var secondPoint = Points[1];
//            var newLenght = CoordinateParser.ParseDoubleArgument(0, text);
//            var distanceRatio = newLenght/firstPoint.Distance(secondPoint);
//            if (Math.Abs(distanceRatio) < 1e-6)
//                return;

//            AddNewPoint(GeomUtils.BetweenValue(firstPoint, secondPoint, distanceRatio));
//        }


//        protected override void OnMouseUpAction(Mouse3DPosition mouseData)
//        {
//            base.OnMouseUpAction(mouseData);
//            switch (Points.Count)
//            {
//                case 1:
//                    ActionsGraph[InputNames.GeometricSolverPipe].Send(NotificationNames.ResetPreviousPoint);
//                    break;
//                case 2:
//                    ShowHint(ModelingResources.LineStep2);
//                    break;
//            }
//        }

//        protected override void OnMouseMove3DAction(Mouse3DPosition mouseData)
//        {
//            SetCoordinate(mouseData.Point);
//            if (Points.Count < 2) return;
//            PreviewLine();
//            UpdateView();
//        }

//        protected override void OnMouseDownAction(Mouse3DPosition mouseData)
//        {
//            AddNewPoint(mouseData.Point);
//        }

//        private void PreviewLine()
//        {
//            InitAnimateSession();
//            BuildLineInDocument(AnimationDocument, false);
//        }

//        private NodeBuilder BuildLine()
//        {
//            InitSession();
//            return BuildLineInDocument(Document, true);
//        }

//        public override void OnDeactivate()
//        {
//            InitAnimateSession();
//            Reset();
//            base.OnDeactivate();
//        }

//        private void AddNewPoint(Point3D coordinate)
//        {
//            if (Points.Count == 2 && Points[0].IsEqual(coordinate))
//                return;
//            SetCoordinate(coordinate);
//            AddNewEmptyPoint();
//            if (Points.Count <= 2) return;
//            var builder = BuildLine();
//            AddNodeToTree(builder.Node);
//            CommitFinal("Added line to scene");
//            UpdateView();
//            Reset();
//        }

//        private void SetCoordinate(Point3D coordinate)
//        {
//            _coordinate = coordinate;
//            Points[Points.Count - 1] = coordinate;
//        }
//    }
//}
