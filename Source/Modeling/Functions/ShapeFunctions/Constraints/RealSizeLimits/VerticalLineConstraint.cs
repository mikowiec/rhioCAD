#region Usings

using Naro.Infrastructure.Interface.Constraints;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctions.Constraints.RealSizeLimits
{
    public class VerticalLineConstraint : ConstraintBaseInterpterer
    {
        #region Properties

        public Node Value
        {
            set
            {
                OnRemove();
                _node = value;
                _node.OnModified += Execute;
                OnModified();
            }
        }

        #endregion

        #region Overriden methods

        public override void Serialize(AttributeData data)
        {
            if (_node != null)
                data.WriteAttribute("Node", Parent, _node);
        }

        public override void Deserialize(AttributeData data)
        {
            if (!data.HasAttribute("Node")) return;
            _node = data.ReadAttributeReference("Node", Parent);
            OnModified();
        }

        public override void OnRemove()
        {
            if (_node != null)
            {
                _node.OnModified -= Execute;
            }
        }

        #endregion

        #region Methods

        private void Execute(Node node, AttributeInterpreterBase atttributeType)
        {
            var nodePoint = NodeBuilderUtils.GetNodePoint(Parent);
            if (nodePoint == null)
            {
                return;
            }
            var builder = new NodeBuilder(_node);
            var x = builder[0].TransformedPoint3D.X;
            var point = (Point3D) nodePoint;
            point.X = x;
            SetupPointCoordinate(point);
        }

        #endregion

        #region Data members

        private Node _node;

        #endregion
    }
}