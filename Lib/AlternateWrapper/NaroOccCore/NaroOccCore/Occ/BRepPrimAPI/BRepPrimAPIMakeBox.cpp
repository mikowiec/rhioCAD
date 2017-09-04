#include "BRepPrimAPIMakeBox.h"
#include <BRepPrimAPI_MakeBox.hxx>

#include <TopoDS_Face.hxx>
#include <TopoDS_Shell.hxx>
#include <TopoDS_Solid.hxx>

DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor9282A951(
	double dx,
	double dy,
	double dz)
{
	return new BRepPrimAPI_MakeBox(			
dx,			
dy,			
dz);
}
DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor22BACD62(
	void* P,
	double dx,
	double dy,
	double dz)
{
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new BRepPrimAPI_MakeBox(			
_P,			
dx,			
dy,			
dz);
}
DECL_EXPORT void* BRepPrimAPI_MakeBox_Ctor5C63477E(
	void* P1,
	void* P2)
{
		const gp_Pnt &  _P1 =*(const gp_Pnt *)P1;
		const gp_Pnt &  _P2 =*(const gp_Pnt *)P2;
	return new BRepPrimAPI_MakeBox(			
_P1,			
_P2);
}
DECL_EXPORT void* BRepPrimAPI_MakeBox_CtorF0200AF(
	void* Axes,
	double dx,
	double dy,
	double dz)
{
		const gp_Ax2 &  _Axes =*(const gp_Ax2 *)Axes;
	return new BRepPrimAPI_MakeBox(			
_Axes,			
dx,			
dy,			
dz);
}
DECL_EXPORT void BRepPrimAPI_MakeBox_Build(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
 	result->Build();
}
DECL_EXPORT void* BRepPrimAPI_MakeBox_Shell(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Shell(	result->Shell());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_Solid(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Solid(	result->Solid());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_BottomFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->BottomFace());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_BackFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->BackFace());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_FrontFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->FrontFace());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_LeftFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->LeftFace());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_RightFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->RightFace());
}

DECL_EXPORT void* BRepPrimAPI_MakeBox_TopFace(void* instance)
{
	BRepPrimAPI_MakeBox* result = (BRepPrimAPI_MakeBox*)instance;
	return 	new TopoDS_Face(	result->TopFace());
}

DECL_EXPORT void BRepPrimAPIMakeBox_Dtor(void* instance)
{
	delete (BRepPrimAPI_MakeBox*)instance;
}
