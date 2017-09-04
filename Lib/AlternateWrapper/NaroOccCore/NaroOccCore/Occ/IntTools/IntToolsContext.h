#ifndef IntTools_Context_H
#define IntTools_Context_H

#include "../../Export_Import.h"

extern "C" DECL_EXPORT void* IntTools_Context_Ctor();
extern "C" DECL_EXPORT void* IntTools_Context_SolidClassifier56111E92(
	void* instance,
	void* aSolid);
extern "C" DECL_EXPORT int IntTools_Context_ComputeVE644637E6(
	void* instance,
	void* aV,
	void* aE,
	double* aT);
extern "C" DECL_EXPORT int IntTools_Context_ComputeVE14B7C63A(
	void* instance,
	void* aV,
	void* aE,
	double* aT,
	bool* bToUpdateVertex,
	double* aDist);
extern "C" DECL_EXPORT int IntTools_Context_ComputeVS2502EEC5(
	void* instance,
	void* aV,
	void* aF,
	double* U,
	double* V);
extern "C" DECL_EXPORT int IntTools_Context_StatePointFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D);
extern "C" DECL_EXPORT bool IntTools_Context_IsPointInFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D);
extern "C" DECL_EXPORT bool IntTools_Context_IsPointInOnFace15F1B95A(
	void* instance,
	void* aF,
	void* aP2D);
extern "C" DECL_EXPORT bool IntTools_Context_IsValidPointForFace51B2A608(
	void* instance,
	void* aP3D,
	void* aF,
	double aTol);
extern "C" DECL_EXPORT bool IntTools_Context_IsValidPointForFaces53322313(
	void* instance,
	void* aP3D,
	void* aF1,
	void* aF2,
	double aTol);
extern "C" DECL_EXPORT bool IntTools_Context_IsValidBlockForFace3F82E9C8(
	void* instance,
	double aT1,
	double aT2,
	void* aIC,
	void* aF,
	double aTol);
extern "C" DECL_EXPORT bool IntTools_Context_IsValidBlockForFacesC37F6D8D(
	void* instance,
	double aT1,
	double aT2,
	void* aIC,
	void* aF1,
	void* aF2,
	double aTol);
extern "C" DECL_EXPORT bool IntTools_Context_IsVertexOnLineE4D8858(
	void* instance,
	void* aV,
	void* aIC,
	double aTolC,
	double* aT);
extern "C" DECL_EXPORT bool IntTools_Context_IsVertexOnLine7D7AFC65(
	void* instance,
	void* aV,
	double aTolV,
	void* aIC,
	double aTolC,
	double* aT);
extern "C" DECL_EXPORT bool IntTools_Context_ProjectPointOnEdge31FF11E7(
	void* instance,
	void* aP,
	void* aE,
	double* aT);
extern "C" DECL_EXPORT void IntToolsContext_Dtor(void* instance);

#endif
