#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.SelectBasics;

#endregion

namespace NaroCppCore.Occ.SelectBasics
{
	public class SelectBasicsSensitiveEntity : MMgtTShared
	{
			public void Set(SelectBasicsEntityOwner TheOwnerId)
				{
					SelectBasics_SensitiveEntity_SetB2ADB135(Instance, TheOwnerId.Instance);
				}
		public SelectBasicsEntityOwner OwnerId{
			get {
				return new SelectBasicsEntityOwner(SelectBasics_SensitiveEntity_OwnerId(Instance));
			}
		}
		public double Depth{
			get {
				return SelectBasics_SensitiveEntity_Depth(Instance);
			}
		}
		public double SensitivityFactor{
			set { 
				SelectBasics_SensitiveEntity_SetSensitivityFactor(Instance, value);
			}
			get {
				return SelectBasics_SensitiveEntity_SensitivityFactor(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectBasics_SensitiveEntity_SetB2ADB135(IntPtr instance, IntPtr TheOwnerId);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr SelectBasics_SensitiveEntity_OwnerId(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double SelectBasics_SensitiveEntity_Depth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void SelectBasics_SensitiveEntity_SetSensitivityFactor(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double SelectBasics_SensitiveEntity_SensitivityFactor(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public SelectBasicsSensitiveEntity() { } 

		public SelectBasicsSensitiveEntity(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ SelectBasicsSensitiveEntity_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void SelectBasicsSensitiveEntity_Dtor(IntPtr instance);
	}
}
