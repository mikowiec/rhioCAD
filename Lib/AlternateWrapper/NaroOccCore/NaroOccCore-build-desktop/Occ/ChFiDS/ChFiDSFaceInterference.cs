#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TopAbs;

#endregion

namespace NaroCppCore.Occ.ChFiDS
{
	public class ChFiDSFaceInterference : NativeInstancePtr
	{
		public ChFiDSFaceInterference()
 :
			base(ChFiDS_FaceInterference_Ctor() )
		{}
			public void SetParameter(double U1,bool IsFirst)
				{
					ChFiDS_FaceInterference_SetParameterC85E5E0F(Instance, U1, IsFirst);
				}
			public double Parameter(bool IsFirst)
				{
					return ChFiDS_FaceInterference_Parameter461FC46A(Instance, IsFirst);
				}
		public int LineIndex{
			set { 
				ChFiDS_FaceInterference_SetLineIndex(Instance, value);
			}
			get {
				return ChFiDS_FaceInterference_LineIndex(Instance);
			}
		}
		public TopAbsOrientation Transition{
			set { 
				ChFiDS_FaceInterference_SetTransition(Instance, (int)value);
			}
			get {
				return (TopAbsOrientation)ChFiDS_FaceInterference_Transition(Instance);
			}
		}
		public double FirstParameter{
			set { 
				ChFiDS_FaceInterference_SetFirstParameter(Instance, value);
			}
			get {
				return ChFiDS_FaceInterference_FirstParameter(Instance);
			}
		}
		public double LastParameter{
			set { 
				ChFiDS_FaceInterference_SetLastParameter(Instance, value);
			}
			get {
				return ChFiDS_FaceInterference_LastParameter(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr ChFiDS_FaceInterference_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_FaceInterference_SetParameterC85E5E0F(IntPtr instance, double U1,bool IsFirst);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_FaceInterference_Parameter461FC46A(IntPtr instance, bool IsFirst);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_FaceInterference_SetLineIndex(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_FaceInterference_LineIndex(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_FaceInterference_SetTransition(IntPtr instance, int value);
		[DllImport("NaroOccCore.dll")]
		private static extern int ChFiDS_FaceInterference_Transition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_FaceInterference_SetFirstParameter(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_FaceInterference_FirstParameter(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDS_FaceInterference_SetLastParameter(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double ChFiDS_FaceInterference_LastParameter(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public ChFiDSFaceInterference(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ ChFiDSFaceInterference_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void ChFiDSFaceInterference_Dtor(IntPtr instance);
	}
}
