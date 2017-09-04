#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVertexNT : Graphic3dVertexN
	{
		public Graphic3dVertexNT()
 :
			base(Graphic3d_VertexNT_Ctor() )
		{}
		public Graphic3dVertexNT(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,double ATX,double ATY,bool FlagNormalise)
 :
			base(Graphic3d_VertexNT_CtorC4E56621(AX, AY, AZ, ANX, ANY, ANZ, ATX, ATY, FlagNormalise) )
		{}
		public Graphic3dVertexNT(Graphic3dVertex APoint,Graphic3dVector AVector,double ATX,double ATY,bool FlagNormalise)
 :
			base(Graphic3d_VertexNT_Ctor6C5E5BBA(APoint.Instance, AVector.Instance, ATX, ATY, FlagNormalise) )
		{}
			public void SetTextureCoordinate(double ATX,double ATY)
				{
					Graphic3d_VertexNT_SetTextureCoordinate9F0E714F(Instance, ATX, ATY);
				}
			public void TextureCoordinate(ref double ATX,ref double ATY)
				{
					Graphic3d_VertexNT_TextureCoordinate9F0E714F(Instance, ref ATX, ref ATY);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNT_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNT_CtorC4E56621(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,double ATX,double ATY,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexNT_Ctor6C5E5BBA(IntPtr APoint,IntPtr AVector,double ATX,double ATY,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexNT_SetTextureCoordinate9F0E714F(IntPtr instance, double ATX,double ATY);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexNT_TextureCoordinate9F0E714F(IntPtr instance, ref double ATX,ref double ATY);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVertexNT(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVertexNT_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVertexNT_Dtor(IntPtr instance);
	}
}
