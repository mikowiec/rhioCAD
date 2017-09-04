#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.IFSelect;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Interface;

#endregion

namespace NaroCppCore.Occ.IFSelect
{
	public class IFSelectWorkSession : MMgtTShared
	{
		public IFSelectWorkSession()
 :
			base(IFSelect_WorkSession_Ctor() )
		{}
			public IFSelectReturnStatus ReadFile(string filename)
				{
					return (IFSelectReturnStatus)IFSelect_WorkSession_ReadFile9381D4D(Instance, filename);
				}
			public StandardTransient StartingEntity(int num)
				{
					return new StandardTransient(IFSelect_WorkSession_StartingEntityE8219145(Instance, num));
				}
			public int StartingNumber(StandardTransient ent)
				{
					return IFSelect_WorkSession_StartingNumberF411CB01(Instance, ent.Instance);
				}
			public int NumberFromLabel(string val,int afternum)
				{
					return IFSelect_WorkSession_NumberFromLabel800FADE1(Instance, val, afternum);
				}
			public TCollectionHAsciiString EntityLabel(StandardTransient ent)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_EntityLabelF411CB01(Instance, ent.Instance));
				}
			public TCollectionHAsciiString EntityName(StandardTransient ent)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_EntityNameF411CB01(Instance, ent.Instance));
				}
			public int CategoryNumber(StandardTransient ent)
				{
					return IFSelect_WorkSession_CategoryNumberF411CB01(Instance, ent.Instance);
				}
			public string CategoryName(StandardTransient ent)
				{
					return IFSelect_WorkSession_CategoryNameF411CB01(Instance, ent.Instance);
				}
			public string ValidityName(StandardTransient ent)
				{
					return IFSelect_WorkSession_ValidityNameF411CB01(Instance, ent.Instance);
				}
			public void ClearData(int mode)
				{
					IFSelect_WorkSession_ClearDataE8219145(Instance, mode);
				}
			public bool ComputeGraph(bool enforce)
				{
					return IFSelect_WorkSession_ComputeGraph461FC46A(Instance, enforce);
				}
			public bool ComputeCheck(bool enforce)
				{
					return IFSelect_WorkSession_ComputeCheck461FC46A(Instance, enforce);
				}
			public StandardTransient Item(int id)
				{
					return new StandardTransient(IFSelect_WorkSession_ItemE8219145(Instance, id));
				}
			public int ItemIdent(StandardTransient item)
				{
					return IFSelect_WorkSession_ItemIdentF411CB01(Instance, item.Instance);
				}
			public StandardTransient NamedItem(string name)
				{
					return new StandardTransient(IFSelect_WorkSession_NamedItem9381D4D(Instance, name));
				}
			public StandardTransient NamedItem(TCollectionHAsciiString name)
				{
					return new StandardTransient(IFSelect_WorkSession_NamedItemB439B3D5(Instance, name.Instance));
				}
			public int NameIdent(string name)
				{
					return IFSelect_WorkSession_NameIdent9381D4D(Instance, name);
				}
			public bool HasName(StandardTransient item)
				{
					return IFSelect_WorkSession_HasNameF411CB01(Instance, item.Instance);
				}
			public TCollectionHAsciiString Name(StandardTransient item)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_NameF411CB01(Instance, item.Instance));
				}
			public int AddItem(StandardTransient item,bool active)
				{
					return IFSelect_WorkSession_AddItemA46DC5B5(Instance, item.Instance, active);
				}
			public int AddNamedItem(string name,StandardTransient item,bool active)
				{
					return IFSelect_WorkSession_AddNamedItem5A688646(Instance, name, item.Instance, active);
				}
			public bool SetActive(StandardTransient item,bool mode)
				{
					return IFSelect_WorkSession_SetActiveA46DC5B5(Instance, item.Instance, mode);
				}
			public bool RemoveNamedItem(string name)
				{
					return IFSelect_WorkSession_RemoveNamedItem9381D4D(Instance, name);
				}
			public bool RemoveName(string name)
				{
					return IFSelect_WorkSession_RemoveName9381D4D(Instance, name);
				}
			public bool RemoveItem(StandardTransient item)
				{
					return IFSelect_WorkSession_RemoveItemF411CB01(Instance, item.Instance);
				}
			public void ClearItems()
				{
					IFSelect_WorkSession_ClearItems(Instance);
				}
			public TCollectionHAsciiString ItemLabel(int id)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_ItemLabelE8219145(Instance, id));
				}
			public int NextIdentForLabel(string label,int id,int mode)
				{
					return IFSelect_WorkSession_NextIdentForLabelC8778026(Instance, label, id, mode);
				}
			public StandardTransient NewParamFromStatic(string statname,string name)
				{
					return new StandardTransient(IFSelect_WorkSession_NewParamFromStatic8A1B7C71(Instance, statname, name));
				}
			public TCollectionHAsciiString TextParam(int id)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_TextParamE8219145(Instance, id));
				}
			public TCollectionAsciiString TextValue(TCollectionHAsciiString par)
				{
					return new TCollectionAsciiString(IFSelect_WorkSession_TextValueB439B3D5(Instance, par.Instance));
				}
			public TCollectionHAsciiString NewTextParam(string name)
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_NewTextParam9381D4D(Instance, name));
				}
			public bool SetTextValue(TCollectionHAsciiString par,string val)
				{
					return IFSelect_WorkSession_SetTextValueC5444B6E(Instance, par.Instance, val);
				}
			public bool ResetItemSelection(StandardTransient item)
				{
					return IFSelect_WorkSession_ResetItemSelectionF411CB01(Instance, item.Instance);
				}
			public void ClearShareOut(bool onlydisp)
				{
					IFSelect_WorkSession_ClearShareOut461FC46A(Instance, onlydisp);
				}
			public int NbFinalModifiers(bool formodel)
				{
					return IFSelect_WorkSession_NbFinalModifiers461FC46A(Instance, formodel);
				}
			public bool ChangeModifierRank(bool formodel,int before,int after)
				{
					return IFSelect_WorkSession_ChangeModifierRank282F7253(Instance, formodel, before, after);
				}
			public void ClearFinalModifiers()
				{
					IFSelect_WorkSession_ClearFinalModifiers(Instance);
				}
			public TCollectionHAsciiString DefaultFileRoot()
				{
					return new TCollectionHAsciiString(IFSelect_WorkSession_DefaultFileRoot(Instance));
				}
			public string GiveFileRoot(string file)
				{
					return IFSelect_WorkSession_GiveFileRoot9381D4D(Instance, file);
				}
			public string GiveFileComplete(string file)
				{
					return IFSelect_WorkSession_GiveFileComplete9381D4D(Instance, file);
				}
			public void ClearFile()
				{
					IFSelect_WorkSession_ClearFile(Instance);
				}
			public void EvaluateFile()
				{
					IFSelect_WorkSession_EvaluateFile(Instance);
				}
			public TCollectionAsciiString FileName(int num)
				{
					return new TCollectionAsciiString(IFSelect_WorkSession_FileNameE8219145(Instance, num));
				}
			public void BeginSentFiles(bool record)
				{
					IFSelect_WorkSession_BeginSentFiles461FC46A(Instance, record);
				}
			public InterfaceEntityIterator SentList(int count)
				{
					return new InterfaceEntityIterator(IFSelect_WorkSession_SentListE8219145(Instance, count));
				}
			public bool SetRemaining(IFSelectRemainMode mode)
				{
					return IFSelect_WorkSession_SetRemaining9B05F970(Instance, (int)mode);
				}
			public IFSelectReturnStatus SendAll(string filename,bool computegraph)
				{
					return (IFSelectReturnStatus)IFSelect_WorkSession_SendAllDE32234A(Instance, filename, computegraph);
				}
			public IFSelectReturnStatus WriteFile(string filename)
				{
					return (IFSelectReturnStatus)IFSelect_WorkSession_WriteFile9381D4D(Instance, filename);
				}
			public int QueryCheckStatus(StandardTransient ent)
				{
					return IFSelect_WorkSession_QueryCheckStatusF411CB01(Instance, ent.Instance);
				}
			public int QueryParent(StandardTransient entdad,StandardTransient entson)
				{
					return IFSelect_WorkSession_QueryParentAB457C73(Instance, entdad.Instance, entson.Instance);
				}
			public void TraceStatics(int use,int mode)
				{
					IFSelect_WorkSession_TraceStatics5107F6FE(Instance, use, mode);
				}
			public void DumpShare()
				{
					IFSelect_WorkSession_DumpShare(Instance);
				}
			public void ListItems(string label)
				{
					IFSelect_WorkSession_ListItems9381D4D(Instance, label);
				}
			public void ListFinalModifiers(bool formodel)
				{
					IFSelect_WorkSession_ListFinalModifiers461FC46A(Instance, formodel);
				}
			public void TraceDumpModel(int mode)
				{
					IFSelect_WorkSession_TraceDumpModelE8219145(Instance, mode);
				}
			public void TraceDumpEntity(StandardTransient ent,int level)
				{
					IFSelect_WorkSession_TraceDumpEntity73E03EE2(Instance, ent.Instance, level);
				}
			public void EvaluateComplete(int mode)
				{
					IFSelect_WorkSession_EvaluateCompleteE8219145(Instance, mode);
				}
			public void ListEntities(InterfaceEntityIterator iter,int mode)
				{
					IFSelect_WorkSession_ListEntities84559BB6(Instance, iter.Instance, mode);
				}
		public bool ErrorHandle{
			set { 
				IFSelect_WorkSession_SetErrorHandle(Instance, value);
			}
			get {
				return IFSelect_WorkSession_ErrorHandle(Instance);
			}
		}
		public bool ModeStat{
			set { 
				IFSelect_WorkSession_SetModeStat(Instance, value);
			}
		}
		public bool GetModeStat{
			get {
				return IFSelect_WorkSession_GetModeStat(Instance);
			}
		}
		public bool HasModel{
			get {
				return IFSelect_WorkSession_HasModel(Instance);
			}
		}
		public string LoadedFile{
			set { 
				IFSelect_WorkSession_SetLoadedFile(Instance, value);
			}
			get {
				return IFSelect_WorkSession_LoadedFile(Instance);
			}
		}
		public int NbStartingEntities{
			get {
				return IFSelect_WorkSession_NbStartingEntities(Instance);
			}
		}
		public bool IsLoaded{
			get {
				return IFSelect_WorkSession_IsLoaded(Instance);
			}
		}
		public int MaxIdent{
			get {
				return IFSelect_WorkSession_MaxIdent(Instance);
			}
		}
		public int NbFiles{
			get {
				return IFSelect_WorkSession_NbFiles(Instance);
			}
		}
		public bool SendSplit{
			get {
				return IFSelect_WorkSession_SendSplit(Instance);
			}
		}
		public int MaxSendingCount{
			get {
				return IFSelect_WorkSession_MaxSendingCount(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_ReadFile9381D4D(IntPtr instance, string filename);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_StartingEntityE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_StartingNumberF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NumberFromLabel800FADE1(IntPtr instance, string val,int afternum);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_EntityLabelF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_EntityNameF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_CategoryNumberF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern string IFSelect_WorkSession_CategoryNameF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern string IFSelect_WorkSession_ValidityNameF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ClearDataE8219145(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_ComputeGraph461FC46A(IntPtr instance, bool enforce);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_ComputeCheck461FC46A(IntPtr instance, bool enforce);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_ItemE8219145(IntPtr instance, int id);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_ItemIdentF411CB01(IntPtr instance, IntPtr item);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_NamedItem9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_NamedItemB439B3D5(IntPtr instance, IntPtr name);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NameIdent9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_HasNameF411CB01(IntPtr instance, IntPtr item);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_NameF411CB01(IntPtr instance, IntPtr item);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_AddItemA46DC5B5(IntPtr instance, IntPtr item,bool active);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_AddNamedItem5A688646(IntPtr instance, string name,IntPtr item,bool active);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_SetActiveA46DC5B5(IntPtr instance, IntPtr item,bool mode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_RemoveNamedItem9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_RemoveName9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_RemoveItemF411CB01(IntPtr instance, IntPtr item);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ClearItems(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_ItemLabelE8219145(IntPtr instance, int id);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NextIdentForLabelC8778026(IntPtr instance, string label,int id,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_NewParamFromStatic8A1B7C71(IntPtr instance, string statname,string name);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_TextParamE8219145(IntPtr instance, int id);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_TextValueB439B3D5(IntPtr instance, IntPtr par);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_NewTextParam9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_SetTextValueC5444B6E(IntPtr instance, IntPtr par,string val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_ResetItemSelectionF411CB01(IntPtr instance, IntPtr item);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ClearShareOut461FC46A(IntPtr instance, bool onlydisp);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NbFinalModifiers461FC46A(IntPtr instance, bool formodel);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_ChangeModifierRank282F7253(IntPtr instance, bool formodel,int before,int after);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ClearFinalModifiers(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_DefaultFileRoot(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string IFSelect_WorkSession_GiveFileRoot9381D4D(IntPtr instance, string file);
		[DllImport("NaroOccCore.dll")]
		private static extern string IFSelect_WorkSession_GiveFileComplete9381D4D(IntPtr instance, string file);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ClearFile(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_EvaluateFile(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_FileNameE8219145(IntPtr instance, int num);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_BeginSentFiles461FC46A(IntPtr instance, bool record);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr IFSelect_WorkSession_SentListE8219145(IntPtr instance, int count);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_SetRemaining9B05F970(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_SendAllDE32234A(IntPtr instance, string filename,bool computegraph);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_WriteFile9381D4D(IntPtr instance, string filename);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_QueryCheckStatusF411CB01(IntPtr instance, IntPtr ent);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_QueryParentAB457C73(IntPtr instance, IntPtr entdad,IntPtr entson);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_TraceStatics5107F6FE(IntPtr instance, int use,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_DumpShare(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ListItems9381D4D(IntPtr instance, string label);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ListFinalModifiers461FC46A(IntPtr instance, bool formodel);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_TraceDumpModelE8219145(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_TraceDumpEntity73E03EE2(IntPtr instance, IntPtr ent,int level);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_EvaluateCompleteE8219145(IntPtr instance, int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_ListEntities84559BB6(IntPtr instance, IntPtr iter,int mode);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_SetErrorHandle(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_ErrorHandle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_SetModeStat(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_GetModeStat(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_HasModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelect_WorkSession_SetLoadedFile(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string IFSelect_WorkSession_LoadedFile(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NbStartingEntities(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_IsLoaded(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_MaxIdent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_NbFiles(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool IFSelect_WorkSession_SendSplit(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int IFSelect_WorkSession_MaxSendingCount(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public IFSelectWorkSession(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ IFSelectWorkSession_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void IFSelectWorkSession_Dtor(IntPtr instance);
	}
}
