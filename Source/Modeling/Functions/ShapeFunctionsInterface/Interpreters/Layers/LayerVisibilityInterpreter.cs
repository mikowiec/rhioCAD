#region Usings

using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Interpreters.Layers
{
    public class LayerVisibilityInterpreter : AttributeInterpreterBase
    {
        #region Properties

        public int TagIndex
        {
            get { return _tagIndex; }
            set
            {
                _tagIndex = value;
                OnModified();
            }
        }

        #endregion

        public bool IsVisible
        {
            get
            {
                var container = GetContainer();
                return container.IsLayerVisible(_tagIndex);
            }
        }

        private LayerContainerInterpreter GetContainer()
        {
            return Parent.Root.Get<LayerContainerInterpreter>();
        }

        #region Overridden methods

        protected override void OnActivate()
        {
            Parent.Root.OnModified += RootModified;
        }

        public override void OnRemove()
        {
            Parent.Root.OnModified -= RootModified;
        }

        private void RootModified(Node node, AttributeInterpreterBase atttributetype)
        {
            if (atttributetype is LayerContainerInterpreter)
                OnModified();
        }

        public override void Serialize(AttributeData data)
        {
            data.WriteAttribute("Value", _tagIndex);
        }

        public override void Deserialize(AttributeData data)
        {
            _tagIndex = data.HasAttribute("Value") ? data.ReadAttributeInteger("Value") : 0;
            OnModified();
        }

        #endregion

        #region Data members

        private int _tagIndex;

        #endregion
    }
}