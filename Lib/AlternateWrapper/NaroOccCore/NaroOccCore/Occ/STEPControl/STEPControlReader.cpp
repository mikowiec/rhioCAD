#include "STEPControlReader.h"
#include <STEPControl_Reader.hxx>


DECL_EXPORT void* STEPControl_Reader_Ctor()
{
	return new STEPControl_Reader();
}
DECL_EXPORT void* STEPControl_Reader_CtorC53309E3(
	void* WS,
	bool scratch)
{
		const Handle_XSControl_WorkSession&  _WS =*(const Handle_XSControl_WorkSession *)WS;
	return new STEPControl_Reader(			
_WS,			
scratch);
}
DECL_EXPORT bool STEPControl_Reader_TransferRootE8219145(
	void* instance,
	int num)
{
	STEPControl_Reader* result = (STEPControl_Reader*)instance;
	return  	result->TransferRoot(			
num);
}
DECL_EXPORT int STEPControl_Reader_NbRootsForTransfer(void* instance)
{
	STEPControl_Reader* result = (STEPControl_Reader*)instance;
	return 	result->NbRootsForTransfer();
}

DECL_EXPORT void STEPControlReader_Dtor(void* instance)
{
	delete (STEPControl_Reader*)instance;
}
