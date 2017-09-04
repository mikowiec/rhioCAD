#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;
using TreeData.Utils;

#endregion

namespace BooDocumentImportExport.Modifiers.BooExport.Interpreters
{
    internal abstract class ExportReferenceBased : ExportBuilderBasedInterpreter
    {
        private AttachedNodeData _data;

        public override void PreconditionCode(AttachedNodeData data, List<string> lines,
                                              AttributeInterpreterBase interpreter)
        {
            _data = data;
        }

        public override void PostconditionCode(AttachedNodeData data, List<string> lines)
        {
        }

        protected void DefineSse(List<string> lines, SceneSelectedEntity sceneSelectedEntity)
        {
            lines.Add("sse = SceneSelectedEntity()");
            lines.Add("sse.Node = " + _(sceneSelectedEntity.Node));
            lines.Add("sse.ShapeCount = " + sceneSelectedEntity.ShapeCount);
            lines.Add("sse.ShapeType = TopAbsShapeEnum." + sceneSelectedEntity.ShapeType);
        }

        private string _(Node node)
        {
            object builderNameValue;
            var parentData = _data.Root.Children[node.Index].Data.TryGetValue(AttachedDataNames.BuilderName,
                                                                              out builderNameValue);
            Ensure.IsTrue(parentData);
            var builderName = (string) builderNameValue;
            return builderName + ".Node";
        }
    }
}