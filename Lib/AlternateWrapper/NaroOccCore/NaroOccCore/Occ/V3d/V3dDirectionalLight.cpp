#include "V3dDirectionalLight.h"
#include <V3d_DirectionalLight.hxx>


DECL_EXPORT void* V3d_DirectionalLight_Ctor83D2E67B(
	void* VM,
	int Direction,
	int Color,
	bool Headlight)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const V3d_TypeOfOrientation _Direction =(const V3d_TypeOfOrientation )Direction;
		const Quantity_NameOfColor _Color =(const Quantity_NameOfColor )Color;
	return new Handle_V3d_DirectionalLight(new V3d_DirectionalLight(			
_VM,			
_Direction,			
_Color,			
Headlight));
}
DECL_EXPORT void* V3d_DirectionalLight_CtorEB2CC882(
	void* VM,
	double Xt,
	double Yt,
	double Zt,
	double Xp,
	double Yp,
	double Zp,
	int Color,
	bool Headlight)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Quantity_NameOfColor _Color =(const Quantity_NameOfColor )Color;
	return new Handle_V3d_DirectionalLight(new V3d_DirectionalLight(			
_VM,			
Xt,			
Yt,			
Zt,			
Xp,			
Yp,			
Zp,			
_Color,			
Headlight));
}
DECL_EXPORT void V3d_DirectionalLight_SetDirection17AA5025(
	void* instance,
	int Direction)
{
		const V3d_TypeOfOrientation _Direction =(const V3d_TypeOfOrientation )Direction;
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->SetDirection(			
_Direction);
}
DECL_EXPORT void V3d_DirectionalLight_SetDirection9282A951(
	void* instance,
	double Xm,
	double Ym,
	double Zm)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->SetDirection(			
Xm,			
Ym,			
Zm);
}
DECL_EXPORT void V3d_DirectionalLight_SetDisplayPosition9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->SetDisplayPosition(			
X,			
Y,			
Z);
}
DECL_EXPORT void V3d_DirectionalLight_SetPosition9282A951(
	void* instance,
	double Xp,
	double Yp,
	double Zp)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->SetPosition(			
Xp,			
Yp,			
Zp);
}
DECL_EXPORT void V3d_DirectionalLight_DisplayF5FC77BB(
	void* instance,
	void* aView,
	int Representation)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
		const V3d_TypeOfRepresentation _Representation =(const V3d_TypeOfRepresentation )Representation;
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->Display(			
_aView,			
_Representation);
}
DECL_EXPORT void V3d_DirectionalLight_Position9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->Position(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_DirectionalLight_DisplayPosition9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->DisplayPosition(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_DirectionalLight_Direction9282A951(
	void* instance,
	double* Vx,
	double* Vy,
	double* Vz)
{
	V3d_DirectionalLight* result = (V3d_DirectionalLight*)(((Handle_V3d_DirectionalLight*)instance)->Access());
 	result->Direction(			
*Vx,			
*Vy,			
*Vz);
}
DECL_EXPORT void V3dDirectionalLight_Dtor(void* instance)
{
	delete (Handle_V3d_DirectionalLight*)instance;
}
