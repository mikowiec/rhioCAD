#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dSetOfView : NativeInstancePtr
	{
		public Visual3dSetOfView()
 :
			base(Visual3d_SetOfView_Ctor() )
		{}
			public void Clear()
				{
					Visual3d_SetOfView_Clear(Instance);
				}
			public bool Add(Visual3dView T)
				{
					return Visual3d_SetOfView_Add68FD189(Instance, T.Instance);
				}
			public bool Remove(Visual3dView T)
				{
					return Visual3d_SetOfView_Remove68FD189(Instance, T.Instance);
				}
			public void Union(Visual3dSetOfView B)
				{
					Visual3d_SetOfView_UnionF34A7047(Instance, B.Instance);
				}
			public void Intersection(Visual3dSetOfView B)
				{
					Visual3d_SetOfView_IntersectionF34A7047(Instance, B.Instance);
				}
			public void Difference(Visual3dSetOfView B)
				{
					Visual3d_SetOfView_DifferenceF34A7047(Instance, B.Instance);
				}
			public bool Contains(Visual3dView T)
				{
					return Visual3d_SetOfView_Contains68FD189(Instance, T.Instance);
				}
			public bool IsASubset(Visual3dSetOfView S)
				{
					return Visual3d_SetOfView_IsASubsetF34A7047(Instance, S.Instance);
				}
			public bool IsAProperSubset(Visual3dSetOfView S)
				{
					return Visual3d_SetOfView_IsAProperSubsetF34A7047(Instance, S.Instance);
				}
		public int Extent{
			get {
				return Visual3d_SetOfView_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return Visual3d_SetOfView_IsEmpty(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_SetOfView_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfView_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_Add68FD189(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_Remove68FD189(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfView_UnionF34A7047(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfView_IntersectionF34A7047(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfView_DifferenceF34A7047(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_Contains68FD189(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_IsASubsetF34A7047(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_IsAProperSubsetF34A7047(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_SetOfView_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfView_IsEmpty(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dSetOfView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dSetOfView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dSetOfView_Dtor(IntPtr instance);
	}
}
