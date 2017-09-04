#region Usings

using NaroConstants.Names;
using NaroPipes.Actions;
using TreeData.AttributeInterpreter;

#endregion

namespace PartModellingLogic.Inputs.Naro.Infrastructure
{
    internal class SelectionContextInput : InputBase
    {
        private SceneSelectedEntity _entity;

        public SelectionContextInput()
            : base(InputNames.SelectionContext)
        {
        }

        public override void OnRegister()
        {
            base.OnRegister();
            AddNotificationHandler(NotificationNames.Selected, OnSelected);
            AddNotificationHandler(NotificationNames.GetValue, OnGetValue);
        }

        private void OnGetValue(DataPackage data)
        {
            ReturnData = new DataPackage(_entity);
        }

        private void OnSelected(DataPackage dataPackage)
        {
            _entity = dataPackage.Get<SceneSelectedEntity>();
        }
    }
}