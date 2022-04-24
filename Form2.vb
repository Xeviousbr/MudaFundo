Option Strict Off
Option Explicit On
Friend Class Form2
	Inherits System.Windows.Forms.Form
	Private Data As String
	Private Arq As String
	Private Automatico As New VB6.FixedLengthString(3)
	
	Private Sub btSalvar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btSalvar.Click
		If Option1(0).Checked = True Then
			Automatico.Value = "Não"
		Else
			Automatico.Value = "Sim"
		End If
		FileOpen(1, "Fundo.ini", OpenMode.Output)
		PrintLine(1, Data)
		PrintLine(1, Arq)
		PrintLine(1, Automatico.Value)
		FileClose(1)
		End
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		End
	End Sub
	
	Private Sub Form2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo Default_Renamed
		FileOpen(1, "Fundo.ini", OpenMode.Input)
		Input(1, Data)
		Input(1, Arq)
		Input(1, Automatico.Value)
		FileClose(1)
		
Mostra: 
		If Automatico.Value = "Sim" Then
			Option1(0).Checked = False
			Option1(1).Checked = True
		Else
			Option1(0).Checked = True
			Option1(1).Checked = False
		End If
		Exit Sub
		
Default_Renamed: 
		FileClose(1)
		Automatico.Value = CStr(False)
		GoTo Mostra
	End Sub
End Class