#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Transfer
{
	public class TransferProcessForTransient : MMgtTShared
	{
		public TransferProcessForTransient(int nb)
 :
			base(Transfer_ProcessForTransient_CtorE8219145(nb) )
		{}
			public void Clear()
				{
					Transfer_ProcessForTransient_Clear(Instance);
				}
			public void Clean()
				{
					Transfer_ProcessForTransient_Clean(Instance);
				}
			public void Resize(int nb)
				{
					Transfer_ProcessForTransient_ResizeE8219145(Instance, nb);
				}
			public bool IsBound(StandardTransient start)
				{
					return Transfer_ProcessForTransient_IsBoundF411CB01(Instance, start.Instance);
				}
			public bool IsAlreadyUsed(StandardTransient start)
				{
					return Transfer_ProcessForTransient_IsAlreadyUsedF411CB01(Instance, start.Instance);
				}
			public bool Unbind(StandardTransient start)
				{
					return Transfer_ProcessForTransient_UnbindF411CB01(Instance, start.Instance);
				}
			public void SendFail(StandardTransient start,MessageMsg amsg)
				{
					Transfer_ProcessForTransient_SendFailF8E53BFD(Instance, start.Instance, amsg.Instance);
				}
			public void SendWarning(StandardTransient start,MessageMsg amsg)
				{
					Transfer_ProcessForTransient_SendWarningF8E53BFD(Instance, start.Instance, amsg.Instance);
				}
			public void SendMsg(StandardTransient start,MessageMsg amsg)
				{
					Transfer_ProcessForTransient_SendMsgF8E53BFD(Instance, start.Instance, amsg.Instance);
				}
			public void AddFail(StandardTransient start,string mess,string orig)
				{
					Transfer_ProcessForTransient_AddFailDBC2D08D(Instance, start.Instance, mess, orig);
				}
			public void AddError(StandardTransient start,string mess,string orig)
				{
					Transfer_ProcessForTransient_AddErrorDBC2D08D(Instance, start.Instance, mess, orig);
				}
			public void AddFail(StandardTransient start,MessageMsg amsg)
				{
					Transfer_ProcessForTransient_AddFailF8E53BFD(Instance, start.Instance, amsg.Instance);
				}
			public void AddWarning(StandardTransient start,string mess,string orig)
				{
					Transfer_ProcessForTransient_AddWarningDBC2D08D(Instance, start.Instance, mess, orig);
				}
			public void AddWarning(StandardTransient start,MessageMsg amsg)
				{
					Transfer_ProcessForTransient_AddWarningF8E53BFD(Instance, start.Instance, amsg.Instance);
				}
			public void Mend(StandardTransient start,string pref)
				{
					Transfer_ProcessForTransient_Mend929AF976(Instance, start.Instance, pref);
				}
			public void BindTransient(StandardTransient start,StandardTransient res)
				{
					Transfer_ProcessForTransient_BindTransientAB457C73(Instance, start.Instance, res.Instance);
				}
			public StandardTransient FindTransient(StandardTransient start)
				{
					return new StandardTransient(Transfer_ProcessForTransient_FindTransientF411CB01(Instance, start.Instance));
				}
			public void BindMultiple(StandardTransient start)
				{
					Transfer_ProcessForTransient_BindMultipleF411CB01(Instance, start.Instance);
				}
			public void AddMultiple(StandardTransient start,StandardTransient res)
				{
					Transfer_ProcessForTransient_AddMultipleAB457C73(Instance, start.Instance, res.Instance);
				}
			public bool FindTypedTransient(StandardTransient start,StandardType atype,StandardTransient val)
				{
					return Transfer_ProcessForTransient_FindTypedTransient2A525E75(Instance, start.Instance, atype.Instance, val.Instance);
				}
			public StandardTransient Mapped(int num)
				{
					return new StandardTransient(Transfer_ProcessForTransient_MappedE8219145(Instance, num));
				}
			public int MapIndex(StandardTransient start)
				{
					return Transfer_ProcessForTransient_MapIndexF411CB01(Instance, start.Instance);
				}
			public void SetRoot(StandardTransient start)
				{
					Transfer_ProcessForTransient_SetRootF411CB01(Instance, start.Instance);
				}
			public StandardTransient Root(int num)
				{
					return new StandardTransient(Transfer_ProcessForTransient_RootE8219145(Instance, num));
				}
			public int RootIndex(StandardTransient start)
				{
					return Transfer_ProcessForTransient_RootIndexF411CB01(Instance, start.Instance);
				}
			public void ResetNestingLevel()
				{
					Transfer_ProcessForTransient_ResetNestingLevel(Instance);
				}
			public bool Recognize(StandardTransient start)
				{
					return Transfer_ProcessForTransient_RecognizeF411CB01(Instance, start.Instance);
				}
			public bool Transfer(StandardTransient start)
				{
					return Transfer_ProcessForTransient_TransferF411CB01(Instance, start.Instance);
				}
			public bool IsLooping(int alevel)
				{
					return Transfer_ProcessForTransient_IsLoopingE8219145(Instance, alevel);
				}
			public bool IsCheckListEmpty(StandardTransient start,int level,bool erronly)
				{
					return Transfer_ProcessForTransient_IsCheckListEmpty145DF9DF(Instance, start.Instance, level, erronly);
				}
			public void RemoveResult(StandardTransient start,int level,bool compute)
				{
					Transfer_ProcessForTransient_RemoveResult145DF9DF(Instance, start.Instance, level, compute);
				}
			public int CheckNum(StandardTransient start)
				{
					return Transfer_ProcessForTransient_CheckNumF411CB01(Instance, start.Instance);
				}
		public int TraceLevel{
			set { 
				Transfer_ProcessForTransient_SetTraceLevel(Instance, value);
			}
			get {
				return Transfer_ProcessForTransient_TraceLevel(Instance);
			}
		}
		public int NbMapped{
			get {
				return Transfer_ProcessForTransient_NbMapped(Instance);
			}
		}
		public bool RootManagement{
			set { 
				Transfer_ProcessForTransient_SetRootManagement(Instance, value);
			}
		}
		public int NbRoots{
			get {
				return Transfer_ProcessForTransient_NbRoots(Instance);
			}
		}
		public int NestingLevel{
			get {
				return Transfer_ProcessForTransient_NestingLevel(Instance);
			}
		}
		public bool ErrorHandle{
			set { 
				Transfer_ProcessForTransient_SetErrorHandle(Instance, value);
			}
			get {
				return Transfer_ProcessForTransient_ErrorHandle(Instance);
			}
		}
		public MessageProgressIndicator Progress{
			set { 
				Transfer_ProcessForTransient_SetProgress(Instance, value.Instance);
			}
		}
		public MessageProgressIndicator GetProgress{
			get {
				return new MessageProgressIndicator(Transfer_ProcessForTransient_GetProgress(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_ProcessForTransient_CtorE8219145(int nb);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_Clean(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_ResizeE8219145(IntPtr instance, int nb);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_IsBoundF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_IsAlreadyUsedF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_UnbindF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SendFailF8E53BFD(IntPtr instance, IntPtr start,IntPtr amsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SendWarningF8E53BFD(IntPtr instance, IntPtr start,IntPtr amsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SendMsgF8E53BFD(IntPtr instance, IntPtr start,IntPtr amsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddFailDBC2D08D(IntPtr instance, IntPtr start,string mess,string orig);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddErrorDBC2D08D(IntPtr instance, IntPtr start,string mess,string orig);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddFailF8E53BFD(IntPtr instance, IntPtr start,IntPtr amsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddWarningDBC2D08D(IntPtr instance, IntPtr start,string mess,string orig);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddWarningF8E53BFD(IntPtr instance, IntPtr start,IntPtr amsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_Mend929AF976(IntPtr instance, IntPtr start,string pref);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_BindTransientAB457C73(IntPtr instance, IntPtr start,IntPtr res);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_ProcessForTransient_FindTransientF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_BindMultipleF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_AddMultipleAB457C73(IntPtr instance, IntPtr start,IntPtr res);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_FindTypedTransient2A525E75(IntPtr instance, IntPtr start,IntPtr atype,IntPtr val);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_ProcessForTransient_MappedE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_MapIndexF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SetRootF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_ProcessForTransient_RootE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_RootIndexF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_ResetNestingLevel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_RecognizeF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_TransferF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_IsLoopingE8219145(IntPtr instance, int alevel);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_IsCheckListEmpty145DF9DF(IntPtr instance, IntPtr start,int level,bool erronly);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_RemoveResult145DF9DF(IntPtr instance, IntPtr start,int level,bool compute);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_CheckNumF411CB01(IntPtr instance, IntPtr start);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SetTraceLevel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_TraceLevel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_NbMapped(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SetRootManagement(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_NbRoots(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_ProcessForTransient_NestingLevel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SetErrorHandle(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_ProcessForTransient_ErrorHandle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_ProcessForTransient_SetProgress(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_ProcessForTransient_GetProgress(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TransferProcessForTransient() { } 

		public TransferProcessForTransient(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TransferProcessForTransient_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TransferProcessForTransient_Dtor(IntPtr instance);
	}
}
