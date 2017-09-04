#region Usings

using System.Collections.Generic;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport
{
    internal interface IHandleBooExportInterpreter
    {
        void PreconditionCode(AttachedNodeData data, List<string> lines, AttributeInterpreterBase interpreter);
        void PostconditionCode(AttachedNodeData data, List<string> lines);
    }
}