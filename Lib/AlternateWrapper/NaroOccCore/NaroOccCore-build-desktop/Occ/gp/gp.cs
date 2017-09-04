#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.gp
{
	public class gp : NativeInstancePtr
	{
		public static double Resolution{
			get {
				return gp_Resolution();
			}
		}
		public static gpPnt Origin{
			get {
				return new gpPnt(gp_Origin());
			}
		}
		public static gpDir DX{
			get {
				return new gpDir(gp_DX());
			}
		}
		public static gpDir DY{
			get {
				return new gpDir(gp_DY());
			}
		}
		public static gpDir DZ{
			get {
				return new gpDir(gp_DZ());
			}
		}
		public static gpAx1 OX{
			get {
				return new gpAx1(gp_OX());
			}
		}
		public static gpAx1 OY{
			get {
				return new gpAx1(gp_OY());
			}
		}
		public static gpAx1 OZ{
			get {
				return new gpAx1(gp_OZ());
			}
		}
		public static gpAx2 XOY{
			get {
				return new gpAx2(gp_XOY());
			}
		}
		public static gpAx2 ZOX{
			get {
				return new gpAx2(gp_ZOX());
			}
		}
		public static gpAx2 YOZ{
			get {
				return new gpAx2(gp_YOZ());
			}
		}
		public static gpPnt2d Origin2d{
			get {
				return new gpPnt2d(gp_Origin2d());
			}
		}
		public static gpDir2d DX2d{
			get {
				return new gpDir2d(gp_DX2d());
			}
		}
		public static gpDir2d DY2d{
			get {
				return new gpDir2d(gp_DY2d());
			}
		}
		public static gpAx2d OX2d{
			get {
				return new gpAx2d(gp_OX2d());
			}
		}
		public static gpAx2d OY2d{
			get {
				return new gpAx2d(gp_OY2d());
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern double gp_Resolution();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Origin();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_DX();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_DY();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_DZ();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_OX();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_OY();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_OZ();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_XOY();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_ZOX();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_YOZ();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_Origin2d();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_DX2d();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_DY2d();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_OX2d();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr gp_OY2d();

		#region NativeInstancePtr Convert constructor

		public gp() { } 

		public gp(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ gp_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void gp_Dtor(IntPtr instance);
	}
}
