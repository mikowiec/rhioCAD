#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Graphic3d
{
	public class Graphic3dArrayOfPrimitives : MMgtTShared
	{
			public int AddVertex(gpPnt aVertice)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex9EAECD5B(Instance, aVertice.Instance);
				}
			public int AddVertex(double X,double Y,double Z)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex9282A951(Instance, X, Y, Z);
				}
			public int AddVertex(gpPnt aVertice,QuantityColor aColor)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexCF428497(Instance, aVertice.Instance, aColor.Instance);
				}
			public int AddVertex(gpPnt aVertice,int aColor)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexB4E46582(Instance, aVertice.Instance, aColor);
				}
			public int AddVertex(gpPnt aVertice,gpDir aNormal)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexE13B639C(Instance, aVertice.Instance, aNormal.Instance);
				}
			public int AddVertex(double X,double Y,double Z,double NX,double NY,double NZ)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexBC7A5786(Instance, X, Y, Z, NX, NY, NZ);
				}
			public int AddVertex(gpPnt aVertice,gpDir aNormal,QuantityColor aColor)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex62B2E04B(Instance, aVertice.Instance, aNormal.Instance, aColor.Instance);
				}
			public int AddVertex(gpPnt aVertice,gpDir aNormal,int aColor)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex2E34027A(Instance, aVertice.Instance, aNormal.Instance, aColor);
				}
			public int AddVertex(gpPnt aVertice,gpPnt2d aTexel)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexB9E79A6(Instance, aVertice.Instance, aTexel.Instance);
				}
			public int AddVertex(double X,double Y,double Z,double TX,double TY)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex216AF150(Instance, X, Y, Z, TX, TY);
				}
			public int AddVertex(gpPnt aVertice,gpDir aNormal,gpPnt2d aTexel)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertex640114B2(Instance, aVertice.Instance, aNormal.Instance, aTexel.Instance);
				}
			public int AddVertex(double X,double Y,double Z,double NX,double NY,double NZ,double TX,double TY)
				{
					return Graphic3d_ArrayOfPrimitives_AddVertexF677E616(Instance, X, Y, Z, NX, NY, NZ, TX, TY);
				}
			public int AddBound(int edgeNumber)
				{
					return Graphic3d_ArrayOfPrimitives_AddBoundE8219145(Instance, edgeNumber);
				}
			public int AddBound(int edgeNumber,QuantityColor aBColor)
				{
					return Graphic3d_ArrayOfPrimitives_AddBound8575C8EE(Instance, edgeNumber, aBColor.Instance);
				}
			public int AddBound(int edgeNumber,double R,double G,double B)
				{
					return Graphic3d_ArrayOfPrimitives_AddBound830CC280(Instance, edgeNumber, R, G, B);
				}
			public int AddEdge(int vertexIndex,bool isVisible)
				{
					return Graphic3d_ArrayOfPrimitives_AddEdge898DAFFC(Instance, vertexIndex, isVisible);
				}
			public bool Orientate(gpDir aNormal)
				{
					return Graphic3d_ArrayOfPrimitives_OrientateCEC711A5(Instance, aNormal.Instance);
				}
			public bool Orientate(int aBoundIndex,gpDir aNormal)
				{
					return Graphic3d_ArrayOfPrimitives_OrientateF2A71E5F(Instance, aBoundIndex, aNormal.Instance);
				}
			public void SetVertice(int anIndex,gpPnt aVertice)
				{
					Graphic3d_ArrayOfPrimitives_SetVertice7B5D1E58(Instance, anIndex, aVertice.Instance);
				}
			public void SetVertice(int anIndex,double X,double Y,double Z)
				{
					Graphic3d_ArrayOfPrimitives_SetVertice830CC280(Instance, anIndex, X, Y, Z);
				}
			public void SetVertexColor(int anIndex,QuantityColor aColor)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexColor8575C8EE(Instance, anIndex, aColor.Instance);
				}
			public void SetVertexColor(int anIndex,double R,double G,double B)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexColor830CC280(Instance, anIndex, R, G, B);
				}
			public void SetVertexColor(int anIndex,int aColor)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexColor5107F6FE(Instance, anIndex, aColor);
				}
			public void SetVertexNormal(int anIndex,gpDir aNormal)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexNormalF2A71E5F(Instance, anIndex, aNormal.Instance);
				}
			public void SetVertexNormal(int anIndex,double NX,double NY,double NZ)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexNormal830CC280(Instance, anIndex, NX, NY, NZ);
				}
			public void SetVertexTexel(int anIndex,gpPnt2d aTexel)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexTexel5174DA04(Instance, anIndex, aTexel.Instance);
				}
			public void SetVertexTexel(int anIndex,double TX,double TY)
				{
					Graphic3d_ArrayOfPrimitives_SetVertexTexel306E0DFB(Instance, anIndex, TX, TY);
				}
			public void SetBoundColor(int anIndex,QuantityColor aColor)
				{
					Graphic3d_ArrayOfPrimitives_SetBoundColor8575C8EE(Instance, anIndex, aColor.Instance);
				}
			public void SetBoundColor(int anIndex,double R,double G,double B)
				{
					Graphic3d_ArrayOfPrimitives_SetBoundColor830CC280(Instance, anIndex, R, G, B);
				}
			public gpPnt Vertice(int aRank)
				{
					return new gpPnt(Graphic3d_ArrayOfPrimitives_VerticeE8219145(Instance, aRank));
				}
			public void Vertice(int aRank,ref double X,ref double Y,ref double Z)
				{
					Graphic3d_ArrayOfPrimitives_Vertice830CC280(Instance, aRank, ref X, ref Y, ref Z);
				}
			public QuantityColor VertexColor(int aRank)
				{
					return new QuantityColor(Graphic3d_ArrayOfPrimitives_VertexColorE8219145(Instance, aRank));
				}
			public void VertexColor(int aRank,ref double R,ref double G,ref double B)
				{
					Graphic3d_ArrayOfPrimitives_VertexColor830CC280(Instance, aRank, ref R, ref G, ref B);
				}
			public void VertexColor(int aRank,ref int aColor)
				{
					Graphic3d_ArrayOfPrimitives_VertexColor5107F6FE(Instance, aRank, ref aColor);
				}
			public gpDir VertexNormal(int aRank)
				{
					return new gpDir(Graphic3d_ArrayOfPrimitives_VertexNormalE8219145(Instance, aRank));
				}
			public void VertexNormal(int aRank,ref double NX,ref double NY,ref double NZ)
				{
					Graphic3d_ArrayOfPrimitives_VertexNormal830CC280(Instance, aRank, ref NX, ref NY, ref NZ);
				}
			public gpPnt2d VertexTexel(int aRank)
				{
					return new gpPnt2d(Graphic3d_ArrayOfPrimitives_VertexTexelE8219145(Instance, aRank));
				}
			public void VertexTexel(int aRank,ref double TX,ref double TY)
				{
					Graphic3d_ArrayOfPrimitives_VertexTexel306E0DFB(Instance, aRank, ref TX, ref TY);
				}
			public int Edge(int aRank)
				{
					return Graphic3d_ArrayOfPrimitives_EdgeE8219145(Instance, aRank);
				}
			public bool EdgeIsVisible(int aRank)
				{
					return Graphic3d_ArrayOfPrimitives_EdgeIsVisibleE8219145(Instance, aRank);
				}
			public int Bound(int aRank)
				{
					return Graphic3d_ArrayOfPrimitives_BoundE8219145(Instance, aRank);
				}
			public QuantityColor BoundColor(int aRank)
				{
					return new QuantityColor(Graphic3d_ArrayOfPrimitives_BoundColorE8219145(Instance, aRank));
				}
			public void BoundColor(int aRank,ref double R,ref double G,ref double B)
				{
					Graphic3d_ArrayOfPrimitives_BoundColor830CC280(Instance, aRank, ref R, ref G, ref B);
				}
			public static void Enable()
				{
					Graphic3d_ArrayOfPrimitives_Enable();
				}
			public static void Disable()
				{
					Graphic3d_ArrayOfPrimitives_Disable();
				}
		public Graphic3dTypeOfPrimitiveArray Type{
			get {
				return (Graphic3dTypeOfPrimitiveArray)Graphic3d_ArrayOfPrimitives_Type(Instance);
			}
		}
		public string StringType{
			get {
				return Graphic3d_ArrayOfPrimitives_StringType(Instance);
			}
		}
		public bool HasVertexNormals{
			get {
				return Graphic3d_ArrayOfPrimitives_HasVertexNormals(Instance);
			}
		}
		public bool HasVertexColors{
			get {
				return Graphic3d_ArrayOfPrimitives_HasVertexColors(Instance);
			}
		}
		public bool HasVertexTexels{
			get {
				return Graphic3d_ArrayOfPrimitives_HasVertexTexels(Instance);
			}
		}
		public int VertexNumber{
			get {
				return Graphic3d_ArrayOfPrimitives_VertexNumber(Instance);
			}
		}
		public bool HasEdgeInfos{
			get {
				return Graphic3d_ArrayOfPrimitives_HasEdgeInfos(Instance);
			}
		}
		public int EdgeNumber{
			get {
				return Graphic3d_ArrayOfPrimitives_EdgeNumber(Instance);
			}
		}
		public bool HasBoundColors{
			get {
				return Graphic3d_ArrayOfPrimitives_HasBoundColors(Instance);
			}
		}
		public int BoundNumber{
			get {
				return Graphic3d_ArrayOfPrimitives_BoundNumber(Instance);
			}
		}
		public int ItemNumber{
			get {
				return Graphic3d_ArrayOfPrimitives_ItemNumber(Instance);
			}
		}
		public static bool IsEnable{
			get {
				return Graphic3d_ArrayOfPrimitives_IsEnable();
			}
		}
		public bool IsValid{
			get {
				return Graphic3d_ArrayOfPrimitives_IsValid(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex9EAECD5B(IntPtr instance, IntPtr aVertice);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexCF428497(IntPtr instance, IntPtr aVertice,IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexB4E46582(IntPtr instance, IntPtr aVertice,int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexE13B639C(IntPtr instance, IntPtr aVertice,IntPtr aNormal);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexBC7A5786(IntPtr instance, double X,double Y,double Z,double NX,double NY,double NZ);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex62B2E04B(IntPtr instance, IntPtr aVertice,IntPtr aNormal,IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex2E34027A(IntPtr instance, IntPtr aVertice,IntPtr aNormal,int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexB9E79A6(IntPtr instance, IntPtr aVertice,IntPtr aTexel);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex216AF150(IntPtr instance, double X,double Y,double Z,double TX,double TY);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertex640114B2(IntPtr instance, IntPtr aVertice,IntPtr aNormal,IntPtr aTexel);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddVertexF677E616(IntPtr instance, double X,double Y,double Z,double NX,double NY,double NZ,double TX,double TY);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddBoundE8219145(IntPtr instance, int edgeNumber);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddBound8575C8EE(IntPtr instance, int edgeNumber,IntPtr aBColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddBound830CC280(IntPtr instance, int edgeNumber,double R,double G,double B);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_AddEdge898DAFFC(IntPtr instance, int vertexIndex,bool isVisible);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_OrientateCEC711A5(IntPtr instance, IntPtr aNormal);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_OrientateF2A71E5F(IntPtr instance, int aBoundIndex,IntPtr aNormal);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertice7B5D1E58(IntPtr instance, int anIndex,IntPtr aVertice);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertice830CC280(IntPtr instance, int anIndex,double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexColor8575C8EE(IntPtr instance, int anIndex,IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexColor830CC280(IntPtr instance, int anIndex,double R,double G,double B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexColor5107F6FE(IntPtr instance, int anIndex,int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexNormalF2A71E5F(IntPtr instance, int anIndex,IntPtr aNormal);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexNormal830CC280(IntPtr instance, int anIndex,double NX,double NY,double NZ);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexTexel5174DA04(IntPtr instance, int anIndex,IntPtr aTexel);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetVertexTexel306E0DFB(IntPtr instance, int anIndex,double TX,double TY);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetBoundColor8575C8EE(IntPtr instance, int anIndex,IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_SetBoundColor830CC280(IntPtr instance, int anIndex,double R,double G,double B);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_ArrayOfPrimitives_VerticeE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_Vertice830CC280(IntPtr instance, int aRank,ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_ArrayOfPrimitives_VertexColorE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_VertexColor830CC280(IntPtr instance, int aRank,ref double R,ref double G,ref double B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_VertexColor5107F6FE(IntPtr instance, int aRank,ref int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_ArrayOfPrimitives_VertexNormalE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_VertexNormal830CC280(IntPtr instance, int aRank,ref double NX,ref double NY,ref double NZ);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_ArrayOfPrimitives_VertexTexelE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_VertexTexel306E0DFB(IntPtr instance, int aRank,ref double TX,ref double TY);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_EdgeE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_EdgeIsVisibleE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_BoundE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Graphic3d_ArrayOfPrimitives_BoundColorE8219145(IntPtr instance, int aRank);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_BoundColor830CC280(IntPtr instance, int aRank,ref double R,ref double G,ref double B);
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_Enable();
		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3d_ArrayOfPrimitives_Disable();
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Graphic3d_ArrayOfPrimitives_StringType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_HasVertexNormals(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_HasVertexColors(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_HasVertexTexels(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_VertexNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_HasEdgeInfos(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_EdgeNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_HasBoundColors(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_BoundNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Graphic3d_ArrayOfPrimitives_ItemNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_IsEnable();
		[DllImport("NaroOccCore.dll")]
		private static extern bool Graphic3d_ArrayOfPrimitives_IsValid(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Graphic3dArrayOfPrimitives() { } 

		public Graphic3dArrayOfPrimitives(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Graphic3dArrayOfPrimitives_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Graphic3dArrayOfPrimitives_Dtor(IntPtr instance);
	}
}
