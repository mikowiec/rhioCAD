#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportReferenceListInterpreter : ExportReferenceBased
    {
        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            base.PreconditionCode(data, lines, interpreter);
            var builderStr = BuilderStr(data);
            if (string.IsNullOrEmpty(builderStr)) return;
            var referenceListInterpreter = (ReferenceListInterpreter) interpreter;

            lines.Add("refList = List[of SceneSelectedEntity]()");
            foreach (var sceneSelectedEntity in referenceListInterpreter.Nodes)
            {
                DefineSse(lines, sceneSelectedEntity);
                lines.Add("refList.Add(sse)");
            }
            lines.Add(builderStr + "ReferenceList = refList");
        }
    }
}