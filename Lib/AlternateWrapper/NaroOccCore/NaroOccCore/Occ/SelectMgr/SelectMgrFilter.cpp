#include "SelectMgrFilter.h"
#include <SelectMgr_Filter.hxx>


DECL_EXPORT bool SelectMgr_Filter_ActsOnC6FD32C4(
	void* instance,
	int aStandardMode)
{
		const TopAbs_ShapeEnum _aStandardMode =(const TopAbs_ShapeEnum )aStandardMode;
	SelectMgr_Filter* result = (SelectMgr_Filter*)(((Handle_SelectMgr_Filter*)instance)->Access());
	return  	result->ActsOn(			
_aStandardMode);
}
DECL_EXPORT void SelectMgrFilter_Dtor(void* instance)
{
	delete (Handle_SelectMgr_Filter*)instance;
}
