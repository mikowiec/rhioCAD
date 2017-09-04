#include "BRepBuilderAPISewing.h"
#include <BRepBuilderAPI_Sewing.hxx>

#include <TopoDS_Edge.hxx>
#include <TopoDS_Face.hxx>
#include <TopoDS_Shape.hxx>

DECL_EXPORT void* BRepBuilderAPI_Sewing_Ctor7CD625AC(
	double tolerance,
	bool option1,
	bool option2,
	bool option3,
	bool option4)
{
	return new Handle_BRepBuilderAPI_Sewing(new BRepBuilderAPI_Sewing(			
tolerance,			
option1,			
option2,			
option3,			
option4));
}
DECL_EXPORT void BRepBuilderAPI_Sewing_Init7CD625AC(
	void* instance,
	double tolerance,
	bool option1,
	bool option2,
	bool option3,
	bool option4)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
 	result->Init(			
tolerance,			
option1,			
option2,			
option3,			
option4);
}
DECL_EXPORT void BRepBuilderAPI_Sewing_Load9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
 	result->Load(			
_shape);
}
DECL_EXPORT void BRepBuilderAPI_Sewing_Add9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
 	result->Add(			
_shape);
}
DECL_EXPORT void BRepBuilderAPI_Sewing_Perform346F5010(
	void* instance,
	void* thePI)
{
	//	const Handle_Message_ProgressIndicator&  _thePI =*(const Handle_Message_ProgressIndicator *)thePI;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
 	result->Perform(			
0);
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_FreeEdgeE8219145(
	void* instance,
	int index)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Edge( 	result->FreeEdge(			
index));
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_MultipleEdgeE8219145(
	void* instance,
	int index)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Edge( 	result->MultipleEdge(			
index));
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_ContigousEdgeE8219145(
	void* instance,
	int index)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Edge( 	result->ContigousEdge(			
index));
}
DECL_EXPORT bool BRepBuilderAPI_Sewing_IsSectionBound24263856(
	void* instance,
	void* section)
{
		const TopoDS_Edge &  _section =*(const TopoDS_Edge *)section;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return  	result->IsSectionBound(			
_section);
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_SectionToBoundary24263856(
	void* instance,
	void* section)
{
		const TopoDS_Edge &  _section =*(const TopoDS_Edge *)section;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Edge( 	result->SectionToBoundary(			
_section));
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_DegeneratedShapeE8219145(
	void* instance,
	int index)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Shape( 	result->DegeneratedShape(			
index));
}
DECL_EXPORT bool BRepBuilderAPI_Sewing_IsDegenerated9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return  	result->IsDegenerated(			
_shape);
}
DECL_EXPORT bool BRepBuilderAPI_Sewing_IsModified9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return  	result->IsModified(			
_shape);
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_Modified9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Shape( 	result->Modified(			
_shape));
}
DECL_EXPORT bool BRepBuilderAPI_Sewing_IsModifiedSubShape9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return  	result->IsModifiedSubShape(			
_shape);
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_ModifiedSubShape9EBAC0C0(
	void* instance,
	void* shape)
{
		const TopoDS_Shape &  _shape =*(const TopoDS_Shape *)shape;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Shape( 	result->ModifiedSubShape(			
_shape));
}
DECL_EXPORT void BRepBuilderAPI_Sewing_Dump(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
 	result->Dump();
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_DeletedFaceE8219145(
	void* instance,
	int index)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Face( 	result->DeletedFace(			
index));
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_WhichFace3274CFB8(
	void* instance,
	void* theEdg,
	int index)
{
		const TopoDS_Edge &  _theEdg =*(const TopoDS_Edge *)theEdg;
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return new TopoDS_Face( 	result->WhichFace(			
_theEdg,			
index));
}
DECL_EXPORT void* BRepBuilderAPI_Sewing_SewedShape(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	new TopoDS_Shape(	result->SewedShape());
}

DECL_EXPORT int BRepBuilderAPI_Sewing_NbFreeEdges(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NbFreeEdges();
}

DECL_EXPORT int BRepBuilderAPI_Sewing_NbMultipleEdges(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NbMultipleEdges();
}

DECL_EXPORT int BRepBuilderAPI_Sewing_NbContigousEdges(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NbContigousEdges();
}

DECL_EXPORT int BRepBuilderAPI_Sewing_NbDegeneratedShapes(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NbDegeneratedShapes();
}

DECL_EXPORT int BRepBuilderAPI_Sewing_NbDeletedFaces(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NbDeletedFaces();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetSameParameterMode(void* instance, bool value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetSameParameterMode(value);
}

DECL_EXPORT bool BRepBuilderAPI_Sewing_SameParameterMode(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->SameParameterMode();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetTolerance(void* instance, double value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetTolerance(value);
}

DECL_EXPORT double BRepBuilderAPI_Sewing_Tolerance(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->Tolerance();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetMinTolerance(void* instance, double value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetMinTolerance(value);
}

DECL_EXPORT double BRepBuilderAPI_Sewing_MinTolerance(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->MinTolerance();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetMaxTolerance(void* instance, double value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetMaxTolerance(value);
}

DECL_EXPORT double BRepBuilderAPI_Sewing_MaxTolerance(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->MaxTolerance();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetFaceMode(void* instance, bool value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetFaceMode(value);
}

DECL_EXPORT bool BRepBuilderAPI_Sewing_FaceMode(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->FaceMode();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetFloatingEdgesMode(void* instance, bool value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetFloatingEdgesMode(value);
}

DECL_EXPORT bool BRepBuilderAPI_Sewing_FloatingEdgesMode(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->FloatingEdgesMode();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetLocalTolerancesMode(void* instance, bool value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetLocalTolerancesMode(value);
}

DECL_EXPORT bool BRepBuilderAPI_Sewing_LocalTolerancesMode(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->LocalTolerancesMode();
}

DECL_EXPORT void BRepBuilderAPI_Sewing_SetNonManifoldMode(void* instance, bool value)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
		result->SetNonManifoldMode(value);
}

DECL_EXPORT bool BRepBuilderAPI_Sewing_NonManifoldMode(void* instance)
{
	BRepBuilderAPI_Sewing* result = (BRepBuilderAPI_Sewing*)(((Handle_BRepBuilderAPI_Sewing*)instance)->Access());
	return 	result->NonManifoldMode();
}

DECL_EXPORT void BRepBuilderAPISewing_Dtor(void* instance)
{
	delete (Handle_BRepBuilderAPI_Sewing*)instance;
}
