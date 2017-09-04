#ifndef BRepBuilderAPI_MakeFace_H
#define BRepBuilderAPI_MakeFace_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor();
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorAEC70AC1(
	void* F);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor9914D2AD(
	void* P);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor67FD6A6(
	void* C);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor25F8D29C(
	void* C);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor95E480D1(
	void* S);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorC906A96F(
	void* C);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor4C43CA45(
	void* S,
	double TolDegen);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorDD072DE5(
	void* P,
	double UMin,
	double UMax,
	double VMin,
	double VMax);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor1CF3267A(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor90A7A2D3(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorDF1FCE01(
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor126052F0(
	void* C,
	double UMin,
	double UMax,
	double VMin,
	double VMax);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor8F43826(
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax,
	double TolDegen);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorF673DC3(
	void* W,
	bool OnlyPlane);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorF0D4468(
	void* P,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor7D92CEE4(
	void* C,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor1AD3E6A2(
	void* C,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor9D6BF994(
	void* S,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor570E9DA5(
	void* C,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_CtorC9D68572(
	void* S,
	void* W,
	bool Inside);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Ctor15D7DFC2(
	void* F,
	void* W);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeFace_InitAEC70AC1(
	void* instance,
	void* F);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeFace_Init78C1643F(
	void* instance,
	void* S,
	bool Bound,
	double TolDegen);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeFace_Init8F43826(
	void* instance,
	void* S,
	double UMin,
	double UMax,
	double VMin,
	double VMax,
	double TolDegen);
extern "C" DECL_EXPORT void BRepBuilderAPI_MakeFace_Add368EDFE5(
	void* instance,
	void* W);
extern "C" DECL_EXPORT bool BRepBuilderAPI_MakeFace_IsDone(void* instance);
extern "C" DECL_EXPORT int BRepBuilderAPI_MakeFace_Error(void* instance);
extern "C" DECL_EXPORT void* BRepBuilderAPI_MakeFace_Face(void* instance);
extern "C" DECL_EXPORT void BRepBuilderAPIMakeFace_Dtor(void* instance);

#endif
