#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Viewer;
using NaroCppCore.Occ.V3d;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Font;
using NaroCppCore.Occ.gp;

#endregion

namespace NaroCppCore.Occ.V3d
{
	public class V3dView : ViewerView
	{
			public void SetWindow(AspectWindow IdWin)
				{
					V3d_View_SetWindow6DD76FB2(Instance, IdWin.Instance);
				}
			public void SetMagnify(AspectWindow IdWin,V3dView aPreviousView,int x1,int y1,int x2,int y2)
				{
					V3d_View_SetMagnifyD520CBEE(Instance, IdWin.Instance, aPreviousView.Instance, x1, y1, x2, y2);
				}
			public void Remove()
				{
					V3d_View_Remove(Instance);
				}
			public void Update()
				{
					V3d_View_Update(Instance);
				}
			public void Redraw()
				{
					V3d_View_Redraw(Instance);
				}
			public void Redraw(int x,int y,int width,int height)
				{
					V3d_View_Redraw8C6D7843(Instance, x, y, width, height);
				}
			public void MustBeResized()
				{
					V3d_View_MustBeResized(Instance);
				}
			public void DoMapping()
				{
					V3d_View_DoMapping(Instance);
				}
			public void UpdateLights()
				{
					V3d_View_UpdateLights(Instance);
				}
			public void SetBackgroundColor(QuantityTypeOfColor Type,double V1,double V2,double V3)
				{
					V3d_View_SetBackgroundColor638950E1(Instance, (int)Type, V1, V2, V3);
				}
			public void SetBackgroundColor(QuantityColor Color)
				{
					V3d_View_SetBackgroundColor8FD7F48(Instance, Color.Instance);
				}
			public void SetBackgroundColor(QuantityNameOfColor Name)
				{
					V3d_View_SetBackgroundColor48F4F471(Instance, (int)Name);
				}
			public void SetBgGradientColors(QuantityColor Color1,QuantityColor Color2,AspectGradientFillMethod FillStyle,bool update)
				{
					V3d_View_SetBgGradientColorsA313F140(Instance, Color1.Instance, Color2.Instance, (int)FillStyle, update);
				}
			public void SetBgGradientColors(QuantityNameOfColor Color1,QuantityNameOfColor Color2,AspectGradientFillMethod FillStyle,bool update)
				{
					V3d_View_SetBgGradientColors4216A027(Instance, (int)Color1, (int)Color2, (int)FillStyle, update);
				}
			public void SetBgGradientStyle(AspectGradientFillMethod AMethod,bool update)
				{
					V3d_View_SetBgGradientStyle86DFD8CC(Instance, (int)AMethod, update);
				}
			public void SetBackgroundImage(string FileName,AspectFillMethod FillStyle,bool update)
				{
					V3d_View_SetBackgroundImage5C59B37F(Instance, FileName, (int)FillStyle, update);
				}
			public void SetBgImageStyle(AspectFillMethod FillStyle,bool update)
				{
					V3d_View_SetBgImageStyle254163A9(Instance, (int)FillStyle, update);
				}
			public void SetAxis(double X,double Y,double Z,double Vx,double Vy,double Vz)
				{
					V3d_View_SetAxisBC7A5786(Instance, X, Y, Z, Vx, Vy, Vz);
				}
			public void SetAntialiasingOn()
				{
					V3d_View_SetAntialiasingOn(Instance);
				}
			public void SetAntialiasingOff()
				{
					V3d_View_SetAntialiasingOff(Instance);
				}
			public void SetZCueingOn()
				{
					V3d_View_SetZCueingOn(Instance);
				}
			public void SetZCueingOff()
				{
					V3d_View_SetZCueingOff(Instance);
				}
			public void SetLightOn(V3dLight MyLight)
				{
					V3d_View_SetLightOn1C16FAC6(Instance, MyLight.Instance);
				}
			public void SetLightOn()
				{
					V3d_View_SetLightOn(Instance);
				}
			public void SetLightOff(V3dLight MyLight)
				{
					V3d_View_SetLightOff1C16FAC6(Instance, MyLight.Instance);
				}
			public void SetLightOff()
				{
					V3d_View_SetLightOff(Instance);
				}
			public bool IsActiveLight(V3dLight aLight)
				{
					return V3d_View_IsActiveLight1C16FAC6(Instance, aLight.Instance);
				}
			public void SetPlaneOn(V3dPlane MyPlane)
				{
					V3d_View_SetPlaneOn20B19CEF(Instance, MyPlane.Instance);
				}
			public void SetPlaneOn()
				{
					V3d_View_SetPlaneOn(Instance);
				}
			public void SetPlaneOff(V3dPlane MyPlane)
				{
					V3d_View_SetPlaneOff20B19CEF(Instance, MyPlane.Instance);
				}
			public void SetPlaneOff()
				{
					V3d_View_SetPlaneOff(Instance);
				}
			public bool IsActivePlane(V3dPlane aPlane)
				{
					return V3d_View_IsActivePlane20B19CEF(Instance, aPlane.Instance);
				}
			public void ZBufferTriedronSetup(QuantityNameOfColor XColor,QuantityNameOfColor YColor,QuantityNameOfColor ZColor,double SizeRatio,double AxisDiametr,int NbFacettes)
				{
					V3d_View_ZBufferTriedronSetup9BCB825E(Instance, (int)XColor, (int)YColor, (int)ZColor, SizeRatio, AxisDiametr, NbFacettes);
				}
			public void TriedronDisplay(AspectTypeOfTriedronPosition APosition,QuantityNameOfColor AColor,double AScale,V3dTypeOfVisualization AMode)
				{
					V3d_View_TriedronDisplay4E80490A(Instance, (int)APosition, (int)AColor, AScale, (int)AMode);
				}
			public void TriedronErase()
				{
					V3d_View_TriedronErase(Instance);
				}
			public void TriedronEcho(AspectTypeOfTriedronEcho AType)
				{
					V3d_View_TriedronEcho14CB0F5D(Instance, (int)AType);
				}
            //public void GetGraduatedTrihedron(TCollectionExtendedString xname,TCollectionExtendedString yname,TCollectionExtendedString zname,ref bool xdrawname,ref bool ydrawname,ref bool zdrawname,ref bool xdrawvalues,ref bool ydrawvalues,ref bool zdrawvalues,ref bool drawgrid,ref bool drawaxes,ref int nbx,ref int nby,ref int nbz,ref int xoffset,ref int yoffset,ref int zoffset,ref int xaxisoffset,ref int yaxisoffset,ref int zaxisoffset,ref bool xdrawtickmarks,ref bool ydrawtickmarks,ref bool zdrawtickmarks,ref int xtickmarklength,ref int ytickmarklength,ref int ztickmarklength,QuantityColor gridcolor,QuantityColor xnamecolor,QuantityColor ynamecolor,QuantityColor znamecolor,QuantityColor xcolor,QuantityColor ycolor,QuantityColor zcolor,TCollectionAsciiString fontOfNames,ref FontFontAspect styleOfNames,ref int sizeOfNames,TCollectionAsciiString fontOfValues,ref FontFontAspect styleOfValues,ref int sizeOfValues)
            //    {
            //        V3d_View_GetGraduatedTrihedronC3638B35(Instance, xname.Instance, yname.Instance, zname.Instance, ref xdrawname, ref ydrawname, ref zdrawname, ref xdrawvalues, ref ydrawvalues, ref zdrawvalues, ref drawgrid, ref drawaxes, ref nbx, ref nby, ref nbz, ref xoffset, ref yoffset, ref zoffset, ref xaxisoffset, ref yaxisoffset, ref zaxisoffset, ref xdrawtickmarks, ref ydrawtickmarks, ref zdrawtickmarks, ref xtickmarklength, ref ytickmarklength, ref ztickmarklength, gridcolor.Instance, xnamecolor.Instance, ynamecolor.Instance, znamecolor.Instance, xcolor.Instance, ycolor.Instance, zcolor.Instance, fontOfNames.Instance, ref (int)styleOfNames, ref sizeOfNames, fontOfValues.Instance, ref (int)styleOfValues, ref sizeOfValues);
            //    }
			public void GraduatedTrihedronDisplay(TCollectionExtendedString xname,TCollectionExtendedString yname,TCollectionExtendedString zname,bool xdrawname,bool ydrawname,bool zdrawname,bool xdrawvalues,bool ydrawvalues,bool zdrawvalues,bool drawgrid,bool drawaxes,int nbx,int nby,int nbz,int xoffset,int yoffset,int zoffset,int xaxisoffset,int yaxisoffset,int zaxisoffset,bool xdrawtickmarks,bool ydrawtickmarks,bool zdrawtickmarks,int xtickmarklength,int ytickmarklength,int ztickmarklength,QuantityColor gridcolor,QuantityColor xnamecolor,QuantityColor ynamecolor,QuantityColor znamecolor,QuantityColor xcolor,QuantityColor ycolor,QuantityColor zcolor,TCollectionAsciiString fontOfNames,FontFontAspect styleOfNames,int sizeOfNames,TCollectionAsciiString fontOfValues,FontFontAspect styleOfValues,int sizeOfValues)
				{
					V3d_View_GraduatedTrihedronDisplayC3638B35(Instance, xname.Instance, yname.Instance, zname.Instance, xdrawname, ydrawname, zdrawname, xdrawvalues, ydrawvalues, zdrawvalues, drawgrid, drawaxes, nbx, nby, nbz, xoffset, yoffset, zoffset, xaxisoffset, yaxisoffset, zaxisoffset, xdrawtickmarks, ydrawtickmarks, zdrawtickmarks, xtickmarklength, ytickmarklength, ztickmarklength, gridcolor.Instance, xnamecolor.Instance, ynamecolor.Instance, znamecolor.Instance, xcolor.Instance, ycolor.Instance, zcolor.Instance, fontOfNames.Instance, (int)styleOfNames, sizeOfNames, fontOfValues.Instance, (int)styleOfValues, sizeOfValues);
				}
			public void GraduatedTrihedronErase()
				{
					V3d_View_GraduatedTrihedronErase(Instance);
				}
			public void ColorScaleDisplay()
				{
					V3d_View_ColorScaleDisplay(Instance);
				}
			public void ColorScaleErase()
				{
					V3d_View_ColorScaleErase(Instance);
				}
			public void SetFront()
				{
					V3d_View_SetFront(Instance);
				}
			public void Rotate(double Ax,double Ay,double Az,bool Start)
				{
					V3d_View_Rotate1B801FD4(Instance, Ax, Ay, Az, Start);
				}
			public void Rotate(double Ax,double Ay,double Az,double X,double Y,double Z,bool Start)
				{
					V3d_View_Rotate51E06B8D(Instance, Ax, Ay, Az, X, Y, Z, Start);
				}
			public void Rotate(V3dTypeOfAxe Axe,double Angle,double X,double Y,double Z,bool Start)
				{
					V3d_View_Rotate45D32271(Instance, (int)Axe, Angle, X, Y, Z, Start);
				}
			public void Rotate(V3dTypeOfAxe Axe,double Angle,bool Start)
				{
					V3d_View_RotateB8D50DF4(Instance, (int)Axe, Angle, Start);
				}
			public void Rotate(double Angle,bool Start)
				{
					V3d_View_RotateC85E5E0F(Instance, Angle, Start);
				}
			public void Move(double Dx,double Dy,double Dz,bool Start)
				{
					V3d_View_Move1B801FD4(Instance, Dx, Dy, Dz, Start);
				}
			public void Move(V3dTypeOfAxe Axe,double Length,bool Start)
				{
					V3d_View_MoveB8D50DF4(Instance, (int)Axe, Length, Start);
				}
			public void Move(double Length,bool Start)
				{
					V3d_View_MoveC85E5E0F(Instance, Length, Start);
				}
			public void Translate(double Dx,double Dy,double Dz,bool Start)
				{
					V3d_View_Translate1B801FD4(Instance, Dx, Dy, Dz, Start);
				}
			public void Translate(V3dTypeOfAxe Axe,double Length,bool Start)
				{
					V3d_View_TranslateB8D50DF4(Instance, (int)Axe, Length, Start);
				}
			public void Translate(double Length,bool Start)
				{
					V3d_View_TranslateC85E5E0F(Instance, Length, Start);
				}
			public void Place(int x,int y,double aZoomFactor)
				{
					V3d_View_Place83917674(Instance, x, y, aZoomFactor);
				}
			public void Turn(double Ax,double Ay,double Az,bool Start)
				{
					V3d_View_Turn1B801FD4(Instance, Ax, Ay, Az, Start);
				}
			public void Turn(V3dTypeOfAxe Axe,double Angle,bool Start)
				{
					V3d_View_TurnB8D50DF4(Instance, (int)Axe, Angle, Start);
				}
			public void Turn(double Angle,bool Start)
				{
					V3d_View_TurnC85E5E0F(Instance, Angle, Start);
				}
			public void SetEye(double X,double Y,double Z)
				{
					V3d_View_SetEye9282A951(Instance, X, Y, Z);
				}
			public void SetProj(double Vx,double Vy,double Vz)
				{
					V3d_View_SetProj9282A951(Instance, Vx, Vy, Vz);
				}
			public void SetProj(V3dTypeOfOrientation Orientation)
				{
					V3d_View_SetProj17AA5025(Instance, (int)Orientation);
				}
			public void SetAt(double X,double Y,double Z)
				{
					V3d_View_SetAt9282A951(Instance, X, Y, Z);
				}
			public void SetUp(double Vx,double Vy,double Vz)
				{
					V3d_View_SetUp9282A951(Instance, Vx, Vy, Vz);
				}
			public void SetUp(V3dTypeOfOrientation Orientation)
				{
					V3d_View_SetUp17AA5025(Instance, (int)Orientation);
				}
			public void SetViewOrientationDefault()
				{
					V3d_View_SetViewOrientationDefault(Instance);
				}
			public void ResetViewOrientation()
				{
					V3d_View_ResetViewOrientation(Instance);
				}
			public void Panning(double Dx,double Dy,double aZoomFactor,bool Start)
				{
					V3d_View_Panning1B801FD4(Instance, Dx, Dy, aZoomFactor, Start);
				}
			public void SetCenter(double Xc,double Yc)
				{
					V3d_View_SetCenter9F0E714F(Instance, Xc, Yc);
				}
			public void SetCenter(int X,int Y)
				{
					V3d_View_SetCenter5107F6FE(Instance, X, Y);
				}
			public void SetSize(double Size)
				{
					V3d_View_SetSizeD82819F3(Instance, Size);
				}
			public void SetZoom(double Coef,bool Start)
				{
					V3d_View_SetZoomC85E5E0F(Instance, Coef, Start);
				}
			public void SetAxialScale(double Sx,double Sy,double Sz)
				{
					V3d_View_SetAxialScale9282A951(Instance, Sx, Sy, Sz);
				}
			public void FitAll(double Coef,bool FitZ,bool update)
				{
					V3d_View_FitAll7B00BEA(Instance, Coef, FitZ, update);
				}
			public void ZFitAll(double Coef)
				{
					V3d_View_ZFitAllD82819F3(Instance, Coef);
				}
			public void DepthFitAll(double Aspect,double Margin)
				{
					V3d_View_DepthFitAll9F0E714F(Instance, Aspect, Margin);
				}
			public void FitAll(double Umin,double Vmin,double Umax,double Vmax)
				{
					V3d_View_FitAllC2777E0C(Instance, Umin, Vmin, Umax, Vmax);
				}
			public void WindowFit(int Xmin,int Ymin,int Xmax,int Ymax)
				{
					V3d_View_WindowFit8C6D7843(Instance, Xmin, Ymin, Xmax, Ymax);
				}
			public void SetViewingVolume(double Left,double Right,double Bottom,double Top,double ZNear,double ZFar)
				{
					V3d_View_SetViewingVolumeBC7A5786(Instance, Left, Right, Bottom, Top, ZNear, ZFar);
				}
			public void SetViewMappingDefault()
				{
					V3d_View_SetViewMappingDefault(Instance);
				}
			public void ResetViewMapping()
				{
					V3d_View_ResetViewMapping(Instance);
				}
			public void Reset(bool update)
				{
					V3d_View_Reset461FC46A(Instance, update);
				}
			public double Convert(int Vp)
				{
					return V3d_View_ConvertE8219145(Instance, Vp);
				}
			public void Convert(int Xp,int Yp,ref double Xv,ref double Yv)
				{
					V3d_View_ConvertB83D31A8(Instance, Xp, Yp, ref Xv, ref Yv);
				}
			public int Convert(double Vv)
				{
					return V3d_View_ConvertD82819F3(Instance, Vv);
				}
			public void Convert(double Xv,double Yv,ref int Xp,ref int Yp)
				{
					V3d_View_Convert852507E(Instance, Xv, Yv, ref Xp, ref Yp);
				}
			public void Convert(int Xp,int Yp,ref double X,ref double Y,ref double Z)
				{
					V3d_View_Convert636CFDD5(Instance, Xp, Yp, ref X, ref Y, ref Z);
				}
			public void ConvertWithProj(int Xp,int Yp,ref double X,ref double Y,ref double Z,ref double Vx,ref double Vy,ref double Vz)
				{
					V3d_View_ConvertWithProj67C254F0(Instance, Xp, Yp, ref X, ref Y, ref Z, ref Vx, ref Vy, ref Vz);
				}
			public void ConvertToGrid(int Xp,int Yp,ref double Xg,ref double Yg,ref double Zg)
				{
					V3d_View_ConvertToGrid636CFDD5(Instance, Xp, Yp, ref Xg, ref Yg, ref Zg);
				}
			public void ConvertToGrid(double X,double Y,double Z,ref double Xg,ref double Yg,ref double Zg)
				{
					V3d_View_ConvertToGridBC7A5786(Instance, X, Y, Z, ref Xg, ref Yg, ref Zg);
				}
			public void Convert(double X,double Y,double Z,ref int Xp,ref int Yp)
				{
					V3d_View_Convert94A49759(Instance, X, Y, Z, ref Xp, ref Yp);
				}
			public void Project(double X,double Y,double Z,ref double Xp,ref double Yp)
				{
					V3d_View_Project216AF150(Instance, X, Y, Z, ref Xp, ref Yp);
				}
			public void BackgroundColor(QuantityTypeOfColor Type,ref double V1,ref double V2,ref double V3)
				{
					V3d_View_BackgroundColor638950E1(Instance, (int)Type, ref V1, ref V2, ref V3);
				}
			public QuantityColor BackgroundColor()
				{
					return new QuantityColor(V3d_View_BackgroundColor(Instance));
				}
			public void GradientBackgroundColors(QuantityColor Color1,QuantityColor Color2)
				{
					V3d_View_GradientBackgroundColorsCF0F9433(Instance, Color1.Instance, Color2.Instance);
				}
			public void AxialScale(ref double Sx,ref double Sy,ref double Sz)
				{
					V3d_View_AxialScale9282A951(Instance, ref Sx, ref Sy, ref Sz);
				}
			public void Center(ref double Xc,ref double Yc)
				{
					V3d_View_Center9F0E714F(Instance, ref Xc, ref Yc);
				}
			public void Size(ref double Width,ref double Height)
				{
					V3d_View_Size9F0E714F(Instance, ref Width, ref Height);
				}
			public void Eye(ref double X,ref double Y,ref double Z)
				{
					V3d_View_Eye9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void FocalReferencePoint(ref double X,ref double Y,ref double Z)
				{
					V3d_View_FocalReferencePoint9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void ProjReferenceAxe(int Xpix,int Ypix,ref double XP,ref double YP,ref double ZP,ref double VX,ref double VY,ref double VZ)
				{
					V3d_View_ProjReferenceAxe67C254F0(Instance, Xpix, Ypix, ref XP, ref YP, ref ZP, ref VX, ref VY, ref VZ);
				}
			public void Proj(ref double Vx,ref double Vy,ref double Vz)
				{
					V3d_View_Proj9282A951(Instance, ref Vx, ref Vy, ref Vz);
				}
			public void At(ref double X,ref double Y,ref double Z)
				{
					V3d_View_At9282A951(Instance, ref X, ref Y, ref Z);
				}
			public void Up(ref double Vx,ref double Vy,ref double Vz)
				{
					V3d_View_Up9282A951(Instance, ref Vx, ref Vy, ref Vz);
				}
			public bool ZCueing(ref double Depth,ref double Width)
				{
					return V3d_View_ZCueing9F0E714F(Instance, ref Depth, ref Width);
				}
			public V3dTypeOfZclipping ZClipping(ref double Depth,ref double Width)
				{
					return (V3dTypeOfZclipping)V3d_View_ZClipping9F0E714F(Instance, ref Depth, ref Width);
				}
			public void InitActiveLights()
				{
					V3d_View_InitActiveLights(Instance);
				}
			public void NextActiveLights()
				{
					V3d_View_NextActiveLights(Instance);
				}
			public void InitActivePlanes()
				{
					V3d_View_InitActivePlanes(Instance);
				}
			public void NextActivePlanes()
				{
					V3d_View_NextActivePlanes(Instance);
				}
			public AspectWindow Window()
				{
					return new AspectWindow(V3d_View_Window(Instance));
				}
			public void Pan(int Dx,int Dy,double aZoomFactor)
				{
					V3d_View_Pan83917674(Instance, Dx, Dy, aZoomFactor);
				}
			public void Zoom(int X1,int Y1,int X2,int Y2)
				{
					V3d_View_Zoom8C6D7843(Instance, X1, Y1, X2, Y2);
				}
			public void Zoom(int X,int Y)
				{
					V3d_View_Zoom5107F6FE(Instance, X, Y);
				}
			public void StartZoomAtPoint(int xpix,int ypix)
				{
					V3d_View_StartZoomAtPoint5107F6FE(Instance, xpix, ypix);
				}
			public void ZoomAtPoint(int mouseStartX,int mouseStartY,int mouseEndX,int mouseEndY)
				{
					V3d_View_ZoomAtPoint8C6D7843(Instance, mouseStartX, mouseStartY, mouseEndX, mouseEndY);
				}
			public void AxialScale(int Dx,int Dy,V3dTypeOfAxe Axis)
				{
					V3d_View_AxialScaleB5EB7D2C(Instance, Dx, Dy, (int)Axis);
				}
			public void StartRotation(int X,int Y,double zRotationThreshold)
				{
					V3d_View_StartRotation83917674(Instance, X, Y, zRotationThreshold);
				}
			public void Rotation(int X,int Y)
				{
					V3d_View_Rotation5107F6FE(Instance, X, Y);
				}
			public bool TransientManagerBeginDraw(bool DoubleBuffer,bool RetainMode)
				{
					return V3d_View_TransientManagerBeginDrawAE8C3818(Instance, DoubleBuffer, RetainMode);
				}
			public void TransientManagerClearDraw()
				{
					V3d_View_TransientManagerClearDraw(Instance);
				}
			public void SetAnimationModeOn()
				{
					V3d_View_SetAnimationModeOn(Instance);
				}
			public void SetAnimationModeOff()
				{
					V3d_View_SetAnimationModeOff(Instance);
				}
			public void SetDegenerateModeOn()
				{
					V3d_View_SetDegenerateModeOn(Instance);
				}
			public void SetDegenerateModeOff()
				{
					V3d_View_SetDegenerateModeOff(Instance);
				}
			public void WindowFitAll(int Xmin,int Ymin,int Xmax,int Ymax)
				{
					V3d_View_WindowFitAll8C6D7843(Instance, Xmin, Ymin, Xmax, Ymax);
				}
			public void Plot()
				{
					V3d_View_Plot(Instance);
				}
			public void SetGrid(gpAx3 aPlane,AspectGrid aGrid)
				{
					V3d_View_SetGridA01EB949(Instance, aPlane.Instance, aGrid.Instance);
				}
			public double Tumble(int NbImages,bool AnimationMode)
				{
					return V3d_View_Tumble898DAFFC(Instance, NbImages, AnimationMode);
				}
			public bool Print(IntPtr hPrnDC,bool showDialog,bool showBackground,string filename,AspectPrintAlgo printAlgorithm)
				{
					return V3d_View_Print4B7FA157(Instance, hPrnDC, showDialog, showBackground, filename, (int)printAlgorithm);
				}
			public void EnableDepthTest(bool enable)
				{
					V3d_View_EnableDepthTest461FC46A(Instance, enable);
				}
			public void EnableGLLight(bool enable)
				{
					V3d_View_EnableGLLight461FC46A(Instance, enable);
				}
		public bool IsEmpty{
			get {
				return V3d_View_IsEmpty(Instance);
			}
		}
		public double ZClippingDepth{
			set { 
				V3d_View_SetZClippingDepth(Instance, value);
			}
		}
		public double ZClippingWidth{
			set { 
				V3d_View_SetZClippingWidth(Instance, value);
			}
		}
		public V3dTypeOfZclipping ZClippingType{
			set { 
				V3d_View_SetZClippingType(Instance, (int)value);
			}
		}
		public double ZCueingDepth{
			set { 
				V3d_View_SetZCueingDepth(Instance, value);
			}
		}
		public double ZCueingWidth{
			set { 
				V3d_View_SetZCueingWidth(Instance, value);
			}
		}
		public V3dLayerMgr LayerMgr{
			set { 
				V3d_View_SetLayerMgr(Instance, value.Instance);
			}
		}
		public bool ColorScaleIsDisplayed{
			get {
				return V3d_View_ColorScaleIsDisplayed(Instance);
			}
		}
		public double Scale{
			set { 
				V3d_View_SetScale(Instance, value);
			}
			get {
				return V3d_View_Scale(Instance);
			}
		}
		public double ZSize{
			set { 
				V3d_View_SetZSize(Instance, value);
			}
			get {
				return V3d_View_ZSize(Instance);
			}
		}
		public double Depth{
			set { 
				V3d_View_SetDepth(Instance, value);
			}
			get {
				return V3d_View_Depth(Instance);
			}
		}
		public double Twist{
			set { 
				V3d_View_SetTwist(Instance, value);
			}
			get {
				return V3d_View_Twist(Instance);
			}
		}
		public V3dTypeOfShadingModel ShadingModel{
			set { 
				V3d_View_SetShadingModel(Instance, (int)value);
			}
			get {
				return (V3dTypeOfShadingModel)V3d_View_ShadingModel(Instance);
			}
		}
		public V3dTypeOfSurfaceDetail SurfaceDetail{
			set { 
				V3d_View_SetSurfaceDetail(Instance, (int)value);
			}
			get {
				return (V3dTypeOfSurfaceDetail)V3d_View_SurfaceDetail(Instance);
			}
		}
		public bool Transparency{
			set { 
				V3d_View_SetTransparency(Instance, value);
			}
			get {
				return V3d_View_Transparency(Instance);
			}
		}
		public V3dTypeOfVisualization Visualization{
			set { 
				V3d_View_SetVisualization(Instance, (int)value);
			}
			get {
				return (V3dTypeOfVisualization)V3d_View_Visualization(Instance);
			}
		}
		public bool Antialiasing{
			get {
				return V3d_View_Antialiasing(Instance);
			}
		}
		public bool IfMoreLights{
			get {
				return V3d_View_IfMoreLights(Instance);
			}
		}
		public bool MoreActiveLights{
			get {
				return V3d_View_MoreActiveLights(Instance);
			}
		}
		public V3dLight ActiveLight{
			get {
				return new V3dLight(V3d_View_ActiveLight(Instance));
			}
		}
		public bool IfMorePlanes{
			get {
				return V3d_View_IfMorePlanes(Instance);
			}
		}
		public bool MoreActivePlanes{
			get {
				return V3d_View_MoreActivePlanes(Instance);
			}
		}
		public V3dPlane ActivePlane{
			get {
				return new V3dPlane(V3d_View_ActivePlane(Instance));
			}
		}
		public V3dViewer Viewer{
			get {
				return new V3dViewer(V3d_View_Viewer(Instance));
			}
		}
		public bool IfWindow{
			get {
				return V3d_View_IfWindow(Instance);
			}
		}
		public V3dTypeOfView Type{
			get {
				return (V3dTypeOfView)V3d_View_Type(Instance);
			}
		}
		public double Focale{
			set { 
				V3d_View_SetFocale(Instance, value);
			}
			get {
				return V3d_View_Focale(Instance);
			}
		}
		public Visual3dView View{
			get {
				return new Visual3dView(V3d_View_View(Instance));
			}
		}
		public Visual3dViewMapping ViewMapping{
			set { 
				V3d_View_SetViewMapping(Instance, value.Instance);
			}
			get {
				return new Visual3dViewMapping(V3d_View_ViewMapping(Instance));
			}
		}
		public Visual3dViewOrientation ViewOrientation{
			set { 
				V3d_View_SetViewOrientation(Instance, value.Instance);
			}
			get {
				return new Visual3dViewOrientation(V3d_View_ViewOrientation(Instance));
			}
		}
		public bool TransientManagerBeginAddDraw{
			get {
				return V3d_View_TransientManagerBeginAddDraw(Instance);
			}
		}
		public bool AnimationModeIsOn{
			get {
				return V3d_View_AnimationModeIsOn(Instance);
			}
		}
		public bool DegenerateModeIsOn{
			get {
				return V3d_View_DegenerateModeIsOn(Instance);
			}
		}
		public bool ComputedMode{
			set { 
				V3d_View_SetComputedMode(Instance, value);
			}
			get {
				return V3d_View_ComputedMode(Instance);
			}
		}
		public Graphic3dPlotter Plotter{
			set { 
				V3d_View_SetPlotter(Instance, value.Instance);
			}
		}
		public AspectGrid GridGraphicValues{
			set { 
				V3d_View_SetGridGraphicValues(Instance, value.Instance);
			}
		}
		public bool GridActivity{
			set { 
				V3d_View_SetGridActivity(Instance, value);
			}
		}
		public V3dTypeOfProjectionModel ProjModel{
			set { 
				V3d_View_SetProjModel(Instance, (int)value);
			}
			get {
				return (V3dTypeOfProjectionModel)V3d_View_ProjModel(Instance);
			}
		}
		public V3dTypeOfBackfacingModel BackFacingModel{
			set { 
				V3d_View_SetBackFacingModel(Instance, (int)value);
			}
			get {
				return (V3dTypeOfBackfacingModel)V3d_View_BackFacingModel(Instance);
			}
		}
		public bool IsDepthTestEnabled{
			get {
				return V3d_View_IsDepthTestEnabled(Instance);
			}
		}
		public bool IsGLLightEnabled{
			get {
				return V3d_View_IsGLLightEnabled(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetWindow6DD76FB2(IntPtr instance, IntPtr IdWin);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetMagnifyD520CBEE(IntPtr instance, IntPtr IdWin,IntPtr aPreviousView,int x1,int y1,int x2,int y2);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Remove(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Update(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Redraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Redraw8C6D7843(IntPtr instance, int x,int y,int width,int height);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_MustBeResized(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_DoMapping(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_UpdateLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBackgroundColor638950E1(IntPtr instance, int Type,double V1,double V2,double V3);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBackgroundColor8FD7F48(IntPtr instance, IntPtr Color);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBackgroundColor48F4F471(IntPtr instance, int Name);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBgGradientColorsA313F140(IntPtr instance, IntPtr Color1,IntPtr Color2,int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBgGradientColors4216A027(IntPtr instance, int Color1,int Color2,int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBgGradientStyle86DFD8CC(IntPtr instance, int AMethod,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBackgroundImage5C59B37F(IntPtr instance, string FileName,int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBgImageStyle254163A9(IntPtr instance, int FillStyle,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAxisBC7A5786(IntPtr instance, double X,double Y,double Z,double Vx,double Vy,double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAntialiasingOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAntialiasingOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZCueingOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZCueingOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetLightOn1C16FAC6(IntPtr instance, IntPtr MyLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetLightOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetLightOff1C16FAC6(IntPtr instance, IntPtr MyLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetLightOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IsActiveLight1C16FAC6(IntPtr instance, IntPtr aLight);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetPlaneOn20B19CEF(IntPtr instance, IntPtr MyPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetPlaneOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetPlaneOff20B19CEF(IntPtr instance, IntPtr MyPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetPlaneOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IsActivePlane20B19CEF(IntPtr instance, IntPtr aPlane);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ZBufferTriedronSetup9BCB825E(IntPtr instance, int XColor,int YColor,int ZColor,double SizeRatio,double AxisDiametr,int NbFacettes);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TriedronDisplay4E80490A(IntPtr instance, int APosition,int AColor,double AScale,int AMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TriedronErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TriedronEcho14CB0F5D(IntPtr instance, int AType);
        //[DllImport("NaroOccCore.dll")]
        //private static extern void V3d_View_GetGraduatedTrihedronC3638B35(IntPtr instance, IntPtr xname,IntPtr yname,IntPtr zname,ref bool xdrawname,ref bool ydrawname,ref bool zdrawname,ref bool xdrawvalues,ref bool ydrawvalues,ref bool zdrawvalues,ref bool drawgrid,ref bool drawaxes,ref int nbx,ref int nby,ref int nbz,ref int xoffset,ref int yoffset,ref int zoffset,ref int xaxisoffset,ref int yaxisoffset,ref int zaxisoffset,ref bool xdrawtickmarks,ref bool ydrawtickmarks,ref bool zdrawtickmarks,ref int xtickmarklength,ref int ytickmarklength,ref int ztickmarklength,IntPtr gridcolor,IntPtr xnamecolor,IntPtr ynamecolor,IntPtr znamecolor,IntPtr xcolor,IntPtr ycolor,IntPtr zcolor,IntPtr fontOfNames,ref int styleOfNames,ref int sizeOfNames,IntPtr fontOfValues,ref int styleOfValues,ref int sizeOfValues);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_GraduatedTrihedronDisplayC3638B35(IntPtr instance, IntPtr xname,IntPtr yname,IntPtr zname,bool xdrawname,bool ydrawname,bool zdrawname,bool xdrawvalues,bool ydrawvalues,bool zdrawvalues,bool drawgrid,bool drawaxes,int nbx,int nby,int nbz,int xoffset,int yoffset,int zoffset,int xaxisoffset,int yaxisoffset,int zaxisoffset,bool xdrawtickmarks,bool ydrawtickmarks,bool zdrawtickmarks,int xtickmarklength,int ytickmarklength,int ztickmarklength,IntPtr gridcolor,IntPtr xnamecolor,IntPtr ynamecolor,IntPtr znamecolor,IntPtr xcolor,IntPtr ycolor,IntPtr zcolor,IntPtr fontOfNames,int styleOfNames,int sizeOfNames,IntPtr fontOfValues,int styleOfValues,int sizeOfValues);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_GraduatedTrihedronErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ColorScaleDisplay(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ColorScaleErase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetFront(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Rotate1B801FD4(IntPtr instance, double Ax,double Ay,double Az,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Rotate51E06B8D(IntPtr instance, double Ax,double Ay,double Az,double X,double Y,double Z,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Rotate45D32271(IntPtr instance, int Axe,double Angle,double X,double Y,double Z,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_RotateB8D50DF4(IntPtr instance, int Axe,double Angle,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_RotateC85E5E0F(IntPtr instance, double Angle,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Move1B801FD4(IntPtr instance, double Dx,double Dy,double Dz,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_MoveB8D50DF4(IntPtr instance, int Axe,double Length,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_MoveC85E5E0F(IntPtr instance, double Length,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Translate1B801FD4(IntPtr instance, double Dx,double Dy,double Dz,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TranslateB8D50DF4(IntPtr instance, int Axe,double Length,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TranslateC85E5E0F(IntPtr instance, double Length,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Place83917674(IntPtr instance, int x,int y,double aZoomFactor);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Turn1B801FD4(IntPtr instance, double Ax,double Ay,double Az,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TurnB8D50DF4(IntPtr instance, int Axe,double Angle,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TurnC85E5E0F(IntPtr instance, double Angle,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetEye9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetProj9282A951(IntPtr instance, double Vx,double Vy,double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetProj17AA5025(IntPtr instance, int Orientation);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAt9282A951(IntPtr instance, double X,double Y,double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetUp9282A951(IntPtr instance, double Vx,double Vy,double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetUp17AA5025(IntPtr instance, int Orientation);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetViewOrientationDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ResetViewOrientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Panning1B801FD4(IntPtr instance, double Dx,double Dy,double aZoomFactor,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetCenter9F0E714F(IntPtr instance, double Xc,double Yc);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetCenter5107F6FE(IntPtr instance, int X,int Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetSizeD82819F3(IntPtr instance, double Size);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZoomC85E5E0F(IntPtr instance, double Coef,bool Start);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAxialScale9282A951(IntPtr instance, double Sx,double Sy,double Sz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_FitAll7B00BEA(IntPtr instance, double Coef,bool FitZ,bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ZFitAllD82819F3(IntPtr instance, double Coef);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_DepthFitAll9F0E714F(IntPtr instance, double Aspect,double Margin);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_FitAllC2777E0C(IntPtr instance, double Umin,double Vmin,double Umax,double Vmax);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_WindowFit8C6D7843(IntPtr instance, int Xmin,int Ymin,int Xmax,int Ymax);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetViewingVolumeBC7A5786(IntPtr instance, double Left,double Right,double Bottom,double Top,double ZNear,double ZFar);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetViewMappingDefault(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ResetViewMapping(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Reset461FC46A(IntPtr instance, bool update);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_ConvertE8219145(IntPtr instance, int Vp);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ConvertB83D31A8(IntPtr instance, int Xp,int Yp,ref double Xv,ref double Yv);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_ConvertD82819F3(IntPtr instance, double Vv);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Convert852507E(IntPtr instance, double Xv,double Yv,ref int Xp,ref int Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Convert636CFDD5(IntPtr instance, int Xp,int Yp,ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ConvertWithProj67C254F0(IntPtr instance, int Xp,int Yp,ref double X,ref double Y,ref double Z,ref double Vx,ref double Vy,ref double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ConvertToGrid636CFDD5(IntPtr instance, int Xp,int Yp,ref double Xg,ref double Yg,ref double Zg);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ConvertToGridBC7A5786(IntPtr instance, double X,double Y,double Z,ref double Xg,ref double Yg,ref double Zg);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Convert94A49759(IntPtr instance, double X,double Y,double Z,ref int Xp,ref int Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Project216AF150(IntPtr instance, double X,double Y,double Z,ref double Xp,ref double Yp);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_BackgroundColor638950E1(IntPtr instance, int Type,ref double V1,ref double V2,ref double V3);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_BackgroundColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_GradientBackgroundColorsCF0F9433(IntPtr instance, IntPtr Color1,IntPtr Color2);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_AxialScale9282A951(IntPtr instance, ref double Sx,ref double Sy,ref double Sz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Center9F0E714F(IntPtr instance, ref double Xc,ref double Yc);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Size9F0E714F(IntPtr instance, ref double Width,ref double Height);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Eye9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_FocalReferencePoint9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ProjReferenceAxe67C254F0(IntPtr instance, int Xpix,int Ypix,ref double XP,ref double YP,ref double ZP,ref double VX,ref double VY,ref double VZ);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Proj9282A951(IntPtr instance, ref double Vx,ref double Vy,ref double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_At9282A951(IntPtr instance, ref double X,ref double Y,ref double Z);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Up9282A951(IntPtr instance, ref double Vx,ref double Vy,ref double Vz);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_ZCueing9F0E714F(IntPtr instance, ref double Depth,ref double Width);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_ZClipping9F0E714F(IntPtr instance, ref double Depth,ref double Width);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_InitActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_NextActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_InitActivePlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_NextActivePlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_Window(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Pan83917674(IntPtr instance, int Dx,int Dy,double aZoomFactor);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Zoom8C6D7843(IntPtr instance, int X1,int Y1,int X2,int Y2);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Zoom5107F6FE(IntPtr instance, int X,int Y);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_StartZoomAtPoint5107F6FE(IntPtr instance, int xpix,int ypix);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_ZoomAtPoint8C6D7843(IntPtr instance, int mouseStartX,int mouseStartY,int mouseEndX,int mouseEndY);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_AxialScaleB5EB7D2C(IntPtr instance, int Dx,int Dy,int Axis);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_StartRotation83917674(IntPtr instance, int X,int Y,double zRotationThreshold);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Rotation5107F6FE(IntPtr instance, int X,int Y);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_TransientManagerBeginDrawAE8C3818(IntPtr instance, bool DoubleBuffer,bool RetainMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_TransientManagerClearDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAnimationModeOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetAnimationModeOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetDegenerateModeOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetDegenerateModeOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_WindowFitAll8C6D7843(IntPtr instance, int Xmin,int Ymin,int Xmax,int Ymax);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_Plot(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetGridA01EB949(IntPtr instance, IntPtr aPlane,IntPtr aGrid);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_Tumble898DAFFC(IntPtr instance, int NbImages,bool AnimationMode);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_Print4B7FA157(IntPtr instance, IntPtr hPrnDC,bool showDialog,bool showBackground,string filename,int printAlgorithm);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_EnableDepthTest461FC46A(IntPtr instance, bool enable);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_EnableGLLight461FC46A(IntPtr instance, bool enable);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IsEmpty(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZClippingDepth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZClippingWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZClippingType(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZCueingDepth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZCueingWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetLayerMgr(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_ColorScaleIsDisplayed(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetScale(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_Scale(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetZSize(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_ZSize(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetDepth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_Depth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetTwist(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_Twist(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetShadingModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_ShadingModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetSurfaceDetail(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_SurfaceDetail(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetTransparency(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_Transparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetVisualization(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_Visualization(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_Antialiasing(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IfMoreLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_MoreActiveLights(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_ActiveLight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IfMorePlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_MoreActivePlanes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_ActivePlane(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_Viewer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IfWindow(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetFocale(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double V3d_View_Focale(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_View(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetViewMapping(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_ViewMapping(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetViewOrientation(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr V3d_View_ViewOrientation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_TransientManagerBeginAddDraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_AnimationModeIsOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_DegenerateModeIsOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetComputedMode(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_ComputedMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetPlotter(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetGridGraphicValues(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetGridActivity(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetProjModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_ProjModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void V3d_View_SetBackFacingModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int V3d_View_BackFacingModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IsDepthTestEnabled(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool V3d_View_IsGLLightEnabled(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public V3dView() { } 

		public V3dView(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ V3dView_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void V3dView_Dtor(IntPtr instance);
	}
}
