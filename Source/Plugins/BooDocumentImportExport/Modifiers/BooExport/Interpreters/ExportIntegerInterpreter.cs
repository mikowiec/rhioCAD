#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportIntegerInterpreter : ExportBuilderBasedInterpreter
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            var buildStr = BuilderStr(data);
            if (string.IsNullOrEmpty(buildStr)) return;
            var intInterpreter = (IntegerInterpreter) interpreter;

            lines.Add(buildStr + "Integer =" + intInterpreter.Value);
        }

        public override void PostconditionCode(AttachedNodeData data, List<string> lines)
        {
        }
    }
}