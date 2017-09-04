#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.Precision
{
	public class Precision : NativeInstancePtr
	{
			public static double Parametric(double P,double T)
				{
					return Precision_Parametric9F0E714F(P, T);
				}
			public static double PConfusion(double T)
				{
					return Precision_PConfusionD82819F3(T);
				}
			public static double PIntersection(double T)
				{
					return Precision_PIntersectionD82819F3(T);
				}
			public static double PApproximation(double T)
				{
					return Precision_PApproximationD82819F3(T);
				}
			public static double Parametric(double P)
				{
					return Precision_ParametricD82819F3(P);
				}
			public static double PConfusion()
				{
					return Precision_PConfusion();
				}
			public static double PIntersection()
				{
					return Precision_PIntersection();
				}
			public static double PApproximation()
				{
					return Precision_PApproximation();
				}
			public static bool IsInfinite(double R)
				{
					return Precision_IsInfiniteD82819F3(R);
				}
			public static bool IsPositiveInfinite(double R)
				{
					return Precision_IsPositiveInfiniteD82819F3(R);
				}
			public static bool IsNegativeInfinite(double R)
				{
					return Precision_IsNegativeInfiniteD82819F3(R);
				}
		public static double Angular{
			get {
				return Precision_Angular();
			}
		}
		public static double Confusion{
			get {
				return Precision_Confusion();
			}
		}
		public static double SquareConfusion{
			get {
				return Precision_SquareConfusion();
			}
		}
		public static double Intersection{
			get {
				return Precision_Intersection();
			}
		}
		public static double Approximation{
			get {
				return Precision_Approximation();
			}
		}
		public static double Infinite{
			get {
				return Precision_Infinite();
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Parametric9F0E714F(double P,double T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PConfusionD82819F3(double T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PIntersectionD82819F3(double T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PApproximationD82819F3(double T);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_ParametricD82819F3(double P);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PConfusion();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PIntersection();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_PApproximation();
		[DllImport("NaroOccCore.dll")]
		private static extern bool Precision_IsInfiniteD82819F3(double R);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Precision_IsPositiveInfiniteD82819F3(double R);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Precision_IsNegativeInfiniteD82819F3(double R);
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Angular();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Confusion();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_SquareConfusion();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Intersection();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Approximation();
		[DllImport("NaroOccCore.dll")]
		private static extern double Precision_Infinite();

		#region NativeInstancePtr Convert constructor

		public Precision() { } 

		public Precision(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Precision_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Precision_Dtor(IntPtr instance);
	}
}
