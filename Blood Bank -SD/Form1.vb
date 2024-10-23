Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles homeHOME.Click
        donate1.Visible = False
        home1.Visible = True
        contact1.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles homeDONATE.Click
        home1.Visible = False
        donate1.Visible = True
        contact1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles donateHOME.Click
        donate1.Visible = False
        home1.Visible = True
        contact1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles donateDONATE.Click
        home1.Visible = False
        donate1.Visible = True
        contact1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles homeCONTACT.Click
        donate1.Visible = False
        home1.Visible = False
        contact1.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles contactCONTACT.Click
        donate1.Visible = False
        home1.Visible = False
        contact1.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles contactDONATE.Click
        donate1.Visible = True
        home1.Visible = False
        contact1.Visible = False
    End Sub

    Private Sub donateCONTACT_Click(sender As Object, e As EventArgs) Handles donateCONTACT.Click
        donate1.Visible = False
        home1.Visible = False
        contact1.Visible = True
    End Sub

    Private Sub contactHOME_Click(sender As Object, e As EventArgs) Handles contactHOME.Click
        donate1.Visible = True
        home1.Visible = False
        contact1.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub contact1_Paint(sender As Object, e As PaintEventArgs) Handles contact1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
    End Sub

    Private Sub home1_Paint(sender As Object, e As PaintEventArgs) Handles home1.Paint

    End Sub
End Class
