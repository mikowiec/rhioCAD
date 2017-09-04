set PATH=%CASROOT%\..\3rdparty\win32\vs;%CASROOT%\..\3rdparty\win32\tcltk\bin;%CASROOT%\..\3rdparty\win32\bin;%CASROOT%\win32\bin;%PATH%
set CSF_MDTVFontDirectory=%CASROOT%\src\FontMFT
set CSF_LANGUAGE=us
set MMGT_CLEAR=1
set MMGT_OPT=1
set MMGT_REENTRANT=1
set CSF_EXCEPTION_PROMPT=1

set CSF_SHMessage=%CASROOT%\src\SHMessage
set CSF_MDTVTexturesDirectory=%CASROOT%\src\Textures
set CSF_XSMessage=%CASROOT%\src\XSMessage
set CSF_StandardDefaults=%CASROOT%\src\StdResource
set CSF_PluginDefaults=%CASROOT%\src\StdResource
set CSF_XCAFDefaults=%CASROOT%\src\StdResource
set CSF_StandardLiteDefaults=%CASROOT%\src\StdResource
set CSF_GraphicShr=%CASROOT%\win32\bin\TKOpenGl.dll
set CSF_UnitsLexicon=%CASROOT%\src\UnitsAPI\Lexi_Expr.dat
set CSF_UnitsDefinition=%CASROOT%\src\UnitsAPI\Units.dat
set CSF_IGESDefaults=%CASROOT%\src\XSTEPResource
set CSF_STEPDefaults=%CASROOT%\src\XSTEPResource
set CSF_XmlOcafResource=%CASROOT%\src\XmlOcafResource

set TCLLIBPATH=%CASROOT%\..\3rdparty\win32\tcltk\lib
set TCL_LIBRARY=%CASROOT%\..\3rdparty\win32\tcltk\lib\tcl8.4
set TK_LIBRARY=%CASROOT%\..\3rdparty\win32\tcltk\lib\tk8.4
set TIX_LIBRARY=%CASROOT%\..\3rdparty\win32\tcltk\lib\tix8.1

appshell.exe %1 %2 %3 %4 %5 
