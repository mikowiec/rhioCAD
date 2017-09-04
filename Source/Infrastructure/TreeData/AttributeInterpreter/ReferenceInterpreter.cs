#region Usings

using NaroCppCore.Occ.TopAbs;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class ReferenceInterpreter : AttributeInterpreterBase
    {
        #region Properties

        private string _constraintType = string.Empty;

        public string ConstraintType
        {
            get { return _constraintType; }
            set { _constraintType = value; }
        }


        public SceneSelectedEntity Data
        {
            get { return _data; }
            set { SetReferenceData(value); }
        }


        public Node Node
        {
            get { return _data == null ? null : _data.Node; }
            set { UpdateNodeValue(value); }
        }

        #endregion

        #region Overridden methods

        public override void OnRemove()
        {
            if (_data != null && _data.Node != null)
                _data.Node.OnModified -= OnReferencedModified;
        }

        public override void Serialize(AttributeData data)
        {
            SerializeData(data);
        }

        public override void Deserialize(AttributeData data)
        {
            if (string.IsNullOrEmpty(data.ReadAttributeString("Value")))
            {
                _data = null;
                OnModified();
                return;
            }
            var result = DeserializeSceneSelectedEntity(data);
            _constraintType = data.ReadAttributeString("ConstraintType");
            if (_data.Node != null)
                _data.Node.OnModified -= OnReferencedModified;
            _data = result;
            if (_data.Node != null)
                _data.Node.OnModified += OnReferencedModified;
            OnModified();
        }

        #endregion

        #region Methods

        private void SerializeData(SceneSelectedEntity referenceData, AttributeData data)
        {
            if (Node == null)
            {
                data.WriteAttribute("Value", string.Empty);
                return;
            }
            data.WriteAttribute("Value", Parent, referenceData.Node);
            data.WriteAttribute("ShapeCount", referenceData.ShapeCount);
            data.WriteAttribute("ShapeType", (int) referenceData.ShapeType);
        }

        private void SerializeData(AttributeData data)
        {
            if (_data == null)
            {
                data.WriteAttribute("Value", "");
            }
            else
            {
                var referenceData = _data;
                data.WriteAttribute("ConstraintType", ConstraintType);
                SerializeData(referenceData, data);
            }
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeType)
        {
            if (!(atttributeType is TopoDsShapeInterpreter || atttributeType is DrawingAttributesInterpreter))
                return;
            OnModified();
        }

        private void UpdateNodeValue(Node value)
        {
            if (_data == null)
                return;
            if (_data.Node != null)
                _data.Node.OnModified -= OnReferencedModified;
            _data.Node = value;
            if (_data.Node != null)
                _data.Node.OnModified += OnReferencedModified;
            OnModified();
        }

        private void SetReferenceData(SceneSelectedEntity value)
        {
            if (value == null)
            {
                _data = value;
                Node = null;
                return;
            }
            if (_data == null)
                _data = new SceneSelectedEntity();
            _data.ShapeCount = value.ShapeCount;
            _data.ShapeType = value.ShapeType;
            Node = value.Node;
        }

        private SceneSelectedEntity DeserializeSceneSelectedEntity(AttributeData data)
        {
            var result = new SceneSelectedEntity(data.ReadAttributeReference("Value", Parent))
                             {
                                 ShapeCount = data.ReadAttributeInteger("ShapeCount"),
                                 ShapeType = (TopAbsShapeEnum) data.ReadAttributeInteger("ShapeType")
                             };

            return result;
        }

        #endregion

        #region Data members

        private SceneSelectedEntity _data = new SceneSelectedEntity();

        #endregion
    }
}