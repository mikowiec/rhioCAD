#include "MessagePrinter.h"
#include <Message_Printer.hxx>


DECL_EXPORT void Message_Printer_Send1267EA5A(
	void* instance,
	char* theString,
	int theGravity,
	bool putEndl)
{
		const Message_Gravity _theGravity =(const Message_Gravity )theGravity;
	Message_Printer* result = (Message_Printer*)(((Handle_Message_Printer*)instance)->Access());
 	result->Send(			
theString,			
_theGravity,			
putEndl);
}
DECL_EXPORT void Message_Printer_SendB37427E3(
	void* instance,
	void* theString,
	int theGravity,
	bool putEndl)
{
		const TCollection_AsciiString &  _theString =*(const TCollection_AsciiString *)theString;
		const Message_Gravity _theGravity =(const Message_Gravity )theGravity;
	Message_Printer* result = (Message_Printer*)(((Handle_Message_Printer*)instance)->Access());
 	result->Send(			
_theString,			
_theGravity,			
putEndl);
}
DECL_EXPORT void MessagePrinter_Dtor(void* instance)
{
	delete (Handle_Message_Printer*)instance;
}
