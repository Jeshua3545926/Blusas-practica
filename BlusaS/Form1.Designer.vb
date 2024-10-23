<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		GroupBox1 = New GroupBox()
		RadioButton5 = New RadioButton()
		RadioButton4 = New RadioButton()
		RadioButton3 = New RadioButton()
		RadioButton1 = New RadioButton()
		Button1 = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Button2 = New Button()
		GroupBox1.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(RadioButton5)
		GroupBox1.Controls.Add(RadioButton4)
		GroupBox1.Controls.Add(RadioButton3)
		GroupBox1.Controls.Add(RadioButton1)
		GroupBox1.Font = New Font("SimSun-ExtB", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		GroupBox1.ForeColor = SystemColors.ControlLightLight
		GroupBox1.Location = New Point(3, 137)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(396, 352)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Blusas"
		' 
		' RadioButton5
		' 
		RadioButton5.AutoSize = True
		RadioButton5.ForeColor = Color.Yellow
		RadioButton5.Location = New Point(31, 151)
		RadioButton5.Name = "RadioButton5"
		RadioButton5.Size = New Size(255, 56)
		RadioButton5.TabIndex = 4
		RadioButton5.TabStop = True
		RadioButton5.Text = "Amarillo"
		RadioButton5.UseVisualStyleBackColor = True
		' 
		' RadioButton4
		' 
		RadioButton4.AutoSize = True
		RadioButton4.ForeColor = Color.DarkViolet
		RadioButton4.Location = New Point(31, 213)
		RadioButton4.Name = "RadioButton4"
		RadioButton4.Size = New Size(203, 56)
		RadioButton4.TabIndex = 3
		RadioButton4.TabStop = True
		RadioButton4.Text = "Morada"
		RadioButton4.UseVisualStyleBackColor = True
		' 
		' RadioButton3
		' 
		RadioButton3.AutoSize = True
		RadioButton3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
		RadioButton3.Location = New Point(31, 275)
		RadioButton3.Name = "RadioButton3"
		RadioButton3.Size = New Size(151, 56)
		RadioButton3.TabIndex = 2
		RadioButton3.TabStop = True
		RadioButton3.Text = "Rosa"
		RadioButton3.UseVisualStyleBackColor = True
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.ForeColor = Color.Green
		RadioButton1.Location = New Point(37, 80)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(177, 56)
		RadioButton1.TabIndex = 0
		RadioButton1.TabStop = True
		RadioButton1.Text = "Verde"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' Button1
		' 
		Button1.FlatAppearance.BorderSize = 0
		Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
		Button1.FlatStyle = FlatStyle.Flat
		Button1.ForeColor = SystemColors.ControlLightLight
		Button1.Location = New Point(937, -1)
		Button1.Name = "Button1"
		Button1.Size = New Size(34, 40)
		Button1.TabIndex = 1
		Button1.Text = "X"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = SystemColors.ControlLightLight
		Label1.Location = New Point(3, 44)
		Label1.Name = "Label1"
		Label1.Size = New Size(268, 48)
		Label1.TabIndex = 2
		Label1.Text = "Escoga La blusa"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = SystemColors.ControlLightLight
		Label2.Location = New Point(22, 575)
		Label2.Name = "Label2"
		Label2.Size = New Size(0, 48)
		Label2.TabIndex = 3
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = SystemColors.ControlLightLight
		Label3.Location = New Point(391, 575)
		Label3.Name = "Label3"
		Label3.Size = New Size(0, 48)
		Label3.TabIndex = 4
		' 
		' Button2
		' 
		Button2.FlatAppearance.BorderSize = 0
		Button2.FlatStyle = FlatStyle.Flat
		Button2.ForeColor = SystemColors.ButtonHighlight
		Button2.Location = New Point(12, 508)
		Button2.Name = "Button2"
		Button2.Size = New Size(146, 64)
		Button2.TabIndex = 5
		Button2.Text = "Borrar"
		Button2.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.Desktop
		ClientSize = New Size(968, 750)
		Controls.Add(Button2)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Button1)
		Controls.Add(GroupBox1)
		FormBorderStyle = FormBorderStyle.None
		Name = "Form1"
		Text = "Form1"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents RadioButton5 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Button2 As Button

End Class
