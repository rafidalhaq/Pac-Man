Public Class OptionsForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents chkQuickGhost As System.Windows.Forms.CheckBox
    Friend WithEvents chkSuperGhosts As System.Windows.Forms.CheckBox
    Friend WithEvents btnHighReset As System.Windows.Forms.Button
    Friend WithEvents chkSuperPac As System.Windows.Forms.CheckBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OptionsForm))
        Me.chkQuickGhost = New System.Windows.Forms.CheckBox
        Me.chkSuperGhosts = New System.Windows.Forms.CheckBox
        Me.btnHighReset = New System.Windows.Forms.Button
        Me.chkSuperPac = New System.Windows.Forms.CheckBox
        Me.btnDone = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkQuickGhost
        '
        Me.chkQuickGhost.Checked = True
        Me.chkQuickGhost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuickGhost.ForeColor = System.Drawing.Color.White
        Me.chkQuickGhost.Location = New System.Drawing.Point(16, 8)
        Me.chkQuickGhost.Name = "chkQuickGhost"
        Me.chkQuickGhost.Size = New System.Drawing.Size(144, 40)
        Me.chkQuickGhost.TabIndex = 0
        Me.chkQuickGhost.Text = "Random Super Ghost Level 2 and up"
        '
        'chkSuperGhosts
        '
        Me.chkSuperGhosts.ForeColor = System.Drawing.Color.White
        Me.chkSuperGhosts.Location = New System.Drawing.Point(16, 56)
        Me.chkSuperGhosts.Name = "chkSuperGhosts"
        Me.chkSuperGhosts.Size = New System.Drawing.Size(120, 24)
        Me.chkSuperGhosts.TabIndex = 1
        Me.chkSuperGhosts.Text = "All Super Ghosts"
        '
        'btnHighReset
        '
        Me.btnHighReset.ForeColor = System.Drawing.Color.White
        Me.btnHighReset.Location = New System.Drawing.Point(24, 120)
        Me.btnHighReset.Name = "btnHighReset"
        Me.btnHighReset.Size = New System.Drawing.Size(104, 23)
        Me.btnHighReset.TabIndex = 2
        Me.btnHighReset.Text = "Reset High Score"
        '
        'chkSuperPac
        '
        Me.chkSuperPac.ForeColor = System.Drawing.Color.White
        Me.chkSuperPac.Location = New System.Drawing.Point(16, 88)
        Me.chkSuperPac.Name = "chkSuperPac"
        Me.chkSuperPac.TabIndex = 3
        Me.chkSuperPac.Text = "Super PacMan"
        '
        'btnDone
        '
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(39, 152)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Apply"
        '
        'OptionsForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(152, 182)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.chkSuperPac)
        Me.Controls.Add(Me.btnHighReset)
        Me.Controls.Add(Me.chkSuperGhosts)
        Me.Controls.Add(Me.chkQuickGhost)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.Text = "Options"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Splash As SplashForm

    Private Sub btnHighReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighReset.Click
        If IO.File.Exists(Application.StartupPath & "\PacHighScore.J34") Then
            IO.File.Delete(Application.StartupPath & "\PacHighScore.J34")
        End If
    End Sub

    Public Sub FindParent(ByRef MyParent As Form)
        Splash = MyParent
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Splash.SavePrefs(Me.chkQuickGhost.Checked, Me.chkSuperGhosts.Checked, Me.chkSuperPac.Checked)
        Me.Close()
    End Sub
End Class
