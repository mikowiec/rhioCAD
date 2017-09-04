#include "BOPToolsCommonBlock.h"
#include <BOPTools_CommonBlock.hxx>

#include <BOPTools_PaveBlock.hxx>

DECL_EXPORT void* BOPTools_CommonBlock_Ctor()
{
	return new BOPTools_CommonBlock();
}
DECL_EXPORT void* BOPTools_CommonBlock_CtorA5B57975(
	void* aPB1,
	void* aPB2)
{
		const BOPTools_PaveBlock &  _aPB1 =*(const BOPTools_PaveBlock *)aPB1;
		const BOPTools_PaveBlock &  _aPB2 =*(const BOPTools_PaveBlock *)aPB2;
	return new BOPTools_CommonBlock(			
_aPB1,			
_aPB2);
}
DECL_EXPORT void* BOPTools_CommonBlock_CtorE11775D8(
	void* aPB1,
	int aF)
{
		const BOPTools_PaveBlock &  _aPB1 =*(const BOPTools_PaveBlock *)aPB1;
	return new BOPTools_CommonBlock(			
_aPB1,			
aF);
}
DECL_EXPORT void BOPTools_CommonBlock_SetPaveBlock136FC67E4(
	void* instance,
	void* aPB1)
{
		const BOPTools_PaveBlock &  _aPB1 =*(const BOPTools_PaveBlock *)aPB1;
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
 	result->SetPaveBlock1(			
_aPB1);
}
DECL_EXPORT void BOPTools_CommonBlock_SetPaveBlock236FC67E4(
	void* instance,
	void* aPB2)
{
		const BOPTools_PaveBlock &  _aPB2 =*(const BOPTools_PaveBlock *)aPB2;
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
 	result->SetPaveBlock2(			
_aPB2);
}
DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock1(void* instance)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
	return new BOPTools_PaveBlock( 	result->PaveBlock1());
}
DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock1E8219145(
	void* instance,
	int anIndex)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
	return new BOPTools_PaveBlock( 	result->PaveBlock1(			
anIndex));
}
DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock2(void* instance)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
	return new BOPTools_PaveBlock( 	result->PaveBlock2());
}
DECL_EXPORT void* BOPTools_CommonBlock_PaveBlock2E8219145(
	void* instance,
	int anIndex)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
	return new BOPTools_PaveBlock( 	result->PaveBlock2(			
anIndex));
}
DECL_EXPORT void BOPTools_CommonBlock_SetFace(void* instance, int value)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
		result->SetFace(value);
}

DECL_EXPORT int BOPTools_CommonBlock_Face(void* instance)
{
	BOPTools_CommonBlock* result = (BOPTools_CommonBlock*)instance;
	return 	result->Face();
}

DECL_EXPORT void BOPToolsCommonBlock_Dtor(void* instance)
{
	delete (BOPTools_CommonBlock*)instance;
}
