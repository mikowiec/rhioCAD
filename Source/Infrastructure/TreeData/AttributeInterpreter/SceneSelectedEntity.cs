#region Usings

using NaroCppCore.Occ.TopAbs;
using NaroCppCore.Occ.TopoDS;
using TreeData.NaroData;

#endregion

namespace TreeData.AttributeInterpreter
{
    public class SceneSelectedEntity
    {
        public SceneSelectedEntity()
        {
        }

        public SceneSelectedEntity(Node node)
        {
            Node = node;
            ShapeType = TopAbsShapeEnum.TopAbs_FACE;
            ShapeCount = 1;
        }

        // Node that holds the main shape
        public Node Node { get; set; }
        // Type of the element this clas describes (points to a face or an edge, etc)
        public TopAbsShapeEnum ShapeType { get; set; }
        // The number of the entity when iterating the mian shape (ex: the edge with numer 3)
        // ! Counting is 1 based
        public int ShapeCount { get; set; }
        // Extracts the subshape to which the SceneSelectedEntity points to
        public TopoDSShape TargetShape()
        {
            var topoDsInterpreter = Node.Get<TopoDsShapeInterpreter>();
            return topoDsInterpreter == null
                       ? null
                       : ShapeUtils.ExtractSubShape(topoDsInterpreter.Shape, ShapeCount, ShapeType);
        }
    }
}