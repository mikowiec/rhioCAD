#region Usings

using Naro.Infrastructure.Library.Geometry;
using PropertyDescriptorsInterface;
using PropertyGridTabItems;
using ShapeFunctionsInterface.Functions;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroCAD.Plugin.Structural.Design
{
    internal class BeamTab : GridTabBase
    {
        public BeamTab(string title)
            : base(title)
        {
            // ... do nothing
        }

        protected override void BuildInterface()
        {
            BuildElasticModulusProperty();
            BuildAreaProperty();
            BuildInertiaMomentProperty();
            BuildFirstNodeProperty();
            BuildSecondNodeProperty();
            BuildLengthProperty();
        }

        private void BuildElasticModulusProperty()
        {
            var elasticModulusProperty = new DoublePropertyTabItem();
            elasticModulusProperty.OnGetValue += OnGetElasticModulusValueHandler;
            PropertyListGenerator.AddProperty("E", elasticModulusProperty);
        }

        private void BuildAreaProperty()
        {
            var areaProperty = new DoublePropertyTabItem();
            areaProperty.OnGetValue += OnGetAreaValueHandler;
            PropertyListGenerator.AddProperty("A", areaProperty);
        }

        private void BuildInertiaMomentProperty()
        {
            var inertiaMomentProperty = new DoublePropertyTabItem();
            inertiaMomentProperty.OnGetValue += OnGetInertiaMomentValueHandler;
            PropertyListGenerator.AddProperty("Iz", inertiaMomentProperty);
        }

        private void BuildFirstNodeProperty()
        {
            var firstNodeProperty = new StringPropertyTabItem();
            firstNodeProperty.OnGetValue += OnGetFirstNodeValueHandler;
            PropertyListGenerator.AddProperty("Node 1", firstNodeProperty);
        }

        private void BuildSecondNodeProperty()
        {
            var secondNodeProperty = new StringPropertyTabItem();
            secondNodeProperty.OnGetValue += OnGetSecondNodeValueHandler;
            PropertyListGenerator.AddProperty("Node 2", secondNodeProperty);
        }

        private void BuildLengthProperty()
        {
            var lengthProperty = new DoublePropertyTabItem();
            lengthProperty.OnGetValue += OnGetLengthValueHandler;
            PropertyListGenerator.AddProperty("Length", lengthProperty);
        }

        private void OnGetElasticModulusValueHandler(ref object resultvalue)
        {
            resultvalue = 210000.0;
        }

        private void OnGetAreaValueHandler(ref object resultvalue)
        {
            resultvalue = 100.0;
        }

        private void OnGetInertiaMomentValueHandler(ref object resultvalue)
        {
            resultvalue = 833.0;
        }

        private void OnGetFirstNodeValueHandler(ref object resultvalue)
        {
            var dependency = Builder.Node.Get<FunctionInterpreter>().Dependency;
            var sourceData = dependency[Constant.StepIndexBeamFirstNode].ReferenceData;
            var shapeNode = sourceData.Node;

            resultvalue = shapeNode.Get<StringInterpreter>().Value;
        }

        private void OnGetSecondNodeValueHandler(ref object resultvalue)
        {
            var dependency = Builder.Node.Get<FunctionInterpreter>().Dependency;
            var sourceData = dependency[Constant.StepIndexBeamSecondNode].ReferenceData;
            var shapeNode = sourceData.Node;

            resultvalue = shapeNode.Get<StringInterpreter>().Value;
        }

        private void OnGetLengthValueHandler(ref object resultvalue)
        {
            resultvalue = GetLineLength();
        }

        private double GetLineLength()
        {
            return FirstNode().Distance(SecondNode());
        }

        private Point3D FirstNode()
        {
            return NodeUtils.GetReferencePoint(Builder, Constant.StepIndexBeamFirstNode);
        }

        private Point3D SecondNode()
        {
            return NodeUtils.GetReferencePoint(Builder, Constant.StepIndexBeamSecondNode);
        }
    }
}