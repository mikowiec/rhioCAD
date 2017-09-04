namespace NaroUiBuilder.RibbonMapping
{
    public class UiMappingConcretePathFactory : ConcretePathFactory
    {
        private readonly UiMappingItem _mappingItem;

        public UiMappingConcretePathFactory(UiMappingItem mappingItem)
        {
            _mappingItem = mappingItem;
        }

        public override void UpdateUi()
        {
            Control = _mappingItem.Control;
        }

        public override void AddChildrenToParent()
        {
            //empty... the control is self contained so have no children
        }
    }
}