#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Prs3d;

#endregion

namespace NaroCppCore.Occ.Prs3d
{
	public class Prs3dDrawer : MMgtTShared
	{
		public Prs3dDrawer()
 :
			base(Prs3d_Drawer_Ctor() )
		{}
			public void EnableDrawHiddenLine()
				{
					Prs3d_Drawer_EnableDrawHiddenLine(Instance);
				}
			public void DisableDrawHiddenLine()
				{
					Prs3d_Drawer_DisableDrawHiddenLine(Instance);
				}
		public AspectTypeOfDeflection TypeOfDeflection{
			set { 
				Prs3d_Drawer_SetTypeOfDeflection(Instance, (int)value);
			}
			get {
				return (AspectTypeOfDeflection)Prs3d_Drawer_TypeOfDeflection(Instance);
			}
		}
		public double MaximalChordialDeviation{
			set { 
				Prs3d_Drawer_SetMaximalChordialDeviation(Instance, value);
			}
			get {
				return Prs3d_Drawer_MaximalChordialDeviation(Instance);
			}
		}
		public double DeviationCoefficient{
			set { 
				Prs3d_Drawer_SetDeviationCoefficient(Instance, value);
			}
			get {
				return Prs3d_Drawer_DeviationCoefficient(Instance);
			}
		}
		public double HLRDeviationCoefficient{
			set { 
				Prs3d_Drawer_SetHLRDeviationCoefficient(Instance, value);
			}
			get {
				return Prs3d_Drawer_HLRDeviationCoefficient(Instance);
			}
		}
		public double HLRAngle{
			set { 
				Prs3d_Drawer_SetHLRAngle(Instance, value);
			}
			get {
				return Prs3d_Drawer_HLRAngle(Instance);
			}
		}
		public double DeviationAngle{
			set { 
				Prs3d_Drawer_SetDeviationAngle(Instance, value);
			}
			get {
				return Prs3d_Drawer_DeviationAngle(Instance);
			}
		}
		public int Discretisation{
			set { 
				Prs3d_Drawer_SetDiscretisation(Instance, value);
			}
			get {
				return Prs3d_Drawer_Discretisation(Instance);
			}
		}
		public double MaximalParameterValue{
			set { 
				Prs3d_Drawer_SetMaximalParameterValue(Instance, value);
			}
			get {
				return Prs3d_Drawer_MaximalParameterValue(Instance);
			}
		}
		public bool IsoOnPlane{
			set { 
				Prs3d_Drawer_SetIsoOnPlane(Instance, value);
			}
			get {
				return Prs3d_Drawer_IsoOnPlane(Instance);
			}
		}
		public Prs3dIsoAspect UIsoAspect{
			set { 
				Prs3d_Drawer_SetUIsoAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dIsoAspect(Prs3d_Drawer_UIsoAspect(Instance));
			}
		}
		public Prs3dIsoAspect VIsoAspect{
			set { 
				Prs3d_Drawer_SetVIsoAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dIsoAspect(Prs3d_Drawer_VIsoAspect(Instance));
			}
		}
		public Prs3dLineAspect FreeBoundaryAspect{
			set { 
				Prs3d_Drawer_SetFreeBoundaryAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_FreeBoundaryAspect(Instance));
			}
		}
		public bool FreeBoundaryDraw{
			set { 
				Prs3d_Drawer_SetFreeBoundaryDraw(Instance, value);
			}
			get {
				return Prs3d_Drawer_FreeBoundaryDraw(Instance);
			}
		}
		public Prs3dLineAspect WireAspect{
			set { 
				Prs3d_Drawer_SetWireAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_WireAspect(Instance));
			}
		}
		public bool WireDraw{
			set { 
				Prs3d_Drawer_SetWireDraw(Instance, value);
			}
			get {
				return Prs3d_Drawer_WireDraw(Instance);
			}
		}
		public Prs3dLineAspect UnFreeBoundaryAspect{
			set { 
				Prs3d_Drawer_SetUnFreeBoundaryAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_UnFreeBoundaryAspect(Instance));
			}
		}
		public bool UnFreeBoundaryDraw{
			set { 
				Prs3d_Drawer_SetUnFreeBoundaryDraw(Instance, value);
			}
			get {
				return Prs3d_Drawer_UnFreeBoundaryDraw(Instance);
			}
		}
		public Prs3dLineAspect LineAspect{
			set { 
				Prs3d_Drawer_SetLineAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_LineAspect(Instance));
			}
		}
		public Prs3dTextAspect TextAspect{
			set { 
				Prs3d_Drawer_SetTextAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dTextAspect(Prs3d_Drawer_TextAspect(Instance));
			}
		}
		public bool LineArrowDraw{
			set { 
				Prs3d_Drawer_SetLineArrowDraw(Instance, value);
			}
			get {
				return Prs3d_Drawer_LineArrowDraw(Instance);
			}
		}
		public Prs3dPointAspect PointAspect{
			set { 
				Prs3d_Drawer_SetPointAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dPointAspect(Prs3d_Drawer_PointAspect(Instance));
			}
		}
		public Prs3dShadingAspect ShadingAspect{
			set { 
				Prs3d_Drawer_SetShadingAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dShadingAspect(Prs3d_Drawer_ShadingAspect(Instance));
			}
		}
		public bool ShadingAspectGlobal{
			set { 
				Prs3d_Drawer_SetShadingAspectGlobal(Instance, value);
			}
			get {
				return Prs3d_Drawer_ShadingAspectGlobal(Instance);
			}
		}
		public bool DrawHiddenLine{
			get {
				return Prs3d_Drawer_DrawHiddenLine(Instance);
			}
		}
		public Prs3dLineAspect HiddenLineAspect{
			set { 
				Prs3d_Drawer_SetHiddenLineAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_HiddenLineAspect(Instance));
			}
		}
		public Prs3dLineAspect SeenLineAspect{
			set { 
				Prs3d_Drawer_SetSeenLineAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_SeenLineAspect(Instance));
			}
		}
		public Prs3dLineAspect VectorAspect{
			set { 
				Prs3d_Drawer_SetVectorAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_VectorAspect(Instance));
			}
		}
		public Prs3dDatumAspect DatumAspect{
			set { 
				Prs3d_Drawer_SetDatumAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dDatumAspect(Prs3d_Drawer_DatumAspect(Instance));
			}
		}
		public Prs3dLineAspect SectionAspect{
			set { 
				Prs3d_Drawer_SetSectionAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_SectionAspect(Instance));
			}
		}
		public bool FaceBoundaryDraw{
			set { 
				Prs3d_Drawer_SetFaceBoundaryDraw(Instance, value);
			}
		}
		public bool IsFaceBoundaryDraw{
			get {
				return Prs3d_Drawer_IsFaceBoundaryDraw(Instance);
			}
		}
		public Prs3dLineAspect FaceBoundaryAspect{
			set { 
				Prs3d_Drawer_SetFaceBoundaryAspect(Instance, value.Instance);
			}
			get {
				return new Prs3dLineAspect(Prs3d_Drawer_FaceBoundaryAspect(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_EnableDrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_DisableDrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetTypeOfDeflection(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_Drawer_TypeOfDeflection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetMaximalChordialDeviation(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_MaximalChordialDeviation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetDeviationCoefficient(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_DeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetHLRDeviationCoefficient(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_HLRDeviationCoefficient(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetHLRAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_HLRAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetDeviationAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_DeviationAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetDiscretisation(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Prs3d_Drawer_Discretisation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetMaximalParameterValue(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Prs3d_Drawer_MaximalParameterValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetIsoOnPlane(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_IsoOnPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetUIsoAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_UIsoAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetVIsoAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_VIsoAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetFreeBoundaryAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_FreeBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetFreeBoundaryDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_FreeBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetWireAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_WireAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetWireDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_WireDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetUnFreeBoundaryAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_UnFreeBoundaryAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetUnFreeBoundaryDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_UnFreeBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetLineAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_LineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetTextAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_TextAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetLineArrowDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_LineArrowDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetPointAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_PointAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetShadingAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_ShadingAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetShadingAspectGlobal(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_ShadingAspectGlobal(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_DrawHiddenLine(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetHiddenLineAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_HiddenLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetSeenLineAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_SeenLineAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetVectorAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_VectorAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetDatumAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_DatumAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetSectionAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_SectionAspect(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetFaceBoundaryDraw(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Prs3d_Drawer_IsFaceBoundaryDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3d_Drawer_SetFaceBoundaryAspect(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Prs3d_Drawer_FaceBoundaryAspect(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Prs3dDrawer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Prs3dDrawer_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Prs3dDrawer_Dtor(IntPtr instance);
	}
}
