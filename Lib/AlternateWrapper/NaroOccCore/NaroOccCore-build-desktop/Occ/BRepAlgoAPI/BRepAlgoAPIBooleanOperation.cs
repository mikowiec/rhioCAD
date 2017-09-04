#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BRepBuilderAPI;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.BOP;

#endregion

namespace NaroCppCore.Occ.BRepAlgoAPI
{
	public class BRepAlgoAPIBooleanOperation : BRepBuilderAPIMakeShape
	{
			public void Build()
				{
					BRepAlgoAPI_BooleanOperation_Build(Instance);
				}
			public void RefineEdges()
				{
					BRepAlgoAPI_BooleanOperation_RefineEdges(Instance);
				}
			public bool IsDeleted(TopoDSShape aS)
				{
					return BRepAlgoAPI_BooleanOperation_IsDeleted9EBAC0C0(Instance, aS.Instance);
				}
			public void Destroy()
				{
					BRepAlgoAPI_BooleanOperation_Destroy(Instance);
				}
		public TopoDSShape Shape1{
			get {
				return new TopoDSShape(BRepAlgoAPI_BooleanOperation_Shape1(Instance));
			}
		}
		public TopoDSShape Shape2{
			get {
				return new TopoDSShape(BRepAlgoAPI_BooleanOperation_Shape2(Instance));
			}
		}
		public BOPOperation Operation{
			set { 
				BRepAlgoAPI_BooleanOperation_SetOperation(Instance, (int)value);
			}
			get {
				return (BOPOperation)BRepAlgoAPI_BooleanOperation_Operation(Instance);
			}
		}
		public bool FuseEdges{
			get {
				return BRepAlgoAPI_BooleanOperation_FuseEdges(Instance);
			}
		}
		public bool BuilderCanWork{
			get {
				return BRepAlgoAPI_BooleanOperation_BuilderCanWork(Instance);
			}
		}
		public int ErrorStatus{
			get {
				return BRepAlgoAPI_BooleanOperation_ErrorStatus(Instance);
			}
		}
		public bool HasModified{
			get {
				return BRepAlgoAPI_BooleanOperation_HasModified(Instance);
			}
		}
		public bool HasGenerated{
			get {
				return BRepAlgoAPI_BooleanOperation_HasGenerated(Instance);
			}
		}
		public bool HasDeleted{
			get {
				return BRepAlgoAPI_BooleanOperation_HasDeleted(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPI_BooleanOperation_Build(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPI_BooleanOperation_RefineEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_IsDeleted9EBAC0C0(IntPtr instance, IntPtr aS);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPI_BooleanOperation_Destroy(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_BooleanOperation_Shape1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BRepAlgoAPI_BooleanOperation_Shape2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPI_BooleanOperation_SetOperation(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAlgoAPI_BooleanOperation_Operation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_FuseEdges(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_BuilderCanWork(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int BRepAlgoAPI_BooleanOperation_ErrorStatus(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_HasModified(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_HasGenerated(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BRepAlgoAPI_BooleanOperation_HasDeleted(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BRepAlgoAPIBooleanOperation() { } 

		public BRepAlgoAPIBooleanOperation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BRepAlgoAPIBooleanOperation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BRepAlgoAPIBooleanOperation_Dtor(IntPtr instance);
	}
}
