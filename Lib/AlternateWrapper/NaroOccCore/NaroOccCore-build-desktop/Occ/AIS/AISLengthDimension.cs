#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.DsgPrs;
using NaroCppCore.Occ.Geom;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISLengthDimension : AISRelation
	{
		public AISLengthDimension(TopoDSFace aFirstFace,TopoDSFace aSecondFace,double aVal,TCollectionExtendedString aText)
 :
			base(AIS_LengthDimension_CtorE30AADB(aFirstFace.Instance, aSecondFace.Instance, aVal, aText.Instance) )
		{}
		public AISLengthDimension(TopoDSFace aFirstFace,TopoDSFace aSecondFace,double aVal,TCollectionExtendedString aText,gpPnt aPosition,DsgPrsArrowSide aSymbolPrs,double anArrowSize)
 :
			base(AIS_LengthDimension_Ctor5485084F(aFirstFace.Instance, aSecondFace.Instance, aVal, aText.Instance, aPosition.Instance, (int)aSymbolPrs, anArrowSize) )
		{}
		public AISLengthDimension(TopoDSFace Face,TopoDSEdge Edge,double Val,TCollectionExtendedString Text)
 :
			base(AIS_LengthDimension_CtorC2ADA788(Face.Instance, Edge.Instance, Val, Text.Instance) )
		{}
		public AISLengthDimension(TopoDSShape aFShape,TopoDSShape aSShape,GeomPlane aPlane,double aVal,TCollectionExtendedString aText)
 :
			base(AIS_LengthDimension_CtorFBAAB8FA(aFShape.Instance, aSShape.Instance, aPlane.Instance, aVal, aText.Instance) )
		{}
		public AISLengthDimension(TopoDSShape aFShape,TopoDSShape aSShape,GeomPlane aPlane,double aVal,TCollectionExtendedString aText,gpPnt aPosition,DsgPrsArrowSide aSymbolPrs,AISTypeOfDist aTypeDist,double anArrowSize)
 :
			base(AIS_LengthDimension_CtorEA089509(aFShape.Instance, aSShape.Instance, aPlane.Instance, aVal, aText.Instance, aPosition.Instance, (int)aSymbolPrs, (int)aTypeDist, anArrowSize) )
		{}
		public TopoDSShape FirstShape{
			set { 
				AIS_LengthDimension_SetFirstShape(Instance, value.Instance);
			}
		}
		public TopoDSShape SecondShape{
			set { 
				AIS_LengthDimension_SetSecondShape(Instance, value.Instance);
			}
		}
		public AISKindOfDimension KindOfDimension{
			get {
				return (AISKindOfDimension)AIS_LengthDimension_KindOfDimension(Instance);
			}
		}
		public bool IsMovable{
			get {
				return AIS_LengthDimension_IsMovable(Instance);
			}
		}
		public AISTypeOfDist TypeOfDist{
			set { 
				AIS_LengthDimension_SetTypeOfDist(Instance, (int)value);
			}
			get {
				return (AISTypeOfDist)AIS_LengthDimension_TypeOfDist(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_LengthDimension_CtorE30AADB(IntPtr aFirstFace,IntPtr aSecondFace,double aVal,IntPtr aText);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_LengthDimension_Ctor5485084F(IntPtr aFirstFace,IntPtr aSecondFace,double aVal,IntPtr aText,IntPtr aPosition,int aSymbolPrs,double anArrowSize);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_LengthDimension_CtorC2ADA788(IntPtr Face,IntPtr Edge,double Val,IntPtr Text);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_LengthDimension_CtorFBAAB8FA(IntPtr aFShape,IntPtr aSShape,IntPtr aPlane,double aVal,IntPtr aText);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_LengthDimension_CtorEA089509(IntPtr aFShape,IntPtr aSShape,IntPtr aPlane,double aVal,IntPtr aText,IntPtr aPosition,int aSymbolPrs,int aTypeDist,double anArrowSize);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_LengthDimension_SetFirstShape(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_LengthDimension_SetSecondShape(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_LengthDimension_KindOfDimension(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_LengthDimension_IsMovable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_LengthDimension_SetTypeOfDist(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_LengthDimension_TypeOfDist(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISLengthDimension() { } 

		public AISLengthDimension(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISLengthDimension_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISLengthDimension_Dtor(IntPtr instance);
	}
}
