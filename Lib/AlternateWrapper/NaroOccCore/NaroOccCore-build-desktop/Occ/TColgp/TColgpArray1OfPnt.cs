#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.TColgp;

#endregion

namespace NaroCppCore.Occ.TColgp
{
	public class TColgpArray1OfPnt : NativeInstancePtr
	{
		public TColgpArray1OfPnt(int Low,int Up)
 :
			base(TColgp_Array1OfPnt_Ctor5107F6FE(Low, Up) )
		{}
		public TColgpArray1OfPnt(gpPnt Item,int Low,int Up)
 :
			base(TColgp_Array1OfPnt_CtorABE6CB63(Item.Instance, Low, Up) )
		{}
			public void Init(gpPnt V)
				{
					TColgp_Array1OfPnt_Init9EAECD5B(Instance, V.Instance);
				}
			public TColgpArray1OfPnt Assign(TColgpArray1OfPnt Other)
				{
					return new TColgpArray1OfPnt(TColgp_Array1OfPnt_AssignFABD0F95(Instance, Other.Instance));
				}
			public void SetValue(int Index,gpPnt Value)
				{
					TColgp_Array1OfPnt_SetValue7B5D1E58(Instance, Index, Value.Instance);
				}
			public gpPnt Value(int Index)
				{
					return new gpPnt(TColgp_Array1OfPnt_ValueE8219145(Instance, Index));
				}
			public gpPnt ChangeValue(int Index)
				{
					return new gpPnt(TColgp_Array1OfPnt_ChangeValueE8219145(Instance, Index));
				}
		public bool IsAllocated{
			get {
				return TColgp_Array1OfPnt_IsAllocated(Instance);
			}
		}
		public int Length{
			get {
				return TColgp_Array1OfPnt_Length(Instance);
			}
		}
		public int Lower{
			get {
				return TColgp_Array1OfPnt_Lower(Instance);
			}
		}
		public int Upper{
			get {
				return TColgp_Array1OfPnt_Upper(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColgp_Array1OfPnt_Ctor5107F6FE(int Low,int Up);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColgp_Array1OfPnt_CtorABE6CB63(IntPtr Item,int Low,int Up);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColgp_Array1OfPnt_Init9EAECD5B(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColgp_Array1OfPnt_AssignFABD0F95(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColgp_Array1OfPnt_SetValue7B5D1E58(IntPtr instance, int Index,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColgp_Array1OfPnt_ValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColgp_Array1OfPnt_ChangeValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TColgp_Array1OfPnt_IsAllocated(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColgp_Array1OfPnt_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColgp_Array1OfPnt_Lower(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColgp_Array1OfPnt_Upper(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TColgpArray1OfPnt() { } 

		public TColgpArray1OfPnt(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TColgpArray1OfPnt_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TColgpArray1OfPnt_Dtor(IntPtr instance);
	}
}
