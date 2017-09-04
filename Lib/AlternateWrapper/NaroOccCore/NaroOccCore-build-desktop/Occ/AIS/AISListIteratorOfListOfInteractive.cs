#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISListIteratorOfListOfInteractive : NativeInstancePtr
	{
		public AISListIteratorOfListOfInteractive()
 :
			base(AIS_ListIteratorOfListOfInteractive_Ctor() )
		{}
		public AISListIteratorOfListOfInteractive(AISListOfInteractive L)
 :
			base(AIS_ListIteratorOfListOfInteractive_Ctor235DE22E(L.Instance) )
		{}
			public void Initialize(AISListOfInteractive L)
				{
					AIS_ListIteratorOfListOfInteractive_Initialize235DE22E(Instance, L.Instance);
				}
			public void Next()
				{
					AIS_ListIteratorOfListOfInteractive_Next(Instance);
				}
		public bool More{
			get {
				return AIS_ListIteratorOfListOfInteractive_More(Instance);
			}
		}
		public AISInteractiveObject Value{
			get {
				return new AISInteractiveObject(AIS_ListIteratorOfListOfInteractive_Value(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListIteratorOfListOfInteractive_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListIteratorOfListOfInteractive_Ctor235DE22E(IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListIteratorOfListOfInteractive_Initialize235DE22E(IntPtr instance, IntPtr L);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListIteratorOfListOfInteractive_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_ListIteratorOfListOfInteractive_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListIteratorOfListOfInteractive_Value(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISListIteratorOfListOfInteractive(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISListIteratorOfListOfInteractive_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISListIteratorOfListOfInteractive_Dtor(IntPtr instance);
	}
}
