#region Usings

using System.Collections.Generic;
using NaroCppCore.Occ.TopAbs;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class ReferenceListInterpreter : AttributeInterpreterBase
    {
        #region Properties

        public List<SceneSelectedEntity> Nodes
        {
            get { return _nodes; }
            set { UpdateNodeList(value); }
        }

        #endregion

        #region Overriden method

        public override void Serialize(AttributeData data)
        {
            SerializeData(data);
        }

        public override void Deserialize(AttributeData data)
        {
            DeserializeData(data);
        }

        #endregion

        #region Methods

        private void UpdateNodeList(IEnumerable<SceneSelectedEntity> value)
        {
            if (_nodes != null)
                ClearNodeList();
            _nodes = new List<SceneSelectedEntity>(value);
            RegisterNodeList();
            OnModified();
        }

        private void RegisterNodeList()
        {
            foreach (var node in _nodes)
                node.Node.OnModified += OnReferencedModified;
        }

        private void ClearNodeList()
        {
            foreach (var node in _nodes)
                node.Node.OnModified -= OnReferencedModified;
            _nodes.Clear();
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeName)
        {
            if (!(atttributeName is TopoDsShapeInterpreter))
                return;
            OnModified();
        }

        public override void OnRemove()
        {
            if (_nodes == null) return;
            ClearNodeList();
        }

        private void SerializeData(AttributeData data)
        {
            data.WriteAttribute("Count", _nodes.Count);
            var position = 0;
            foreach (var node in _nodes)
            {
                data.WriteAttribute("Node" + position, Parent, node.Node);
                data.WriteAttribute("ShapeType" + position, (int) node.ShapeType);
                data.WriteAttribute("ShapeIndex" + position, node.ShapeCount);
                position++;
            }
        }

        private void DeserializeData(AttributeData data)
        {
            ClearNodeList();
            var count = data.ReadAttributeInteger("Count");
            var referenceNodes = new List<Node>();
            var shapeTypes = new List<int>();
            var shapeIndexes = new List<int>();

            for (var position = 0; position < count; position++)
            {
                var node = data.ReadAttributeReference("Node" + position, Parent);
                referenceNodes.Add(node);
                shapeTypes.Add(data.ReadAttributeInteger("ShapeType" + position));
                shapeIndexes.Add(data.ReadAttributeInteger("ShapeIndex" + position));
            }

            var pos = 0;
            foreach (var node in referenceNodes)
            {
                var entity = new SceneSelectedEntity
                                 {
                                     Node = node,
                                     ShapeType = (TopAbsShapeEnum) shapeTypes[pos],
                                     ShapeCount = shapeIndexes[pos]
                                 };
                Nodes.Add(entity);

                pos++;
            }
            RegisterNodeList();
            OnModified();
        }

        #endregion

        #region Data members

        private List<SceneSelectedEntity> _nodes = new List<SceneSelectedEntity>();

        #endregion
    }
}