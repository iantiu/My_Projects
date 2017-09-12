Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = "Hello World"

        textbox1.TextAlign = HorizontalAlignment.Center
        TextBox1.BackColor = ProvideRandomColor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        textbox1.focus

        textbox1.TextAlign = HorizontalAlignment.Left
        TextBox1.BackColor = Color.White
    End Sub

    Private Function ProvideRandomColor() As Color
        Dim rand = new Random

        Dim red = rand.Next(0, 255)
        Dim green = rand.Next(0, 255)
        Dim blue = rand.Next(0, 255)

        Const alpha = 255

        Return Color.FromArgb(alpha, red, green, blue)
    End Function
End Class
