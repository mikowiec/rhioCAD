#region Usings

using TreeData.NaroData;

#endregion

namespace TreeData.NaroDataViewer
{
    /// <summary>
    ///   An abstract attribute that can be attached to a Node
    /// </summary>
    public abstract class AttributeInterpreterBase
    {
        #region Data members

        private bool _disabled;

        #endregion

        #region Methods

        internal void SetupInternal(Node parent)
        {
            Parent = parent;
            OnActivate();
        }

        //called after Parent is setup
        protected virtual void OnActivate()
        {
        }


        public void Enable()
        {
            _disabled = false;
        }

        public void Disable()
        {
            _disabled = true;
        }

        /// <summary>
        ///   Notify parent node that actual interpreter was changed
        /// </summary>
        public void OnModified()
        {
            if (!_disabled)
                Parent.OnModified(Parent, this);
            else
                Parent.Mark();
        }

        /// <summary>
        ///   Make setup code in case of removal of attribute
        /// </summary>
        public virtual void OnRemove()
        {
        }

        /// <summary>
        ///   Serialize the current attribute storing the mapped attributes to data member
        /// </summary>
        /// <param name = "data">A key/value map store</param>
        public abstract void Serialize(AttributeData data);

        public AttributeData Serialize()
        {
            var result = new AttributeData(TypeNameId);
            Serialize(result);
            return result;
        }

        /// <summary>
        ///   Deserialize the data using the AttributeData
        /// </summary>
        /// <param name = "data">A key/value map store</param>
        public abstract void Deserialize(AttributeData data);

        #endregion

        #region Properties

        /// <summary>
        ///   The parent node associated with the parent
        /// </summary>
        public Node Parent { get; private set; }

        private int TypeNameId
        {
            get { return GetType().GetHashCode(); }
        }

        #endregion
    }
}