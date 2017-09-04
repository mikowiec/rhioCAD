#region Usings

using System.Collections.Generic;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal abstract class ExportBuilderBasedInterpreter : IHandleBooExportInterpreter
    {
        #region IHandleBooExportInterpreter Members

        public abstract void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter);

        public abstract void PostconditionCode(AttachedNodeData data, List<string> lines);

        #endregion

        protected static string BuilderStr(AttachedNodeData data)
        {
            object builderNameObj;
            if (!data.Parent.Data.TryGetValue(AttachedDataNames.BuilderName, out builderNameObj)) return string.Empty;
            var builderName = (string) builderNameObj;
            return builderName + "[" + (data.Node.Index - 1) + "].";
        }
    }
}