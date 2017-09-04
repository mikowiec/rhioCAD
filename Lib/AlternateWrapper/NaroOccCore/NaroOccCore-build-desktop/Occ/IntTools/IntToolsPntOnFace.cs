#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsPntOnFace : NativeInstancePtr
	{
		public IntToolsPntOnFace()
 :
			base(IntTools_PntOnFace_Ctor() )
		{}
			public void Init(TopoDSFace aF,gpPnt aP,double U,double V)
				{
					IntTools_PntOnFace_InitB2FF1B6E(Instance, aF.Instance, aP.Instance, U, V);
				}
			public void SetParameters(double U,double V)
				{
					IntTools_PntOnFace_SetParameters9F0E714F(Instance, U, V);
				}
			public void Parameters(ref double U,ref double V)
				{
					IntTools_PntOnFace_Parameters9F0E714F(Instance, ref U, ref V);
				}
		public bool Valid{
			set { 
				IntTools_PntOnFace_SetValid(Instance, value);
			}
			get {
				return IntTools_PntOnFace_Valid(Instance);
			}
		}
		public TopoDSFace Face{
			set { 
				IntTools_PntOnFace_SetFace(Instance, value.Instance);
			}
			get {
				return new TopoDSFace(IntTools_PntOnFace_Face(Instance));
			}
		}
		public gpPnt Pnt{
			set { 
				IntTools_PntOnFace_SetPnt(Instance, value.Instance);
			}
			get {
				return new gpPnt(IntTools_PntOnFace_Pnt(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOnFace_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_InitB2FF1B6E(IntPtr instance, IntPtr aF,IntPtr aP,double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_SetParameters9F0E714F(IntPtr instance, double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_Parameters9F0E714F(IntPtr instance, ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_SetValid(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_PntOnFace_Valid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_SetFace(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOnFace_Face(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_PntOnFace_SetPnt(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_PntOnFace_Pnt(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsPntOnFace(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsPntOnFace_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsPntOnFace_Dtor(IntPtr instance);
	}
}
