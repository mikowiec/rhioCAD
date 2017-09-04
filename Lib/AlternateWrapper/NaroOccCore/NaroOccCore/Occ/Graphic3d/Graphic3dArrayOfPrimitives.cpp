#include "Graphic3dArrayOfPrimitives.h"
#include <Graphic3d_ArrayOfPrimitives.hxx>

#include <gp_Dir.hxx>
#include <gp_Pnt.hxx>
#include <gp_Pnt2d.hxx>
#include <Quantity_Color.hxx>

DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex9EAECD5B(
	void* instance,
	void* aVertice)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex9282A951(
	void* instance,
	double X,
	double Y,
	double Z)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
X,			
Y,			
Z);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexCF428497(
	void* instance,
	void* aVertice,
	void* aColor)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aColor);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexB4E46582(
	void* instance,
	void* aVertice,
	int aColor)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
aColor);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexE13B639C(
	void* instance,
	void* aVertice,
	void* aNormal)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aNormal);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexBC7A5786(
	void* instance,
	double X,
	double Y,
	double Z,
	double NX,
	double NY,
	double NZ)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
X,			
Y,			
Z,			
NX,			
NY,			
NZ);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex62B2E04B(
	void* instance,
	void* aVertice,
	void* aNormal,
	void* aColor)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aNormal,			
_aColor);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex2E34027A(
	void* instance,
	void* aVertice,
	void* aNormal,
	int aColor)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aNormal,			
aColor);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexB9E79A6(
	void* instance,
	void* aVertice,
	void* aTexel)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const gp_Pnt2d &  _aTexel =*(const gp_Pnt2d *)aTexel;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aTexel);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex216AF150(
	void* instance,
	double X,
	double Y,
	double Z,
	double TX,
	double TY)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
X,			
Y,			
Z,			
TX,			
TY);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertex640114B2(
	void* instance,
	void* aVertice,
	void* aNormal,
	void* aTexel)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
		const gp_Pnt2d &  _aTexel =*(const gp_Pnt2d *)aTexel;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
_aVertice,			
_aNormal,			
_aTexel);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddVertexF677E616(
	void* instance,
	double X,
	double Y,
	double Z,
	double NX,
	double NY,
	double NZ,
	double TX,
	double TY)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddVertex(			
X,			
Y,			
Z,			
NX,			
NY,			
NZ,			
TX,			
TY);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBoundE8219145(
	void* instance,
	int edgeNumber)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddBound(			
edgeNumber);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBound8575C8EE(
	void* instance,
	int edgeNumber,
	void* aBColor)
{
		const Quantity_Color &  _aBColor =*(const Quantity_Color *)aBColor;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddBound(			
edgeNumber,			
_aBColor);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddBound830CC280(
	void* instance,
	int edgeNumber,
	double R,
	double G,
	double B)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddBound(			
edgeNumber,			
R,			
G,			
B);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_AddEdge898DAFFC(
	void* instance,
	int vertexIndex,
	bool isVisible)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->AddEdge(			
vertexIndex,			
isVisible);
}
DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_OrientateCEC711A5(
	void* instance,
	void* aNormal)
{
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->Orientate(			
_aNormal);
}
DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_OrientateF2A71E5F(
	void* instance,
	int aBoundIndex,
	void* aNormal)
{
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->Orientate(			
aBoundIndex,			
_aNormal);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertice7B5D1E58(
	void* instance,
	int anIndex,
	void* aVertice)
{
		const gp_Pnt &  _aVertice =*(const gp_Pnt *)aVertice;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertice(			
anIndex,			
_aVertice);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertice830CC280(
	void* instance,
	int anIndex,
	double X,
	double Y,
	double Z)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertice(			
anIndex,			
X,			
Y,			
Z);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor8575C8EE(
	void* instance,
	int anIndex,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexColor(			
anIndex,			
_aColor);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor830CC280(
	void* instance,
	int anIndex,
	double R,
	double G,
	double B)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexColor(			
anIndex,			
R,			
G,			
B);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexColor5107F6FE(
	void* instance,
	int anIndex,
	int aColor)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexColor(			
anIndex,			
aColor);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexNormalF2A71E5F(
	void* instance,
	int anIndex,
	void* aNormal)
{
		const gp_Dir &  _aNormal =*(const gp_Dir *)aNormal;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexNormal(			
anIndex,			
_aNormal);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexNormal830CC280(
	void* instance,
	int anIndex,
	double NX,
	double NY,
	double NZ)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexNormal(			
anIndex,			
NX,			
NY,			
NZ);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexTexel5174DA04(
	void* instance,
	int anIndex,
	void* aTexel)
{
		const gp_Pnt2d &  _aTexel =*(const gp_Pnt2d *)aTexel;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexTexel(			
anIndex,			
_aTexel);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetVertexTexel306E0DFB(
	void* instance,
	int anIndex,
	double TX,
	double TY)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetVertexTexel(			
anIndex,			
TX,			
TY);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetBoundColor8575C8EE(
	void* instance,
	int anIndex,
	void* aColor)
{
		const Quantity_Color &  _aColor =*(const Quantity_Color *)aColor;
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetBoundColor(			
anIndex,			
_aColor);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_SetBoundColor830CC280(
	void* instance,
	int anIndex,
	double R,
	double G,
	double B)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->SetBoundColor(			
anIndex,			
R,			
G,			
B);
}
DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VerticeE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return new gp_Pnt( 	result->Vertice(			
aRank));
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Vertice830CC280(
	void* instance,
	int aRank,
	double* X,
	double* Y,
	double* Z)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->Vertice(			
aRank,			
*X,			
*Y,			
*Z);
}
DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexColorE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return new Quantity_Color( 	result->VertexColor(			
aRank));
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexColor830CC280(
	void* instance,
	int aRank,
	double* R,
	double* G,
	double* B)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->VertexColor(			
aRank,			
*R,			
*G,			
*B);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexColor5107F6FE(
	void* instance,
	int aRank,
	int* aColor)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->VertexColor(			
aRank,			
*aColor);
}
DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexNormalE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return new gp_Dir( 	result->VertexNormal(			
aRank));
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexNormal830CC280(
	void* instance,
	int aRank,
	double* NX,
	double* NY,
	double* NZ)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->VertexNormal(			
aRank,			
*NX,			
*NY,			
*NZ);
}
DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_VertexTexelE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return new gp_Pnt2d( 	result->VertexTexel(			
aRank));
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_VertexTexel306E0DFB(
	void* instance,
	int aRank,
	double* TX,
	double* TY)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->VertexTexel(			
aRank,			
*TX,			
*TY);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_EdgeE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->Edge(			
aRank);
}
DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_EdgeIsVisibleE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->EdgeIsVisible(			
aRank);
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_BoundE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return  	result->Bound(			
aRank);
}
DECL_EXPORT void* Graphic3d_ArrayOfPrimitives_BoundColorE8219145(
	void* instance,
	int aRank)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return new Quantity_Color( 	result->BoundColor(			
aRank));
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_BoundColor830CC280(
	void* instance,
	int aRank,
	double* R,
	double* G,
	double* B)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
 	result->BoundColor(			
aRank,			
*R,			
*G,			
*B);
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Enable()
{
 Graphic3d_ArrayOfPrimitives::Enable();
}
DECL_EXPORT void Graphic3d_ArrayOfPrimitives_Disable()
{
 Graphic3d_ArrayOfPrimitives::Disable();
}
DECL_EXPORT int Graphic3d_ArrayOfPrimitives_Type(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return (int)	result->Type();
}

DECL_EXPORT Standard_CString Graphic3d_ArrayOfPrimitives_StringType(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->StringType();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexNormals(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->HasVertexNormals();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexColors(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->HasVertexColors();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasVertexTexels(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->HasVertexTexels();
}

DECL_EXPORT int Graphic3d_ArrayOfPrimitives_VertexNumber(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->VertexNumber();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasEdgeInfos(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->HasEdgeInfos();
}

DECL_EXPORT int Graphic3d_ArrayOfPrimitives_EdgeNumber(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->EdgeNumber();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_HasBoundColors(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->HasBoundColors();
}

DECL_EXPORT int Graphic3d_ArrayOfPrimitives_BoundNumber(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->BoundNumber();
}

DECL_EXPORT int Graphic3d_ArrayOfPrimitives_ItemNumber(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->ItemNumber();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_IsEnable()
{
	return Graphic3d_ArrayOfPrimitives::IsEnable();
}

DECL_EXPORT bool Graphic3d_ArrayOfPrimitives_IsValid(void* instance)
{
	Graphic3d_ArrayOfPrimitives* result = (Graphic3d_ArrayOfPrimitives*)(((Handle_Graphic3d_ArrayOfPrimitives*)instance)->Access());
	return 	result->IsValid();
}

DECL_EXPORT void Graphic3dArrayOfPrimitives_Dtor(void* instance)
{
	delete (Handle_Graphic3d_ArrayOfPrimitives*)instance;
}
