#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportRealInterpreter : ExportRealBased
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            var builderStr = BuilderStr(data);
            if (string.IsNullOrEmpty(builderStr)) return;
            var realInterpreter = (RealInterpreter) interpreter;
            lines.Add(builderStr + "Real =" + _(realInterpreter.Value));
        }
    }
}