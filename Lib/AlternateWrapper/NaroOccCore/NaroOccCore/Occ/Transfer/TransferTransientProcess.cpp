#include "TransferTransientProcess.h"
#include <Transfer_TransientProcess.hxx>

#include <Dico_DictionaryOfTransient.hxx>

DECL_EXPORT void* Transfer_TransientProcess_CtorE8219145(
	int nb)
{
	return new Handle_Transfer_TransientProcess(new Transfer_TransientProcess(			
nb));
}
DECL_EXPORT void* Transfer_TransientProcess_Context(void* instance)
{
	Transfer_TransientProcess* result = (Transfer_TransientProcess*)(((Handle_Transfer_TransientProcess*)instance)->Access());
	return new Handle_Dico_DictionaryOfTransient( 	result->Context());
}
DECL_EXPORT bool Transfer_TransientProcess_HasGraph(void* instance)
{
	Transfer_TransientProcess* result = (Transfer_TransientProcess*)(((Handle_Transfer_TransientProcess*)instance)->Access());
	return 	result->HasGraph();
}

DECL_EXPORT void TransferTransientProcess_Dtor(void* instance)
{
	delete (Handle_Transfer_TransientProcess*)instance;
}
