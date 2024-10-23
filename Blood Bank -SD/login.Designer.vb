<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Panel3 = New Panel()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel4 = New Panel()
        login1 = New Panel()
        register1 = New Panel()
        Panel6 = New Panel()
        Label12 = New Label()
        Label32 = New Label()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        TextBox7 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox3 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        GroupBox2 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        login1.SuspendLayout()
        register1.SuspendLayout()
        Panel6.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(18, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 17)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(17, 44)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(285, 30)
        TextBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(15, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 17)
        Label2.TabIndex = 4
        Label2.Text = "Email"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(19, 110)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(283, 30)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.FlatAppearance.BorderColor = Color.Gray
        Button1.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(206, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 31)
        Button1.TabIndex = 9
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Variable Display", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(19, 162)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(117, 19)
        CheckBox1.TabIndex = 8
        CheckBox1.Text = "Forgot Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonShadow
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(120, 79)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(318, 205)
        Panel3.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(120, 302)
        Button2.Name = "Button2"
        Button2.Size = New Size(318, 30)
        Button2.TabIndex = 12
        Button2.Text = "REGISTER NEW ACCOUNT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(22, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 31)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(64, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 17)
        Label1.TabIndex = 6
        Label1.Text = "Red Cross Philippines"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Maroon
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(535, 36)
        Panel4.TabIndex = 14
        ' 
        ' login1
        ' 
        login1.Controls.Add(Panel4)
        login1.Controls.Add(Button2)
        login1.Controls.Add(Panel3)
        login1.Dock = DockStyle.Fill
        login1.Location = New Point(0, 0)
        login1.Name = "login1"
        login1.Size = New Size(537, 369)
        login1.TabIndex = 15
        ' 
        ' register1
        ' 
        register1.AutoScroll = True
        register1.BackColor = Color.LightGray
        register1.Controls.Add(Panel6)
        register1.Controls.Add(Button3)
        register1.Controls.Add(GroupBox1)
        register1.Controls.Add(Label10)
        register1.Controls.Add(Label9)
        register1.Controls.Add(Label6)
        register1.Controls.Add(Label8)
        register1.Controls.Add(Label7)
        register1.Controls.Add(Panel5)
        register1.Controls.Add(PictureBox3)
        register1.Dock = DockStyle.Fill
        register1.Location = New Point(0, 0)
        register1.Name = "register1"
        register1.Size = New Size(537, 369)
        register1.TabIndex = 16
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Gray
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(Label32)
        Panel6.Location = New Point(3, 880)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(522, 36)
        Panel6.TabIndex = 39
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Maroon
        Label12.Location = New Point(263, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(122, 16)
        Label12.TabIndex = 42
        Label12.Text = "Philippine Red Cross"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = Color.Black
        Label32.Location = New Point(165, 10)
        Label32.Name = "Label32"
        Label32.Size = New Size(95, 16)
        Label32.TabIndex = 41
        Label32.Text = "Copyright 2024"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Maroon
        Button3.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(223, 808)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 40)
        Button3.TabIndex = 38
        Button3.Text = "Sign Up"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Font = New Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(51, 470)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(420, 321)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "SIGN UP TO DONATE"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = SystemColors.Menu
        TextBox7.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(20, 264)
        TextBox7.Multiline = True
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(376, 35)
        TextBox7.TabIndex = 37
        TextBox7.Text = "Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Menu
        TextBox3.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(20, 222)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(376, 35)
        TextBox3.TabIndex = 35
        TextBox3.Text = "Mobile Number or Email"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Menu
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Font = New Font("Segoe UI Variable Display Semil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(20, 89)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(376, 58)
        GroupBox3.TabIndex = 34
        GroupBox3.TabStop = False
        GroupBox3.Text = "Birthday"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = SystemColors.Menu
        DateTimePicker1.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(6, 24)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(359, 25)
        DateTimePicker1.TabIndex = 28
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Menu
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Font = New Font("Segoe UI Variable Display Semil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(20, 155)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(376, 58)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gender"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.FlatAppearance.BorderSize = 3
        RadioButton1.Font = New Font("Segoe UI Variable Display Semil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(31, 25)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(66, 21)
        RadioButton1.TabIndex = 30
        RadioButton1.TabStop = True
        RadioButton1.Text = "Female"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI Variable Display Semil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(258, 25)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(70, 21)
        RadioButton3.TabIndex = 32
        RadioButton3.TabStop = True
        RadioButton3.Text = "Custom"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI Variable Display Semil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(158, 25)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(53, 21)
        RadioButton2.TabIndex = 31
        RadioButton2.TabStop = True
        RadioButton2.Text = "Male"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.Menu
        TextBox5.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(23, 46)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(185, 35)
        TextBox5.TabIndex = 26
        TextBox5.Text = "First Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Menu
        TextBox4.Font = New Font("Segoe UI Variable Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(214, 46)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(185, 35)
        TextBox4.TabIndex = 25
        TextBox4.Text = "Last Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(102, 291)
        Label10.Name = "Label10"
        Label10.Size = New Size(369, 150)
        Label10.TabIndex = 23
        Label10.Text = resources.GetString("Label10.Text")
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(83, 269)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 15)
        Label9.TabIndex = 22
        Label9.Text = "You can't donate if you:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(102, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(281, 45)
        Label6.TabIndex = 21
        Label6.Text = "- be in good general health" & vbCrLf & "- be aged between 17 and 65 (you can register at 16)" & vbCrLf & "- weigh at least 7 stone 12 lbs (50kg)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(83, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(246, 15)
        Label8.TabIndex = 20
        Label8.Text = "To donate blood or plasma you will need to:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(54, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(335, 15)
        Label7.TabIndex = 19
        Label7.Text = "Check if you are eligible to sign up for giving blood or plasma."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Maroon
        Panel5.Controls.Add(PictureBox1)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(537, 36)
        Panel5.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 31)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(64, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 17)
        Label4.TabIndex = 6
        Label4.Text = "Red Cross Philippines"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(2, 36)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(537, 101)
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 369)
        Controls.Add(login1)
        Controls.Add(register1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In Account"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        login1.ResumeLayout(False)
        register1.ResumeLayout(False)
        register1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents login1 As Panel
    Friend WithEvents register1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Label12 As Label
End Class
