#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.PlotMgt;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.OSD;

#endregion

namespace NaroCppCore.Occ.PlotMgt
{
	public class PlotMgtPlotterParameter : MMgtTShared
	{
		public PlotMgtPlotterParameter(TCollectionAsciiString aName)
 :
			base(PlotMgt_PlotterParameter_Ctor66CFACD0(aName.Instance) )
		{}
			public bool Save(OSDFile aFile)
				{
					return PlotMgt_PlotterParameter_Save626970E9(Instance, aFile.Instance);
				}
			public void SValue(TCollectionAsciiString aValue)
				{
					PlotMgt_PlotterParameter_SValue66CFACD0(Instance, aValue.Instance);
				}
			public void Dump()
				{
					PlotMgt_PlotterParameter_Dump(Instance);
				}
			public void SetSValue(TCollectionAsciiString aValue)
				{
					PlotMgt_PlotterParameter_SetSValue66CFACD0(Instance, aValue.Instance);
				}
		public bool State{
			set { 
				PlotMgt_PlotterParameter_SetState(Instance, value);
			}
		}
		public PlotMgtTypeOfPlotterParameter Type{
			set { 
				PlotMgt_PlotterParameter_SetType(Instance, (int)value);
			}
		}
		public TCollectionAsciiString Name{
			get {
				return new TCollectionAsciiString(PlotMgt_PlotterParameter_Name(Instance));
			}
		}
		public TCollectionAsciiString OldName{
			get {
				return new TCollectionAsciiString(PlotMgt_PlotterParameter_OldName(Instance));
			}
		}
		public bool NeedToBeSaved{
			get {
				return PlotMgt_PlotterParameter_NeedToBeSaved(Instance);
			}
		}
		public bool BValue{
			set { 
				PlotMgt_PlotterParameter_SetBValue(Instance, value);
			}
			get {
				return PlotMgt_PlotterParameter_BValue(Instance);
			}
		}
		public int IValue{
			set { 
				PlotMgt_PlotterParameter_SetIValue(Instance, value);
			}
			get {
				return PlotMgt_PlotterParameter_IValue(Instance);
			}
		}
		public double RValue{
			set { 
				PlotMgt_PlotterParameter_SetRValue(Instance, value);
			}
			get {
				return PlotMgt_PlotterParameter_RValue(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PlotMgt_PlotterParameter_Ctor66CFACD0(IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PlotMgt_PlotterParameter_Save626970E9(IntPtr instance, IntPtr aFile);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SValue66CFACD0(IntPtr instance, IntPtr aValue);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_Dump(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetSValue66CFACD0(IntPtr instance, IntPtr aValue);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetState(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PlotMgt_PlotterParameter_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr PlotMgt_PlotterParameter_OldName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PlotMgt_PlotterParameter_NeedToBeSaved(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetBValue(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool PlotMgt_PlotterParameter_BValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetIValue(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int PlotMgt_PlotterParameter_IValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgt_PlotterParameter_SetRValue(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double PlotMgt_PlotterParameter_RValue(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public PlotMgtPlotterParameter() { } 

		public PlotMgtPlotterParameter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ PlotMgtPlotterParameter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void PlotMgtPlotterParameter_Dtor(IntPtr instance);
	}
}
