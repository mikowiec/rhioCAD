#region Usings

using NaroCppCore.Occ.TopAbs;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace Naro.Infrastructure.Interface.Constraints
{
    public class ConstraintReferenceInterpreter : ConstraintBaseInterpterer
    {
        #region Properties

        public SceneSelectedEntity Data
        {
            get { return _data; }
        }

        public Node Node
        {
            protected get { return _data.Node; }
            set { SetNode(value); }
        }

        #endregion

        #region Overriten methods

        public override void Deserialize(AttributeData data)
        {
            var result = DeserializeSceneSelectedEntity(data);
            _data = result;
            OnModified();
        }


        public override void Serialize(AttributeData data)
        {
            if (_data == null || _data.Node == null)
                data.WriteAttribute("Value", "");
            else
                SerializeSceneSelectedEntity(_data, data);
        }

        public override void OnRemove()
        {
            if (_data != null && _data.Node != null)
                _data.Node.OnModified -= OnReferencedModified;
        }

        #endregion

        #region Methods

        private void SetNode(Node value)
        {
            if (_data.Node != null)
                _data.Node.OnModified -= OnReferencedModified;
            _data.Node = value;
            _data.Node.OnModified += OnReferencedModified;
            OnModified();
        }

        private SceneSelectedEntity DeserializeSceneSelectedEntity(AttributeData data)
        {
            return new SceneSelectedEntity(data.ReadAttributeReference("Value", Parent))
                       {
                           ShapeCount = data.ReadAttributeInteger("ShapeCount"),
                           ShapeType = (TopAbsShapeEnum)data.ReadAttributeInteger("ShapeType")
                       };
        }

        private void SerializeSceneSelectedEntity(SceneSelectedEntity referenceData, AttributeData data)
        {
            data.WriteAttribute("Value", Parent, referenceData.Node);
            data.WriteAttribute("ShapeCount", referenceData.ShapeCount);
            data.WriteAttribute("ShapeType", (int) referenceData.ShapeType);
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeType)
        {
            OnModified();
        }

        #endregion

        #region Data members

        private SceneSelectedEntity _data = new SceneSelectedEntity();

        #endregion
    }
}