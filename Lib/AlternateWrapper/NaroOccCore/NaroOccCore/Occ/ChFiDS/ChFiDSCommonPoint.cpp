#include "ChFiDSCommonPoint.h"
#include <ChFiDS_CommonPoint.hxx>

#include <gp_Pnt.hxx>
#include <gp_Vec.hxx>
#include <TopoDS_Edge.hxx>
#include <TopoDS_Vertex.hxx>

DECL_EXPORT void* ChFiDS_CommonPoint_Ctor()
{
	return new ChFiDS_CommonPoint();
}
DECL_EXPORT void ChFiDS_CommonPoint_Reset(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
 	result->Reset();
}
DECL_EXPORT void ChFiDS_CommonPoint_SetArc65E3D459(
	void* instance,
	double Tol,
	void* A,
	double Param,
	int TArc)
{
		const TopoDS_Edge &  _A =*(const TopoDS_Edge *)A;
		const TopAbs_Orientation _TArc =(const TopAbs_Orientation )TArc;
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
 	result->SetArc(			
Tol,			
_A,			
Param,			
_TArc);
}
DECL_EXPORT void* ChFiDS_CommonPoint_Arc(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return new TopoDS_Edge( 	result->Arc());
}
DECL_EXPORT void ChFiDS_CommonPoint_SetTolerance(void* instance, double value)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
		result->SetTolerance(value);
}

DECL_EXPORT double ChFiDS_CommonPoint_Tolerance(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->Tolerance();
}

DECL_EXPORT bool ChFiDS_CommonPoint_IsVertex(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->IsVertex();
}

DECL_EXPORT void ChFiDS_CommonPoint_SetVertex(void* instance, void* value)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
		result->SetVertex(*(const TopoDS_Vertex *)value);
}

DECL_EXPORT void* ChFiDS_CommonPoint_Vertex(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	new TopoDS_Vertex(	result->Vertex());
}

DECL_EXPORT bool ChFiDS_CommonPoint_IsOnArc(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->IsOnArc();
}

DECL_EXPORT int ChFiDS_CommonPoint_TransitionOnArc(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return (int)	result->TransitionOnArc();
}

DECL_EXPORT double ChFiDS_CommonPoint_ParameterOnArc(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->ParameterOnArc();
}

DECL_EXPORT void ChFiDS_CommonPoint_SetParameter(void* instance, double value)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
		result->SetParameter(value);
}

DECL_EXPORT double ChFiDS_CommonPoint_Parameter(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->Parameter();
}

DECL_EXPORT void ChFiDS_CommonPoint_SetPoint(void* instance, void* value)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
		result->SetPoint(*(const gp_Pnt *)value);
}

DECL_EXPORT void* ChFiDS_CommonPoint_Point(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	new gp_Pnt(	result->Point());
}

DECL_EXPORT bool ChFiDS_CommonPoint_HasVector(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	result->HasVector();
}

DECL_EXPORT void ChFiDS_CommonPoint_SetVector(void* instance, void* value)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
		result->SetVector(*(const gp_Vec *)value);
}

DECL_EXPORT void* ChFiDS_CommonPoint_Vector(void* instance)
{
	ChFiDS_CommonPoint* result = (ChFiDS_CommonPoint*)instance;
	return 	new gp_Vec(	result->Vector());
}

DECL_EXPORT void ChFiDSCommonPoint_Dtor(void* instance)
{
	delete (ChFiDS_CommonPoint*)instance;
}
