#region Usages

using System.Windows.Forms;
using ApiCommon;
using ApiGenerators.Forms;

#endregion

namespace ApiGenerators
{
    internal static class MainClass
    {
        public static void Main(string[] args)
        {
            //var api = new DataNode(Consts.Api);
            var api = DataNodeLoader.FromFile("..\\..\\OccWrapper.api");
            var form = new OccTypeFormLookup(api);
            Application.Run(form);

            OccTypeFormLookup.RegenWrapper(api);
        }
    }
}