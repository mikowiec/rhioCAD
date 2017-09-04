#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Standard
{
	public class StandardType : StandardTransient
	{
		public StandardType(string aName,int aSize)
 :
			base(Standard_Type_Ctor800FADE1(aName, aSize) )
		{}
		public StandardType(string aName,int aSize,int aNumberOfParent,IntPtr aAncestors)
 :
			base(Standard_Type_Ctor29DC790D(aName, aSize, aNumberOfParent, aAncestors) )
		{}
		public StandardType(string aName,int aSize,int aNumberOfElement,int aNumberOfParent,IntPtr anAncestors,IntPtr aElements)
 :
			base(Standard_Type_CtorAF7BE74A(aName, aSize, aNumberOfElement, aNumberOfParent, anAncestors, aElements) )
		{}
		public StandardType(string aName,int aSize,int aNumberOfParent,IntPtr anAncestors,IntPtr aFields)
 :
			base(Standard_Type_Ctor23B9A32F(aName, aSize, aNumberOfParent, anAncestors, aFields) )
		{}
			public bool SubType(StandardType aOther)
				{
					return Standard_Type_SubTypeE2B3EAC1(Instance, aOther.Instance);
				}
			public bool SubType(string theName)
				{
					return Standard_Type_SubType9381D4D(Instance, theName);
				}
		public string Name{
			get {
				return Standard_Type_Name(Instance);
			}
		}
		public int Size{
			get {
				return Standard_Type_Size(Instance);
			}
		}
		public bool IsImported{
			get {
				return Standard_Type_IsImported(Instance);
			}
		}
		public bool IsPrimitive{
			get {
				return Standard_Type_IsPrimitive(Instance);
			}
		}
		public bool IsEnumeration{
			get {
				return Standard_Type_IsEnumeration(Instance);
			}
		}
		public bool IsClass{
			get {
				return Standard_Type_IsClass(Instance);
			}
		}
		public int NumberOfParent{
			get {
				return Standard_Type_NumberOfParent(Instance);
			}
		}
		public int NumberOfAncestor{
			get {
				return Standard_Type_NumberOfAncestor(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_Type_Ctor800FADE1(string aName,int aSize);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_Type_Ctor29DC790D(string aName,int aSize,int aNumberOfParent,IntPtr aAncestors);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_Type_CtorAF7BE74A(string aName,int aSize,int aNumberOfElement,int aNumberOfParent,IntPtr anAncestors,IntPtr aElements);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_Type_Ctor23B9A32F(string aName,int aSize,int aNumberOfParent,IntPtr anAncestors,IntPtr aFields);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_SubTypeE2B3EAC1(IntPtr instance, IntPtr aOther);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_SubType9381D4D(IntPtr instance, string theName);
		[DllImport("NaroOccCore.dll")]
		private static extern string Standard_Type_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Standard_Type_Size(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_IsImported(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_IsPrimitive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_IsEnumeration(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Type_IsClass(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Standard_Type_NumberOfParent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Standard_Type_NumberOfAncestor(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StandardType() { } 

		public StandardType(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StandardType_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StandardType_Dtor(IntPtr instance);
	}
}
