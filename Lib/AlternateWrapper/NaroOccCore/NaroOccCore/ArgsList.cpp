#include "NaroExport.h"

#include <vector>

union Register
{
    double Double;
    int Int32;
    void* Pointer;
};

namespace RegTypes
{
    enum Values
    {
        Int,
        Double,
        Ptr
    };

}
std::vector<Register> _registers;
std::vector<RegTypes::Values> _regTypes;
void __stdcall ClearArgs()
{
    _registers.clear();
    _regTypes.clear();
}

void __stdcall AddInt(int value) {
    Register reg;
    reg.Int32 = value;
    _registers.push_back(reg);
    _regTypes.push_back(RegTypes::Int);
}

void __stdcall AddDouble(double value) {
    Register reg;
    reg.Double = value;
    _registers.push_back(reg);
    _regTypes.push_back(RegTypes::Double);
}

void __stdcall AddPtr(void* value) {
    Register reg;
    reg.Pointer = value;
    _registers.push_back(reg);
    _regTypes.push_back(RegTypes::Ptr);
}
