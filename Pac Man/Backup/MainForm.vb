
Public Class MainForm
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
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picPacRight1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacRight2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacUp1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacUp2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacDown1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacDown2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicPacLeft1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacLeft2 As System.Windows.Forms.PictureBox
    Friend WithEvents picGhost1 As System.Windows.Forms.PictureBox
    Friend WithEvents picGhost2 As System.Windows.Forms.PictureBox
    Friend WithEvents picGhost3 As System.Windows.Forms.PictureBox
    Friend WithEvents picGhost4 As System.Windows.Forms.PictureBox
    Friend WithEvents PicGhost5 As System.Windows.Forms.PictureBox
    Friend WithEvents picPacMan As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picboxGate As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox22 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox23 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox24 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox27 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox30 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox31 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox32 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox34 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox35 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox37 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox38 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox39 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox40 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox41 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox42 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox43 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox44 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox45 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox46 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox47 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox48 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox49 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox50 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox51 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox33 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox36 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox52 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox53 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox54 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox55 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox56 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxGhost1 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxGhost2 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxGhost3 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxGhost4 As System.Windows.Forms.PictureBox
    Friend WithEvents picboxGhost5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents DrawTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GateTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox28 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox29 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox57 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox58 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox59 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox60 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox61 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox62 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox63 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox64 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox65 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox66 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox67 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox68 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox69 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox70 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox71 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox72 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox73 As System.Windows.Forms.PictureBox
    Friend WithEvents MorphTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox74 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox75 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox76 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox77 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox79 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox81 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox82 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox83 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox84 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox85 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox86 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox87 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox88 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox89 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox90 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox91 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox92 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox93 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox94 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox95 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox97 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox98 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox100 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox80 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox96 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox99 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox101 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox102 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox103 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox104 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox105 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox106 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox107 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox108 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox109 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox110 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox111 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox112 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox113 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox114 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox115 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox116 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox117 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox118 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox119 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox120 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox78 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox121 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox122 As System.Windows.Forms.PictureBox
    Friend WithEvents picScaredGhost As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents MusicPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLifes As System.Windows.Forms.Label
    Friend WithEvents picboxFruit As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit2 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit10 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit9 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit3 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit4 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit5 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit8 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit6 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit7 As System.Windows.Forms.PictureBox
    Friend WithEvents picFruit1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox123 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox124 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox125 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox126 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox127 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox128 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox129 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox130 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox131 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox132 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox133 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHigh As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.picPacRight1 = New System.Windows.Forms.PictureBox
        Me.picPacRight2 = New System.Windows.Forms.PictureBox
        Me.picPacUp1 = New System.Windows.Forms.PictureBox
        Me.picPacUp2 = New System.Windows.Forms.PictureBox
        Me.picPacDown1 = New System.Windows.Forms.PictureBox
        Me.picPacDown2 = New System.Windows.Forms.PictureBox
        Me.PicPacLeft1 = New System.Windows.Forms.PictureBox
        Me.picPacLeft2 = New System.Windows.Forms.PictureBox
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.picGhost1 = New System.Windows.Forms.PictureBox
        Me.picGhost2 = New System.Windows.Forms.PictureBox
        Me.picGhost3 = New System.Windows.Forms.PictureBox
        Me.picGhost4 = New System.Windows.Forms.PictureBox
        Me.PicGhost5 = New System.Windows.Forms.PictureBox
        Me.picPacMan = New System.Windows.Forms.PictureBox
        Me.picboxGhost1 = New System.Windows.Forms.PictureBox
        Me.picboxGhost2 = New System.Windows.Forms.PictureBox
        Me.picboxGhost3 = New System.Windows.Forms.PictureBox
        Me.picboxGhost4 = New System.Windows.Forms.PictureBox
        Me.picboxGhost5 = New System.Windows.Forms.PictureBox
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.PictureBox10 = New System.Windows.Forms.PictureBox
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.picboxGate = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.PictureBox15 = New System.Windows.Forms.PictureBox
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.PictureBox17 = New System.Windows.Forms.PictureBox
        Me.PictureBox19 = New System.Windows.Forms.PictureBox
        Me.PictureBox20 = New System.Windows.Forms.PictureBox
        Me.PictureBox21 = New System.Windows.Forms.PictureBox
        Me.PictureBox22 = New System.Windows.Forms.PictureBox
        Me.PictureBox23 = New System.Windows.Forms.PictureBox
        Me.PictureBox24 = New System.Windows.Forms.PictureBox
        Me.PictureBox25 = New System.Windows.Forms.PictureBox
        Me.PictureBox27 = New System.Windows.Forms.PictureBox
        Me.PictureBox30 = New System.Windows.Forms.PictureBox
        Me.PictureBox31 = New System.Windows.Forms.PictureBox
        Me.PictureBox32 = New System.Windows.Forms.PictureBox
        Me.PictureBox34 = New System.Windows.Forms.PictureBox
        Me.PictureBox35 = New System.Windows.Forms.PictureBox
        Me.PictureBox37 = New System.Windows.Forms.PictureBox
        Me.PictureBox38 = New System.Windows.Forms.PictureBox
        Me.PictureBox39 = New System.Windows.Forms.PictureBox
        Me.PictureBox40 = New System.Windows.Forms.PictureBox
        Me.PictureBox41 = New System.Windows.Forms.PictureBox
        Me.PictureBox42 = New System.Windows.Forms.PictureBox
        Me.PictureBox43 = New System.Windows.Forms.PictureBox
        Me.PictureBox44 = New System.Windows.Forms.PictureBox
        Me.PictureBox45 = New System.Windows.Forms.PictureBox
        Me.PictureBox46 = New System.Windows.Forms.PictureBox
        Me.PictureBox47 = New System.Windows.Forms.PictureBox
        Me.PictureBox48 = New System.Windows.Forms.PictureBox
        Me.PictureBox49 = New System.Windows.Forms.PictureBox
        Me.PictureBox50 = New System.Windows.Forms.PictureBox
        Me.PictureBox51 = New System.Windows.Forms.PictureBox
        Me.PictureBox18 = New System.Windows.Forms.PictureBox
        Me.PictureBox33 = New System.Windows.Forms.PictureBox
        Me.PictureBox36 = New System.Windows.Forms.PictureBox
        Me.PictureBox52 = New System.Windows.Forms.PictureBox
        Me.PictureBox53 = New System.Windows.Forms.PictureBox
        Me.PictureBox54 = New System.Windows.Forms.PictureBox
        Me.PictureBox55 = New System.Windows.Forms.PictureBox
        Me.PictureBox56 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.DrawTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox14 = New System.Windows.Forms.PictureBox
        Me.PictureBox26 = New System.Windows.Forms.PictureBox
        Me.PictureBox28 = New System.Windows.Forms.PictureBox
        Me.PictureBox29 = New System.Windows.Forms.PictureBox
        Me.PictureBox57 = New System.Windows.Forms.PictureBox
        Me.PictureBox58 = New System.Windows.Forms.PictureBox
        Me.PictureBox59 = New System.Windows.Forms.PictureBox
        Me.PictureBox60 = New System.Windows.Forms.PictureBox
        Me.PictureBox61 = New System.Windows.Forms.PictureBox
        Me.PictureBox62 = New System.Windows.Forms.PictureBox
        Me.PictureBox63 = New System.Windows.Forms.PictureBox
        Me.PictureBox64 = New System.Windows.Forms.PictureBox
        Me.PictureBox65 = New System.Windows.Forms.PictureBox
        Me.PictureBox66 = New System.Windows.Forms.PictureBox
        Me.PictureBox67 = New System.Windows.Forms.PictureBox
        Me.PictureBox68 = New System.Windows.Forms.PictureBox
        Me.PictureBox69 = New System.Windows.Forms.PictureBox
        Me.PictureBox70 = New System.Windows.Forms.PictureBox
        Me.PictureBox71 = New System.Windows.Forms.PictureBox
        Me.PictureBox72 = New System.Windows.Forms.PictureBox
        Me.PictureBox73 = New System.Windows.Forms.PictureBox
        Me.MorphTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox74 = New System.Windows.Forms.PictureBox
        Me.PictureBox75 = New System.Windows.Forms.PictureBox
        Me.PictureBox76 = New System.Windows.Forms.PictureBox
        Me.PictureBox77 = New System.Windows.Forms.PictureBox
        Me.PictureBox79 = New System.Windows.Forms.PictureBox
        Me.PictureBox81 = New System.Windows.Forms.PictureBox
        Me.PictureBox82 = New System.Windows.Forms.PictureBox
        Me.PictureBox83 = New System.Windows.Forms.PictureBox
        Me.PictureBox84 = New System.Windows.Forms.PictureBox
        Me.PictureBox85 = New System.Windows.Forms.PictureBox
        Me.PictureBox86 = New System.Windows.Forms.PictureBox
        Me.PictureBox87 = New System.Windows.Forms.PictureBox
        Me.PictureBox88 = New System.Windows.Forms.PictureBox
        Me.PictureBox89 = New System.Windows.Forms.PictureBox
        Me.PictureBox90 = New System.Windows.Forms.PictureBox
        Me.PictureBox91 = New System.Windows.Forms.PictureBox
        Me.PictureBox92 = New System.Windows.Forms.PictureBox
        Me.PictureBox93 = New System.Windows.Forms.PictureBox
        Me.PictureBox94 = New System.Windows.Forms.PictureBox
        Me.PictureBox95 = New System.Windows.Forms.PictureBox
        Me.PictureBox97 = New System.Windows.Forms.PictureBox
        Me.PictureBox98 = New System.Windows.Forms.PictureBox
        Me.PictureBox100 = New System.Windows.Forms.PictureBox
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.PictureBox80 = New System.Windows.Forms.PictureBox
        Me.PictureBox96 = New System.Windows.Forms.PictureBox
        Me.PictureBox99 = New System.Windows.Forms.PictureBox
        Me.PictureBox101 = New System.Windows.Forms.PictureBox
        Me.PictureBox102 = New System.Windows.Forms.PictureBox
        Me.PictureBox103 = New System.Windows.Forms.PictureBox
        Me.PictureBox104 = New System.Windows.Forms.PictureBox
        Me.PictureBox105 = New System.Windows.Forms.PictureBox
        Me.PictureBox106 = New System.Windows.Forms.PictureBox
        Me.PictureBox107 = New System.Windows.Forms.PictureBox
        Me.PictureBox108 = New System.Windows.Forms.PictureBox
        Me.PictureBox109 = New System.Windows.Forms.PictureBox
        Me.PictureBox110 = New System.Windows.Forms.PictureBox
        Me.PictureBox111 = New System.Windows.Forms.PictureBox
        Me.PictureBox112 = New System.Windows.Forms.PictureBox
        Me.PictureBox113 = New System.Windows.Forms.PictureBox
        Me.PictureBox114 = New System.Windows.Forms.PictureBox
        Me.PictureBox115 = New System.Windows.Forms.PictureBox
        Me.PictureBox116 = New System.Windows.Forms.PictureBox
        Me.PictureBox117 = New System.Windows.Forms.PictureBox
        Me.PictureBox118 = New System.Windows.Forms.PictureBox
        Me.PictureBox119 = New System.Windows.Forms.PictureBox
        Me.PictureBox120 = New System.Windows.Forms.PictureBox
        Me.PictureBox78 = New System.Windows.Forms.PictureBox
        Me.PictureBox121 = New System.Windows.Forms.PictureBox
        Me.PictureBox122 = New System.Windows.Forms.PictureBox
        Me.picScaredGhost = New System.Windows.Forms.PictureBox
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblLevel = New System.Windows.Forms.Label
        Me.MusicPlayer = New AxWMPLib.AxWindowsMediaPlayer
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblLifes = New System.Windows.Forms.Label
        Me.picboxFruit = New System.Windows.Forms.PictureBox
        Me.picFruit2 = New System.Windows.Forms.PictureBox
        Me.picFruit10 = New System.Windows.Forms.PictureBox
        Me.picFruit9 = New System.Windows.Forms.PictureBox
        Me.picFruit3 = New System.Windows.Forms.PictureBox
        Me.picFruit4 = New System.Windows.Forms.PictureBox
        Me.picFruit5 = New System.Windows.Forms.PictureBox
        Me.picFruit8 = New System.Windows.Forms.PictureBox
        Me.picFruit6 = New System.Windows.Forms.PictureBox
        Me.picFruit7 = New System.Windows.Forms.PictureBox
        Me.picFruit1 = New System.Windows.Forms.PictureBox
        Me.PictureBox123 = New System.Windows.Forms.PictureBox
        Me.PictureBox124 = New System.Windows.Forms.PictureBox
        Me.PictureBox125 = New System.Windows.Forms.PictureBox
        Me.PictureBox126 = New System.Windows.Forms.PictureBox
        Me.PictureBox127 = New System.Windows.Forms.PictureBox
        Me.PictureBox128 = New System.Windows.Forms.PictureBox
        Me.PictureBox129 = New System.Windows.Forms.PictureBox
        Me.PictureBox130 = New System.Windows.Forms.PictureBox
        Me.PictureBox131 = New System.Windows.Forms.PictureBox
        Me.PictureBox132 = New System.Windows.Forms.PictureBox
        Me.PictureBox133 = New System.Windows.Forms.PictureBox
        Me.lblHigh = New System.Windows.Forms.Label
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPacRight1
        '
        Me.picPacRight1.Image = CType(resources.GetObject("picPacRight1.Image"), System.Drawing.Image)
        Me.picPacRight1.Location = New System.Drawing.Point(-248, 0)
        Me.picPacRight1.Name = "picPacRight1"
        Me.picPacRight1.Size = New System.Drawing.Size(58, 25)
        Me.picPacRight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacRight1.TabIndex = 3
        Me.picPacRight1.TabStop = False
        Me.picPacRight1.Visible = False
        '
        'picPacRight2
        '
        Me.picPacRight2.Image = CType(resources.GetObject("picPacRight2.Image"), System.Drawing.Image)
        Me.picPacRight2.Location = New System.Drawing.Point(-216, 0)
        Me.picPacRight2.Name = "picPacRight2"
        Me.picPacRight2.Size = New System.Drawing.Size(58, 25)
        Me.picPacRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacRight2.TabIndex = 4
        Me.picPacRight2.TabStop = False
        Me.picPacRight2.Visible = False
        '
        'picPacUp1
        '
        Me.picPacUp1.Image = CType(resources.GetObject("picPacUp1.Image"), System.Drawing.Image)
        Me.picPacUp1.Location = New System.Drawing.Point(-184, 0)
        Me.picPacUp1.Name = "picPacUp1"
        Me.picPacUp1.Size = New System.Drawing.Size(58, 25)
        Me.picPacUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacUp1.TabIndex = 5
        Me.picPacUp1.TabStop = False
        Me.picPacUp1.Visible = False
        '
        'picPacUp2
        '
        Me.picPacUp2.Image = CType(resources.GetObject("picPacUp2.Image"), System.Drawing.Image)
        Me.picPacUp2.Location = New System.Drawing.Point(-152, 0)
        Me.picPacUp2.Name = "picPacUp2"
        Me.picPacUp2.Size = New System.Drawing.Size(58, 25)
        Me.picPacUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacUp2.TabIndex = 6
        Me.picPacUp2.TabStop = False
        Me.picPacUp2.Visible = False
        '
        'picPacDown1
        '
        Me.picPacDown1.Image = CType(resources.GetObject("picPacDown1.Image"), System.Drawing.Image)
        Me.picPacDown1.Location = New System.Drawing.Point(-120, 0)
        Me.picPacDown1.Name = "picPacDown1"
        Me.picPacDown1.Size = New System.Drawing.Size(58, 25)
        Me.picPacDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacDown1.TabIndex = 7
        Me.picPacDown1.TabStop = False
        Me.picPacDown1.Visible = False
        '
        'picPacDown2
        '
        Me.picPacDown2.Image = CType(resources.GetObject("picPacDown2.Image"), System.Drawing.Image)
        Me.picPacDown2.Location = New System.Drawing.Point(-88, 0)
        Me.picPacDown2.Name = "picPacDown2"
        Me.picPacDown2.Size = New System.Drawing.Size(58, 25)
        Me.picPacDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacDown2.TabIndex = 8
        Me.picPacDown2.TabStop = False
        Me.picPacDown2.Visible = False
        '
        'PicPacLeft1
        '
        Me.PicPacLeft1.Image = CType(resources.GetObject("PicPacLeft1.Image"), System.Drawing.Image)
        Me.PicPacLeft1.Location = New System.Drawing.Point(-248, 32)
        Me.PicPacLeft1.Name = "PicPacLeft1"
        Me.PicPacLeft1.Size = New System.Drawing.Size(58, 25)
        Me.PicPacLeft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPacLeft1.TabIndex = 9
        Me.PicPacLeft1.TabStop = False
        Me.PicPacLeft1.Visible = False
        '
        'picPacLeft2
        '
        Me.picPacLeft2.Image = CType(resources.GetObject("picPacLeft2.Image"), System.Drawing.Image)
        Me.picPacLeft2.Location = New System.Drawing.Point(-216, 32)
        Me.picPacLeft2.Name = "picPacLeft2"
        Me.picPacLeft2.Size = New System.Drawing.Size(58, 25)
        Me.picPacLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacLeft2.TabIndex = 10
        Me.picPacLeft2.TabStop = False
        Me.picPacLeft2.Visible = False
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(265, 130)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.TabIndex = 11
        Me.MediaPlayer.Visible = False
        '
        'picGhost1
        '
        Me.picGhost1.Image = CType(resources.GetObject("picGhost1.Image"), System.Drawing.Image)
        Me.picGhost1.Location = New System.Drawing.Point(-184, 32)
        Me.picGhost1.Name = "picGhost1"
        Me.picGhost1.Size = New System.Drawing.Size(65, 32)
        Me.picGhost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost1.TabIndex = 12
        Me.picGhost1.TabStop = False
        Me.picGhost1.Visible = False
        '
        'picGhost2
        '
        Me.picGhost2.Image = CType(resources.GetObject("picGhost2.Image"), System.Drawing.Image)
        Me.picGhost2.Location = New System.Drawing.Point(-152, 32)
        Me.picGhost2.Name = "picGhost2"
        Me.picGhost2.Size = New System.Drawing.Size(65, 32)
        Me.picGhost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost2.TabIndex = 13
        Me.picGhost2.TabStop = False
        Me.picGhost2.Visible = False
        '
        'picGhost3
        '
        Me.picGhost3.Image = CType(resources.GetObject("picGhost3.Image"), System.Drawing.Image)
        Me.picGhost3.Location = New System.Drawing.Point(-120, 32)
        Me.picGhost3.Name = "picGhost3"
        Me.picGhost3.Size = New System.Drawing.Size(65, 32)
        Me.picGhost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost3.TabIndex = 14
        Me.picGhost3.TabStop = False
        Me.picGhost3.Visible = False
        '
        'picGhost4
        '
        Me.picGhost4.Image = CType(resources.GetObject("picGhost4.Image"), System.Drawing.Image)
        Me.picGhost4.Location = New System.Drawing.Point(-88, 32)
        Me.picGhost4.Name = "picGhost4"
        Me.picGhost4.Size = New System.Drawing.Size(65, 32)
        Me.picGhost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost4.TabIndex = 15
        Me.picGhost4.TabStop = False
        Me.picGhost4.Visible = False
        '
        'PicGhost5
        '
        Me.PicGhost5.Image = CType(resources.GetObject("PicGhost5.Image"), System.Drawing.Image)
        Me.PicGhost5.Location = New System.Drawing.Point(-56, 32)
        Me.PicGhost5.Name = "PicGhost5"
        Me.PicGhost5.Size = New System.Drawing.Size(56, 32)
        Me.PicGhost5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGhost5.TabIndex = 16
        Me.PicGhost5.TabStop = False
        Me.PicGhost5.Visible = False
        '
        'picPacMan
        '
        Me.picPacMan.Image = CType(resources.GetObject("picPacMan.Image"), System.Drawing.Image)
        Me.picPacMan.Location = New System.Drawing.Point(10, 5)
        Me.picPacMan.Name = "picPacMan"
        Me.picPacMan.Size = New System.Drawing.Size(25, 25)
        Me.picPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPacMan.TabIndex = 17
        Me.picPacMan.TabStop = False
        Me.picPacMan.Tag = "1"
        '
        'picboxGhost1
        '
        Me.picboxGhost1.Image = CType(resources.GetObject("picboxGhost1.Image"), System.Drawing.Image)
        Me.picboxGhost1.Location = New System.Drawing.Point(290, 145)
        Me.picboxGhost1.Name = "picboxGhost1"
        Me.picboxGhost1.Size = New System.Drawing.Size(25, 25)
        Me.picboxGhost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxGhost1.TabIndex = 18
        Me.picboxGhost1.TabStop = False
        Me.picboxGhost1.Tag = "Ghost"
        '
        'picboxGhost2
        '
        Me.picboxGhost2.Image = CType(resources.GetObject("picboxGhost2.Image"), System.Drawing.Image)
        Me.picboxGhost2.Location = New System.Drawing.Point(275, 170)
        Me.picboxGhost2.Name = "picboxGhost2"
        Me.picboxGhost2.Size = New System.Drawing.Size(25, 25)
        Me.picboxGhost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxGhost2.TabIndex = 19
        Me.picboxGhost2.TabStop = False
        Me.picboxGhost2.Tag = "Ghost"
        '
        'picboxGhost3
        '
        Me.picboxGhost3.Image = CType(resources.GetObject("picboxGhost3.Image"), System.Drawing.Image)
        Me.picboxGhost3.Location = New System.Drawing.Point(305, 170)
        Me.picboxGhost3.Name = "picboxGhost3"
        Me.picboxGhost3.Size = New System.Drawing.Size(25, 25)
        Me.picboxGhost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxGhost3.TabIndex = 20
        Me.picboxGhost3.TabStop = False
        Me.picboxGhost3.Tag = "Ghost"
        '
        'picboxGhost4
        '
        Me.picboxGhost4.Image = CType(resources.GetObject("picboxGhost4.Image"), System.Drawing.Image)
        Me.picboxGhost4.Location = New System.Drawing.Point(275, 205)
        Me.picboxGhost4.Name = "picboxGhost4"
        Me.picboxGhost4.Size = New System.Drawing.Size(25, 25)
        Me.picboxGhost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxGhost4.TabIndex = 21
        Me.picboxGhost4.TabStop = False
        Me.picboxGhost4.Tag = "Ghost"
        '
        'picboxGhost5
        '
        Me.picboxGhost5.Image = CType(resources.GetObject("picboxGhost5.Image"), System.Drawing.Image)
        Me.picboxGhost5.Location = New System.Drawing.Point(305, 205)
        Me.picboxGhost5.Name = "picboxGhost5"
        Me.picboxGhost5.Size = New System.Drawing.Size(25, 25)
        Me.picboxGhost5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxGhost5.TabIndex = 22
        Me.picboxGhost5.TabStop = False
        Me.picboxGhost5.Tag = "Ghost"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Location = New System.Drawing.Point(270, 130)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(5, 105)
        Me.PictureBox9.TabIndex = 23
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "Wall"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Location = New System.Drawing.Point(270, 235)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(70, 5)
        Me.PictureBox10.TabIndex = 24
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "Wall"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Location = New System.Drawing.Point(335, 130)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(5, 105)
        Me.PictureBox11.TabIndex = 25
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "Wall"
        '
        'picboxGate
        '
        Me.picboxGate.BackColor = System.Drawing.Color.White
        Me.picboxGate.Location = New System.Drawing.Point(275, 130)
        Me.picboxGate.Name = "picboxGate"
        Me.picboxGate.Size = New System.Drawing.Size(60, 5)
        Me.picboxGate.TabIndex = 26
        Me.picboxGate.TabStop = False
        Me.picboxGate.Tag = "Wall"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Location = New System.Drawing.Point(5, 280)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(45, 5)
        Me.PictureBox12.TabIndex = 29
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "Wall"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.White
        Me.PictureBox15.Location = New System.Drawing.Point(85, 280)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(5, 45)
        Me.PictureBox15.TabIndex = 31
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "Wall"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.White
        Me.PictureBox16.Location = New System.Drawing.Point(375, 170)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(35, 115)
        Me.PictureBox16.TabIndex = 32
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "Wall"
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.White
        Me.PictureBox17.Location = New System.Drawing.Point(0, 320)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(50, 60)
        Me.PictureBox17.TabIndex = 33
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "Wall"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.White
        Me.PictureBox19.Location = New System.Drawing.Point(160, 95)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(15, 40)
        Me.PictureBox19.TabIndex = 35
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "Wall"
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.White
        Me.PictureBox20.Location = New System.Drawing.Point(140, 90)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(60, 5)
        Me.PictureBox20.TabIndex = 36
        Me.PictureBox20.TabStop = False
        Me.PictureBox20.Tag = "Wall"
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.White
        Me.PictureBox21.Location = New System.Drawing.Point(100, 90)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(5, 85)
        Me.PictureBox21.TabIndex = 37
        Me.PictureBox21.TabStop = False
        Me.PictureBox21.Tag = "Wall"
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.White
        Me.PictureBox22.Location = New System.Drawing.Point(5, 130)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(60, 5)
        Me.PictureBox22.TabIndex = 38
        Me.PictureBox22.TabStop = False
        Me.PictureBox22.Tag = "Wall"
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.White
        Me.PictureBox23.Location = New System.Drawing.Point(165, 0)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(5, 55)
        Me.PictureBox23.TabIndex = 39
        Me.PictureBox23.TabStop = False
        Me.PictureBox23.Tag = "Wall"
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.White
        Me.PictureBox24.Location = New System.Drawing.Point(35, 90)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(30, 5)
        Me.PictureBox24.TabIndex = 40
        Me.PictureBox24.TabStop = False
        Me.PictureBox24.Tag = "Wall"
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.White
        Me.PictureBox25.Location = New System.Drawing.Point(105, 130)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(20, 5)
        Me.PictureBox25.TabIndex = 41
        Me.PictureBox25.TabStop = False
        Me.PictureBox25.Tag = "Wall"
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.Color.White
        Me.PictureBox27.Location = New System.Drawing.Point(100, 30)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox27.TabIndex = 43
        Me.PictureBox27.TabStop = False
        Me.PictureBox27.Tag = "Wall"
        '
        'PictureBox30
        '
        Me.PictureBox30.BackColor = System.Drawing.Color.White
        Me.PictureBox30.Location = New System.Drawing.Point(5, 170)
        Me.PictureBox30.Name = "PictureBox30"
        Me.PictureBox30.Size = New System.Drawing.Size(60, 5)
        Me.PictureBox30.TabIndex = 46
        Me.PictureBox30.TabStop = False
        Me.PictureBox30.Tag = "Wall"
        '
        'PictureBox31
        '
        Me.PictureBox31.BackColor = System.Drawing.Color.White
        Me.PictureBox31.Location = New System.Drawing.Point(270, 90)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(105, 5)
        Me.PictureBox31.TabIndex = 47
        Me.PictureBox31.TabStop = False
        Me.PictureBox31.Tag = "Wall"
        '
        'PictureBox32
        '
        Me.PictureBox32.BackColor = System.Drawing.Color.White
        Me.PictureBox32.Location = New System.Drawing.Point(45, 210)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(20, 5)
        Me.PictureBox32.TabIndex = 48
        Me.PictureBox32.TabStop = False
        Me.PictureBox32.Tag = "Wall"
        '
        'PictureBox34
        '
        Me.PictureBox34.BackColor = System.Drawing.Color.White
        Me.PictureBox34.Location = New System.Drawing.Point(170, 175)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(5, 40)
        Me.PictureBox34.TabIndex = 50
        Me.PictureBox34.TabStop = False
        Me.PictureBox34.Tag = "Wall"
        '
        'PictureBox35
        '
        Me.PictureBox35.BackColor = System.Drawing.Color.White
        Me.PictureBox35.Location = New System.Drawing.Point(85, 325)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox35.TabIndex = 51
        Me.PictureBox35.TabStop = False
        Me.PictureBox35.Tag = "Wall"
        '
        'PictureBox37
        '
        Me.PictureBox37.BackColor = System.Drawing.Color.White
        Me.PictureBox37.Location = New System.Drawing.Point(60, 210)
        Me.PictureBox37.Name = "PictureBox37"
        Me.PictureBox37.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox37.TabIndex = 53
        Me.PictureBox37.TabStop = False
        Me.PictureBox37.Tag = "Wall"
        '
        'PictureBox38
        '
        Me.PictureBox38.BackColor = System.Drawing.Color.White
        Me.PictureBox38.Location = New System.Drawing.Point(310, 275)
        Me.PictureBox38.Name = "PictureBox38"
        Me.PictureBox38.Size = New System.Drawing.Size(5, 40)
        Me.PictureBox38.TabIndex = 52
        Me.PictureBox38.TabStop = False
        Me.PictureBox38.Tag = "Wall"
        '
        'PictureBox39
        '
        Me.PictureBox39.BackColor = System.Drawing.Color.White
        Me.PictureBox39.Location = New System.Drawing.Point(210, 130)
        Me.PictureBox39.Name = "PictureBox39"
        Me.PictureBox39.Size = New System.Drawing.Size(20, 5)
        Me.PictureBox39.TabIndex = 56
        Me.PictureBox39.TabStop = False
        Me.PictureBox39.Tag = "Wall"
        '
        'PictureBox40
        '
        Me.PictureBox40.BackColor = System.Drawing.Color.White
        Me.PictureBox40.Location = New System.Drawing.Point(230, 90)
        Me.PictureBox40.Name = "PictureBox40"
        Me.PictureBox40.Size = New System.Drawing.Size(5, 85)
        Me.PictureBox40.TabIndex = 55
        Me.PictureBox40.TabStop = False
        Me.PictureBox40.Tag = "Wall"
        '
        'PictureBox41
        '
        Me.PictureBox41.BackColor = System.Drawing.Color.White
        Me.PictureBox41.Location = New System.Drawing.Point(45, 240)
        Me.PictureBox41.Name = "PictureBox41"
        Me.PictureBox41.Size = New System.Drawing.Size(20, 5)
        Me.PictureBox41.TabIndex = 57
        Me.PictureBox41.TabStop = False
        Me.PictureBox41.Tag = "Wall"
        '
        'PictureBox42
        '
        Me.PictureBox42.BackColor = System.Drawing.Color.White
        Me.PictureBox42.Location = New System.Drawing.Point(375, 130)
        Me.PictureBox42.Name = "PictureBox42"
        Me.PictureBox42.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox42.TabIndex = 59
        Me.PictureBox42.TabStop = False
        Me.PictureBox42.Tag = "Wall"
        '
        'PictureBox43
        '
        Me.PictureBox43.BackColor = System.Drawing.Color.White
        Me.PictureBox43.Location = New System.Drawing.Point(150, 170)
        Me.PictureBox43.Name = "PictureBox43"
        Me.PictureBox43.Size = New System.Drawing.Size(45, 5)
        Me.PictureBox43.TabIndex = 58
        Me.PictureBox43.TabStop = False
        Me.PictureBox43.Tag = "Wall"
        '
        'PictureBox44
        '
        Me.PictureBox44.BackColor = System.Drawing.Color.White
        Me.PictureBox44.Location = New System.Drawing.Point(110, 210)
        Me.PictureBox44.Name = "PictureBox44"
        Me.PictureBox44.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox44.TabIndex = 63
        Me.PictureBox44.TabStop = False
        Me.PictureBox44.Tag = "Wall"
        '
        'PictureBox45
        '
        Me.PictureBox45.BackColor = System.Drawing.Color.White
        Me.PictureBox45.Location = New System.Drawing.Point(230, 210)
        Me.PictureBox45.Name = "PictureBox45"
        Me.PictureBox45.Size = New System.Drawing.Size(5, 45)
        Me.PictureBox45.TabIndex = 62
        Me.PictureBox45.TabStop = False
        Me.PictureBox45.Tag = "Wall"
        '
        'PictureBox46
        '
        Me.PictureBox46.BackColor = System.Drawing.Color.White
        Me.PictureBox46.Location = New System.Drawing.Point(405, 0)
        Me.PictureBox46.Name = "PictureBox46"
        Me.PictureBox46.Size = New System.Drawing.Size(5, 130)
        Me.PictureBox46.TabIndex = 61
        Me.PictureBox46.TabStop = False
        Me.PictureBox46.Tag = "Wall"
        '
        'PictureBox47
        '
        Me.PictureBox47.BackColor = System.Drawing.Color.White
        Me.PictureBox47.Location = New System.Drawing.Point(40, 210)
        Me.PictureBox47.Name = "PictureBox47"
        Me.PictureBox47.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox47.TabIndex = 60
        Me.PictureBox47.TabStop = False
        Me.PictureBox47.Tag = "Wall"
        '
        'PictureBox48
        '
        Me.PictureBox48.BackColor = System.Drawing.Color.White
        Me.PictureBox48.Location = New System.Drawing.Point(305, 350)
        Me.PictureBox48.Name = "PictureBox48"
        Me.PictureBox48.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox48.TabIndex = 65
        Me.PictureBox48.TabStop = False
        Me.PictureBox48.Tag = "Wall"
        '
        'PictureBox49
        '
        Me.PictureBox49.BackColor = System.Drawing.Color.White
        Me.PictureBox49.Location = New System.Drawing.Point(200, 325)
        Me.PictureBox49.Name = "PictureBox49"
        Me.PictureBox49.Size = New System.Drawing.Size(70, 5)
        Me.PictureBox49.TabIndex = 64
        Me.PictureBox49.TabStop = False
        Me.PictureBox49.Tag = "Wall"
        '
        'PictureBox50
        '
        Me.PictureBox50.BackColor = System.Drawing.Color.White
        Me.PictureBox50.Location = New System.Drawing.Point(310, 275)
        Me.PictureBox50.Name = "PictureBox50"
        Me.PictureBox50.Size = New System.Drawing.Size(70, 10)
        Me.PictureBox50.TabIndex = 67
        Me.PictureBox50.TabStop = False
        Me.PictureBox50.Tag = "Wall"
        '
        'PictureBox51
        '
        Me.PictureBox51.BackColor = System.Drawing.Color.White
        Me.PictureBox51.Location = New System.Drawing.Point(350, 320)
        Me.PictureBox51.Name = "PictureBox51"
        Me.PictureBox51.Size = New System.Drawing.Size(60, 5)
        Me.PictureBox51.TabIndex = 66
        Me.PictureBox51.TabStop = False
        Me.PictureBox51.Tag = "Wall"
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.White
        Me.PictureBox18.Location = New System.Drawing.Point(115, 210)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(20, 5)
        Me.PictureBox18.TabIndex = 70
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "Wall"
        '
        'PictureBox33
        '
        Me.PictureBox33.BackColor = System.Drawing.Color.White
        Me.PictureBox33.Location = New System.Drawing.Point(350, 325)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(60, 55)
        Me.PictureBox33.TabIndex = 69
        Me.PictureBox33.TabStop = False
        Me.PictureBox33.Tag = "Wall"
        '
        'PictureBox36
        '
        Me.PictureBox36.BackColor = System.Drawing.Color.White
        Me.PictureBox36.Location = New System.Drawing.Point(150, 250)
        Me.PictureBox36.Name = "PictureBox36"
        Me.PictureBox36.Size = New System.Drawing.Size(45, 5)
        Me.PictureBox36.TabIndex = 68
        Me.PictureBox36.TabStop = False
        Me.PictureBox36.Tag = "Wall"
        '
        'PictureBox52
        '
        Me.PictureBox52.BackColor = System.Drawing.Color.White
        Me.PictureBox52.Location = New System.Drawing.Point(125, 290)
        Me.PictureBox52.Name = "PictureBox52"
        Me.PictureBox52.Size = New System.Drawing.Size(110, 5)
        Me.PictureBox52.TabIndex = 72
        Me.PictureBox52.TabStop = False
        Me.PictureBox52.Tag = "Wall"
        '
        'PictureBox53
        '
        Me.PictureBox53.BackColor = System.Drawing.Color.White
        Me.PictureBox53.Location = New System.Drawing.Point(200, 365)
        Me.PictureBox53.Name = "PictureBox53"
        Me.PictureBox53.Size = New System.Drawing.Size(35, 15)
        Me.PictureBox53.TabIndex = 71
        Me.PictureBox53.TabStop = False
        Me.PictureBox53.Tag = "Wall"
        '
        'PictureBox54
        '
        Me.PictureBox54.BackColor = System.Drawing.Color.White
        Me.PictureBox54.Location = New System.Drawing.Point(270, 325)
        Me.PictureBox54.Name = "PictureBox54"
        Me.PictureBox54.Size = New System.Drawing.Size(5, 25)
        Me.PictureBox54.TabIndex = 73
        Me.PictureBox54.TabStop = False
        Me.PictureBox54.Tag = "Wall"
        '
        'PictureBox55
        '
        Me.PictureBox55.BackColor = System.Drawing.Color.White
        Me.PictureBox55.Location = New System.Drawing.Point(270, 275)
        Me.PictureBox55.Name = "PictureBox55"
        Me.PictureBox55.Size = New System.Drawing.Size(5, 10)
        Me.PictureBox55.TabIndex = 74
        Me.PictureBox55.TabStop = False
        Me.PictureBox55.Tag = "Wall"
        '
        'PictureBox56
        '
        Me.PictureBox56.BackColor = System.Drawing.Color.White
        Me.PictureBox56.Location = New System.Drawing.Point(155, 325)
        Me.PictureBox56.Name = "PictureBox56"
        Me.PictureBox56.Size = New System.Drawing.Size(5, 25)
        Me.PictureBox56.TabIndex = 75
        Me.PictureBox56.TabStop = False
        Me.PictureBox56.Tag = "Wall"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(35, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox3.TabIndex = 76
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Wall"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(205, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox4.TabIndex = 78
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Wall"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(270, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox5.TabIndex = 77
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Wall"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(335, 30)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 25)
        Me.PictureBox6.TabIndex = 79
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Wall"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox7.Location = New System.Drawing.Point(140, 105)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(5, 5)
        Me.PictureBox7.TabIndex = 80
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "Dot"
        Me.PictureBox7.Visible = False
        '
        'DrawTimer
        '
        Me.DrawTimer.Enabled = True
        Me.DrawTimer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 135)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Wall"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(0, 170)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 115)
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Wall"
        '
        'GateTimer
        '
        Me.GateTimer.Enabled = True
        Me.GateTimer.Interval = 1
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Red
        Me.PictureBox8.Location = New System.Drawing.Point(100, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox8.TabIndex = 83
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "Path-Right-Down"
        Me.PictureBox8.Visible = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Red
        Me.PictureBox14.Location = New System.Drawing.Point(205, 55)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox14.TabIndex = 85
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "Path-Right-Up"
        Me.PictureBox14.Visible = False
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Red
        Me.PictureBox26.Location = New System.Drawing.Point(270, 55)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox26.TabIndex = 86
        Me.PictureBox26.TabStop = False
        Me.PictureBox26.Tag = "Path-Right-Both"
        Me.PictureBox26.Visible = False
        '
        'PictureBox28
        '
        Me.PictureBox28.BackColor = System.Drawing.Color.Red
        Me.PictureBox28.Location = New System.Drawing.Point(335, 55)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox28.TabIndex = 87
        Me.PictureBox28.TabStop = False
        Me.PictureBox28.Tag = "Path-Right-Up"
        Me.PictureBox28.Visible = False
        '
        'PictureBox29
        '
        Me.PictureBox29.BackColor = System.Drawing.Color.Red
        Me.PictureBox29.Location = New System.Drawing.Point(100, 55)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox29.TabIndex = 88
        Me.PictureBox29.TabStop = False
        Me.PictureBox29.Tag = "Path-Right-Both"
        Me.PictureBox29.Visible = False
        '
        'PictureBox57
        '
        Me.PictureBox57.BackColor = System.Drawing.Color.Red
        Me.PictureBox57.Location = New System.Drawing.Point(270, 0)
        Me.PictureBox57.Name = "PictureBox57"
        Me.PictureBox57.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox57.TabIndex = 89
        Me.PictureBox57.TabStop = False
        Me.PictureBox57.Tag = "Path-Right-Down"
        Me.PictureBox57.Visible = False
        '
        'PictureBox58
        '
        Me.PictureBox58.BackColor = System.Drawing.Color.Red
        Me.PictureBox58.Location = New System.Drawing.Point(335, 0)
        Me.PictureBox58.Name = "PictureBox58"
        Me.PictureBox58.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox58.TabIndex = 90
        Me.PictureBox58.TabStop = False
        Me.PictureBox58.Tag = "Path-Right-Down"
        Me.PictureBox58.Visible = False
        '
        'PictureBox59
        '
        Me.PictureBox59.BackColor = System.Drawing.Color.Red
        Me.PictureBox59.Location = New System.Drawing.Point(140, 55)
        Me.PictureBox59.Name = "PictureBox59"
        Me.PictureBox59.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox59.TabIndex = 91
        Me.PictureBox59.TabStop = False
        Me.PictureBox59.Tag = "Path-Right-Down"
        Me.PictureBox59.Visible = False
        '
        'PictureBox60
        '
        Me.PictureBox60.BackColor = System.Drawing.Color.Red
        Me.PictureBox60.Location = New System.Drawing.Point(230, 55)
        Me.PictureBox60.Name = "PictureBox60"
        Me.PictureBox60.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox60.TabIndex = 92
        Me.PictureBox60.TabStop = False
        Me.PictureBox60.Tag = "Path-Right-Down"
        Me.PictureBox60.Visible = False
        '
        'PictureBox61
        '
        Me.PictureBox61.BackColor = System.Drawing.Color.Red
        Me.PictureBox61.Location = New System.Drawing.Point(375, 95)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox61.TabIndex = 93
        Me.PictureBox61.TabStop = False
        Me.PictureBox61.Tag = "Path-Right-Down"
        Me.PictureBox61.Visible = False
        '
        'PictureBox62
        '
        Me.PictureBox62.BackColor = System.Drawing.Color.Red
        Me.PictureBox62.Location = New System.Drawing.Point(160, 135)
        Me.PictureBox62.Name = "PictureBox62"
        Me.PictureBox62.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox62.TabIndex = 94
        Me.PictureBox62.TabStop = False
        Me.PictureBox62.Tag = "Path-Right-Up"
        Me.PictureBox62.Visible = False
        '
        'PictureBox63
        '
        Me.PictureBox63.BackColor = System.Drawing.Color.Red
        Me.PictureBox63.Location = New System.Drawing.Point(210, 135)
        Me.PictureBox63.Name = "PictureBox63"
        Me.PictureBox63.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox63.TabIndex = 95
        Me.PictureBox63.TabStop = False
        Me.PictureBox63.Tag = "Path-Right-Up"
        Me.PictureBox63.Visible = False
        '
        'PictureBox64
        '
        Me.PictureBox64.BackColor = System.Drawing.Color.Red
        Me.PictureBox64.Location = New System.Drawing.Point(100, 175)
        Me.PictureBox64.Name = "PictureBox64"
        Me.PictureBox64.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox64.TabIndex = 96
        Me.PictureBox64.TabStop = False
        Me.PictureBox64.Tag = "Path-Right-Both"
        Me.PictureBox64.Visible = False
        '
        'PictureBox65
        '
        Me.PictureBox65.BackColor = System.Drawing.Color.Red
        Me.PictureBox65.Location = New System.Drawing.Point(230, 175)
        Me.PictureBox65.Name = "PictureBox65"
        Me.PictureBox65.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox65.TabIndex = 97
        Me.PictureBox65.TabStop = False
        Me.PictureBox65.Tag = "Path-Right-Both"
        Me.PictureBox65.Visible = False
        '
        'PictureBox66
        '
        Me.PictureBox66.BackColor = System.Drawing.Color.Red
        Me.PictureBox66.Location = New System.Drawing.Point(310, 240)
        Me.PictureBox66.Name = "PictureBox66"
        Me.PictureBox66.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox66.TabIndex = 98
        Me.PictureBox66.TabStop = False
        Me.PictureBox66.Tag = "Path-Right-Down"
        Me.PictureBox66.Visible = False
        '
        'PictureBox67
        '
        Me.PictureBox67.BackColor = System.Drawing.Color.Red
        Me.PictureBox67.Location = New System.Drawing.Point(270, 285)
        Me.PictureBox67.Name = "PictureBox67"
        Me.PictureBox67.Size = New System.Drawing.Size(5, 40)
        Me.PictureBox67.TabIndex = 99
        Me.PictureBox67.TabStop = False
        Me.PictureBox67.Tag = "Path-Right-Up"
        Me.PictureBox67.Visible = False
        '
        'PictureBox68
        '
        Me.PictureBox68.BackColor = System.Drawing.Color.Red
        Me.PictureBox68.Location = New System.Drawing.Point(155, 295)
        Me.PictureBox68.Name = "PictureBox68"
        Me.PictureBox68.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox68.TabIndex = 100
        Me.PictureBox68.TabStop = False
        Me.PictureBox68.Tag = "Path-Right-Down"
        Me.PictureBox68.Visible = False
        '
        'PictureBox69
        '
        Me.PictureBox69.BackColor = System.Drawing.Color.Red
        Me.PictureBox69.Location = New System.Drawing.Point(200, 295)
        Me.PictureBox69.Name = "PictureBox69"
        Me.PictureBox69.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox69.TabIndex = 101
        Me.PictureBox69.TabStop = False
        Me.PictureBox69.Tag = "Path-Right-Down"
        Me.PictureBox69.Visible = False
        '
        'PictureBox70
        '
        Me.PictureBox70.BackColor = System.Drawing.Color.Red
        Me.PictureBox70.Location = New System.Drawing.Point(125, 245)
        Me.PictureBox70.Name = "PictureBox70"
        Me.PictureBox70.Size = New System.Drawing.Size(5, 45)
        Me.PictureBox70.TabIndex = 102
        Me.PictureBox70.TabStop = False
        Me.PictureBox70.Tag = "Path-Right-Down"
        Me.PictureBox70.Visible = False
        '
        'PictureBox71
        '
        Me.PictureBox71.BackColor = System.Drawing.Color.Red
        Me.PictureBox71.Location = New System.Drawing.Point(150, 255)
        Me.PictureBox71.Name = "PictureBox71"
        Me.PictureBox71.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox71.TabIndex = 103
        Me.PictureBox71.TabStop = False
        Me.PictureBox71.Tag = "Path-Right-Up"
        Me.PictureBox71.Visible = False
        '
        'PictureBox72
        '
        Me.PictureBox72.BackColor = System.Drawing.Color.Red
        Me.PictureBox72.Location = New System.Drawing.Point(230, 255)
        Me.PictureBox72.Name = "PictureBox72"
        Me.PictureBox72.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox72.TabIndex = 104
        Me.PictureBox72.TabStop = False
        Me.PictureBox72.Tag = "Path-Right-Up"
        Me.PictureBox72.Visible = False
        '
        'PictureBox73
        '
        Me.PictureBox73.BackColor = System.Drawing.Color.Red
        Me.PictureBox73.Location = New System.Drawing.Point(155, 350)
        Me.PictureBox73.Name = "PictureBox73"
        Me.PictureBox73.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox73.TabIndex = 105
        Me.PictureBox73.TabStop = False
        Me.PictureBox73.Tag = "Path-Right-Up"
        Me.PictureBox73.Visible = False
        '
        'MorphTimer
        '
        Me.MorphTimer.Interval = 1
        '
        'PictureBox74
        '
        Me.PictureBox74.BackColor = System.Drawing.Color.Red
        Me.PictureBox74.Location = New System.Drawing.Point(60, 0)
        Me.PictureBox74.Name = "PictureBox74"
        Me.PictureBox74.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox74.TabIndex = 106
        Me.PictureBox74.TabStop = False
        Me.PictureBox74.Tag = "Path-Left-Down"
        Me.PictureBox74.Visible = False
        '
        'PictureBox75
        '
        Me.PictureBox75.BackColor = System.Drawing.Color.Red
        Me.PictureBox75.Location = New System.Drawing.Point(295, 0)
        Me.PictureBox75.Name = "PictureBox75"
        Me.PictureBox75.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox75.TabIndex = 107
        Me.PictureBox75.TabStop = False
        Me.PictureBox75.Tag = "Path-Left-Down"
        Me.PictureBox75.Visible = False
        '
        'PictureBox76
        '
        Me.PictureBox76.BackColor = System.Drawing.Color.Red
        Me.PictureBox76.Location = New System.Drawing.Point(230, 0)
        Me.PictureBox76.Name = "PictureBox76"
        Me.PictureBox76.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox76.TabIndex = 108
        Me.PictureBox76.TabStop = False
        Me.PictureBox76.Tag = "Path-Left-Down"
        Me.PictureBox76.Visible = False
        '
        'PictureBox77
        '
        Me.PictureBox77.BackColor = System.Drawing.Color.Red
        Me.PictureBox77.Location = New System.Drawing.Point(295, 55)
        Me.PictureBox77.Name = "PictureBox77"
        Me.PictureBox77.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox77.TabIndex = 109
        Me.PictureBox77.TabStop = False
        Me.PictureBox77.Tag = "Path-Left-Up"
        Me.PictureBox77.Visible = False
        '
        'PictureBox79
        '
        Me.PictureBox79.BackColor = System.Drawing.Color.Red
        Me.PictureBox79.Location = New System.Drawing.Point(195, 55)
        Me.PictureBox79.Name = "PictureBox79"
        Me.PictureBox79.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox79.TabIndex = 111
        Me.PictureBox79.TabStop = False
        Me.PictureBox79.Tag = "Path-Left-Down"
        Me.PictureBox79.Visible = False
        '
        'PictureBox81
        '
        Me.PictureBox81.BackColor = System.Drawing.Color.Red
        Me.PictureBox81.Location = New System.Drawing.Point(100, 55)
        Me.PictureBox81.Name = "PictureBox81"
        Me.PictureBox81.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox81.TabIndex = 113
        Me.PictureBox81.TabStop = False
        Me.PictureBox81.Tag = "Path-Left-Down"
        Me.PictureBox81.Visible = False
        '
        'PictureBox82
        '
        Me.PictureBox82.BackColor = System.Drawing.Color.Red
        Me.PictureBox82.Location = New System.Drawing.Point(125, 55)
        Me.PictureBox82.Name = "PictureBox82"
        Me.PictureBox82.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox82.TabIndex = 114
        Me.PictureBox82.TabStop = False
        Me.PictureBox82.Tag = "Path-Left-Up"
        Me.PictureBox82.Visible = False
        '
        'PictureBox83
        '
        Me.PictureBox83.BackColor = System.Drawing.Color.Red
        Me.PictureBox83.Location = New System.Drawing.Point(60, 55)
        Me.PictureBox83.Name = "PictureBox83"
        Me.PictureBox83.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox83.TabIndex = 115
        Me.PictureBox83.TabStop = False
        Me.PictureBox83.Tag = "Path-Left-Both"
        Me.PictureBox83.Visible = False
        '
        'PictureBox84
        '
        Me.PictureBox84.BackColor = System.Drawing.Color.Red
        Me.PictureBox84.Location = New System.Drawing.Point(170, 135)
        Me.PictureBox84.Name = "PictureBox84"
        Me.PictureBox84.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox84.TabIndex = 116
        Me.PictureBox84.TabStop = False
        Me.PictureBox84.Tag = "Path-Left-Up"
        Me.PictureBox84.Visible = False
        '
        'PictureBox85
        '
        Me.PictureBox85.BackColor = System.Drawing.Color.Red
        Me.PictureBox85.Location = New System.Drawing.Point(120, 135)
        Me.PictureBox85.Name = "PictureBox85"
        Me.PictureBox85.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox85.TabIndex = 117
        Me.PictureBox85.TabStop = False
        Me.PictureBox85.Tag = "Path-Left-Up"
        Me.PictureBox85.Visible = False
        '
        'PictureBox86
        '
        Me.PictureBox86.BackColor = System.Drawing.Color.Red
        Me.PictureBox86.Location = New System.Drawing.Point(100, 175)
        Me.PictureBox86.Name = "PictureBox86"
        Me.PictureBox86.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox86.TabIndex = 118
        Me.PictureBox86.TabStop = False
        Me.PictureBox86.Tag = "Path-Left-Up"
        Me.PictureBox86.Visible = False
        '
        'PictureBox87
        '
        Me.PictureBox87.BackColor = System.Drawing.Color.Red
        Me.PictureBox87.Location = New System.Drawing.Point(190, 175)
        Me.PictureBox87.Name = "PictureBox87"
        Me.PictureBox87.Size = New System.Drawing.Size(5, 40)
        Me.PictureBox87.TabIndex = 119
        Me.PictureBox87.TabStop = False
        Me.PictureBox87.Tag = "Path-Left-Both"
        Me.PictureBox87.Visible = False
        '
        'PictureBox88
        '
        Me.PictureBox88.BackColor = System.Drawing.Color.Red
        Me.PictureBox88.Location = New System.Drawing.Point(150, 174)
        Me.PictureBox88.Name = "PictureBox88"
        Me.PictureBox88.Size = New System.Drawing.Size(5, 41)
        Me.PictureBox88.TabIndex = 120
        Me.PictureBox88.TabStop = False
        Me.PictureBox88.Tag = "Path-Right-Up"
        Me.PictureBox88.Visible = False
        '
        'PictureBox89
        '
        Me.PictureBox89.BackColor = System.Drawing.Color.Red
        Me.PictureBox89.Location = New System.Drawing.Point(60, 175)
        Me.PictureBox89.Name = "PictureBox89"
        Me.PictureBox89.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox89.TabIndex = 121
        Me.PictureBox89.TabStop = False
        Me.PictureBox89.Tag = "Path-Left-Both"
        Me.PictureBox89.Visible = False
        '
        'PictureBox90
        '
        Me.PictureBox90.BackColor = System.Drawing.Color.Red
        Me.PictureBox90.Location = New System.Drawing.Point(110, 245)
        Me.PictureBox90.Name = "PictureBox90"
        Me.PictureBox90.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox90.TabIndex = 122
        Me.PictureBox90.TabStop = False
        Me.PictureBox90.Tag = "Path-Right-Up"
        Me.PictureBox90.Visible = False
        '
        'PictureBox91
        '
        Me.PictureBox91.BackColor = System.Drawing.Color.Red
        Me.PictureBox91.Location = New System.Drawing.Point(190, 255)
        Me.PictureBox91.Name = "PictureBox91"
        Me.PictureBox91.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox91.TabIndex = 123
        Me.PictureBox91.TabStop = False
        Me.PictureBox91.Tag = "Path-Left-Up"
        Me.PictureBox91.Visible = False
        '
        'PictureBox92
        '
        Me.PictureBox92.BackColor = System.Drawing.Color.Red
        Me.PictureBox92.Location = New System.Drawing.Point(110, 245)
        Me.PictureBox92.Name = "PictureBox92"
        Me.PictureBox92.Size = New System.Drawing.Size(5, 45)
        Me.PictureBox92.TabIndex = 124
        Me.PictureBox92.TabStop = False
        Me.PictureBox92.Tag = "Path-Left-Up"
        Me.PictureBox92.Visible = False
        '
        'PictureBox93
        '
        Me.PictureBox93.BackColor = System.Drawing.Color.Red
        Me.PictureBox93.Location = New System.Drawing.Point(155, 295)
        Me.PictureBox93.Name = "PictureBox93"
        Me.PictureBox93.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox93.TabIndex = 125
        Me.PictureBox93.TabStop = False
        Me.PictureBox93.Tag = "Path-Left-Down"
        Me.PictureBox93.Visible = False
        '
        'PictureBox94
        '
        Me.PictureBox94.BackColor = System.Drawing.Color.Red
        Me.PictureBox94.Location = New System.Drawing.Point(115, 295)
        Me.PictureBox94.Name = "PictureBox94"
        Me.PictureBox94.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox94.TabIndex = 126
        Me.PictureBox94.TabStop = False
        Me.PictureBox94.Tag = "Path-Left-Down"
        Me.PictureBox94.Visible = False
        '
        'PictureBox95
        '
        Me.PictureBox95.BackColor = System.Drawing.Color.Red
        Me.PictureBox95.Location = New System.Drawing.Point(230, 295)
        Me.PictureBox95.Name = "PictureBox95"
        Me.PictureBox95.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox95.TabIndex = 127
        Me.PictureBox95.TabStop = False
        Me.PictureBox95.Tag = "Path-Left-Up"
        Me.PictureBox95.Visible = False
        '
        'PictureBox97
        '
        Me.PictureBox97.BackColor = System.Drawing.Color.Red
        Me.PictureBox97.Location = New System.Drawing.Point(155, 350)
        Me.PictureBox97.Name = "PictureBox97"
        Me.PictureBox97.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox97.TabIndex = 129
        Me.PictureBox97.TabStop = False
        Me.PictureBox97.Tag = "Path-Left-Up"
        Me.PictureBox97.Visible = False
        '
        'PictureBox98
        '
        Me.PictureBox98.BackColor = System.Drawing.Color.Red
        Me.PictureBox98.Location = New System.Drawing.Point(115, 350)
        Me.PictureBox98.Name = "PictureBox98"
        Me.PictureBox98.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox98.TabIndex = 130
        Me.PictureBox98.TabStop = False
        Me.PictureBox98.Tag = "Path-Left-Up"
        Me.PictureBox98.Visible = False
        '
        'PictureBox100
        '
        Me.PictureBox100.BackColor = System.Drawing.Color.Red
        Me.PictureBox100.Location = New System.Drawing.Point(45, 245)
        Me.PictureBox100.Name = "PictureBox100"
        Me.PictureBox100.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox100.TabIndex = 132
        Me.PictureBox100.TabStop = False
        Me.PictureBox100.Tag = "Path-Left-Down"
        Me.PictureBox100.Visible = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Red
        Me.PictureBox13.Location = New System.Drawing.Point(60, 245)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox13.TabIndex = 133
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "Path-Left-Up"
        Me.PictureBox13.Visible = False
        '
        'PictureBox80
        '
        Me.PictureBox80.BackColor = System.Drawing.Color.Red
        Me.PictureBox80.Location = New System.Drawing.Point(65, 90)
        Me.PictureBox80.Name = "PictureBox80"
        Me.PictureBox80.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox80.TabIndex = 134
        Me.PictureBox80.TabStop = False
        Me.PictureBox80.Tag = "Path-Up-Left"
        Me.PictureBox80.Visible = False
        '
        'PictureBox96
        '
        Me.PictureBox96.BackColor = System.Drawing.Color.Red
        Me.PictureBox96.Location = New System.Drawing.Point(65, 170)
        Me.PictureBox96.Name = "PictureBox96"
        Me.PictureBox96.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox96.TabIndex = 135
        Me.PictureBox96.TabStop = False
        Me.PictureBox96.Tag = "Path-Up-Both"
        Me.PictureBox96.Visible = False
        '
        'PictureBox99
        '
        Me.PictureBox99.BackColor = System.Drawing.Color.Red
        Me.PictureBox99.Location = New System.Drawing.Point(235, 250)
        Me.PictureBox99.Name = "PictureBox99"
        Me.PictureBox99.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox99.TabIndex = 136
        Me.PictureBox99.TabStop = False
        Me.PictureBox99.Tag = "Path-Up-Left"
        Me.PictureBox99.Visible = False
        '
        'PictureBox101
        '
        Me.PictureBox101.BackColor = System.Drawing.Color.Red
        Me.PictureBox101.Location = New System.Drawing.Point(235, 170)
        Me.PictureBox101.Name = "PictureBox101"
        Me.PictureBox101.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox101.TabIndex = 137
        Me.PictureBox101.TabStop = False
        Me.PictureBox101.Tag = "Path-Up-Left"
        Me.PictureBox101.Visible = False
        '
        'PictureBox102
        '
        Me.PictureBox102.BackColor = System.Drawing.Color.Red
        Me.PictureBox102.Location = New System.Drawing.Point(235, 90)
        Me.PictureBox102.Name = "PictureBox102"
        Me.PictureBox102.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox102.TabIndex = 138
        Me.PictureBox102.TabStop = False
        Me.PictureBox102.Tag = "Path-Up-Right"
        Me.PictureBox102.Visible = False
        '
        'PictureBox103
        '
        Me.PictureBox103.BackColor = System.Drawing.Color.Red
        Me.PictureBox103.Location = New System.Drawing.Point(235, 50)
        Me.PictureBox103.Name = "PictureBox103"
        Me.PictureBox103.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox103.TabIndex = 139
        Me.PictureBox103.TabStop = False
        Me.PictureBox103.Tag = "Path-Up-Both"
        Me.PictureBox103.Visible = False
        '
        'PictureBox104
        '
        Me.PictureBox104.BackColor = System.Drawing.Color.Red
        Me.PictureBox104.Location = New System.Drawing.Point(375, 50)
        Me.PictureBox104.Name = "PictureBox104"
        Me.PictureBox104.Size = New System.Drawing.Size(30, 5)
        Me.PictureBox104.TabIndex = 140
        Me.PictureBox104.TabStop = False
        Me.PictureBox104.Tag = "Path-Up-Left"
        Me.PictureBox104.Visible = False
        '
        'PictureBox105
        '
        Me.PictureBox105.BackColor = System.Drawing.Color.Red
        Me.PictureBox105.Location = New System.Drawing.Point(170, 215)
        Me.PictureBox105.Name = "PictureBox105"
        Me.PictureBox105.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox105.TabIndex = 141
        Me.PictureBox105.TabStop = False
        Me.PictureBox105.Tag = "Path-Right-Up"
        Me.PictureBox105.Visible = False
        '
        'PictureBox106
        '
        Me.PictureBox106.BackColor = System.Drawing.Color.Red
        Me.PictureBox106.Location = New System.Drawing.Point(170, 215)
        Me.PictureBox106.Name = "PictureBox106"
        Me.PictureBox106.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox106.TabIndex = 142
        Me.PictureBox106.TabStop = False
        Me.PictureBox106.Tag = "Path-Left-Up"
        Me.PictureBox106.Visible = False
        '
        'PictureBox107
        '
        Me.PictureBox107.BackColor = System.Drawing.Color.Red
        Me.PictureBox107.Location = New System.Drawing.Point(65, 130)
        Me.PictureBox107.Name = "PictureBox107"
        Me.PictureBox107.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox107.TabIndex = 143
        Me.PictureBox107.TabStop = False
        Me.PictureBox107.Tag = "Path-Down-Left"
        Me.PictureBox107.Visible = False
        '
        'PictureBox108
        '
        Me.PictureBox108.BackColor = System.Drawing.Color.Red
        Me.PictureBox108.Location = New System.Drawing.Point(65, 210)
        Me.PictureBox108.Name = "PictureBox108"
        Me.PictureBox108.Size = New System.Drawing.Size(40, 5)
        Me.PictureBox108.TabIndex = 144
        Me.PictureBox108.TabStop = False
        Me.PictureBox108.Tag = "Path-Down-Both"
        Me.PictureBox108.Visible = False
        '
        'PictureBox109
        '
        Me.PictureBox109.BackColor = System.Drawing.Color.Red
        Me.PictureBox109.Location = New System.Drawing.Point(160, 365)
        Me.PictureBox109.Name = "PictureBox109"
        Me.PictureBox109.Size = New System.Drawing.Size(40, 5)
        Me.PictureBox109.TabIndex = 145
        Me.PictureBox109.TabStop = False
        Me.PictureBox109.Tag = "Path-Down-Right"
        Me.PictureBox109.Visible = False
        '
        'PictureBox110
        '
        Me.PictureBox110.BackColor = System.Drawing.Color.Red
        Me.PictureBox110.Location = New System.Drawing.Point(275, 290)
        Me.PictureBox110.Name = "PictureBox110"
        Me.PictureBox110.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox110.TabIndex = 146
        Me.PictureBox110.TabStop = False
        Me.PictureBox110.Tag = "Path-Up-Left"
        Me.PictureBox110.Visible = False
        '
        'PictureBox111
        '
        Me.PictureBox111.BackColor = System.Drawing.Color.Red
        Me.PictureBox111.Location = New System.Drawing.Point(275, 325)
        Me.PictureBox111.Name = "PictureBox111"
        Me.PictureBox111.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox111.TabIndex = 147
        Me.PictureBox111.TabStop = False
        Me.PictureBox111.Tag = "Path-Down-Left"
        Me.PictureBox111.Visible = False
        '
        'PictureBox112
        '
        Me.PictureBox112.BackColor = System.Drawing.Color.Red
        Me.PictureBox112.Location = New System.Drawing.Point(235, 290)
        Me.PictureBox112.Name = "PictureBox112"
        Me.PictureBox112.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox112.TabIndex = 148
        Me.PictureBox112.TabStop = False
        Me.PictureBox112.Tag = "Path-Down-Left"
        Me.PictureBox112.Visible = False
        '
        'PictureBox113
        '
        Me.PictureBox113.BackColor = System.Drawing.Color.Red
        Me.PictureBox113.Location = New System.Drawing.Point(235, 275)
        Me.PictureBox113.Name = "PictureBox113"
        Me.PictureBox113.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox113.TabIndex = 149
        Me.PictureBox113.TabStop = False
        Me.PictureBox113.Tag = "Path-Down-Right"
        Me.PictureBox113.Visible = False
        '
        'PictureBox114
        '
        Me.PictureBox114.BackColor = System.Drawing.Color.Red
        Me.PictureBox114.Location = New System.Drawing.Point(235, 235)
        Me.PictureBox114.Name = "PictureBox114"
        Me.PictureBox114.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox114.TabIndex = 150
        Me.PictureBox114.TabStop = False
        Me.PictureBox114.Tag = "Path-Up-Right"
        Me.PictureBox114.Visible = False
        '
        'PictureBox115
        '
        Me.PictureBox115.BackColor = System.Drawing.Color.Red
        Me.PictureBox115.Location = New System.Drawing.Point(235, 210)
        Me.PictureBox115.Name = "PictureBox115"
        Me.PictureBox115.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox115.TabIndex = 151
        Me.PictureBox115.TabStop = False
        Me.PictureBox115.Tag = "Path-Down-Left"
        Me.PictureBox115.Visible = False
        '
        'PictureBox116
        '
        Me.PictureBox116.BackColor = System.Drawing.Color.Red
        Me.PictureBox116.Location = New System.Drawing.Point(235, 130)
        Me.PictureBox116.Name = "PictureBox116"
        Me.PictureBox116.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox116.TabIndex = 152
        Me.PictureBox116.TabStop = False
        Me.PictureBox116.Tag = "Path-Down-Right"
        Me.PictureBox116.Visible = False
        '
        'PictureBox117
        '
        Me.PictureBox117.BackColor = System.Drawing.Color.Red
        Me.PictureBox117.Location = New System.Drawing.Point(235, 90)
        Me.PictureBox117.Name = "PictureBox117"
        Me.PictureBox117.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox117.TabIndex = 153
        Me.PictureBox117.TabStop = False
        Me.PictureBox117.Tag = "Path-Down-Both"
        Me.PictureBox117.Visible = False
        '
        'PictureBox118
        '
        Me.PictureBox118.BackColor = System.Drawing.Color.Red
        Me.PictureBox118.Location = New System.Drawing.Point(375, 90)
        Me.PictureBox118.Name = "PictureBox118"
        Me.PictureBox118.Size = New System.Drawing.Size(30, 5)
        Me.PictureBox118.TabIndex = 154
        Me.PictureBox118.TabStop = False
        Me.PictureBox118.Tag = "Path-Down-Left"
        Me.PictureBox118.Visible = False
        '
        'PictureBox119
        '
        Me.PictureBox119.BackColor = System.Drawing.Color.Red
        Me.PictureBox119.Location = New System.Drawing.Point(65, 90)
        Me.PictureBox119.Name = "PictureBox119"
        Me.PictureBox119.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox119.TabIndex = 155
        Me.PictureBox119.TabStop = False
        Me.PictureBox119.Tag = "Path-Down-Both"
        Me.PictureBox119.Visible = False
        '
        'PictureBox120
        '
        Me.PictureBox120.BackColor = System.Drawing.Color.Red
        Me.PictureBox120.Location = New System.Drawing.Point(395, 285)
        Me.PictureBox120.Name = "PictureBox120"
        Me.PictureBox120.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox120.TabIndex = 156
        Me.PictureBox120.TabStop = False
        Me.PictureBox120.Tag = "Path-Right-Flip"
        Me.PictureBox120.Visible = False
        '
        'PictureBox78
        '
        Me.PictureBox78.BackColor = System.Drawing.Color.Red
        Me.PictureBox78.Location = New System.Drawing.Point(175, 210)
        Me.PictureBox78.Name = "PictureBox78"
        Me.PictureBox78.Size = New System.Drawing.Size(55, 5)
        Me.PictureBox78.TabIndex = 157
        Me.PictureBox78.TabStop = False
        Me.PictureBox78.Tag = "Path-Up-Left"
        Me.PictureBox78.Visible = False
        '
        'PictureBox121
        '
        Me.PictureBox121.BackColor = System.Drawing.Color.Red
        Me.PictureBox121.Location = New System.Drawing.Point(135, 210)
        Me.PictureBox121.Name = "PictureBox121"
        Me.PictureBox121.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox121.TabIndex = 158
        Me.PictureBox121.TabStop = False
        Me.PictureBox121.Tag = "Path-Up-Right"
        Me.PictureBox121.Visible = False
        '
        'PictureBox122
        '
        Me.PictureBox122.BackColor = System.Drawing.Color.Red
        Me.PictureBox122.Location = New System.Drawing.Point(195, 170)
        Me.PictureBox122.Name = "PictureBox122"
        Me.PictureBox122.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox122.TabIndex = 159
        Me.PictureBox122.TabStop = False
        Me.PictureBox122.Tag = "Path-Up-Right"
        Me.PictureBox122.Visible = False
        '
        'picScaredGhost
        '
        Me.picScaredGhost.Image = CType(resources.GetObject("picScaredGhost.Image"), System.Drawing.Image)
        Me.picScaredGhost.Location = New System.Drawing.Point(-245, -30)
        Me.picScaredGhost.Name = "picScaredGhost"
        Me.picScaredGhost.Size = New System.Drawing.Size(40, 30)
        Me.picScaredGhost.TabIndex = 160
        Me.picScaredGhost.TabStop = False
        Me.picScaredGhost.Visible = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Black
        Me.lblScore.Location = New System.Drawing.Point(0, 385)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(115, 15)
        Me.lblScore.TabIndex = 161
        Me.lblScore.Text = "Score:0"
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.White
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.Black
        Me.lblLevel.Location = New System.Drawing.Point(115, 385)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(85, 15)
        Me.lblLevel.TabIndex = 163
        Me.lblLevel.Text = "Level:1"
        '
        'MusicPlayer
        '
        Me.MusicPlayer.Enabled = True
        Me.MusicPlayer.Location = New System.Drawing.Point(330, 360)
        Me.MusicPlayer.Name = "MusicPlayer"
        Me.MusicPlayer.OcxState = CType(resources.GetObject("MusicPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MusicPlayer.TabIndex = 164
        Me.MusicPlayer.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(0, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 25)
        Me.Label1.TabIndex = 165
        '
        'lblLifes
        '
        Me.lblLifes.BackColor = System.Drawing.Color.White
        Me.lblLifes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLifes.ForeColor = System.Drawing.Color.Black
        Me.lblLifes.Location = New System.Drawing.Point(200, 385)
        Me.lblLifes.Name = "lblLifes"
        Me.lblLifes.Size = New System.Drawing.Size(60, 15)
        Me.lblLifes.TabIndex = 166
        Me.lblLifes.Text = "Lifes:3"
        '
        'picboxFruit
        '
        Me.picboxFruit.Image = CType(resources.GetObject("picboxFruit.Image"), System.Drawing.Image)
        Me.picboxFruit.Location = New System.Drawing.Point(295, 100)
        Me.picboxFruit.Name = "picboxFruit"
        Me.picboxFruit.Size = New System.Drawing.Size(25, 25)
        Me.picboxFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxFruit.TabIndex = 167
        Me.picboxFruit.TabStop = False
        Me.picboxFruit.Tag = "1"
        '
        'picFruit2
        '
        Me.picFruit2.Image = CType(resources.GetObject("picFruit2.Image"), System.Drawing.Image)
        Me.picFruit2.Location = New System.Drawing.Point(10, 35)
        Me.picFruit2.Name = "picFruit2"
        Me.picFruit2.Size = New System.Drawing.Size(25, 25)
        Me.picFruit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit2.TabIndex = 168
        Me.picFruit2.TabStop = False
        Me.picFruit2.Tag = "1"
        Me.picFruit2.Visible = False
        '
        'picFruit10
        '
        Me.picFruit10.Image = CType(resources.GetObject("picFruit10.Image"), System.Drawing.Image)
        Me.picFruit10.Location = New System.Drawing.Point(10, 100)
        Me.picFruit10.Name = "picFruit10"
        Me.picFruit10.Size = New System.Drawing.Size(25, 25)
        Me.picFruit10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit10.TabIndex = 169
        Me.picFruit10.TabStop = False
        Me.picFruit10.Tag = "1"
        Me.picFruit10.Visible = False
        '
        'picFruit9
        '
        Me.picFruit9.Image = CType(resources.GetObject("picFruit9.Image"), System.Drawing.Image)
        Me.picFruit9.Location = New System.Drawing.Point(10, 65)
        Me.picFruit9.Name = "picFruit9"
        Me.picFruit9.Size = New System.Drawing.Size(25, 25)
        Me.picFruit9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit9.TabIndex = 170
        Me.picFruit9.TabStop = False
        Me.picFruit9.Tag = "1"
        Me.picFruit9.Visible = False
        '
        'picFruit3
        '
        Me.picFruit3.Image = CType(resources.GetObject("picFruit3.Image"), System.Drawing.Image)
        Me.picFruit3.Location = New System.Drawing.Point(40, 100)
        Me.picFruit3.Name = "picFruit3"
        Me.picFruit3.Size = New System.Drawing.Size(25, 25)
        Me.picFruit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit3.TabIndex = 171
        Me.picFruit3.TabStop = False
        Me.picFruit3.Tag = "1"
        Me.picFruit3.Visible = False
        '
        'picFruit4
        '
        Me.picFruit4.Image = CType(resources.GetObject("picFruit4.Image"), System.Drawing.Image)
        Me.picFruit4.Location = New System.Drawing.Point(65, 100)
        Me.picFruit4.Name = "picFruit4"
        Me.picFruit4.Size = New System.Drawing.Size(25, 25)
        Me.picFruit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit4.TabIndex = 172
        Me.picFruit4.TabStop = False
        Me.picFruit4.Tag = "1"
        Me.picFruit4.Visible = False
        '
        'picFruit5
        '
        Me.picFruit5.Image = CType(resources.GetObject("picFruit5.Image"), System.Drawing.Image)
        Me.picFruit5.Location = New System.Drawing.Point(70, 130)
        Me.picFruit5.Name = "picFruit5"
        Me.picFruit5.Size = New System.Drawing.Size(25, 25)
        Me.picFruit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit5.TabIndex = 173
        Me.picFruit5.TabStop = False
        Me.picFruit5.Tag = "1"
        Me.picFruit5.Visible = False
        '
        'picFruit8
        '
        Me.picFruit8.Image = CType(resources.GetObject("picFruit8.Image"), System.Drawing.Image)
        Me.picFruit8.Location = New System.Drawing.Point(40, 140)
        Me.picFruit8.Name = "picFruit8"
        Me.picFruit8.Size = New System.Drawing.Size(25, 25)
        Me.picFruit8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit8.TabIndex = 174
        Me.picFruit8.TabStop = False
        Me.picFruit8.Tag = "1"
        Me.picFruit8.Visible = False
        '
        'picFruit6
        '
        Me.picFruit6.Image = CType(resources.GetObject("picFruit6.Image"), System.Drawing.Image)
        Me.picFruit6.Location = New System.Drawing.Point(10, 140)
        Me.picFruit6.Name = "picFruit6"
        Me.picFruit6.Size = New System.Drawing.Size(25, 25)
        Me.picFruit6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit6.TabIndex = 175
        Me.picFruit6.TabStop = False
        Me.picFruit6.Tag = "1"
        Me.picFruit6.Visible = False
        '
        'picFruit7
        '
        Me.picFruit7.Image = CType(resources.GetObject("picFruit7.Image"), System.Drawing.Image)
        Me.picFruit7.Location = New System.Drawing.Point(70, 180)
        Me.picFruit7.Name = "picFruit7"
        Me.picFruit7.Size = New System.Drawing.Size(25, 25)
        Me.picFruit7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit7.TabIndex = 176
        Me.picFruit7.TabStop = False
        Me.picFruit7.Tag = "1"
        Me.picFruit7.Visible = False
        '
        'picFruit1
        '
        Me.picFruit1.Image = CType(resources.GetObject("picFruit1.Image"), System.Drawing.Image)
        Me.picFruit1.Location = New System.Drawing.Point(70, 60)
        Me.picFruit1.Name = "picFruit1"
        Me.picFruit1.Size = New System.Drawing.Size(25, 25)
        Me.picFruit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit1.TabIndex = 177
        Me.picFruit1.TabStop = False
        Me.picFruit1.Tag = "1"
        Me.picFruit1.Visible = False
        '
        'PictureBox123
        '
        Me.PictureBox123.BackColor = System.Drawing.Color.Red
        Me.PictureBox123.Location = New System.Drawing.Point(65, 130)
        Me.PictureBox123.Name = "PictureBox123"
        Me.PictureBox123.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox123.TabIndex = 178
        Me.PictureBox123.TabStop = False
        Me.PictureBox123.Tag = "Path-Up-Left"
        Me.PictureBox123.Visible = False
        '
        'PictureBox124
        '
        Me.PictureBox124.BackColor = System.Drawing.Color.Red
        Me.PictureBox124.Location = New System.Drawing.Point(25, 135)
        Me.PictureBox124.Name = "PictureBox124"
        Me.PictureBox124.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox124.TabIndex = 179
        Me.PictureBox124.TabStop = False
        Me.PictureBox124.Tag = "Path-Left-Flip"
        Me.PictureBox124.Visible = False
        '
        'PictureBox125
        '
        Me.PictureBox125.BackColor = System.Drawing.Color.Red
        Me.PictureBox125.Location = New System.Drawing.Point(50, 280)
        Me.PictureBox125.Name = "PictureBox125"
        Me.PictureBox125.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox125.TabIndex = 180
        Me.PictureBox125.TabStop = False
        Me.PictureBox125.Tag = "Path-Up-Left"
        Me.PictureBox125.Visible = False
        '
        'PictureBox126
        '
        Me.PictureBox126.BackColor = System.Drawing.Color.Red
        Me.PictureBox126.Location = New System.Drawing.Point(20, 285)
        Me.PictureBox126.Name = "PictureBox126"
        Me.PictureBox126.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox126.TabIndex = 181
        Me.PictureBox126.TabStop = False
        Me.PictureBox126.Tag = "Path-Left-Flip"
        Me.PictureBox126.Visible = False
        '
        'PictureBox127
        '
        Me.PictureBox127.BackColor = System.Drawing.Color.Red
        Me.PictureBox127.Location = New System.Drawing.Point(340, 130)
        Me.PictureBox127.Name = "PictureBox127"
        Me.PictureBox127.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox127.TabIndex = 182
        Me.PictureBox127.TabStop = False
        Me.PictureBox127.Tag = "Path-Up-Right"
        Me.PictureBox127.Visible = False
        '
        'PictureBox128
        '
        Me.PictureBox128.BackColor = System.Drawing.Color.Red
        Me.PictureBox128.Location = New System.Drawing.Point(390, 135)
        Me.PictureBox128.Name = "PictureBox128"
        Me.PictureBox128.Size = New System.Drawing.Size(5, 35)
        Me.PictureBox128.TabIndex = 183
        Me.PictureBox128.TabStop = False
        Me.PictureBox128.Tag = "Path-Right-Flip"
        Me.PictureBox128.Visible = False
        '
        'PictureBox129
        '
        Me.PictureBox129.BackColor = System.Drawing.Color.Red
        Me.PictureBox129.Location = New System.Drawing.Point(340, 170)
        Me.PictureBox129.Name = "PictureBox129"
        Me.PictureBox129.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox129.TabIndex = 184
        Me.PictureBox129.TabStop = False
        Me.PictureBox129.Tag = "Path-Down-Right"
        Me.PictureBox129.Visible = False
        '
        'PictureBox130
        '
        Me.PictureBox130.BackColor = System.Drawing.Color.Red
        Me.PictureBox130.Location = New System.Drawing.Point(65, 170)
        Me.PictureBox130.Name = "PictureBox130"
        Me.PictureBox130.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox130.TabIndex = 185
        Me.PictureBox130.TabStop = False
        Me.PictureBox130.Tag = "Path-Down-Left"
        Me.PictureBox130.Visible = False
        '
        'PictureBox131
        '
        Me.PictureBox131.BackColor = System.Drawing.Color.Red
        Me.PictureBox131.Location = New System.Drawing.Point(50, 320)
        Me.PictureBox131.Name = "PictureBox131"
        Me.PictureBox131.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox131.TabIndex = 186
        Me.PictureBox131.TabStop = False
        Me.PictureBox131.Tag = "Path-Down-Left"
        Me.PictureBox131.Visible = False
        '
        'PictureBox132
        '
        Me.PictureBox132.BackColor = System.Drawing.Color.Red
        Me.PictureBox132.Location = New System.Drawing.Point(275, 310)
        Me.PictureBox132.Name = "PictureBox132"
        Me.PictureBox132.Size = New System.Drawing.Size(35, 5)
        Me.PictureBox132.TabIndex = 187
        Me.PictureBox132.TabStop = False
        Me.PictureBox132.Tag = "Path-Up-Right"
        Me.PictureBox132.Visible = False
        '
        'PictureBox133
        '
        Me.PictureBox133.BackColor = System.Drawing.Color.Red
        Me.PictureBox133.Location = New System.Drawing.Point(315, 285)
        Me.PictureBox133.Name = "PictureBox133"
        Me.PictureBox133.Size = New System.Drawing.Size(5, 30)
        Me.PictureBox133.TabIndex = 188
        Me.PictureBox133.TabStop = False
        Me.PictureBox133.Tag = "Path-Left-FlipDown"
        Me.PictureBox133.Visible = False
        '
        'lblHigh
        '
        Me.lblHigh.BackColor = System.Drawing.Color.White
        Me.lblHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHigh.ForeColor = System.Drawing.Color.Black
        Me.lblHigh.Location = New System.Drawing.Point(270, 385)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(130, 15)
        Me.lblHigh.TabIndex = 189
        Me.lblHigh.Text = "HighScore:0"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(409, 403)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.PictureBox133)
        Me.Controls.Add(Me.PictureBox132)
        Me.Controls.Add(Me.PictureBox131)
        Me.Controls.Add(Me.PictureBox130)
        Me.Controls.Add(Me.PictureBox129)
        Me.Controls.Add(Me.PictureBox128)
        Me.Controls.Add(Me.PictureBox127)
        Me.Controls.Add(Me.PictureBox126)
        Me.Controls.Add(Me.PictureBox125)
        Me.Controls.Add(Me.PictureBox124)
        Me.Controls.Add(Me.PictureBox123)
        Me.Controls.Add(Me.picFruit1)
        Me.Controls.Add(Me.picFruit7)
        Me.Controls.Add(Me.picFruit6)
        Me.Controls.Add(Me.picFruit8)
        Me.Controls.Add(Me.picFruit5)
        Me.Controls.Add(Me.picFruit4)
        Me.Controls.Add(Me.picFruit3)
        Me.Controls.Add(Me.picFruit9)
        Me.Controls.Add(Me.picFruit10)
        Me.Controls.Add(Me.picFruit2)
        Me.Controls.Add(Me.picboxFruit)
        Me.Controls.Add(Me.lblLifes)
        Me.Controls.Add(Me.MusicPlayer)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picScaredGhost)
        Me.Controls.Add(Me.PictureBox122)
        Me.Controls.Add(Me.PictureBox121)
        Me.Controls.Add(Me.PictureBox78)
        Me.Controls.Add(Me.PictureBox120)
        Me.Controls.Add(Me.PictureBox119)
        Me.Controls.Add(Me.PictureBox118)
        Me.Controls.Add(Me.PictureBox117)
        Me.Controls.Add(Me.PictureBox116)
        Me.Controls.Add(Me.PictureBox115)
        Me.Controls.Add(Me.PictureBox114)
        Me.Controls.Add(Me.PictureBox113)
        Me.Controls.Add(Me.PictureBox112)
        Me.Controls.Add(Me.PictureBox111)
        Me.Controls.Add(Me.PictureBox110)
        Me.Controls.Add(Me.PictureBox109)
        Me.Controls.Add(Me.PictureBox108)
        Me.Controls.Add(Me.PictureBox107)
        Me.Controls.Add(Me.PictureBox106)
        Me.Controls.Add(Me.PictureBox105)
        Me.Controls.Add(Me.PictureBox104)
        Me.Controls.Add(Me.PictureBox103)
        Me.Controls.Add(Me.PictureBox102)
        Me.Controls.Add(Me.PictureBox101)
        Me.Controls.Add(Me.PictureBox99)
        Me.Controls.Add(Me.PictureBox96)
        Me.Controls.Add(Me.PictureBox80)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox100)
        Me.Controls.Add(Me.PictureBox98)
        Me.Controls.Add(Me.PictureBox97)
        Me.Controls.Add(Me.PictureBox95)
        Me.Controls.Add(Me.PictureBox94)
        Me.Controls.Add(Me.PictureBox93)
        Me.Controls.Add(Me.PictureBox92)
        Me.Controls.Add(Me.PictureBox91)
        Me.Controls.Add(Me.PictureBox90)
        Me.Controls.Add(Me.PictureBox89)
        Me.Controls.Add(Me.PictureBox88)
        Me.Controls.Add(Me.PictureBox87)
        Me.Controls.Add(Me.PictureBox86)
        Me.Controls.Add(Me.PictureBox85)
        Me.Controls.Add(Me.PictureBox84)
        Me.Controls.Add(Me.PictureBox83)
        Me.Controls.Add(Me.PictureBox82)
        Me.Controls.Add(Me.PictureBox81)
        Me.Controls.Add(Me.PictureBox79)
        Me.Controls.Add(Me.PictureBox77)
        Me.Controls.Add(Me.PictureBox76)
        Me.Controls.Add(Me.PictureBox75)
        Me.Controls.Add(Me.PictureBox74)
        Me.Controls.Add(Me.PictureBox73)
        Me.Controls.Add(Me.PictureBox72)
        Me.Controls.Add(Me.PictureBox71)
        Me.Controls.Add(Me.PictureBox70)
        Me.Controls.Add(Me.PictureBox69)
        Me.Controls.Add(Me.PictureBox68)
        Me.Controls.Add(Me.PictureBox67)
        Me.Controls.Add(Me.PictureBox66)
        Me.Controls.Add(Me.PictureBox65)
        Me.Controls.Add(Me.PictureBox64)
        Me.Controls.Add(Me.PictureBox63)
        Me.Controls.Add(Me.PictureBox62)
        Me.Controls.Add(Me.PictureBox61)
        Me.Controls.Add(Me.PictureBox60)
        Me.Controls.Add(Me.PictureBox59)
        Me.Controls.Add(Me.PictureBox58)
        Me.Controls.Add(Me.PictureBox57)
        Me.Controls.Add(Me.PictureBox29)
        Me.Controls.Add(Me.PictureBox28)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox56)
        Me.Controls.Add(Me.PictureBox55)
        Me.Controls.Add(Me.PictureBox54)
        Me.Controls.Add(Me.PictureBox52)
        Me.Controls.Add(Me.PictureBox53)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox33)
        Me.Controls.Add(Me.PictureBox36)
        Me.Controls.Add(Me.PictureBox50)
        Me.Controls.Add(Me.PictureBox51)
        Me.Controls.Add(Me.PictureBox48)
        Me.Controls.Add(Me.PictureBox49)
        Me.Controls.Add(Me.PictureBox44)
        Me.Controls.Add(Me.PictureBox45)
        Me.Controls.Add(Me.PictureBox46)
        Me.Controls.Add(Me.PictureBox47)
        Me.Controls.Add(Me.PictureBox42)
        Me.Controls.Add(Me.PictureBox43)
        Me.Controls.Add(Me.PictureBox41)
        Me.Controls.Add(Me.PictureBox39)
        Me.Controls.Add(Me.PictureBox40)
        Me.Controls.Add(Me.PictureBox37)
        Me.Controls.Add(Me.PictureBox38)
        Me.Controls.Add(Me.PictureBox35)
        Me.Controls.Add(Me.PictureBox34)
        Me.Controls.Add(Me.PictureBox32)
        Me.Controls.Add(Me.PictureBox31)
        Me.Controls.Add(Me.PictureBox30)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.picboxGate)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.picboxGhost5)
        Me.Controls.Add(Me.picboxGhost4)
        Me.Controls.Add(Me.picboxGhost3)
        Me.Controls.Add(Me.picboxGhost2)
        Me.Controls.Add(Me.picboxGhost1)
        Me.Controls.Add(Me.picPacMan)
        Me.Controls.Add(Me.PicGhost5)
        Me.Controls.Add(Me.picGhost4)
        Me.Controls.Add(Me.picGhost3)
        Me.Controls.Add(Me.picGhost2)
        Me.Controls.Add(Me.picGhost1)
        Me.Controls.Add(Me.MediaPlayer)
        Me.Controls.Add(Me.picPacLeft2)
        Me.Controls.Add(Me.PicPacLeft1)
        Me.Controls.Add(Me.picPacDown2)
        Me.Controls.Add(Me.picPacDown1)
        Me.Controls.Add(Me.picPacUp2)
        Me.Controls.Add(Me.picPacUp1)
        Me.Controls.Add(Me.picPacRight2)
        Me.Controls.Add(Me.picPacRight1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Tag = "1"
        Me.Text = "J34 - Pac Man"
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"


    Dim GameOn As Boolean
    Dim GameOver As Boolean

    Dim HighScore As Integer

    Dim PacSpeed As Integer = 1
    Dim PacLifes As Integer = 3
    Dim PacScore As Integer = 0
    Dim PacManLevel As Integer = 1
    Dim DisplayLevel As Integer = PacManLevel

    Dim FruitDir As String = "left"
    Dim FruitCCount As Integer = 0
    Dim FruitCBuf As Boolean = False

    Dim MoveDir As String = "right" 'Direction moving in
    Dim movestage As Integer = 10 'Count down to change pic
    Dim rd, ld, ud, dd As Boolean 'Keys being held down
    Dim DotCords(0) As Point ' Cordinates of remianing dots
    Dim DotCordsType(0) As String 'Type of each dotcord
    Dim DotCount As Integer 'number of remaining dots
    Dim PacSpin As Boolean = False 'Spin squence when pacman dies

    Dim DotsDrawn As Boolean 'Start of game initialization

    Dim GhostSpeed As Integer = 1
    Dim GhostsEaten As Integer = 0
    Dim Ghostdir(4) As String ' The direction each of the ghosts travel
    Dim FastGhost As Integer


    Dim GhostChangeBuf(4) As Boolean 'Stops corner paths conflicting during diagonal chase
    Dim GhostChangeCount(4) As Integer 'Counts pixels moved, to avoid conflicts
    Dim GCBufWall(4) As Boolean ' Stop wall conflicts
    Dim GCCountWall(4) As Integer

    Dim MorphReverse As Boolean 'If large dot eaten, ghosts run

    Dim MediaLocs(4) As String

    Dim Restarting As Boolean

#End Region

#Region "Options"
    Public QuickGhost As Boolean
    Public StartPacSpeed As Integer
    Public StartGhostSpeed As Integer
#End Region

#Region "HighScore"
    Private Sub LoadHighScore()
        If IO.File.Exists(Application.StartupPath & "\PacHighScore.J34") Then
            Dim HighFile As New IO.StreamReader("PacHighScore.J34")
            HighScore = Integer.Parse(highfile.ReadToEnd())
            highfile.Close()
            lblHigh.Text = "HighScore:" & HighScore
        Else
            Dim HighFile As New IO.StreamWriter("PacHighScore.J34")
            highfile.Write("0")
            highfile.Close()
            HighScore = 0
        End If
    End Sub
    Private Sub WriteHighScore()
        If IO.File.Exists(Application.StartupPath & "\PacHighScore.J34") Then
            IO.File.Delete(Application.StartupPath & "\PacHighScore.J34")
        End If
        Dim HighFile As New IO.StreamWriter("PacHighScore.J34")
        HighFile.WriteLine(PacScore)
        HighFile.Close()
    End Sub
#End Region

#Region "Drawing"
    Structure PacDot
        Dim DotColor As System.Drawing.Color
        Dim DotSize As Integer
    End Structure

    'Creates lines of dots throughout maze
    Private Sub InitializeDots()
        MakeLine(15, 15, 150, 15)
        MakeLine(15, 40, 15, 110)

        MakeLine(85, 40, 85, 40)
        MakeLine(85, 90, 85, 265)

        MakeLine(50, 115, 50, 115)

        MakeLine(40, 70, 370, 70)

        MakeLine(250, 40, 250, 40)
        MakeLine(250, 90, 250, 290)

        MakeLine(145, 40, 145, 40)
        MakeLine(185, 40, 185, 40)
        MakeLine(315, 40, 315, 40)

        MakeLine(185, 15, 390, 15)
        MakeLine(390, 40, 390, 110)

        MakeLine(275, 110, 370, 110)

        MakeLine(125, 90, 125, 110)
        MakeLine(145, 110, 145, 130)
        MakeLine(210, 90, 210, 110)
        MakeLine(190, 110, 190, 130)
        MakeLine(125, 150, 210, 150)

        MakeLine(355, 135, 355, 235)
        MakeLine(275, 260, 355, 255)

        MakeLine(130, 170, 130, 170)
        MakeLine(210, 170, 210, 170)
        MakeLine(110, 190, 155, 190)
        MakeLine(185, 190, 230, 190)

        MakeLine(40, 190, 70, 190)
        MakeLine(15, 190, 15, 260)
        MakeLine(40, 260, 70, 260)

        MakeLine(70, 280, 70, 340)
        MakeLine(70, 365, 180, 365)

        MakeLine(150, 210, 150, 210)
        MakeLine(205, 210, 210, 210)
        MakeLine(130, 230, 210, 230)
        MakeLine(130, 250, 130, 250)
        MakeLine(210, 250, 210, 250)

        MakeLine(110, 270, 230, 270)
        MakeLine(105, 290, 105, 290)
        MakeLine(250, 290, 250, 290)
        MakeLine(105, 310, 265, 310)

        MakeLine(290, 275, 290, 360)
        MakeLine(250, 365, 285, 365)
        MakeLine(180, 345, 250, 345)
        MakeLine(135, 345, 135, 345)

        MakeMorph(45, 70)
        MakeMorph(385, 15)
        MakeMorph(175, 340)

        DotsDrawn = True
        Randomize()
        FastGhost = (Rnd() * 4) + 1
        ChangeWalls()
    End Sub

    'Finds the nearest dot to the given coordinates and turns it into morph dot
    Private Sub MakeMorph(ByVal X As Integer, ByVal Y As Integer)
        Dim ClosestMatch As Point
        Dim MatchIndex As Integer
        Dim TestMatch As Point
        Dim TestIndex As Integer
        Dim TestDiffX, TestDiffY, TotalDiff, TotalClose As Integer
        Dim CloseDiffX, CloseDiffY As Integer

        If DotCords.Length > 0 Then
            With TestMatch
                ClosestMatch.X = DotCords(0).X
                ClosestMatch.Y = DotCords(0).Y
                MatchIndex = 0
                CloseDiffX = IIf(ClosestMatch.X > X, ClosestMatch.X - X, X - ClosestMatch.X)
                CloseDiffY = IIf(ClosestMatch.Y > Y, ClosestMatch.Y - Y, Y - ClosestMatch.Y)
                TotalClose = CloseDiffX + CloseDiffY
                For TestIndex = 0 To (DotCords.Length - 1)
                    .X = DotCords(TestIndex).X
                    .Y = DotCords(TestIndex).Y
                    TestDiffX = IIf(X > .X, X - .X, .X - X)
                    TestDiffY = IIf(Y > .Y, Y - .Y, .Y - Y)
                    TotalDiff = TestDiffX + TestDiffY
                    If TotalDiff < TotalClose Then
                        ClosestMatch.X = .X
                        ClosestMatch.Y = .Y
                        TotalClose = TotalDiff
                        MatchIndex = TestIndex
                    End If
                Next TestIndex
                DotCordsType(MatchIndex) = "morph"
            End With
        End If
    End Sub

    'Creates a line of dot coordinates spaced out by 25
    Private Sub MakeLine(ByVal firstx As Integer, ByVal firsty As Integer, ByVal endx As Integer, ByVal endy As Integer)
        Dim i, j, x, y As Integer
        Dim tempPoint As Point
        'number of dots = ((last - first)/interval) + 1
        If firstx <> endx Then
            x = endx
            y = firstx
        Else
            x = endy
            y = firsty
        End If
        j = ((x - y) / 25) + 1
        For i = 0 To (j - 1)
            If firstx <> endx Then
                x = firstx + (i * 25)
                y = firsty
            Else
                x = firstx
                y = firsty + (i * 25)
            End If
            'inventory the new point
            MakeP(tempPoint, x, y)
            DotCount = DotCords.Length
            ReDim Preserve DotCords(DotCount)
            ReDim Preserve DotCordsType(DotCount)
            DotCords(DotCount - 1) = tempPoint
            DotCordsType(DotCount - 1) = "normal"
        Next i
    End Sub

    'Creates a point with coordinates
    Private Sub MakeP(ByRef temppoint As Point, ByVal x As Integer, ByVal y As Integer)
        temppoint = New Point(x, y)
    End Sub

    'Changes wall colors based on level
    Private Sub ChangeWalls()
        Dim mytype As System.Type
        Dim curpic As PictureBox
        Dim NewColor As System.Drawing.Color
        Dim i As Integer
        Select Case PacManLevel
            Case 1
                NewColor = Color.White
            Case 2
                NewColor = Color.Yellow
            Case 3
                NewColor = Color.Blue
            Case 4
                NewColor = Color.Red
            Case 5
                NewColor = Color.Orange
            Case 6
                NewColor = Color.Green
            Case 7
                NewColor = Color.Purple
            Case 8
                NewColor = Color.White
            Case 9
                NewColor = Color.SkyBlue
            Case 10
                NewColor = Color.DeepPink
        End Select
        For i = 0 To (Me.Controls.Count - 1)
            mytype = Me.Controls(i).GetType
            If mytype.Name.ToLower = "picturebox" Then
                curpic = Me.Controls(i)
                If curpic.Tag = "Wall" Then
                    curpic.BackColor = NewColor
                End If
            End If
        Next i
    End Sub

    'Draws all remaining dots stored in DotCords array
    Private Sub DrawDots()
        Dim i As Integer
        Dim nwdot As New PacDot
        Dim maincolor As System.Drawing.Color
        If DotCount > 0 Then
            Select Case PacManLevel
                Case 1
                    maincolor = Color.Yellow
                Case 2
                    maincolor = Color.Blue
                Case 3
                    maincolor = Color.Red
                Case 4
                    maincolor = Color.Orange
                Case 5
                    maincolor = Color.Green
                Case 6
                    maincolor = Color.Purple
                Case 7
                    maincolor = Color.White
                Case 8
                    maincolor = Color.SkyBlue
                Case 9
                    maincolor = Color.DeepPink
                Case 10
                    maincolor = Color.LimeGreen
            End Select
            nwdot.DotSize = 4
            For i = 0 To (DotCords.Length - 1)
                If DotCordsType(i) = "morph" Then
                    nwdot.DotColor = Color.Brown
                    nwdot.DotSize = 10
                Else
                    nwdot.DotColor = maincolor
                End If
                DrawPoint(DotCords(i), nwdot)
                nwdot.DotColor = maincolor
                nwdot.DotSize = 4
            Next i
        End If
    End Sub

    'Draws a yellow 4x4 dot at DPoint
    Private Sub DrawPoint(ByRef DPoint As Point, ByVal DotType As PacDot)
        Dim mygraph As Drawing.Graphics
        Dim mypen As New Pen(DotType.DotColor)
        mygraph = Me.CreateGraphics
        mypen.Width = DotType.DotSize
        mygraph.DrawLine(mypen, DPoint.X, DPoint.Y, DPoint.X + mypen.Width, DPoint.Y)
        mygraph.DrawLine(mypen, DPoint.X, DPoint.Y + mypen.Width, DPoint.X, DPoint.Y + mypen.Width)
        mygraph.Dispose()
    End Sub

#End Region

    'Take away a life and reset game
    Private Sub Retry()
        Dim i As Integer
        GameOver = False
        PacLifes -= 1
        lblLifes.Text = "Lifes:" & PacLifes


        If DotCount = 0 Or PacLifes <= 0 Then
            ReDim DotCords(0)
            ReDim DotCordsType(0)
            DotsDrawn = False
            DotCount = 0
            InitializeDots()
            'Fruit Reset code
            If FruitDir = "dead" Then FruitDir = "left"
            If picboxFruit.Visible = False Then
                picboxFruit.Visible = True
            End If
        End If

        If PacLifes <= 0 Then
            'Restart game
            PacLifes = 3
            PacManLevel = 1
            If PacScore >= HighScore Then
                WriteHighScore()
                HighScore = PacScore
                MsgBox("HIGH SCORE!", MsgBoxStyle.Exclamation, "J34 PacMan")
            End If
            PacScore = 0
            lblScore.Text = "Score:" & PacScore
            lblLifes.Text = "Lifes:" & PacLifes
            lblLevel.Text = "Level:" & PacManLevel
        End If

        For i = 0 To 4
            Ghostdir(i) = "Waiting"
        Next i

        Select Case PacManLevel
            Case 1
                picboxFruit.Image = picFruit1.Image
            Case 2
                picboxFruit.Image = picFruit2.Image
            Case 3
                picboxFruit.Image = picFruit3.Image
            Case 4
                picboxFruit.Image = picFruit4.Image
            Case 5
                picboxFruit.Image = picFruit5.Image
            Case 6
                picboxFruit.Image = picFruit6.Image
            Case 7
                picboxFruit.Image = picFruit7.Image
            Case 8
                picboxFruit.Image = picFruit8.Image
            Case 9
                picboxFruit.Image = picFruit9.Image
            Case 10
                picboxFruit.Image = picFruit10.Image
            Case Else
                picboxFruit.Image = picFruit10.Image
        End Select


        picPacMan.Location = New Point(10, 5)
        picboxGhost1.Location = New Point(290, 140)
        picboxGhost2.Location = New Point(275, 170)
        picboxGhost3.Location = New Point(305, 170)
        picboxGhost4.Location = New Point(275, 205)
        picboxGhost5.Location = New Point(305, 205)
        picboxGhost1.Image = picGhost1.Image
        picboxGhost2.Image = picGhost2.Image
        picboxGhost3.Image = picGhost3.Image
        picboxGhost4.Image = picGhost4.Image
        picboxGhost5.Image = PicGhost5.Image
        picboxGhost1.Visible = True
        picboxGhost2.Visible = True
        picboxGhost3.Visible = True
        picboxGhost4.Visible = True
        picboxGhost5.Visible = True
        picPacMan.Image = Me.picPacRight1.Image

        Restarting = False
        PacSpeed = StartPacSpeed
        MoveDir = "right"
        movestage = 10

        PacSpin = False
        GhostSpeed = StartGhostSpeed
        ReDim GhostChangeBuf(4)
        ReDim GhostChangeCount(4)
        ReDim GCBufWall(4)
        ReDim GCCountWall(4)

        MorphReverse = False
        MorphTimer.Interval = 1
        MorphTimer.Enabled = False
        GameOn = False
        GateTimer.Interval = 1

        GateTimer.Enabled = True
        Timer1.Enabled = True
        ChangeWalls()
    End Sub

    'Inventory dots, load sounds
    Public Sub LoadPacMan()
        Dim i As Integer
        Dim StartPath As String = Application.StartupPath & "\Data\"
        MediaLocs(0) = StartPath & "blip.wav"
        MediaLocs(1) = StartPath & "Killed.wav"
        MediaLocs(2) = StartPath & "LevelUp.wav"
        MediaLocs(3) = StartPath & "Morph.wav"
        MediaLocs(4) = StartPath & "GhostEaten.wav"
        InitializeDots()
        For i = 0 To 4
            Ghostdir(i) = "Waiting"
        Next i
        LoadHighScore()
        PacSpeed = StartPacSpeed
        GhostSpeed = StartGhostSpeed
        Timer1.Enabled = True
    End Sub

    'End program
    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If PacScore > HighScore Then WriteHighScore()
        Application.Exit()
    End Sub

    'Change direction
    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            MoveDir = "left"
            ld = True
        ElseIf e.KeyCode = Keys.Right Then
            MoveDir = "right"
            rd = True
        ElseIf e.KeyCode = Keys.Up Then
            MoveDir = "up"
            ud = True
        ElseIf e.KeyCode = Keys.Down Then
            MoveDir = "down"
            dd = True
        End If
    End Sub

    'If direction key is released Check for other keys still pressed/reset direction
    Private Sub MainForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            ld = False
            If rd = True Then MoveDir = "right"
            If ud = True Then MoveDir = "up"
            If dd = True Then MoveDir = "down"
        ElseIf e.KeyCode = Keys.Right Then
            If ld = True Then MoveDir = "left"
            rd = False
            If ud = True Then MoveDir = "up"
            If dd = True Then MoveDir = "down"
        ElseIf e.KeyCode = Keys.Up Then
            If ld = True Then MoveDir = "left"
            If rd = True Then MoveDir = "right"
            ud = False
            If dd = True Then MoveDir = "down"
        ElseIf e.KeyCode = Keys.Down Then
            If ld = True Then MoveDir = "left"
            If rd = True Then MoveDir = "right"
            If ud = True Then MoveDir = "up"
            dd = False
        End If
    End Sub

    'Moves the fruit
    Private Sub MoveFruit()
        Dim x, y, wx, hy As Integer
        Dim WallBuf, Buf2() As String
        Dim randnum As Integer
        With picboxFruit
            x = .Location.X
            y = .Location.Y
            Select Case FruitDir
                Case "up"
                    y -= PacSpeed * 2
                Case "down"
                    y += PacSpeed * 2
                Case "left"
                    x -= PacSpeed * 2
                Case "right"
                    x += PacSpeed * 2
            End Select
            wx = x + .Width
            hy = y + .Height
            'see if fruit hit a wall
            If CheckWall(picboxFruit, FruitDir, WallBuf, PacSpeed) Then
                'no wall, check for paths
                WallBuf = CheckPaths(picboxFruit, New Point(x, y), FruitDir)
                If WallBuf <> "true" Then
                    'Hit a path
                    Buf2 = WallBuf.Split("-")
                    'buf(0)=direction
                    'buf(1) = directions open
                    'buf(2)=x coord
                    'buf(3)=y coord
                    Randomize()
                    'randnum = (Rnd() * 3)
                    randnum = 1
                    If randnum = 1 Then
                        Buf2(1) = Buf2(1).ToLower
                        Select Case FruitDir 'Direction traveling
                            Case "up"
                                LeftRightFruit(Buf2)
                            Case "down"
                                LeftRightFruit(Buf2)
                            Case "left"
                                UpDownFruit(Buf2)
                            Case "right"
                                UpDownFruit(Buf2)
                        End Select
                        If FruitCCount < 30 And FruitCBuf = True Then
                            picboxFruit.Location = New Point(x, y)
                        End If
                    Else
                        'randnum<>1
                        'path hit, but randnum number says dont take it
                        picboxFruit.Location = New Point(x, y)
                    End If
                Else
                    'No paths hit
                    picboxFruit.Location = New Point(x, y)
                End If
            Else
                'Wall hit
                Randomize()
                randnum = (Rnd() * 2)
                Select Case FruitDir
                    Case "up", "down"
                        If randnum = 1 Then
                            FruitDir = "left"
                        Else
                            FruitDir = "right"
                        End If
                    Case "left", "right"
                        If randnum = 1 Then
                            FruitDir = "up"
                        Else
                            FruitDir = "down"
                        End If
                End Select
            End If
        End With
    End Sub

    Private Sub LeftRightFruit(ByVal Buf() As String)
        Dim randnum As Integer
        Randomize()
        If FruitCBuf = False Then
            If Buf(1) = "left" Or Buf(1) = "both" Then
                randnum = (Rnd() * 2)
                If randnum = 1 And Buf(1) = "both" Then
                    FruitDir = "right"
                Else
                    FruitDir = "left"
                End If
                Select Case FruitDir
                    Case "left"
                        Buf(2) -= PacSpeed * 3
                    Case "right"
                        Buf(2) += PacSpeed * 3
                End Select
                FruitCBuf = True
                FruitCCount = 0
                picboxFruit.Location = New Point(Buf(2), Buf(3))

            ElseIf Buf(1) = "right" Or Buf(1) = "both" Then
                randnum = (Rnd() * 2)
                If randnum = 1 And Buf(1) = "both" Then
                    FruitDir = "left"
                Else
                    FruitDir = "right"
                End If
                Select Case FruitDir
                    Case "left"
                        Buf(2) -= PacSpeed * 3
                    Case "right"
                        Buf(2) += PacSpeed * 3
                End Select
                FruitCBuf = True
                FruitCCount = 0
                picboxFruit.Location = New Point(Buf(2), Buf(3))

            ElseIf Buf(1) = "flip" Then
                Select Case FruitDir
                    Case "left"
                        FruitDir = "right"
                    Case "right"
                        FruitDir = "left"
                    Case "up"
                        FruitDir = "down"
                    Case "down"
                        FruitDir = "up"
                End Select
            End If
        Else
            'fruitcbuf=true
            If FruitCCount < 30 Then
                FruitCCount += PacSpeed
            Else
                FruitCCount = 0
                FruitCBuf = False
            End If
        End If
    End Sub
    Private Sub UpDownFruit(ByVal Buf() As String)
        Dim randnum As Integer
        Randomize()
        If FruitCBuf = False Then
            If Buf(1) = "up" Or Buf(1) = "both" Then
                randnum = (Rnd() * 2)
                If randnum = 1 And Buf(1) = "both" Then
                    FruitDir = "down"
                Else
                    FruitDir = "up"
                End If
                Select Case FruitDir
                    Case "up"
                        Buf(2) -= PacSpeed * 3
                    Case "down"
                        Buf(2) += PacSpeed * 3
                End Select
                FruitCBuf = True
                FruitCCount = 0
                picboxFruit.Location = New Point(Buf(2), Buf(3))

            ElseIf Buf(1) = "down" Or Buf(1) = "both" Then
                randnum = (Rnd() * 2)
                If randnum = 1 And Buf(1) = "both" Then
                    FruitDir = "up"
                Else
                    FruitDir = "down"
                End If
                Select Case FruitDir
                    Case "up"
                        Buf(2) -= PacSpeed * 3
                    Case "down"
                        Buf(2) += PacSpeed * 3
                End Select
                FruitCBuf = True
                FruitCCount = 0
                picboxFruit.Location = New Point(Buf(2), Buf(3))
            ElseIf Buf(1) = "flip" Then
                Select Case FruitDir
                    Case "left"
                        FruitDir = "right"
                    Case "right"
                        FruitDir = "left"
                    Case "up"
                        FruitDir = "down"
                    Case "down"
                        FruitDir = "up"
                End Select

            End If
        Else
            'fruitcbuf=true
            If FruitCCount < 30 Then
                FruitCCount += PacSpeed
            Else
                FruitCCount = 0
                FruitCBuf = False
            End If
        End If
    End Sub

    'move Player image/check hits
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim WallBuf As String
        Dim i As Integer
        Static MediaReady As Boolean
        If GhostSpeed > 0 And PacSpeed > 0 And GameOn Then
            MoveGhost(picboxGhost1)
            MoveGhost(picboxGhost2)
            MoveGhost(picboxGhost3)
            MoveGhost(picboxGhost4)
            MoveGhost(picboxGhost5)
        End If
        If PacScore > HighScore Then
            lblHigh.Text = "HighScore:" & PacScore
        End If
        If FruitDir <> "dead" Then MoveFruit()
        CheckFruitHit()
        If GameOn And PacSpeed > 0 Then
            If CheckWall(picPacMan, MoveDir, WallBuf, PacSpeed) Then
                Select Case MoveDir
                    Case "left"
                        picPacMan.Location = New Point(picPacMan.Location.X - PacSpeed, picPacMan.Location.Y)
                    Case "right"
                        picPacMan.Location = New Point(picPacMan.Location.X + PacSpeed, picPacMan.Location.Y)
                    Case "down"
                        picPacMan.Location = New Point(picPacMan.Location.X, picPacMan.Location.Y + PacSpeed)
                    Case "up"
                        picPacMan.Location = New Point(picPacMan.Location.X, picPacMan.Location.Y - PacSpeed)
                End Select
                Checks()
            End If
        Else
            'Check if won or lost game
            If PacSpin And GameOver Then
                'Hit by ghost, spin pacman
                GameOn = False
                Static TimeIn As Integer
                If TimeIn < 10 Then
                    TimeIn += 1
                Else
                    TimeIn = 0
                    movestage += 1
                    If movestage > 4 Then PacSpin = False
                    Select Case movestage
                        Case 1
                            Select Case MoveDir
                                Case "left"
                                    picPacMan.Image = Me.picPacUp2.Image
                                Case "right"
                                    picPacMan.Image = Me.picPacDown2.Image
                                Case "up"
                                    picPacMan.Image = Me.picPacRight2.Image
                                Case "down"
                                    picPacMan.Image = Me.picPacLeft2.Image
                            End Select
                        Case 2
                            Select Case MoveDir
                                Case "left"
                                    picPacMan.Image = Me.picPacRight2.Image
                                Case "right"
                                    picPacMan.Image = Me.picPacLeft2.Image
                                Case "up"
                                    picPacMan.Image = Me.picPacDown2.Image
                                Case "down"
                                    picPacMan.Image = Me.picPacUp2.Image
                            End Select
                        Case 3
                            Select Case MoveDir
                                Case "left"
                                    picPacMan.Image = Me.picPacDown2.Image
                                Case "right"
                                    picPacMan.Image = Me.picPacUp2.Image
                                Case "up"
                                    picPacMan.Image = Me.picPacLeft2.Image
                                Case "down"
                                    picPacMan.Image = Me.picPacRight2.Image
                            End Select
                        Case 4
                            Select Case MoveDir
                                Case "left"
                                    picPacMan.Image = Me.picPacLeft2.Image
                                Case "right"
                                    picPacMan.Image = Me.picPacRight2.Image
                                Case "up"
                                    picPacMan.Image = Me.picPacUp2.Image
                                Case "down"
                                    picPacMan.Image = Me.picPacDown2.Image
                            End Select
                    End Select
                End If
            Else
                If Restarting = False And GameOver Then
                    'died, sequence over, ask for continue
                    Timer1.Enabled = False
                    Restarting = True
                    Dim response As String
                    response = "Restart?"
                    If (PacLifes - 1) > 0 Then response = "Continue?"
                    If MessageBox.Show(response & vbNewLine & (PacLifes - 1) & " lifes left.", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.None) = DialogResult.Yes Then
                        Retry()
                    End If
                End If
            End If
        End If

        'Check if game has been won
        If DotCount = 0 And DotsDrawn And GameOn Then
            PacSpeed = 0
            GhostSpeed = 0
            If MusicPlayer.URL = MediaLocs(2) Then
                If MusicPlayer.Ctlcontrols.currentPosition > 0 Then
                    MediaReady = True
                ElseIf MediaReady = False Then
                    MusicPlayer.Ctlcontrols.play()
                End If
                If MusicPlayer.playState = WMPLib.WMPPlayState.wmppsStopped And MediaReady Then
                    MediaReady = False
                    If PacManLevel < 10 Then
                        PacManLevel += 1
                        lblLevel.Text = "Level:" & PacManLevel
                    ElseIf PacManLevel = 10 Then
                        DisplayLevel = PacManLevel + 1
                        lblLevel.Text = "Level:" & DisplayLevel
                    Else
                        DisplayLevel += 1
                        lblLevel.Text = "Level:" & DisplayLevel
                    End If
                    PacScore += 1000
                    Randomize()
                    FastGhost = (Rnd() * 4) + 1
                    ChangeWalls()

                    GameOn = False
                    DotsDrawn = False
                    PacSpeed = 0
                    GhostSpeed = 0
                    PacLifes += 2
                    Retry()
                End If
            Else
                MusicPlayer.URL = MediaLocs(2)
            End If
        End If
    End Sub

    Private Sub Checks()
        ChangePic()
        CheckDotHit()
    End Sub

    'Check to see if pacman ate the fruit
    Private Sub CheckFruitHit()
        If FruitDir <> "dead" Then
            Select Case FruitDir
                Case "left"
                    If HitGoingLeft(picPacMan, (New Point(picboxFruit.Location.X, picboxFruit.Location.Y)), picboxFruit) Then
                        FruitEaten()
                    End If
                Case "right"
                    If HitGoingRight(picPacMan, (New Point(picboxFruit.Location.X, picboxFruit.Location.Y)), picboxFruit) Then
                        FruitEaten()
                    End If
                Case "up"
                    If HitGoingUp(picPacMan, (New Point(picboxFruit.Location.X, picboxFruit.Location.Y)), picboxFruit) Then
                        FruitEaten()
                    End If
                Case "down"
                    If HitGoingDown(picPacMan, (New Point(picboxFruit.Location.X, picboxFruit.Location.Y)), picboxFruit) Then
                        FruitEaten()
                    End If
            End Select
        End If
    End Sub

    'Add score, 2 times higher for each level, add level amount to lifes
    Private Sub FruitEaten()
        picboxFruit.Visible = False
        picboxFruit.Location = New Point(295, 100)
        FruitDir = "dead"
        PacScore += (100 * (2 ^ (PacManLevel - 1)))
        lblScore.Text = "Score:" & PacScore
        PacLifes += 1
        lblLifes.Text = "Lifes:" & PacLifes
        If PacManLevel >= 10 Then
            picboxGhost1.Tag = "dead"
            picboxGhost2.Tag = "dead"
            picboxGhost3.Tag = "dead"
            picboxGhost4.Tag = "dead"
            picboxGhost5.Tag = "dead"
            SendGhostToStart(picboxGhost1)
            SendGhostToStart(picboxGhost2)
            SendGhostToStart(picboxGhost3)
            SendGhostToStart(picboxGhost4)
            SendGhostToStart(picboxGhost5)
        Else
            If MediaPlayer.URL <> MediaLocs(4) Then
                MediaPlayer.URL = MediaLocs(4)
                MediaPlayer.Ctlcontrols.play()
            Else
                MediaPlayer.Ctlcontrols.play()
            End If
        End If

    End Sub

    'Check for eat
    Private Sub CheckDotHit()
        Dim i, j As Integer
        Dim PlayerRect As New Rectangle(picPacMan.Location, picPacMan.Size)
        If DotCount > 0 And DotCords.Length > 0 Then
            For i = 0 To (DotCords.Length - 1)
                If i = DotCords.Length Then Exit For
                If Within(PlayerRect, DotCords(i)) Then
                    If DotCordsType(i) = "morph" Then
                        'Call morph code
                        MorphTimer.Enabled = True
                        PacScore += 5
                        lblScore.Text = "Score:" & PacScore
                    End If
                    'dot eaten, remove from dotcords array, lower dotcount
                    'image of dot should be removed by player image passing over
                    Dim topdots() As Point
                    Dim bottomdots() As Point
                    Dim toptype() As String
                    Dim bottomtype() As String
                    If i = 0 Then
                        ReDim topdots(DotCords.Length - 2)
                        ReDim toptype(DotCords.Length - 2)
                        DotCords.Copy(DotCords, 1, topdots, 0, DotCount - 1)
                        DotCordsType.Copy(DotCordsType, 1, toptype, 0, DotCount - 1)
                        ReDim DotCords(DotCount - 1)
                        ReDim DotCordsType(DotCount - 1)
                        DotCords = topdots
                        DotCordsType = toptype
                    ElseIf i = (DotCords.Length - 1) Then
                        ReDim Preserve DotCords(DotCount - 1)
                        ReDim Preserve DotCordsType(DotCount - 1)
                    Else
                        ReDim topdots(i)
                        ReDim toptype(i)
                        ReDim bottomdots(DotCords.Length - topdots.Length - 1)
                        ReDim bottomtype(DotCords.Length - topdots.Length - 1)
                        DotCords.Copy(DotCords, 0, topdots, 0, i)
                        DotCordsType.Copy(DotCordsType, 0, toptype, 0, i)
                        DotCords.Copy(DotCords, i + 1, bottomdots, 0, (DotCords.Length - topdots.Length - 1))
                        DotCordsType.Copy(DotCordsType, i + 1, bottomtype, 0, (DotCords.Length - topdots.Length - 1))
                        ReDim DotCords(DotCount - 1)
                        ReDim DotCordsType(DotCount - 1)
                        topdots.Copy(topdots, 0, DotCords, 0, topdots.Length)
                        toptype.Copy(toptype, 0, DotCordsType, 0, topdots.Length)
                        bottomdots.Copy(bottomdots, 0, DotCords, (topdots.Length - 1), bottomdots.Length)
                        bottomtype.Copy(bottomtype, 0, DotCordsType, (topdots.Length - 1), bottomdots.Length)
                    End If
                    DotCount -= 1
                    PacScore += 1
                    lblScore.Text = "Score:" & PacScore
                    If MediaPlayer.URL <> MediaLocs(0) Then
                        MediaPlayer.URL = MediaLocs(0)
                    Else
                        MediaPlayer.Ctlcontrols.play()
                    End If
                End If
            Next i
        End If
    End Sub

    Private Function Within(ByVal CordA As Rectangle, ByVal CordB As Point) As Boolean
        Dim ax, ay, aw, ah As Integer 'Dimensions
        Dim bx, by, bw, bh As Integer
        'Assign dimensions
        ax = CordA.Left
        ay = CordA.Top
        aw = ax + CordA.Width
        ah = ay + CordA.Height

        'Dot dimensions
        bx = CordB.X
        by = CordB.Y
        bw = bx + 4
        bh = by + 4

        'Check if dot intersects rectangle
        Within = False
        If ax <= bx And aw >= bw And ay <= by And ah >= bh Then Return True
    End Function

    'Determines direction and dimensions of player, and then teleports or checks if wall hit
    'Target is the picture to check, Direction is targets move dirction, Wallbuffer is a 
    'string to return the side the target encountered a wall
    'Returns true if no hit
    Public Function CheckWall(ByRef Target As PictureBox, ByVal Direction As String, ByRef WallBuffer As String, ByVal TargetSpeed As Integer) As Boolean
        Dim x, y, h, k As Integer
        Dim wallhit As String
        Dim pyr As PictureBox = Target
        x = Target.Location.X
        y = Target.Location.Y
        h = x + Target.Width
        k = y + Target.Height
        If Direction = "left" Then x = x - TargetSpeed
        If Direction = "right" Then h = h + TargetSpeed
        If Direction = "up" Then y = y - TargetSpeed
        If Direction = "down" Then k = k + TargetSpeed
        CheckWall = True
        wallhit = CheckHitWalls(x, y, h, k, Direction)
        WallBuffer = wallhit
        If WallBuffer <> "true" Then
            'If wallhit = "right" Then pyr.Location = New Point(pyr.Location.X - 1, pyr.Location.Y)
            'If wallhit = "left" Then pyr.Location = New Point(pyr.Location.X + 1, pyr.Location.Y)
            'If wallhit = "bottom" Then pyr.Location = New Point(pyr.Location.X, pyr.Location.Y - 1)
            'If wallhit = "top" Then pyr.Location = New Point(pyr.Location.X, pyr.Location.Y + 1)
            Return False
        End If
        '135,285 teleport
        If x < 5 Or h > 405 Then 'teleport
            If x < 5 And ((y >= 135 And y <= 145) Or (y >= 285 And y <= 295)) Then
                Target.Location = New Point(380, Target.Location.Y)
            ElseIf h > 405 And ((y >= 135 And y <= 145) Or (y >= 285 And y <= 295)) Then
                Target.Location = New Point(4, Target.Location.Y)
            Else
                'Out of bounds
                If x < 5 Then
                    Target.Location = New Point(5, y)
                    WallBuffer = "left"
                    Return False
                End If
                If h > 405 Then
                    Target.Location = New Point(x - (h - 405), y)
                    WallBuffer = "right"
                    Return False
                End If
            End If
        End If
        If y < 0 Or k > 380 Then
            'out of bounds
            If y < 0 Then
                Target.Location = New Point(x, 0)
                WallBuffer = "top"
                Return False
            End If

            If k > 380 Then
                Target.Location = New Point(x, y - (k - 380))
                WallBuffer = "bottom"
                Return False
            End If
        End If
    End Function

    'Cycles through every image tagged "Wall" and checks for hit, returns true or side of hit
    Private Function CheckHitWalls(ByVal px As Integer, ByVal py As Integer, ByVal pwx As Integer, ByVal phy As Integer, ByVal Direction As String) As String
        Dim picbox As PictureBox
        Dim curpic As PictureBox
        Dim PicTag As String
        Dim lastname As String
        Dim i As Integer
        Dim mytype As System.Type
        Dim x, y, wx, hy As Integer
        'top - y, left - x, right - wx, down - hy
        CheckHitWalls = "true"
        Try
            For i = 0 To (Me.Controls.Count - 1)
                mytype = Me.Controls(i).GetType()
                If mytype.Name.ToLower = "picturebox" Then
                    curpic = Me.Controls(i)
                    PicTag = curpic.Tag
                    lastname = curpic.Name
                    If (PicTag = "Wall") Then
                        x = curpic.Location.X
                        y = curpic.Location.Y
                        wx = x + curpic.Width
                        hy = y + curpic.Height
                        If Direction = "left" And px <= wx And wx <= pwx And ((py <= hy And py >= y) Or (py <= y And phy >= y) Or (py <= hy And phy >= hy) Or (py >= y And phy <= hy)) Then Return "left" ' hit left side
                        If Direction = "up" And py <= hy And hy <= phy And ((px >= x And px <= wx) Or (px <= x And pwx >= x) Or (px <= x And pwx >= wx) Or (px >= x And pwx <= wx)) Then Return "top" ' hit top side
                        If Direction = "right" And pwx >= x And x >= px And ((py <= hy And py >= y) Or (py <= y And phy >= y) Or (py <= hy And phy >= hy) Or (py >= y And phy <= hy)) Then Return "right" ' hit right side
                        If Direction = "down" And phy >= y And y >= py And ((px >= x And px <= wx) Or (px <= x And pwx >= x) Or (px <= x And pwx >= wx) Or (px >= x And pwx <= wx)) Then Return "bottom" ' hit bottom side
                    End If
                End If
            Next i
1:
            Return "true"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Checks for paths (red lines)
    'Returns Returns directiontraveling-sidesopen-x coord of path-y coord of path  ' hit left side
    Private Function CheckPaths(ByRef Target As PictureBox, ByVal Coord As Point, ByVal Direction As String) As String
        Dim mytype As System.Type
        Dim i As Integer
        Dim curpic As PictureBox
        Dim lastname As String
        Dim PicTag, PathTag(2) As String
        Dim NewLocX, NewLocY As Integer
        CheckPaths = "true"
        Try
            For i = 0 To (Me.Controls.Count - 1)
                mytype = Me.Controls(i).GetType()
                If mytype.Name.ToLower = "picturebox" Then
                    curpic = Me.Controls(i)
                    lastname = curpic.Name
                    PicTag = curpic.Tag
                    If PicTag <> Nothing Then
                        If (PicTag.ToLower.StartsWith("path")) Then
                            PathTag = PicTag.Split("-")
                            If PathTag(1).ToLower = Direction.ToLower Then

                                If Direction = "left" And HitGoingLeft(curpic, Coord, Target) Then
                                    NewLocX = curpic.Location.X + curpic.Width + 1
                                    NewLocY = curpic.Location.Y + 1
                                    Return "left-" & PathTag(2) & "-" & NewLocX & "-" & NewLocY  ' hit left side
                                End If
                                If Direction = "right" And HitGoingRight(curpic, Coord, Target) Then
                                    NewLocX = curpic.Location.X - Target.Width - 1
                                    NewLocY = curpic.Location.Y + 1
                                    Return "right-" & PathTag(2) & "-" & NewLocX & "-" & NewLocY ' hit right side
                                End If
                                If Direction = "up" And HitGoingUp(curpic, Coord, Target) Then
                                    NewLocY = curpic.Location.Y + curpic.Height + 1
                                    NewLocX = curpic.Location.X + 1
                                    Return "top-" & PathTag(2) & "-" & NewLocX & "-" & NewLocY  ' hit top side
                                End If
                                If Direction = "down" And HitGoingDown(curpic, Coord, Target) Then
                                    NewLocY = curpic.Location.Y - Target.Height - 1
                                    NewLocX = curpic.Location.X + 1
                                    Return "bottom-" & PathTag(2) & "-" & NewLocX & "-" & NewLocY  ' hit bottom side
                                End If
                            End If
                        End If
                    End If
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return "true"
    End Function

#Region "CheckCollision"
    Private Function HitGoingLeft(ByRef CurrentTarget As PictureBox, ByVal CheckCoord As Point, ByRef CheckTarget As PictureBox) As Boolean
        Dim x, y, wx, hy As Integer
        Dim px, py, pwx, phy As Integer
        px = CheckCoord.X
        py = CheckCoord.Y
        pwx = px + CheckTarget.Width
        phy = py + CheckTarget.Height
        x = CurrentTarget.Location.X
        y = CurrentTarget.Location.Y
        wx = x + CurrentTarget.Width
        hy = y + CurrentTarget.Height
        HitGoingLeft = False
        If px <= wx And wx <= pwx And ((py <= hy And py >= y) Or (py <= y And phy >= y) Or (py <= hy And phy >= hy) Or (py >= y And phy <= hy)) Then Return True
    End Function

    Private Function HitGoingRight(ByRef CurrentTarget As PictureBox, ByVal CheckCoord As Point, ByRef CheckTarget As PictureBox) As Boolean
        Dim x, y, wx, hy As Integer
        Dim px, py, pwx, phy As Integer
        px = CheckCoord.X
        py = CheckCoord.Y
        pwx = px + CheckTarget.Width
        phy = py + CheckTarget.Height
        x = CurrentTarget.Location.X
        y = CurrentTarget.Location.Y
        wx = x + CurrentTarget.Width
        hy = y + CurrentTarget.Height
        HitGoingRight = False
        If pwx >= x And x >= px And ((py <= hy And py >= y) Or (py <= y And phy >= y) Or (py <= hy And phy >= hy) Or (py >= y And phy <= hy)) Then Return True
    End Function

    Private Function HitGoingUp(ByRef CurrentTarget As PictureBox, ByVal CheckCoord As Point, ByRef CheckTarget As PictureBox) As Boolean
        Dim x, y, wx, hy As Integer
        Dim px, py, pwx, phy As Integer
        px = CheckCoord.X
        py = CheckCoord.Y
        pwx = px + CheckTarget.Width
        phy = py + CheckTarget.Height
        x = CurrentTarget.Location.X
        y = CurrentTarget.Location.Y
        wx = x + CurrentTarget.Width
        hy = y + CurrentTarget.Height
        HitGoingUp = False
        If py <= hy And hy <= phy And ((px >= x And px <= wx) Or (px <= x And pwx >= x) Or (px <= x And pwx >= wx) Or (px >= x And pwx <= wx)) Then Return True
    End Function

    Private Function HitGoingDown(ByRef CurrentTarget As PictureBox, ByVal CheckCoord As Point, ByRef CheckTarget As PictureBox) As Boolean
        Dim x, y, wx, hy As Integer
        Dim px, py, pwx, phy As Integer
        px = CheckCoord.X
        py = CheckCoord.Y
        pwx = px + CheckTarget.Width
        phy = py + CheckTarget.Height
        x = CurrentTarget.Location.X
        y = CurrentTarget.Location.Y
        wx = x + CurrentTarget.Width
        hy = y + CurrentTarget.Height
        If phy >= y And y >= py And ((px >= x And px <= wx) Or (px <= x And pwx >= x) Or (px <= x And pwx >= wx) Or (px >= x And pwx <= wx)) Then Return True
    End Function
#End Region

    'Changes the image of the player according to stage and direction
    Private Sub ChangePic()
        If movestage > 0 Then
            movestage -= 1
        Else
            movestage = 10
            If picPacMan.Tag = "1" Then
                If MoveDir = "left" Then
                    picPacMan.Image = Me.picPacLeft2.Image
                ElseIf MoveDir = "right" Then
                    picPacMan.Image = Me.picPacRight2.Image
                ElseIf MoveDir = "up" Then
                    picPacMan.Image = Me.picPacUp2.Image
                ElseIf MoveDir = "down" Then
                    picPacMan.Image = Me.picPacDown2.Image
                End If
                picPacMan.Tag = "2"
            Else
                If MoveDir = "left" Then
                    picPacMan.Image = Me.PicPacLeft1.Image
                ElseIf MoveDir = "right" Then
                    picPacMan.Image = Me.picPacRight1.Image
                ElseIf MoveDir = "up" Then
                    picPacMan.Image = Me.picPacUp1.Image
                ElseIf MoveDir = "down" Then
                    picPacMan.Image = Me.picPacDown1.Image
                End If
                picPacMan.Tag = "1"
            End If
        End If
    End Sub

    'Draws remaining dots
    Private Sub DrawTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawTimer.Tick
        DrawDots()
    End Sub

    Public Sub MoveGhost(ByRef GhostPic As PictureBox)
        Dim i As Integer
        Dim curcord As Point
        Dim WallBuf1, WallBuf2(3) As String
        Dim changing, changing2 As Boolean
        Dim MoveSpeed As Integer

        MoveSpeed = GhostSpeed
        i = FindGhost(GhostPic)

        If i = FastGhost And PacManLevel >= 2 And QuickGhost = True Then MoveSpeed *= 2

        curcord = GhostPic.Location
        Select Case Ghostdir(i - 1)
            Case "up"
                curcord.Y = curcord.Y - MoveSpeed
            Case "down"
                curcord.Y = curcord.Y + MoveSpeed
            Case "left"
                curcord.X = curcord.X - MoveSpeed
            Case "right"
                curcord.X = curcord.X + MoveSpeed
            Case "dead"
                curcord.Y = curcord.Y - MoveSpeed
                If picboxGate.Visible Then
                    picboxGate.Visible = False
                End If
                If ReleaseOneGhost(GhostPic) Then
                    Ghostdir(i - 1) = "up"
                End If
        End Select
        If CheckWall(GhostPic, Ghostdir(i - 1), WallBuf1, GhostSpeed) Then
            'no walls check for paths
            changing = False
            changing2 = False
            WallBuf1 = CheckPaths(GhostPic, curcord, Ghostdir(i - 1))
            If WallBuf1 = "true" Then
                'no walls or paths, continue
                GhostPic.Location = curcord
            Else
                WallBuf1 = WallBuf1.ToLower
                WallBuf2 = WallBuf1.Split("-")
                'path wall hit
                With picPacMan
                    Select Case WallBuf2(0)
                        'Format path walls - Path-"direction hit"-"directions open"
                    Case "top"
                            If WallBuf2(1) = "left" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.X + 30 <= curcord.X Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "left"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                End If
                            End If
                            If WallBuf2(1) = "right" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.X - 30 >= curcord.X Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "right"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                Else
                                    If changing = False Then
                                        GhostPic.Location = curcord
                                    End If
                                End If
                            Else
                                If changing = False Then
                                    GhostPic.Location = curcord
                                End If
                            End If
                        Case "bottom"
                            If WallBuf2(1) = "left" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.X + 30 <= curcord.X Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "left"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                End If
                            End If
                            If WallBuf2(1) = "right" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.X - 30 >= curcord.X Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "right"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                Else
                                    If changing = False Then
                                        GhostPic.Location = curcord

                                    End If
                                End If
                            Else
                                If changing = False Then
                                    GhostPic.Location = curcord
                                End If
                            End If

                        Case "left"
                            If WallBuf2(1) = "up" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.Y + 30 <= curcord.Y Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "up"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                End If
                            ElseIf WallBuf2(1) = "flip" Then
                                Ghostdir(i - 1) = "right"
                                changing = True
                            ElseIf WallBuf2(1) = "flipdown" Then
                                Ghostdir(i - 1) = "down"
                                changing = True
                            End If
                            If WallBuf2(1) = "down" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.Y - 30 >= curcord.Y Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "down"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                Else
                                    If changing = False Then
                                        GhostPic.Location = curcord
                                    End If
                                End If
                            Else
                                If changing = False Then
                                    GhostPic.Location = curcord
                                End If
                            End If
                        Case "right"
                            If WallBuf2(1) = "up" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.Y + 30 <= curcord.Y Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "up"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                End If
                            ElseIf WallBuf2(1) = "flip" Then
                                Ghostdir(i - 1) = "left"
                                changing = True
                            End If
                            If WallBuf2(1) = "down" Or WallBuf2(1) = "both" Then
                                If picPacMan.Location.Y - 30 >= curcord.Y Then
                                    If GhostChangeBuf(i - 1) = False Then
                                        Ghostdir(i - 1) = "down"
                                        If WallBuf2(1) = "both" Then CheckReverse(i)
                                        changing = True
                                        GhostChangeBuf(i - 1) = True
                                    Else
                                        If GhostChangeCount(i - 1) >= 30 Then
                                            GhostChangeBuf(i - 1) = False
                                            GhostChangeCount(i - 1) = 0
                                        Else
                                            GhostPic.Location = curcord
                                        End If
                                    End If
                                Else
                                    If changing = False Then
                                        GhostPic.Location = curcord
                                    End If
                                End If
                            Else
                                If changing = False Then
                                    GhostPic.Location = curcord
                                End If
                            End If
                    End Select
                    If changing = True Then
                        GhostPic.Location = New Point(WallBuf2(2), WallBuf2(3))
                    Else
                        If GhostChangeBuf(i - 1) = True Then
                            GhostChangeCount(i - 1) += GhostSpeed
                        End If
                    End If
                End With
            End If
        Else
            'Wall hit, change direction
            Select Case WallBuf1
                Case "top"
                    If picPacMan.Location.X <= GhostPic.Location.X And GhostPic.Location.X <> 5 Then
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "left"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            Else
                                If picPacMan.Location.X <= GhostPic.Location.X Then
                                    If GhostChangeBuf(i - 1) Then
                                        GhostChangeBuf(i - 1) = False
                                        GhostChangeCount(i - 1) = 0
                                    End If
                                    Ghostdir(i - 1) = "right"
                                    CheckReverse(i)
                                    GCBufWall(i - 1) = False
                                End If
                            End If
                        End If
                    Else
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "right"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            Else
                                If picPacMan.Location.X >= GhostPic.Location.X Then
                                    If GhostChangeBuf(i - 1) Then
                                        GhostChangeBuf(i - 1) = False
                                        GhostChangeCount(i - 1) = 0
                                    End If
                                    Ghostdir(i - 1) = "left"
                                    CheckReverse(i)
                                    GCBufWall(i - 1) = False
                                End If
                            End If
                        End If
                    End If
                Case "bottom"
                    If picPacMan.Location.X <= GhostPic.Location.X And GhostPic.Location.X <> 5 Then
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "left"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            Else
                                If picPacMan.Location.X <= GhostPic.Location.X Then
                                    If GhostChangeBuf(i - 1) Then
                                        GhostChangeBuf(i - 1) = False
                                        GhostChangeCount(i - 1) = 0
                                    End If
                                    Ghostdir(i - 1) = "right"
                                    CheckReverse(i)
                                    GCBufWall(i - 1) = False
                                End If
                            End If
                        End If
                    Else
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "right"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            Else
                                If picPacMan.Location.X >= GhostPic.Location.X Then
                                    If GhostChangeBuf(i - 1) Then
                                        GhostChangeBuf(i - 1) = False
                                        GhostChangeCount(i - 1) = 0
                                    End If
                                    Ghostdir(i - 1) = "left"
                                    CheckReverse(i)
                                    GCBufWall(i - 1) = False
                                End If
                            End If
                        End If
                    End If

                Case "left"
                    If picPacMan.Location.Y <= GhostPic.Location.Y And GhostPic.Location.Y <> 0 Then
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "up"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            End If
                        End If
                    Else
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "down"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            End If
                        End If
                    End If
                Case "right"
                    If picPacMan.Location.Y <= GhostPic.Location.Y And GhostPic.Location.Y <> 0 Then
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "up"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            End If
                        End If
                    Else
                        If GCBufWall(i - 1) = False Then
                            If GhostChangeBuf(i - 1) Then
                                GhostChangeBuf(i - 1) = False
                                GhostChangeCount(i - 1) = 0
                            End If
                            Ghostdir(i - 1) = "down"
                            CheckReverse(i)
                            GCBufWall(i - 1) = True
                        Else
                            If GCCountWall(i - 1) >= 5 Then
                                GCBufWall(i - 1) = False
                                GCCountWall(i - 1) = 0
                            End If
                        End If
                    End If
            End Select
        End If
        If GCBufWall(i - 1) = True Then
            GCCountWall(i - 1) += GhostSpeed
        End If

        'Find out if ghosts caught pacman
        Select Case Ghostdir(i - 1)
            Case "left"
                If HitGoingLeft(picPacMan, (New Point(GhostPic.Location.X, GhostPic.Location.Y)), GhostPic) Then
                    If MorphReverse = False Then
                        If Ghostdir(i - 1) = "dead" Then Exit Select
                        PacSpeed = 0
                        CreateGameOver()
                    Else
                        Ghostdir(i - 1) = "dead"
                        SendGhostToStart(GhostPic)
                        PacScore += (100 * (2 ^ (GhostsEaten - 1)))
                        lblScore.Text = "Score:" & PacScore
                    End If
                End If
            Case "right"
                If HitGoingRight(picPacMan, (New Point(GhostPic.Location.X, GhostPic.Location.Y)), GhostPic) Then
                    If MorphReverse = False Then
                        If Ghostdir(i - 1) = "dead" Then Exit Select
                        PacSpeed = 0
                        CreateGameOver()
                    Else
                        Ghostdir(i - 1) = "dead"
                        SendGhostToStart(GhostPic)
                        PacScore += (100 * (2 ^ (GhostsEaten - 1)))
                        lblScore.Text = "Score:" & PacScore
                    End If
                End If
            Case "up"
                If HitGoingUp(picPacMan, (New Point(GhostPic.Location.X, GhostPic.Location.Y)), GhostPic) Then
                    If MorphReverse = False Then
                        If Ghostdir(i - 1) = "dead" Then Exit Select
                        PacSpeed = 0
                        CreateGameOver()
                    Else
                        Ghostdir(i - 1) = "dead"
                        SendGhostToStart(GhostPic)
                        PacScore += (100 * (2 ^ (GhostsEaten - 1)))
                        lblScore.Text = "Score:" & PacScore
                    End If
                End If
            Case "down"
                If HitGoingDown(picPacMan, (New Point(GhostPic.Location.X, GhostPic.Location.Y)), GhostPic) Then
                    If MorphReverse = False Then
                        If Ghostdir(i - 1) = "dead" Then Exit Select
                        PacSpeed = 0
                        CreateGameOver()
                    Else
                        Ghostdir(i - 1) = "dead"
                        SendGhostToStart(GhostPic)
                        PacScore += (100 * (2 ^ (GhostsEaten - 1)))
                        lblScore.Text = "Score:" & PacScore
                    End If
                End If
        End Select
    End Sub

    Private Sub SendGhostToStart(ByRef GhostPic As PictureBox)
        GhostsEaten += 1
        If MediaPlayer.URL = MediaLocs(4) Then
            MediaPlayer.Ctlcontrols.play()
        Else
            MediaPlayer.URL = MediaLocs(4)
        End If
        Select Case FindGhost(GhostPic)
            Case 1
                picboxGhost1.Location = New Point(290, 140)
            Case 2
                picboxGhost2.Location = New Point(275, 170)
            Case 3
                picboxGhost3.Location = New Point(305, 170)
            Case 4
                picboxGhost4.Location = New Point(275, 205)
            Case 5
                picboxGhost5.Location = New Point(305, 205)
        End Select
    End Sub

    Private Sub CreateGameOver()
        GameOver = True
        GhostSpeed = 0
        movestage = 0
        PacSpin = True
        MediaPlayer.URL = MediaLocs(1)
    End Sub

    Private Sub CheckReverse(ByVal GhostNum As Integer)
        If MorphReverse Then
            Select Case Ghostdir(GhostNum - 1)
                Case "up"
                    Ghostdir(GhostNum - 1) = "down"
                Case "down"
                    Ghostdir(GhostNum - 1) = "up"
                Case "left"
                    Ghostdir(GhostNum - 1) = "right"
                Case "right"
                    Ghostdir(GhostNum - 1) = "left"
            End Select
        End If
    End Sub

    Public Function FindGhost(ByRef GhostPic As PictureBox) As Integer
        Dim gname As String
        gname = GhostPic.Name
        Return Integer.Parse(gname.Substring(gname.Length - 1))
    End Function

    Private Sub GateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GateTimer.Tick
        Static Released As Integer
        Static TimeCount As Integer
        Dim i As Integer
        Static Opening As Boolean = False
        Static Waiting As Boolean
        Dim GhostBox As PictureBox
        If GameOn = False Then
            Released = 0
            TimeCount = 0
            i = 0
            Opening = False
            Waiting = False
            GameOn = True
        End If
        If MorphReverse = False Then
            If Opening = False Then
                TimeCount += 1
                If TimeCount >= 100 Then
                    Opening = True
                    TimeCount = 0
                End If
                Exit Sub
            End If
            If Waiting = False Then
                Waiting = True
                picboxGate.Visible = False
                picboxGate.Tag = "Wait"
                Ghostdir(Released) = "up"
            End If
            If Waiting = True Or picboxGate.Tag = "Wait" Then
                GhostBox = FindGhostPic(Released + 1)
                If GhostBox.Location.Y < 105 Then
                    Waiting = False
                    Opening = False
                    picboxGate.Visible = True
                    picboxGate.Tag = "Wall"
                    Released += 1
                    If Released = 5 Then
                        GateTimer.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Function ReleaseOneGhost(ByRef GhostPic As PictureBox) As Boolean
        Dim i As Integer = FindGhost(GhostPic)
        If Ghostdir(i - 1) <> "dead" Then
            Ghostdir(i - 1) = "dead"
            picboxGate.Visible = False
            picboxGate.Tag = "Wait"
            Return False
        Else
            If GhostPic.Location.Y <= 105 Then
                picboxGate.Visible = True
                picboxGate.Tag = "Wall"
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Function FindGhostPic(ByVal Number As Integer) As PictureBox
        Select Case Number
            Case 1
                Return Me.picboxGhost1
            Case 2
                Return Me.picboxGhost2
            Case 3
                Return Me.picboxGhost3
            Case 4
                Return Me.picboxGhost4
            Case 5
                Return Me.picboxGhost5
        End Select
    End Function

    Private Sub MorphTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MorphTimer.Tick
        Dim i As Integer
        Dim CurGhost As PictureBox
        If MorphTimer.Interval = 1 And GhostSpeed > 0 Then
            If MusicPlayer.URL = MediaLocs(3) Then
                If MusicPlayer.Ctlcontrols.currentPosition <= 0 Then MusicPlayer.Ctlcontrols.play()
                If MusicPlayer.Ctlcontrols.currentPosition > 0 Then
                    MorphTimer.Interval = 5000
                    GhostsEaten = 0
                    PacSpeed = StartPacSpeed * 2
                    MorphReverse = True
                    ReverseGhosts()
                    picboxGhost1.Image = picScaredGhost.Image
                    picboxGhost2.Image = picScaredGhost.Image
                    picboxGhost3.Image = picScaredGhost.Image
                    picboxGhost4.Image = picScaredGhost.Image
                    picboxGhost5.Image = picScaredGhost.Image
                End If
            Else
                MusicPlayer.URL = MediaLocs(3)
            End If
        Else
            'Morph over
            GhostsEaten = 0
            PacSpeed = StartPacSpeed
            MorphTimer.Interval = 1
            MorphReverse = False
            MorphTimer.Enabled = False
            picboxGhost1.Image = picGhost1.Image
            picboxGhost2.Image = picGhost2.Image
            picboxGhost3.Image = picGhost3.Image
            picboxGhost4.Image = picGhost4.Image
            picboxGhost5.Image = PicGhost5.Image
            'If any ghosts were trapped by gate then free them
            For i = 0 To 4
                CurGhost = FindGhostPic(i + 1)
                If CurGhost.Location.X >= 270 And CurGhost.Location.X <= 370 Then
                    If CurGhost.Location.Y > 105 And CurGhost.Location.Y < 240 Then
                        CurGhost.Location = New Point(CurGhost.Location.X, 206)
                    End If
                End If
            Next i
        End If
    End Sub

    Private Sub ReverseGhosts()
        Dim i As Integer
        Dim CurGhost As PictureBox
        For i = 0 To 4
            CurGhost = FindGhostPic(i + 1)
            With CurGhost.Location
                If .X >= 275 And .X <= 315 Then
                    If .Y >= 130 And .Y <= 215 Then
                        GoTo 2
                    End If
                End If
            End With
            Select Case Ghostdir(i)
                Case "left"
                    Ghostdir(i) = "right"
                Case "right"
                    Ghostdir(i) = "left"
                Case "up"
                    Ghostdir(i) = "down"
                Case "down"
                    Ghostdir(i) = "up"
            End Select
2:
        Next i
    End Sub
End Class