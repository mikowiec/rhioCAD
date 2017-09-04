#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Quantity
{
	public class QuantityDate : NativeInstancePtr
	{
		public QuantityDate()
 :
			base(Quantity_Date_Ctor() )
		{}
		public QuantityDate(int mm,int dd,int yyyy,int hh,int mn,int ss,int mis,int mics)
 :
			base(Quantity_Date_Ctor24458BB5(mm, dd, yyyy, hh, mn, ss, mis, mics) )
		{}
			public void Values(ref int mm,ref int dd,ref int yy,ref int hh,ref int mn,ref int ss,ref int mis,ref int mics)
				{
					Quantity_Date_Values24458BB5(Instance, ref mm, ref dd, ref yy, ref hh, ref mn, ref ss, ref mis, ref mics);
				}
			public void SetValues(int mm,int dd,int yy,int hh,int mn,int ss,int mis,int mics)
				{
					Quantity_Date_SetValues24458BB5(Instance, mm, dd, yy, hh, mn, ss, mis, mics);
				}
			public QuantityPeriod Difference(QuantityDate anOther)
				{
					return new QuantityPeriod(Quantity_Date_Difference4AE38D5E(Instance, anOther.Instance));
				}
			public QuantityDate Subtract(QuantityPeriod aPeriod)
				{
					return new QuantityDate(Quantity_Date_Subtract22BB0292(Instance, aPeriod.Instance));
				}
			public QuantityDate Add(QuantityPeriod aPeriod)
				{
					return new QuantityDate(Quantity_Date_Add22BB0292(Instance, aPeriod.Instance));
				}
			public bool IsEqual(QuantityDate anOther)
				{
					return Quantity_Date_IsEqual4AE38D5E(Instance, anOther.Instance);
				}
			public bool IsEarlier(QuantityDate anOther)
				{
					return Quantity_Date_IsEarlier4AE38D5E(Instance, anOther.Instance);
				}
			public bool IsLater(QuantityDate anOther)
				{
					return Quantity_Date_IsLater4AE38D5E(Instance, anOther.Instance);
				}
			public static bool IsValid(int mm,int dd,int yy,int hh,int mn,int ss,int mis,int mics)
				{
					return Quantity_Date_IsValid24458BB5(mm, dd, yy, hh, mn, ss, mis, mics);
				}
			public static bool IsLeap(int yy)
				{
					return Quantity_Date_IsLeapE8219145(yy);
				}
		public int Year{
			get {
				return Quantity_Date_Year(Instance);
			}
		}
		public int Month{
			get {
				return Quantity_Date_Month(Instance);
			}
		}
		public int Day{
			get {
				return Quantity_Date_Day(Instance);
			}
		}
		public int Hour{
			get {
				return Quantity_Date_Hour(Instance);
			}
		}
		public int Minute{
			get {
				return Quantity_Date_Minute(Instance);
			}
		}
		public int Second{
			get {
				return Quantity_Date_Second(Instance);
			}
		}
		public int MilliSecond{
			get {
				return Quantity_Date_MilliSecond(Instance);
			}
		}
		public int MicroSecond{
			get {
				return Quantity_Date_MicroSecond(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Date_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Date_Ctor24458BB5(int mm,int dd,int yyyy,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Date_Values24458BB5(IntPtr instance, ref int mm,ref int dd,ref int yy,ref int hh,ref int mn,ref int ss,ref int mis,ref int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Date_SetValues24458BB5(IntPtr instance, int mm,int dd,int yy,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Date_Difference4AE38D5E(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Date_Subtract22BB0292(IntPtr instance, IntPtr aPeriod);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Date_Add22BB0292(IntPtr instance, IntPtr aPeriod);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Date_IsEqual4AE38D5E(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Date_IsEarlier4AE38D5E(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Date_IsLater4AE38D5E(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Date_IsValid24458BB5(int mm,int dd,int yy,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Date_IsLeapE8219145(int yy);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Year(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Month(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Day(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Hour(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Minute(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_Second(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_MilliSecond(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Quantity_Date_MicroSecond(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public QuantityDate(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ QuantityDate_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void QuantityDate_Dtor(IntPtr instance);
	}
}
