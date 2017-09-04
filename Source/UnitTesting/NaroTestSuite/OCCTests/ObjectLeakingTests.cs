#region Usings

using System.Diagnostics;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TopoDS;
using NUnit.Framework;


#endregion

namespace NaroTestSuite.OCCTests
{
    [TestFixture]
    public class ObjectLeakingTests
    {
        [Test]
        public void AllocDeallocSimpleTest()
        {
            //NaroMessage.Show("start test");
            //Console.WriteLine("---- wrapper start test ----");
            var watch = new Stopwatch();
            watch.Start();
            for (var i = 0; i < 300000; i++)
            {
                var pnt = new gpPnt(i, i, i);
                var pnt2 = new gpPnt(i + 10, i + 10, i + 10);
                var aEdge = new BRepBuilderAPIMakeEdge(pnt, pnt2).Edge;
                var wire = new BRepBuilderAPIMakeWire(aEdge).Wire;
                TopoDSShape shape = wire;
                new AISShape(shape);

                var pln = new gpPln(i + 10, i + 10, i + 10, i + 10);
                var geomPln = new GeomPlane(pln);
                var trsf = new gpTrsf();
                geomPln.Transform(trsf);
            }

            watch.Stop();
            //Console.WriteLine("---- wrapper end test - took {0} ms ----", watch.ElapsedMilliseconds);

            //NaroMessage.Show(String.Format("---- wrapper end test - took {0} ms ----", watch.ElapsedMilliseconds));
        }
    }
}