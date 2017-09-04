#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace ShapeFunctions.Functions.Naro.Tools
{
    /// <summary>
    ///   Describes a subshpe that refers to another shape.
    ///   Ex: it holds a face that belongs to another shape.
    /// </summary>
    public class SubShapeFunction : FunctionBase
    {
        private readonly SortedDictionary<int, TopAbsShapeEnum> _subShapeTypes =
            new SortedDictionary<int, TopAbsShapeEnum>();

        public SubShapeFunction()
            : base(FunctionNames.SubShape)
        {
            // Reference shape that contains the face
            Dependency.AddAttributeType(InterpreterNames.Reference);
            // The number of the face (the n-th face while iterating)
            Dependency.AddAttributeType(InterpreterNames.Integer);
            // Id of subshape type, 0 = face, 1 = point, 2 = edge, 3 = solid, 4 = shape
            Dependency.AddAttributeType(InterpreterNames.Integer);

            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_VERTEX] = TopAbsShapeEnum.TopAbs_VERTEX;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_EDGE] = TopAbsShapeEnum.TopAbs_EDGE;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_WIRE] = TopAbsShapeEnum.TopAbs_WIRE;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_FACE] = TopAbsShapeEnum.TopAbs_FACE;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_SHELL] = TopAbsShapeEnum.TopAbs_SHELL;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_SOLID] = TopAbsShapeEnum.TopAbs_SOLID;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_COMPOUND] = TopAbsShapeEnum.TopAbs_COMPOUND;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_COMPSOLID] = TopAbsShapeEnum.TopAbs_COMPSOLID;
            _subShapeTypes[(int) TopAbsShapeEnum.TopAbs_SHAPE] = TopAbsShapeEnum.TopAbs_SHAPE;
        }

        public override bool Execute()
        {
            var originalShape = Dependency[0].ReferedShape;
            if (originalShape == null)
                return false;
            var facePosition = Dependency[1].Integer;
            TopAbsShapeEnum shapeType;
            var shapeTypeId = Dependency[2].Integer;
            if (_subShapeTypes.ContainsKey(shapeTypeId))
                shapeType = _subShapeTypes[shapeTypeId];
            else
                return false;

            var shape = ShapeUtils.ExtractSubShape(originalShape, facePosition, shapeType);
            if (shape == null)
                return false;
            Shape = shape;
            return true;
        }
    }
}