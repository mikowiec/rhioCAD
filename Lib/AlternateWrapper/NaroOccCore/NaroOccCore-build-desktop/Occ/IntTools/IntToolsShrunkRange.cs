#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.IntTools;
using NaroCppCore.Occ.Bnd;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.IntTools
{
	public class IntToolsShrunkRange : NativeInstancePtr
	{
		public IntToolsShrunkRange()
 :
			base(IntTools_ShrunkRange_Ctor() )
		{}
			public void Perform()
				{
					IntTools_ShrunkRange_Perform(Instance);
				}
		public IntToolsRange ShrunkRange{
			set { 
				IntTools_ShrunkRange_SetShrunkRange(Instance, value.Instance);
			}
			get {
				return new IntToolsRange(IntTools_ShrunkRange_ShrunkRange(Instance));
			}
		}
		public BndBox BndBox{
			get {
				return new BndBox(IntTools_ShrunkRange_BndBox(Instance));
			}
		}
		public TopoDSEdge Edge{
			get {
				return new TopoDSEdge(IntTools_ShrunkRange_Edge(Instance));
			}
		}
		public bool IsDone{
			get {
				return IntTools_ShrunkRange_IsDone(Instance);
			}
		}
		public int ErrorStatus{
			get {
				return IntTools_ShrunkRange_ErrorStatus(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_ShrunkRange_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_ShrunkRange_Perform(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IntTools_ShrunkRange_SetShrunkRange(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_ShrunkRange_ShrunkRange(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_ShrunkRange_BndBox(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IntTools_ShrunkRange_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IntTools_ShrunkRange_IsDone(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IntTools_ShrunkRange_ErrorStatus(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IntToolsShrunkRange(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IntToolsShrunkRange_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IntToolsShrunkRange_Dtor(IntPtr instance);
	}
}
