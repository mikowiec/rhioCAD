#include "IntToolsShrunkRange.h"
#include <IntTools_ShrunkRange.hxx>

#include <Bnd_Box.hxx>
#include <IntTools_Range.hxx>
#include <TopoDS_Edge.hxx>

DECL_EXPORT void* IntTools_ShrunkRange_Ctor()
{
	return new IntTools_ShrunkRange();
}
DECL_EXPORT void IntTools_ShrunkRange_Perform(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
 	result->Perform();
}
DECL_EXPORT void IntTools_ShrunkRange_SetShrunkRange(void* instance, void* value)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
		result->SetShrunkRange(*(const IntTools_Range *)value);
}

DECL_EXPORT void* IntTools_ShrunkRange_ShrunkRange(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
	return 	new IntTools_Range(	result->ShrunkRange());
}

DECL_EXPORT void* IntTools_ShrunkRange_BndBox(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
	return 	new Bnd_Box(	result->BndBox());
}

DECL_EXPORT void* IntTools_ShrunkRange_Edge(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
	return 	new TopoDS_Edge(	result->Edge());
}

DECL_EXPORT bool IntTools_ShrunkRange_IsDone(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
	return 	result->IsDone();
}

DECL_EXPORT int IntTools_ShrunkRange_ErrorStatus(void* instance)
{
	IntTools_ShrunkRange* result = (IntTools_ShrunkRange*)instance;
	return 	result->ErrorStatus();
}

DECL_EXPORT void IntToolsShrunkRange_Dtor(void* instance)
{
	delete (IntTools_ShrunkRange*)instance;
}
