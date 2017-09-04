#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.IFSelect;
using NaroCppCore.Occ.Dico;
using NaroCppCore.Occ.Transfer;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.XSControl
{
	public class XSControlWorkSession : IFSelectWorkSession
	{
		public XSControlWorkSession()
 :
			base(XSControl_WorkSession_Ctor() )
		{}
			public void ClearData(int mode)
				{
					XSControl_WorkSession_ClearDataE8219145(Instance, mode);
				}
			public bool SelectNorm(string normname,string profile)
				{
					return XSControl_WorkSession_SelectNorm8A1B7C71(Instance, normname, profile);
				}
			public bool SelectProfile(string profile)
				{
					return XSControl_WorkSession_SelectProfile9381D4D(Instance, profile);
				}
			public void AdaptNorm()
				{
					XSControl_WorkSession_AdaptNorm(Instance);
				}
			public string SelectedNorm(bool rsc)
				{
					return XSControl_WorkSession_SelectedNorm461FC46A(Instance, rsc);
				}
			public void ClearContext()
				{
					XSControl_WorkSession_ClearContext(Instance);
				}
			public void InitTransferReader(int mode)
				{
					XSControl_WorkSession_InitTransferReaderE8219145(Instance, mode);
				}
			public TransferTransientProcess MapReader()
				{
					return new TransferTransientProcess(XSControl_WorkSession_MapReader(Instance));
				}
			public bool SetMapReader(TransferTransientProcess TP)
				{
					return XSControl_WorkSession_SetMapReader38FF314(Instance, TP.Instance);
				}
			public StandardTransient Result(StandardTransient ent,int mode)
				{
					return new StandardTransient(XSControl_WorkSession_Result73E03EE2(Instance, ent.Instance, mode));
				}
			public int TransferReadOne(StandardTransient ents)
				{
					return XSControl_WorkSession_TransferReadOneF411CB01(Instance, ents.Instance);
				}
			public IFSelectReturnStatus TransferWriteShape(TopoDSShape shape,bool compgraph)
				{
					return (IFSelectReturnStatus)XSControl_WorkSession_TransferWriteShape5E7DD5C8(Instance, shape.Instance, compgraph);
				}
			public void ClearBinders()
				{
					XSControl_WorkSession_ClearBinders(Instance);
				}
		public DicoDictionaryOfTransient Context{
			get {
				return new DicoDictionaryOfTransient(XSControl_WorkSession_Context(Instance));
			}
		}
		public DicoDictionaryOfTransient AllContext{
			set { 
				XSControl_WorkSession_SetAllContext(Instance, value.Instance);
			}
		}
		public int TransferReadRoots{
			get {
				return XSControl_WorkSession_TransferReadRoots(Instance);
			}
		}
		public int ModeWriteShape{
			set { 
				XSControl_WorkSession_SetModeWriteShape(Instance, value);
			}
			get {
				return XSControl_WorkSession_ModeWriteShape(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_WorkSession_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_ClearDataE8219145(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_WorkSession_SelectNorm8A1B7C71(IntPtr instance, string normname,string profile);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_WorkSession_SelectProfile9381D4D(IntPtr instance, string profile);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_AdaptNorm(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string XSControl_WorkSession_SelectedNorm461FC46A(IntPtr instance, bool rsc);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_ClearContext(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_InitTransferReaderE8219145(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_WorkSession_MapReader(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool XSControl_WorkSession_SetMapReader38FF314(IntPtr instance, IntPtr TP);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_WorkSession_Result73E03EE2(IntPtr instance, IntPtr ent,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_WorkSession_TransferReadOneF411CB01(IntPtr instance, IntPtr ents);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_WorkSession_TransferWriteShape5E7DD5C8(IntPtr instance, IntPtr shape,bool compgraph);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_ClearBinders(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr XSControl_WorkSession_Context(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_SetAllContext(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_WorkSession_TransferReadRoots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void XSControl_WorkSession_SetModeWriteShape(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int XSControl_WorkSession_ModeWriteShape(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public XSControlWorkSession(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ XSControlWorkSession_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void XSControlWorkSession_Dtor(IntPtr instance);
	}
}
