#include "TColStdSequenceOfInteger.h"
#include <TColStd_SequenceOfInteger.hxx>

#include <TColStd_SequenceOfInteger.hxx>

DECL_EXPORT void* TColStd_SequenceOfInteger_Ctor()
{
	return new TColStd_SequenceOfInteger();
}
DECL_EXPORT void* TColStd_SequenceOfInteger_AssignE22FA26(
	void* instance,
	void* Other)
{
	TColStd_SequenceOfInteger* data = new TColStd_SequenceOfInteger();
		const TColStd_SequenceOfInteger &  _Other =*(const TColStd_SequenceOfInteger *)Other;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
	*data =	result->Assign(			
_Other);
	return data;
}
DECL_EXPORT void TColStd_SequenceOfInteger_AppendE8219145(
	void* instance,
	int T)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Append(			
T);
}
DECL_EXPORT void TColStd_SequenceOfInteger_AppendE22FA26(
	void* instance,
	void* S)
{
		TColStd_SequenceOfInteger &  _S =*(TColStd_SequenceOfInteger *)S;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Append(			
_S);
}
DECL_EXPORT void TColStd_SequenceOfInteger_PrependE8219145(
	void* instance,
	int T)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Prepend(			
T);
}
DECL_EXPORT void TColStd_SequenceOfInteger_PrependE22FA26(
	void* instance,
	void* S)
{
		TColStd_SequenceOfInteger &  _S =*(TColStd_SequenceOfInteger *)S;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Prepend(			
_S);
}
DECL_EXPORT void TColStd_SequenceOfInteger_InsertBefore5107F6FE(
	void* instance,
	int Index,
	int T)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->InsertBefore(			
Index,			
T);
}
DECL_EXPORT void TColStd_SequenceOfInteger_InsertBefore20E7A93A(
	void* instance,
	int Index,
	void* S)
{
		TColStd_SequenceOfInteger &  _S =*(TColStd_SequenceOfInteger *)S;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->InsertBefore(			
Index,			
_S);
}
DECL_EXPORT void TColStd_SequenceOfInteger_InsertAfter5107F6FE(
	void* instance,
	int Index,
	int T)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->InsertAfter(			
Index,			
T);
}
DECL_EXPORT void TColStd_SequenceOfInteger_InsertAfter20E7A93A(
	void* instance,
	int Index,
	void* S)
{
		TColStd_SequenceOfInteger &  _S =*(TColStd_SequenceOfInteger *)S;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->InsertAfter(			
Index,			
_S);
}
DECL_EXPORT void TColStd_SequenceOfInteger_Split20E7A93A(
	void* instance,
	int Index,
	void* Sub)
{
		TColStd_SequenceOfInteger &  _Sub =*(TColStd_SequenceOfInteger *)Sub;
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Split(			
Index,			
_Sub);
}
DECL_EXPORT int TColStd_SequenceOfInteger_ValueE8219145(
	void* instance,
	int Index)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
	return  	result->Value(			
Index);
}
DECL_EXPORT void TColStd_SequenceOfInteger_SetValue5107F6FE(
	void* instance,
	int Index,
	int I)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->SetValue(			
Index,			
I);
}
DECL_EXPORT int TColStd_SequenceOfInteger_ChangeValueE8219145(
	void* instance,
	int Index)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
	return  	result->ChangeValue(			
Index);
}
DECL_EXPORT void TColStd_SequenceOfInteger_RemoveE8219145(
	void* instance,
	int Index)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Remove(			
Index);
}
DECL_EXPORT void TColStd_SequenceOfInteger_Remove5107F6FE(
	void* instance,
	int FromIndex,
	int ToIndex)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
 	result->Remove(			
FromIndex,			
ToIndex);
}
DECL_EXPORT int TColStd_SequenceOfInteger_First(void* instance)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
	return 	result->First();
}

DECL_EXPORT int TColStd_SequenceOfInteger_Last(void* instance)
{
	TColStd_SequenceOfInteger* result = (TColStd_SequenceOfInteger*)instance;
	return 	result->Last();
}

DECL_EXPORT void TColStdSequenceOfInteger_Dtor(void* instance)
{
	delete (TColStd_SequenceOfInteger*)instance;
}
