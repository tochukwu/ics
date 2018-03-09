Public Class login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdlgn_Click(sender As Object, e As EventArgs) Handles cmdlgn.Click
        'the code ID's the type of access to give to the person accessing the  program
        If username.Text = "" And password.Text = "***" Then
            Call adminlogin()
        ElseIf username.Text = "catherine" And password.Text = "passwordd" Then
            Call auxiliaryadmin()
        ElseIf username.Text = "staff" And password.Text = "password" Then
            Call attendant()

            Me.Dispose()

        Else
            MsgBox("invalid cedentials...threat to sysem")
            Me.Close()
        End If





    End Sub

    Private Sub tmp_Click(sender As Object, e As EventArgs) Handles tmp.Click
        username.Clear()
        password.Clear()


    End Sub
    Private Sub adminlogin()



        Form2.id.Text = "ADMIN"
        Me.Dispose()
        Form2.Show()







    End Sub
    Private Sub auxiliaryadmin()

        Form2.id.Text = "Hello" & username.Text
        Me.Dispose()
        Form2.Show()


    End Sub
    Private Sub attendant()

        Form2.id.Text = username.Text
        Me.Dispose()
        Form2.Show()


    End Sub

End Class
