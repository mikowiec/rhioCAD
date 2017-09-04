#region Usings

using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;

using ShapeFunctionsInterface.Interpreters.Layers;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Interpreters
{
    public class NamedShapeInterpreter : AttributeInterpreterBase
    {
        private gpAx1 _axis = new gpAx1();
        private AISInteractiveObject _interactive;
        private bool _registered;

        public TopoDSShape Shape
        {
            get { return Parent.Set<TopoDsShapeInterpreter>().Shape; }
            set
            {
                Parent.Set<TopoDsShapeInterpreter>().Shape = value;

                if (!_registered)
                {
                    Parent.OnModified += OnReferencedModified;
                    _registered = true;
                }
                RegenerateInteractive();
            }
        }

        public gpAx1 Axis
        {
            get { return _axis; }
            set { _axis = value; }
        }

        /// <summary>
        /// </summary>
        public AISInteractiveObject Interactive
        {
            get
            {
                //RegenerateInteractive();
                return _interactive;
            }
            set { _interactive = value; }
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeName)
        {
            if ((atttributeName is DrawingAttributesInterpreter)
                || (atttributeName is LayerVisibilityInterpreter)
                || (atttributeName is TopoDsShapeInterpreter)
                || (atttributeName is TransformationInterpreter)
                )
            {
                RegenerateInteractive();
            }
        }

        public override void OnRemove()
        {
            var shapeManager = Parent.Root.Set<DocumentContextInterpreter>().ShapeManager;
            shapeManager.RemoveShapeFromContext(Parent);
            _interactive = null;
            if (_registered)
                Parent.OnModified -= OnReferencedModified;
        }

        public void RegenerateInteractive()
        {
            var shapeManager = Parent.Root.Set<DocumentContextInterpreter>().ShapeManager;
            _interactive = shapeManager.UpdateNodesInteractive(Parent);
        }

        public override void Serialize(AttributeData data)
        {
        }

        public override void Deserialize(AttributeData data)
        {
        }
    }
}