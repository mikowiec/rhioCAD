#region Usings

using System.Windows.Forms;
using Naro.PartModeling;
using NaroCppCore;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Precision;
using NaroCppCore.Occ.V3d;

//using NaroCppCore.Occ.gp;

#endregion

namespace NaroHost
{
    internal class StartUp
    {
        public static int Main()
        {
            var confusion = Precision.Confusion;
            var mainWindow = new MainWindow();
            var panel = mainWindow.panel1;
            Graphic3dWNTGraphicDevice device = null;
            V3dViewer viewer = null;
            AISInteractiveContext context = null;
            V3dView view;
            OccInitialize.Setup(ref device, ref viewer, ref context, out view, panel);
            //var point = new gpPnt();
            //var secondPoint = point.Convert<gpPnt>();
            //Console.WriteLine(point.X);
            return 0;
        }
    }
}