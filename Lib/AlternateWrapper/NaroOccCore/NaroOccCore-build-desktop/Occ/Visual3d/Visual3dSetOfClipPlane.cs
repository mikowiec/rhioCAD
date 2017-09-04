#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dSetOfClipPlane : NativeInstancePtr
	{
		public Visual3dSetOfClipPlane()
 :
			base(Visual3d_SetOfClipPlane_Ctor() )
		{}
			public void Clear()
				{
					Visual3d_SetOfClipPlane_Clear(Instance);
				}
			public bool Add(Visual3dClipPlane T)
				{
					return Visual3d_SetOfClipPlane_Add97234D4A(Instance, T.Instance);
				}
			public bool Remove(Visual3dClipPlane T)
				{
					return Visual3d_SetOfClipPlane_Remove97234D4A(Instance, T.Instance);
				}
			public void Union(Visual3dSetOfClipPlane B)
				{
					Visual3d_SetOfClipPlane_Union129D9308(Instance, B.Instance);
				}
			public void Intersection(Visual3dSetOfClipPlane B)
				{
					Visual3d_SetOfClipPlane_Intersection129D9308(Instance, B.Instance);
				}
			public void Difference(Visual3dSetOfClipPlane B)
				{
					Visual3d_SetOfClipPlane_Difference129D9308(Instance, B.Instance);
				}
			public bool Contains(Visual3dClipPlane T)
				{
					return Visual3d_SetOfClipPlane_Contains97234D4A(Instance, T.Instance);
				}
			public bool IsASubset(Visual3dSetOfClipPlane S)
				{
					return Visual3d_SetOfClipPlane_IsASubset129D9308(Instance, S.Instance);
				}
			public bool IsAProperSubset(Visual3dSetOfClipPlane S)
				{
					return Visual3d_SetOfClipPlane_IsAProperSubset129D9308(Instance, S.Instance);
				}
		public int Extent{
			get {
				return Visual3d_SetOfClipPlane_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return Visual3d_SetOfClipPlane_IsEmpty(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_SetOfClipPlane_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfClipPlane_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_Add97234D4A(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_Remove97234D4A(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfClipPlane_Union129D9308(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfClipPlane_Intersection129D9308(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_SetOfClipPlane_Difference129D9308(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_Contains97234D4A(IntPtr instance, IntPtr T);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_IsASubset129D9308(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_IsAProperSubset129D9308(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_SetOfClipPlane_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_SetOfClipPlane_IsEmpty(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dSetOfClipPlane(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dSetOfClipPlane_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dSetOfClipPlane_Dtor(IntPtr instance);
	}
}
