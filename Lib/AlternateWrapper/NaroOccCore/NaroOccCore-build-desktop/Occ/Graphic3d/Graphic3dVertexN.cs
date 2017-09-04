#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dVertexN : Graphic3dVertex
	{
		public Graphic3dVertexN()
 :
			base(Graphic3d_VertexN_Ctor() )
		{}
		public Graphic3dVertexN(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,bool FlagNormalise)
 :
			base(Graphic3d_VertexN_Ctor51E06B8D(AX, AY, AZ, ANX, ANY, ANZ, FlagNormalise) )
		{}
		public Graphic3dVertexN(Graphic3dVertex APoint,Graphic3dVector AVector,bool FlagNormalise)
 :
			base(Graphic3d_VertexN_CtorD1B20338(APoint.Instance, AVector.Instance, FlagNormalise) )
		{}
			public void SetNormal(double NXnew,double NYnew,double NZnew,bool FlagNormalise)
				{
					Graphic3d_VertexN_SetNormal1B801FD4(Instance, NXnew, NYnew, NZnew, FlagNormalise);
				}
			public void Normal(ref double ANX,ref double ANY,ref double ANZ)
				{
					Graphic3d_VertexN_Normal9282A951(Instance, ref ANX, ref ANY, ref ANZ);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexN_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexN_Ctor51E06B8D(double AX,double AY,double AZ,double ANX,double ANY,double ANZ,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_VertexN_CtorD1B20338(IntPtr APoint,IntPtr AVector,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexN_SetNormal1B801FD4(IntPtr instance, double NXnew,double NYnew,double NZnew,bool FlagNormalise);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_VertexN_Normal9282A951(IntPtr instance, ref double ANX,ref double ANY,ref double ANZ);

		#region NativeInstancePtr Convert constructor

		public Graphic3dVertexN(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dVertexN_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dVertexN_Dtor(IntPtr instance);
	}
}
