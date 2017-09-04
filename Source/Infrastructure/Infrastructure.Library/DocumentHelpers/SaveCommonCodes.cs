#region Usings

using System.Collections.Generic;
using ErrorReportCommon.Messages;
using NaroConstants.Names;
using NaroCppCore.Occ.BRep;
using NaroCppCore.Occ.BRepAlgo;
using NaroCppCore.Occ.BRepTools;
using NaroCppCore.Occ.IFSelect;
using NaroCppCore.Occ.STEPControl;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;
using ShapeFunctionsInterface.Interpreters;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Library.DocumentHelpers
{
    public static class SaveCommonCodes
    {
        public static void SaveToFile(string fileName, Document document)
        {
            document.DumpToXml(fileName);
        }

        public static void SaveToStep(string fileName, Document document)
        {
            var shapes = new List<TopoDSShape>();
            foreach (var node in document.Root.Children.Values)
            {
                var interpreter = node.Get<NamedShapeInterpreter>();
                if (interpreter == null)
                {
                    continue;
                }
                var shape = interpreter.Shape;
                var hidden = node.Set<DrawingAttributesInterpreter>().Visibility == ObjectVisibility.Hidden;
                if (!hidden)
                    shapes.Add(shape);
            }
            MeshTopoShapeInterpreter.SaveShapeToStep(shapes, fileName);
        }

        public static void LoadStepFile(string fileName, Document document)
        {
            try
            {
                document.Transact();
                var aReader = new STEPControlReader();

                aReader.ReadFile(fileName);

                aReader.WS().MapReader().TraceLevel = 2; // increase default trace level

                aReader.PrintCheckLoad(false, IFSelectPrintCount.IFSelect_ItemsByEntity);

                // Root transfers
                var nbr = aReader.NbRootsForTransfer;
                aReader.PrintCheckTransfer(false, IFSelectPrintCount.IFSelect_ItemsByEntity);

                for (var n = 1; n <= nbr; n++)
                    aReader.TransferRoot(n);

                var nbs = aReader.NbShapes;

                var aSequence = new TopToolsHSequenceOfShape();
                for (var i = 1; i <= nbs; i++)
                    aSequence.Append(aReader.Shape(i));

                for (var i = 1; i <= aSequence.Length; i++)
                {
                    var aisShape = aSequence.Value(i);
                    var builder = new NodeBuilder(document, FunctionNames.Mesh);
                    builder[0].Shape = aisShape;
                    builder.ExecuteFunction();
                }
                document.Commit("Added to scene filename: " + fileName);
            }
            catch
            {
                document.Revert();
                NaroMessage.Show("Exception on loading file: " + fileName);
            }
        }

        public static void LoadBrepFile(string fileName, Document document)
        {
            var aSequence = new TopToolsHSequenceOfShape();
            var aShape = new TopoDSShape();
            var aBuilder = new BRepBuilder();

            var result = BRepTools.Read(aShape, fileName, aBuilder, null);
            if (result)
            {
                if (!BRepAlgo.IsValid(aShape))
                {
                    // Warning: The shape is not valid!
                }
                else
                {
                    aSequence.Append(aShape);
                }
            }

            if (aSequence.IsEmpty)
                return;

            document.Transact();
            for (var i = 1; i <= aSequence.Length; i++)
            {
                var aisShape = aSequence.Value(i);
                var builder = new NodeBuilder(document, FunctionNames.Mesh);
                builder[0].Shape = aisShape;
                builder.ExecuteFunction();
            }
            document.Commit("Added to scene filename: " + fileName);
        }
    }
}