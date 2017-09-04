#include "V3dPositionLight.h"
#include <V3d_PositionLight.hxx>


DECL_EXPORT void V3d_PositionLight_SetTarget9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->SetTarget(			
X,			
Y,			
Z);
}
DECL_EXPORT void V3d_PositionLight_OnHideFace36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->OnHideFace(			
_aView);
}
DECL_EXPORT void V3d_PositionLight_OnSeeFace36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->OnSeeFace(			
_aView);
}
DECL_EXPORT void V3d_PositionLight_TrackingA941FC63(
	void* instance,
	void* aView,
	int WathPick,
	int Xpix,
	int Ypix)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
		const V3d_TypeOfPickLight _WathPick =(const V3d_TypeOfPickLight )WathPick;
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->Tracking(			
_aView,			
_WathPick,			
Xpix,			
Ypix);
}
DECL_EXPORT void V3d_PositionLight_DisplayF5FC77BB(
	void* instance,
	void* aView,
	int Representation)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
		const V3d_TypeOfRepresentation _Representation =(const V3d_TypeOfRepresentation )Representation;
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->Display(			
_aView,			
_Representation);
}
DECL_EXPORT void V3d_PositionLight_Erase(void* instance)
{
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->Erase();
}
DECL_EXPORT bool V3d_PositionLight_SeeOrHide36A6FAB7(
	void* instance,
	void* aView)
{
		const Handle_V3d_View&  _aView =*(const Handle_V3d_View *)aView;
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
	return  	result->SeeOrHide(			
_aView);
}
DECL_EXPORT void V3d_PositionLight_Target9282A951(
	void* instance,
	double* X,
	double* Y,
	double* Z)
{
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
 	result->Target(			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void V3d_PositionLight_SetRadius(void* instance, double value)
{
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
		result->SetRadius(value);
}

DECL_EXPORT double V3d_PositionLight_Radius(void* instance)
{
	V3d_PositionLight* result = (V3d_PositionLight*)(((Handle_V3d_PositionLight*)instance)->Access());
	return 	result->Radius();
}

DECL_EXPORT void V3dPositionLight_Dtor(void* instance)
{
	delete (Handle_V3d_PositionLight*)instance;
}
