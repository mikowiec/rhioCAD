#include "ChFiDSSurfData.h"
#include <ChFiDS_SurfData.hxx>

#include <ChFiDS_CommonPoint.hxx>
#include <ChFiDS_FaceInterference.hxx>
#include <gp_Pnt2d.hxx>
#include <MMgt_TShared.hxx>

DECL_EXPORT void* ChFiDS_SurfData_Ctor()
{
	return new Handle_ChFiDS_SurfData(new ChFiDS_SurfData());
}
DECL_EXPORT void ChFiDS_SurfData_CopyB9327F76(
	void* instance,
	void* Other)
{
		const Handle_ChFiDS_SurfData&  _Other =*(const Handle_ChFiDS_SurfData *)Other;
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->Copy(			
_Other);
}
DECL_EXPORT void ChFiDS_SurfData_ChangeIndexOfS1E8219145(
	void* instance,
	int Index)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->ChangeIndexOfS1(			
Index);
}
DECL_EXPORT void ChFiDS_SurfData_ChangeIndexOfS2E8219145(
	void* instance,
	int Index)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->ChangeIndexOfS2(			
Index);
}
DECL_EXPORT void ChFiDS_SurfData_ChangeSurfE8219145(
	void* instance,
	int Index)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->ChangeSurf(			
Index);
}
DECL_EXPORT void* ChFiDS_SurfData_InterferenceE8219145(
	void* instance,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return new ChFiDS_FaceInterference( 	result->Interference(			
OnS));
}
DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceE8219145(
	void* instance,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return new ChFiDS_FaceInterference( 	result->ChangeInterference(			
OnS));
}
DECL_EXPORT int ChFiDS_SurfData_IndexE8219145(
	void* instance,
	int OfS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->Index(			
OfS);
}
DECL_EXPORT void* ChFiDS_SurfData_VertexD4631C92(
	void* instance,
	bool First,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return new ChFiDS_CommonPoint( 	result->Vertex(			
First,			
OnS));
}
DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexD4631C92(
	void* instance,
	bool First,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return new ChFiDS_CommonPoint( 	result->ChangeVertex(			
First,			
OnS));
}
DECL_EXPORT bool ChFiDS_SurfData_IsOnCurveE8219145(
	void* instance,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->IsOnCurve(			
OnS);
}
DECL_EXPORT int ChFiDS_SurfData_IndexOfCE8219145(
	void* instance,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->IndexOfC(			
OnS);
}
DECL_EXPORT double ChFiDS_SurfData_FirstSpineParam(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->FirstSpineParam();
}
DECL_EXPORT double ChFiDS_SurfData_LastSpineParam(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->LastSpineParam();
}
DECL_EXPORT void ChFiDS_SurfData_FirstSpineParamD82819F3(
	void* instance,
	double Par)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->FirstSpineParam(			
Par);
}
DECL_EXPORT void ChFiDS_SurfData_LastSpineParamD82819F3(
	void* instance,
	double Par)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->LastSpineParam(			
Par);
}
DECL_EXPORT double ChFiDS_SurfData_FirstExtensionValue(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->FirstExtensionValue();
}
DECL_EXPORT double ChFiDS_SurfData_LastExtensionValue(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->LastExtensionValue();
}
DECL_EXPORT void ChFiDS_SurfData_FirstExtensionValueD82819F3(
	void* instance,
	double Extend)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->FirstExtensionValue(			
Extend);
}
DECL_EXPORT void ChFiDS_SurfData_LastExtensionValueD82819F3(
	void* instance,
	double Extend)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->LastExtensionValue(			
Extend);
}
DECL_EXPORT void ChFiDS_SurfData_ResetSimul(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->ResetSimul();
}
DECL_EXPORT void* ChFiDS_SurfData_Get2dPointsD4631C92(
	void* instance,
	bool First,
	int OnS)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return new gp_Pnt2d( 	result->Get2dPoints(			
First,			
OnS));
}
DECL_EXPORT void ChFiDS_SurfData_Get2dPoints79D6D16B(
	void* instance,
	void* P2df1,
	void* P2dl1,
	void* P2df2,
	void* P2dl2)
{
		 gp_Pnt2d &  _P2df1 =*( gp_Pnt2d *)P2df1;
		 gp_Pnt2d &  _P2dl1 =*( gp_Pnt2d *)P2dl1;
		 gp_Pnt2d &  _P2df2 =*( gp_Pnt2d *)P2df2;
		 gp_Pnt2d &  _P2dl2 =*( gp_Pnt2d *)P2dl2;
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->Get2dPoints(			
_P2df1,			
_P2dl1,			
_P2df2,			
_P2dl2);
}
DECL_EXPORT void ChFiDS_SurfData_Set2dPoints79D6D16B(
	void* instance,
	void* P2df1,
	void* P2dl1,
	void* P2df2,
	void* P2dl2)
{
		const gp_Pnt2d &  _P2df1 =*(const gp_Pnt2d *)P2df1;
		const gp_Pnt2d &  _P2dl1 =*(const gp_Pnt2d *)P2dl1;
		const gp_Pnt2d &  _P2df2 =*(const gp_Pnt2d *)P2df2;
		const gp_Pnt2d &  _P2dl2 =*(const gp_Pnt2d *)P2dl2;
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->Set2dPoints(			
_P2df1,			
_P2dl1,			
_P2df2,			
_P2dl2);
}
DECL_EXPORT bool ChFiDS_SurfData_TwistOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->TwistOnS1();
}
DECL_EXPORT bool ChFiDS_SurfData_TwistOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return  	result->TwistOnS2();
}
DECL_EXPORT void ChFiDS_SurfData_TwistOnS1461FC46A(
	void* instance,
	bool T)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->TwistOnS1(			
T);
}
DECL_EXPORT void ChFiDS_SurfData_TwistOnS2461FC46A(
	void* instance,
	bool T)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
 	result->TwistOnS2(			
T);
}
DECL_EXPORT int ChFiDS_SurfData_IndexOfS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IndexOfS1();
}

DECL_EXPORT int ChFiDS_SurfData_IndexOfS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IndexOfS2();
}

DECL_EXPORT bool ChFiDS_SurfData_IsOnCurve1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IsOnCurve1();
}

DECL_EXPORT bool ChFiDS_SurfData_IsOnCurve2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IsOnCurve2();
}

DECL_EXPORT int ChFiDS_SurfData_Surf(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->Surf();
}

DECL_EXPORT int ChFiDS_SurfData_Orientation(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return (int)	result->Orientation();
}

DECL_EXPORT void* ChFiDS_SurfData_InterferenceOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_FaceInterference(	result->InterferenceOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_InterferenceOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_FaceInterference(	result->InterferenceOnS2());
}

DECL_EXPORT void* ChFiDS_SurfData_VertexFirstOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->VertexFirstOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_VertexFirstOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->VertexFirstOnS2());
}

DECL_EXPORT void* ChFiDS_SurfData_VertexLastOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->VertexLastOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_VertexLastOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->VertexLastOnS2());
}

DECL_EXPORT void ChFiDS_SurfData_SetIndexOfC1(void* instance, int value)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
		result->SetIndexOfC1(value);
}

DECL_EXPORT int ChFiDS_SurfData_IndexOfC1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IndexOfC1();
}

DECL_EXPORT void ChFiDS_SurfData_SetIndexOfC2(void* instance, int value)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
		result->SetIndexOfC2(value);
}

DECL_EXPORT int ChFiDS_SurfData_IndexOfC2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	result->IndexOfC2();
}

DECL_EXPORT int ChFiDS_SurfData_ChangeOrientation(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return (int)	result->ChangeOrientation();
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_FaceInterference(	result->ChangeInterferenceOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeInterferenceOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_FaceInterference(	result->ChangeInterferenceOnS2());
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexFirstOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->ChangeVertexFirstOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexFirstOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->ChangeVertexFirstOnS2());
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexLastOnS1(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->ChangeVertexLastOnS1());
}

DECL_EXPORT void* ChFiDS_SurfData_ChangeVertexLastOnS2(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new ChFiDS_CommonPoint(	result->ChangeVertexLastOnS2());
}

DECL_EXPORT void ChFiDS_SurfData_SetSimul(void* instance, void* value)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
		result->SetSimul(*(const Handle_MMgt_TShared *)value);
}

DECL_EXPORT void* ChFiDS_SurfData_Simul(void* instance)
{
	ChFiDS_SurfData* result = (ChFiDS_SurfData*)(((Handle_ChFiDS_SurfData*)instance)->Access());
	return 	new Handle_MMgt_TShared(	result->Simul());
}

DECL_EXPORT void ChFiDSSurfData_Dtor(void* instance)
{
	delete (Handle_ChFiDS_SurfData*)instance;
}
