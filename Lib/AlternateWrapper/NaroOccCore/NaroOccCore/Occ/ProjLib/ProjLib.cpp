#include "ProjLib.h"
#include <ProjLib.hxx>

#include <gp_Circ2d.hxx>
#include <gp_Elips2d.hxx>
#include <gp_Hypr2d.hxx>
#include <gp_Lin2d.hxx>
#include <gp_Parab2d.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT void* ProjLib_Project10B48A70(
	void* Pl,
	void* P)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new gp_Pnt2d( ProjLib::Project(			
_Pl,			
_P));
}
DECL_EXPORT void* ProjLib_Project1626C982(
	void* Pl,
	void* L)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new gp_Lin2d( ProjLib::Project(			
_Pl,			
_L));
}
DECL_EXPORT void* ProjLib_Project13B7CC27(
	void* Pl,
	void* C)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Circ &  _C =*(const gp_Circ *)C;
	return new gp_Circ2d( ProjLib::Project(			
_Pl,			
_C));
}
DECL_EXPORT void* ProjLib_ProjectEB568F0D(
	void* Pl,
	void* E)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Elips &  _E =*(const gp_Elips *)E;
	return new gp_Elips2d( ProjLib::Project(			
_Pl,			
_E));
}
DECL_EXPORT void* ProjLib_ProjectDE13DD50(
	void* Pl,
	void* P)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Parab &  _P =*(const gp_Parab *)P;
	return new gp_Parab2d( ProjLib::Project(			
_Pl,			
_P));
}
DECL_EXPORT void* ProjLib_ProjectEAC29BEC(
	void* Pl,
	void* H)
{
		const gp_Pln &  _Pl =*(const gp_Pln *)Pl;
		const gp_Hypr &  _H =*(const gp_Hypr *)H;
	return new gp_Hypr2d( ProjLib::Project(			
_Pl,			
_H));
}
DECL_EXPORT void* ProjLib_ProjectFA59BDF6(
	void* Cy,
	void* P)
{
		const gp_Cylinder &  _Cy =*(const gp_Cylinder *)Cy;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new gp_Pnt2d( ProjLib::Project(			
_Cy,			
_P));
}
DECL_EXPORT void* ProjLib_ProjectDE57BDFB(
	void* Cy,
	void* L)
{
		const gp_Cylinder &  _Cy =*(const gp_Cylinder *)Cy;
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new gp_Lin2d( ProjLib::Project(			
_Cy,			
_L));
}
DECL_EXPORT void* ProjLib_ProjectED02D9F7(
	void* Cy,
	void* Ci)
{
		const gp_Cylinder &  _Cy =*(const gp_Cylinder *)Cy;
		const gp_Circ &  _Ci =*(const gp_Circ *)Ci;
	return new gp_Lin2d( ProjLib::Project(			
_Cy,			
_Ci));
}
DECL_EXPORT void* ProjLib_ProjectF81943F5(
	void* Co,
	void* P)
{
		const gp_Cone &  _Co =*(const gp_Cone *)Co;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new gp_Pnt2d( ProjLib::Project(			
_Co,			
_P));
}
DECL_EXPORT void* ProjLib_Project80DF43EE(
	void* Co,
	void* L)
{
		const gp_Cone &  _Co =*(const gp_Cone *)Co;
		const gp_Lin &  _L =*(const gp_Lin *)L;
	return new gp_Lin2d( ProjLib::Project(			
_Co,			
_L));
}
DECL_EXPORT void* ProjLib_ProjectA92F9F7D(
	void* Co,
	void* Ci)
{
		const gp_Cone &  _Co =*(const gp_Cone *)Co;
		const gp_Circ &  _Ci =*(const gp_Circ *)Ci;
	return new gp_Lin2d( ProjLib::Project(			
_Co,			
_Ci));
}
DECL_EXPORT void* ProjLib_Project1377F951(
	void* Sp,
	void* P)
{
		const gp_Sphere &  _Sp =*(const gp_Sphere *)Sp;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new gp_Pnt2d( ProjLib::Project(			
_Sp,			
_P));
}
DECL_EXPORT void* ProjLib_Project4CF82905(
	void* Sp,
	void* Ci)
{
		const gp_Sphere &  _Sp =*(const gp_Sphere *)Sp;
		const gp_Circ &  _Ci =*(const gp_Circ *)Ci;
	return new gp_Lin2d( ProjLib::Project(			
_Sp,			
_Ci));
}
DECL_EXPORT void* ProjLib_ProjectA0BA3DF1(
	void* To,
	void* P)
{
		const gp_Torus &  _To =*(const gp_Torus *)To;
		const gp_Pnt &  _P =*(const gp_Pnt *)P;
	return new gp_Pnt2d( ProjLib::Project(			
_To,			
_P));
}
DECL_EXPORT void* ProjLib_ProjectB747273A(
	void* To,
	void* Ci)
{
		const gp_Torus &  _To =*(const gp_Torus *)To;
		const gp_Circ &  _Ci =*(const gp_Circ *)Ci;
	return new gp_Lin2d( ProjLib::Project(			
_To,			
_Ci));
}
DECL_EXPORT void ProjLib_Dtor(void* instance)
{
	delete (ProjLib*)instance;
}
