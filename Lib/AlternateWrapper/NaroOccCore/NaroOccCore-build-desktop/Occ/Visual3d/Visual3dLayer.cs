#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Visual3d;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dLayer : MMgtTShared
	{
		public Visual3dLayer(Visual3dViewManager AViewer,AspectTypeOfLayer AType,bool AFlag)
 :
			base(Visual3d_Layer_Ctor441B6185(AViewer.Instance, (int)AType, AFlag) )
		{}
			public void Begin()
				{
					Visual3d_Layer_Begin(Instance);
				}
			public void End()
				{
					Visual3d_Layer_End(Instance);
				}
			public void Clear()
				{
					Visual3d_Layer_Clear(Instance);
				}
			public void BeginPolyline()
				{
					Visual3d_Layer_BeginPolyline(Instance);
				}
			public void BeginPolygon()
				{
					Visual3d_Layer_BeginPolygon(Instance);
				}
			public void AddVertex(double X,double Y,bool AFlag)
				{
					Visual3d_Layer_AddVertex947352B1(Instance, X, Y, AFlag);
				}
			public void ClosePrimitive()
				{
					Visual3d_Layer_ClosePrimitive(Instance);
				}
			public void DrawRectangle(double X,double Y,double Width,double Height)
				{
					Visual3d_Layer_DrawRectangleC2777E0C(Instance, X, Y, Width, Height);
				}
			public void DrawText(string AText,double X,double Y,double AHeight)
				{
					Visual3d_Layer_DrawText70DEA06(Instance, AText, X, Y, AHeight);
				}
			public void TextSize(string AText,double AHeight,ref double AWidth,ref double AnAscent,ref double ADescent)
				{
					Visual3d_Layer_TextSize60366884(Instance, AText, AHeight, ref AWidth, ref AnAscent, ref ADescent);
				}
			public void UnsetTransparency()
				{
					Visual3d_Layer_UnsetTransparency(Instance);
				}
			public void SetLineAttributes(AspectTypeOfLine AType,double AWidth)
				{
					Visual3d_Layer_SetLineAttributes4A74B177(Instance, (int)AType, AWidth);
				}
			public void SetTextAttributes(string AFont,AspectTypeOfDisplayText AType,QuantityColor AColor)
				{
					Visual3d_Layer_SetTextAttributesB86808AE(Instance, AFont, (int)AType, AColor.Instance);
				}
			public void SetOrtho(double Left,double Right,double Bottom,double Top,AspectTypeOfConstraint Attach)
				{
					Visual3d_Layer_SetOrtho2E58BA48(Instance, Left, Right, Bottom, Top, (int)Attach);
				}
			public void SetViewport(int Width,int Height)
				{
					Visual3d_Layer_SetViewport5107F6FE(Instance, Width, Height);
				}
			public void AddLayerItem(Visual3dLayerItem Item)
				{
					Visual3d_Layer_AddLayerItem62CFB744(Instance, Item.Instance);
				}
			public void RemoveLayerItem(Visual3dLayerItem Item)
				{
					Visual3d_Layer_RemoveLayerItem62CFB744(Instance, Item.Instance);
				}
			public void RemoveAllLayerItems()
				{
					Visual3d_Layer_RemoveAllLayerItems(Instance);
				}
			public void RenderLayerItems()
				{
					Visual3d_Layer_RenderLayerItems(Instance);
				}
		public QuantityColor Color{
			set { 
				Visual3d_Layer_SetColor(Instance, value.Instance);
			}
		}
		public double Transparency{
			set { 
				Visual3d_Layer_SetTransparency(Instance, value);
			}
		}
		public AspectTypeOfLayer Type{
			get {
				return (AspectTypeOfLayer)Visual3d_Layer_Type(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_Layer_Ctor441B6185(IntPtr AViewer,int AType,bool AFlag);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_Begin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_End(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_BeginPolyline(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_BeginPolygon(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_AddVertex947352B1(IntPtr instance, double X,double Y,bool AFlag);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_ClosePrimitive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_DrawRectangleC2777E0C(IntPtr instance, double X,double Y,double Width,double Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_DrawText70DEA06(IntPtr instance, string AText,double X,double Y,double AHeight);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_TextSize60366884(IntPtr instance, string AText,double AHeight,ref double AWidth,ref double AnAscent,ref double ADescent);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_UnsetTransparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetLineAttributes4A74B177(IntPtr instance, int AType,double AWidth);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetTextAttributesB86808AE(IntPtr instance, string AFont,int AType,IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetOrtho2E58BA48(IntPtr instance, double Left,double Right,double Bottom,double Top,int Attach);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetViewport5107F6FE(IntPtr instance, int Width,int Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_AddLayerItem62CFB744(IntPtr instance, IntPtr Item);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_RemoveLayerItem62CFB744(IntPtr instance, IntPtr Item);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_RemoveAllLayerItems(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_RenderLayerItems(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_Layer_SetTransparency(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_Layer_Type(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dLayer() { } 

		public Visual3dLayer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{
            try
            {
                Visual3dLayer_Dtor(Instance);
            }
            catch { }
        }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dLayer_Dtor(IntPtr instance);
	}
}
