#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.XSControl;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.STEPControl;
using NaroCppCore.Occ.IFSelect;

#endregion

namespace NaroCppCore.Occ.STEPControl
{
	public class STEPControlWriter : NativeInstancePtr
	{
		public STEPControlWriter()
 :
			base(STEPControl_Writer_Ctor() )
		{}
		public STEPControlWriter(XSControlWorkSession WS,bool scratch)
 :
			base(STEPControl_Writer_CtorC53309E3(WS.Instance, scratch) )
		{}
			public void UnsetTolerance()
				{
					STEPControl_Writer_UnsetTolerance(Instance);
				}
			public void SetWS(XSControlWorkSession WS,bool scratch)
				{
					STEPControl_Writer_SetWSC53309E3(Instance, WS.Instance, scratch);
				}
			public XSControlWorkSession WS()
				{
					return new XSControlWorkSession(STEPControl_Writer_WS(Instance));
				}
			public IFSelectReturnStatus Transfer(TopoDSShape sh,STEPControlStepModelType mode,bool compgraph)
				{
					return (IFSelectReturnStatus)STEPControl_Writer_Transfer9FBB318E(Instance, sh.Instance, (int)mode, compgraph);
				}
			public IFSelectReturnStatus Write(string filename)
				{
					return (IFSelectReturnStatus)STEPControl_Writer_Write9381D4D(Instance, filename);
				}
			public void PrintStatsTransfer(int what,int mode)
				{
					STEPControl_Writer_PrintStatsTransfer5107F6FE(Instance, what, mode);
				}
		public double Tolerance{
			set { 
				STEPControl_Writer_SetTolerance(Instance, value);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr STEPControl_Writer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr STEPControl_Writer_CtorC53309E3(IntPtr WS,bool scratch);
		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControl_Writer_UnsetTolerance(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControl_Writer_SetWSC53309E3(IntPtr instance, IntPtr WS,bool scratch);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr STEPControl_Writer_WS(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int STEPControl_Writer_Transfer9FBB318E(IntPtr instance, IntPtr sh,int mode,bool compgraph);
		[DllImport("NaroOccCore.dll")]
		private static extern int STEPControl_Writer_Write9381D4D(IntPtr instance, string filename);
		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControl_Writer_PrintStatsTransfer5107F6FE(IntPtr instance, int what,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControl_Writer_SetTolerance(IntPtr instance, double value);

		#region NativeInstancePtr Convert constructor

		public STEPControlWriter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ STEPControlWriter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void STEPControlWriter_Dtor(IntPtr instance);
	}
}
