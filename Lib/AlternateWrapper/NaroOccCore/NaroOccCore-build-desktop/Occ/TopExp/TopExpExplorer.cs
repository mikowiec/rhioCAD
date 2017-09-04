#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.TopExp
{
	public class TopExpExplorer : NativeInstancePtr
	{
		public TopExpExplorer()
 :
			base(TopExp_Explorer_Ctor() )
		{}
		public TopExpExplorer(TopoDSShape S,TopAbsShapeEnum ToFind,TopAbsShapeEnum ToAvoid)
 :
			base(TopExp_Explorer_CtorBEBE8016(S.Instance, (int)ToFind, (int)ToAvoid) )
		{}
			public void Init(TopoDSShape S,TopAbsShapeEnum ToFind,TopAbsShapeEnum ToAvoid)
				{
					TopExp_Explorer_InitBEBE8016(Instance, S.Instance, (int)ToFind, (int)ToAvoid);
				}
			public void Next()
				{
					TopExp_Explorer_Next(Instance);
				}
			public void ReInit()
				{
					TopExp_Explorer_ReInit(Instance);
				}
			public void Clear()
				{
					TopExp_Explorer_Clear(Instance);
				}
		public bool More{
			get {
				return TopExp_Explorer_More(Instance);
			}
		}
		public TopoDSShape Current{
			get {
				return new TopoDSShape(TopExp_Explorer_Current(Instance));
			}
		}
		public int Depth{
			get {
				return TopExp_Explorer_Depth(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopExp_Explorer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopExp_Explorer_CtorBEBE8016(IntPtr S,int ToFind,int ToAvoid);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Explorer_InitBEBE8016(IntPtr instance, IntPtr S,int ToFind,int ToAvoid);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Explorer_Next(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Explorer_ReInit(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void TopExp_Explorer_Clear(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool TopExp_Explorer_More(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr TopExp_Explorer_Current(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int TopExp_Explorer_Depth(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public TopExpExplorer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ TopExpExplorer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void TopExpExplorer_Dtor(IntPtr instance);
	}
}
