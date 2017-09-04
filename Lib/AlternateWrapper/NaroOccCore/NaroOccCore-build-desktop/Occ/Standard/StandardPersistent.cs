#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Standard;

#endregion

namespace NaroCppCore.Occ.Standard
{
	public class StandardPersistent : NativeInstancePtr
	{
			public void Delete()
				{
					Standard_Persistent_Delete(Instance);
				}
			public bool IsInstance(StandardType TheType)
				{
					return Standard_Persistent_IsInstanceE2B3EAC1(Instance, TheType.Instance);
				}
			public bool IsKind(StandardType TheType)
				{
					return Standard_Persistent_IsKindE2B3EAC1(Instance, TheType.Instance);
				}
		public StandardType DynamicType{
			get {
				return new StandardType(Standard_Persistent_DynamicType(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Standard_Persistent_Delete(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Persistent_IsInstanceE2B3EAC1(IntPtr instance, IntPtr TheType);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Standard_Persistent_IsKindE2B3EAC1(IntPtr instance, IntPtr TheType);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Standard_Persistent_DynamicType(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public StandardPersistent() { } 

		public StandardPersistent(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ StandardPersistent_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void StandardPersistent_Dtor(IntPtr instance);
	}
}
