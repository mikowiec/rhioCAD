#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.XSControl;
using NaroCppCore.Occ.IFSelect;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.XSControl
{
	public class XSControlReader : NativeInstancePtr
	{
		public XSControlReader()
 :
			base(XSControl_Reader_Ctor() )
		{}
		public XSControlReader(string norm)
 :
			base(XSControl_Reader_Ctor9381D4D(norm) )
		{}
		public XSControlReader(XSControlWorkSession WS,bool scratch)
 :
			base(XSControl_Reader_CtorC53309E3(WS.Instance, scratch) )
		{}
			public bool SetNorm(string norm)
				{
					return XSControl_Reader_SetNorm9381D4D(Instance, norm);
				}
			public void SetWS(XSControlWorkSession WS,bool scratch)
				{
					XSControl_Reader_SetWSC53309E3(Instance, WS.Instance, scratch);
				}
			public XSControlWorkSession WS()
				{
					return new XSControlWorkSession(XSControl_Reader_WS(Instance));
				}
			public IFSelectReturnStatus ReadFile(string filename)
				{
					return (IFSelectReturnStatus)XSControl_Reader_ReadFile9381D4D(Instance, filename);
				}
			public StandardTransient RootForTransfer(int num)
				{
					return new StandardTransient(XSControl_Reader_RootForTransferE8219145(Instance, num));
				}
			public bool TransferOneRoot(int num)
				{
					return XSControl_Reader_TransferOneRootE8219145(Instance, num);
				}
			public bool TransferOne(int num)
				{
					return XSControl_Reader_TransferOneE8219145(Instance, num);
				}
			public bool TransferEntity(StandardTransient start)
				{
					return XSControl_Reader_TransferEntityF411CB01(Instance, start.Instance);
				}
			public void ClearShapes()
				{
					XSControl_Reader_ClearShapes(Instance);
				}
			public TopoDSShape Shape(int num)
				{
					return new TopoDSShape(XSControl_Reader_ShapeE8219145(Instance, num));
				}
			public void PrintCheckLoad(bool failsonly,IFSelectPrintCount mode)
				{
					XSControl_Reader_PrintCheckLoad57E14BA(Instance, failsonly, (int)mode);
				}
			public void PrintCheckTransfer(bool failsonly,IFSelectPrintCount mode)
				{
					XSControl_Reader_PrintCheckTransfer57E14BA(Instance, failsonly, (int)mode);
				}
			public void PrintStatsTransfer(int what,int mode)
				{
					XSControl_Reader_PrintStatsTransfer5107F6FE(Instance, what, mode);
				}
		public int NbRootsForTransfer{
			get {
				return XSControl_Reader_NbRootsForTransfer(Instance);
			}
		}
		public int TransferRoots{
			get {
				return XSControl_Reader_TransferRoots(Instance);
			}
		}
		public int NbShapes{
			get {
				return XSControl_Reader_NbShapes(Instance);
			}
		}
		public TopoDSShape OneShape{
			get {
				return new TopoDSShape(XSControl_Reader_OneShape(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_Ctor9381D4D(string norm);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_CtorC53309E3(IntPtr WS,bool scratch);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_Reader_SetNorm9381D4D(IntPtr instance, string norm);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_Reader_SetWSC53309E3(IntPtr instance, IntPtr WS,bool scratch);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_WS(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_Reader_ReadFile9381D4D(IntPtr instance, string filename);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_RootForTransferE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_Reader_TransferOneRootE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_Reader_TransferOneE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_Reader_TransferEntityF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_Reader_ClearShapes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_ShapeE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_Reader_PrintCheckLoad57E14BA(IntPtr instance, bool failsonly,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_Reader_PrintCheckTransfer57E14BA(IntPtr instance, bool failsonly,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_Reader_PrintStatsTransfer5107F6FE(IntPtr instance, int what,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_Reader_NbRootsForTransfer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_Reader_TransferRoots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_Reader_NbShapes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_Reader_OneShape(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public XSControlReader(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ XSControlReader_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void XSControlReader_Dtor(IntPtr instance);
	}
}
