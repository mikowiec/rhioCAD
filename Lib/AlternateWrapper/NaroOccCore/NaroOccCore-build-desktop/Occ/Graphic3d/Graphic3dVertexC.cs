#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVertexC : Graphic3dVertex
	{
		public Graphic3dVertexC()
 :
			base(Graphic3d_VertexC_Ctor() )
		{}
		public Graphic3dVertexC(double AX,double AY,double AZ,QuantityColor AColor)
 :
			base(Graphic3d_VertexC_Ctor54B79BE2(AX, AY, AZ, AColor.Instance) )
		{}
		public Graphic3dVertexC(Graphic3dVertex APoint,QuantityColor AColor)
 :
			base(Graphic3d_VertexC_Ctor1204A009(APoint.Instance, AColor.Instance) )
		{}
		public QuantityColor Color{
			set { 
				Graphic3d_VertexC_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_VertexC_Color(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexC_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexC_Ctor54B79BE2(double AX,double AY,double AZ,IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexC_Ctor1204A009(IntPtr APoint,IntPtr AColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexC_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexC_Color(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVertexC(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVertexC_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVertexC_Dtor(IntPtr instance);
	}
}
