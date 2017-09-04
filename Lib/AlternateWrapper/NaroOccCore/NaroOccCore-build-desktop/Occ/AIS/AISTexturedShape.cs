#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.AIS;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.TopoDS;

#endregion

namespace NaroCppCore.Occ.AIS
{
	public class AISTexturedShape : AISShape
	{
		public AISTexturedShape(TopoDSShape shap)
 :
			base(AIS_TexturedShape_Ctor9EBAC0C0(shap.Instance) )
		{}
			public void SetTextureRepeat(bool RepeatYN,double URepeat,double VRepeat)
				{
					AIS_TexturedShape_SetTextureRepeatDA23FEE7(Instance, RepeatYN, URepeat, VRepeat);
				}
			public void SetTextureOrigin(bool SetTextureOriginYN,double UOrigin,double VOrigin)
				{
					AIS_TexturedShape_SetTextureOriginDA23FEE7(Instance, SetTextureOriginYN, UOrigin, VOrigin);
				}
			public void SetTextureScale(bool SetTextureScaleYN,double ScaleU,double ScaleV)
				{
					AIS_TexturedShape_SetTextureScaleDA23FEE7(Instance, SetTextureScaleYN, ScaleU, ScaleV);
				}
			public void SetTextureMapOn()
				{
					AIS_TexturedShape_SetTextureMapOn(Instance);
				}
			public void SetTextureMapOff()
				{
					AIS_TexturedShape_SetTextureMapOff(Instance);
				}
			public void EnableTextureModulate()
				{
					AIS_TexturedShape_EnableTextureModulate(Instance);
				}
			public void DisableTextureModulate()
				{
					AIS_TexturedShape_DisableTextureModulate(Instance);
				}
			public void UpdateAttributes()
				{
					AIS_TexturedShape_UpdateAttributes(Instance);
				}
			public bool TextureRepeat()
				{
					return AIS_TexturedShape_TextureRepeat(Instance);
				}
			public bool TextureScale()
				{
					return AIS_TexturedShape_TextureScale(Instance);
				}
			public bool TextureOrigin()
				{
					return AIS_TexturedShape_TextureOrigin(Instance);
				}
		public TCollectionAsciiString TextureFileName{
			set { 
				AIS_TexturedShape_SetTextureFileName(Instance, value.Instance);
			}
		}
		public bool TextureMapState{
			get {
				return AIS_TexturedShape_TextureMapState(Instance);
			}
		}
		public double URepeat{
			get {
				return AIS_TexturedShape_URepeat(Instance);
			}
		}
		public double Deflection{
			get {
				return AIS_TexturedShape_Deflection(Instance);
			}
		}
		public double VRepeat{
			get {
				return AIS_TexturedShape_VRepeat(Instance);
			}
		}
		public double TextureUOrigin{
			get {
				return AIS_TexturedShape_TextureUOrigin(Instance);
			}
		}
		public double TextureVOrigin{
			get {
				return AIS_TexturedShape_TextureVOrigin(Instance);
			}
		}
		public double TextureScaleU{
			get {
				return AIS_TexturedShape_TextureScaleU(Instance);
			}
		}
		public double TextureScaleV{
			get {
				return AIS_TexturedShape_TextureScaleV(Instance);
			}
		}
		public bool TextureModulate{
			get {
				return AIS_TexturedShape_TextureModulate(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr AIS_TexturedShape_Ctor9EBAC0C0(IntPtr shap);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureRepeatDA23FEE7(IntPtr instance, bool RepeatYN,double URepeat,double VRepeat);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureOriginDA23FEE7(IntPtr instance, bool SetTextureOriginYN,double UOrigin,double VOrigin);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureScaleDA23FEE7(IntPtr instance, bool SetTextureScaleYN,double ScaleU,double ScaleV);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureMapOn(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureMapOff(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_EnableTextureModulate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_DisableTextureModulate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_UpdateAttributes(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_TexturedShape_TextureRepeat(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_TexturedShape_TextureScale(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_TexturedShape_TextureOrigin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void AIS_TexturedShape_SetTextureFileName(IntPtr instance, IntPtr value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_TexturedShape_TextureMapState(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_URepeat(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_Deflection(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_VRepeat(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_TextureUOrigin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_TextureVOrigin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_TextureScaleU(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double AIS_TexturedShape_TextureScaleV(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool AIS_TexturedShape_TextureModulate(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public AISTexturedShape() { } 

		public AISTexturedShape(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ AISTexturedShape_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void AISTexturedShape_Dtor(IntPtr instance);
	}
}
