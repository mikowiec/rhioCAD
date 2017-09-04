#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepPrimAPI;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BRepOffsetAPI
{
	public class BRepOffsetAPIMakePipe : BRepPrimAPIMakeSweep
	{
		public BRepOffsetAPIMakePipe(TopoDSWire Spine,TopoDSShape Profile)
 :
			base(BRepOffsetAPI_MakePipe_Ctor6D9C9186(Spine.Instance, Profile.Instance) )
		{}
			public void Build()
				{
					BRepOffsetAPI_MakePipe_Build(Instance);
				}
			public TopoDSShape Generated(TopoDSShape SSpine,TopoDSShape SProfile)
				{
					return new TopoDSShape(BRepOffsetAPI_MakePipe_Generated877A736F(Instance, SSpine.Instance, SProfile.Instance));
				}
		public TopoDSShape FirstShape{
			get {
				return new TopoDSShape(BRepOffsetAPI_MakePipe_FirstShape(Instance));
			}
		}
		public TopoDSShape LastShape{
			get {
				return new TopoDSShape(BRepOffsetAPI_MakePipe_LastShape(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakePipe_Ctor6D9C9186(IntPtr Spine,IntPtr Profile);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPI_MakePipe_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakePipe_Generated877A736F(IntPtr instance, IntPtr SSpine,IntPtr SProfile);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakePipe_FirstShape(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepOffsetAPI_MakePipe_LastShape(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepOffsetAPIMakePipe() { } 

		public BRepOffsetAPIMakePipe(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepOffsetAPIMakePipe_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepOffsetAPIMakePipe_Dtor(IntPtr instance);
	}
}
