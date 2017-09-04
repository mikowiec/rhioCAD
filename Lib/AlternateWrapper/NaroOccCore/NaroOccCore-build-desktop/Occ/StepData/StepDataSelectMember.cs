#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Interface;
using NaroCppCore.Occ.StepData;

#endregion

namespace NaroCppCore.Occ.StepData
{
	public class StepDataSelectMember : MMgtTShared
	{
		public StepDataSelectMember()
 :
			base(StepData_SelectMember_Ctor() )
		{}
			public string Name()
				{
					return StepData_SelectMember_Name(Instance);
				}
			public bool SetName(string name)
				{
					return StepData_SelectMember_SetName9381D4D(Instance, name);
				}
			public bool Matches(string name)
				{
					return StepData_SelectMember_Matches9381D4D(Instance, name);
				}
			public int Enum()
				{
					return StepData_SelectMember_Enum(Instance);
				}
			public string EnumText()
				{
					return StepData_SelectMember_EnumText(Instance);
				}
			public void SetEnum(int val,string text)
				{
					StepData_SelectMember_SetEnumC9F1A165(Instance, val, text);
				}
			public void SetEnumText(int val,string text)
				{
					StepData_SelectMember_SetEnumTextC9F1A165(Instance, val, text);
				}
		public bool HasName{
			get {
				return StepData_SelectMember_HasName(Instance);
			}
		}
		public int Kind{
			set { 
				StepData_SelectMember_SetKind(Instance, value);
			}
			get {
				return StepData_SelectMember_Kind(Instance);
			}
		}
		public InterfaceParamType ParamType{
			get {
				return (InterfaceParamType)StepData_SelectMember_ParamType(Instance);
			}
		}
		public int Int{
			set { 
				StepData_SelectMember_SetInt(Instance, value);
			}
			get {
				return StepData_SelectMember_Int(Instance);
			}
		}
		public int Integer{
			set { 
				StepData_SelectMember_SetInteger(Instance, value);
			}
			get {
				return StepData_SelectMember_Integer(Instance);
			}
		}
		public bool Boolean{
			set { 
				StepData_SelectMember_SetBoolean(Instance, value);
			}
			get {
				return StepData_SelectMember_Boolean(Instance);
			}
		}
		public StepDataLogical Logical{
			set { 
				StepData_SelectMember_SetLogical(Instance, (int)value);
			}
			get {
				return (StepDataLogical)StepData_SelectMember_Logical(Instance);
			}
		}
		public double Real{
			set { 
				StepData_SelectMember_SetReal(Instance, value);
			}
			get {
				return StepData_SelectMember_Real(Instance);
			}
		}
		public string String{
			set { 
				StepData_SelectMember_SetString(Instance, value);
			}
			get {
				return StepData_SelectMember_String(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr StepData_SelectMember_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_SelectMember_Name(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_SelectMember_SetName9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_SelectMember_Matches9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_Enum(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_SelectMember_EnumText(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetEnumC9F1A165(IntPtr instance, int val,string text);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetEnumTextC9F1A165(IntPtr instance, int val,string text);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_SelectMember_HasName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetKind(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_Kind(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_ParamType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetInt(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_Int(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetInteger(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_Integer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetBoolean(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool StepData_SelectMember_Boolean(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetLogical(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int StepData_SelectMember_Logical(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetReal(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double StepData_SelectMember_Real(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void StepData_SelectMember_SetString(IntPtr instance, string value);
		[DllImport("NaroOccCore.dll")]
		private static extern string StepData_SelectMember_String(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StepDataSelectMember(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StepDataSelectMember_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StepDataSelectMember_Dtor(IntPtr instance);
	}
}
