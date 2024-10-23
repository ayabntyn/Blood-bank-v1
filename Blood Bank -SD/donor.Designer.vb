<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class donor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(donor))
        Panel4 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        PictureBox4 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Maroon
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(1, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(787, 57)
        Panel4.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Monotype Corsiva", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(56, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 14)
        Label1.TabIndex = 13
        Label1.Text = "Always First, Always Ready, Always There"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 31)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(56, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 17)
        Label2.TabIndex = 11
        Label2.Text = "Red Cross Philippines"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MistyRose
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Button4)
        Panel1.Location = New Point(1, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(146, 412)
        Panel1.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(11, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 42)
        Button2.TabIndex = 13
        Button2.Text = "Profile"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(20, 368)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(23, 32)
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderColor = Color.LightGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold)
        Button4.ImageAlign = ContentAlignment.TopLeft
        Button4.Location = New Point(46, 363)
        Button4.Name = "Button4"
        Button4.Size = New Size(66, 32)
        Button4.TabIndex = 4
        Button4.Text = "Log Out"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(22, 149)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 26)
        Button3.TabIndex = 1
        Button3.Text = "Upload Picture"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RosyBrown
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(148, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(639, 574)
        Panel2.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = SystemColors.HighlightText
        Panel3.Controls.Add(GroupBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Button3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(639, 574)
        Panel3.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(22, 187)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(591, 177)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(146, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 21)
        Label3.TabIndex = 3
        Label3.Text = "DONOR NAME"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(22, 27)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(118, 116)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Variable Text Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(11, 54)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 42)
        Button1.TabIndex = 21
        Button1.Text = "       Appointments"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' donor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "donor"
        Text = "donor"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
