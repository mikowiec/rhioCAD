#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TopoDS;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.DsgPrs;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISDiameterDimension : AISRelation
	{
		public AISDiameterDimension(TopoDSShape aShape,double aVal,TCollectionExtendedString aText)
 :
			base(AIS_DiameterDimension_Ctor1C945158(aShape.Instance, aVal, aText.Instance) )
		{}
		public AISDiameterDimension(TopoDSShape aShape,double aVal,TCollectionExtendedString aText,gpPnt aPosition,DsgPrsArrowSide aSymbolPrs,bool aDiamSymbol,double anArrowSize)
 :
			base(AIS_DiameterDimension_Ctor54910EE4(aShape.Instance, aVal, aText.Instance, aPosition.Instance, (int)aSymbolPrs, aDiamSymbol, anArrowSize) )
		{}
		public AISKindOfDimension KindOfDimension{
			get {
				return (AISKindOfDimension)AIS_DiameterDimension_KindOfDimension(Instance);
			}
		}
		public bool IsMovable{
			get {
				return AIS_DiameterDimension_IsMovable(Instance);
			}
		}
		public bool DiamSymbol{
			set { 
				AIS_DiameterDimension_SetDiamSymbol(Instance, value);
			}
			get {
				return AIS_DiameterDimension_DiamSymbol(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_DiameterDimension_Ctor1C945158(IntPtr aShape,double aVal,IntPtr aText);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_DiameterDimension_Ctor54910EE4(IntPtr aShape,double aVal,IntPtr aText,IntPtr aPosition,int aSymbolPrs,bool aDiamSymbol,double anArrowSize);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_DiameterDimension_KindOfDimension(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_DiameterDimension_IsMovable(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_DiameterDimension_SetDiamSymbol(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_DiameterDimension_DiamSymbol(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISDiameterDimension() { } 

		public AISDiameterDimension(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISDiameterDimension_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISDiameterDimension_Dtor(IntPtr instance);
	}
}
