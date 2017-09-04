#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Message;

#endregion

namespace NaroCppCore.Occ.Message
{
	public class MessageProgressIndicator : MMgtTShared
	{
			public void Reset()
				{
					Message_ProgressIndicator_Reset(Instance);
				}
			public void SetName(string name)
				{
					Message_ProgressIndicator_SetName9381D4D(Instance, name);
				}
			public void SetName(TCollectionHAsciiString name)
				{
					Message_ProgressIndicator_SetNameB439B3D5(Instance, name.Instance);
				}
			public void SetRange(double min,double max)
				{
					Message_ProgressIndicator_SetRange9F0E714F(Instance, min, max);
				}
			public void SetScale(string name,double min,double max,double step,bool isInf)
				{
					Message_ProgressIndicator_SetScale13FE3006(Instance, name, min, max, step, isInf);
				}
			public void SetScale(double min,double max,double step,bool isInf)
				{
					Message_ProgressIndicator_SetScale1B801FD4(Instance, min, max, step, isInf);
				}
			public void Increment()
				{
					Message_ProgressIndicator_Increment(Instance);
				}
			public void Increment(double step)
				{
					Message_ProgressIndicator_IncrementD82819F3(Instance, step);
				}
			public bool NewScope(string name)
				{
					return Message_ProgressIndicator_NewScope9381D4D(Instance, name);
				}
			public bool NewScope(TCollectionHAsciiString name)
				{
					return Message_ProgressIndicator_NewScopeB439B3D5(Instance, name.Instance);
				}
			public bool NewScope(double span,string name)
				{
					return Message_ProgressIndicator_NewScopeFEB27313(Instance, span, name);
				}
			public bool NewScope(double span,TCollectionHAsciiString name)
				{
					return Message_ProgressIndicator_NewScope9A242015(Instance, span, name.Instance);
				}
			public bool NextScope(string name)
				{
					return Message_ProgressIndicator_NextScope9381D4D(Instance, name);
				}
			public bool NextScope(double span,string name)
				{
					return Message_ProgressIndicator_NextScopeFEB27313(Instance, span, name);
				}
			public MessageProgressScale GetScope(int index)
				{
					return new MessageProgressScale(Message_ProgressIndicator_GetScopeE8219145(Instance, index));
				}
		public double Step{
			set { 
				Message_ProgressIndicator_SetStep(Instance, value);
			}
		}
		public bool Infinite{
			set { 
				Message_ProgressIndicator_SetInfinite(Instance, value);
			}
		}
		public double Value{
			set { 
				Message_ProgressIndicator_SetValue(Instance, value);
			}
		}
		public double GetValue{
			get {
				return Message_ProgressIndicator_GetValue(Instance);
			}
		}
		public bool EndScope{
			get {
				return Message_ProgressIndicator_EndScope(Instance);
			}
		}
		public bool UserBreak{
			get {
				return Message_ProgressIndicator_UserBreak(Instance);
			}
		}
		public double GetPosition{
			get {
				return Message_ProgressIndicator_GetPosition(Instance);
			}
		}
		public int GetNbScopes{
			get {
				return Message_ProgressIndicator_GetNbScopes(Instance);
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_Reset(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetName9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetNameB439B3D5(IntPtr instance, IntPtr name);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetRange9F0E714F(IntPtr instance, double min,double max);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetScale13FE3006(IntPtr instance, string name,double min,double max,double step,bool isInf);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetScale1B801FD4(IntPtr instance, double min,double max,double step,bool isInf);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_Increment(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_IncrementD82819F3(IntPtr instance, double step);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NewScope9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NewScopeB439B3D5(IntPtr instance, IntPtr name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NewScopeFEB27313(IntPtr instance, double span,string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NewScope9A242015(IntPtr instance, double span,IntPtr name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NextScope9381D4D(IntPtr instance, string name);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_NextScopeFEB27313(IntPtr instance, double span,string name);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_ProgressIndicator_GetScopeE8219145(IntPtr instance, int index);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetStep(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetInfinite(IntPtr instance, bool value);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_ProgressIndicator_SetValue(IntPtr instance, double value);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressIndicator_GetValue(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_EndScope(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_ProgressIndicator_UserBreak(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern double Message_ProgressIndicator_GetPosition(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern int Message_ProgressIndicator_GetNbScopes(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MessageProgressIndicator() { } 

		public MessageProgressIndicator(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MessageProgressIndicator_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MessageProgressIndicator_Dtor(IntPtr instance);
	}
}
