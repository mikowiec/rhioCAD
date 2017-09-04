#ifndef BRepGProp_H
#define BRepGProp_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void BRepGProp_LinearProperties883E019(
	void* S,
	void* LProps);
extern "C" DECL_EXPORT void BRepGProp_SurfaceProperties883E019(
	void* S,
	void* SProps);
extern "C" DECL_EXPORT double BRepGProp_SurfacePropertiesCE035849(
	void* S,
	void* SProps,
	double Eps);
extern "C" DECL_EXPORT void BRepGProp_VolumeProperties6CC68073(
	void* S,
	void* VProps,
	bool OnlyClosed);
extern "C" DECL_EXPORT double BRepGProp_VolumeProperties95E7E8(
	void* S,
	void* VProps,
	double Eps,
	bool OnlyClosed);
extern "C" DECL_EXPORT double BRepGProp_VolumePropertiesGK7C6171BD(
	void* S,
	void* VProps,
	double Eps,
	bool OnlyClosed,
	bool IsUseSpan,
	bool CGFlag,
	bool IFlag);
extern "C" DECL_EXPORT double BRepGProp_VolumePropertiesGKD4DE636B(
	void* S,
	void* VProps,
	void* thePln,
	double Eps,
	bool OnlyClosed,
	bool IsUseSpan,
	bool CGFlag,
	bool IFlag);
extern "C" DECL_EXPORT void BRepGProp_Dtor(void* instance);

#endif
