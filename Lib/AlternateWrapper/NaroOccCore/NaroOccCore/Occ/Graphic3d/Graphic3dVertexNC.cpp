#include "Graphic3dVertexNC.h"
#include <Graphic3d_VertexNC.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Graphic3d_VertexNC_Ctor()
{
	return new Graphic3d_VertexNC();
}
DECL_EXPORT void* Graphic3d_VertexNC_CtorF45E0172(
	double AX,
	double AY,
	double AZ,
	double ANX,
	double ANY,
	double ANZ,
	void* AColor,
	bool FlagNormalise)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	return new Graphic3d_VertexNC(			
AX,			
AY,			
AZ,			
ANX,			
ANY,			
ANZ,			
_AColor,			
FlagNormalise);
}
DECL_EXPORT void* Graphic3d_VertexNC_Ctor523C1B5F(
	void* APoint,
	void* AVector,
	void* AColor,
	bool FlagNormalise)
{
		const Graphic3d_Vertex &  _APoint =*(const Graphic3d_Vertex *)APoint;
		const Graphic3d_Vector &  _AVector =*(const Graphic3d_Vector *)AVector;
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	return new Graphic3d_VertexNC(			
_APoint,			
_AVector,			
_AColor,			
FlagNormalise);
}
DECL_EXPORT void Graphic3d_VertexNC_SetColor(void* instance, void* value)
{
	Graphic3d_VertexNC* result = (Graphic3d_VertexNC*)instance;
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_VertexNC_Color(void* instance)
{
	Graphic3d_VertexNC* result = (Graphic3d_VertexNC*)instance;
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT void Graphic3dVertexNC_Dtor(void* instance)
{
	delete (Graphic3d_VertexNC*)instance;
}
