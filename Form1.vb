Option Strict Off
Option Explicit On
Imports System.Threading
Imports VB = Microsoft.VisualBasic
Friend Class Form1
    Inherits System.Windows.Forms.Form
    'Altera��es futuras
    '1) Fazer a renova��o no desktop imediatamente ap�s a troca do arquivo
    '2) N�o deixar a imagem de ante-ontem aparecer
    '3) Fazer uma critica de pontua��o para mostrar sempre as imagens menos mostradas

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
        'Dim Automatico As New VB6.FixedLengthString(3)

        Const MsgErrFim As String = "O programa MudaFundo n�o poder� funcionar"

        Randomize()

        'Gambiarra
        Dim EsseDir As String = "H:\Imagens"

        DirFoi = EsseDir & "\Foi"
        'On Error GoTo SemIni
        FileOpen(1, EsseDir & "\MudaFundo.ini", OpenMode.Input)
        Input(1, Data)
        Input(1, Arq)
        'On Error GoTo ConfAutomatico

        Input(1, Automatico)
        'Input(1, Automatico.Value)

        On Error GoTo 0
        FileClose(1)

        On Error Resume Next
        Kill(EsseDir & "\" & Arq)
        On Error GoTo 0
        Dim repetido As Boolean = False

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
                MsgBox("N�o existem imagens no diret�rio do programa nem no diret�rio FOI", MsgBoxStyle.Critical, MsgErrFim)
                End
            Else
                If Automatico = "Sim" Then
                    MoveImagens()
                    GoTo Inicio
                Else
                    If MsgBox("Quer que trazer as imagens do diret�rio FOI para o das imagens?", MsgBoxStyle.YesNo, "N�o existem mais imagens neste diret�rio") = MsgBoxResult.No Then
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
                If MsgBox("Deseja trocar o arquivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "O programa j� foi executado hoje") = MsgBoxResult.No Then
                    End
                Else
                    repetido = True
                    GoTo Inicio
                End If
            End If
        End If

        Escolha = Int(Quant * Rnd())
        Arq = File.Items(Escolha)

        Dim TemJpg As Integer = InStr(LCase(Arq), "jpg")
        If TemJpg = 0 Then
            MsgBox("Arquivo sem extens�o jpg")
        End If

        FileOpen(1, "H:\Imagens\MudaFundo.ini", OpenMode.Output)
        PrintLine(1, Hoje.Value)
        PrintLine(1, Arq)
        PrintLine(1, Automatico)
        FileClose(1)

        PICT = System.Drawing.Image.FromFile(Arq)
        'UPGRADE_WARNING: SavePicture was upgraded to System.Drawing.Image.Save and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        PICT.Save("Fundo.bmp")

        'On Error GoTo SemDirFoi
MoveJpg:
        FileCopy(EsseDir & "\" & Arq, DirFoi & "\" & Arq)
        'On Error GoTo 0
        'Kill(EsseDir & "\" & Arq)
        '   Arq = CurDir + "\Fundo.jpg"
        'X = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0&, "(None)", SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)

        '   X = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0&, (CurDir + "\Preto.bmp"), SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
        '
        '   X = DoEvents
        'Arq = EsseDir & "\Fundo.bmp"
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, EsseDir & "\Fundo.bmp", SPIF_SENDWININICHANGE Or SPIF_UPDATEINIFILE)
        'SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Arq, SPIF_SENDWININICHANGE Or SPIF_UPDATEINIFILE)
        'SystemParametersInfo SPI_SETDESKWALLPAPER, 0&, ByVal xFile, SPIF_SENDWININICHANGE Or SPIF_UPDATEINIFILE

        'X = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0&, (CurDir + "\Fundo.bmp"), SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)

        '   X = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0&, Arq, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
        '   WinExec "rundll32.exe shell32.dll,Control_RunDLL desk.cpl,,0", 0

        'Thread.Sleep(100)
        'On Error Resume Next
        'Kill(EsseDir & "\" & Arq)
        End

SemDirFoi:
        If Err.Number = 76 Then
            MkDir("Foi")
            Resume MoveJpg
        Else
            MsgBox("Erro de tipo: '" & ErrorToString(Err.Number) & "' na opera��o de c�pia do arqivo", MsgBoxStyle.Critical, "MudaFundo")
            End
        End If

SemFoi2:
        MsgBox("N�o existem imagens nem no diret�rio corrente e n�o existe o diret�rio FOI", MsgBoxStyle.Critical, MsgErrFim)
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