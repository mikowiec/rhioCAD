#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Poly;

#endregion

namespace NaroCppCore.Occ.Poly
{
	public class PolyArray1OfTriangle : NativeInstancePtr
	{
		public PolyArray1OfTriangle(int Low,int Up)
 :
			base(Poly_Array1OfTriangle_Ctor5107F6FE(Low, Up) )
		{}
		public PolyArray1OfTriangle(PolyTriangle Item,int Low,int Up)
 :
			base(Poly_Array1OfTriangle_Ctor522DB52C(Item.Instance, Low, Up) )
		{}
			public void Init(PolyTriangle V)
				{
					Poly_Array1OfTriangle_Init170E771E(Instance, V.Instance);
				}
			public PolyArray1OfTriangle Assign(PolyArray1OfTriangle Other)
				{
					return new PolyArray1OfTriangle(Poly_Array1OfTriangle_Assign8767CC10(Instance, Other.Instance));
				}
			public void SetValue(int Index,PolyTriangle Value)
				{
					Poly_Array1OfTriangle_SetValue9D4F3515(Instance, Index, Value.Instance);
				}
			public PolyTriangle Value(int Index)
				{
					return new PolyTriangle(Poly_Array1OfTriangle_ValueE8219145(Instance, Index));
				}
			public PolyTriangle ChangeValue(int Index)
				{
					return new PolyTriangle(Poly_Array1OfTriangle_ChangeValueE8219145(Instance, Index));
				}
		public bool IsAllocated{
			get {
				return Poly_Array1OfTriangle_IsAllocated(Instance);
			}
		}
		public int Length{
			get {
				return Poly_Array1OfTriangle_Length(Instance);
			}
		}
		public int Lower{
			get {
				return Poly_Array1OfTriangle_Lower(Instance);
			}
		}
		public int Upper{
			get {
				return Poly_Array1OfTriangle_Upper(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Array1OfTriangle_Ctor5107F6FE(int Low,int Up);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Array1OfTriangle_Ctor522DB52C(IntPtr Item,int Low,int Up);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Array1OfTriangle_Init170E771E(IntPtr instance, IntPtr V);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Array1OfTriangle_Assign8767CC10(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Array1OfTriangle_SetValue9D4F3515(IntPtr instance, int Index,IntPtr Value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Array1OfTriangle_ValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Array1OfTriangle_ChangeValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Poly_Array1OfTriangle_IsAllocated(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Array1OfTriangle_Length(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Array1OfTriangle_Lower(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Array1OfTriangle_Upper(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PolyArray1OfTriangle() { } 

		public PolyArray1OfTriangle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PolyArray1OfTriangle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PolyArray1OfTriangle_Dtor(IntPtr instance);
	}
}
