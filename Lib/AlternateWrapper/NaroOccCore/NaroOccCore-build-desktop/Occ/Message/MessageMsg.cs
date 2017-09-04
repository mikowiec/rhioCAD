#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.TCollection;
using NaroCppCore.Occ.Message;

#endregion

namespace NaroCppCore.Occ.Message
{
	public class MessageMsg : NativeInstancePtr
	{
		public MessageMsg()
 :
			base(Message_Msg_Ctor() )
		{}
		public MessageMsg(MessageMsg theMsg)
 :
			base(Message_Msg_Ctor46FB5B4A(theMsg.Instance) )
		{}
		public MessageMsg(string theKey)
 :
			base(Message_Msg_Ctor9381D4D(theKey) )
		{}
		public MessageMsg(TCollectionExtendedString theKey)
 :
			base(Message_Msg_Ctor6EE6EE89(theKey.Instance) )
		{}
			public void Set(string theMsg)
				{
					Message_Msg_Set9381D4D(Instance, theMsg);
				}
			public void Set(TCollectionExtendedString theMsg)
				{
					Message_Msg_Set6EE6EE89(Instance, theMsg.Instance);
				}
			public MessageMsg Arg(string theString)
				{
					return new MessageMsg(Message_Msg_Arg9381D4D(Instance, theString));
				}
			public MessageMsg Arg(TCollectionAsciiString theString)
				{
					return new MessageMsg(Message_Msg_Arg66CFACD0(Instance, theString.Instance));
				}
			public MessageMsg Arg(TCollectionHAsciiString theString)
				{
					return new MessageMsg(Message_Msg_ArgB439B3D5(Instance, theString.Instance));
				}
			public MessageMsg Arg(TCollectionExtendedString theString)
				{
					return new MessageMsg(Message_Msg_Arg6EE6EE89(Instance, theString.Instance));
				}
			public MessageMsg Arg(TCollectionHExtendedString theString)
				{
					return new MessageMsg(Message_Msg_Arg4C6BF532(Instance, theString.Instance));
				}
			public MessageMsg Arg(int theInt)
				{
					return new MessageMsg(Message_Msg_ArgE8219145(Instance, theInt));
				}
			public MessageMsg Arg(double theReal)
				{
					return new MessageMsg(Message_Msg_ArgD82819F3(Instance, theReal));
				}
		public TCollectionExtendedString Original{
			get {
				return new TCollectionExtendedString(Message_Msg_Original(Instance));
			}
		}
		public TCollectionExtendedString Value{
			get {
				return new TCollectionExtendedString(Message_Msg_Value(Instance));
			}
		}
		public bool IsEdited{
			get {
				return Message_Msg_IsEdited(Instance);
			}
		}
		public TCollectionExtendedString Get{
			get {
				return new TCollectionExtendedString(Message_Msg_Get(Instance));
			}
		}
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Ctor();
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Ctor46FB5B4A(IntPtr theMsg);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Ctor9381D4D(string theKey);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Ctor6EE6EE89(IntPtr theKey);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_Msg_Set9381D4D(IntPtr instance, string theMsg);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_Msg_Set6EE6EE89(IntPtr instance, IntPtr theMsg);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Arg9381D4D(IntPtr instance, string theString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Arg66CFACD0(IntPtr instance, IntPtr theString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_ArgB439B3D5(IntPtr instance, IntPtr theString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Arg6EE6EE89(IntPtr instance, IntPtr theString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Arg4C6BF532(IntPtr instance, IntPtr theString);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_ArgE8219145(IntPtr instance, int theInt);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_ArgD82819F3(IntPtr instance, double theReal);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Original(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Value(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern bool Message_Msg_IsEdited(IntPtr instance);
		[DllImport("NaroOccCore.dll")]
		private static extern IntPtr Message_Msg_Get(IntPtr instance);

		#region NativeInstancePtr Convert constructor

		public MessageMsg(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MessageMsg_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MessageMsg_Dtor(IntPtr instance);
	}
}
