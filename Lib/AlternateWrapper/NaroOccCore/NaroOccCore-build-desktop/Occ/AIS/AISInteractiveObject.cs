#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.SelectMgr;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.Standard;
using NaroCppCore.Occ.Quantity;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Geom;
using NaroCppCore.Occ.Prs3d;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISInteractiveObject : SelectMgrSelectableObject
	{
			public void SetColor(QuantityColor aColor)
				{
					AIS_InteractiveObject_SetColor8FD7F48(Instance, aColor.Instance);
				}
			public void SetColor(QuantityNameOfColor aColor)
				{
					AIS_InteractiveObject_SetColor48F4F471(Instance, (int)aColor);
				}
			public void UnsetColor()
				{
					AIS_InteractiveObject_UnsetColor(Instance);
				}
			public void UnsetWidth()
				{
					AIS_InteractiveObject_UnsetWidth(Instance);
				}
			public bool AcceptDisplayMode(int aMode)
				{
					return AIS_InteractiveObject_AcceptDisplayModeE8219145(Instance, aMode);
				}
			public void Redisplay(bool AllModes)
				{
					AIS_InteractiveObject_Redisplay461FC46A(Instance, AllModes);
				}
			public void ClearOwner()
				{
					AIS_InteractiveObject_ClearOwner(Instance);
				}
			public void AddUser(StandardTransient aUser)
				{
					AIS_InteractiveObject_AddUserF411CB01(Instance, aUser.Instance);
				}
			public void ClearUsers()
				{
					AIS_InteractiveObject_ClearUsers(Instance);
				}
			public void UnsetDisplayMode()
				{
					AIS_InteractiveObject_UnsetDisplayMode(Instance);
				}
			public void UnsetSelectionMode()
				{
					AIS_InteractiveObject_UnsetSelectionMode(Instance);
				}
			public void UnsetSelectionPriority()
				{
					AIS_InteractiveObject_UnsetSelectionPriority(Instance);
				}
			public void UnsetHilightMode()
				{
					AIS_InteractiveObject_UnsetHilightMode(Instance);
				}
			public QuantityNameOfColor Color()
				{
					return (QuantityNameOfColor)AIS_InteractiveObject_Color(Instance);
				}
			public void Color(QuantityColor aColor)
				{
					AIS_InteractiveObject_Color8FD7F48(Instance, aColor.Instance);
				}
			public Graphic3dNameOfMaterial Material()
				{
					return (Graphic3dNameOfMaterial)AIS_InteractiveObject_Material(Instance);
				}
			public void SetMaterial(Graphic3dNameOfMaterial aName)
				{
					AIS_InteractiveObject_SetMaterialE047B55B(Instance, (int)aName);
				}
			public void SetMaterial(Graphic3dMaterialAspect aName)
				{
					AIS_InteractiveObject_SetMaterialC0044920(Instance, aName.Instance);
				}
			public void UnsetMaterial()
				{
					AIS_InteractiveObject_UnsetMaterial(Instance);
				}
			public void UnsetTransparency()
				{
					AIS_InteractiveObject_UnsetTransparency(Instance);
				}
			public void UnsetAttributes()
				{
					AIS_InteractiveObject_UnsetAttributes(Instance);
				}
			public void State(int theState)
				{
					AIS_InteractiveObject_StateE8219145(Instance, theState);
				}
			public int State()
				{
					return AIS_InteractiveObject_State(Instance);
				}
			public void SetDegenerateModel(AspectTypeOfDegenerateModel aModel,double aRatio)
				{
					AIS_InteractiveObject_SetDegenerateModelE6DFDFE0(Instance, (int)aModel, aRatio);
				}
			public AspectTypeOfDegenerateModel DegenerateModel(ref double aRatio)
				{
					return (AspectTypeOfDegenerateModel)AIS_InteractiveObject_DegenerateModelD82819F3(Instance, ref aRatio);
				}
			public void SetTransformation(GeomTransformation aTranformation,bool postConcatenate,bool updateSelection)
				{
					AIS_InteractiveObject_SetTransformationA067E6E8(Instance, aTranformation.Instance, postConcatenate, updateSelection);
				}
			public void UnsetTransformation()
				{
					AIS_InteractiveObject_UnsetTransformation(Instance);
				}
			public GeomTransformation Transformation()
				{
					return new GeomTransformation(AIS_InteractiveObject_Transformation(Instance));
				}
			public void SetAspect(Prs3dBasicAspect anAspect,bool globalChange)
				{
					AIS_InteractiveObject_SetAspect93F6A493(Instance, anAspect.Instance, globalChange);
				}
            //public void SetPolygonOffsets(int aMode,double aFactor,double aUnits)
            //    {
            //        AIS_InteractiveObject_SetPolygonOffsets306E0DFB(Instance, aMode, aFactor, aUnits);
            //    }
            //public void PolygonOffsets(ref int aMode,ref double aFactor,ref double aUnits)
            //    {
            //        AIS_InteractiveObject_PolygonOffsets306E0DFB(Instance, ref aMode, ref aFactor, ref aUnits);
            //    }
		public AISKindOfInteractive Type{
			get {
				return (AISKindOfInteractive)AIS_InteractiveObject_Type(Instance);
			}
		}
		public int Signature{
			get {
				return AIS_InteractiveObject_Signature(Instance);
			}
		}
		public bool AcceptShapeDecomposition{
			get {
				return AIS_InteractiveObject_AcceptShapeDecomposition(Instance);
			}
		}
		public AspectTypeOfFacingModel CurrentFacingModel{
			set { 
				AIS_InteractiveObject_SetCurrentFacingModel(Instance, (int)value);
			}
			get {
				return (AspectTypeOfFacingModel)AIS_InteractiveObject_CurrentFacingModel(Instance);
			}
		}
		public int DefaultDisplayMode{
			get {
				return AIS_InteractiveObject_DefaultDisplayMode(Instance);
			}
		}
		public bool InfiniteState{
			set { 
				AIS_InteractiveObject_SetInfiniteState(Instance, value);
			}
		}
		public bool IsInfinite{
			get {
				return AIS_InteractiveObject_IsInfinite(Instance);
			}
		}
		public bool HasInteractiveContext{
			get {
				return AIS_InteractiveObject_HasInteractiveContext(Instance);
			}
		}
		public AISInteractiveContext GetContext{
			get {
				return new AISInteractiveContext(AIS_InteractiveObject_GetContext(Instance));
			}
		}
		public AISInteractiveContext Context{
			set { 
				AIS_InteractiveObject_SetContext(Instance, value.Instance);
			}
		}
		public bool HasOwner{
			get {
				return AIS_InteractiveObject_HasOwner(Instance);
			}
		}
		public StandardTransient GetOwner{
			get {
				return new StandardTransient(AIS_InteractiveObject_GetOwner(Instance));
			}
		}
		public StandardTransient Owner{
			set { 
				AIS_InteractiveObject_SetOwner(Instance, value.Instance);
			}
		}
		public bool HasUsers{
			get {
				return AIS_InteractiveObject_HasUsers(Instance);
			}
		}
		public bool HasDisplayMode{
			get {
				return AIS_InteractiveObject_HasDisplayMode(Instance);
			}
		}
		public int DisplayMode{
			set { 
				AIS_InteractiveObject_SetDisplayMode(Instance, value);
			}
			get {
				return AIS_InteractiveObject_DisplayMode(Instance);
			}
		}
		public bool HasSelectionMode{
			get {
				return AIS_InteractiveObject_HasSelectionMode(Instance);
			}
		}
		public int SelectionMode{
			set { 
				AIS_InteractiveObject_SetSelectionMode(Instance, value);
			}
			get {
				return AIS_InteractiveObject_SelectionMode(Instance);
			}
		}
		public int SelectionPriority{
			set { 
				AIS_InteractiveObject_SetSelectionPriority(Instance, value);
			}
			get {
				return AIS_InteractiveObject_SelectionPriority(Instance);
			}
		}
		public bool HasSelectionPriority{
			get {
				return AIS_InteractiveObject_HasSelectionPriority(Instance);
			}
		}
		public bool HasHilightMode{
			get {
				return AIS_InteractiveObject_HasHilightMode(Instance);
			}
		}
		public int HilightMode{
			set { 
				AIS_InteractiveObject_SetHilightMode(Instance, value);
			}
			get {
				return AIS_InteractiveObject_HilightMode(Instance);
			}
		}
		public bool HasColor{
			get {
				return AIS_InteractiveObject_HasColor(Instance);
			}
		}
		public bool HasWidth{
			get {
				return AIS_InteractiveObject_HasWidth(Instance);
			}
		}
		public double Width{
			set { 
				AIS_InteractiveObject_SetWidth(Instance, value);
			}
			get {
				return AIS_InteractiveObject_Width(Instance);
			}
		}
		public bool HasMaterial{
			get {
				return AIS_InteractiveObject_HasMaterial(Instance);
			}
		}
		public bool IsTransparent{
			get {
				return AIS_InteractiveObject_IsTransparent(Instance);
			}
		}
		public double Transparency{
			set { 
				AIS_InteractiveObject_SetTransparency(Instance, value);
			}
			get {
				return AIS_InteractiveObject_Transparency(Instance);
			}
		}
		public AISDrawer Attributes{
			set { 
				AIS_InteractiveObject_SetAttributes(Instance, value.Instance);
			}
			get {
				return new AISDrawer(AIS_InteractiveObject_Attributes(Instance));
			}
		}
		public bool HasTransformation{
			get {
				return AIS_InteractiveObject_HasTransformation(Instance);
			}
		}
		public bool HasPresentation{
			get {
				return AIS_InteractiveObject_HasPresentation(Instance);
			}
		}
		public bool HasPolygonOffsets{
			get {
				return AIS_InteractiveObject_HasPolygonOffsets(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetColor8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetColor48F4F471(IntPtr instance, int aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_AcceptDisplayModeE8219145(IntPtr instance, int aMode);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_Redisplay461FC46A(IntPtr instance, bool AllModes);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_ClearOwner(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_AddUserF411CB01(IntPtr instance, IntPtr aUser);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_ClearUsers(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetDisplayMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetSelectionMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetSelectionPriority(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetHilightMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_Color(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_Color8FD7F48(IntPtr instance, IntPtr aColor);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_Material(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetMaterialE047B55B(IntPtr instance, int aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetMaterialC0044920(IntPtr instance, IntPtr aName);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetMaterial(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetTransparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetAttributes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_StateE8219145(IntPtr instance, int theState);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_State(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetDegenerateModelE6DFDFE0(IntPtr instance, int aModel,double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_DegenerateModelD82819F3(IntPtr instance, ref double aRatio);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetTransformationA067E6E8(IntPtr instance, IntPtr aTranformation,bool postConcatenate,bool updateSelection);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_UnsetTransformation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveObject_Transformation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetAspect93F6A493(IntPtr instance, IntPtr anAspect,bool globalChange);
        //[DllImport("NaroOccCore.dll")]
        //private static extern void AIS_InteractiveObject_SetPolygonOffsets306E0DFB(IntPtr instance, int aMode,double aFactor,double aUnits);
        //[DllImport("NaroOccCore.dll")]
        //private static extern void AIS_InteractiveObject_PolygonOffsets306E0DFB(IntPtr instance, ref int aMode,ref double aFactor,ref double aUnits);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_Type(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_Signature(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_AcceptShapeDecomposition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetCurrentFacingModel(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_CurrentFacingModel(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_DefaultDisplayMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetInfiniteState(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_IsInfinite(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasInteractiveContext(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveObject_GetContext(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetContext(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasOwner(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveObject_GetOwner(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetOwner(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasUsers(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasDisplayMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetDisplayMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_DisplayMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasSelectionMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetSelectionMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_SelectionMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetSelectionPriority(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_SelectionPriority(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasSelectionPriority(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasHilightMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetHilightMode(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int AIS_InteractiveObject_HilightMode(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasColor(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasWidth(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetWidth(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveObject_Width(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasMaterial(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_IsTransparent(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetTransparency(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_InteractiveObject_Transparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_InteractiveObject_SetAttributes(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_InteractiveObject_Attributes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasTransformation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasPresentation(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_InteractiveObject_HasPolygonOffsets(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISInteractiveObject() { } 

		public AISInteractiveObject(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISInteractiveObject_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISInteractiveObject_Dtor(IntPtr instance);
	}
}
