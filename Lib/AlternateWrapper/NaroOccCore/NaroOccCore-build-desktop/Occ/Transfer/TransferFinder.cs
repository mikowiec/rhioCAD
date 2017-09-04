#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.Dico;
using NaroCppCore.Occ.Interface;
using NaroCppCore.Occ.Transfer;

#endregion

namespace NaroCppCore.Occ.Transfer
{
	public class TransferFinder : MMgtTShared
	{
			public void SetAttribute(string name,StandardTransient val)
				{
					Transfer_Finder_SetAttributeD637E227(Instance, name, val.Instance);
				}
			public bool RemoveAttribute(string name)
				{
					return Transfer_Finder_RemoveAttribute9381D4D(Instance, name);
				}
			public bool GetAttribute(string name,StandardType type,StandardTransient val)
				{
					return Transfer_Finder_GetAttributeCBA201FA(Instance, name, type.Instance, val.Instance);
				}
			public StandardTransient Attribute(string name)
				{
					return new StandardTransient(Transfer_Finder_Attribute9381D4D(Instance, name));
				}
			public InterfaceParamType AttributeType(string name)
				{
					return (InterfaceParamType)Transfer_Finder_AttributeType9381D4D(Instance, name);
				}
			public void SetIntegerAttribute(string name,int val)
				{
					Transfer_Finder_SetIntegerAttribute800FADE1(Instance, name, val);
				}
			public bool GetIntegerAttribute(string name,ref int val)
				{
					return Transfer_Finder_GetIntegerAttribute800FADE1(Instance, name, ref val);
				}
			public int IntegerAttribute(string name)
				{
					return Transfer_Finder_IntegerAttribute9381D4D(Instance, name);
				}
			public void SetRealAttribute(string name,double val)
				{
					Transfer_Finder_SetRealAttribute28A665C3(Instance, name, val);
				}
			public bool GetRealAttribute(string name,ref double val)
				{
					return Transfer_Finder_GetRealAttribute28A665C3(Instance, name, ref val);
				}
			public double RealAttribute(string name)
				{
					return Transfer_Finder_RealAttribute9381D4D(Instance, name);
				}
			public void SetStringAttribute(string name,string val)
				{
					Transfer_Finder_SetStringAttribute8A1B7C71(Instance, name, val);
				}
			public bool GetStringAttribute(string name,ref string val)
				{
					return Transfer_Finder_GetStringAttribute8A1B7C71(Instance, name, ref val);
				}
			public string StringAttribute(string name)
				{
					return Transfer_Finder_StringAttribute9381D4D(Instance, name);
				}
			public void SameAttributes(TransferFinder other)
				{
					Transfer_Finder_SameAttributes62F97174(Instance, other.Instance);
				}
			public void GetAttributes(TransferFinder other,string fromname,bool copied)
				{
					Transfer_Finder_GetAttributesDA2BDE8C(Instance, other.Instance, fromname, copied);
				}
		public int GetHashCode{
			get {
				return Transfer_Finder_GetHashCode(Instance);
			}
		}
		public StandardType ValueType{
			get {
				return new StandardType(Transfer_Finder_ValueType(Instance));
			}
		}
		public string ValueTypeName{
			get {
				return Transfer_Finder_ValueTypeName(Instance);
			}
		}
		public DicoDictionaryOfTransient AttrList{
			get {
				return new DicoDictionaryOfTransient(Transfer_Finder_AttrList(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_SetAttributeD637E227(IntPtr instance, string name,IntPtr val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_Finder_RemoveAttribute9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_Finder_GetAttributeCBA201FA(IntPtr instance, string name,IntPtr type,IntPtr val);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_Finder_Attribute9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_Finder_AttributeType9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_SetIntegerAttribute800FADE1(IntPtr instance, string name,int val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_Finder_GetIntegerAttribute800FADE1(IntPtr instance, string name,ref int val);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_Finder_IntegerAttribute9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_SetRealAttribute28A665C3(IntPtr instance, string name,double val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_Finder_GetRealAttribute28A665C3(IntPtr instance, string name,ref double val);
		[DllImport("NaroOccCore.dll")]
		private static extern double Transfer_Finder_RealAttribute9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_SetStringAttribute8A1B7C71(IntPtr instance, string name,string val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Transfer_Finder_GetStringAttribute8A1B7C71(IntPtr instance, string name,ref string val);
		[DllImport("NaroOccCore.dll")]
		private static extern string Transfer_Finder_StringAttribute9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_SameAttributes62F97174(IntPtr instance, IntPtr other);
		[DllImport("NaroOccCore.dll")]
		private static extern void Transfer_Finder_GetAttributesDA2BDE8C(IntPtr instance, IntPtr other,string fromname,bool copied);
		[DllImport("NaroOccCore.dll")]
		private static extern int Transfer_Finder_GetHashCode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_Finder_ValueType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string Transfer_Finder_ValueTypeName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Transfer_Finder_AttrList(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TransferFinder() { } 

		public TransferFinder(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TransferFinder_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TransferFinder_Dtor(IntPtr instance);
	}
}
