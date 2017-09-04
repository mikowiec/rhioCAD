#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISListOfInteractive : NativeInstancePtr
	{
		public AISListOfInteractive()
 :
			base(AIS_ListOfInteractive_Ctor() )
		{}
			public void Assign(AISListOfInteractive Other)
				{
					AIS_ListOfInteractive_Assign235DE22E(Instance, Other.Instance);
				}
			public void Prepend(AISInteractiveObject I)
				{
					AIS_ListOfInteractive_Prepend5DD8A2CA(Instance, I.Instance);
				}
			public void Prepend(AISInteractiveObject I,AISListIteratorOfListOfInteractive theIt)
				{
					AIS_ListOfInteractive_Prepend3A5B8247(Instance, I.Instance, theIt.Instance);
				}
			public void Prepend(AISListOfInteractive Other)
				{
					AIS_ListOfInteractive_Prepend235DE22E(Instance, Other.Instance);
				}
			public void Append(AISInteractiveObject I)
				{
					AIS_ListOfInteractive_Append5DD8A2CA(Instance, I.Instance);
				}
			public void Append(AISInteractiveObject I,AISListIteratorOfListOfInteractive theIt)
				{
					AIS_ListOfInteractive_Append3A5B8247(Instance, I.Instance, theIt.Instance);
				}
			public void Append(AISListOfInteractive Other)
				{
					AIS_ListOfInteractive_Append235DE22E(Instance, Other.Instance);
				}
			public void RemoveFirst()
				{
					AIS_ListOfInteractive_RemoveFirst(Instance);
				}
			public void Remove(AISListIteratorOfListOfInteractive It)
				{
					AIS_ListOfInteractive_RemoveC3A8FDC6(Instance, It.Instance);
				}
			public void InsertBefore(AISInteractiveObject I,AISListIteratorOfListOfInteractive It)
				{
					AIS_ListOfInteractive_InsertBefore3A5B8247(Instance, I.Instance, It.Instance);
				}
			public void InsertBefore(AISListOfInteractive Other,AISListIteratorOfListOfInteractive It)
				{
					AIS_ListOfInteractive_InsertBeforeED3785BE(Instance, Other.Instance, It.Instance);
				}
			public void InsertAfter(AISInteractiveObject I,AISListIteratorOfListOfInteractive It)
				{
					AIS_ListOfInteractive_InsertAfter3A5B8247(Instance, I.Instance, It.Instance);
				}
			public void InsertAfter(AISListOfInteractive Other,AISListIteratorOfListOfInteractive It)
				{
					AIS_ListOfInteractive_InsertAfterED3785BE(Instance, Other.Instance, It.Instance);
				}
		public int Extent{
			get {
				return AIS_ListOfInteractive_Extent(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return AIS_ListOfInteractive_IsEmpty(Instance);
			}
		}
		public AISInteractiveObject First{
			get {
				return new AISInteractiveObject(AIS_ListOfInteractive_First(Instance));
			}
		}
		public AISInteractiveObject Last{
			get {
				return new AISInteractiveObject(AIS_ListOfInteractive_Last(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListOfInteractive_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Assign235DE22E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Prepend5DD8A2CA(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Prepend3A5B8247(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Prepend235DE22E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Append5DD8A2CA(IntPtr instance, IntPtr I);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Append3A5B8247(IntPtr instance, IntPtr I,IntPtr theIt);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_Append235DE22E(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_RemoveFirst(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_RemoveC3A8FDC6(IntPtr instance, IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_InsertBefore3A5B8247(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_InsertBeforeED3785BE(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_InsertAfter3A5B8247(IntPtr instance, IntPtr I,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_ListOfInteractive_InsertAfterED3785BE(IntPtr instance, IntPtr Other,IntPtr It);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_ListOfInteractive_Extent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_ListOfInteractive_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListOfInteractive_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_ListOfInteractive_Last(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISListOfInteractive(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISListOfInteractive_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISListOfInteractive_Dtor(IntPtr instance);
	}
}
