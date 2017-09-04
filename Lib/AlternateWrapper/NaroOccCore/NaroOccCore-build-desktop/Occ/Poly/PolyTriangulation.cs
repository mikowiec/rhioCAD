#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TColgp;
using NaroCppCore.Occ.Poly;

#endregion

namespace NaroCppCore.Occ.Poly
{
	public class PolyTriangulation : MMgtTShared
	{
		public PolyTriangulation(int nbNodes,int nbTriangles,bool UVNodes)
 :
			base(Poly_Triangulation_Ctor28218E44(nbNodes, nbTriangles, UVNodes) )
		{}
		public PolyTriangulation(TColgpArray1OfPnt Nodes,PolyArray1OfTriangle Triangles)
 :
			base(Poly_Triangulation_Ctor9EE6697D(Nodes.Instance, Triangles.Instance) )
		{}
			public double Deflection()
				{
					return Poly_Triangulation_Deflection(Instance);
				}
			public void Deflection(double D)
				{
					Poly_Triangulation_DeflectionD82819F3(Instance, D);
				}
			public void RemoveUVNodes()
				{
					Poly_Triangulation_RemoveUVNodes(Instance);
				}
		public int NbNodes{
			get {
				return Poly_Triangulation_NbNodes(Instance);
			}
		}
		public int NbTriangles{
			get {
				return Poly_Triangulation_NbTriangles(Instance);
			}
		}
		public bool HasUVNodes{
			get {
				return Poly_Triangulation_HasUVNodes(Instance);
			}
		}
		public TColgpArray1OfPnt Nodes{
			get {
				return new TColgpArray1OfPnt(Poly_Triangulation_Nodes(Instance));
			}
		}
		public PolyArray1OfTriangle Triangles{
			get {
				return new PolyArray1OfTriangle(Poly_Triangulation_Triangles(Instance));
			}
		}
		public bool HasNormals{
			get {
				return Poly_Triangulation_HasNormals(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangulation_Ctor28218E44(int nbNodes,int nbTriangles,bool UVNodes);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangulation_Ctor9EE6697D(IntPtr Nodes,IntPtr Triangles);
		[DllImport("NaroOccCore.dll")]
		private static extern double Poly_Triangulation_Deflection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Triangulation_DeflectionD82819F3(IntPtr instance, double D);
		[DllImport("NaroOccCore.dll")]
		private static extern void Poly_Triangulation_RemoveUVNodes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Triangulation_NbNodes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Poly_Triangulation_NbTriangles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Poly_Triangulation_HasUVNodes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangulation_Nodes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Poly_Triangulation_Triangles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Poly_Triangulation_HasNormals(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PolyTriangulation() { } 

		public PolyTriangulation(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PolyTriangulation_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PolyTriangulation_Dtor(IntPtr instance);
	}
}
