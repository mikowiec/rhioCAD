#include "gp.h"
#include <gp.hxx>

#include <gp_Ax1.hxx>
#include <gp_Ax2.hxx>
#include <gp_Ax2d.hxx>
#include <gp_Dir.hxx>
#include <gp_Dir2d.hxx>
#include <gp_Pnt.hxx>
#include <gp_Pnt2d.hxx>

DECL_EXPORT double gp_Resolution()
{
	return gp::Resolution();
}

DECL_EXPORT void* gp_Origin()
{
	return 	new gp_Pnt(gp::Origin());
}

DECL_EXPORT void* gp_DX()
{
	return 	new gp_Dir(gp::DX());
}

DECL_EXPORT void* gp_DY()
{
	return 	new gp_Dir(gp::DY());
}

DECL_EXPORT void* gp_DZ()
{
	return 	new gp_Dir(gp::DZ());
}

DECL_EXPORT void* gp_OX()
{
	return 	new gp_Ax1(gp::OX());
}

DECL_EXPORT void* gp_OY()
{
	return 	new gp_Ax1(gp::OY());
}

DECL_EXPORT void* gp_OZ()
{
	return 	new gp_Ax1(gp::OZ());
}

DECL_EXPORT void* gp_XOY()
{
	return 	new gp_Ax2(gp::XOY());
}

DECL_EXPORT void* gp_ZOX()
{
	return 	new gp_Ax2(gp::ZOX());
}

DECL_EXPORT void* gp_YOZ()
{
	return 	new gp_Ax2(gp::YOZ());
}

DECL_EXPORT void* gp_Origin2d()
{
	return 	new gp_Pnt2d(gp::Origin2d());
}

DECL_EXPORT void* gp_DX2d()
{
	return 	new gp_Dir2d(gp::DX2d());
}

DECL_EXPORT void* gp_DY2d()
{
	return 	new gp_Dir2d(gp::DY2d());
}

DECL_EXPORT void* gp_OX2d()
{
	return 	new gp_Ax2d(gp::OX2d());
}

DECL_EXPORT void* gp_OY2d()
{
	return 	new gp_Ax2d(gp::OY2d());
}

DECL_EXPORT void gp_Dtor(void* instance)
{
	delete (gp*)instance;
}
