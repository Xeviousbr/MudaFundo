Option Strict Off
Option Explicit On

Module Module1
	'Public Declare Function WinExec Lib "kernel32" (ByVal lpCmdLine As String, ByVal nCmdShow As Long) As Long
	
	Public Declare Function SystemParametersInfo Lib "user32"  Alias "SystemParametersInfoA"(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
	Public Const SPIF_UPDATEINIFILE As Integer = &H1
	Public Const SPI_SETDESKWALLPAPER As Short = 20
	Public Const SPIF_SENDWININICHANGE As Integer = &H2
	
	Private Declare Function RegOpenKey Lib "advapi32.dll"  Alias "RegOpenKeyA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'

    'Private Declare Function RegSetValueEx Lib "advapi32.dll"  Alias "RegSetValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Any, ByVal cbData As Integer) As Integer
    Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hkey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, ByVal lpData As String, ByVal cbData As Long) As Long

	Private Declare Function RegFlushKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
	Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
	Public Const HKEY_CURRENT_USER As Integer = &H80000001
	
	Public Sub WriteRegistry(ByVal Group As Integer, ByVal Section As String, ByVal Key As String, ByRef NewVal As String)
		Dim lResult As Integer
		Dim lKeyValue As Integer
		Dim InLen As Integer
		Dim strBuf As String
		Dim Dado As New VB6.FixedLengthString(1024)
		
		InLen = Len(NewVal)
		Dado.Value = NewVal & New String(Chr(0), 1024 - InLen)
		lResult = RegOpenKey(Group, Section, lKeyValue)
		lResult = RegSetValueEx(lKeyValue, Key, 0, 1, Dado.Value, InLen)
		lResult = RegFlushKey(lKeyValue)
		lResult = RegCloseKey(lKeyValue)
	End Sub
End Module