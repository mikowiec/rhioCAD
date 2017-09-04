#include "MessageProgressIndicator.h"
#include <Message_ProgressIndicator.hxx>

#include <Message_ProgressScale.hxx>

DECL_EXPORT void Message_ProgressIndicator_Reset(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->Reset();
}
DECL_EXPORT void Message_ProgressIndicator_SetName9381D4D(
	void* instance,
	char* name)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->SetName(			
name);
}
DECL_EXPORT void Message_ProgressIndicator_SetNameB439B3D5(
	void* instance,
	void* name)
{
		const Handle_TCollection_HAsciiString&  _name =*(const Handle_TCollection_HAsciiString *)name;
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->SetName(			
_name);
}
DECL_EXPORT void Message_ProgressIndicator_SetRange9F0E714F(
	void* instance,
	double min,
	double max)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->SetRange(			
min,			
max);
}
DECL_EXPORT void Message_ProgressIndicator_SetScale13FE3006(
	void* instance,
	char* name,
	double min,
	double max,
	double step,
	bool isInf)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->SetScale(			
name,			
min,			
max,			
step,			
isInf);
}
DECL_EXPORT void Message_ProgressIndicator_SetScale1B801FD4(
	void* instance,
	double min,
	double max,
	double step,
	bool isInf)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->SetScale(			
min,			
max,			
step,			
isInf);
}
DECL_EXPORT void Message_ProgressIndicator_Increment(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->Increment();
}
DECL_EXPORT void Message_ProgressIndicator_IncrementD82819F3(
	void* instance,
	double step)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
 	result->Increment(			
step);
}
DECL_EXPORT bool Message_ProgressIndicator_NewScope9381D4D(
	void* instance,
	char* name)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NewScope(			
name);
}
DECL_EXPORT bool Message_ProgressIndicator_NewScopeB439B3D5(
	void* instance,
	void* name)
{
		const Handle_TCollection_HAsciiString&  _name =*(const Handle_TCollection_HAsciiString *)name;
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NewScope(			
_name);
}
DECL_EXPORT bool Message_ProgressIndicator_NewScopeFEB27313(
	void* instance,
	double span,
	char* name)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NewScope(			
span,			
name);
}
DECL_EXPORT bool Message_ProgressIndicator_NewScope9A242015(
	void* instance,
	double span,
	void* name)
{
		const Handle_TCollection_HAsciiString&  _name =*(const Handle_TCollection_HAsciiString *)name;
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NewScope(			
span,			
_name);
}
DECL_EXPORT bool Message_ProgressIndicator_NextScope9381D4D(
	void* instance,
	char* name)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NextScope(			
name);
}
DECL_EXPORT bool Message_ProgressIndicator_NextScopeFEB27313(
	void* instance,
	double span,
	char* name)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return  	result->NextScope(			
span,			
name);
}
DECL_EXPORT void* Message_ProgressIndicator_GetScopeE8219145(
	void* instance,
	int index)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return new Message_ProgressScale( 	result->GetScope(			
index));
}
DECL_EXPORT void Message_ProgressIndicator_SetStep(void* instance, double value)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
		result->SetStep(value);
}

DECL_EXPORT void Message_ProgressIndicator_SetInfinite(void* instance, bool value)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
		result->SetInfinite(value);
}

DECL_EXPORT void Message_ProgressIndicator_SetValue(void* instance, double value)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
		result->SetValue(value);
}

DECL_EXPORT double Message_ProgressIndicator_GetValue(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return 	result->GetValue();
}

DECL_EXPORT bool Message_ProgressIndicator_EndScope(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return 	result->EndScope();
}

DECL_EXPORT bool Message_ProgressIndicator_UserBreak(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return 	result->UserBreak();
}

DECL_EXPORT double Message_ProgressIndicator_GetPosition(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return 	result->GetPosition();
}

DECL_EXPORT int Message_ProgressIndicator_GetNbScopes(void* instance)
{
	Message_ProgressIndicator* result = (Message_ProgressIndicator*)(((Handle_Message_ProgressIndicator*)instance)->Access());
	return 	result->GetNbScopes();
}

DECL_EXPORT void MessageProgressIndicator_Dtor(void* instance)
{
	delete (Handle_Message_ProgressIndicator*)instance;
}
