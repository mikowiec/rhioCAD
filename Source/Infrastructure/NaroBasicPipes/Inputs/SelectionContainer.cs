#region Usings

using System.Collections.Generic;
using System.Linq;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopAbs;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;

#endregion

namespace NaroBasicPipes.Inputs
{
    /// <summary>
    ///   Detects selected shapes from scene and populates lists with them.
    ///   It works on neutral points and also on local contexts.
    /// </summary>
    public class SelectionContainer : InteractionContainer
    {
        public SceneSelectedEntity selectedFace;

        public SelectionContainer(GeomUtilsWrapper geomUtilsWrapper)
        {
            InitSelectionContainer();
            _geomUtilsWrapper = geomUtilsWrapper;
        }

        public AISInteractiveContext Context { private get; set; }

        private void InitSelectionContainer()
        {
            _supportedSelections.Add(TopAbsShapeEnum.TopAbs_VERTEX);
            _supportedSelections.Add(TopAbsShapeEnum.TopAbs_EDGE);
            _supportedSelections.Add(TopAbsShapeEnum.TopAbs_FACE);
            _supportedSelections.Add(TopAbsShapeEnum.TopAbs_SOLID);

            CurrentSelectionMode = TopAbsShapeEnum.TopAbs_SOLID;

            foreach (var selectionMode in _supportedSelections)
                InitSelectionList(selectionMode);
        }

        public void SwitchSelectionMode(TopAbsShapeEnum selectionMode)
        {
            CurrentSelectionMode = selectionMode;
            CleanupDetectionEnvironment();

            if (selectionMode == TopAbsShapeEnum.TopAbs_SOLID) return;

            if (Context == null) return;
            Context.OpenLocalContext(true, true, false, false);
            Context.ActivateStandardMode(selectionMode);
        }

        public void CleanupDetectionEnvironment()
        {
            ClearAllSelections();

            if (Context != null)
                Context.CloseAllContexts(false);
        }

        public void BuildSelections(Mouse3DPosition mousePosition)
        {
            ClearSelectionList(CurrentSelectionMode);

            if (CurrentSelectionMode == TopAbsShapeEnum.TopAbs_SOLID)
                BuildNeutralPointSelections(mousePosition);
            else
                BuildLocalContextSelections();
        }

        public void BuildSelections(List<int> selectedNodesIndexes)
        {
            var selectedEntities = new List<SceneSelectedEntity>();
            selectedEntities.Clear();
            foreach (var nodeIndex in selectedNodesIndexes)
                selectedEntities.Add(new SceneSelectedEntity(Document.Root[nodeIndex]) { ShapeType = TopAbsShapeEnum.TopAbs_COMPOUND });
            Selection[CurrentSelectionMode].AddRange(selectedEntities);
        }

        private void BuildNeutralPointSelections(Mouse3DPosition mousePosition)
        {
            var aisNodes = NodeBuilderUtils.IdentifyAisSelectedNodes(Document.Root);
            var selectedEntities = new List<SceneSelectedEntity>();
            selectedEntities.Clear();
            foreach (var aisNode in aisNodes)
                selectedEntities.Add(new SceneSelectedEntity(aisNode) {ShapeType = TopAbsShapeEnum.TopAbs_SOLID});
            Selection[CurrentSelectionMode].AddRange(selectedEntities);
            DetectFacesUnderMouseClick(selectedEntities, mousePosition);
        }

        private void BuildLocalContextSelections()
        {
            List<SceneSelectedEntity> detectedShapes;
            var geomUtilsWrapper = new GeomUtilsWrapper();
            if (CurrentSelectionMode == TopAbsShapeEnum.TopAbs_FACE)
            {
                detectedShapes = geomUtilsWrapper.IdentifyDetectedNodes(Document.Root);
                if (detectedShapes.Count > 0)
                    Selection[CurrentSelectionMode].AddRange(detectedShapes);
            }
            if ((CurrentSelectionMode != TopAbsShapeEnum.TopAbs_EDGE) &&
                (CurrentSelectionMode != TopAbsShapeEnum.TopAbs_VERTEX)) return;
            detectedShapes = geomUtilsWrapper.IdentifySelectedNodes(Document.Root);
            if (detectedShapes.Count > 0)
            {
                Selection[CurrentSelectionMode].AddRange(detectedShapes);
                return;
            }
            detectedShapes = geomUtilsWrapper.IdentifyDetectedNodes(Document.Root);
            if (detectedShapes.Count > 0)
                Selection[CurrentSelectionMode].AddRange(detectedShapes);
        }
    }
}