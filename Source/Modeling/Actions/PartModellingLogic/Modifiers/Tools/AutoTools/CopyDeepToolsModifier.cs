#region Usings

using System.Collections.Generic;
using ErrorReportCommon.Messages;
using Naro.Infrastructure.Library.Geometry;
using NaroPipes.Constants;
using OccCode;
using TreeData.NaroData;

#endregion

namespace PartModellingLogic.Modifiers.Tools.AutoTools
{
    internal class CopyDeepToolsModifier : ModifierTwoShapesCommon
    {
        private List<Node> _listTools;

        public CopyDeepToolsModifier()
            : base(ModifierNames.CopyDeepTools)
        {
        }

        protected override void DocumentCommitReason()
        {
            Document.Commit("Copy tools");
        }

        protected override bool ApplyFunction()
        {
            var sourceShape = FirstShape;
            var destinationShape = SecondShape;

            return CopyModifiersToShape(sourceShape, destinationShape);
        }

        private bool CopyModifiersToShape(Node sourceShape, Node destinationShape)
        {
            var root = Document.Root;
            var impactedValues = ComputeImpactedValues(sourceShape, root);
            if (impactedValues.Count != 0)
            {
                NaroMessage.Show("You should apply a list of tools without branches");
                return false;
            }
            if (_listTools.Count == 0)
            {
                NaroMessage.Show("No tool to apply!");
                return false;
            }

            foreach (var tool in _listTools)
            {
                var generatedTool = NodeUtils.ApplyToolOnOtherShape(Document, tool, destinationShape);
                if (!generatedTool.LastExecute)
                {
                    NaroMessage.Show("Error on generating tool chain. Quitting...");
                    return false;
                }
                destinationShape = generatedTool.Node;
            }
            return true;
        }

        private List<int> ComputeImpactedValues(Node sourceShape, Node root)
        {
            _listTools = new List<Node>();
            var impactedValues = GeomUtils.GetReferencingValues(sourceShape);
            while (impactedValues.Count == 1)
            {
                var addedNode = root[impactedValues[0]];
                _listTools.Add(addedNode);
                impactedValues = GeomUtils.GetReferencingValues(addedNode);
            }
            return impactedValues;
        }
    }
}