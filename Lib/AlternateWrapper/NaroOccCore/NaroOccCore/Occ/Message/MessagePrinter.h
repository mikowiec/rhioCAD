#ifndef Message_Printer_H
#define Message_Printer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void Message_Printer_Send1267EA5A(
	void* instance,
	char* theString,
	int theGravity,
	bool putEndl);
extern "C" DECL_EXPORT void Message_Printer_SendB37427E3(
	void* instance,
	void* theString,
	int theGravity,
	bool putEndl);
extern "C" DECL_EXPORT void MessagePrinter_Dtor(void* instance);

#endif
