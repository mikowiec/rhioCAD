#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.BOPTools;
using NaroCppCore.Occ.IntTools;

#endregion

namespace NaroCppCore.Occ.BOPTools
{
	public class BOPToolsPaveBlock : NativeInstancePtr
	{
		public BOPToolsPaveBlock()
 :
			base(BOPTools_PaveBlock_Ctor() )
		{}
		public BOPToolsPaveBlock(int anEdge,BOPToolsPave aPave1,BOPToolsPave aPave2)
 :
			base(BOPTools_PaveBlock_Ctor9182DAFF(anEdge, aPave1.Instance, aPave2.Instance) )
		{}
			public bool IsEqual(BOPToolsPaveBlock Other)
				{
					return BOPTools_PaveBlock_IsEqual36FC67E4(Instance, Other.Instance);
				}
			public void Parameters(ref double aT1,ref double aT2)
				{
					BOPTools_PaveBlock_Parameters9F0E714F(Instance, ref aT1, ref aT2);
				}
			public bool IsInBlock(BOPToolsPave aPaveX)
				{
					return BOPTools_PaveBlock_IsInBlock3EED610E(Instance, aPaveX.Instance);
				}
		public int Edge{
			set { 
				BOPTools_PaveBlock_SetEdge(Instance, value);
			}
			get {
				return BOPTools_PaveBlock_Edge(Instance);
			}
		}
		public int OriginalEdge{
			set { 
				BOPTools_PaveBlock_SetOriginalEdge(Instance, value);
			}
			get {
				return BOPTools_PaveBlock_OriginalEdge(Instance);
			}
		}
		public BOPToolsPave Pave1{
			set { 
				BOPTools_PaveBlock_SetPave1(Instance, value.Instance);
			}
			get {
				return new BOPToolsPave(BOPTools_PaveBlock_Pave1(Instance));
			}
		}
		public BOPToolsPave Pave2{
			set { 
				BOPTools_PaveBlock_SetPave2(Instance, value.Instance);
			}
			get {
				return new BOPToolsPave(BOPTools_PaveBlock_Pave2(Instance));
			}
		}
		public bool IsValid{
			get {
				return BOPTools_PaveBlock_IsValid(Instance);
			}
		}
		public IntToolsRange Range{
			get {
				return new IntToolsRange(BOPTools_PaveBlock_Range(Instance));
			}
		}
		public IntToolsShrunkRange ShrunkRange{
			set { 
				BOPTools_PaveBlock_SetShrunkRange(Instance, value.Instance);
			}
			get {
				return new IntToolsShrunkRange(BOPTools_PaveBlock_ShrunkRange(Instance));
			}
		}
		public BOPToolsPointBetween PointBetween{
			set { 
				BOPTools_PaveBlock_SetPointBetween(Instance, value.Instance);
			}
			get {
				return new BOPToolsPointBetween(BOPTools_PaveBlock_PointBetween(Instance));
			}
		}
		public IntToolsCurve Curve{
			set { 
				BOPTools_PaveBlock_SetCurve(Instance, value.Instance);
			}
			get {
				return new IntToolsCurve(BOPTools_PaveBlock_Curve(Instance));
			}
		}
		public int Face1{
			set { 
				BOPTools_PaveBlock_SetFace1(Instance, value);
			}
			get {
				return BOPTools_PaveBlock_Face1(Instance);
			}
		}
		public int Face2{
			set { 
				BOPTools_PaveBlock_SetFace2(Instance, value);
			}
			get {
				return BOPTools_PaveBlock_Face2(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Ctor9182DAFF(int anEdge,IntPtr aPave1,IntPtr aPave2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_PaveBlock_IsEqual36FC67E4(IntPtr instance, IntPtr Other);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_Parameters9F0E714F(IntPtr instance, ref double aT1,ref double aT2);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_PaveBlock_IsInBlock3EED610E(IntPtr instance, IntPtr aPaveX);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetEdge(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_PaveBlock_Edge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetOriginalEdge(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_PaveBlock_OriginalEdge(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetPave1(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Pave1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetPave2(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Pave2(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool BOPTools_PaveBlock_IsValid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Range(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetShrunkRange(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_ShrunkRange(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetPointBetween(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_PointBetween(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetCurve(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr BOPTools_PaveBlock_Curve(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetFace1(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_PaveBlock_Face1(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void BOPTools_PaveBlock_SetFace2(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int BOPTools_PaveBlock_Face2(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public BOPToolsPaveBlock(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ BOPToolsPaveBlock_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void BOPToolsPaveBlock_Dtor(IntPtr instance);
	}
}
