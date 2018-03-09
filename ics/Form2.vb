Imports System.IO
'Please do note that some of my comments are in short hand
Public Class Form2
    'Dim As String
    Dim total As Double
    Dim vat As Decimal 'hndls the flt tx on 4everything
    Dim discount As Double = 0 'hndls d 15% discount if d person hs a cusomer card
    Dim prival As Decimal ' i aded this  for the  iscount
    Dim newans As Decimal ' this too for the discount
    Dim distot As Decimal 'hndls d new value for  discount x total which wiould be deducted form the original total amount
    Dim Cal As Double = 0 'hndls d 20% charge for  gettin it to go
    Dim mainc As Decimal '4 main course 
    Dim sidc As Decimal '4 side order
    Dim array As New ArrayList

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles maincourse.Enter

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles prcss.Enter

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        dsply.Clear()



    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ndrntim_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub feb_Click(sender As Object, e As EventArgs) Handles feb.Click
        mainc = 4.75 * NumericUpDown3.Value
        dsply.AppendText("Full English BreakFast £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub hec_Click(sender As Object, e As EventArgs) Handles hec.Click
        
        mainc = 4.5 * NumericUpDown1.Value
        dsply.AppendText("Ham, Eggs and Chips £" + mainc.ToString + vbNewLine)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles jpb.Click

        mainc = 3.75 * NumericUpDown5.Value
        dsply.AppendText("Jacket potato and  Beans £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles beans.Click
        sidc = 1.1 * NumericUpDown13.Value
        dsply.AppendText("Beans £" + sidc.ToString + vbNewLine)
    End Sub

    Private Sub ndrntm_Click(sender As Object, e As EventArgs) Handles ndrntm.Click

        Me.Close()







    End Sub

    Private Sub po_Click(sender As Object, e As EventArgs) Handles po.Click
        'Private Sub po_Click(ByVal sender As System.Object, e As EventArgs) Handles po.Click
        Dim file As System.IO.StreamWriter
        Dim MyStamp

        Dim response = MsgBox("Are you sure you want to procede with this order?", vbQuestion + vbYesNo, )


        If response = MsgBoxResult.Yes Then
            file = My.Computer.FileSystem.OpenTextFileWriter("Orders", True)
            file.WriteLine(dsply.Text)
            'bring  time from the  label
            MyStamp = FileDateTime("Orders")
            file.Close()
            MsgBox(" Thank you, your order is being  procesed")
            dsply.Text = ""
        Else
            'this is will clear the display box
            dsply.Text = ""

            MsgBox("This Order was Aborted")

        End If





    End Sub

    Private Sub ttlcst_Click(sender As Object, e As EventArgs) Handles po.Click

    End Sub


    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        dsply.Text = ""

        Dim reader As System.IO.StreamReader

        reader = My.Computer.FileSystem.OpenTextFileReader("Orders")
        dsply.Text = reader.ReadLine("Orders")



    End Sub

    Private Sub dsply_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Function Ham() As String
        Throw New NotImplementedException
    End Function

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        RadioButton3.Enabled = False




    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton5.Enabled = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        MsgBox("This is type of discount is not yet avalable")

    End Sub


    Private Sub GroupBox1_Enter_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub pac_Click(sender As Object, e As EventArgs) Handles pac.Click
        mainc = 4.2 * NumericUpDown2.Value
        dsply.AppendText("Pie and Chips £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub br_Click(sender As Object, e As EventArgs) Handles br.Click
        mainc = 2.2 * NumericUpDown7.Value
        dsply.AppendText("Bacon Roll £" + mainc.ToString + vbNewLine)

    End Sub
    Private Sub cs_Click(sender As Object, e As EventArgs) Handles cs.Click
        mainc = 4.0 * NumericUpDown9.Value
        dsply.AppendText("Chicken Salad £" + mainc.ToString + vbNewLine)

    End Sub

    Private Sub l_Click(sender As Object, e As EventArgs) Handles l.Click
        mainc = 4.0 * NumericUpDown4.Value
        dsply.AppendText("Lasagnae £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub Rst_Click(sender As Object, e As EventArgs) Handles Rst.Click
        mainc = 5.25 * NumericUpDown6.Value
        dsply.AppendText("Roast Dinner £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub co_Click(sender As Object, e As EventArgs) Handles co.Click
        mainc = 3.4 * NumericUpDown8.Value
        dsply.AppendText("Cheese Omlete £" + mainc.ToString + vbNewLine)
    End Sub

    Private Sub gb_Click(sender As Object, e As EventArgs) Handles gb.Click
        sidc = 1.5 * NumericUpDown10.Value
        dsply.AppendText("Garlic Bread £" + sidc.ToString + vbNewLine)

    End Sub

    Private Sub chips_Click(sender As Object, e As EventArgs) Handles chips.Click
        sidc = 1.1 * NumericUpDown12.Value
        dsply.AppendText("Chips £" + sidc.ToString + vbNewLine)
    End Sub

    Private Sub ss_Click(sender As Object, e As EventArgs) Handles ss.Click
        sidc = 1.0 * NumericUpDown11.Value
        dsply.AppendText("Side salad £" + sidc.ToString + vbNewLine)

    End Sub

    Private Sub dsply_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Display_TextChanged(sender As Object, e As EventArgs) Handles dsply.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vat = 0.2
        total = mainc + sidc - distot
        If (RadioButton2.Checked) Then
            Cal = total * 20% / 100
            RadioButton2.Text = Cal.ToString

        Else
            Cal = 0
        End If
        If RadioButton5.Checked Then
            discount = total * 15% / 100

        End If
        total -= Cal
        total -= discount
        dsply.AppendText("This is  what you have to  pay" + total.ToString)



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Now.ToString("dd:MM:yyyy hh:mm:ss")
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class