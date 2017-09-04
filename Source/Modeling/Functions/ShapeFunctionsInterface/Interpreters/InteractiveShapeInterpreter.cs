#region Usings

using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopLoc;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Interpreters
{
    public class InteractiveShapeInterpreter : AttributeInterpreterBase
    {
        private AISInteractiveObject _interactive;
        private bool _registered;

        /// <summary>
        ///   Value associated to attribute
        /// </summary>
        public AISInteractiveObject Interactive
        {
            get { return _interactive; }
            set
            {
                // Remove the previous interctive drawn
                Remove();
                // Set the new interactive and draw it
                _interactive = value;

                if (value != null)
                {
                    var transform = ExtractNodeTransform();

                    if (transform != null)
                        value.Location = (new TopLocLocation(transform));
                }

                DisplayInteractive();
                OnModified();
                if (_registered) return;
                _registered = true;
                Parent.OnModified += HandleModified;
            }
        }

        private gpTrsf ExtractNodeTransform()
        {
            if (_interactive == null)
                return null;
            gpTrsf transform;
            var transformInter = Parent.Get<TransformationInterpreter>();
            var baseTransform = new gpTrsf();
            if (transformInter != null)
            {
                transform = transformInter.CurrTransform;
                baseTransform.Multiply(transform);
            }
            transform = baseTransform;

            return transform;
        }

        private void HandleModified(Node node, AttributeInterpreterBase atttributetype)
        {
            var shapeManager = Parent.Root.Set<DocumentContextInterpreter>().ShapeManager;
            shapeManager.UpdateNodesInteractive(Parent);
        }


        private void DisplayInteractive()
        {
            var shapeManager = Parent.Root.Set<DocumentContextInterpreter>().ShapeManager;
            shapeManager.UpdateNodesInteractive(Parent);
            return;
        }

        public override void OnRemove()
        {
            if (!_registered)
                Parent.OnModified -= HandleModified;

            Remove();
        }

        private void Remove()
        {
            var shapeManager = Parent.Root.Set<DocumentContextInterpreter>().ShapeManager;
            shapeManager.RemoveShapeFromContext(Parent);
            _interactive = null;
        }

        public override void Serialize(AttributeData data)
        {
        }

        public override void Deserialize(AttributeData data)
        {
        }
    }
}