#include "Visual3dLayer.h"
#include <Visual3d_Layer.hxx>


DECL_EXPORT void* Visual3d_Layer_Ctor441B6185(
	void* AViewer,
	int AType,
	bool AFlag)
{
		const Handle_Visual3d_ViewManager&  _AViewer =*(const Handle_Visual3d_ViewManager *)AViewer;
		const Aspect_TypeOfLayer _AType =(const Aspect_TypeOfLayer )AType;
	return new Handle_Visual3d_Layer(new Visual3d_Layer(			
_AViewer,			
_AType,			
AFlag));
}
DECL_EXPORT void Visual3d_Layer_Begin(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->Begin();
}
DECL_EXPORT void Visual3d_Layer_End(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->End();
}
DECL_EXPORT void Visual3d_Layer_Clear(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->Clear();
}
DECL_EXPORT void Visual3d_Layer_BeginPolyline(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->BeginPolyline();
}
DECL_EXPORT void Visual3d_Layer_BeginPolygon(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->BeginPolygon();
}
DECL_EXPORT void Visual3d_Layer_AddVertex947352B1(
	void* instance,
	double X,
	double Y,
	bool AFlag)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->AddVertex(			
X,			
Y,			
AFlag);
}
DECL_EXPORT void Visual3d_Layer_ClosePrimitive(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->ClosePrimitive();
}
DECL_EXPORT void Visual3d_Layer_DrawRectangleC2777E0C(
	void* instance,
	double X,
	double Y,
	double Width,
	double Height)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->DrawRectangle(			
X,			
Y,			
Width,			
Height);
}
DECL_EXPORT void Visual3d_Layer_DrawText70DEA06(
	void* instance,
	char* AText,
	double X,
	double Y,
	double AHeight)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->DrawText(			
AText,			
X,			
Y,			
AHeight);
}
DECL_EXPORT void Visual3d_Layer_TextSize60366884(
	void* instance,
	char* AText,
	double AHeight,
	double* AWidth,
	double* AnAscent,
	double* ADescent)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->TextSize(			
AText,			
AHeight,			
*AWidth,			
*AnAscent,			
*ADescent);
}
DECL_EXPORT void Visual3d_Layer_UnsetTransparency(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->UnsetTransparency();
}
DECL_EXPORT void Visual3d_Layer_SetLineAttributes4A74B177(
	void* instance,
	int AType,
	double AWidth)
{
		const Aspect_TypeOfLine _AType =(const Aspect_TypeOfLine )AType;
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->SetLineAttributes(			
_AType,			
AWidth);
}
DECL_EXPORT void Visual3d_Layer_SetTextAttributesB86808AE(
	void* instance,
	char* AFont,
	int AType,
	void* AColor)
{
		const Aspect_TypeOfDisplayText _AType =(const Aspect_TypeOfDisplayText )AType;
		const Quantity_Color &  _AColor =*(const Quantity_Color *)AColor;
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->SetTextAttributes(			
AFont,			
_AType,			
_AColor);
}
DECL_EXPORT void Visual3d_Layer_SetOrtho2E58BA48(
	void* instance,
	double Left,
	double Right,
	double Bottom,
	double Top,
	int Attach)
{
		const Aspect_TypeOfConstraint _Attach =(const Aspect_TypeOfConstraint )Attach;
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->SetOrtho(			
Left,			
Right,			
Bottom,			
Top,			
_Attach);
}
DECL_EXPORT void Visual3d_Layer_SetViewport5107F6FE(
	void* instance,
	int Width,
	int Height)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->SetViewport(			
Width,			
Height);
}
DECL_EXPORT void Visual3d_Layer_AddLayerItem62CFB744(
	void* instance,
	void* Item)
{
		const Handle_Visual3d_LayerItem&  _Item =*(const Handle_Visual3d_LayerItem *)Item;
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->AddLayerItem(			
_Item);
}
DECL_EXPORT void Visual3d_Layer_RemoveLayerItem62CFB744(
	void* instance,
	void* Item)
{
		const Handle_Visual3d_LayerItem&  _Item =*(const Handle_Visual3d_LayerItem *)Item;
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->RemoveLayerItem(			
_Item);
}
DECL_EXPORT void Visual3d_Layer_RemoveAllLayerItems(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->RemoveAllLayerItems();
}
DECL_EXPORT void Visual3d_Layer_RenderLayerItems(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
 	result->RenderLayerItems();
}
DECL_EXPORT void Visual3d_Layer_SetColor(void* instance, void* value)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
		result->SetColor(*(const Quantity_Color *)value);
}

DECL_EXPORT void Visual3d_Layer_SetTransparency(void* instance, double value)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
		result->SetTransparency(value);
}

DECL_EXPORT int Visual3d_Layer_Type(void* instance)
{
	Visual3d_Layer* result = (Visual3d_Layer*)(((Handle_Visual3d_Layer*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT void Visual3dLayer_Dtor(void* instance)
{
	delete (Handle_Visual3d_Layer*)instance;
}
