#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsPointBetween : NativeInstancePtr
	{
		public BOPToolsPointBetween()
 :
			base(BOPTools_PointBetween_Ctor() )
		{}
			public void SetUV(double U,double V)
				{
					BOPTools_PointBetween_SetUV9F0E714F(Instance, U, V);
				}
			public void UV(ref double U,ref double V)
				{
					BOPTools_PointBetween_UV9F0E714F(Instance, ref U, ref V);
				}
		public double Parameter{
			set { 
				BOPTools_PointBetween_SetParameter(Instance, value);
			}
			get {
				return BOPTools_PointBetween_Parameter(Instance);
			}
		}
		public gpPnt Pnt{
			set { 
				BOPTools_PointBetween_SetPnt(Instance, value.Instance);
			}
			get {
				return new gpPnt(BOPTools_PointBetween_Pnt(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PointBetween_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PointBetween_SetUV9F0E714F(IntPtr instance, double U,double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PointBetween_UV9F0E714F(IntPtr instance, ref double U,ref double V);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PointBetween_SetParameter(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BOPTools_PointBetween_Parameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PointBetween_SetPnt(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PointBetween_Pnt(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsPointBetween(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsPointBetween_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsPointBetween_Dtor(IntPtr instance);
	}
}
