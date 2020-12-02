<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RightWall = New System.Windows.Forms.PictureBox()
        Me.LeftWall = New System.Windows.Forms.PictureBox()
        Me.BottomWall = New System.Windows.Forms.PictureBox()
        Me.Topwall = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Topwall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(585, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp5.My.Resources.Resources.download__2_
        Me.PictureBox2.Location = New System.Drawing.Point(222, 81)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 149)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RightWall
        '
        Me.RightWall.BackColor = System.Drawing.Color.Red
        Me.RightWall.Location = New System.Drawing.Point(1166, 12)
        Me.RightWall.Name = "RightWall"
        Me.RightWall.Size = New System.Drawing.Size(18, 540)
        Me.RightWall.TabIndex = 2
        Me.RightWall.TabStop = False
        '
        'LeftWall
        '
        Me.LeftWall.BackColor = System.Drawing.Color.Red
        Me.LeftWall.Location = New System.Drawing.Point(12, 12)
        Me.LeftWall.Name = "LeftWall"
        Me.LeftWall.Size = New System.Drawing.Size(18, 540)
        Me.LeftWall.TabIndex = 3
        Me.LeftWall.TabStop = False
        '
        'BottomWall
        '
        Me.BottomWall.BackColor = System.Drawing.Color.Red
        Me.BottomWall.Location = New System.Drawing.Point(28, 533)
        Me.BottomWall.Name = "BottomWall"
        Me.BottomWall.Size = New System.Drawing.Size(1140, 18)
        Me.BottomWall.TabIndex = 4
        Me.BottomWall.TabStop = False
        '
        'Topwall
        '
        Me.Topwall.BackColor = System.Drawing.Color.Red
        Me.Topwall.Location = New System.Drawing.Point(28, 12)
        Me.Topwall.Name = "Topwall"
        Me.Topwall.Size = New System.Drawing.Size(1140, 18)
        Me.Topwall.TabIndex = 5
        Me.Topwall.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 564)
        Me.Controls.Add(Me.Topwall)
        Me.Controls.Add(Me.BottomWall)
        Me.Controls.Add(Me.LeftWall)
        Me.Controls.Add(Me.RightWall)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Topwall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RightWall As PictureBox
    Friend WithEvents LeftWall As PictureBox
    Friend WithEvents BottomWall As PictureBox
    Friend WithEvents Topwall As PictureBox
End Class
