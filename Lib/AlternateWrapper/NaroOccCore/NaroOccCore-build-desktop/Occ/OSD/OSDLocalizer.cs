#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;

#endregion

namespace NaroCppCore.Occ.OSD
{
	public class OSDLocalizer : NativeInstancePtr
	{
		public OSDLocalizer(int Category,string Locale)
 :
			base(OSD_Localizer_CtorC9F1A165(Category, Locale) )
		{}
			public void Restore()
				{
					OSD_Localizer_Restore(Instance);
				}
			public void SetLocale(int Category,string Locale)
				{
					OSD_Localizer_SetLocaleC9F1A165(Instance, Category, Locale);
				}
			public string Locale()
				{
					return OSD_Localizer_Locale(Instance);
				}
		public int Category{
			get {
				return OSD_Localizer_Category(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr OSD_Localizer_CtorC9F1A165(int Category,string Locale);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Localizer_Restore(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void OSD_Localizer_SetLocaleC9F1A165(IntPtr instance, int Category,string Locale);
		[DllImport("NaroOccCore.dll")]
		private static extern string OSD_Localizer_Locale(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int OSD_Localizer_Category(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public OSDLocalizer() { } 

		public OSDLocalizer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ OSDLocalizer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void OSDLocalizer_Dtor(IntPtr instance);
	}
}
