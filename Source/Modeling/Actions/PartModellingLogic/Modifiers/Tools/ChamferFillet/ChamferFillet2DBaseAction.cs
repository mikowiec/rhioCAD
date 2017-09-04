#region Usings

using System.Collections.Generic;
using NaroConstants.Names;
using NaroCppCore.Occ.TopAbs;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Modifiers.Tools.ChamferFillet
{
    public abstract class ChamferFillet2DBaseAction : ChamferFilletBaseAction
    {
        protected ChamferFillet2DBaseAction(string modifierName) : base(modifierName)
        {
        }

        protected void BuildSelectionList()
        {
            var entities =
                Inputs[InputNames.SelectionContainerPipe].GetData(NotificationNames.GetEntities).Get
                    <List<SceneSelectedEntity>>();
            SelectedShapes = new List<SceneSelectedEntity>();

            foreach (var entity in entities)
            {
                if ((entity.ShapeType == TopAbsShapeEnum.TopAbs_WIRE) ||
                    (entity.ShapeType == TopAbsShapeEnum.TopAbs_EDGE))
                    SelectedShapes.Add(entity);
            }
        }
    }
}