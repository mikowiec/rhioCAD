#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.Message
{
	public class MessageProgressScale : NativeInstancePtr
	{
		public MessageProgressScale()
 :
			base(Message_ProgressScale_Ctor() )
		{}
			public void SetName(string theName)
				{
					Message_ProgressScale_SetName9381D4D(Instance, theName);
				}
			public void SetName(TCollectionHAsciiString theName)
				{
					Message_ProgressScale_SetNameB439B3D5(Instance, theName.Instance);
				}
			public void SetRange(double min,double max)
				{
					Message_ProgressScale_SetRange9F0E714F(Instance, min, max);
				}
			public void SetScale(double min,double max,double step,bool theInfinite)
				{
					Message_ProgressScale_SetScale1B801FD4(Instance, min, max, step, theInfinite);
				}
			public void SetSpan(double first,double last)
				{
					Message_ProgressScale_SetSpan9F0E714F(Instance, first, last);
				}
			public double LocalToBase(double val)
				{
					return Message_ProgressScale_LocalToBaseD82819F3(Instance, val);
				}
			public double BaseToLocal(double val)
				{
					return Message_ProgressScale_BaseToLocalD82819F3(Instance, val);
				}
		public TCollectionHAsciiString GetName{
			get {
				return new TCollectionHAsciiString(Message_ProgressScale_GetName(Instance));
			}
		}
		public double Min{
			set { 
				Message_ProgressScale_SetMin(Instance, value);
			}
		}
		public double GetMin{
			get {
				return Message_ProgressScale_GetMin(Instance);
			}
		}
		public double Max{
			set { 
				Message_ProgressScale_SetMax(Instance, value);
			}
		}
		public double GetMax{
			get {
				return Message_ProgressScale_GetMax(Instance);
			}
		}
		public double Step{
			set { 
				Message_ProgressScale_SetStep(Instance, value);
			}
		}
		public double GetStep{
			get {
				return Message_ProgressScale_GetStep(Instance);
			}
		}
		public bool Infinite{
			set { 
				Message_ProgressScale_SetInfinite(Instance, value);
			}
		}
		public bool GetInfinite{
			get {
				return Message_ProgressScale_GetInfinite(Instance);
			}
		}
		public double GetFirst{
			get {
				return Message_ProgressScale_GetFirst(Instance);
			}
		}
		public double GetLast{
			get {
				return Message_ProgressScale_GetLast(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_ProgressScale_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetName9381D4D(IntPtr instance, string theName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetNameB439B3D5(IntPtr instance, IntPtr theName);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetRange9F0E714F(IntPtr instance, double min,double max);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetScale1B801FD4(IntPtr instance, double min,double max,double step,bool theInfinite);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetSpan9F0E714F(IntPtr instance, double first,double last);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_LocalToBaseD82819F3(IntPtr instance, double val);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_BaseToLocalD82819F3(IntPtr instance, double val);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_ProgressScale_GetName(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetMin(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_GetMin(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetMax(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_GetMax(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetStep(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_GetStep(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressScale_SetInfinite(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressScale_GetInfinite(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_GetFirst(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressScale_GetLast(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MessageProgressScale(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MessageProgressScale_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MessageProgressScale_Dtor(IntPtr instance);
	}
}
