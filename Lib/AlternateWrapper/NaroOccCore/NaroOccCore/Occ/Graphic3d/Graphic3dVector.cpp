#include "Graphic3dVector.h"
#include <Graphic3d_Vector.hxx>


DECL_EXPORT void* Graphic3d_Vector_Ctor()
{
	return new Graphic3d_Vector();
}
DECL_EXPORT void* Graphic3d_Vector_Ctor9282A951(
	double AX,
	double AY,
	double AZ)
{
	return new Graphic3d_Vector(			
AX,			
AY,			
AZ);
}
DECL_EXPORT void* Graphic3d_Vector_Ctor29D8F78D(
	void* APoint1,
	void* APoint2)
{
		const Graphic3d_Vertex &  _APoint1 =*(const Graphic3d_Vertex *)APoint1;
		const Graphic3d_Vertex &  _APoint2 =*(const Graphic3d_Vertex *)APoint2;
	return new Graphic3d_Vector(			
_APoint1,			
_APoint2);
}
DECL_EXPORT void Graphic3d_Vector_Normalize(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
 	result->Normalize();
}
DECL_EXPORT void Graphic3d_Vector_SetCoord9282A951(
	void* instance,
	double Xnew,
	double Ynew,
	double Znew)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
 	result->SetCoord(			
Xnew,			
Ynew,			
Znew);
}
DECL_EXPORT void Graphic3d_Vector_Coord9282A951(
	void* instance,
	double* AX,
	double* AY,
	double* AZ)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
 	result->Coord(			
*AX,			
*AY,			
*AZ);
}
DECL_EXPORT bool Graphic3d_Vector_IsParallelE005972F(
	void* AV1,
	void* AV2)
{
		const Graphic3d_Vector &  _AV1 =*(const Graphic3d_Vector *)AV1;
		const Graphic3d_Vector &  _AV2 =*(const Graphic3d_Vector *)AV2;
	return  Graphic3d_Vector::IsParallel(			
_AV1,			
_AV2);
}
DECL_EXPORT double Graphic3d_Vector_NormeOf9282A951(
	double AX,
	double AY,
	double AZ)
{
	return  Graphic3d_Vector::NormeOf(			
AX,			
AY,			
AZ);
}
DECL_EXPORT double Graphic3d_Vector_NormeOf8053F351(
	void* AVector)
{
		const Graphic3d_Vector &  _AVector =*(const Graphic3d_Vector *)AVector;
	return  Graphic3d_Vector::NormeOf(			
_AVector);
}
DECL_EXPORT void Graphic3d_Vector_SetXCoord(void* instance, double value)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
		result->SetXCoord(value);
}

DECL_EXPORT void Graphic3d_Vector_SetYCoord(void* instance, double value)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
		result->SetYCoord(value);
}

DECL_EXPORT void Graphic3d_Vector_SetZCoord(void* instance, double value)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
		result->SetZCoord(value);
}

DECL_EXPORT bool Graphic3d_Vector_IsNormalized(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
	return 	result->IsNormalized();
}

DECL_EXPORT bool Graphic3d_Vector_LengthZero(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
	return 	result->LengthZero();
}

DECL_EXPORT double Graphic3d_Vector_X(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
	return 	result->X();
}

DECL_EXPORT double Graphic3d_Vector_Y(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
	return 	result->Y();
}

DECL_EXPORT double Graphic3d_Vector_Z(void* instance)
{
	Graphic3d_Vector* result = (Graphic3d_Vector*)instance;
	return 	result->Z();
}

DECL_EXPORT void Graphic3dVector_Dtor(void* instance)
{
	delete (Graphic3d_Vector*)instance;
}
