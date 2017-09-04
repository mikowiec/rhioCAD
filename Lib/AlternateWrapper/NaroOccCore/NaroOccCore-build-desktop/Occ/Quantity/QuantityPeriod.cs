#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Quantity;

#endregion

namespace NaroCppCore.Occ.Quantity
{
	public class QuantityPeriod : NativeInstancePtr
	{
		public QuantityPeriod(int dd,int hh,int mn,int ss,int mis,int mics)
 :
			base(Quantity_Period_Ctor9EE4184A(dd, hh, mn, ss, mis, mics) )
		{}
		public QuantityPeriod(int ss,int mics)
 :
			base(Quantity_Period_Ctor5107F6FE(ss, mics) )
		{}
			public void Values(ref int dd,ref int hh,ref int mn,ref int ss,ref int mis,ref int mics)
				{
					Quantity_Period_Values9EE4184A(Instance, ref dd, ref hh, ref mn, ref ss, ref mis, ref mics);
				}
			public void Values(ref int ss,ref int mics)
				{
					Quantity_Period_Values5107F6FE(Instance, ref ss, ref mics);
				}
			public void SetValues(int dd,int hh,int mn,int ss,int mis,int mics)
				{
					Quantity_Period_SetValues9EE4184A(Instance, dd, hh, mn, ss, mis, mics);
				}
			public void SetValues(int ss,int mics)
				{
					Quantity_Period_SetValues5107F6FE(Instance, ss, mics);
				}
			public QuantityPeriod Subtract(QuantityPeriod anOther)
				{
					return new QuantityPeriod(Quantity_Period_Subtract22BB0292(Instance, anOther.Instance));
				}
			public QuantityPeriod Add(QuantityPeriod anOther)
				{
					return new QuantityPeriod(Quantity_Period_Add22BB0292(Instance, anOther.Instance));
				}
			public bool IsEqual(QuantityPeriod anOther)
				{
					return Quantity_Period_IsEqual22BB0292(Instance, anOther.Instance);
				}
			public bool IsShorter(QuantityPeriod anOther)
				{
					return Quantity_Period_IsShorter22BB0292(Instance, anOther.Instance);
				}
			public bool IsLonger(QuantityPeriod anOther)
				{
					return Quantity_Period_IsLonger22BB0292(Instance, anOther.Instance);
				}
			public static bool IsValid(int dd,int hh,int mn,int ss,int mis,int mics)
				{
					return Quantity_Period_IsValid9EE4184A(dd, hh, mn, ss, mis, mics);
				}
			public static bool IsValid(int ss,int mics)
				{
					return Quantity_Period_IsValid5107F6FE(ss, mics);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Period_Ctor9EE4184A(int dd,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Period_Ctor5107F6FE(int ss,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Period_Values9EE4184A(IntPtr instance, ref int dd,ref int hh,ref int mn,ref int ss,ref int mis,ref int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Period_Values5107F6FE(IntPtr instance, ref int ss,ref int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Period_SetValues9EE4184A(IntPtr instance, int dd,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern void Quantity_Period_SetValues5107F6FE(IntPtr instance, int ss,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Period_Subtract22BB0292(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Quantity_Period_Add22BB0292(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Period_IsEqual22BB0292(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Period_IsShorter22BB0292(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Period_IsLonger22BB0292(IntPtr instance, IntPtr anOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Period_IsValid9EE4184A(int dd,int hh,int mn,int ss,int mis,int mics);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Quantity_Period_IsValid5107F6FE(int ss,int mics);

		#region NativeInstancePtr Convert constructor

		public QuantityPeriod() { } 

		public QuantityPeriod(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ QuantityPeriod_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void QuantityPeriod_Dtor(IntPtr instance);
	}
}
