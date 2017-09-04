#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.TopTools
{
	public class TopToolsShapeSet : NativeInstancePtr
	{
		public TopToolsShapeSet()
 :
			base(TopTools_ShapeSet_Ctor() )
		{}
			public void Delete()
				{
					TopTools_ShapeSet_Delete(Instance);
				}
			public void Clear()
				{
					TopTools_ShapeSet_Clear(Instance);
				}
			public int Add(TopoDSShape S)
				{
					return TopTools_ShapeSet_Add9EBAC0C0(Instance, S.Instance);
				}
			public TopoDSShape Shape(int I)
				{
					return new TopoDSShape(TopTools_ShapeSet_ShapeE8219145(Instance, I));
				}
			public int Index(TopoDSShape S)
				{
					return TopTools_ShapeSet_Index9EBAC0C0(Instance, S.Instance);
				}
			public void AddGeometry(TopoDSShape S)
				{
					TopTools_ShapeSet_AddGeometry9EBAC0C0(Instance, S.Instance);
				}
		public int FormatNb{
			set { 
				TopTools_ShapeSet_SetFormatNb(Instance, value);
			}
			get {
				return TopTools_ShapeSet_FormatNb(Instance);
			}
		}
		public int NbShapes{
			get {
				return TopTools_ShapeSet_NbShapes(Instance);
			}
		}
		public MessageProgressIndicator Progress{
			set { 
				TopTools_ShapeSet_SetProgress(Instance, value.Instance);
			}
		}
		public MessageProgressIndicator GetProgress{
			get {
				return new MessageProgressIndicator(TopTools_ShapeSet_GetProgress(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ShapeSet_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ShapeSet_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ShapeSet_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_ShapeSet_Add9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ShapeSet_ShapeE8219145(IntPtr instance, int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_ShapeSet_Index9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ShapeSet_AddGeometry9EBAC0C0(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ShapeSet_SetFormatNb(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_ShapeSet_FormatNb(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopTools_ShapeSet_NbShapes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopTools_ShapeSet_SetProgress(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopTools_ShapeSet_GetProgress(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopToolsShapeSet(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopToolsShapeSet_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopToolsShapeSet_Dtor(IntPtr instance);
	}
}
