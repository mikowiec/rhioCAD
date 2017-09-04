#include "Prs2dDrawer.h"
#include <Prs2d_Drawer.hxx>

#include <Prs2d_AspectRoot.hxx>

DECL_EXPORT void* Prs2d_Drawer_Ctor()
{
	return new Handle_Prs2d_Drawer(new Prs2d_Drawer());
}
DECL_EXPORT void* Prs2d_Drawer_FindAspect3485EFC5(
	void* instance,
	int anAspectName)
{
		const Prs2d_AspectName _anAspectName =(const Prs2d_AspectName )anAspectName;
	Prs2d_Drawer* result = (Prs2d_Drawer*)(((Handle_Prs2d_Drawer*)instance)->Access());
	return new Handle_Prs2d_AspectRoot( 	result->FindAspect(			
_anAspectName));
}
DECL_EXPORT void Prs2d_Drawer_SetAspectADBB773B(
	void* instance,
	void* anAspectRoot,
	int anAspectName)
{
		const Handle_Prs2d_AspectRoot&  _anAspectRoot =*(const Handle_Prs2d_AspectRoot *)anAspectRoot;
		const Prs2d_AspectName _anAspectName =(const Prs2d_AspectName )anAspectName;
	Prs2d_Drawer* result = (Prs2d_Drawer*)(((Handle_Prs2d_Drawer*)instance)->Access());
 	result->SetAspect(			
_anAspectRoot,			
_anAspectName);
}
DECL_EXPORT void Prs2d_Drawer_SetMaxParameterValue(void* instance, double value)
{
	Prs2d_Drawer* result = (Prs2d_Drawer*)(((Handle_Prs2d_Drawer*)instance)->Access());
		result->SetMaxParameterValue(value);
}

DECL_EXPORT double Prs2d_Drawer_MaxParameterValue(void* instance)
{
	Prs2d_Drawer* result = (Prs2d_Drawer*)(((Handle_Prs2d_Drawer*)instance)->Access());
	return 	result->MaxParameterValue();
}

DECL_EXPORT void Prs2dDrawer_Dtor(void* instance)
{
	delete (Handle_Prs2d_Drawer*)instance;
}
