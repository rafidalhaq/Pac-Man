Public Class SplashForm
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
    Friend WithEvents picboxPac As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblJustin As System.Windows.Forms.Label
    Friend WithEvents picboxPac1 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxPac2 As System.Windows.Forms.PictureBox
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picboxTitle As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SplashForm))
        Me.picboxPac = New System.Windows.Forms.PictureBox
        Me.picboxPac1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblJustin = New System.Windows.Forms.Label
        Me.picboxPac2 = New System.Windows.Forms.PictureBox
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.picboxTitle = New System.Windows.Forms.PictureBox
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnOptions = New System.Windows.Forms.Button
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxPac
        '
        Me.picboxPac.BackColor = System.Drawing.Color.Transparent
        Me.picboxPac.Image = CType(resources.GetObject("picboxPac.Image"), System.Drawing.Image)
        Me.picboxPac.Location = New System.Drawing.Point(-224, 0)
        Me.picboxPac.Name = "picboxPac"
        Me.picboxPac.Size = New System.Drawing.Size(224, 224)
        Me.picboxPac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPac.TabIndex = 0
        Me.picboxPac.TabStop = False
        Me.picboxPac.Visible = False
        '
        'picboxPac1
        '
        Me.picboxPac1.BackColor = System.Drawing.Color.Transparent
        Me.picboxPac1.Image = CType(resources.GetObject("picboxPac1.Image"), System.Drawing.Image)
        Me.picboxPac1.Location = New System.Drawing.Point(24, 16)
        Me.picboxPac1.Name = "picboxPac1"
        Me.picboxPac1.Size = New System.Drawing.Size(112, 112)
        Me.picboxPac1.TabIndex = 1
        Me.picboxPac1.TabStop = False
        Me.picboxPac1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 96)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "J34 Presents:"
        '
        'Timer1
        '
        '
        'lblJustin
        '
        Me.lblJustin.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJustin.ForeColor = System.Drawing.Color.Black
        Me.lblJustin.Location = New System.Drawing.Point(-21, 39)
        Me.lblJustin.Name = "lblJustin"
        Me.lblJustin.Size = New System.Drawing.Size(600, 144)
        Me.lblJustin.TabIndex = 3
        Me.lblJustin.Text = "In Association with:  Justin Watts"
        Me.lblJustin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJustin.Visible = False
        '
        'picboxPac2
        '
        Me.picboxPac2.BackColor = System.Drawing.Color.Transparent
        Me.picboxPac2.Image = CType(resources.GetObject("picboxPac2.Image"), System.Drawing.Image)
        Me.picboxPac2.Location = New System.Drawing.Point(448, 16)
        Me.picboxPac2.Name = "picboxPac2"
        Me.picboxPac2.Size = New System.Drawing.Size(112, 112)
        Me.picboxPac2.TabIndex = 4
        Me.picboxPac2.TabStop = False
        Me.picboxPac2.Visible = False
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(240, 0)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.TabIndex = 5
        Me.MediaPlayer.Visible = False
        '
        'picboxTitle
        '
        Me.picboxTitle.Image = CType(resources.GetObject("picboxTitle.Image"), System.Drawing.Image)
        Me.picboxTitle.Location = New System.Drawing.Point(23, 47)
        Me.picboxTitle.Name = "picboxTitle"
        Me.picboxTitle.Size = New System.Drawing.Size(512, 128)
        Me.picboxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxTitle.TabIndex = 6
        Me.picboxTitle.TabStop = False
        Me.picboxTitle.Visible = False
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(0, 192)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 32)
        Me.btnPlay.TabIndex = 7
        Me.btnPlay.Text = "Play"
        Me.btnPlay.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(480, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.Visible = False
        '
        'btnOptions
        '
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.White
        Me.btnOptions.Location = New System.Drawing.Point(231, 192)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(96, 32)
        Me.btnOptions.TabIndex = 9
        Me.btnOptions.Text = "Options"
        Me.btnOptions.Visible = False
        '
        'SplashForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(558, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.picboxPac)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.picboxPac1)
        Me.Controls.Add(Me.MediaPlayer)
        Me.Controls.Add(Me.picboxPac2)
        Me.Controls.Add(Me.lblJustin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picboxTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(560, 224)
        Me.Name = "SplashForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.LightCoral
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FadeOn As Boolean
    Dim JustinOn As Boolean
    Dim PacOn As Boolean
    Dim ButtonFallOn As Boolean
    Dim FadeLevel As Integer = 255
    Dim jumpFade As Integer = 2
    Dim Clear As Boolean

    Dim QGhost As Boolean = True
    Dim SGhosts As Integer = 1
    Dim SPac As Integer = 1

    Private Sub SplashForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
        FadeOn = True
        JustinOn = False
        MediaPlayer.URL = "data\theme.mp3"
        MediaPlayer.Ctlcontrols.play()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Clear = True
        End If
        If Clear = True Then
            If FadeOn = True Then
                If FadeLevel - jumpFade > 0 Then
                    If Timer1.Interval = 1000 Then
                        Timer1.Interval = 1
                    End If
                    FadeLevel = FadeLevel - jumpFade
                    Label1.ForeColor = Label1.ForeColor.FromArgb(FadeLevel, FadeLevel, FadeLevel)
                Else
                    FadeLevel = 0
                    Label1.ForeColor = Label1.ForeColor.FromArgb(FadeLevel, FadeLevel, FadeLevel)
                    FadeOn = False
                    JustinOn = True
                End If
            Else
                If JustinOn Then
                    If lblJustin.Visible = False Then
                        lblJustin.Visible = True
                        Label1.Visible = False
                    End If
                    If FadeLevel + jumpFade < 255 Then
                        FadeLevel = FadeLevel + jumpFade
                        lblJustin.ForeColor = Label1.ForeColor.FromArgb(FadeLevel, FadeLevel, FadeLevel)
                    Else
                        FadeLevel = 255
                        lblJustin.ForeColor = Label1.ForeColor.FromArgb(FadeLevel, FadeLevel, FadeLevel)
                        JustinOn = False
                        lblJustin.Visible = False
                        PacOn = True
                        FadeLevel = 20
                        Timer1.Interval = 1500
                    End If
                Else
                    If PacOn = True Then
                        If Timer1.Interval = 1500 Then
                            Timer1.Interval = 1
                            picboxTitle.Visible = True
                        End If
                        picboxPac.Visible = True
                        If (picboxPac.Location.X < Me.Width) Then
                            picboxPac.Location = New Point(picboxPac.Location.X + jumpFade, picboxPac.Location.Y)
                            FadeLevel -= jumpFade
                            If FadeLevel <= 0 Then
                                FadeLevel = 20
                                If picboxPac.Tag = 1 Then
                                    picboxPac.Image = picboxPac1.Image
                                    picboxPac.Tag = 2
                                Else
                                    picboxPac.Image = picboxPac2.Image
                                    picboxPac.Tag = 1
                                End If
                            End If
                        Else
                            PacOn = False
                        End If
                    Else
                        If Not ButtonFallOn And (btnPlay.Visible = False) Then
                            ButtonFallOn = True
                            btnPlay.Location = New Point(0, (0 - btnPlay.Height))
                            btnExit.Location = New Point(Me.Width - btnExit.Width, (0 - btnExit.Height))
                            FadeLevel = (0 - btnPlay.Height)
                            btnPlay.Visible = True
                            btnExit.Visible = True
                            btnOptions.Visible = True
                        End If
                        If FadeLevel < (Me.Height - btnPlay.Height) Then
                            FadeLevel += jumpFade
                            btnPlay.Location = New Point(0, FadeLevel)
                            btnExit.Location = New Point(Me.Width - btnExit.Width, FadeLevel)
                        Else
                            FadeLevel = Me.Height - btnPlay.Height
                            btnPlay.Location = New Point(0, FadeLevel)
                            btnExit.Location = New Point(Me.Width - btnExit.Width, FadeLevel)
                            ButtonFallOn = False
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim GameForm As New MainForm
        GameForm.QuickGhost = QGhost
        GameForm.StartGhostSpeed = SGhosts
        GameForm.StartPacSpeed = SPac
        GameForm.Location = Me.Location
        GameForm.LoadPacMan()
        GameForm.Show()
        Me.Hide()
        MediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub FormClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, picboxPac.MouseDown, picboxPac1.MouseDown, picboxPac2.MouseDown, picboxTitle.MouseDown
        Me.btnPlay.Location = New Point(0, 192)
        Me.btnExit.Location = New Point(480, 192)
        Me.btnPlay.Visible = True
        Me.btnExit.Visible = True
        Me.btnOptions.Visible = True
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Dim NewOptions As New OptionsForm
        NewOptions.FindParent(Me)
        NewOptions.Location = Me.Location
        NewOptions.Show()
    End Sub

    Public Sub SavePrefs(ByVal QuickGhost As Boolean, ByVal SuperGhosts As Boolean, ByVal SuperPac As Boolean)
        QGhost = IIf(QuickGhost, True, False)
        SGhosts = IIf(SuperGhosts, 2, 1)
        SPac = IIf(SuperPac, 2, 1)
    End Sub
End Class
