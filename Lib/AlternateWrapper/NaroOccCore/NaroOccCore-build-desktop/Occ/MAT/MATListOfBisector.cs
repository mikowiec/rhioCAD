#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.MAT;

#endregion

namespace NaroCppCore.Occ.MAT
{
	public class MATListOfBisector : MMgtTShared
	{
		public MATListOfBisector()
 :
			base(MAT_ListOfBisector_Ctor() )
		{}
			public void First()
				{
					MAT_ListOfBisector_First(Instance);
				}
			public void Last()
				{
					MAT_ListOfBisector_Last(Instance);
				}
			public void Init(MATBisector aniten)
				{
					MAT_ListOfBisector_Init1F24E859(Instance, aniten.Instance);
				}
			public void Next()
				{
					MAT_ListOfBisector_Next(Instance);
				}
			public void Previous()
				{
					MAT_ListOfBisector_Previous(Instance);
				}
			public MATBisector Current()
				{
					return new MATBisector(MAT_ListOfBisector_Current(Instance));
				}
			public void Current(MATBisector anitem)
				{
					MAT_ListOfBisector_Current1F24E859(Instance, anitem.Instance);
				}
			public MATBisector Brackets(int anindex)
				{
					return new MATBisector(MAT_ListOfBisector_BracketsE8219145(Instance, anindex));
				}
			public void Unlink()
				{
					MAT_ListOfBisector_Unlink(Instance);
				}
			public void LinkBefore(MATBisector anitem)
				{
					MAT_ListOfBisector_LinkBefore1F24E859(Instance, anitem.Instance);
				}
			public void LinkAfter(MATBisector anitem)
				{
					MAT_ListOfBisector_LinkAfter1F24E859(Instance, anitem.Instance);
				}
			public void FrontAdd(MATBisector anitem)
				{
					MAT_ListOfBisector_FrontAdd1F24E859(Instance, anitem.Instance);
				}
			public void BackAdd(MATBisector anitem)
				{
					MAT_ListOfBisector_BackAdd1F24E859(Instance, anitem.Instance);
				}
			public void Permute()
				{
					MAT_ListOfBisector_Permute(Instance);
				}
			public void Loop()
				{
					MAT_ListOfBisector_Loop(Instance);
				}
			public void Dump(int ashift,int alevel)
				{
					MAT_ListOfBisector_Dump5107F6FE(Instance, ashift, alevel);
				}
		public bool More{
			get {
				return MAT_ListOfBisector_More(Instance);
			}
		}
		public MATBisector FirstItem{
			get {
				return new MATBisector(MAT_ListOfBisector_FirstItem(Instance));
			}
		}
		public MATBisector LastItem{
			get {
				return new MATBisector(MAT_ListOfBisector_LastItem(Instance));
			}
		}
		public MATBisector PreviousItem{
			get {
				return new MATBisector(MAT_ListOfBisector_PreviousItem(Instance));
			}
		}
		public MATBisector NextItem{
			get {
				return new MATBisector(MAT_ListOfBisector_NextItem(Instance));
			}
		}
		public int Number{
			get {
				return MAT_ListOfBisector_Number(Instance);
			}
		}
		public int Index{
			get {
				return MAT_ListOfBisector_Index(Instance);
			}
		}
		public bool IsEmpty{
			get {
				return MAT_ListOfBisector_IsEmpty(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_First(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Last(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Init1F24E859(IntPtr instance, IntPtr aniten);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Previous(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_Current(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Current1F24E859(IntPtr instance, IntPtr anitem);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_BracketsE8219145(IntPtr instance, int anindex);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Unlink(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_LinkBefore1F24E859(IntPtr instance, IntPtr anitem);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_LinkAfter1F24E859(IntPtr instance, IntPtr anitem);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_FrontAdd1F24E859(IntPtr instance, IntPtr anitem);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_BackAdd1F24E859(IntPtr instance, IntPtr anitem);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Permute(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Loop(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void MAT_ListOfBisector_Dump5107F6FE(IntPtr instance, int ashift,int alevel);
		[DllImport("NaroOccCore.dll")]
		private static extern bool MAT_ListOfBisector_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_FirstItem(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_LastItem(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_PreviousItem(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr MAT_ListOfBisector_NextItem(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_ListOfBisector_Number(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int MAT_ListOfBisector_Index(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool MAT_ListOfBisector_IsEmpty(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MATListOfBisector(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MATListOfBisector_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MATListOfBisector_Dtor(IntPtr instance);
	}
}
