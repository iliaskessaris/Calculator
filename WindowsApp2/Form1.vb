Public Class Form1
    Dim a, b As Decimal, d As Double, c As String, sign, result, NewNumber As Boolean


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Not System.Convert.ToDecimal(TextBox1.Text) = 0 Then
            TextBox1.Text = 1 / System.Convert.ToDecimal(TextBox1.Text)
        Else
            TextBox1.Text = "Αδύνατη η αντιστροφή"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        a = System.Convert.ToDecimal(TextBox1.Text)
        NewNumber = True
        c = "+"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        b = System.Convert.ToDecimal(TextBox1.Text)
        If c = "+" Then
            TextBox1.Text = a + b
        End If
        If c = "-" Then
            TextBox1.Text = a - b
        End If
        If c = "*" Then
            TextBox1.Text = a * b
        End If
        If c = "/" And Not b = 0 Then
            TextBox1.Text = a / b
        End If
        If c = "/" And b = 0 Then
            TextBox1.Text = "Αδύνατη η διαίρεση"
        End If
        result = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "1"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "2"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "3"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "4"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "5"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "6"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "7"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "8"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If NewNumber = True Then
            TextBox1.Text = ""
            NewNumber = False
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If result = True Then
            TextBox1.Text = "9"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If result = True Then
            TextBox1.Text = "0"
            result = False
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        a = System.Convert.ToDecimal(TextBox1.Text)
        NewNumber = True
        c = "*"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        a = System.Convert.ToDecimal(TextBox1.Text)
        NewNumber = True
        c = "/"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        a = System.Convert.ToDecimal(TextBox1.Text)
        If a > 0 Or a = 0 Then
            d = Math.Sqrt(a)
            TextBox1.Text = d
        Else
            TextBox1.Text = "Αδύνατη η εύρεση της ρίζας"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        a = 0
        b = 0
        TextBox1.Text = "0"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0,"
        Else
            TextBox1.Text = TextBox1.Text + ","
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        sign = False
        If System.Convert.ToDecimal(TextBox1.Text) > 0 And sign = False Then
            If TextBox1.Text.First() = "+" Then
                TextBox1.Text = TextBox1.Text.Remove(0, 1)
                TextBox1.Text = "-" + TextBox1.Text
            Else
                TextBox1.Text = "-" + TextBox1.Text
            End If
            sign = True
        End If
        If System.Convert.ToDecimal(TextBox1.Text) < 0 And sign = False Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
            TextBox1.Text = "+" + TextBox1.Text
            sign = True
        End If
        sign = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        a = System.Convert.ToDecimal(TextBox1.Text)
        NewNumber = True
        c = "-"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
