#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BRepPrimAPI
{
	public class BRepPrimAPIMakeBox : BRepBuilderAPIMakeShape
	{
		public BRepPrimAPIMakeBox(double dx,double dy,double dz)
 :
			base(BRepPrimAPI_MakeBox_Ctor9282A951(dx, dy, dz) )
		{}
		public BRepPrimAPIMakeBox(gpPnt P,double dx,double dy,double dz)
 :
			base(BRepPrimAPI_MakeBox_Ctor22BACD62(P.Instance, dx, dy, dz) )
		{}
		public BRepPrimAPIMakeBox(gpPnt P1,gpPnt P2)
 :
			base(BRepPrimAPI_MakeBox_Ctor5C63477E(P1.Instance, P2.Instance) )
		{}
		public BRepPrimAPIMakeBox(gpAx2 Axes,double dx,double dy,double dz)
 :
			base(BRepPrimAPI_MakeBox_CtorF0200AF(Axes.Instance, dx, dy, dz) )
		{}
			public void Build()
				{
					BRepPrimAPI_MakeBox_Build(Instance);
				}
		public TopoDSShell Shell{
			get {
				return new TopoDSShell(BRepPrimAPI_MakeBox_Shell(Instance));
			}
		}
		public TopoDSSolid Solid{
			get {
				return new TopoDSSolid(BRepPrimAPI_MakeBox_Solid(Instance));
			}
		}
		public TopoDSFace BottomFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_BottomFace(Instance));
			}
		}
		public TopoDSFace BackFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_BackFace(Instance));
			}
		}
		public TopoDSFace FrontFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_FrontFace(Instance));
			}
		}
		public TopoDSFace LeftFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_LeftFace(Instance));
			}
		}
		public TopoDSFace RightFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_RightFace(Instance));
			}
		}
		public TopoDSFace TopFace{
			get {
				return new TopoDSFace(BRepPrimAPI_MakeBox_TopFace(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_Ctor9282A951(double dx,double dy,double dz);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_Ctor22BACD62(IntPtr P,double dx,double dy,double dz);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_Ctor5C63477E(IntPtr P1,IntPtr P2);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_CtorF0200AF(IntPtr Axes,double dx,double dy,double dz);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPI_MakeBox_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_Shell(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_Solid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_BottomFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_BackFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_FrontFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_LeftFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_RightFace(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepPrimAPI_MakeBox_TopFace(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepPrimAPIMakeBox() { } 

		public BRepPrimAPIMakeBox(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepPrimAPIMakeBox_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepPrimAPIMakeBox_Dtor(IntPtr instance);
	}
}
