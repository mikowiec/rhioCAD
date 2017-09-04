#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportAxisInterpreter : ExportRealBased
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            var builderStr = BuilderStr(data);
            if (string.IsNullOrEmpty(builderStr)) return;
            var axis = new Axis(new NodeBuilder(data.Parent.Node)[data.Node.Index - 1].TransformedAxis3D);
            lines.Add(builderStr + "Axis3D = Axis (" +
                      "Point3D(" + _(axis.Location.X) + ", " + _(axis.Location.Y) + ", " + _(axis.Location.Z) + ")," +
                      "Point3D(" + _(axis.Direction.X) + ", " + _(axis.Direction.Y) + ", " + _(axis.Direction.Z) + "))"
                );
        }
    }
}