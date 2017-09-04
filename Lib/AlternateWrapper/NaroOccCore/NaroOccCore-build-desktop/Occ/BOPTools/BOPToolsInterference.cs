#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BooleanOperations;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsInterference : NativeInstancePtr
	{
		public BOPToolsInterference()
 :
			base(BOPTools_Interference_Ctor() )
		{}
		public BOPToolsInterference(int aWith,BooleanOperationsKindOfInterference aType,int anIndex)
 :
			base(BOPTools_Interference_CtorF7A1D3E9(aWith, (int)aType, anIndex) )
		{}
		public int With{
			set { 
				BOPTools_Interference_SetWith(Instance, value);
			}
			get {
				return BOPTools_Interference_With(Instance);
			}
		}
		public BooleanOperationsKindOfInterference Type{
			set { 
				BOPTools_Interference_SetType(Instance, (int)value);
			}
			get {
				return (BooleanOperationsKindOfInterference)BOPTools_Interference_Type(Instance);
			}
		}
		public int Index{
			set { 
				BOPTools_Interference_SetIndex(Instance, value);
			}
			get {
				return BOPTools_Interference_Index(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_Interference_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_Interference_CtorF7A1D3E9(int aWith,int aType,int anIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Interference_SetWith(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Interference_With(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Interference_SetType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Interference_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_Interference_SetIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_Interference_Index(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsInterference(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsInterference_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsInterference_Dtor(IntPtr instance);
	}
}
