#ifndef Message_Msg_H
#define Message_Msg_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Message_Msg_Ctor();
extern "C" DECL_EXPORT void* Message_Msg_Ctor46FB5B4A(
	void* theMsg);
extern "C" DECL_EXPORT void* Message_Msg_Ctor9381D4D(
	char* theKey);
extern "C" DECL_EXPORT void* Message_Msg_Ctor6EE6EE89(
	void* theKey);
extern "C" DECL_EXPORT void Message_Msg_Set9381D4D(
	void* instance,
	char* theMsg);
extern "C" DECL_EXPORT void Message_Msg_Set6EE6EE89(
	void* instance,
	void* theMsg);
extern "C" DECL_EXPORT void* Message_Msg_Arg9381D4D(
	void* instance,
	char* theString);
extern "C" DECL_EXPORT void* Message_Msg_Arg66CFACD0(
	void* instance,
	void* theString);
extern "C" DECL_EXPORT void* Message_Msg_ArgB439B3D5(
	void* instance,
	void* theString);
extern "C" DECL_EXPORT void* Message_Msg_Arg6EE6EE89(
	void* instance,
	void* theString);
extern "C" DECL_EXPORT void* Message_Msg_Arg4C6BF532(
	void* instance,
	void* theString);
extern "C" DECL_EXPORT void* Message_Msg_ArgE8219145(
	void* instance,
	int theInt);
extern "C" DECL_EXPORT void* Message_Msg_ArgD82819F3(
	void* instance,
	double theReal);
extern "C" DECL_EXPORT void* Message_Msg_Original(void* instance);
extern "C" DECL_EXPORT void* Message_Msg_Value(void* instance);
extern "C" DECL_EXPORT bool Message_Msg_IsEdited(void* instance);
extern "C" DECL_EXPORT void* Message_Msg_Get(void* instance);
extern "C" DECL_EXPORT void MessageMsg_Dtor(void* instance);

#endif
