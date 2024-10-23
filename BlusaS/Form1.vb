Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim result As String = MessageBox.Show("Desea salir del programa?", "advertencia", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			Application.Exit
		End If
	End Sub
	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
		Label2.Text = "Su blusa de color es"
		Label3.Text = "verde"
		Label3.ForeColor = Drawing.Color.Green
	End Sub
	Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
		Label2.Text = "Su blusa de color es"
		Label3.Text = "amarillo"
		Label3.ForeColor = Drawing.Color.Yellow
	End Sub
	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
		Label2.Text = "Su blusa de color es"
		Label3.Text = "morado"
		Label3.ForeColor = Drawing.Color.Purple
	End Sub
	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
		Label2.Text = "Su blusa de color es"
		Label3.Text = "rosa"
		Label3.ForeColor = Drawing.Color.HotPink
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Label3.Text = " "
		Label2.Text = ""

	End Sub


End Class
