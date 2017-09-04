#include "TopoDSTShape.h"
#include <TopoDS_TShape.hxx>


DECL_EXPORT bool TopoDS_TShape_Free(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Free();
}
DECL_EXPORT void TopoDS_TShape_Free461FC46A(
	void* instance,
	bool F)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Free(			
F);
}
DECL_EXPORT bool TopoDS_TShape_Modified(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Modified();
}
DECL_EXPORT void TopoDS_TShape_Modified461FC46A(
	void* instance,
	bool M)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Modified(			
M);
}
DECL_EXPORT bool TopoDS_TShape_Checked(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Checked();
}
DECL_EXPORT void TopoDS_TShape_Checked461FC46A(
	void* instance,
	bool C)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Checked(			
C);
}
DECL_EXPORT bool TopoDS_TShape_Orientable(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Orientable();
}
DECL_EXPORT void TopoDS_TShape_Orientable461FC46A(
	void* instance,
	bool C)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Orientable(			
C);
}
DECL_EXPORT bool TopoDS_TShape_Closed(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Closed();
}
DECL_EXPORT void TopoDS_TShape_Closed461FC46A(
	void* instance,
	bool C)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Closed(			
C);
}
DECL_EXPORT bool TopoDS_TShape_Infinite(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Infinite();
}
DECL_EXPORT void TopoDS_TShape_Infinite461FC46A(
	void* instance,
	bool C)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Infinite(			
C);
}
DECL_EXPORT bool TopoDS_TShape_Convex(void* instance)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
	return  	result->Convex();
}
DECL_EXPORT void TopoDS_TShape_Convex461FC46A(
	void* instance,
	bool C)
{
	TopoDS_TShape* result = (TopoDS_TShape*)(((Handle_TopoDS_TShape*)instance)->Access());
 	result->Convex(			
C);
}
DECL_EXPORT void TopoDSTShape_Dtor(void* instance)
{
	delete (Handle_TopoDS_TShape*)instance;
}
