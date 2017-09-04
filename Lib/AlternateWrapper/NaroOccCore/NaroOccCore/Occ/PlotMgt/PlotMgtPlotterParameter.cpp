#include "PlotMgtPlotterParameter.h"
#include <PlotMgt_PlotterParameter.hxx>

#include <TCollection_AsciiString.hxx>

DECL_EXPORT void* PlotMgt_PlotterParameter_Ctor66CFACD0(
	void* aName)
{
		const TCollection_AsciiString &  _aName =*(const TCollection_AsciiString *)aName;
	return new Handle_PlotMgt_PlotterParameter(new PlotMgt_PlotterParameter(			
_aName));
}
DECL_EXPORT bool PlotMgt_PlotterParameter_Save626970E9(
	void* instance,
	void* aFile)
{
		 OSD_File &  _aFile =*( OSD_File *)aFile;
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return  	result->Save(			
_aFile);
}
DECL_EXPORT void PlotMgt_PlotterParameter_SValue66CFACD0(
	void* instance,
	void* aValue)
{
		 TCollection_AsciiString &  _aValue =*( TCollection_AsciiString *)aValue;
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
 	result->SValue(			
_aValue);
}
DECL_EXPORT void PlotMgt_PlotterParameter_Dump(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
 	result->Dump();
}
DECL_EXPORT void PlotMgt_PlotterParameter_SetSValue66CFACD0(
	void* instance,
	void* aValue)
{
		const TCollection_AsciiString &  _aValue =*(const TCollection_AsciiString *)aValue;
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
 	result->SetSValue(			
_aValue);
}
DECL_EXPORT void PlotMgt_PlotterParameter_SetState(void* instance, bool value)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
		result->SetState(value);
}

DECL_EXPORT void PlotMgt_PlotterParameter_SetType(void* instance, int value)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
		result->SetType((const PlotMgt_TypeOfPlotterParameter)value);
}

DECL_EXPORT void* PlotMgt_PlotterParameter_Name(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	new TCollection_AsciiString(	result->Name());
}

DECL_EXPORT void* PlotMgt_PlotterParameter_OldName(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	new TCollection_AsciiString(	result->OldName());
}

DECL_EXPORT bool PlotMgt_PlotterParameter_NeedToBeSaved(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	result->NeedToBeSaved();
}

DECL_EXPORT void PlotMgt_PlotterParameter_SetBValue(void* instance, bool value)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
		result->SetBValue(value);
}

DECL_EXPORT bool PlotMgt_PlotterParameter_BValue(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	result->BValue();
}

DECL_EXPORT void PlotMgt_PlotterParameter_SetIValue(void* instance, int value)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
		result->SetIValue(value);
}

DECL_EXPORT int PlotMgt_PlotterParameter_IValue(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	result->IValue();
}

DECL_EXPORT void PlotMgt_PlotterParameter_SetRValue(void* instance, double value)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
		result->SetRValue(value);
}

DECL_EXPORT double PlotMgt_PlotterParameter_RValue(void* instance)
{
	PlotMgt_PlotterParameter* result = (PlotMgt_PlotterParameter*)(((Handle_PlotMgt_PlotterParameter*)instance)->Access());
	return 	result->RValue();
}

DECL_EXPORT void PlotMgtPlotterParameter_Dtor(void* instance)
{
	delete (Handle_PlotMgt_PlotterParameter*)instance;
}
