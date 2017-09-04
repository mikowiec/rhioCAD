#region Usings

using System;
using System.Collections.Generic;
using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.AttributeInterpreter;

#endregion

namespace MetaActionFakesInterface.MockInputs
{
    public class DirectSelectionContainerPipe : PipeBase
    {
        public DirectSelectionContainerPipe()
            : base(InputNames.SelectionContainerPipe)
        {
        }

        public override void OnRegister()
        {
            DependsOn(InputNames.GeometricSolverPipe);
            AddNotificationHandler(NotificationNames.GetEntities, OnGetEntities);
        }

        private void OnGetEntities(DataPackage data)
        {
            ReturnData=new DataPackage(new List<SceneSelectedEntity>());
        }

        protected override void SourceOnData(string inputName, DataPackage data)
        {
            AddData(data.Data);
        }
    }
}