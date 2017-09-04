#include "Graphic3dPlotter.h"
#include <Graphic3d_Plotter.hxx>


DECL_EXPORT bool Graphic3d_Plotter_BeginPlot8A4E6B67(
	void* instance,
	void* aProjector)
{
		const Handle_Graphic3d_DataStructureManager&  _aProjector =*(const Handle_Graphic3d_DataStructureManager *)aProjector;
	Graphic3d_Plotter* result = (Graphic3d_Plotter*)(((Handle_Graphic3d_Plotter*)instance)->Access());
	return  	result->BeginPlot(			
_aProjector);
}
DECL_EXPORT void Graphic3d_Plotter_EndPlot(void* instance)
{
	Graphic3d_Plotter* result = (Graphic3d_Plotter*)(((Handle_Graphic3d_Plotter*)instance)->Access());
 	result->EndPlot();
}
DECL_EXPORT void Graphic3dPlotter_Dtor(void* instance)
{
	delete (Handle_Graphic3d_Plotter*)instance;
}
