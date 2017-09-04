#region Usings

using System;
using MetaActionFakesInterface;
using NaroUiBuilder;
using NUnit.Framework;

#endregion

namespace PluginTests.Common
{
    public abstract class ModifierRegisterBase : MetaActionsTestBase
    {
        protected static void CheckRibbonButton(UiBuilder uiBuilder, string path, Type type)
        {
            var factory = uiBuilder.Factory;
            Assert.IsNotNull(factory);
            var cursor = factory.GetPathElement(path);
            Assert.IsNotNull(cursor);
            var concreteFactory = cursor.Factory;
            Assert.IsNotNull(concreteFactory);
            concreteFactory.UpdateUi();
            var control = concreteFactory.Control;
            Assert.IsNotNull(control);
            Assert.IsInstanceOfType(type, control);
        }
    }
}