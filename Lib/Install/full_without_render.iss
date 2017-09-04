[Setup]
AppName=NaroCAD
AppVerName=NaroCAD 1.5.0
AppPublisher=NaroCAD Team
Compression=lzma
SolidCompression=true
MinVersion=0,5.01.2600sp2
AllowRootDirectory=true
DefaultDirName=C:\NaroCAD
DefaultGroupName=NaroCAD
EnableDirDoesntExistWarning=false
RestartIfNeededByRun=false
UninstallLogMode=new
UninstallDisplayIcon={app}\naro.ico

[Languages]
Name: en; MessagesFile: compiler:Default.isl

[Types]
Name: *.naroxml; Description: NaroCAD File

[Files]
Source: ..\..\narocad\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\bin\Release\*.exe; DestDir: {app}; Flags: ignoreversion; Languages:

Source: ..\..\narocad\bin\Debug\NewFile.naroxml; DestDir: {app}\Samples; Flags: ignoreversion
Source: ..\..\narocad\bin\Debug\DockPanel.config; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\bin\Debug\options.nxml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\bin\Release\AppShell.exe.config; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\Source\AppShell\AppShell\ProfileCatalog.xml; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\bin\Debug\shape_options_dialog.lua; DestDir: {app}\Samples\Lua; Flags: ignoreversion
Source: ..\..\narocad\bin\Debug\shape_sample.lua; DestDir: {app}\Samples\Lua; Flags: ignoreversion
Source: ..\..\narocad\bin\Debug\table.lua; DestDir: {app}\Samples\Lua; Flags: ignoreversion

Source: ..\..\narocad\Lib\Lua51.dll; DestDir: {app}; Flags: ignoreversion

Source: ..\..\narocad\Lib\SciLexer.dll; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\Lib\ScintillaNet.dll; DestDir: {app}; Flags: ignoreversion
Source: ..\..\narocad\Lib\scintilla-license.txt; DestDir: {app}; Flags: ignoreversion

Source: c:\occ\3rdparty\win32\tcltk\bin\*.dll; DestDir: {app}\occ\3rdparty\win32\tcltk\bin; Flags: ignoreversion
Source: c:\occ\ros\win32\bin\*.dll; DestDir: {app}\occ\ros\win32\bin; Flags: ignoreversion

Source: c:\occ\ros\src\UnitsAPI\CurrentUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occ\ros\src\UnitsAPI\Lexi_Expr.dat; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occ\ros\src\UnitsAPI\MDTVBaseUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occ\ros\src\UnitsAPI\MDTVCurrentUnits; DestDir: {app}\occ\ros\src\UnitsAPI
Source: c:\occ\ros\src\UnitsAPI\Units.dat; DestDir: {app}\occ\ros\src\UnitsAPI

Source: c:\occ\ros\src\SHMessage\SHAPE.us; DestDir: {app}\occ\ros\src\SHMessage
Source: c:\occ\ros\src\XSMessage\IGES.us; DestDir: {app}\occ\ros\src\XSMessage
Source: c:\occ\ros\src\XSMessage\XSTEP.us; DestDir: {app}\occ\ros\src\XSMessage
Source: c:\occ\ros\src\XSTEPResource\STEP; DestDir: {app}\occ\ros\src\XSTEPResource
Source: c:\occ\ros\src\XSTEPResource\IGES; DestDir: {app}\occ\ros\src\XSTEPResource

Source: c:\occ\ros\..\3rdparty\win32\vs\*.dll; DestDir: {app}\occ\3rdparty\win32\vs; Flags: ignoreversion
Source: bats\env.bat; DestDir: {app}\occ\ros; Flags: ignoreversion

Source: ..\..\narocad\Tutorial.pdf; DestDir: {app}; Flags: ignoreversion
Source: Readme.txt; DestDir: {app}; Flags: isreadme

Source: ..\..\narocad\bin\debug\Help\*.*; DestDir: {app}\Help; Flags: ignoreversion
Source: ..\..\narocad\bin\debug\Help\images\*.*; DestDir: {app}\Help\images; Flags: ignoreversion
Source: ..\..\narocad\bin\debug\Help\lua\*.html; DestDir: {app}\Help\Lua; Flags: ignoreversion


;VS Runtime
Source: Lib\vs\Microsoft.VC90.CRT.manifest; DestDir: {app}
Source: Lib\vs\msvcm90.dll; DestDir: {app}
Source: Lib\vs\msvcp90.dll; DestDir: {app}
Source: Lib\vs\msvcr90.dll; DestDir: {app}
Source: ..\..\narocad\Source\Images\view_comp_on copy.ico; DestDir: {app}; DestName: naro.ico
Source: ..\..\narocad\bin\Debug\options.nxml; DestDir: {app}

;Svn
Source: Lib\svn\*.*; DestDir: {app}

[Icons]
Name: {group}\NaroCAD; Filename: {app}\NaroStarter.exe; WorkingDir: {app}; IconFilename: {app}\naro.ico; IconIndex: 0
Name: {group}\UninstallProgram; Filename: {uninstallexe}

[Registry]
Root: HKLM; Subkey: System\CurrentControlSet\Control\Session Manager\Environment; ValueType: string; ValueName: CASROOT; ValueData: {app}\occ\ros\win32\bin; Flags: createvalueifdoesntexist; Languages: 

