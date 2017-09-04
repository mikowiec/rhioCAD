#include "AspectFontStyle.h"
#include <Aspect_FontStyle.hxx>

#include <Aspect_FontStyle.hxx>

DECL_EXPORT void* Aspect_FontStyle_Ctor()
{
	return new Aspect_FontStyle();
}
DECL_EXPORT void* Aspect_FontStyle_Ctor625FF186(
	int Type,
	double Size,
	double Slant,
	bool CapsHeight)
{
		const Aspect_TypeOfFont _Type =(const Aspect_TypeOfFont )Type;
	return new Aspect_FontStyle(			
_Type,			
Size,			
Slant,			
CapsHeight);
}
DECL_EXPORT void* Aspect_FontStyle_Ctor27C00EC7(
	char* Style,
	double Size,
	double Slant,
	bool CapsHeight)
{
	return new Aspect_FontStyle(			
Style,			
Size,			
Slant,			
CapsHeight);
}
DECL_EXPORT void* Aspect_FontStyle_Ctor9381D4D(
	char* Style)
{
	return new Aspect_FontStyle(			
Style);
}
DECL_EXPORT void* Aspect_FontStyle_Assign8E648131(
	void* instance,
	void* Other)
{
		const Aspect_FontStyle &  _Other =*(const Aspect_FontStyle *)Other;
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return new Aspect_FontStyle( 	result->Assign(			
_Other));
}
DECL_EXPORT void Aspect_FontStyle_SetValues625FF186(
	void* instance,
	int Type,
	double Size,
	double Slant,
	bool CapsHeight)
{
		const Aspect_TypeOfFont _Type =(const Aspect_TypeOfFont )Type;
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
 	result->SetValues(			
_Type,			
Size,			
Slant,			
CapsHeight);
}
DECL_EXPORT void Aspect_FontStyle_SetValues27C00EC7(
	void* instance,
	char* Style,
	double Size,
	double Slant,
	bool CapsHeight)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
 	result->SetValues(			
Style,			
Size,			
Slant,			
CapsHeight);
}
DECL_EXPORT void Aspect_FontStyle_SetValues9381D4D(
	void* instance,
	char* Style)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
 	result->SetValues(			
Style);
}
DECL_EXPORT void Aspect_FontStyle_Dump(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
 	result->Dump();
}
DECL_EXPORT bool Aspect_FontStyle_IsEqual8E648131(
	void* instance,
	void* Other)
{
		const Aspect_FontStyle &  _Other =*(const Aspect_FontStyle *)Other;
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return  	result->IsEqual(			
_Other);
}
DECL_EXPORT bool Aspect_FontStyle_IsNotEqual8E648131(
	void* instance,
	void* Other)
{
		const Aspect_FontStyle &  _Other =*(const Aspect_FontStyle *)Other;
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return  	result->IsNotEqual(			
_Other);
}
DECL_EXPORT int Aspect_FontStyle_Style(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return (int)	result->Style();
}

DECL_EXPORT int Aspect_FontStyle_Length(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Length();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Value(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Value();
}

DECL_EXPORT double Aspect_FontStyle_Size(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Size();
}

DECL_EXPORT double Aspect_FontStyle_Slant(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Slant();
}

DECL_EXPORT bool Aspect_FontStyle_CapsHeight(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->CapsHeight();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_AliasName(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->AliasName();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_FullName(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->FullName();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Foundry(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Foundry();
}

DECL_EXPORT void Aspect_FontStyle_SetFamily(void* instance, char* value)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
		result->SetFamily(value);
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Family(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Family();
}

DECL_EXPORT void Aspect_FontStyle_SetWeight(void* instance, char* value)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
		result->SetWeight(value);
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Weight(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Weight();
}

DECL_EXPORT void Aspect_FontStyle_SetRegistry(void* instance, char* value)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
		result->SetRegistry(value);
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Registry(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Registry();
}

DECL_EXPORT void Aspect_FontStyle_SetEncoding(void* instance, char* value)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
		result->SetEncoding(value);
}

DECL_EXPORT Standard_CString Aspect_FontStyle_Encoding(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->Encoding();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SSlant(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SSlant();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SWidth(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SWidth();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SStyle(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SStyle();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SPixelSize(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SPixelSize();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SPointSize(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SPointSize();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SResolutionX(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SResolutionX();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SResolutionY(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SResolutionY();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SSpacing(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SSpacing();
}

DECL_EXPORT Standard_CString Aspect_FontStyle_SAverageWidth(void* instance)
{
	Aspect_FontStyle* result = (Aspect_FontStyle*)instance;
	return 	result->SAverageWidth();
}

DECL_EXPORT void AspectFontStyle_Dtor(void* instance)
{
	delete (Aspect_FontStyle*)instance;
}
