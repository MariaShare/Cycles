Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Введите натуральное число"
        Button1.Text = "Вычислить"
    End Sub
    Private Sub ButEvs(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Выберите функцию!")
        Else
            Dim i = ComboBox1.SelectedIndex
            Select Case i
                Case 0
                    ListBox1.Items.Clear()
                    NInfo()
                Case 1
                    ListBox1.Items.Clear()
                    sumSin()
            End Select
        End If
    End Sub

    Private Sub NInfo()
        Dim num = TextBox1.Text
        Dim i = 0
        Dim sum2 = 0
        Dim sum3 = 0
        Dim fl = 0
        Do While i < Len(num)
            sum2 += Math.Pow(Val(num(i)), 2)
            sum3 += Math.Pow(Val(num(i)), 3)
            If i = 0 Or i = Len(num) - 1 Then
                fl += Val(num(i))
            End If
            i += 1
        Loop
        ListBox1.Items.Add("Пред Do While:" + Str(sum2) + Str(sum3) + Str(Val(num(0))) + Str(fl))

        i = Len(num) - 1
        sum2 = 0
        sum3 = 0
        fl = 0
        Do Until i < 0
            sum2 += Math.Pow(Val(num(i)), 2)
            sum3 += Math.Pow(Val(num(i)), 3)
            If i = 0 Or i = Len(num) - 1 Then
                fl += Val(num(i))
            End If
            i -= 1
        Loop
        ListBox1.Items.Add("Пред Do Until:" + Str(sum2) + Str(sum3) + Str(Val(num(0))) + Str(fl))

        i = 0
        sum2 = 0
        sum3 = 0
        fl = 0
        Do
            sum2 += Math.Pow(Val(num(i)), 2)
            sum3 += Math.Pow(Val(num(i)), 3)
            If i = 0 Or i = Len(num) - 1 Then
                fl += Val(num(i))
            End If
            i += 1
        Loop While i < Len(num)
        ListBox1.Items.Add("Пост Do While:" + Str(sum2) + Str(sum3) + Str(Val(num(0))) + Str(fl))

        i = Len(num) - 1
        sum2 = 0
        sum3 = 0
        fl = 0
        Do
            sum2 += Math.Pow(Val(num(i)), 2)
            sum3 += Math.Pow(Val(num(i)), 3)
            If i = 0 Or i = Len(num) - 1 Then
                fl += Val(num(i))
            End If
            i -= 1
        Loop Until i < 0
        ListBox1.Items.Add("Пост Do Until:" + Str(sum2) + Str(sum3) + Str(Val(num(0))) + Str(fl))
    End Sub
    Private Sub sumSin()
        Dim num = CInt(TextBox1.Text)
        Dim summ As Double = 0
        Dim summSin As Double = 0
        Dim i As Int64
        For i = 1 To num
            summSin += Math.Sin(i)
            summ += 1 / summSin
        Next i
        ListBox1.Items.Add("For:" + Str(summSin) + Str(summ))

        summ = 0
        summSin = 0
        i = 1
        Do While i <= num
            summSin += Math.Sin(i)
            summ += 1 / summSin
            i += 1
        Loop
        ListBox1.Items.Add("Do While:" + Str(summSin) + Str(summ))
    End Sub
End Class
