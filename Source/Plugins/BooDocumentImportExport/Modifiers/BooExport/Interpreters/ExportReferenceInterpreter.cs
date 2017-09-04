#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportReferenceInterpreter : ExportReferenceBased
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            base.PreconditionCode(data, lines, interpreter);
            var builderStr = BuilderStr(data);
            if (string.IsNullOrEmpty(builderStr)) return;
            var referenceInterpreter = (ReferenceInterpreter) interpreter;

            DefineSse(lines, referenceInterpreter.Data);
            lines.Add(builderStr + "ReferenceData = sse");
        }
    }
}