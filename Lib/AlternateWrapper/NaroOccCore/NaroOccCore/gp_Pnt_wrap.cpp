#include "NaroExport.h"

#include <gp_Pnt.hxx>

void* naro_gp_Pnt_ctor()
{
    return new gp_Pnt();
}

double naro_gp_Pnt_X(void* instance)
{
    gp_Pnt* native = (gp_Pnt*)instance;
    return native->X();
}

void naro_gp_Pnt_SetX(void* instance, double X)
{
    gp_Pnt* native = (gp_Pnt*)instance;
    native->SetX(X);
}

void naro_gp_Pnt_dtor(void* instance)
{
    delete (gp_Pnt*)instance;
}
