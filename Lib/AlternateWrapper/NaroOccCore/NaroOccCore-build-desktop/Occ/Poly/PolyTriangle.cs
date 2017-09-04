#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.Poly
{
	public class PolyTriangle : NativeInstancePtr
	{
		public PolyTriangle()
 :
			base(Poly_Triangle_Ctor() )
		{}
		public PolyTriangle(int N1,int N2,int N3)
 :
			base(Poly_Triangle_CtorE278791(N1, N2, N3) )
		{}
			public void Set(int N1,int N2,int N3)
				{
					Poly_Triangle_SetE278791(Instance, N1, N2, N3);
				}
			public void Set(int Index,int Node)
				{
					Poly_Triangle_Set5107F6FE(Instance, Index, Node);
				}
			public void Get(ref int N1,ref int N2,ref int N3)
				{
					Poly_Triangle_GetE278791(Instance, ref N1, ref N2, ref N3);
				}
			public int Value(int Index)
				{
					return Poly_Triangle_ValueE8219145(Instance, Index);
				}
			public int ChangeValue(int Index)
				{
					return Poly_Triangle_ChangeValueE8219145(Instance, Index);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangle_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangle_CtorE278791(int N1,int N2,int N3);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Triangle_SetE278791(IntPtr instance, int N1,int N2,int N3);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Triangle_Set5107F6FE(IntPtr instance, int Index,int Node);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Triangle_GetE278791(IntPtr instance, ref int N1,ref int N2,ref int N3);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Triangle_ValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Triangle_ChangeValueE8219145(IntPtr instance, int Index);

		#region NativeInstancePtr Convert constructor

		public PolyTriangle(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PolyTriangle_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PolyTriangle_Dtor(IntPtr instance);
	}
}
