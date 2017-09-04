#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dSetOfLight : NativeInstancePtr
	{
		public Visual3dSetOfLight()
 :
			base(Visual3d_SetOfLight_Ctor() )
		{}
			public void Clear()
				{
					Visual3d_SetOfLight_Clear(Instance);
				}
			public bool Add(Visual3dLight T)
				{
					return Visual3d_SetOfLight_Add279ABABC(Instance, T.Instance);
				}
			public bool Remove(Visual3dLight T)
				{
					return Visual3d_SetOfLight_Remove279ABABC(Instance, T.Instance);
				}
			public void Union(Visual3dSetOfLight B)
				{
					Visual3d_SetOfLight_Union4AF300FE(Instance, B.Instance);
				}
			public void Intersection(Visual3dSetOfLight B)
				{
					Visual3d_SetOfLight_Intersection4AF300FE(Instance, B.Instance);
				}
			public void Difference(Visual3dSetOfLight B)
				{
					Visual3d_SetOfLight_Difference4AF300FE(Instance, B.Instance);
				}
			public bool Contains(Visual3dLight T)
				{
					return Visual3d_SetOfLight_Contains279ABABC(Instance, T.Instance);
				}
			public bool IsASubset(Visual3dSetOfLight S)
				{
					return Visual3d_SetOfLight_IsASubset4AF300FE(Instance, S.Instance);
				}
			public bool IsAProperSubset(Visual3dSetOfLight S)
				{
					return Visual3d_SetOfLight_IsAProperSubset4AF300FE(Instance, S.Instance);
				}
		public int Extent{
			get {
				return Visual3d_SetOfLight_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return Visual3d_SetOfLight_IsEmpty(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_SetOfLight_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfLight_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_Add279ABABC(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_Remove279ABABC(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfLight_Union4AF300FE(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfLight_Intersection4AF300FE(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfLight_Difference4AF300FE(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_Contains279ABABC(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_IsASubset4AF300FE(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_IsAProperSubset4AF300FE(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_SetOfLight_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfLight_IsEmpty(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dSetOfLight(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dSetOfLight_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dSetOfLight_Dtor(IntPtr instance);
	}
}
