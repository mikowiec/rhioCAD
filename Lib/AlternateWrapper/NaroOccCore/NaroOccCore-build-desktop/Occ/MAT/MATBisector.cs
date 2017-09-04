#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.MAT;

#endregion

namespace NaroCppCore.Occ.MAT
{
	public class MATBisector : MMgtTShared
	{
		public MATBisector()
 :
			base(MAT_Bisector_Ctor() )
		{}
			public void AddBisector(MATBisector abisector)
				{
					MAT_Bisector_AddBisector1F24E859(Instance, abisector.Instance);
				}
			public void BisectorNumber(int anumber)
				{
					MAT_Bisector_BisectorNumberE8219145(Instance, anumber);
				}
			public void IndexNumber(int anumber)
				{
					MAT_Bisector_IndexNumberE8219145(Instance, anumber);
				}
			public void FirstEdge(MATEdge anedge)
				{
					MAT_Bisector_FirstEdge878E0E92(Instance, anedge.Instance);
				}
			public void SecondEdge(MATEdge anedge)
				{
					MAT_Bisector_SecondEdge878E0E92(Instance, anedge.Instance);
				}
			public void IssuePoint(int apoint)
				{
					MAT_Bisector_IssuePointE8219145(Instance, apoint);
				}
			public void EndPoint(int apoint)
				{
					MAT_Bisector_EndPointE8219145(Instance, apoint);
				}
			public void DistIssuePoint(double areal)
				{
					MAT_Bisector_DistIssuePointD82819F3(Instance, areal);
				}
			public void FirstVector(int avector)
				{
					MAT_Bisector_FirstVectorE8219145(Instance, avector);
				}
			public void SecondVector(int avector)
				{
					MAT_Bisector_SecondVectorE8219145(Instance, avector);
				}
			public void Sense(double asense)
				{
					MAT_Bisector_SenseD82819F3(Instance, asense);
				}
			public void FirstParameter(double aparameter)
				{
					MAT_Bisector_FirstParameterD82819F3(Instance, aparameter);
				}
			public void SecondParameter(double aparameter)
				{
					MAT_Bisector_SecondParameterD82819F3(Instance, aparameter);
				}
			public int BisectorNumber()
				{
					return MAT_Bisector_BisectorNumber(Instance);
				}
			public int IndexNumber()
				{
					return MAT_Bisector_IndexNumber(Instance);
				}
			public MATEdge FirstEdge()
				{
					return new MATEdge(MAT_Bisector_FirstEdge(Instance));
				}
			public MATEdge SecondEdge()
				{
					return new MATEdge(MAT_Bisector_SecondEdge(Instance));
				}
			public int IssuePoint()
				{
					return MAT_Bisector_IssuePoint(Instance);
				}
			public int EndPoint()
				{
					return MAT_Bisector_EndPoint(Instance);
				}
			public double DistIssuePoint()
				{
					return MAT_Bisector_DistIssuePoint(Instance);
				}
			public int FirstVector()
				{
					return MAT_Bisector_FirstVector(Instance);
				}
			public int SecondVector()
				{
					return MAT_Bisector_SecondVector(Instance);
				}
			public double Sense()
				{
					return MAT_Bisector_Sense(Instance);
				}
			public double FirstParameter()
				{
					return MAT_Bisector_FirstParameter(Instance);
				}
			public double SecondParameter()
				{
					return MAT_Bisector_SecondParameter(Instance);
				}
			public void Dump(int ashift,int alevel)
				{
					MAT_Bisector_Dump5107F6FE(Instance, ashift, alevel);
				}
		public MATListOfBisector List{
			get {
				return new MATListOfBisector(MAT_Bisector_List(Instance));
			}
		}
		public MATBisector FirstBisector{
			get {
				return new MATBisector(MAT_Bisector_FirstBisector(Instance));
			}
		}
		public MATBisector LastBisector{
			get {
				return new MATBisector(MAT_Bisector_LastBisector(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_AddBisector1F24E859(IntPtr instance, IntPtr abisector);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_BisectorNumberE8219145(IntPtr instance, int anumber);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_IndexNumberE8219145(IntPtr instance, int anumber);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_FirstEdge878E0E92(IntPtr instance, IntPtr anedge);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_SecondEdge878E0E92(IntPtr instance, IntPtr anedge);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_IssuePointE8219145(IntPtr instance, int apoint);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_EndPointE8219145(IntPtr instance, int apoint);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_DistIssuePointD82819F3(IntPtr instance, double areal);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_FirstVectorE8219145(IntPtr instance, int avector);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_SecondVectorE8219145(IntPtr instance, int avector);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_SenseD82819F3(IntPtr instance, double asense);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_FirstParameterD82819F3(IntPtr instance, double aparameter);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_SecondParameterD82819F3(IntPtr instance, double aparameter);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_BisectorNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_IndexNumber(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_FirstEdge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_SecondEdge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_IssuePoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_EndPoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double MAT_Bisector_DistIssuePoint(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_FirstVector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_Bisector_SecondVector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double MAT_Bisector_Sense(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double MAT_Bisector_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double MAT_Bisector_SecondParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_Bisector_Dump5107F6FE(IntPtr instance, int ashift,int alevel);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_List(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_FirstBisector(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_Bisector_LastBisector(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MATBisector(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MATBisector_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MATBisector_Dtor(IntPtr instance);
	}
}
