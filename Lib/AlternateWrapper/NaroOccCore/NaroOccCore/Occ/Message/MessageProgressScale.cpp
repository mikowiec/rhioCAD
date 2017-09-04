#include "MessageProgressScale.h"
#include <Message_ProgressScale.hxx>

#include <TCollection_HAsciiString.hxx>

DECL_EXPORT void* Message_ProgressScale_Ctor()
{
	return new Message_ProgressScale();
}
DECL_EXPORT void Message_ProgressScale_SetName9381D4D(
	void* instance,
	char* theName)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
 	result->SetName(			
theName);
}
DECL_EXPORT void Message_ProgressScale_SetNameB439B3D5(
	void* instance,
	void* theName)
{
		const Handle_TCollection_HAsciiString&  _theName =*(const Handle_TCollection_HAsciiString *)theName;
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
 	result->SetName(			
_theName);
}
DECL_EXPORT void Message_ProgressScale_SetRange9F0E714F(
	void* instance,
	double min,
	double max)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
 	result->SetRange(			
min,			
max);
}
DECL_EXPORT void Message_ProgressScale_SetScale1B801FD4(
	void* instance,
	double min,
	double max,
	double step,
	bool theInfinite)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
 	result->SetScale(			
min,			
max,			
step,			
theInfinite);
}
DECL_EXPORT void Message_ProgressScale_SetSpan9F0E714F(
	void* instance,
	double first,
	double last)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
 	result->SetSpan(			
first,			
last);
}
DECL_EXPORT double Message_ProgressScale_LocalToBaseD82819F3(
	void* instance,
	double val)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return  	result->LocalToBase(			
val);
}
DECL_EXPORT double Message_ProgressScale_BaseToLocalD82819F3(
	void* instance,
	double val)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return  	result->BaseToLocal(			
val);
}
DECL_EXPORT void* Message_ProgressScale_GetName(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	new Handle_TCollection_HAsciiString(	result->GetName());
}

DECL_EXPORT void Message_ProgressScale_SetMin(void* instance, double value)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
		result->SetMin(value);
}

DECL_EXPORT double Message_ProgressScale_GetMin(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetMin();
}

DECL_EXPORT void Message_ProgressScale_SetMax(void* instance, double value)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
		result->SetMax(value);
}

DECL_EXPORT double Message_ProgressScale_GetMax(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetMax();
}

DECL_EXPORT void Message_ProgressScale_SetStep(void* instance, double value)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
		result->SetStep(value);
}

DECL_EXPORT double Message_ProgressScale_GetStep(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetStep();
}

DECL_EXPORT void Message_ProgressScale_SetInfinite(void* instance, bool value)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
		result->SetInfinite(value);
}

DECL_EXPORT bool Message_ProgressScale_GetInfinite(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetInfinite();
}

DECL_EXPORT double Message_ProgressScale_GetFirst(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetFirst();
}

DECL_EXPORT double Message_ProgressScale_GetLast(void* instance)
{
	Message_ProgressScale* result = (Message_ProgressScale*)instance;
	return 	result->GetLast();
}

DECL_EXPORT void MessageProgressScale_Dtor(void* instance)
{
	delete (Message_ProgressScale*)instance;
}
