#region Usings

using System.Collections.Generic;
using NaroSketchAdapter;
using NaroSketchAdapter.Views;
using ShapeFunctionsInterface.Utils;
using SketchHinter.Primitives;
using TreeData.NaroData;

#endregion

namespace SketchHinter.Algorithms
{
    public abstract class SketchHinterAlgorithmBase
    {
        protected Sketch3DTo2DTranslator CoordinateTranslator;
        protected Hinter2D Hinter2D;
        protected SketchHinterOptions Options;
        private ConstraintDocumentHelper _constraintMapper;
        public List<NodeBuilder> constraintNodes;

        public void Setup(Sketch3DTo2DTranslator coordinateTranslator, SketchHinterOptions options,
                          ConstraintDocumentHelper constraintMapper, Hinter2D hinter2D)
        {
            Hinter2D = hinter2D;
            CoordinateTranslator = coordinateTranslator;
            Options = options;
            _constraintMapper = constraintMapper;
            constraintNodes = new List<NodeBuilder>();
        }

        public virtual void OnRegister()
        {
        }

        protected void AddConstraint(HinterShapeBase shape, string constraintName)
        {
            AddConstraint(shape.Builder.Node, constraintName);
        }

        protected NodeBuilder AddConstraint(HinterShapeBase shape, HinterShapeBase destination, string constraintName)
        {
            if (shape.Builder.Node.Index != destination.Builder.Node.Index)
              return  AddConstraint(shape.Builder.Node, destination.Builder.Node, constraintName);
            return null;
        }

        public abstract bool Apply(HinterShapeBase hinterShape);

        protected NodeBuilder AddConstraint(Node reference, Node node, string constraintName)
        {
            return _constraintMapper.ApplyConstraint(reference, node, constraintName);
        }

        protected void AddConstraint(Node reference, string constraintName)
        {
            _constraintMapper.ApplyConstraint(reference, constraintName);
        }

        public virtual void OnPopulate()
        {
        }
    }
}