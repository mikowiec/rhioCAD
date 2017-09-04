call "c:\OpenCASCADE6.5.5\ros\env.bat"

set MMGT_CLEAR=1
set MMGT_OPT=1
set MMGT_REENTRANT=1
set OCCBASE=c:\OpenCASCADE6.5.5\
set PATH=%OCCBASE%\ros\win32\vc9\bin;%OCCBASE%\3rdparty\tbb30_018oss\bin\ia32\vc10\;%OCCBASE%\3rdparty\freeimage-vc9-32\bin\;%OCCBASE%\3rdparty\gl2ps-1.3.5-vc9-32\bin\;%OCCBASE%\3rdparty\tcltk-85-32\bin\;%OCCBASE%\3rdparty\ftgl-2.1.3-vc9-32\bin\;%OCCBASE%\3rdparty\freetype-2.4.10-vc9-32\bin\;%path%
start "C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\devenv.exe" "Naro.sln"
