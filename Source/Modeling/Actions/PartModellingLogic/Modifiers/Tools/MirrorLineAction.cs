#region Usings

using System;
using NaroConstants.Names;
using NaroPipes.Constants;
using OccCode;
using ShapeFunctionsInterface.Utils;
using TreeData.Capabilities;
using TreeData.NaroData;
using TreeData.Utils;

#endregion

namespace PartModellingLogic.Modifiers.Tools
{
    public class MirrorLineAction : MirrorActionCommon
    {
        private CapabilitiesCollection _collection;

        public MirrorLineAction()
            : base(ModifierNames.MirrorLine, FunctionNames.MirrorLine)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            DependsOn(InputNames.GlobalCapabilitiesInput);
        }

        private bool IsNodeValid(int dependencyIndex, Node node)
        {
            var builder = new NodeBuilder(node);
            if (dependencyIndex != 1)
                return true;
            if (!_collection.HasConcept(builder.FunctionName))
                return false;
            if (!_collection.IsRelatedWith(builder.FunctionName, ConceptNames.Axis))
                return false;
            try
            {
                var axis = GeomUtils.ExtractAxis(builder.Shape);
                Ensure.IsNotNull(axis);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override void OnShapePicked(Node node)
        {
            if (!IsNodeValid(SelectedNodes.Count, node))
                return;
            if (SelectedNodes.Count > 0 && SelectedNodes[0].Index == node.Index)
                return;
            SelectShape(node);
            SelectedNodes.Add(node);
            UpdateShapeSelection();
        }

        protected override void AddShapeToScene()
        {
            var axisBuilder = new NodeBuilder(SelectedNodes[1]);
            var axis = GeomUtils.ExtractAxis(axisBuilder.TransformedShape);
            Builder[1].TransformedAxis3D = axis;
        }

        public override void OnActivate()
        {
            base.OnActivate();
            _collection = Inputs[InputNames.GlobalCapabilitiesInput].Get<CapabilitiesCollection>();
        }
    }
}