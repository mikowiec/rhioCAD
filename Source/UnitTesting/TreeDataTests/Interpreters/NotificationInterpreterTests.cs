#region Usings

using ErrorReportCommon.Messages;
using Extensions.NotificationTree;
using NUnit.Framework;
using PartModellingLogic;
using TreeData.NaroData;

#endregion

namespace TreeDataTests.Interpreters
{
    /// <summary>
    ///   Description of NotificationInterpreterTests.
    /// </summary>
    [TestFixture]
    public class NotificationInterpreterTests
    {
        private Document _document;

        [TestFixtureSetUp]
        public void Setup()
        {
            DefaultInterpreters.Setup();
            _document = new Document();
            _document.Transact();
        }

        private void OnChange(Node pathnode)
        {
            NaroMessage.Show("In notification");
        }

        [Test]
        public void RegisterNotifyAndCall()
        {
            var interpreter = _document.Root.Set<NotificationInterpreter>();
            interpreter.RegisterPath("MyPath/OnChange", OnChange);
            interpreter.NotifyPath("MyPath/OnChange");
        }
    }
}