#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.Aspect
{
	public class AspectEdge : NativeInstancePtr
	{
		public AspectEdge()
 :
			base(Aspect_Edge_Ctor() )
		{}
		public AspectEdge(int AIndex1,int AIndex2,AspectTypeOfEdge AType)
 :
			base(Aspect_Edge_Ctor7A0E4278(AIndex1, AIndex2, (int)AType) )
		{}
		public int FirstIndex{
			get {
				return Aspect_Edge_FirstIndex(Instance);
			}
		}
		public int LastIndex{
			get {
				return Aspect_Edge_LastIndex(Instance);
			}
		}
		public AspectTypeOfEdge Type{
			get {
				return (AspectTypeOfEdge)Aspect_Edge_Type(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Edge_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Aspect_Edge_Ctor7A0E4278(int AIndex1,int AIndex2,int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_Edge_FirstIndex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_Edge_LastIndex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Aspect_Edge_Type(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AspectEdge(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AspectEdge_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AspectEdge_Dtor(IntPtr instance);
	}
}
