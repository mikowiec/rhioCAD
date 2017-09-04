#ifndef Visual3d_Layer_H
#define Visual3d_Layer_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* Visual3d_Layer_Ctor441B6185(
	void* AViewer,
	int AType,
	bool AFlag);
extern "C" DECL_EXPORT void Visual3d_Layer_Begin(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_End(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_Clear(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_BeginPolyline(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_BeginPolygon(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_AddVertex947352B1(
	void* instance,
	double X,
	double Y,
	bool AFlag);
extern "C" DECL_EXPORT void Visual3d_Layer_ClosePrimitive(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_DrawRectangleC2777E0C(
	void* instance,
	double X,
	double Y,
	double Width,
	double Height);
extern "C" DECL_EXPORT void Visual3d_Layer_DrawText70DEA06(
	void* instance,
	char* AText,
	double X,
	double Y,
	double AHeight);
extern "C" DECL_EXPORT void Visual3d_Layer_TextSize60366884(
	void* instance,
	char* AText,
	double AHeight,
	double* AWidth,
	double* AnAscent,
	double* ADescent);
extern "C" DECL_EXPORT void Visual3d_Layer_UnsetTransparency(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_SetLineAttributes4A74B177(
	void* instance,
	int AType,
	double AWidth);
extern "C" DECL_EXPORT void Visual3d_Layer_SetTextAttributesB86808AE(
	void* instance,
	char* AFont,
	int AType,
	void* AColor);
extern "C" DECL_EXPORT void Visual3d_Layer_SetOrtho2E58BA48(
	void* instance,
	double Left,
	double Right,
	double Bottom,
	double Top,
	int Attach);
extern "C" DECL_EXPORT void Visual3d_Layer_SetViewport5107F6FE(
	void* instance,
	int Width,
	int Height);
extern "C" DECL_EXPORT void Visual3d_Layer_AddLayerItem62CFB744(
	void* instance,
	void* Item);
extern "C" DECL_EXPORT void Visual3d_Layer_RemoveLayerItem62CFB744(
	void* instance,
	void* Item);
extern "C" DECL_EXPORT void Visual3d_Layer_RemoveAllLayerItems(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_RenderLayerItems(void* instance);
extern "C" DECL_EXPORT void Visual3d_Layer_SetColor(void* instance, void* value);
extern "C" DECL_EXPORT void Visual3d_Layer_SetTransparency(void* instance, double value);
extern "C" DECL_EXPORT int Visual3d_Layer_Type(void* instance);
extern "C" DECL_EXPORT void Visual3dLayer_Dtor(void* instance);

#endif
