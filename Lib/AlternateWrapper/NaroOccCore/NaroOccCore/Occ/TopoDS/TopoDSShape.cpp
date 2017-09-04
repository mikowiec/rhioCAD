#include "TopoDSShape.h"
#include <TopoDS_Shape.hxx>

#include <TopLoc_Location.hxx>
#include <TopoDS_Shape.hxx>
#include <TopoDS_TShape.hxx>

DECL_EXPORT void* TopoDS_Shape_Ctor()
{
	return new TopoDS_Shape();
}
DECL_EXPORT void TopoDS_Shape_Nullify(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Nullify();
}
DECL_EXPORT void* TopoDS_Shape_Location(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new TopLoc_Location( 	result->Location());
}
DECL_EXPORT void TopoDS_Shape_Location15DCA881(
	void* instance,
	void* Loc)
{
		const TopLoc_Location &  _Loc =*(const TopLoc_Location *)Loc;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Location(			
_Loc);
}
DECL_EXPORT void* TopoDS_Shape_Located15DCA881(
	void* instance,
	void* Loc)
{
		const TopLoc_Location &  _Loc =*(const TopLoc_Location *)Loc;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new TopoDS_Shape( 	result->Located(			
_Loc));
}
DECL_EXPORT int TopoDS_Shape_Orientation(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Orientation();
}
DECL_EXPORT void TopoDS_Shape_Orientation69EAD1AB(
	void* instance,
	int Orient)
{
		const TopAbs_Orientation _Orient =(const TopAbs_Orientation )Orient;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Orientation(			
_Orient);
}
DECL_EXPORT void* TopoDS_Shape_Oriented69EAD1AB(
	void* instance,
	int Or)
{
		const TopAbs_Orientation _Or =(const TopAbs_Orientation )Or;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new TopoDS_Shape( 	result->Oriented(			
_Or));
}
DECL_EXPORT void* TopoDS_Shape_TShape(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new Handle_TopoDS_TShape( 	result->TShape());
}
DECL_EXPORT bool TopoDS_Shape_Free(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Free();
}
DECL_EXPORT void TopoDS_Shape_Free461FC46A(
	void* instance,
	bool F)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Free(			
F);
}
DECL_EXPORT bool TopoDS_Shape_Modified(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Modified();
}
DECL_EXPORT void TopoDS_Shape_Modified461FC46A(
	void* instance,
	bool M)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Modified(			
M);
}
DECL_EXPORT bool TopoDS_Shape_Checked(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Checked();
}
DECL_EXPORT void TopoDS_Shape_Checked461FC46A(
	void* instance,
	bool C)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Checked(			
C);
}
DECL_EXPORT bool TopoDS_Shape_Orientable(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Orientable();
}
DECL_EXPORT void TopoDS_Shape_Orientable461FC46A(
	void* instance,
	bool C)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Orientable(			
C);
}
DECL_EXPORT bool TopoDS_Shape_Closed(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Closed();
}
DECL_EXPORT void TopoDS_Shape_Closed461FC46A(
	void* instance,
	bool C)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Closed(			
C);
}
DECL_EXPORT bool TopoDS_Shape_Infinite(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Infinite();
}
DECL_EXPORT void TopoDS_Shape_Infinite461FC46A(
	void* instance,
	bool C)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Infinite(			
C);
}
DECL_EXPORT bool TopoDS_Shape_Convex(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->Convex();
}
DECL_EXPORT void TopoDS_Shape_Convex461FC46A(
	void* instance,
	bool C)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Convex(			
C);
}
DECL_EXPORT void TopoDS_Shape_Move15DCA881(
	void* instance,
	void* position)
{
		const TopLoc_Location &  _position =*(const TopLoc_Location *)position;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Move(			
_position);
}
DECL_EXPORT void* TopoDS_Shape_Moved15DCA881(
	void* instance,
	void* position)
{
		const TopLoc_Location &  _position =*(const TopLoc_Location *)position;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new TopoDS_Shape( 	result->Moved(			
_position));
}
DECL_EXPORT void TopoDS_Shape_Reverse(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Reverse();
}
DECL_EXPORT void TopoDS_Shape_Complement(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Complement();
}
DECL_EXPORT void TopoDS_Shape_Compose69EAD1AB(
	void* instance,
	int Orient)
{
		const TopAbs_Orientation _Orient =(const TopAbs_Orientation )Orient;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->Compose(			
_Orient);
}
DECL_EXPORT void* TopoDS_Shape_Composed69EAD1AB(
	void* instance,
	int Orient)
{
		const TopAbs_Orientation _Orient =(const TopAbs_Orientation )Orient;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return new TopoDS_Shape( 	result->Composed(			
_Orient));
}
DECL_EXPORT bool TopoDS_Shape_IsPartner9EBAC0C0(
	void* instance,
	void* other)
{
		const TopoDS_Shape &  _other =*(const TopoDS_Shape *)other;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->IsPartner(			
_other);
}
DECL_EXPORT bool TopoDS_Shape_IsSame9EBAC0C0(
	void* instance,
	void* other)
{
		const TopoDS_Shape &  _other =*(const TopoDS_Shape *)other;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->IsSame(			
_other);
}
DECL_EXPORT bool TopoDS_Shape_IsEqual9EBAC0C0(
	void* instance,
	void* other)
{
		const TopoDS_Shape &  _other =*(const TopoDS_Shape *)other;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->IsEqual(			
_other);
}
DECL_EXPORT bool TopoDS_Shape_IsNotEqual9EBAC0C0(
	void* instance,
	void* other)
{
		const TopoDS_Shape &  _other =*(const TopoDS_Shape *)other;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->IsNotEqual(			
_other);
}
DECL_EXPORT int TopoDS_Shape_HashCodeE8219145(
	void* instance,
	int Upper)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return  	result->HashCode(			
Upper);
}
DECL_EXPORT void TopoDS_Shape_EmptyCopy(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->EmptyCopy();
}
DECL_EXPORT void TopoDS_Shape_TShape3F0FF109(
	void* instance,
	void* T)
{
		const Handle_TopoDS_TShape&  _T =*(const Handle_TopoDS_TShape *)T;
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
 	result->TShape(			
_T);
}
DECL_EXPORT bool TopoDS_Shape_IsNull(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return 	result->IsNull();
}

DECL_EXPORT int TopoDS_Shape_ShapeType(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return (int)	result->ShapeType();
}

DECL_EXPORT void* TopoDS_Shape_Reversed(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return 	new TopoDS_Shape(	result->Reversed());
}

DECL_EXPORT void* TopoDS_Shape_Complemented(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return 	new TopoDS_Shape(	result->Complemented());
}

DECL_EXPORT void* TopoDS_Shape_EmptyCopied(void* instance)
{
	TopoDS_Shape* result = (TopoDS_Shape*)instance;
	return 	new TopoDS_Shape(	result->EmptyCopied());
}

DECL_EXPORT void TopoDSShape_Dtor(void* instance)
{
	delete (TopoDS_Shape*)instance;
}
