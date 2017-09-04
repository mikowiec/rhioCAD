#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BooleanOperations;
using NaroCppCore.Occ.BOPTools;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsPave : NativeInstancePtr
	{
		public BOPToolsPave()
 :
			base(BOPTools_Pave_Ctor() )
		{}
		public BOPToolsPave(int Index,double aParam,BooleanOperationsKindOfInterference aType)
 :
			base(BOPTools_Pave_Ctor62B18AF(Index, aParam, (int)aType) )
		{}
			public bool IsEqual(BOPToolsPave Other)
				{
					return BOPTools_Pave_IsEqual3EED610E(Instance, Other.Instance);
				}
		public double Param{
			set { 
				BOPTools_Pave_SetParam(Instance, value);
			}
			get {
				return BOPTools_Pave_Param(Instance);
			}
		}
		public int Index{
			set { 
				BOPTools_Pave_SetIndex(Instance, value);
			}
			get {
				return BOPTools_Pave_Index(Instance);
			}
		}
		public BooleanOperationsKindOfInterference Type{
			set { 
				BOPTools_Pave_SetType(Instance, (int)value);
			}
			get {
				return (BooleanOperationsKindOfInterference)BOPTools_Pave_Type(Instance);
			}
		}
		public int Interference{
			set { 
				BOPTools_Pave_SetInterference(Instance, value);
			}
			get {
				return BOPTools_Pave_Interference(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_Pave_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_Pave_Ctor62B18AF(int Index,double aParam,int aType);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_Pave_IsEqual3EED610E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Pave_SetParam(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double BOPTools_Pave_Param(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Pave_SetIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Pave_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Pave_SetType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Pave_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Pave_SetInterference(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Pave_Interference(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsPave(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsPave_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsPave_Dtor(IntPtr instance);
	}
}
