#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.HLRAlgo;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.HLRAlgo
{
	public class HLRAlgoInterference : NativeInstancePtr
	{
		public HLRAlgoInterference()
 :
			base(HLRAlgo_Interference_Ctor() )
		{}
		public HLRAlgoInterference(HLRAlgoIntersection Inters,HLRAlgoCoincidence Bound,TopAbsOrientation Orient,TopAbsOrientation Trans,TopAbsOrientation BTrans)
 :
			base(HLRAlgo_Interference_Ctor43D8FA96(Inters.Instance, Bound.Instance, (int)Orient, (int)Trans, (int)BTrans) )
		{}
			public void Intersection(HLRAlgoIntersection I)
				{
					HLRAlgo_Interference_Intersection2F323D4D(Instance, I.Instance);
				}
			public void Boundary(HLRAlgoCoincidence B)
				{
					HLRAlgo_Interference_Boundary358C2A26(Instance, B.Instance);
				}
			public void Orientation(TopAbsOrientation O)
				{
					HLRAlgo_Interference_Orientation69EAD1AB(Instance, (int)O);
				}
			public void Transition(TopAbsOrientation Tr)
				{
					HLRAlgo_Interference_Transition69EAD1AB(Instance, (int)Tr);
				}
			public void BoundaryTransition(TopAbsOrientation BTr)
				{
					HLRAlgo_Interference_BoundaryTransition69EAD1AB(Instance, (int)BTr);
				}
			public HLRAlgoIntersection Intersection()
				{
					return new HLRAlgoIntersection(HLRAlgo_Interference_Intersection(Instance));
				}
			public HLRAlgoCoincidence Boundary()
				{
					return new HLRAlgoCoincidence(HLRAlgo_Interference_Boundary(Instance));
				}
			public TopAbsOrientation Orientation()
				{
					return (TopAbsOrientation)HLRAlgo_Interference_Orientation(Instance);
				}
			public TopAbsOrientation Transition()
				{
					return (TopAbsOrientation)HLRAlgo_Interference_Transition(Instance);
				}
			public TopAbsOrientation BoundaryTransition()
				{
					return (TopAbsOrientation)HLRAlgo_Interference_BoundaryTransition(Instance);
				}
		public HLRAlgoIntersection ChangeIntersection{
			get {
				return new HLRAlgoIntersection(HLRAlgo_Interference_ChangeIntersection(Instance));
			}
		}
		public HLRAlgoCoincidence ChangeBoundary{
			get {
				return new HLRAlgoCoincidence(HLRAlgo_Interference_ChangeBoundary(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_Ctor43D8FA96(IntPtr Inters,IntPtr Bound,int Orient,int Trans,int BTrans);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Interference_Intersection2F323D4D(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Interference_Boundary358C2A26(IntPtr instance, IntPtr B);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Interference_Orientation69EAD1AB(IntPtr instance, int O);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Interference_Transition69EAD1AB(IntPtr instance, int Tr);
		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgo_Interference_BoundaryTransition69EAD1AB(IntPtr instance, int BTr);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_Intersection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_Boundary(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Interference_Orientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Interference_Transition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int HLRAlgo_Interference_BoundaryTransition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_ChangeIntersection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr HLRAlgo_Interference_ChangeBoundary(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public HLRAlgoInterference(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ HLRAlgoInterference_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void HLRAlgoInterference_Dtor(IntPtr instance);
	}
}
