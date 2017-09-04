#ifndef Graphic3d_ArrayOfPrimitives_H
#define Graphic3d_ArrayOfPrimitives_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex9EAECD5B(
	void* instance,
	void* aVertice);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex9282A951(
	void* instance,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexCF428497(
	void* instance,
	void* aVertice,
	void* aColor);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexB4E46582(
	void* instance,
	void* aVertice,
	int aColor);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexE13B639C(
	void* instance,
	void* aVertice,
	void* aNormal);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double NX,
	double NY,
	double NZ);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex62B2E04B(
	void* instance,
	void* aVertice,
	void* aNormal,
	void* aColor);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex2E34027A(
	void* instance,
	void* aVertice,
	void* aNormal,
	int aColor);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexB9E79A6(
	void* instance,
	void* aVertice,
	void* aTexel);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex216AF150(
	void* instance,
	double X,
	double Y,
	double Z,
	double TX,
	double TY);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex640114B2(
	void* instance,
	void* aVertice,
	void* aNormal,
	void* aTexel);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexF677E616(
	void* instance,
	double X,
	double Y,
	double Z,
	double NX,
	double NY,
	double NZ,
	double TX,
	double TY);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBoundE8219145(
	void* instance,
	int edgeNumber);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBound8575C8EE(
	void* instance,
	int edgeNumber,
	void* aBColor);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBound830CC280(
	void* instance,
	int edgeNumber,
	double R,
	double G,
	double B);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddEdge898DAFFC(
	void* instance,
	int vertexIndex,
	bool isVisible);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_OrientateCEC711A5(
	void* instance,
	void* aNormal);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_OrientateF2A71E5F(
	void* instance,
	int aBoundIndex,
	void* aNormal);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertice7B5D1E58(
	void* instance,
	int anIndex,
	void* aVertice);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertice830CC280(
	void* instance,
	int anIndex,
	double X,
	double Y,
	double Z);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor8575C8EE(
	void* instance,
	int anIndex,
	void* aColor);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor830CC280(
	void* instance,
	int anIndex,
	double R,
	double G,
	double B);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor5107F6FE(
	void* instance,
	int anIndex,
	int aColor);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexNormalF2A71E5F(
	void* instance,
	int anIndex,
	void* aNormal);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexNormal830CC280(
	void* instance,
	int anIndex,
	double NX,
	double NY,
	double NZ);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexTexel5174DA04(
	void* instance,
	int anIndex,
	void* aTexel);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexTexel306E0DFB(
	void* instance,
	int anIndex,
	double TX,
	double TY);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetBoundColor8575C8EE(
	void* instance,
	int anIndex,
	void* aColor);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetBoundColor830CC280(
	void* instance,
	int anIndex,
	double R,
	double G,
	double B);
extern "C" DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VerticeE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Vertice830CC280(
	void* instance,
	int aRank,
	double* X,
	double* Y,
	double* Z);
extern "C" DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexColorE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexColor830CC280(
	void* instance,
	int aRank,
	double* R,
	double* G,
	double* B);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexColor5107F6FE(
	void* instance,
	int aRank,
	int* aColor);
extern "C" DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexNormalE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexNormal830CC280(
	void* instance,
	int aRank,
	double* NX,
	double* NY,
	double* NZ);
extern "C" DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexTexelE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexTexel306E0DFB(
	void* instance,
	int aRank,
	double* TX,
	double* TY);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_EdgeE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_EdgeIsVisibleE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_BoundE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_BoundColorE8219145(
	void* instance,
	int aRank);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_BoundColor830CC280(
	void* instance,
	int aRank,
	double* R,
	double* G,
	double* B);
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Enable();
extern "C" DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Disable();
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_Type(void* instance);
extern "C" DECL_EXPORT Standard_CString Graphic3d_ArrayOfPrimitives_StringType(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexNormals(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexColors(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexTexels(void* instance);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_VertexNumber(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasEdgeInfos(void* instance);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_EdgeNumber(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasBoundColors(void* instance);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_BoundNumber(void* instance);
extern "C" DECL_EXPORT int Graphic3d_ArrayOfPrimitives_ItemNumber(void* instance);
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_IsEnable();
extern "C" DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_IsValid(void* instance);
extern "C" DECL_EXPORT void Graphic3dArrayOfPrimitives_Dtor(void* instance);

#endif
