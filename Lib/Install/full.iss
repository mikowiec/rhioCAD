[Setup]
AppName=NaroCAD
AppVerName=NaroCAD 1.8.8 Beta
AppPublisher=NaroCAD Team
Compression=lzma2/ultra
SolidCompression=true
MinVersion=0,5.01.2600sp2
AllowRootDirectory=true
DefaultDirName={pf32}\NaroCAD
DefaultGroupName=NaroCAD
EnableDirDoesntExistWarning=false
RestartIfNeededByRun=false
UninstallLogMode=new
UninstallDisplayIcon={app}\naro.ico

WizardImageFile=InstallerImage.bmp
WizardSmallImageFile=SmallImage.bmp

[Languages]
Name: en; MessagesFile: compiler:Default.isl

[Types]
Name: *.naroxml; Description: NaroCAD File

[Files]
Source: ..\..\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Release\*.exe; DestDir: {app}; Flags: ignoreversion; Languages:

Source: options.nxml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\background.bmp; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\NewFile.naroxml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\naroLayout.xml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\defaultNaroLayout.xml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\DockPanel.config; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\*.caps; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\*.naro; DestDir: {app}; Flags: ignoreversion
Source: ..\..\bin\Debug\Boo\*.boo; DestDir: {app}\Boo\; Flags: ignoreversion
Source: ..\..\bin\Debug\Boo\Actions\*.*; DestDir: {app}\Boo\Actions\; Flags: ignoreversion
Source: ..\..\bin\Debug\Boo\Scripts\*.*; DestDir: {app}\Boo\Scripts\; Flags: ignoreversion
Source: ..\..\bin\Debug\Boo\Library\*.*; DestDir: {app}\Boo\Library\; Flags: ignoreversion
Source: ..\..\bin\Debug\Pics\horizontal_constraint.bmp; DestDir: {app}\Pics\; Flags: ignoreversion
Source: ..\..\bin\Debug\Pics\perpendicular_constraint.bmp; DestDir: {app}\Pics\; Flags: ignoreversion
Source: ..\..\bin\Debug\Pics\parallel_constraint.bmp; DestDir: {app}\Pics\; Flags: ignoreversion
Source: ..\..\bin\Release\AppShell.exe.config; DestDir: {app}; Flags: ignoreversion

Source: c:\occBase\3rdparty\tcltk-85-32\bin\*.dll; DestDir: {app}\occ\3rdparty\win32\tcltk\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\freeimage-vc9-32\bin\*.dll; DestDir: {app}\occ\3rdparty\win32\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\tbb30_018oss\bin\ia32\vc10\tbbmalloc.dll; DestDir: {app}\occ\3rdparty\win32\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\tbb30_018oss\bin\ia32\vc10\tbb.dll; DestDir: {app}\occ\3rdparty\win32\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\freeimage-vc9-32\bin\*.dll; DestDir: {app}\occ\3rdparty\win32\freeimage\bin; Flags: ignoreversion 
Source: c:\occBase\3rdparty\gl2ps-1.3.5-vc9-32\bin\*.dll; DestDir: {app}\occ\ros\win32\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\ftgl-2.1.3-vc9-32\bin\*.dll; DestDir: {app}\occ\ros\win32\bin; Flags: ignoreversion
Source: c:\occBase\3rdparty\freetype-2.4.10-vc9-32\bin\*.dll; DestDir: {app}\occ\ros\win32\bin; Flags: ignoreversion
Source: c:\occBase\ros\win32\vc9\bin\*.dll; DestDir: {app}\occ\ros\win32\bin; Flags: ignoreversion

Source: c:\occBase\ros\src\UnitsAPI\CurrentUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occBase\ros\src\UnitsAPI\Lexi_Expr.dat; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occBase\ros\src\UnitsAPI\MDTVBaseUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occBase\ros\src\UnitsAPI\MDTVCurrentUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occBase\ros\src\UnitsAPI\Units.dat; DestDir: {app}\occ\ros\src\UnitsAPI

Source: c:\occBase\ros\src\SHMessage\SHAPE.us; DestDir: {app}\occ\ros\src\SHMessage
Source: c:\occBase\ros\src\XSMessage\IGES.us; DestDir: {app}\occ\ros\src\XSMessage
Source: c:\occBase\ros\src\XSMessage\XSTEP.us; DestDir: {app}\occ\ros\src\XSMessage
Source: c:\occBase\ros\src\XSTEPResource\STEP; DestDir: {app}\occ\ros\src\XSTEPResource
Source: c:\occBase\ros\src\XSTEPResource\IGES; DestDir: {app}\occ\ros\src\XSTEPResource

;Source: c:\occBase\ros\..\3rdparty\win32\vs\*.dll; DestDir: {app}\occ\3rdparty\win32\vs; Flags: ignoreversion
Source: ..\..\lib\install\bats\env.bat; DestDir: {app}\occ\ros; Flags: ignoreversion

Source: ..\..\Tutorial.pdf; DestDir: {app}; Flags: ignoreversion
Source: ..\..\lib\install\readme.txt; DestDir: {app}; Flags: isreadme

Source: ..\..\bin\debug\Help\*.*; DestDir: {app}\Help; Flags: ignoreversion
Source: ..\..\bin\debug\Help\images\*.*; DestDir: {app}\Help\images; Flags: ignoreversion
Source: ..\..\bin\debug\Help\Boo\*.html; DestDir: {app}\Help\Lua; Flags: ignoreversion
Source: ..\..\bin\debug\Wpf\TipsPages\*.*; DestDir: {app}\Wpf\TipsPages; Flags: ignoreversion
Source: ..\..\bin\debug\Shaders\*.*; DestDir: {app}\Shaders; Flags: ignoreversion

Source: ..\..\Source\TwoPointLinePlugin\Properties\*.*; DestDir: {app}\Source\TwoPointLinePlugin\Properties;  Flags: ignoreversion
Source: ..\..\Source\TwoPointLinePlugin\*.cs; DestDir: {app}\Source\TwoPointLinePlugin;  Flags: ignoreversion
Source: ..\..\Source\TwoPointLinePlugin\*.csproj; DestDir: {app}\Source\TwoPointLinePlugin;  Flags: ignoreversion
Source: ..\..\Source\TwoPointLinePlugin\*.xaml; DestDir: {app}\Source\TwoPointLinePlugin;  Flags: ignoreversion

Source: Version.xml; DestDir: {app}; Flags: ignoreversion

;VS Runtime
Source: ..\..\Lib\install\lib\vs\*.*; DestDir: {app}
Source: ..\..\Source\Images\view_comp_on_copy.ico; DestDir: {app}; DestName: naro.ico
;Source: options.nxml; DestDir: {app}
Source: ..\..\bin\Debug\naro.cfg; DestDir: {app}

[Tasks]
; NOTE: The following entry contains English phrases ("Create a desktop icon" and "Additional icons"). You are free to translate them into another language if required.
Name: "desktopicon"; Description: "Create a &desktop icon"; GroupDescription: "Desktop Icons"

[Icons]
Name: {group}\NaroCAD; Filename: {app}\NaroStarter.exe; WorkingDir: {app}; IconFilename: {app}\naro.ico; IconIndex: 0
Name: "{userdesktop}\NaroCAD"; Filename: "{app}\NaroStarter.exe"; WorkingDir: {app}; Tasks: desktopicon
Name: {group}\UninstallProgram; Filename: {uninstallexe}

;[Registry]
;Root: HKLM; Subkey: System\CurrentControlSet\Control\Session Manager\Environment; ValueType: string; ValueName: CASROOT; ValueData: {app}\occ\ros\win32\bin; Flags: createvalueifdoesntexist; Languages: 

[Run]
Filename: "{app}\NaroStarter.exe"; Description: "Launch NaroCAD"; Flags: nowait postinstall skipifsilent
Filename: "{dotnet20}\ngen.exe"; Parameters: "install {app}\AppShell.exe /queue"; StatusMsg: "Optimizing performance, it may take a while"; Flags: runhidden;

[UninstallRun]
Filename: "{dotnet20}\ngen.exe"; Parameters: "uninstall {app}\AppShell.exe"; StatusMsg: "Cleanup"; Flags: runhidden;

