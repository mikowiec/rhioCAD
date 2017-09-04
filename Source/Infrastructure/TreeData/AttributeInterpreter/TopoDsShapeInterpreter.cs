#region Usings

using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopLoc;
using NaroCppCore.Occ.TopoDS;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class TopoDsShapeInterpreter : AttributeInterpreterBase
    {
        private bool _registered;

        private TopoDSShape _value;

        public TopoDSShape Shape
        {
            get { return _value; }
            set
            {
                _value = value;

                if (!_registered)
                {
                    Parent.OnModified += OnReferencedModified;
                    _registered = true;
                }

                if (_value != null)
                {
                    var transform = ExtractNodeTransform();

                    //if (transform != null)
                    //    _value.Location(new TopLocLocation(transform));
                    var myBRepTransformation = new BRepBuilderAPITransform(transform);
                    myBRepTransformation.Perform(value, false);
                    if (!myBRepTransformation.IsDone)
                        return;
                    _value = myBRepTransformation.Shape;
                }

                OnModified();
            }
        }

        private gpTrsf ExtractNodeTransform()
        {
            if (Shape == null)
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

        private void RegenerateShape()
        {
            var transform = ExtractNodeTransform();

            if (transform != null)
            {
                OnModified();
            }
            ;  //_value.Location = new TopLocLocation(transform);
        }


        public override void OnRemove()
        {
            if (!_registered) return;
            Parent.OnModified -= OnReferencedModified;
        }

        private void OnReferencedModified(Node node, AttributeInterpreterBase atttributeName)
        {
            if (!(atttributeName is TransformationInterpreter)) return;

            RegenerateShape();
        }

        public override void Serialize(AttributeData data)
        {
        }

        public override void Deserialize(AttributeData data)
        {
        }
    }
}