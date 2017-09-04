#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsDSFiller : NativeInstancePtr
	{
		public BOPToolsDSFiller()
 :
			base(BOPTools_DSFiller_Ctor() )
		{}
			public void SetShapes(TopoDSShape aS1,TopoDSShape aS2)
				{
					BOPTools_DSFiller_SetShapes877A736F(Instance, aS1.Instance, aS2.Instance);
				}
			public void Perform()
				{
					BOPTools_DSFiller_Perform(Instance);
				}
			public void InitFillersAndPools()
				{
					BOPTools_DSFiller_InitFillersAndPools(Instance);
				}
			public void ToCompletePerform()
				{
					BOPTools_DSFiller_ToCompletePerform(Instance);
				}
			public static int TreatCompound(TopoDSShape theShape,TopoDSShape theShapeResult)
				{
					return BOPTools_DSFiller_TreatCompound877A736F(theShape.Instance, theShapeResult.Instance);
				}
		public TopoDSShape Shape1{
			get {
				return new TopoDSShape(BOPTools_DSFiller_Shape1(Instance));
			}
		}
		public TopoDSShape Shape2{
			get {
				return new TopoDSShape(BOPTools_DSFiller_Shape2(Instance));
			}
		}
		public bool IsNewFiller{
			get {
				return BOPTools_DSFiller_IsNewFiller(Instance);
			}
		}
		public bool NewFiller{
			set { 
				BOPTools_DSFiller_SetNewFiller(Instance, value);
			}
		}
		public bool IsDone{
			get {
				return BOPTools_DSFiller_IsDone(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_DSFiller_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_DSFiller_SetShapes877A736F(IntPtr instance, IntPtr aS1,IntPtr aS2);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_DSFiller_Perform(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_DSFiller_InitFillersAndPools(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_DSFiller_ToCompletePerform(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_DSFiller_TreatCompound877A736F(IntPtr theShape,IntPtr theShapeResult);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_DSFiller_Shape1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_DSFiller_Shape2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_DSFiller_IsNewFiller(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_DSFiller_SetNewFiller(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_DSFiller_IsDone(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsDSFiller(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsDSFiller_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsDSFiller_Dtor(IntPtr instance);
	}
}
