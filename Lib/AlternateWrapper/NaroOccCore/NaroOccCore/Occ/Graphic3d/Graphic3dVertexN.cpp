#include "Graphic3dVertexN.h"
#include <Graphic3d_VertexN.hxx>


DECL_EXPORT void* Graphic3d_VertexN_Ctor()
{
	return new Graphic3d_VertexN();
}
DECL_EXPORT void* Graphic3d_VertexN_Ctor51E06B8D(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	bool FlagNormalise)
{
	return new Graphic3d_VertexN(			
AX,			
AY,			
AZ,			
ANX,			
ANY,			
ANZ,			
FlagNormalise);
}
DECL_EXPORT void* Graphic3d_VertexN_CtorD1B20338(
	void* APoint,
	void* AVector,
	bool FlagNormalise)
{
		const Graphic3d_Vertex &  _APoint =*(const Graphic3d_Vertex *)APoint;
		const Graphic3d_Vector &  _AVector =*(const Graphic3d_Vector *)AVector;
	return new Graphic3d_VertexN(			
_APoint,			
_AVector,			
FlagNormalise);
}
DECL_EXPORT void Graphic3d_VertexN_SetNormal1B801FD4(
	void* instance,
	double NXnew,
	double NYnew,
	double NZnew,
	bool FlagNormalise)
{
	Graphic3d_VertexN* result = (Graphic3d_VertexN*)instance;
 	result->SetNormal(			
NXnew,			
NYnew,			
NZnew,			
FlagNormalise);
}
DECL_EXPORT void Graphic3d_VertexN_Normal9282A951(
	void* instance,
	double* ANX,
	double* ANY,
	double* ANZ)
{
	Graphic3d_VertexN* result = (Graphic3d_VertexN*)instance;
 	result->Normal(			
*ANX,			
*ANY,			
*ANZ);
}
DECL_EXPORT void Graphic3dVertexN_Dtor(void* instance)
{
	delete (Graphic3d_VertexN*)instance;
}
