#ifndef PlotMgt_PlotterParameter_H
#define PlotMgt_PlotterParameter_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* PlotMgt_PlotterParameter_Ctor66CFACD0(
	void* aName);
extern "C" DECL_EXPORT bool PlotMgt_PlotterParameter_Save626970E9(
	void* instance,
	void* aFile);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SValue66CFACD0(
	void* instance,
	void* aValue);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_Dump(void* instance);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetSValue66CFACD0(
	void* instance,
	void* aValue);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetState(void* instance, bool value);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetType(void* instance, int value);
extern "C" DECL_EXPORT void* PlotMgt_PlotterParameter_Name(void* instance);
extern "C" DECL_EXPORT void* PlotMgt_PlotterParameter_OldName(void* instance);
extern "C" DECL_EXPORT bool PlotMgt_PlotterParameter_NeedToBeSaved(void* instance);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetBValue(void* instance, bool value);
extern "C" DECL_EXPORT bool PlotMgt_PlotterParameter_BValue(void* instance);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetIValue(void* instance, int value);
extern "C" DECL_EXPORT int PlotMgt_PlotterParameter_IValue(void* instance);
extern "C" DECL_EXPORT void PlotMgt_PlotterParameter_SetRValue(void* instance, double value);
extern "C" DECL_EXPORT double PlotMgt_PlotterParameter_RValue(void* instance);
extern "C" DECL_EXPORT void PlotMgtPlotterParameter_Dtor(void* instance);

#endif
