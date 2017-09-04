#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVertexNC : Graphic3dVertexN
	{
		public Graphic3dVertexNC()
 :
			base(Graphic3d_VertexNC_Ctor() )
		{}
		public Graphic3dVertexNC(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,QuantityColor AColor,bool FlagNormalise)
 :
			base(Graphic3d_VertexNC_CtorF45E0172(AX, AY, AZ, ANX, ANY, ANZ, AColor.Instance, FlagNormalise) )
		{}
		public Graphic3dVertexNC(Graphic3dVertex APoint,Graphic3dVector AVector,QuantityColor AColor,bool FlagNormalise)
 :
			base(Graphic3d_VertexNC_Ctor523C1B5F(APoint.Instance, AVector.Instance, AColor.Instance, FlagNormalise) )
		{}
		public QuantityColor Color{
			set { 
				Graphic3d_VertexNC_SetColor(Instance, value.Instance);
			}
			get {
				return new QuantityColor(Graphic3d_VertexNC_Color(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNC_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNC_CtorF45E0172(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,IntPtr AColor,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNC_Ctor523C1B5F(IntPtr APoint,IntPtr AVector,IntPtr AColor,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexNC_SetColor(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNC_Color(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVertexNC(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVertexNC_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVertexNC_Dtor(IntPtr instance);
	}
}
