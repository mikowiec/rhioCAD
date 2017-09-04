#include "BRepPrimAPIMakeOneAxis.h"
#include <BRepPrimAPI_MakeOneAxis.hxx>

#include <TopoDS_Face.hxx>
#include <TopoDS_Shell.hxx>
#include <TopoDS_Solid.hxx>

DECL_EXPORT void BRepPrimAPI_MakeOneAxis_Build(void* instance)
{
	BRepPrimAPI_MakeOneAxis* result = (BRepPrimAPI_MakeOneAxis*)instance;
 	result->Build();
}
DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Face(void* instance)
{
	BRepPrimAPI_MakeOneAxis* result = (BRepPrimAPI_MakeOneAxis*)instance;
	return 	new TopoDS_Face(	result->Face());
}

DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Shell(void* instance)
{
	BRepPrimAPI_MakeOneAxis* result = (BRepPrimAPI_MakeOneAxis*)instance;
	return 	new TopoDS_Shell(	result->Shell());
}

DECL_EXPORT void* BRepPrimAPI_MakeOneAxis_Solid(void* instance)
{
	BRepPrimAPI_MakeOneAxis* result = (BRepPrimAPI_MakeOneAxis*)instance;
	return 	new TopoDS_Solid(	result->Solid());
}

DECL_EXPORT void BRepPrimAPIMakeOneAxis_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeOneAxis*)instance;
}
