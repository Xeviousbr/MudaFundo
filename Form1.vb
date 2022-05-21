Option Strict Off
Option Explicit On
Imports System.Threading
Imports VB = Microsoft.VisualBasic
Friend Class Form1
    Inherits System.Windows.Forms.Form
    'Alterações futuras
    '1) Fazer a renovação no desktop imediatamente após a troca do arquivo
    '2) Não deixar a imagem de ante-ontem aparecer
    '3) Fazer uma critica de pontuação para mostrar sempre as imagens menos mostradas

    Private X As Short
    Private DirFoi As String
    Private Arq As String
    Private Quant As Short

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If VB.Command() = "D" Then
            Form2.Show()
        Else
            MudaFundo()
        End If
    End Sub

    Private Sub MudaFundo()
        Dim Data As String
        Dim Hoje As New VB6.FixedLengthString(10)
        Dim Escolha As Short
        Dim PICT As System.Drawing.Image
        Dim Automatico As String

        Const MsgErrFim As String = "O programa MudaFundo não poderá funcionar"

        Randomize()

        'Gambiarra
        Dim EsseDir As String = "H:\Imagens"

        DirFoi = EsseDir & "\Foi"
        FileOpen(1, EsseDir & "\MudaFundo.ini", OpenMode.Input)
        Input(1, Data)
        Input(1, Arq)
        Input(1, Automatico)

        On Error GoTo 0
        FileClose(1)
        Dim repetido As Boolean = False
Apaga:
        On Error Resume Next
        Kill(EsseDir & "\" & Arq)
        On Error GoTo 0

Inicio:
        File.Path = EsseDir
        File.Refresh()
        Quant = File.Items.Count
        If File.Items.Count = 0 Then
            On Error GoTo SemFoi2
            File.Path = DirFoi
            On Error GoTo 0
            Quant = File.Items.Count
            If File.Items.Count = 0 Then
                MsgBox("Não existem imagens no diretório do programa nem no diretório FOI", MsgBoxStyle.Critical, MsgErrFim)
                End
            Else
                If Automatico = "Sim" Then
                    MoveImagens()
                    GoTo Inicio
                Else
                    If MsgBox("Quer que trazer as imagens do diretório FOI para o das imagens?", MsgBoxStyle.YesNo, "Não existem mais imagens neste diretório") = MsgBoxResult.No Then
                        End
                    Else
                        MoveImagens()
                        GoTo Inicio
                    End If
                End If
            End If
        End If
        Hoje.Value = VB6.Format(Today, "dd/mm/yyyy")
Continua:
        If repetido = False Then
            If Data = Hoje.Value Then
                If MsgBox("Deseja trocar o arquivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "O programa já foi executado hoje") = MsgBoxResult.No Then
                    End
                Else
                    repetido = True
                    If MsgBox("Deseja apagar o arquivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "O programa já foi executado hoje") = MsgBoxResult.No Then
                        GoTo Inicio
                    Else
                        GoTo Apaga
                    End If
                End If
            End If
        End If

        Escolha = Int(Quant * Rnd())
        Arq = File.Items(Escolha)

        Dim TemJpg As Integer = InStr(LCase(Arq), "jpg")
        If TemJpg = 0 Then
            MsgBox("Arquivo sem extensão jpg")
        End If

        FileOpen(1, "H:\Imagens\MudaFundo.ini", OpenMode.Output)
        PrintLine(1, Hoje.Value)
        PrintLine(1, Arq)
        PrintLine(1, Automatico)
        FileClose(1)

        PICT = System.Drawing.Image.FromFile(Arq)
        PICT.Save("Fundo.bmp")
MoveJpg:
        FileCopy(EsseDir & "\" & Arq, DirFoi & "\" & Arq)
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, EsseDir & "\Fundo.bmp", SPIF_SENDWININICHANGE Or SPIF_UPDATEINIFILE)
        End
SemDirFoi:
        If Err.Number = 76 Then
            MkDir("Foi")
            Resume MoveJpg
        Else
            MsgBox("Erro de tipo: '" & ErrorToString(Err.Number) & "' na operação de cópia do arqivo", MsgBoxStyle.Critical, "MudaFundo")
            End
        End If

SemFoi2:
        MsgBox("Não existem imagens nem no diretório corrente e não existe o diretório FOI", MsgBoxStyle.Critical, MsgErrFim)
        End

ConfAutomatico:
        FileClose(1)
        Resume Inicio

SemIni:
        FileClose(1)
        Data = CStr(0)
        Resume Continua
    End Sub
    Private Sub MoveImagens()
        Dim Label2 As Object
        Me.Visible = True
        For X = (Quant - 1) To 0 Step -1
            Arq = File.Items(X)
            FileCopy(DirFoi & "\" & Arq, CurDir() & "\" & Arq)
            Kill(DirFoi & "\" & Arq)
            'UPGRADE_WARNING: Couldn't resolve default property of object Label2.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Label2.Caption = Trim(Str(Int(((Quant - X) / Quant) * 100))) & " %"
            'UPGRADE_WARNING: Couldn't resolve default property of object Label2.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Label2.Refresh()
        Next
    End Sub
End Class