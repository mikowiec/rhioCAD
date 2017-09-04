#include "V3dAmbientLight.h"
#include <V3d_AmbientLight.hxx>


DECL_EXPORT void* V3d_AmbientLight_Ctor185B9A99(
	void* VM,
	int Color)
{
		const Handle_V3d_Viewer&  _VM =*(const Handle_V3d_Viewer *)VM;
		const Quantity_NameOfColor _Color =(const Quantity_NameOfColor )Color;
	return new Handle_V3d_AmbientLight(new V3d_AmbientLight(			
_VM,			
_Color));
}
DECL_EXPORT void V3dAmbientLight_Dtor(void* instance)
{
	delete (Handle_V3d_AmbientLight*)instance;
}
