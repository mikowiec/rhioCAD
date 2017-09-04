#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.NaroDataViewer;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal class ExportFunctionInterpreter : IHandleBooExportInterpreter
    {
        #region IHandleBooExportInterpreter Members

        public void PreconditionCode(AttachedNodeData data, List<string> lines, AttributeInterpreterBase interpreter)
        {
            var builder = new NodeBuilder(interpreter.Parent);
            var builderName = "builder" + builder.Node.Index;
            data.Data[AttachedDataNames.BuilderName] = builderName;
            lines.Add(builderName + "= NodeBuilder(Document, FunctionNames." + builder.FunctionName + ")");
            lines.Add(builderName + ".ShapeName =  \"" + builder.ShapeName + "\"");
        }

        public void PostconditionCode(AttachedNodeData data, List<string> lines)
        {
            object builderNameObj;
            if (!data.Data.TryGetValue(AttachedDataNames.BuilderName, out builderNameObj)) return;
            var builderName = (string) builderNameObj;
            lines.Add(builderName + ".ExecuteFunction()");
        }

        #endregion
    }
}