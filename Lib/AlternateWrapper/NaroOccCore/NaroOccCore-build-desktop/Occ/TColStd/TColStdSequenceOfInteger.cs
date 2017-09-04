#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TColStd;

#endregion

namespace NaroCppCore.Occ.TColStd
{
	public class TColStdSequenceOfInteger : TCollectionBaseSequence
	{
		public TColStdSequenceOfInteger()
 :
			base(TColStd_SequenceOfInteger_Ctor() )
		{}
			public TColStdSequenceOfInteger Assign(TColStdSequenceOfInteger Other)
				{
					return new TColStdSequenceOfInteger(TColStd_SequenceOfInteger_AssignE22FA26(Instance, Other.Instance));
				}
			public void Append(int T)
				{
					TColStd_SequenceOfInteger_AppendE8219145(Instance, T);
				}
			public void Append(TColStdSequenceOfInteger S)
				{
					TColStd_SequenceOfInteger_AppendE22FA26(Instance, S.Instance);
				}
			public void Prepend(int T)
				{
					TColStd_SequenceOfInteger_PrependE8219145(Instance, T);
				}
			public void Prepend(TColStdSequenceOfInteger S)
				{
					TColStd_SequenceOfInteger_PrependE22FA26(Instance, S.Instance);
				}
			public void InsertBefore(int Index,int T)
				{
					TColStd_SequenceOfInteger_InsertBefore5107F6FE(Instance, Index, T);
				}
			public void InsertBefore(int Index,TColStdSequenceOfInteger S)
				{
					TColStd_SequenceOfInteger_InsertBefore20E7A93A(Instance, Index, S.Instance);
				}
			public void InsertAfter(int Index,int T)
				{
					TColStd_SequenceOfInteger_InsertAfter5107F6FE(Instance, Index, T);
				}
			public void InsertAfter(int Index,TColStdSequenceOfInteger S)
				{
					TColStd_SequenceOfInteger_InsertAfter20E7A93A(Instance, Index, S.Instance);
				}
			public void Split(int Index,TColStdSequenceOfInteger Sub)
				{
					TColStd_SequenceOfInteger_Split20E7A93A(Instance, Index, Sub.Instance);
				}
			public int Value(int Index)
				{
					return TColStd_SequenceOfInteger_ValueE8219145(Instance, Index);
				}
			public void SetValue(int Index,int I)
				{
					TColStd_SequenceOfInteger_SetValue5107F6FE(Instance, Index, I);
				}
			public int ChangeValue(int Index)
				{
					return TColStd_SequenceOfInteger_ChangeValueE8219145(Instance, Index);
				}
			public void Remove(int Index)
				{
					TColStd_SequenceOfInteger_RemoveE8219145(Instance, Index);
				}
			public void Remove(int FromIndex,int ToIndex)
				{
					TColStd_SequenceOfInteger_Remove5107F6FE(Instance, FromIndex, ToIndex);
				}
		public int First{
			get {
				return TColStd_SequenceOfInteger_First(Instance);
			}
		}
		public int Last{
			get {
				return TColStd_SequenceOfInteger_Last(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColStd_SequenceOfInteger_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TColStd_SequenceOfInteger_AssignE22FA26(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_AppendE8219145(IntPtr instance, int T);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_AppendE22FA26(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_PrependE8219145(IntPtr instance, int T);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_PrependE22FA26(IntPtr instance, IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_InsertBefore5107F6FE(IntPtr instance, int Index,int T);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_InsertBefore20E7A93A(IntPtr instance, int Index,IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_InsertAfter5107F6FE(IntPtr instance, int Index,int T);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_InsertAfter20E7A93A(IntPtr instance, int Index,IntPtr S);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_Split20E7A93A(IntPtr instance, int Index,IntPtr Sub);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColStd_SequenceOfInteger_ValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_SetValue5107F6FE(IntPtr instance, int Index,int I);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColStd_SequenceOfInteger_ChangeValueE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_RemoveE8219145(IntPtr instance, int Index);
		[DllImport("NaroOccCore.dll")]
		private static extern void TColStd_SequenceOfInteger_Remove5107F6FE(IntPtr instance, int FromIndex,int ToIndex);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColStd_SequenceOfInteger_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TColStd_SequenceOfInteger_Last(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TColStdSequenceOfInteger(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TColStdSequenceOfInteger_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TColStdSequenceOfInteger_Dtor(IntPtr instance);
	}
}
