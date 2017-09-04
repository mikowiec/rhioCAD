// File generated by CPPExt (CPP file)
//

#include "TColStd_StackIteratorOfStackOfInteger.h"
#include "../Converter.h"
#include "TColStd_StackOfInteger.h"
#include "TColStd_StackNodeOfStackOfInteger.h"


using namespace OCNaroWrappers;

OCTColStd_StackIteratorOfStackOfInteger::OCTColStd_StackIteratorOfStackOfInteger(TColStd_StackIteratorOfStackOfInteger* nativeHandle) 
{
  this->nativeHandle = nativeHandle;
}

OCTColStd_StackIteratorOfStackOfInteger::OCTColStd_StackIteratorOfStackOfInteger() 
{
  nativeHandle = new TColStd_StackIteratorOfStackOfInteger();
}

OCTColStd_StackIteratorOfStackOfInteger::OCTColStd_StackIteratorOfStackOfInteger(OCNaroWrappers::OCTColStd_StackOfInteger^ S) 
{
  nativeHandle = new TColStd_StackIteratorOfStackOfInteger(*((TColStd_StackOfInteger*)S->Handle));
}

 void OCTColStd_StackIteratorOfStackOfInteger::Initialize(OCNaroWrappers::OCTColStd_StackOfInteger^ S)
{
  ((TColStd_StackIteratorOfStackOfInteger*)nativeHandle)->Initialize(*((TColStd_StackOfInteger*)S->Handle));
}

 System::Boolean OCTColStd_StackIteratorOfStackOfInteger::More()
{
  return OCConverter::StandardBooleanToBoolean(((TColStd_StackIteratorOfStackOfInteger*)nativeHandle)->More());
}

 void OCTColStd_StackIteratorOfStackOfInteger::Next()
{
  ((TColStd_StackIteratorOfStackOfInteger*)nativeHandle)->Next();
}

 Standard_Integer OCTColStd_StackIteratorOfStackOfInteger::Value()
{
  return ((TColStd_StackIteratorOfStackOfInteger*)nativeHandle)->Value();
}


