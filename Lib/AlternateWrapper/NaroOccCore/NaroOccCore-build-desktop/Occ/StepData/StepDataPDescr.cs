#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.StepData;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.StepData
{
	public class StepDataPDescr : MMgtTShared
	{
		public StepDataPDescr()
 :
			base(StepData_PDescr_Ctor() )
		{}
			public void SetSelect()
				{
					StepData_PDescr_SetSelect(Instance);
				}
			public void AddMember(StepDataPDescr member)
				{
					StepData_PDescr_AddMemberE5051D76(Instance, member.Instance);
				}
			public void SetInteger()
				{
					StepData_PDescr_SetInteger(Instance);
				}
			public void SetReal()
				{
					StepData_PDescr_SetReal(Instance);
				}
			public void SetString()
				{
					StepData_PDescr_SetString(Instance);
				}
			public void SetBoolean()
				{
					StepData_PDescr_SetBoolean(Instance);
				}
			public void SetLogical()
				{
					StepData_PDescr_SetLogical(Instance);
				}
			public void SetEnum()
				{
					StepData_PDescr_SetEnum(Instance);
				}
			public void AddEnumDef(string enumdef)
				{
					StepData_PDescr_AddEnumDef9381D4D(Instance, enumdef);
				}
			public void AddArity(int arity)
				{
					StepData_PDescr_AddArityE8219145(Instance, arity);
				}
			public void SetField(string name,int rank)
				{
					StepData_PDescr_SetField800FADE1(Instance, name, rank);
				}
			public StepDataPDescr Member(string name)
				{
					return new StepDataPDescr(StepData_PDescr_Member9381D4D(Instance, name));
				}
			public int EnumValue(string name)
				{
					return StepData_PDescr_EnumValue9381D4D(Instance, name);
				}
			public string EnumText(int val)
				{
					return StepData_PDescr_EnumTextE8219145(Instance, val);
				}
			public bool IsType(StandardType atype)
				{
					return StepData_PDescr_IsTypeE2B3EAC1(Instance, atype.Instance);
				}
			public bool IsDescr(StepDataEDescr descr)
				{
					return StepData_PDescr_IsDescr67A25A8F(Instance, descr.Instance);
				}
		public string Name{
			set { 
				StepData_PDescr_SetName(Instance, value);
			}
			get {
				return StepData_PDescr_Name(Instance);
			}
		}
		public string MemberName{
			set { 
				StepData_PDescr_SetMemberName(Instance, value);
			}
		}
		public string Descr{
			set { 
				StepData_PDescr_SetDescr(Instance, value);
			}
		}
		public StepDataPDescr From{
			set { 
				StepData_PDescr_SetFrom(Instance, value.Instance);
			}
		}
		public bool Optional{
			set { 
				StepData_PDescr_SetOptional(Instance, value);
			}
		}
		public bool Derived{
			set { 
				StepData_PDescr_SetDerived(Instance, value);
			}
		}
		public bool IsSelect{
			get {
				return StepData_PDescr_IsSelect(Instance);
			}
		}
		public bool IsInteger{
			get {
				return StepData_PDescr_IsInteger(Instance);
			}
		}
		public bool IsReal{
			get {
				return StepData_PDescr_IsReal(Instance);
			}
		}
		public bool IsString{
			get {
				return StepData_PDescr_IsString(Instance);
			}
		}
		public bool IsBoolean{
			get {
				return StepData_PDescr_IsBoolean(Instance);
			}
		}
		public bool IsLogical{
			get {
				return StepData_PDescr_IsLogical(Instance);
			}
		}
		public bool IsEnum{
			get {
				return StepData_PDescr_IsEnum(Instance);
			}
		}
		public int EnumMax{
			get {
				return StepData_PDescr_EnumMax(Instance);
			}
		}
		public bool IsEntity{
			get {
				return StepData_PDescr_IsEntity(Instance);
			}
		}
		public StandardType Type{
			set { 
				StepData_PDescr_SetType(Instance, value.Instance);
			}
			get {
				return new StandardType(StepData_PDescr_Type(Instance));
			}
		}
		public string DescrName{
			get {
				return StepData_PDescr_DescrName(Instance);
			}
		}
		public int Arity{
			set { 
				StepData_PDescr_SetArity(Instance, value);
			}
			get {
				return StepData_PDescr_Arity(Instance);
			}
		}
		public StepDataPDescr Simple{
			get {
				return new StepDataPDescr(StepData_PDescr_Simple(Instance));
			}
		}
		public bool IsOptional{
			get {
				return StepData_PDescr_IsOptional(Instance);
			}
		}
		public bool IsDerived{
			get {
				return StepData_PDescr_IsDerived(Instance);
			}
		}
		public bool IsField{
			get {
				return StepData_PDescr_IsField(Instance);
			}
		}
		public string FieldName{
			get {
				return StepData_PDescr_FieldName(Instance);
			}
		}
		public int FieldRank{
			get {
				return StepData_PDescr_FieldRank(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepData_PDescr_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetSelect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_AddMemberE5051D76(IntPtr instance, IntPtr member);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetInteger(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetReal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetString(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetBoolean(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetLogical(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetEnum(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_AddEnumDef9381D4D(IntPtr instance, string enumdef);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_AddArityE8219145(IntPtr instance, int arity);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetField800FADE1(IntPtr instance, string name,int rank);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepData_PDescr_Member9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_PDescr_EnumValue9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_PDescr_EnumTextE8219145(IntPtr instance, int val);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsTypeE2B3EAC1(IntPtr instance, IntPtr atype);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsDescr67A25A8F(IntPtr instance, IntPtr descr);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetName(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_PDescr_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetMemberName(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetDescr(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetFrom(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetOptional(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetDerived(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsSelect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsInteger(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsReal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsString(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsBoolean(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsLogical(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsEnum(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_PDescr_EnumMax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsEntity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetType(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepData_PDescr_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_PDescr_DescrName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_PDescr_SetArity(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_PDescr_Arity(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepData_PDescr_Simple(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsOptional(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsDerived(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_PDescr_IsField(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_PDescr_FieldName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_PDescr_FieldRank(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StepDataPDescr(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepDataPDescr_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepDataPDescr_Dtor(IntPtr instance);
	}
}
