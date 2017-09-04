#include "BOPToolsPaveBlock.h"
#include <BOPTools_PaveBlock.hxx>

#include <BOPTools_Pave.hxx>
#include <BOPTools_PointBetween.hxx>
#include <IntTools_Curve.hxx>
#include <IntTools_Range.hxx>
#include <IntTools_ShrunkRange.hxx>

DECL_EXPORT void* BOPTools_PaveBlock_Ctor()
{
	return new BOPTools_PaveBlock();
}
DECL_EXPORT void* BOPTools_PaveBlock_Ctor9182DAFF(
	int anEdge,
	void* aPave1,
	void* aPave2)
{
		const BOPTools_Pave &  _aPave1 =*(const BOPTools_Pave *)aPave1;
		const BOPTools_Pave &  _aPave2 =*(const BOPTools_Pave *)aPave2;
	return new BOPTools_PaveBlock(			
anEdge,			
_aPave1,			
_aPave2);
}
DECL_EXPORT bool BOPTools_PaveBlock_IsEqual36FC67E4(
	void* instance,
	void* Other)
{
		const BOPTools_PaveBlock &  _Other =*(const BOPTools_PaveBlock *)Other;
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT void BOPTools_PaveBlock_Parameters9F0E714F(
	void* instance,
	double* aT1,
	double* aT2)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
 	result->Parameters(			
*aT1,			
*aT2);
}
DECL_EXPORT bool BOPTools_PaveBlock_IsInBlock3EED610E(
	void* instance,
	void* aPaveX)
{
		const BOPTools_Pave &  _aPaveX =*(const BOPTools_Pave *)aPaveX;
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return  	result->IsInBlock(			
_aPaveX);
}
DECL_EXPORT void BOPTools_PaveBlock_SetEdge(void* instance, int value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetEdge(value);
}

DECL_EXPORT int BOPTools_PaveBlock_Edge(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	result->Edge();
}

DECL_EXPORT void BOPTools_PaveBlock_SetOriginalEdge(void* instance, int value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetOriginalEdge(value);
}

DECL_EXPORT int BOPTools_PaveBlock_OriginalEdge(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	result->OriginalEdge();
}

DECL_EXPORT void BOPTools_PaveBlock_SetPave1(void* instance, void* value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetPave1(*(const BOPTools_Pave *)value);
}

DECL_EXPORT void* BOPTools_PaveBlock_Pave1(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new BOPTools_Pave(	result->Pave1());
}

DECL_EXPORT void BOPTools_PaveBlock_SetPave2(void* instance, void* value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetPave2(*(const BOPTools_Pave *)value);
}

DECL_EXPORT void* BOPTools_PaveBlock_Pave2(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new BOPTools_Pave(	result->Pave2());
}

DECL_EXPORT bool BOPTools_PaveBlock_IsValid(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	result->IsValid();
}

DECL_EXPORT void* BOPTools_PaveBlock_Range(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new IntTools_Range(	result->Range());
}

DECL_EXPORT void BOPTools_PaveBlock_SetShrunkRange(void* instance, void* value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetShrunkRange(*(const IntTools_ShrunkRange *)value);
}

DECL_EXPORT void* BOPTools_PaveBlock_ShrunkRange(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new IntTools_ShrunkRange(	result->ShrunkRange());
}

DECL_EXPORT void BOPTools_PaveBlock_SetPointBetween(void* instance, void* value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetPointBetween(*(const BOPTools_PointBetween *)value);
}

DECL_EXPORT void* BOPTools_PaveBlock_PointBetween(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new BOPTools_PointBetween(	result->PointBetween());
}

DECL_EXPORT void BOPTools_PaveBlock_SetCurve(void* instance, void* value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetCurve(*(const IntTools_Curve *)value);
}

DECL_EXPORT void* BOPTools_PaveBlock_Curve(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	new IntTools_Curve(	result->Curve());
}

DECL_EXPORT void BOPTools_PaveBlock_SetFace1(void* instance, int value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetFace1(value);
}

DECL_EXPORT int BOPTools_PaveBlock_Face1(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	result->Face1();
}

DECL_EXPORT void BOPTools_PaveBlock_SetFace2(void* instance, int value)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
		result->SetFace2(value);
}

DECL_EXPORT int BOPTools_PaveBlock_Face2(void* instance)
{
	BOPTools_PaveBlock* result = (BOPTools_PaveBlock*)instance;
	return 	result->Face2();
}

DECL_EXPORT void BOPToolsPaveBlock_Dtor(void* instance)
{
	delete (BOPTools_PaveBlock*)instance;
}
