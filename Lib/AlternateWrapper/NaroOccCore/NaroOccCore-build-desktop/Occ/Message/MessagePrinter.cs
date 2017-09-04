#region Usings

using System;
using System.Runtime.InteropServices;
using NaroCppCore.Core;
using NaroCppCore.Occ.MMgt;
using NaroCppCore.Occ.Message;
using NaroCppCore.Occ.TCollection;

#endregion

namespace NaroCppCore.Occ.Message
{
	public class MessagePrinter : MMgtTShared
	{
			public void Send(string theString,MessageGravity theGravity,bool putEndl)
				{
					Message_Printer_Send1267EA5A(Instance, theString, (int)theGravity, putEndl);
				}
			public void Send(TCollectionAsciiString theString,MessageGravity theGravity,bool putEndl)
				{
					Message_Printer_SendB37427E3(Instance, theString.Instance, (int)theGravity, putEndl);
				}
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_Printer_Send1267EA5A(IntPtr instance, string theString,int theGravity,bool putEndl);
		[DllImport("NaroOccCore.dll")]
		private static extern void Message_Printer_SendB37427E3(IntPtr instance, IntPtr theString,int theGravity,bool putEndl);

		#region NativeInstancePtr Convert constructor

		public MessagePrinter() { } 

		public MessagePrinter(IntPtr instance) : base(instance) { } 

		protected override void DeleteSelf()
		{ MessagePrinter_Dtor(Instance); }

		#endregion

		[DllImport("NaroOccCore.dll")]
		private static extern void MessagePrinter_Dtor(IntPtr instance);
	}
}
