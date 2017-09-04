#include "BRepCheckAnalyzer.h"
#include <BRepCheck_Analyzer.hxx>


DECL_EXPORT void* BRepCheck_Analyzer_Ctor5E7DD5C8(
	void* S,
	bool GeomControls)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	return new BRepCheck_Analyzer(			
_S,			
GeomControls);
}
DECL_EXPORT void BRepCheck_Analyzer_Init5E7DD5C8(
	void* instance,
	void* S,
	bool GeomControls)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepCheck_Analyzer* result = (BRepCheck_Analyzer*)instance;
 	result->Init(			
_S,			
GeomControls);
}
DECL_EXPORT bool BRepCheck_Analyzer_IsValid9EBAC0C0(
	void* instance,
	void* S)
{
		const TopoDS_Shape &  _S =*(const TopoDS_Shape *)S;
	BRepCheck_Analyzer* result = (BRepCheck_Analyzer*)instance;
	return  	result->IsValid(			
_S);
}
DECL_EXPORT bool BRepCheck_Analyzer_IsValid(void* instance)
{
	BRepCheck_Analyzer* result = (BRepCheck_Analyzer*)instance;
	return  	result->IsValid();
}
DECL_EXPORT void BRepCheckAnalyzer_Dtor(void* instance)
{
	delete (BRepCheck_Analyzer*)instance;
}
