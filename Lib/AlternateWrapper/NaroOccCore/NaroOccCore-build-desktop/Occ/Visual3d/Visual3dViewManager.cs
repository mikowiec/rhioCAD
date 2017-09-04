#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.Graphic3d;
using NaroCppCore.Occ.Visual3d;
using NaroCppCore.Occ.Aspect;
using NaroCppCore.Occ.TColStd;

#endregion

namespace NaroCppCore.Occ.Visual3d
{
	public class Visual3dViewManager : Graphic3dStructureManager
	{
		public Visual3dViewManager(AspectGraphicDevice aDevice)
 :
			base(Visual3d_ViewManager_CtorAC5012C4(aDevice.Instance) )
		{}
			public void Activate()
				{
					Visual3d_ViewManager_Activate(Instance);
				}
			public void Deactivate()
				{
					Visual3d_ViewManager_Deactivate(Instance);
				}
			public void Erase()
				{
					Visual3d_ViewManager_Erase(Instance);
				}
			public void Redraw()
				{
					Visual3d_ViewManager_Redraw(Instance);
				}
			public void Remove()
				{
					Visual3d_ViewManager_Remove(Instance);
				}
			public void Update()
				{
					Visual3d_ViewManager_Update(Instance);
				}
			public void ConvertCoord(AspectWindow AWindow,Graphic3dVertex AVertex,ref int AU,ref int AV)
				{
					Visual3d_ViewManager_ConvertCoord8C15567E(Instance, AWindow.Instance, AVertex.Instance, ref AU, ref AV);
				}
			public Graphic3dVertex ConvertCoord(AspectWindow AWindow,int AU,int AV)
				{
					return new Graphic3dVertex(Visual3d_ViewManager_ConvertCoord6DDFCDA0(Instance, AWindow.Instance, AU, AV));
				}
			public void ConvertCoordWithProj(AspectWindow AWindow,int AU,int AV,Graphic3dVertex Point,Graphic3dVector Proj)
				{
					Visual3d_ViewManager_ConvertCoordWithProj4FF6C2D0(Instance, AWindow.Instance, AU, AV, Point.Instance, Proj.Instance);
				}
			public int Identification(Visual3dView AView)
				{
					return Visual3d_ViewManager_Identification68FD189(Instance, AView.Instance);
				}
			public void UnIdentification(int aViewId)
				{
					Visual3d_ViewManager_UnIdentificationE8219145(Instance, aViewId);
				}
			public int Identification()
				{
					return Visual3d_ViewManager_Identification(Instance);
				}
			public bool AddZLayer(ref int theLayerId)
				{
					return Visual3d_ViewManager_AddZLayerE8219145(Instance, ref theLayerId);
				}
			public bool RemoveZLayer(int theLayerId)
				{
					return Visual3d_ViewManager_RemoveZLayerE8219145(Instance, theLayerId);
				}
			public void GetAllZLayers(TColStdSequenceOfInteger theLayerSeq)
				{
					Visual3d_ViewManager_GetAllZLayersE22FA26(Instance, theLayerSeq.Instance);
				}
			public void UnHighlight()
				{
					Visual3d_ViewManager_UnHighlight(Instance);
				}
		public int MaxNumOfViews{
			get {
				return Visual3d_ViewManager_MaxNumOfViews(Instance);
			}
		}
		public Visual3dLayer UnderLayer{
			get {
				return new Visual3dLayer(Visual3d_ViewManager_UnderLayer(Instance));
			}
		}
		public Visual3dLayer OverLayer{
			get {
				return new Visual3dLayer(Visual3d_ViewManager_OverLayer(Instance));
			}
		}
		public bool Transparency{
			set { 
				Visual3d_ViewManager_SetTransparency(Instance, value);
			}
			get {
				return Visual3d_ViewManager_Transparency(Instance);
			}
		}
		public bool ZBufferAuto{
			set { 
				Visual3d_ViewManager_SetZBufferAuto(Instance, value);
			}
			get {
				return Visual3d_ViewManager_ZBufferAuto(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewManager_CtorAC5012C4(IntPtr aDevice);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Activate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Deactivate(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Erase(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Redraw(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Remove(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_Update(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_ConvertCoord8C15567E(IntPtr instance, IntPtr AWindow,IntPtr AVertex,ref int AU,ref int AV);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewManager_ConvertCoord6DDFCDA0(IntPtr instance, IntPtr AWindow,int AU,int AV);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_ConvertCoordWithProj4FF6C2D0(IntPtr instance, IntPtr AWindow,int AU,int AV,IntPtr Point,IntPtr Proj);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ViewManager_Identification68FD189(IntPtr instance, IntPtr AView);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_UnIdentificationE8219145(IntPtr instance, int aViewId);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ViewManager_Identification(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewManager_AddZLayerE8219145(IntPtr instance, ref int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewManager_RemoveZLayerE8219145(IntPtr instance, int theLayerId);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_GetAllZLayersE22FA26(IntPtr instance, IntPtr theLayerSeq);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_UnHighlight(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Visual3d_ViewManager_MaxNumOfViews(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewManager_UnderLayer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Visual3d_ViewManager_OverLayer(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_SetTransparency(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewManager_Transparency(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3d_ViewManager_SetZBufferAuto(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Visual3d_ViewManager_ZBufferAuto(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public Visual3dViewManager() { } 

		public Visual3dViewManager(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ Visual3dViewManager_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void Visual3dViewManager_Dtor(IntPtr instance);
	}
}
