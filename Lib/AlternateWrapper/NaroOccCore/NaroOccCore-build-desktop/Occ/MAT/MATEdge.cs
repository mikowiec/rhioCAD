#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.MAT;

#endregion

namespace NaroCppCore.Occ.MAT
{
	public class MATEdge : MMgtTShared
	{
		public MATEdge()
 :
			base(MAT_Edge_Ctor() )
		{}
			public void EdgeNumber(int anumber)
				{
					MAT_Edge_EdgeNumberE8219145(Instance, anumber);
				}
			public void FirstBisector(MATBisector abisector)
				{
					MAT_Edge_FirstBisector1F24E859(Instance, abisector.Instance);
				}
			public void SecondBisector(MATBisector abisector)
				{
					MAT_Edge_SecondBisector1F24E859(Instance, abisector.Instance);
				}
			public void Distance(double adistance)
				{
					MAT_Edge_DistanceD82819F3(Instance, adistance);
				}
			public void IntersectionPoint(int apoint)
				{
					MAT_Edge_IntersectionPointE8219145(Instance, apoint);
				}
			public int EdgeNumber()
				{
					return MAT_Edge_EdgeNumber(Instance);
				}
			public MATBisector FirstBisector()
				{
					return new MATBisector(MAT_Edge_FirstBisector(Instance));
				}
			public MATBisector SecondBisector()
				{
					return new MATBisector(MAT_Edge_SecondBisector(Instance));
				}
			public double Distance()
				{
					return MAT_Edge_Distance(Instance);
				}
			public int IntersectionPoint()
				{
					return MAT_Edge_IntersectionPoint(Instance);
				}
			public void Dump(int ashift,int alevel)
				{
					MAT_Edge_Dump5107F6FE(Instance, ashift, alevel);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Edge_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_EdgeNumberE8219145(IntPtr instance, int anumber);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_FirstBisector1F24E859(IntPtr instance, IntPtr abisector);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_SecondBisector1F24E859(IntPtr instance, IntPtr abisector);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_DistanceD82819F3(IntPtr instance, double adistance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_IntersectionPointE8219145(IntPtr instance, int apoint);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Edge_EdgeNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Edge_FirstBisector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Edge_SecondBisector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double MAT_Edge_Distance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Edge_IntersectionPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Edge_Dump5107F6FE(IntPtr instance, int ashift,int alevel);

		#region NativeInstancePtr Convert constructor

		public MATEdge(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MATEdge_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MATEdge_Dtor(IntPtr instance);
	}
}
