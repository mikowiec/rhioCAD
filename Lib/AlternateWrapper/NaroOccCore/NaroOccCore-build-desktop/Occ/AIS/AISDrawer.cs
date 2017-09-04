#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Prs3d;
using NaroCppCore.Occ.Aspect;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISDrawer : Prs3dDrawer
	{
		public AISDrawer()
 :
			base(AIS_Drawer_Ctor() )
		{}
			public void SetDeviationCoefficient()
				{
					AIS_Drawer_SetDeviationCoefficient(Instance);
				}
			public void SetHLRDeviationCoefficient()
				{
					AIS_Drawer_SetHLRDeviationCoefficient(Instance);
				}
			public void SetDeviationAngle()
				{
					AIS_Drawer_SetDeviationAngle(Instance);
				}
			public void SetHLRAngle()
				{
					AIS_Drawer_SetHLRAngle(Instance);
				}
			public void SetDeviationCoefficient(double aCoefficient)
				{
					AIS_Drawer_SetDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public void SetHLRDeviationCoefficient(double aCoefficient)
				{
					AIS_Drawer_SetHLRDeviationCoefficientD82819F3(Instance, aCoefficient);
				}
			public void SetDeviationAngle(double anAngle)
				{
					AIS_Drawer_SetDeviationAngleD82819F3(Instance, anAngle);
				}
			public void SetHLRAngle(double anAngle)
				{
					AIS_Drawer_SetHLRAngleD82819F3(Instance, anAngle);
				}
			public double DeviationCoefficient()
				{
					return AIS_Drawer_DeviationCoefficient(Instance);
				}
			public double HLRDeviationCoefficient()
				{
					return AIS_Drawer_HLRDeviationCoefficient(Instance);
				}
			public double DeviationAngle()
				{
					return AIS_Drawer_DeviationAngle(Instance);
				}
			public double HLRAngle()
				{
					return AIS_Drawer_HLRAngle(Instance);
				}
			public void ClearLocalAttributes()
				{
					AIS_Drawer_ClearLocalAttributes(Instance);
				}
		public AspectTypeOfDeflection TypeOfDeflection{
			get {
				return (AspectTypeOfDeflection)AIS_Drawer_TypeOfDeflection(Instance);
			}
		}
		public double MaximalChordialDeviation{
			get {
				return AIS_Drawer_MaximalChordialDeviation(Instance);
			}
		}
		public double PreviousDeviationCoefficient{
			get {
				return AIS_Drawer_PreviousDeviationCoefficient(Instance);
			}
		}
		public double PreviousHLRDeviationCoefficient{
			get {
				return AIS_Drawer_PreviousHLRDeviationCoefficient(Instance);
			}
		}
		public double PreviousDeviationAngle{
			get {
				return AIS_Drawer_PreviousDeviationAngle(Instance);
			}
		}
		public double PreviousHLRDeviationAngle{
			get {
				return AIS_Drawer_PreviousHLRDeviationAngle(Instance);
			}
		}
		public bool IsOwnDeviationCoefficient{
			get {
				return AIS_Drawer_IsOwnDeviationCoefficient(Instance);
			}
		}
		public bool IsOwnHLRDeviationCoefficient{
			get {
				return AIS_Drawer_IsOwnHLRDeviationCoefficient(Instance);
			}
		}
		public bool IsOwnDeviationAngle{
			get {
				return AIS_Drawer_IsOwnDeviationAngle(Instance);
			}
		}
		public bool IsOwnHLRDeviationAngle{
			get {
				return AIS_Drawer_IsOwnHLRDeviationAngle(Instance);
			}
		}
		public int Discretisation{
			get {
				return AIS_Drawer_Discretisation(Instance);
			}
		}
		public double MaximalParameterValue{
			get {
				return AIS_Drawer_MaximalParameterValue(Instance);
			}
		}
		public bool IsoOnPlane{
			get {
				return AIS_Drawer_IsoOnPlane(Instance);
			}
		}
		public Prs3dLineAspect FreeBoundaryAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_FreeBoundaryAspect(Instance));
			}
		}
		public bool FreeBoundaryDraw{
			get {
				return AIS_Drawer_FreeBoundaryDraw(Instance);
			}
		}
		public Prs3dLineAspect WireAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_WireAspect(Instance));
			}
		}
		public bool HasLineAspect{
			get {
				return AIS_Drawer_HasLineAspect(Instance);
			}
		}
		public bool HasWireAspect{
			get {
				return AIS_Drawer_HasWireAspect(Instance);
			}
		}
		public bool WireDraw{
			get {
				return AIS_Drawer_WireDraw(Instance);
			}
		}
		public Prs3dLineAspect UnFreeBoundaryAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_UnFreeBoundaryAspect(Instance));
			}
		}
		public bool UnFreeBoundaryDraw{
			get {
				return AIS_Drawer_UnFreeBoundaryDraw(Instance);
			}
		}
		public bool HasTextAspect{
			get {
				return AIS_Drawer_HasTextAspect(Instance);
			}
		}
		public Prs3dTextAspect TextAspect{
			get {
				return new Prs3dTextAspect(AIS_Drawer_TextAspect(Instance));
			}
		}
		public bool LineArrowDraw{
			get {
				return AIS_Drawer_LineArrowDraw(Instance);
			}
		}
		public Prs3dPointAspect PointAspect{
			get {
				return new Prs3dPointAspect(AIS_Drawer_PointAspect(Instance));
			}
		}
		public bool HasPointAspect{
			get {
				return AIS_Drawer_HasPointAspect(Instance);
			}
		}
		public Prs3dShadingAspect ShadingAspect{
			get {
				return new Prs3dShadingAspect(AIS_Drawer_ShadingAspect(Instance));
			}
		}
		public bool HasShadingAspect{
			get {
				return AIS_Drawer_HasShadingAspect(Instance);
			}
		}
		public bool ShadingAspectGlobal{
			get {
				return AIS_Drawer_ShadingAspectGlobal(Instance);
			}
		}
		public bool DrawHiddenLine{
			get {
				return AIS_Drawer_DrawHiddenLine(Instance);
			}
		}
		public Prs3dLineAspect HiddenLineAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_HiddenLineAspect(Instance));
			}
		}
		public Prs3dLineAspect SeenLineAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_SeenLineAspect(Instance));
			}
		}
		public bool HasPlaneAspect{
			get {
				return AIS_Drawer_HasPlaneAspect(Instance);
			}
		}
		public Prs3dLineAspect VectorAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_VectorAspect(Instance));
			}
		}
		public bool FaceBoundaryDraw{
			set { 
				AIS_Drawer_SetFaceBoundaryDraw(Instance, value);
			}
		}
		public bool IsFaceBoundaryDraw{
			get {
				return AIS_Drawer_IsFaceBoundaryDraw(Instance);
			}
		}
		public Prs3dLineAspect FaceBoundaryAspect{
			set { 
				AIS_Drawer_SetFaceBoundaryAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(AIS_Drawer_FaceBoundaryAspect(Instance));
			}
		}
		public bool IsOwnFaceBoundaryDraw{
			get {
				return AIS_Drawer_IsOwnFaceBoundaryDraw(Instance);
			}
		}
		public bool IsOwnFaceBoundaryAspect{
			get {
				return AIS_Drawer_IsOwnFaceBoundaryAspect(Instance);
			}
		}
		public bool HasDatumAspect{
			get {
				return AIS_Drawer_HasDatumAspect(Instance);
			}
		}
		public Prs3dDatumAspect DatumAspect{
			get {
				return new Prs3dDatumAspect(AIS_Drawer_DatumAspect(Instance));
			}
		}
		public bool HasLengthAspect{
			get {
				return AIS_Drawer_HasLengthAspect(Instance);
			}
		}
		public bool HasAngleAspect{
			get {
				return AIS_Drawer_HasAngleAspect(Instance);
			}
		}
		public Prs3dLineAspect SectionAspect{
			get {
				return new Prs3dLineAspect(AIS_Drawer_SectionAspect(Instance));
			}
		}
		public bool HasLink{
			get {
				return AIS_Drawer_HasLink(Instance);
			}
		}
		public bool WasLastLocal{
			get {
				return AIS_Drawer_WasLastLocal(Instance);
			}
		}
		public bool HasLocalAttributes{
			get {
				return AIS_Drawer_HasLocalAttributes(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetHLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetHLRAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetHLRDeviationCoefficientD82819F3(IntPtr instance, double aCoefficient);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetDeviationAngleD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetHLRAngleD82819F3(IntPtr instance, double anAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_DeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_HLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_DeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_HLRAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_ClearLocalAttributes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Drawer_TypeOfDeflection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_MaximalChordialDeviation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_PreviousDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_PreviousHLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_PreviousDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_PreviousHLRDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnHLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnHLRDeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_Drawer_Discretisation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_Drawer_MaximalParameterValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsoOnPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_FreeBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_FreeBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_WireAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasWireAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_WireDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_UnFreeBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_UnFreeBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasTextAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_TextAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_LineArrowDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_PointAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasPointAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_ShadingAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasShadingAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_ShadingAspectGlobal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_DrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_HiddenLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_SeenLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasPlaneAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_VectorAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetFaceBoundaryDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsFaceBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_Drawer_SetFaceBoundaryAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_FaceBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnFaceBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_IsOwnFaceBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasDatumAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_DatumAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasLengthAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasAngleAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_Drawer_SectionAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasLink(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_WasLastLocal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_Drawer_HasLocalAttributes(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISDrawer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISDrawer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISDrawer_Dtor(IntPtr instance);
	}
}
