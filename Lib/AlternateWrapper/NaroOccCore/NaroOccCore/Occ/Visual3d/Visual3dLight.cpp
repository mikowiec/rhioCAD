#include "Visual3dLight.h"
#include <Visual3d_Light.hxx>

#include <Quantity_Color.hxx>

DECL_EXPORT void* Visual3d_Light_Ctor()
{
	return new Handle_Visual3d_Light(new Visual3d_Light());
}
DECL_EXPORT void* Visual3d_Light_Ctor8FD7F48(
	void* Color)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
	return new Handle_Visual3d_Light(new Visual3d_Light(			
_Color));
}
DECL_EXPORT void* Visual3d_Light_Ctor37E700E8(
	void* Color,
	void* Direction,
	bool Headlight)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
		const Graphic3d_Vector &  _Direction =*(const Graphic3d_Vector *)Direction;
	return new Handle_Visual3d_Light(new Visual3d_Light(			
_Color,			
_Direction,			
Headlight));
}
DECL_EXPORT void* Visual3d_Light_Ctor75C213E8(
	void* Color,
	void* Position,
	double Fact1,
	double Fact2)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
		const Graphic3d_Vertex &  _Position =*(const Graphic3d_Vertex *)Position;
	return new Handle_Visual3d_Light(new Visual3d_Light(			
_Color,			
_Position,			
Fact1,			
Fact2));
}
DECL_EXPORT void* Visual3d_Light_Ctor3F337B1E(
	void* Color,
	void* Position,
	void* Direction,
	double Concentration,
	double Fact1,
	double Fact2,
	double AngleCone)
{
		const Quantity_Color &  _Color =*(const Quantity_Color *)Color;
		const Graphic3d_Vertex &  _Position =*(const Graphic3d_Vertex *)Position;
		const Graphic3d_Vector &  _Direction =*(const Graphic3d_Vector *)Direction;
	return new Handle_Visual3d_Light(new Visual3d_Light(			
_Color,			
_Position,			
_Direction,			
Concentration,			
Fact1,			
Fact2,			
AngleCone));
}
DECL_EXPORT void Visual3d_Light_Values8FD7F48(
	void* instance,
	void* Color)
{
		 Quantity_Color &  _Color =*( Quantity_Color *)Color;
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
 	result->Values(			
_Color);
}
DECL_EXPORT void Visual3d_Light_Values7778B201(
	void* instance,
	void* Color,
	void* Direction)
{
		 Quantity_Color &  _Color =*( Quantity_Color *)Color;
		 Graphic3d_Vector &  _Direction =*( Graphic3d_Vector *)Direction;
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
 	result->Values(			
_Color,			
_Direction);
}
DECL_EXPORT void Visual3d_Light_Values75C213E8(
	void* instance,
	void* Color,
	void* Position,
	double* Fact1,
	double* Fact2)
{
		 Quantity_Color &  _Color =*( Quantity_Color *)Color;
		 Graphic3d_Vertex &  _Position =*( Graphic3d_Vertex *)Position;
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
 	result->Values(			
_Color,			
_Position,			
*Fact1,			
*Fact2);
}
DECL_EXPORT void Visual3d_Light_Values3F337B1E(
	void* instance,
	void* Color,
	void* Position,
	void* Direction,
	double* Concentration,
	double* Fact1,
	double* Fact2,
	double* AngleCone)
{
		 Quantity_Color &  _Color =*( Quantity_Color *)Color;
		 Graphic3d_Vertex &  _Position =*( Graphic3d_Vertex *)Position;
		 Graphic3d_Vector &  _Direction =*( Graphic3d_Vector *)Direction;
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
 	result->Values(			
_Color,			
_Position,			
_Direction,			
*Concentration,			
*Fact1,			
*Fact2,			
*AngleCone);
}
DECL_EXPORT void Visual3d_Light_SetAngle(void* instance, double value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetAngle(value);
}

DECL_EXPORT void Visual3d_Light_SetAttenuation1(void* instance, double value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetAttenuation1(value);
}

DECL_EXPORT void Visual3d_Light_SetAttenuation2(void* instance, double value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetAttenuation2(value);
}

DECL_EXPORT void Visual3d_Light_SetConcentration(void* instance, double value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetConcentration(value);
}

DECL_EXPORT void Visual3d_Light_SetDirection(void* instance, void* value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetDirection(*(const Graphic3d_Vector *)value);
}

DECL_EXPORT void Visual3d_Light_SetPosition(void* instance, void* value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetPosition(*(const Graphic3d_Vertex *)value);
}

DECL_EXPORT bool Visual3d_Light_Headlight(void* instance)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
	return 	result->Headlight();
}

DECL_EXPORT void Visual3d_Light_SetColor(void* instance, void* value)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void* Visual3d_Light_Color(void* instance)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
	return 	new Quantity_Color(	result->Color());
}

DECL_EXPORT int Visual3d_Light_LightType(void* instance)
{
	Visual3d_Light* result = (Visual3d_Light*)(((Handle_Visual3d_Light*)instance)->Access());
	return (int)	result->LightType();
}

DECL_EXPORT int Visual3d_Light_Limit()
{
	return Visual3d_Light::Limit();
}

DECL_EXPORT void Visual3dLight_Dtor(void* instance)
{
	delete (Handle_Visual3d_Light*)instance;
}
