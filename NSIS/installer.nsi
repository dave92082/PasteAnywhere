OutFile "PasteAnywhereSetup.exe"
InstallDir $PROGRAMFILES\PasteAnywhere

Page components
Page directory
page instfiles
UninstPage uninstConfirm
UninstPage instfiles

Section "PasteAnywhere"
	SetOutPath $INSTDIR
	FILE ..\PasteAnywhere\bin\Release\PasteAnywhere.exe
	File ..\PasteAnywhere\bin\Release\KeystrokeAPI.dll
	CreateShortCut "$SMSTARTUP\PasteAnywhere.lnk" "$INSTDIR\PasteAnywhere.exe"
	WriteUninstaller $INSTDIR\Uninstall.exe
	ExecShell "" "$INSTDIR\PasteAnywhere.exe"
SectionEnd

Section "Uninstall"
	Delete $INSTDIR\Uninstall.exe
	Delete $SMSTARTUP\PasteAnywhere.lnk
	Delete $INSTDIR\PasteAnywhere.exe
	Delete $INSTDIR\KeystrokeAPI.dll
	RMDir $INSTDIR
SectionEnd
