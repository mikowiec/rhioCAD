#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Font;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dView : Graphic3dDataStructureManager
	{
		public Visual3dView(Visual3dViewManager AManager)
 :
			base(Visual3d_View_CtorC8D72425(AManager.Instance) )
		{}
			public void Activate()
				{
					Visual3d_View_Activate(Instance);
				}
			public void Deactivate()
				{
					Visual3d_View_Deactivate(Instance);
				}
			public void Redraw()
				{
					Visual3d_View_Redraw(Instance);
				}
			public void Redraw(int x,int y,int width,int height)
				{
					Visual3d_View_Redraw8C6D7843(Instance, x, y, width, height);
				}
			public void Redraw(Visual3dLayer AnUnderLayer,Visual3dLayer AnOverLayer)
				{
					Visual3d_View_Redraw7202F40D(Instance, AnUnderLayer.Instance, AnOverLayer.Instance);
				}
			public void Redraw(Visual3dLayer AnUnderLayer,Visual3dLayer AnOverLayer,int x,int y,int width,int height)
				{
					Visual3d_View_Redraw885CF247(Instance, AnUnderLayer.Instance, AnOverLayer.Instance, x, y, width, height);
				}
			public void Remove()
				{
					Visual3d_View_Remove(Instance);
				}
			public void Resized()
				{
					Visual3d_View_Resized(Instance);
				}
			public void SetBackgroundImage(string FileName,AspectFillMethod FillStyle,bool update)
				{
					Visual3d_View_SetBackgroundImage5C59B37F(Instance, FileName, (int)FillStyle, update);
				}
			public void SetBgImageStyle(AspectFillMethod FillStyle,bool update)
				{
					Visual3d_View_SetBgImageStyle254163A9(Instance, (int)FillStyle, update);
				}
			public void SetBgGradientStyle(AspectGradientFillMethod FillStyle,bool update)
				{
					Visual3d_View_SetBgGradientStyle86DFD8CC(Instance, (int)FillStyle, update);
				}
			public void SetViewMappingDefault()
				{
					Visual3d_View_SetViewMappingDefault(Instance);
				}
			public void SetViewOrientationDefault()
				{
					Visual3d_View_SetViewOrientationDefault(Instance);
				}
			public void Update()
				{
					Visual3d_View_Update(Instance);
				}
			public void Update(Visual3dLayer AnUnderLayer,Visual3dLayer AnOverLayer)
				{
					Visual3d_View_Update7202F40D(Instance, AnUnderLayer.Instance, AnOverLayer.Instance);
				}
			public void ViewMappingReset()
				{
					Visual3d_View_ViewMappingReset(Instance);
				}
			public void ViewOrientationReset()
				{
					Visual3d_View_ViewOrientationReset(Instance);
				}
			public void SetAnimationModeOff()
				{
					Visual3d_View_SetAnimationModeOff(Instance);
				}
			public void ZBufferTriedronSetup(QuantityNameOfColor XColor,QuantityNameOfColor YColor,QuantityNameOfColor ZColor,double SizeRatio,double AxisDiametr,int NbFacettes)
				{
					Visual3d_View_ZBufferTriedronSetup9BCB825E(Instance, (int)XColor, (int)YColor, (int)ZColor, SizeRatio, AxisDiametr, NbFacettes);
				}
			public void TriedronDisplay(AspectTypeOfTriedronPosition APosition,QuantityNameOfColor AColor,double AScale,bool AsWireframe)
				{
					Visual3d_View_TriedronDisplayE9A003B7(Instance, (int)APosition, (int)AColor, AScale, AsWireframe);
				}
			public void TriedronErase()
				{
					Visual3d_View_TriedronErase(Instance);
				}
			public void TriedronEcho(AspectTypeOfTriedronEcho AType)
				{
					Visual3d_View_TriedronEcho14CB0F5D(Instance, (int)AType);
				}
			public void GraduatedTrihedronDisplay(TCollectionExtendedString xname,TCollectionExtendedString yname,TCollectionExtendedString zname,bool xdrawname,bool ydrawname,bool zdrawname,bool xdrawvalues,bool ydrawvalues,bool zdrawvalues,bool drawgrid,bool drawaxes,int nbx,int nby,int nbz,int xoffset,int yoffset,int zoffset,int xaxisoffset,int yaxisoffset,int zaxisoffset,bool xdrawtickmarks,bool ydrawtickmarks,bool zdrawtickmarks,int xtickmarklength,int ytickmarklength,int ztickmarklength,QuantityColor gridcolor,QuantityColor xnamecolor,QuantityColor ynamecolor,QuantityColor znamecolor,QuantityColor xcolor,QuantityColor ycolor,QuantityColor zcolor,TCollectionAsciiString fontOfNames,FontFontAspect styleOfNames,int sizeOfNames,TCollectionAsciiString fontOfValues,FontFontAspect styleOfValues,int sizeOfValues)
				{
					Visual3d_View_GraduatedTrihedronDisplayC3638B35(Instance, xname.Instance, yname.Instance, zname.Instance, xdrawname, ydrawname, zdrawname, xdrawvalues, ydrawvalues, zdrawvalues, drawgrid, drawaxes, nbx, nby, nbz, xoffset, yoffset, zoffset, xaxisoffset, yaxisoffset, zaxisoffset, xdrawtickmarks, ydrawtickmarks, zdrawtickmarks, xtickmarklength, ytickmarklength, ztickmarklength, gridcolor.Instance, xnamecolor.Instance, ynamecolor.Instance, znamecolor.Instance, xcolor.Instance, ycolor.Instance, zcolor.Instance, fontOfNames.Instance, (int)styleOfNames, sizeOfNames, fontOfValues.Instance, (int)styleOfValues, sizeOfValues);
				}
			public void GraduatedTrihedronErase()
				{
					Visual3d_View_GraduatedTrihedronErase(Instance);
				}
			public bool ContainsFacet()
				{
					return Visual3d_View_ContainsFacet(Instance);
				}
			public void MinMaxValues(ref double XMin,ref double YMin,ref double ZMin,ref double XMax,ref double YMax,ref double ZMax)
				{
					Visual3d_View_MinMaxValuesBC7A5786(Instance, ref XMin, ref YMin, ref ZMin, ref XMax, ref YMax, ref ZMax);
				}
			public void MinMaxValues(ref double XMin,ref double YMin,ref double XMax,ref double YMax)
				{
					Visual3d_View_MinMaxValuesC2777E0C(Instance, ref XMin, ref YMin, ref XMax, ref YMax);
				}
			public void Projects(double AX,double AY,double AZ,ref double APX,ref double APY,ref double APZ)
				{
					Visual3d_View_ProjectsBC7A5786(Instance, AX, AY, AZ, ref APX, ref APY, ref APZ);
				}
			public Visual3dViewMapping ViewMappingDefault()
				{
					return new Visual3dViewMapping(Visual3d_View_ViewMappingDefault(Instance));
				}
			public Visual3dViewOrientation ViewOrientationDefault()
				{
					return new Visual3dViewOrientation(Visual3d_View_ViewOrientationDefault(Instance));
				}
			public AspectWindow Window()
				{
					return new AspectWindow(Visual3d_View_Window(Instance));
				}
			public void Plot(Graphic3dPlotter APlotter)
				{
					Visual3d_View_Plot9190F42F(Instance, APlotter.Instance);
				}
			public bool Print(Visual3dLayer AnUnderLayer,Visual3dLayer AnOverLayer,IntPtr hPrnDC,bool showBackground,string filename,AspectPrintAlgo printAlgorithm,double theScaleFactor)
				{
					return Visual3d_View_Print3E41AD16(Instance, AnUnderLayer.Instance, AnOverLayer.Instance, hPrnDC, showBackground, filename, (int)printAlgorithm, theScaleFactor);
				}
			public bool Print(IntPtr hPrnDC,bool showBackground,string filename,AspectPrintAlgo printAlgorithm,double theScaleFactor)
				{
					return Visual3d_View_Print23A2F056(Instance, hPrnDC, showBackground, filename, (int)printAlgorithm, theScaleFactor);
				}
			public void EnableDepthTest(bool enable)
				{
					Visual3d_View_EnableDepthTest461FC46A(Instance, enable);
				}
			public void EnableGLLight(bool enable)
				{
					Visual3d_View_EnableGLLight461FC46A(Instance, enable);
				}
		public Visual3dTypeOfBackfacingModel BackFacingModel{
			set { 
				Visual3d_View_SetBackFacingModel(Instance, (int)value);
			}
			get {
				return (Visual3dTypeOfBackfacingModel)Visual3d_View_BackFacingModel(Instance);
			}
		}
		public bool AnimationModeOn{
			set { 
				Visual3d_View_SetAnimationModeOn(Instance, value);
			}
		}
		public bool AnimationModeIsOn{
			get {
				return Visual3d_View_AnimationModeIsOn(Instance);
			}
		}
		public bool DegenerateModeIsOn{
			get {
				return Visual3d_View_DegenerateModeIsOn(Instance);
			}
		}
		public bool ComputedMode{
			set { 
				Visual3d_View_SetComputedMode(Instance, value);
			}
			get {
				return Visual3d_View_ComputedMode(Instance);
			}
		}
		public AspectBackground Background{
			set { 
				Visual3d_View_SetBackground(Instance, value.Instance);
			}
			get {
				return new AspectBackground(Visual3d_View_Background(Instance));
			}
		}
		public bool IsActive{
			get {
				return Visual3d_View_IsActive(Instance);
			}
		}
		public bool IsDefined{
			get {
				return Visual3d_View_IsDefined(Instance);
			}
		}
		public bool IsDeleted{
			get {
				return Visual3d_View_IsDeleted(Instance);
			}
		}
		public int NumberOfDisplayedStructures{
			get {
				return Visual3d_View_NumberOfDisplayedStructures(Instance);
			}
		}
		public Visual3dViewMapping ViewMapping{
			set { 
				Visual3d_View_SetViewMapping(Instance, value.Instance);
			}
			get {
				return new Visual3dViewMapping(Visual3d_View_ViewMapping(Instance));
			}
		}
		public Visual3dViewOrientation ViewOrientation{
			set { 
				Visual3d_View_SetViewOrientation(Instance, value.Instance);
			}
			get {
				return new Visual3dViewOrientation(Visual3d_View_ViewOrientation(Instance));
			}
		}
		public int LightLimit{
			get {
				return Visual3d_View_LightLimit(Instance);
			}
		}
		public int PlaneLimit{
			get {
				return Visual3d_View_PlaneLimit(Instance);
			}
		}
		public Visual3dViewManager ViewManager{
			get {
				return new Visual3dViewManager(Visual3d_View_ViewManager(Instance));
			}
		}
		public int Identification{
			get {
				return Visual3d_View_Identification(Instance);
			}
		}
		public AspectGraphicDriver GraphicDriver{
			get {
				return new AspectGraphicDriver(Visual3d_View_GraphicDriver(Instance));
			}
		}
		public bool Transparency{
			set { 
				Visual3d_View_SetTransparency(Instance, value);
			}
		}
		public bool ZBufferIsActivated{
			get {
				return Visual3d_View_ZBufferIsActivated(Instance);
			}
		}
		public int ZBufferActivity{
			set { 
				Visual3d_View_SetZBufferActivity(Instance, value);
			}
		}
		public Visual3dLayer UnderLayer{
			get {
				return new Visual3dLayer(Visual3d_View_UnderLayer(Instance));
			}
		}
		public Visual3dLayer OverLayer{
			get {
				return new Visual3dLayer(Visual3d_View_OverLayer(Instance));
			}
		}
		public bool IsDepthTestEnabled{
			get {
				return Visual3d_View_IsDepthTestEnabled(Instance);
			}
		}
		public bool IsGLLightEnabled{
			get {
				return Visual3d_View_IsGLLightEnabled(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_CtorC8D72425(IntPtr AManager);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Activate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Deactivate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Redraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Redraw8C6D7843(IntPtr instance, int x,int y,int width,int height);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Redraw7202F40D(IntPtr instance, IntPtr AnUnderLayer,IntPtr AnOverLayer);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Redraw885CF247(IntPtr instance, IntPtr AnUnderLayer,IntPtr AnOverLayer,int x,int y,int width,int height);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Remove(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Resized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetBackgroundImage5C59B37F(IntPtr instance, string FileName,int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetBgImageStyle254163A9(IntPtr instance, int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetBgGradientStyle86DFD8CC(IntPtr instance, int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetViewMappingDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetViewOrientationDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Update(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Update7202F40D(IntPtr instance, IntPtr AnUnderLayer,IntPtr AnOverLayer);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_ViewMappingReset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_ViewOrientationReset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetAnimationModeOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_ZBufferTriedronSetup9BCB825E(IntPtr instance, int XColor,int YColor,int ZColor,double SizeRatio,double AxisDiametr,int NbFacettes);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_TriedronDisplayE9A003B7(IntPtr instance, int APosition,int AColor,double AScale,bool AsWireframe);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_TriedronErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_TriedronEcho14CB0F5D(IntPtr instance, int AType);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_GraduatedTrihedronDisplayC3638B35(IntPtr instance, IntPtr xname,IntPtr yname,IntPtr zname,bool xdrawname,bool ydrawname,bool zdrawname,bool xdrawvalues,bool ydrawvalues,bool zdrawvalues,bool drawgrid,bool drawaxes,int nbx,int nby,int nbz,int xoffset,int yoffset,int zoffset,int xaxisoffset,int yaxisoffset,int zaxisoffset,bool xdrawtickmarks,bool ydrawtickmarks,bool zdrawtickmarks,int xtickmarklength,int ytickmarklength,int ztickmarklength,IntPtr gridcolor,IntPtr xnamecolor,IntPtr ynamecolor,IntPtr znamecolor,IntPtr xcolor,IntPtr ycolor,IntPtr zcolor,IntPtr fontOfNames,int styleOfNames,int sizeOfNames,IntPtr fontOfValues,int styleOfValues,int sizeOfValues);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_GraduatedTrihedronErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_ContainsFacet(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_MinMaxValuesBC7A5786(IntPtr instance, ref double XMin,ref double YMin,ref double ZMin,ref double XMax,ref double YMax,ref double ZMax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_MinMaxValuesC2777E0C(IntPtr instance, ref double XMin,ref double YMin,ref double XMax,ref double YMax);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_ProjectsBC7A5786(IntPtr instance, double AX,double AY,double AZ,ref double APX,ref double APY,ref double APZ);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_ViewMappingDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_ViewOrientationDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_Window(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_Plot9190F42F(IntPtr instance, IntPtr APlotter);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_Print3E41AD16(IntPtr instance, IntPtr AnUnderLayer,IntPtr AnOverLayer,IntPtr hPrnDC,bool showBackground,string filename,int printAlgorithm,double theScaleFactor);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_Print23A2F056(IntPtr instance, IntPtr hPrnDC,bool showBackground,string filename,int printAlgorithm,double theScaleFactor);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_EnableDepthTest461FC46A(IntPtr instance, bool enable);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_EnableGLLight461FC46A(IntPtr instance, bool enable);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetBackFacingModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_View_BackFacingModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetAnimationModeOn(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_AnimationModeIsOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_DegenerateModeIsOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetComputedMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_ComputedMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetBackground(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_Background(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_IsActive(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_IsDefined(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_IsDeleted(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_View_NumberOfDisplayedStructures(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetViewMapping(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_ViewMapping(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetViewOrientation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_ViewOrientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_View_LightLimit(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_View_PlaneLimit(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_ViewManager(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_View_Identification(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_GraphicDriver(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetTransparency(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_ZBufferIsActivated(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_View_SetZBufferActivity(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_UnderLayer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_View_OverLayer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_IsDepthTestEnabled(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_View_IsGLLightEnabled(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dView() { } 

		public Visual3dView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dView_Dtor(IntPtr instance);
	}
}
