#include "Graphic3dVertexC.h"
#include <Graphic3d_VertexC.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Graphic3d_VertexC_Ctor()
{
	return new Graphic3d_VertexC();
}
DECL_EXPORT void* Graphic3d_VertexC_Ctor54B79BE2(
	double AX,
	double AY,
	double AZ,
	void* AColor)
{
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	return new Graphic3d_VertexC(			
AX,			
AY,			
AZ,			
_AColor);
}
DECL_EXPORT void* Graphic3d_VertexC_Ctor1204A009(
	void* APoint,
	void* AColor)
{
		const Graphic3d_Vertex &  _APoint =*(const Graphic3d_Vertex *)APoint;
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	return new Graphic3d_VertexC(			
_APoint,			
_AColor);
}
DECL_EXPORT void Graphic3d_VertexC_SetColor(void* instance, void* value)
{
	Graphic3d_VertexC* result = (Graphic3d_VertexC*)instance;
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Graphic3d_VertexC_Color(void* instance)
{
	Graphic3d_VertexC* result = (Graphic3d_VertexC*)instance;
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT void Graphic3dVertexC_Dtor(void* instance)
{
	delete (Graphic3d_VertexC*)instance;
}
