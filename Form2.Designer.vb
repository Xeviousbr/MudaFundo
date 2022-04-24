<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form2
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
	Public WithEvents _Option1_1 As System.Windows.Forms.RadioButton
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents btSalvar As System.Windows.Forms.Button
	Public WithEvents _Option1_0 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._Option1_1 = New System.Windows.Forms.RadioButton
		Me.Command1 = New System.Windows.Forms.Button
		Me.btSalvar = New System.Windows.Forms.Button
		Me._Option1_0 = New System.Windows.Forms.RadioButton
		Me.Option1 = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Option1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Configuração do Muda Fundo"
		Me.ClientSize = New System.Drawing.Size(260, 61)
		Me.Location = New System.Drawing.Point(231, 235)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form2"
		Me._Option1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_1.Text = "Mover automaticamente"
		Me._Option1_1.Size = New System.Drawing.Size(281, 13)
		Me._Option1_1.Location = New System.Drawing.Point(0, 16)
		Me._Option1_1.TabIndex = 3
		Me._Option1_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Option1_1.CausesValidation = True
		Me._Option1_1.Enabled = True
		Me._Option1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option1_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option1_1.TabStop = True
		Me._Option1_1.Checked = False
		Me._Option1_1.Visible = True
		Me._Option1_1.Name = "_Option1_1"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.Command1
		Me.Command1.Text = "Cancelar"
		Me.AcceptButton = Me.Command1
		Me.Command1.Size = New System.Drawing.Size(81, 25)
		Me.Command1.Location = New System.Drawing.Point(160, 32)
		Me.Command1.TabIndex = 2
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btSalvar.Text = "Salvar"
		Me.btSalvar.Size = New System.Drawing.Size(81, 25)
		Me.btSalvar.Location = New System.Drawing.Point(24, 32)
		Me.btSalvar.TabIndex = 1
		Me.btSalvar.BackColor = System.Drawing.SystemColors.Control
		Me.btSalvar.CausesValidation = True
		Me.btSalvar.Enabled = True
		Me.btSalvar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Default
		Me.btSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btSalvar.TabStop = True
		Me.btSalvar.Name = "btSalvar"
		Me._Option1_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_0.Text = "Avisar quando não existir mais imagens na pasta"
		Me._Option1_0.Size = New System.Drawing.Size(281, 17)
		Me._Option1_0.Location = New System.Drawing.Point(0, 0)
		Me._Option1_0.TabIndex = 0
		Me._Option1_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Option1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Option1_0.CausesValidation = True
		Me._Option1_0.Enabled = True
		Me._Option1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Option1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Option1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Option1_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Option1_0.TabStop = True
		Me._Option1_0.Checked = False
		Me._Option1_0.Visible = True
		Me._Option1_0.Name = "_Option1_0"
		Me.Controls.Add(_Option1_1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(btSalvar)
		Me.Controls.Add(_Option1_0)
		Me.Option1.SetIndex(_Option1_1, CType(1, Short))
		Me.Option1.SetIndex(_Option1_0, CType(0, Short))
		CType(Me.Option1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class