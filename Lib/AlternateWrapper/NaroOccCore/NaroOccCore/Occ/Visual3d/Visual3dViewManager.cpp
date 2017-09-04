#include "Visual3dViewManager.h"
#include <Visual3d_ViewManager.hxx>

#include <Graphic3d_Vertex.hxx>
#include <Visual3d_Layer.hxx>

DECL_EXPORT void* Visual3d_ViewManager_CtorAC5012C4(
	void* aDevice)
{
		const Handle_Aspect_GraphicDevice&  _aDevice =*(const Handle_Aspect_GraphicDevice *)aDevice;
	return new Handle_Visual3d_ViewManager(new Visual3d_ViewManager(			
_aDevice));
}
DECL_EXPORT void Visual3d_ViewManager_Activate(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Activate();
}
DECL_EXPORT void Visual3d_ViewManager_Deactivate(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Deactivate();
}
DECL_EXPORT void Visual3d_ViewManager_Erase(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Erase();
}
DECL_EXPORT void Visual3d_ViewManager_Redraw(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Redraw();
}
DECL_EXPORT void Visual3d_ViewManager_Remove(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Remove();
}
DECL_EXPORT void Visual3d_ViewManager_Update(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->Update();
}
DECL_EXPORT void Visual3d_ViewManager_ConvertCoord8C15567E(
	void* instance,
	void* AWindow,
	void* AVertex,
	int* AU,
	int* AV)
{
		const Handle_Aspect_Window&  _AWindow =*(const Handle_Aspect_Window *)AWindow;
		const Graphic3d_Vertex &  _AVertex =*(const Graphic3d_Vertex *)AVertex;
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->ConvertCoord(			
_AWindow,			
_AVertex,			
*AU,			
*AV);
}
DECL_EXPORT void* Visual3d_ViewManager_ConvertCoord6DDFCDA0(
	void* instance,
	void* AWindow,
	int AU,
	int AV)
{
		const Handle_Aspect_Window&  _AWindow =*(const Handle_Aspect_Window *)AWindow;
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return new Graphic3d_Vertex( 	result->ConvertCoord(			
_AWindow,			
AU,			
AV));
}
DECL_EXPORT void Visual3d_ViewManager_ConvertCoordWithProj4FF6C2D0(
	void* instance,
	void* AWindow,
	int AU,
	int AV,
	void* Point,
	void* Proj)
{
		const Handle_Aspect_Window&  _AWindow =*(const Handle_Aspect_Window *)AWindow;
		 Graphic3d_Vertex &  _Point =*( Graphic3d_Vertex *)Point;
		 Graphic3d_Vector &  _Proj =*( Graphic3d_Vector *)Proj;
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->ConvertCoordWithProj(			
_AWindow,			
AU,			
AV,			
_Point,			
_Proj);
}
DECL_EXPORT int Visual3d_ViewManager_Identification68FD189(
	void* instance,
	void* AView)
{
		const Handle_Visual3d_View&  _AView =*(const Handle_Visual3d_View *)AView;
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return  	result->Identification(			
_AView);
}
DECL_EXPORT void Visual3d_ViewManager_UnIdentificationE8219145(
	void* instance,
	int aViewId)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->UnIdentification(			
aViewId);
}
DECL_EXPORT int Visual3d_ViewManager_Identification(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return  	result->Identification();
}
DECL_EXPORT bool Visual3d_ViewManager_AddZLayerE8219145(
	void* instance,
	int* theLayerId)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return  	result->AddZLayer(			
*theLayerId);
}
DECL_EXPORT bool Visual3d_ViewManager_RemoveZLayerE8219145(
	void* instance,
	int theLayerId)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return  	result->RemoveZLayer(			
theLayerId);
}
DECL_EXPORT void Visual3d_ViewManager_GetAllZLayersE22FA26(
	void* instance,
	void* theLayerSeq)
{
		 TColStd_SequenceOfInteger &  _theLayerSeq =*( TColStd_SequenceOfInteger *)theLayerSeq;
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->GetAllZLayers(			
_theLayerSeq);
}
DECL_EXPORT void Visual3d_ViewManager_UnHighlight(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
 	result->UnHighlight();
}
DECL_EXPORT int Visual3d_ViewManager_MaxNumOfViews(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return 	result->MaxNumOfViews();
}

DECL_EXPORT void* Visual3d_ViewManager_UnderLayer(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return 	new Handle_Visual3d_Layer(	result->UnderLayer());
}

DECL_EXPORT void* Visual3d_ViewManager_OverLayer(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return 	new Handle_Visual3d_Layer(	result->OverLayer());
}

DECL_EXPORT void Visual3d_ViewManager_SetTransparency(void* instance, bool value)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT bool Visual3d_ViewManager_Transparency(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return 	result->Transparency();
}

DECL_EXPORT void Visual3d_ViewManager_SetZBufferAuto(void* instance, bool value)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
		result->SetZBufferAuto(value);
}

DECL_EXPORT bool Visual3d_ViewManager_ZBufferAuto(void* instance)
{
	Visual3d_ViewManager* result = (Visual3d_ViewManager*)(((Handle_Visual3d_ViewManager*)instance)->Access());
	return 	result->ZBufferAuto();
}

DECL_EXPORT void Visual3dViewManager_Dtor(void* instance)
{
	delete (Handle_Visual3d_ViewManager*)instance;
}
