#region Usings

using System.Collections.Generic;
using Naro.Infrastructure.Interface.GeomHelpers;
using NaroBasicPipes.Actions;
using NaroCppCore.Occ.TopAbs;
using OccCode;

using TreeData.AttributeInterpreter;
using TreeData.NaroData;
using NaroCppCore.Occ.Precision;

#endregion

namespace NaroBasicPipes.Inputs
{
    public class InteractionContainer
    {
        protected readonly List<TopAbsShapeEnum> _supportedSelections = new List<TopAbsShapeEnum>();
        protected GeomUtilsWrapper _geomUtilsWrapper;

        public InteractionContainer()
        {
            Selection = new SortedDictionary<TopAbsShapeEnum, List<SceneSelectedEntity>>();
        }

        public Document Document { get; set; }

        public SortedDictionary<TopAbsShapeEnum, List<SceneSelectedEntity>> Selection { get; protected set; }
        public TopAbsShapeEnum CurrentSelectionMode { get; protected set; }

        public List<SceneSelectedEntity> Entities
        {
            get { return Selection[CurrentSelectionMode]; }
        }

        public List<SceneSelectedEntity> this[TopAbsShapeEnum selectionMode]
        {
            get { return !Selection.ContainsKey(selectionMode) ? null : Selection[selectionMode]; }
        }

        protected void InitSelectionList(TopAbsShapeEnum selectMode)
        {
            Selection[selectMode] = new List<SceneSelectedEntity>();
        }

        protected void ClearSelectionList(TopAbsShapeEnum selectMode)
        {
            Selection[selectMode].Clear();
        }

        protected void ClearAllSelections()
        {
            foreach (var selectionMode in _supportedSelections)
                ClearSelectionList(selectionMode);
        }

        protected void DetectFacesUnderMouseClick(IEnumerable<SceneSelectedEntity> selectedEntities,
                                                  Mouse3DPosition mousePosition)
        {
            ClearSelectionList(TopAbsShapeEnum.TopAbs_FACE);
            var facesList = DetectFacesAtCoordinate(selectedEntities, mousePosition);
            Selection[TopAbsShapeEnum.TopAbs_FACE].AddRange(facesList);
        }

        protected static IEnumerable<SceneSelectedEntity> DetectFacesAtCoordinate(
            IEnumerable<SceneSelectedEntity> selectedEntities, Mouse3DPosition mousePosition)
        {
            var detectedFaces = new List<SceneSelectedEntity>();
            foreach (var entity in selectedEntities)
            {
                var detectedFacesOnShape = DetectFacesAtCoordinate(entity, mousePosition);
                if (detectedFacesOnShape.Count > 0)
                    detectedFaces.AddRange(detectedFacesOnShape);
            }
            return detectedFaces;
        }

        protected static List<SceneSelectedEntity> DetectFacesAtCoordinate(SceneSelectedEntity selectedEntity,
                                                                           Mouse3DPosition mousePosition)
        {
            var detectedFaces = new List<SceneSelectedEntity>();

            var faces = GeomUtils.ExtractFaces(selectedEntity.TargetShape());
            var faceNumber = 1;
            foreach (var face in faces)
            {
                var plane = GeomUtils.ExtractPlane(face);
                if ((plane != null) && (plane.Distance(mousePosition.Point.GpPnt) <= Precision.Confusion))
                {
                    var detectedFace = new SceneSelectedEntity(selectedEntity.Node)
                                           {
                                               ShapeType = TopAbsShapeEnum.TopAbs_FACE,
                                               ShapeCount = faceNumber
                                           };
                    detectedFaces.Add(detectedFace);
                }
                faceNumber++;
            }

            return detectedFaces;
        }
    }
}