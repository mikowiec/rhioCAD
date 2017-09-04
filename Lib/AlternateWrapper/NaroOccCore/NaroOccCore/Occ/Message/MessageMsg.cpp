#include "MessageMsg.h"
#include <Message_Msg.hxx>

#include <Message_Msg.hxx>
#include <TCollection_ExtendedString.hxx>

DECL_EXPORT void* Message_Msg_Ctor()
{
	return new Message_Msg();
}
DECL_EXPORT void* Message_Msg_Ctor46FB5B4A(
	void* theMsg)
{
		const Message_Msg &  _theMsg =*(const Message_Msg *)theMsg;
	return new Message_Msg(			
_theMsg);
}
DECL_EXPORT void* Message_Msg_Ctor9381D4D(
	char* theKey)
{
	return new Message_Msg(			
theKey);
}
DECL_EXPORT void* Message_Msg_Ctor6EE6EE89(
	void* theKey)
{
		const TCollection_ExtendedString &  _theKey =*(const TCollection_ExtendedString *)theKey;
	return new Message_Msg(			
_theKey);
}
DECL_EXPORT void Message_Msg_Set9381D4D(
	void* instance,
	char* theMsg)
{
	Message_Msg* result = (Message_Msg*)instance;
 	result->Set(			
theMsg);
}
DECL_EXPORT void Message_Msg_Set6EE6EE89(
	void* instance,
	void* theMsg)
{
		const TCollection_ExtendedString &  _theMsg =*(const TCollection_ExtendedString *)theMsg;
	Message_Msg* result = (Message_Msg*)instance;
 	result->Set(			
_theMsg);
}
DECL_EXPORT void* Message_Msg_Arg9381D4D(
	void* instance,
	char* theString)
{
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
theString));
}
DECL_EXPORT void* Message_Msg_Arg66CFACD0(
	void* instance,
	void* theString)
{
		const TCollection_AsciiString &  _theString =*(const TCollection_AsciiString *)theString;
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
_theString));
}
DECL_EXPORT void* Message_Msg_ArgB439B3D5(
	void* instance,
	void* theString)
{
		const Handle_TCollection_HAsciiString&  _theString =*(const Handle_TCollection_HAsciiString *)theString;
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
_theString));
}
DECL_EXPORT void* Message_Msg_Arg6EE6EE89(
	void* instance,
	void* theString)
{
		const TCollection_ExtendedString &  _theString =*(const TCollection_ExtendedString *)theString;
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
_theString));
}
DECL_EXPORT void* Message_Msg_Arg4C6BF532(
	void* instance,
	void* theString)
{
		const Handle_TCollection_HExtendedString&  _theString =*(const Handle_TCollection_HExtendedString *)theString;
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
_theString));
}
DECL_EXPORT void* Message_Msg_ArgE8219145(
	void* instance,
	int theInt)
{
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
theInt));
}
DECL_EXPORT void* Message_Msg_ArgD82819F3(
	void* instance,
	double theReal)
{
	Message_Msg* result = (Message_Msg*)instance;
	return new Message_Msg( 	result->Arg(			
theReal));
}
DECL_EXPORT void* Message_Msg_Original(void* instance)
{
	Message_Msg* result = (Message_Msg*)instance;
	return 	new TCollection_ExtendedString(	result->Original());
}

DECL_EXPORT void* Message_Msg_Value(void* instance)
{
	Message_Msg* result = (Message_Msg*)instance;
	return 	new TCollection_ExtendedString(	result->Value());
}

DECL_EXPORT bool Message_Msg_IsEdited(void* instance)
{
	Message_Msg* result = (Message_Msg*)instance;
	return 	result->IsEdited();
}

DECL_EXPORT void* Message_Msg_Get(void* instance)
{
	Message_Msg* result = (Message_Msg*)instance;
	return 	new TCollection_ExtendedString(	result->Get());
}

DECL_EXPORT void MessageMsg_Dtor(void* instance)
{
	delete (Message_Msg*)instance;
}
