using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI;
using NaroCAD.Infrastructure.Interface;
using System.Collections;
using NaroCAD.Sketcher.Tests.Support;
using NUnit.Framework;

namespace NaroCAD.Sketcher.Tests
{
    /// <summary>
    /// Summary description for ModuleTestFixture
    /// </summary>
    [TestFixture]
    public class ModuleTestFixture
    {

        [Test]
        public void OnLoadCreateModuleController()
        {
            TestableRootWorkItem rootWorkItem = new TestableRootWorkItem();
            Module moduleInitializer = new Module(rootWorkItem);

            moduleInitializer.Load();

            ICollection<ControlledWorkItem<ModuleController>> controllers =
                rootWorkItem.WorkItems.FindByType<ControlledWorkItem<ModuleController>>();
            Assert.AreEqual(1, controllers.Count);
        }
    }
}
