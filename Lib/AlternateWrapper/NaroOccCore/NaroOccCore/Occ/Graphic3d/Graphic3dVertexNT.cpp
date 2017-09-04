#include "Graphic3dVertexNT.h"
#include <Graphic3d_VertexNT.hxx>


DECL_EXPORT void* Graphic3d_VertexNT_Ctor()
{
	return new Graphic3d_VertexNT();
}
DECL_EXPORT void* Graphic3d_VertexNT_CtorC4E56621(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	double ATX,
	double ATY,
	bool FlagNormalise)
{
	return new Graphic3d_VertexNT(			
AX,			
AY,			
AZ,			
ANX,			
ANY,			
ANZ,			
ATX,			
ATY,			
FlagNormalise);
}
DECL_EXPORT void* Graphic3d_VertexNT_Ctor6C5E5BBA(
	void* APoint,
	void* AVector,
	double ATX,
	double ATY,
	bool FlagNormalise)
{
		const Graphic3d_Vertex &  _APoint =*(const Graphic3d_Vertex *)APoint;
		const Graphic3d_Vector &  _AVector =*(const Graphic3d_Vector *)AVector;
	return new Graphic3d_VertexNT(			
_APoint,			
_AVector,			
ATX,			
ATY,			
FlagNormalise);
}
DECL_EXPORT void Graphic3d_VertexNT_SetTextureCoordinate9F0E714F(
	void* instance,
	double ATX,
	double ATY)
{
	Graphic3d_VertexNT* result = (Graphic3d_VertexNT*)instance;
 	result->SetTextureCoordinate(			
ATX,			
ATY);
}
DECL_EXPORT void Graphic3d_VertexNT_TextureCoordinate9F0E714F(
	void* instance,
	double* ATX,
	double* ATY)
{
	Graphic3d_VertexNT* result = (Graphic3d_VertexNT*)instance;
 	result->TextureCoordinate(			
*ATX,			
*ATY);
}
DECL_EXPORT void Graphic3dVertexNT_Dtor(void* instance)
{
	delete (Graphic3d_VertexNT*)instance;
}
