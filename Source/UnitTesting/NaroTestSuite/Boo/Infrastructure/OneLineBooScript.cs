#region Usings

using BooCoreScript;

#endregion

namespace NaroTestSuite.Boo.Infrastructure
{
    internal class OneLineBooScript : BooScript
    {
        public void Do()
        {
            Line(0, 0, 0, 100, 100, 0);
        }
    }
}