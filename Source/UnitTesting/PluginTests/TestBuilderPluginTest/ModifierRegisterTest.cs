#region Usings

using System;
using NUnit.Framework;
using TestBuilderPlugin;

#endregion

namespace PluginTests.TestBuilderPluginTest
{
    [TestFixture]
    public class ModifierRegisterTest
    {
        private readonly ModifierRegister _sut = new ModifierRegister();

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void RegisterNullArgument()
        {
            _sut.Register(null);
        }
    }
}