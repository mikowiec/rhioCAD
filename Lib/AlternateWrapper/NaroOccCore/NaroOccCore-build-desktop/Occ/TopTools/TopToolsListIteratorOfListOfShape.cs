#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopTools;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsListIteratorOfListOfShape : NativeInstancePtr
	{
		public TopToolsListIteratorOfListOfShape()
 :
			base(TopTools_ListIteratorOfListOfShape_Ctor() )
		{}
		public TopToolsListIteratorOfListOfShape(TopToolsListOfShape L)
 :
			base(TopTools_ListIteratorOfListOfShape_Ctor49A1D41A(L.Instance) )
		{}
			public void Initialize(TopToolsListOfShape L)
				{
					TopTools_ListIteratorOfListOfShape_Initialize49A1D41A(Instance, L.Instance);
				}
			public void Next()
				{
					TopTools_ListIteratorOfListOfShape_Next(Instance);
				}
		public bool More{
			get {
				return TopTools_ListIteratorOfListOfShape_More(Instance);
			}
		}
		public TopoDSShape Value{
			get {
				return new TopoDSShape(TopTools_ListIteratorOfListOfShape_Value(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListIteratorOfListOfShape_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListIteratorOfListOfShape_Ctor49A1D41A(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListIteratorOfListOfShape_Initialize49A1D41A(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ListIteratorOfListOfShape_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopTools_ListIteratorOfListOfShape_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ListIteratorOfListOfShape_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopToolsListIteratorOfListOfShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsListIteratorOfListOfShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsListIteratorOfListOfShape_Dtor(IntPtr instance);
	}
}
