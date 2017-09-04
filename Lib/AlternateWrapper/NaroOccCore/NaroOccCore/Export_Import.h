#ifndef EXPORT_IMPORT_H
#define EXPORT_IMPORT_H

#ifndef DECL_EXPORT
#  if defined(WIN32)
#    define DECL_EXPORT __declspec(dllexport)
#  endif
#  ifndef DECL_EXPORT
#    define DECL_EXPORT
#  endif
#endif

#include <Standard_TypeDef.hxx>

#endif // EXPORT_IMPORT_H
