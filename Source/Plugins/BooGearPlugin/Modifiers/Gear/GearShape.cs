#region Usings

using System;
using Naro.Infrastructure.Interface.Boo;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroConstants.Enums;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace BooGearPlugin.Modifiers.Gear
{
    internal class GearShape : LibraryShape
    {
        public GearShape()
        {
            AddDependency<Point3D>();
            AddDependency(32.0);
            AddDependency(40.0);
            //steps
            AddDependency(20);
            AddDependency(5.5);
        }

        private static double Sin(double value)
        {
            return Math.Sin(value);
        }

        private static double Cos(double value)
        {
            return Math.Cos(value);
        }

        public override bool Execute(Document document)
        {
            var origin = Get<Point3D>(0);
            var innerRange = Get<double>(1);
            var outerRange = Get<double>(2);
            const double innerAngleRatio = 0.4;
            const double outerAngleRatio = 0.2;
            var steps = Get<int>(3);
            var extrudeSize = Get<double>(4);

            const double piMul2 = 2*Math.PI;
            var radStep = piMul2/steps;

            const double angleRatioStart = innerAngleRatio + (1.0 - innerAngleRatio - outerAngleRatio)/2.0;

            double x1;
            double y1;
            var x4 = 0.0;
            var y4 = 0.0;

            var secondLine = false;
            var i = 0;
            var l1 = 0;
            while (i < steps)
            {
                x1 = Math.Cos(radStep*i)*innerRange;
                y1 = Math.Sin(radStep*i)*innerRange;
                var x2 = Math.Cos(radStep*(i + innerAngleRatio))*innerRange;
                var y2 = Math.Sin(radStep*(i + innerAngleRatio))*innerRange;
                l1 = Line(x1, y1, 0, x2, y2, 0, document);

                if (secondLine)
                    Line(x4, y4, 0, x1, y1, 0, document);
                else
                    secondLine = true;

                var x3 = Cos(radStep*(i + angleRatioStart))*outerRange;
                var y3 = Sin(radStep*(i + angleRatioStart))*outerRange;
                x4 = Cos(radStep*(i + angleRatioStart + outerAngleRatio))*outerRange;
                y4 = Sin(radStep*(i + angleRatioStart + outerAngleRatio))*outerRange;
                Line(x3, y3, 0, x4, y4, 0, document);
                Line(x2, y2, 0, x3, y3, 0, document);
                ++i;
            }
            x1 = Cos(radStep*i)*innerRange;
            y1 = Sin(radStep*i)*innerRange;
            Line(x4, y4, 0, x1, y1, 0, document);

            var f1 = MakeFace(l1, document);
            if (f1 == -1) return false;
            RootBuilder = Extrude(f1, extrudeSize, document, origin);
            GenerateTreeViewFromRootBuilder = true;
            return true;
        }

        private static NodeBuilder Extrude(int f1, double i, Document document, Point3D origin)
        {
            var builder = new NodeBuilder(document, FunctionNames.Extrude);
            builder[0].ReferenceData = new SceneSelectedEntity
                                           {
                                               Node = document.Root[f1],
                                               ShapeType = TopAbsShapeEnum.TopAbs_FACE,
                                               ShapeCount = 1
                                           };
            builder[1].Integer = (int) ExtrusionTypes.ToDepth;
            builder[2].Real = i;
            builder.Translate = origin.GpPnt;
            builder.ExecuteFunction();
            new NodeBuilder(document.Root[f1]) {Visibility = ObjectVisibility.Hidden};
            return builder;
        }

        private static int MakeFace(int l1, Document document)
        {
            var node = AutoGroupLogic.TryAutoGroup(document, document.Root[l1]);
            if (node == null) return -1;
            return node.Index;
        }

        private static int Line(double x1, double y1, double z1, double x2, double y2, double z2, Document document)
        {
            var firstPoint = new Point3D(x1, y1, z1);
            var secondPoint = new Point3D(x2, y2, z2);
            var builder = new NodeBuilder(document, FunctionNames.LineTwoPoints);
            builder[0].RefTransformedPoint3D = firstPoint;
            builder[1].RefTransformedPoint3D = secondPoint;
            builder.ExecuteFunction();
            return builder.Node.Index;
        }
    }
}