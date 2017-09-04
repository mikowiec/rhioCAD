#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Dico;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Dico
{
	public class DicoDictionaryOfTransient : MMgtTShared
	{
		public DicoDictionaryOfTransient()
 :
			base(Dico_DictionaryOfTransient_Ctor() )
		{}
			public bool HasItem(string name,bool exact)
				{
					return Dico_DictionaryOfTransient_HasItemDE32234A(Instance, name, exact);
				}
			public bool HasItem(TCollectionAsciiString name,bool exact)
				{
					return Dico_DictionaryOfTransient_HasItem145F6059(Instance, name.Instance, exact);
				}
			public StandardTransient Item(string name,bool exact)
				{
					return new StandardTransient(Dico_DictionaryOfTransient_ItemDE32234A(Instance, name, exact));
				}
			public StandardTransient Item(TCollectionAsciiString name,bool exact)
				{
					return new StandardTransient(Dico_DictionaryOfTransient_Item145F6059(Instance, name.Instance, exact));
				}
			public bool GetItem(string name,StandardTransient anitem,bool exact)
				{
					return Dico_DictionaryOfTransient_GetItem5A688646(Instance, name, anitem.Instance, exact);
				}
			public bool GetItem(TCollectionAsciiString name,StandardTransient anitem,bool exact)
				{
					return Dico_DictionaryOfTransient_GetItem10A7D525(Instance, name.Instance, anitem.Instance, exact);
				}
			public void SetItem(string name,StandardTransient anitem,bool exact)
				{
					Dico_DictionaryOfTransient_SetItem5A688646(Instance, name, anitem.Instance, exact);
				}
			public void SetItem(TCollectionAsciiString name,StandardTransient anitem,bool exact)
				{
					Dico_DictionaryOfTransient_SetItem10A7D525(Instance, name.Instance, anitem.Instance, exact);
				}
			public StandardTransient NewItem(string name,ref bool isvalued,bool exact)
				{
					return new StandardTransient(Dico_DictionaryOfTransient_NewItem7BFBA428(Instance, name, ref isvalued, exact));
				}
			public StandardTransient NewItem(TCollectionAsciiString name,ref bool isvalued,bool exact)
				{
					return new StandardTransient(Dico_DictionaryOfTransient_NewItem18A50CD3(Instance, name.Instance, ref isvalued, exact));
				}
			public bool RemoveItem(string name,bool cln,bool exact)
				{
					return Dico_DictionaryOfTransient_RemoveItem7BFBA428(Instance, name, cln, exact);
				}
			public bool RemoveItem(TCollectionAsciiString name,bool cln,bool exact)
				{
					return Dico_DictionaryOfTransient_RemoveItem18A50CD3(Instance, name.Instance, cln, exact);
				}
			public void Clean()
				{
					Dico_DictionaryOfTransient_Clean(Instance);
				}
			public void Clear()
				{
					Dico_DictionaryOfTransient_Clear(Instance);
				}
			public bool Complete(DicoDictionaryOfTransient acell)
				{
					return Dico_DictionaryOfTransient_Complete31B29E5D(Instance, acell.Instance);
				}
		public bool IsEmpty{
			get {
				return Dico_DictionaryOfTransient_IsEmpty(Instance);
			}
		}
		public DicoDictionaryOfTransient Copy{
			get {
				return new DicoDictionaryOfTransient(Dico_DictionaryOfTransient_Copy(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_HasItemDE32234A(IntPtr instance, string name,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_HasItem145F6059(IntPtr instance, IntPtr name,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_ItemDE32234A(IntPtr instance, string name,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_Item145F6059(IntPtr instance, IntPtr name,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_GetItem5A688646(IntPtr instance, string name,IntPtr anitem,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_GetItem10A7D525(IntPtr instance, IntPtr name,IntPtr anitem,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern void Dico_DictionaryOfTransient_SetItem5A688646(IntPtr instance, string name,IntPtr anitem,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern void Dico_DictionaryOfTransient_SetItem10A7D525(IntPtr instance, IntPtr name,IntPtr anitem,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_NewItem7BFBA428(IntPtr instance, string name,ref bool isvalued,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_NewItem18A50CD3(IntPtr instance, IntPtr name,ref bool isvalued,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_RemoveItem7BFBA428(IntPtr instance, string name,bool cln,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_RemoveItem18A50CD3(IntPtr instance, IntPtr name,bool cln,bool exact);
		[DllImport("NaroOccCore.dll")]
		private static extern void Dico_DictionaryOfTransient_Clean(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Dico_DictionaryOfTransient_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_Complete31B29E5D(IntPtr instance, IntPtr acell);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Dico_DictionaryOfTransient_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Dico_DictionaryOfTransient_Copy(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public DicoDictionaryOfTransient(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ DicoDictionaryOfTransient_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void DicoDictionaryOfTransient_Dtor(IntPtr instance);
	}
}
