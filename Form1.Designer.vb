<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents File As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.File = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(108, 63)
		Me.Location = New System.Drawing.Point(288, 234)
		Me.Visible = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form1"
		Me.File.Size = New System.Drawing.Size(81, 19)
		Me.File.Location = New System.Drawing.Point(12, 12)
		Me.File.Pattern = "*.jpg"
		Me.File.TabIndex = 0
		Me.File.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.File.Archive = True
		Me.File.BackColor = System.Drawing.SystemColors.Window
		Me.File.CausesValidation = True
		Me.File.Enabled = True
		Me.File.ForeColor = System.Drawing.SystemColors.WindowText
		Me.File.Hidden = False
		Me.File.Cursor = System.Windows.Forms.Cursors.Default
		Me.File.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.File.Normal = True
		Me.File.ReadOnly = True
		Me.File.System = False
		Me.File.TabStop = True
		Me.File.TopIndex = 0
		Me.File.Visible = True
		Me.File.Name = "File"
		Me.Controls.Add(File)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class