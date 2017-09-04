#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Viewer;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.gp;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TColStd;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dViewer : ViewerViewer
	{
		public V3dViewer(AspectGraphicDevice Device,string aName,string aDomain,double ViewSize,V3dTypeOfOrientation ViewProj,QuantityNameOfColor ViewBackground,V3dTypeOfVisualization Visualization,V3dTypeOfShadingModel ShadingModel,V3dTypeOfUpdate UpdateMode,bool ComputedMode,bool DefaultComputedMode,V3dTypeOfSurfaceDetail SurfaceDetail)
 :
			base(V3d_Viewer_Ctor36F0AB5(Device.Instance, aName, aDomain, ViewSize, (int)ViewProj, (int)ViewBackground, (int)Visualization, (int)ShadingModel, (int)UpdateMode, ComputedMode, DefaultComputedMode, (int)SurfaceDetail) )
		{}
			public void SetViewOn()
				{
					V3d_Viewer_SetViewOn(Instance);
				}
			public void SetViewOn(V3dView View)
				{
					V3d_Viewer_SetViewOn36A6FAB7(Instance, View.Instance);
				}
			public void SetViewOff()
				{
					V3d_Viewer_SetViewOff(Instance);
				}
			public void SetViewOff(V3dView View)
				{
					V3d_Viewer_SetViewOff36A6FAB7(Instance, View.Instance);
				}
			public void Update()
				{
                    try
                    {
                        V3d_Viewer_Update(Instance);
                    }
                catch
                {
                }
				}
			public void UpdateLights()
				{
					V3d_Viewer_UpdateLights(Instance);
				}
			public void Redraw()
				{
					V3d_Viewer_Redraw(Instance);
				}
			public void Remove()
				{
					V3d_Viewer_Remove(Instance);
				}
			public void Erase()
				{
					V3d_Viewer_Erase(Instance);
				}
			public void UnHighlight()
				{
					V3d_Viewer_UnHighlight(Instance);
				}
			public void SetDefaultBackgroundColor(QuantityTypeOfColor Type,double V1,double V2,double V3)
				{
					V3d_Viewer_SetDefaultBackgroundColor638950E1(Instance, (int)Type, V1, V2, V3);
				}
			public void SetDefaultBackgroundColor(QuantityNameOfColor Name)
				{
					V3d_Viewer_SetDefaultBackgroundColor48F4F471(Instance, (int)Name);
				}
			public void SetDefaultBackgroundColor(QuantityColor Color)
				{
					V3d_Viewer_SetDefaultBackgroundColor8FD7F48(Instance, Color.Instance);
				}
			public void SetDefaultBgGradientColors(QuantityNameOfColor Name1,QuantityNameOfColor Name2,AspectGradientFillMethod FillStyle)
				{
					V3d_Viewer_SetDefaultBgGradientColors99C5FF9E(Instance, (int)Name1, (int)Name2, (int)FillStyle);
				}
			public void SetDefaultBgGradientColors(QuantityColor Color1,QuantityColor Color2,AspectGradientFillMethod FillStyle)
				{
					V3d_Viewer_SetDefaultBgGradientColorsEE919A89(Instance, Color1.Instance, Color2.Instance, (int)FillStyle);
				}
			public void DisplayPrivilegedPlane(bool OnOff,double aSize)
				{
					V3d_Viewer_DisplayPrivilegedPlane15F3D2D4(Instance, OnOff, aSize);
				}
			public void SetLightOn(V3dLight MyLight)
				{
					V3d_Viewer_SetLightOn1C16FAC6(Instance, MyLight.Instance);
				}
			public void SetLightOn()
				{
					V3d_Viewer_SetLightOn(Instance);
				}
			public void SetLightOff(V3dLight MyLight)
				{
					V3d_Viewer_SetLightOff1C16FAC6(Instance, MyLight.Instance);
				}
			public void SetLightOff()
				{
					V3d_Viewer_SetLightOff(Instance);
				}
			public void DelLight(V3dLight MyLight)
				{
					V3d_Viewer_DelLight1C16FAC6(Instance, MyLight.Instance);
				}
			public void ClearCurrentSelectedLight()
				{
					V3d_Viewer_ClearCurrentSelectedLight(Instance);
				}
			public void DefaultBackgroundColor(QuantityTypeOfColor Type,ref double V1,ref double V2,ref double V3)
				{
					V3d_Viewer_DefaultBackgroundColor638950E1(Instance, (int)Type, ref V1, ref V2, ref V3);
				}
			public QuantityColor DefaultBackgroundColor()
				{
					return new QuantityColor(V3d_Viewer_DefaultBackgroundColor(Instance));
				}
			public void DefaultBgGradientColors(QuantityColor Color1,QuantityColor Color2)
				{
					V3d_Viewer_DefaultBgGradientColorsCF0F9433(Instance, Color1.Instance, Color2.Instance);
				}
			public void InitActiveViews()
				{
					V3d_Viewer_InitActiveViews(Instance);
				}
			public void NextActiveViews()
				{
					V3d_Viewer_NextActiveViews(Instance);
				}
			public void InitDefinedViews()
				{
					V3d_Viewer_InitDefinedViews(Instance);
				}
			public void NextDefinedViews()
				{
					V3d_Viewer_NextDefinedViews(Instance);
				}
			public void InitActiveLights()
				{
					V3d_Viewer_InitActiveLights(Instance);
				}
			public void NextActiveLights()
				{
					V3d_Viewer_NextActiveLights(Instance);
				}
			public void InitDefinedLights()
				{
					V3d_Viewer_InitDefinedLights(Instance);
				}
			public void NextDefinedLights()
				{
					V3d_Viewer_NextDefinedLights(Instance);
				}
			public void AddPlane(V3dPlane MyPlane)
				{
					V3d_Viewer_AddPlane20B19CEF(Instance, MyPlane.Instance);
				}
			public void DelPlane(V3dPlane MyPlane)
				{
					V3d_Viewer_DelPlane20B19CEF(Instance, MyPlane.Instance);
				}
			public void InitDefinedPlanes()
				{
					V3d_Viewer_InitDefinedPlanes(Instance);
				}
			public void NextDefinedPlanes()
				{
					V3d_Viewer_NextDefinedPlanes(Instance);
				}
			public bool IsGlobalLight(V3dLight TheLight)
				{
					return V3d_Viewer_IsGlobalLight1C16FAC6(Instance, TheLight.Instance);
				}
			public void ActivateGrid(AspectGridType aGridType,AspectGridDrawMode aGridDrawMode)
				{
					V3d_Viewer_ActivateGridBD34C5A5(Instance, (int)aGridType, (int)aGridDrawMode);
				}
			public void DeactivateGrid()
				{
					V3d_Viewer_DeactivateGrid(Instance);
				}
			public bool GridEcho()
				{
					return V3d_Viewer_GridEcho(Instance);
				}
			public void RectangularGridValues(ref double XOrigin,ref double YOrigin,ref double XStep,ref double YStep,ref double RotationAngle)
				{
					V3d_Viewer_RectangularGridValues216AF150(Instance, ref XOrigin, ref YOrigin, ref XStep, ref YStep, ref RotationAngle);
				}
			public void SetRectangularGridValues(double XOrigin,double YOrigin,double XStep,double YStep,double RotationAngle)
				{
					V3d_Viewer_SetRectangularGridValues216AF150(Instance, XOrigin, YOrigin, XStep, YStep, RotationAngle);
				}
			public void CircularGridValues(ref double XOrigin,ref double YOrigin,ref double RadiusStep,ref int DivisionNumber,ref double RotationAngle)
				{
					V3d_Viewer_CircularGridValuesFC0B193D(Instance, ref XOrigin, ref YOrigin, ref RadiusStep, ref DivisionNumber, ref RotationAngle);
				}
			public void SetCircularGridValues(double XOrigin,double YOrigin,double RadiusStep,int DivisionNumber,double RotationAngle)
				{
					V3d_Viewer_SetCircularGridValuesFC0B193D(Instance, XOrigin, YOrigin, RadiusStep, DivisionNumber, RotationAngle);
				}
			public void CircularGridGraphicValues(ref double Radius,ref double OffSet)
				{
					V3d_Viewer_CircularGridGraphicValues9F0E714F(Instance, ref Radius, ref OffSet);
				}
			public void SetCircularGridGraphicValues(double Radius,double OffSet)
				{
					V3d_Viewer_SetCircularGridGraphicValues9F0E714F(Instance, Radius, OffSet);
				}
			public void RectangularGridGraphicValues(ref double XSize,ref double YSize,ref double OffSet)
				{
					V3d_Viewer_RectangularGridGraphicValues9282A951(Instance, ref XSize, ref YSize, ref OffSet);
				}
			public void SetRectangularGridGraphicValues(double XSize,double YSize,double OffSet)
				{
					V3d_Viewer_SetRectangularGridGraphicValues9282A951(Instance, XSize, YSize, OffSet);
				}
			public void SetDefaultLights()
				{
					V3d_Viewer_SetDefaultLights(Instance);
				}
			public void Init()
				{
					V3d_Viewer_Init(Instance);
				}
			public bool AddZLayer(ref int theLayerId)
				{
					return V3d_Viewer_AddZLayerE8219145(Instance, ref theLayerId);
				}
			public bool RemoveZLayer(int theLayerId)
				{
					return V3d_Viewer_RemoveZLayerE8219145(Instance, theLayerId);
				}
			public void GetAllZLayers(TColStdSequenceOfInteger theLayerSeq)
				{
					V3d_Viewer_GetAllZLayersE22FA26(Instance, theLayerSeq.Instance);
				}
		public V3dView CreateView{
			get {
				return new V3dView(V3d_Viewer_CreateView(Instance));
			}
		}
		public V3dOrthographicView DefaultOrthographicView{
			get {
				return new V3dOrthographicView(V3d_Viewer_DefaultOrthographicView(Instance));
			}
		}
		public V3dPerspectiveView DefaultPerspectiveView{
			get {
				return new V3dPerspectiveView(V3d_Viewer_DefaultPerspectiveView(Instance));
			}
		}
		public bool ZBufferManagment{
			set { 
				V3d_Viewer_SetZBufferManagment(Instance, value);
			}
			get {
				return V3d_Viewer_ZBufferManagment(Instance);
			}
		}
		public V3dTypeOfView DefaultTypeOfView{
			set { 
				V3d_Viewer_SetDefaultTypeOfView(Instance, (int)value);
			}
		}
		public gpAx3 PrivilegedPlane{
			set { 
				V3d_Viewer_SetPrivilegedPlane(Instance, value.Instance);
			}
			get {
				return new gpAx3(V3d_Viewer_PrivilegedPlane(Instance));
			}
		}
		public double DefaultViewSize{
			set { 
				V3d_Viewer_SetDefaultViewSize(Instance, value);
			}
			get {
				return V3d_Viewer_DefaultViewSize(Instance);
			}
		}
		public V3dTypeOfOrientation DefaultViewProj{
			set { 
				V3d_Viewer_SetDefaultViewProj(Instance, (int)value);
			}
			get {
				return (V3dTypeOfOrientation)V3d_Viewer_DefaultViewProj(Instance);
			}
		}
		public V3dTypeOfVisualization DefaultVisualization{
			set { 
				V3d_Viewer_SetDefaultVisualization(Instance, (int)value);
			}
			get {
				return (V3dTypeOfVisualization)V3d_Viewer_DefaultVisualization(Instance);
			}
		}
		public V3dTypeOfShadingModel DefaultShadingModel{
			set { 
				V3d_Viewer_SetDefaultShadingModel(Instance, (int)value);
			}
			get {
				return (V3dTypeOfShadingModel)V3d_Viewer_DefaultShadingModel(Instance);
			}
		}
		public V3dTypeOfSurfaceDetail DefaultSurfaceDetail{
			set { 
				V3d_Viewer_SetDefaultSurfaceDetail(Instance, (int)value);
			}
			get {
				return (V3dTypeOfSurfaceDetail)V3d_Viewer_DefaultSurfaceDetail(Instance);
			}
		}
		public double DefaultAngle{
			set { 
				V3d_Viewer_SetDefaultAngle(Instance, value);
			}
			get {
				return V3d_Viewer_DefaultAngle(Instance);
			}
		}
		public V3dTypeOfUpdate UpdateMode{
			set { 
				V3d_Viewer_SetUpdateMode(Instance, (int)value);
			}
			get {
				return (V3dTypeOfUpdate)V3d_Viewer_UpdateMode(Instance);
			}
		}
		public bool IfMoreViews{
			get {
				return V3d_Viewer_IfMoreViews(Instance);
			}
		}
		public bool MoreActiveViews{
			get {
				return V3d_Viewer_MoreActiveViews(Instance);
			}
		}
		public V3dView ActiveView{
			get {
				return new V3dView(V3d_Viewer_ActiveView(Instance));
			}
		}
		public bool LastActiveView{
			get {
				return V3d_Viewer_LastActiveView(Instance);
			}
		}
		public bool MoreDefinedViews{
			get {
				return V3d_Viewer_MoreDefinedViews(Instance);
			}
		}
		public V3dView DefinedView{
			get {
				return new V3dView(V3d_Viewer_DefinedView(Instance));
			}
		}
		public bool MoreActiveLights{
			get {
				return V3d_Viewer_MoreActiveLights(Instance);
			}
		}
		public V3dLight ActiveLight{
			get {
				return new V3dLight(V3d_Viewer_ActiveLight(Instance));
			}
		}
		public bool MoreDefinedLights{
			get {
				return V3d_Viewer_MoreDefinedLights(Instance);
			}
		}
		public V3dLight DefinedLight{
			get {
				return new V3dLight(V3d_Viewer_DefinedLight(Instance));
			}
		}
		public bool MoreDefinedPlanes{
			get {
				return V3d_Viewer_MoreDefinedPlanes(Instance);
			}
		}
		public V3dPlane DefinedPlane{
			get {
				return new V3dPlane(V3d_Viewer_DefinedPlane(Instance));
			}
		}
		public Visual3dViewManager Viewer{
			get {
				return new Visual3dViewManager(V3d_Viewer_Viewer(Instance));
			}
		}
		public V3dLight CurrentSelectedLight{
			set { 
				V3d_Viewer_SetCurrentSelectedLight(Instance, value.Instance);
			}
			get {
				return new V3dLight(V3d_Viewer_CurrentSelectedLight(Instance));
			}
		}
		public bool ComputedMode{
			get {
				return V3d_Viewer_ComputedMode(Instance);
			}
		}
		public bool DefaultComputedMode{
			get {
				return V3d_Viewer_DefaultComputedMode(Instance);
			}
		}
		public bool IsActive{
			get {
				return V3d_Viewer_IsActive(Instance);
			}
		}
		public AspectGrid Grid{
			get {
				return new AspectGrid(V3d_Viewer_Grid(Instance));
			}
		}
		public AspectGridType GridType{
			get {
				return (AspectGridType)V3d_Viewer_GridType(Instance);
			}
		}
		public AspectGridDrawMode GridDrawMode{
			get {
				return (AspectGridDrawMode)V3d_Viewer_GridDrawMode(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_Ctor36F0AB5(IntPtr Device,string aName,string aDomain,double ViewSize,int ViewProj,int ViewBackground,int Visualization,int ShadingModel,int UpdateMode,bool ComputedMode,bool DefaultComputedMode,int SurfaceDetail);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetViewOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetViewOn36A6FAB7(IntPtr instance, IntPtr View);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetViewOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetViewOff36A6FAB7(IntPtr instance, IntPtr View);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_Update(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_UpdateLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_Redraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_Remove(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_Erase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_UnHighlight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultBackgroundColor638950E1(IntPtr instance, int Type,double V1,double V2,double V3);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultBackgroundColor48F4F471(IntPtr instance, int Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultBackgroundColor8FD7F48(IntPtr instance, IntPtr Color);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultBgGradientColors99C5FF9E(IntPtr instance, int Name1,int Name2,int FillStyle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultBgGradientColorsEE919A89(IntPtr instance, IntPtr Color1,IntPtr Color2,int FillStyle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DisplayPrivilegedPlane15F3D2D4(IntPtr instance, bool OnOff,double aSize);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetLightOn1C16FAC6(IntPtr instance, IntPtr MyLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetLightOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetLightOff1C16FAC6(IntPtr instance, IntPtr MyLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetLightOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DelLight1C16FAC6(IntPtr instance, IntPtr MyLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_ClearCurrentSelectedLight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DefaultBackgroundColor638950E1(IntPtr instance, int Type,ref double V1,ref double V2,ref double V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefaultBackgroundColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DefaultBgGradientColorsCF0F9433(IntPtr instance, IntPtr Color1,IntPtr Color2);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_InitActiveViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_NextActiveViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_InitDefinedViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_NextDefinedViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_InitActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_NextActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_InitDefinedLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_NextDefinedLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_AddPlane20B19CEF(IntPtr instance, IntPtr MyPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DelPlane20B19CEF(IntPtr instance, IntPtr MyPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_InitDefinedPlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_NextDefinedPlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_IsGlobalLight1C16FAC6(IntPtr instance, IntPtr TheLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_ActivateGridBD34C5A5(IntPtr instance, int aGridType,int aGridDrawMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_DeactivateGrid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_GridEcho(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_RectangularGridValues216AF150(IntPtr instance, ref double XOrigin,ref double YOrigin,ref double XStep,ref double YStep,ref double RotationAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetRectangularGridValues216AF150(IntPtr instance, double XOrigin,double YOrigin,double XStep,double YStep,double RotationAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_CircularGridValuesFC0B193D(IntPtr instance, ref double XOrigin,ref double YOrigin,ref double RadiusStep,ref int DivisionNumber,ref double RotationAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetCircularGridValuesFC0B193D(IntPtr instance, double XOrigin,double YOrigin,double RadiusStep,int DivisionNumber,double RotationAngle);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_CircularGridGraphicValues9F0E714F(IntPtr instance, ref double Radius,ref double OffSet);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetCircularGridGraphicValues9F0E714F(IntPtr instance, double Radius,double OffSet);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_RectangularGridGraphicValues9282A951(IntPtr instance, ref double XSize,ref double YSize,ref double OffSet);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetRectangularGridGraphicValues9282A951(IntPtr instance, double XSize,double YSize,double OffSet);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_Init(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_AddZLayerE8219145(IntPtr instance, ref int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_RemoveZLayerE8219145(IntPtr instance, int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_GetAllZLayersE22FA26(IntPtr instance, IntPtr theLayerSeq);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_CreateView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefaultOrthographicView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefaultPerspectiveView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetZBufferManagment(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_ZBufferManagment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultTypeOfView(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetPrivilegedPlane(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_PrivilegedPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultViewSize(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_Viewer_DefaultViewSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultViewProj(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_DefaultViewProj(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultVisualization(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_DefaultVisualization(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultShadingModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_DefaultShadingModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultSurfaceDetail(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_DefaultSurfaceDetail(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetDefaultAngle(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_Viewer_DefaultAngle(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetUpdateMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_UpdateMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_IfMoreViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_MoreActiveViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_ActiveView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_LastActiveView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_MoreDefinedViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefinedView(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_MoreActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_ActiveLight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_MoreDefinedLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefinedLight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_MoreDefinedPlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_DefinedPlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_Viewer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_Viewer_SetCurrentSelectedLight(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_CurrentSelectedLight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_ComputedMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_DefaultComputedMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_Viewer_IsActive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_Viewer_Grid(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_GridType(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_Viewer_GridDrawMode(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dViewer() { } 

		public V3dViewer(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{
            try
            {
                V3dViewer_Dtor(Instance);
            }
            catch
            {
            }
		}

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dViewer_Dtor(IntPtr instance);
	}
}
