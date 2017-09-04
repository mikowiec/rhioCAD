#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportPoint3DInterpreter : ExportRealBased
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            var buildStr = BuilderStr(data);
            if (string.IsNullOrEmpty(buildStr)) return;
            var nodeBuilder = new NodeBuilder(data.Parent.Node);

            var point = nodeBuilder[data.Node.Index - 1].TransformedPoint3D;

            lines.Add(buildStr + "Point3D = Point3D(" + _(point.X) + ", " + _(point.Y) + ", " + _(point.Z) + ")");
        }
    }
}