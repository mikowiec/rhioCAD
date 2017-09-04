#region Usings

using System.Collections.Generic;
using MetaActionsInterface;
using ShapeFunctionsInterface.Interpreters.Layers;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.DocumentAction
{
    public class ImportNaroXmlCloneLogic : DrawingAction3D
    {
        protected readonly SortedDictionary<int, int> ImportedIdMapping = new SortedDictionary<int, int>();

        protected ImportNaroXmlCloneLogic(string name) : base(name)
        {
        }

        protected void BuildMappedShape(NodeBuilder builder, NodeBuilder buildNode)
        {
            foreach (var child in builder.Node.Children.Values)
            {
                var serializedNode = Document.ReflectTreeMirror(child);
                var refInt = child.Get<ReferenceInterpreter>();
                var refListInt = child.Get<ReferenceListInterpreter>();
                if (refInt == null && refListInt == null)
                    serializedNode.ApplyOnNode(buildNode.Node[child.Index]);
                else
                {
                    if (refInt != null)
                    {
                        var entity = refInt.Data;
                        var mappedEntity = ComputeMappedEntity(buildNode, entity);
                        buildNode.Node[child.Index].Set<ReferenceInterpreter>().Data = mappedEntity;
                    }
                    if (refListInt != null)
                    {
                        var nodeList = new List<SceneSelectedEntity>();
                        foreach (var entity in refListInt.Nodes)
                        {
                            var mappedEntity = ComputeMappedEntity(buildNode, entity);
                            nodeList.Add(mappedEntity);
                        }
                        buildNode.Node[child.Index].Set<ReferenceListInterpreter>().Nodes = nodeList;
                    }
                }
            }
            SetBaseNodeAttributes(builder, buildNode);
            buildNode.ExecuteFunction();
        }

        private SceneSelectedEntity ComputeMappedEntity(NodeBuilder buildNode, SceneSelectedEntity entity)
        {
            return new SceneSelectedEntity
                       {
                           Node = GetMappedNode(buildNode, entity.Node),
                           ShapeCount = entity.ShapeCount,
                           ShapeType = entity.ShapeType
                       };
        }

        private void SetBaseNodeAttributes(NodeBuilder builder, NodeBuilder buildNode)
        {
            var node = builder.Node;
            var result = new SerializedNode(node.Index);
            foreach (var aib in node.Interpreters)
            {
                var data = new AttributeData(aib.Key);
                aib.Value.Serialize(data);
                result.Interpreters[aib.Key] = data;
            }
            result.ApplyOnNode(buildNode.Node);
            buildNode.Node.Set<LayerVisibilityInterpreter>().TagIndex =
                Document.Root.Set<LayerContainerInterpreter>().CurrentLayer;
        }

        private Node GetMappedNode(NodeBuilder buildNode, Node referencedNode)
        {
            var refNodeIndex = referencedNode.Index;
            return buildNode.Node.Root[ImportedIdMapping[refNodeIndex]];
        }
    }
}