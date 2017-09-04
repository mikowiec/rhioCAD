#include "BRepClass3dSClassifier.h"
#include <BRepClass3d_SClassifier.hxx>

#include <TopoDS_Face.hxx>

DECL_EXPORT void* BRepClass3d_SClassifier_Ctor()
{
	return new BRepClass3d_SClassifier();
}
DECL_EXPORT bool BRepClass3d_SClassifier_Rejected(void* instance)
{
	BRepClass3d_SClassifier* result = (BRepClass3d_SClassifier*)instance;
	return 	result->Rejected();
}

DECL_EXPORT int BRepClass3d_SClassifier_State(void* instance)
{
	BRepClass3d_SClassifier* result = (BRepClass3d_SClassifier*)instance;
	return (int)	result->State();
}

DECL_EXPORT bool BRepClass3d_SClassifier_IsOnAFace(void* instance)
{
	BRepClass3d_SClassifier* result = (BRepClass3d_SClassifier*)instance;
	return 	result->IsOnAFace();
}

DECL_EXPORT void* BRepClass3d_SClassifier_Face(void* instance)
{
	BRepClass3d_SClassifier* result = (BRepClass3d_SClassifier*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void BRepClass3dSClassifier_Dtor(void* instance)
{
	delete (BRepClass3d_SClassifier*)instance;
}
