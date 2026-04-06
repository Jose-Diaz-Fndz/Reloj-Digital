<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Days = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Calstone = New System.Windows.Forms.Panel()
        Me.ElCondorPasa = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Kokona = New System.Windows.Forms.Panel()
        Me.AgnesDigital = New System.Windows.Forms.Button()
        Me.HarikitteIkou = New System.Windows.Forms.Button()
        Me.Manhattancafe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Matikanetannhauser1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Calstone.SuspendLayout()
        Me.Kokona.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Matikanetannhauser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Palace Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(204, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reloj Digital c:"
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.BackColor = System.Drawing.Color.DarkRed
        Me.Hours.Font = New System.Drawing.Font("Palace Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Hours.Location = New System.Drawing.Point(215, 154)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(65, 60)
        Me.Hours.TabIndex = 1
        Me.Hours.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.Font = New System.Drawing.Font("Palace Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label2.Location = New System.Drawing.Point(302, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 60)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.BackColor = System.Drawing.Color.DarkRed
        Me.Minutes.Font = New System.Drawing.Font("Palace Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Minutes.Location = New System.Drawing.Point(354, 154)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(65, 60)
        Me.Minutes.TabIndex = 3
        Me.Minutes.Text = "00"
        '
        'Days
        '
        Me.Days.AutoSize = True
        Me.Days.BackColor = System.Drawing.Color.Maroon
        Me.Days.Font = New System.Drawing.Font("Pristina", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Days.Location = New System.Drawing.Point(298, 228)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(91, 49)
        Me.Days.TabIndex = 4
        Me.Days.Text = "Lunes"
        Me.Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.Maroon
        Me.Fecha.Font = New System.Drawing.Font("Yu Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Fecha.Location = New System.Drawing.Point(157, 288)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(388, 47)
        Me.Fecha.TabIndex = 5
        Me.Fecha.Text = "09 de marzo del 2026"
        Me.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Calstone
        '
        Me.Calstone.BackColor = System.Drawing.Color.DarkRed
        Me.Calstone.Controls.Add(Me.PictureBox4)
        Me.Calstone.Controls.Add(Me.ElCondorPasa)
        Me.Calstone.Controls.Add(Me.Button1)
        Me.Calstone.Controls.Add(Me.Label3)
        Me.Calstone.Location = New System.Drawing.Point(135, 228)
        Me.Calstone.Name = "Calstone"
        Me.Calstone.Size = New System.Drawing.Size(528, 223)
        Me.Calstone.TabIndex = 8
        Me.Calstone.Visible = False
        '
        'ElCondorPasa
        '
        Me.ElCondorPasa.BackColor = System.Drawing.SystemColors.Menu
        Me.ElCondorPasa.FormattingEnabled = True
        Me.ElCondorPasa.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Naranja", "Verde"})
        Me.ElCondorPasa.Location = New System.Drawing.Point(21, 116)
        Me.ElCondorPasa.Name = "ElCondorPasa"
        Me.ElCondorPasa.Size = New System.Drawing.Size(121, 21)
        Me.ElCondorPasa.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "24h"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Parchment", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(164, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 51)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Configuraciones ~w~"
        '
        'Kokona
        '
        Me.Kokona.BackColor = System.Drawing.Color.IndianRed
        Me.Kokona.Controls.Add(Me.PictureBox3)
        Me.Kokona.Controls.Add(Me.AgnesDigital)
        Me.Kokona.Controls.Add(Me.HarikitteIkou)
        Me.Kokona.Controls.Add(Me.Manhattancafe)
        Me.Kokona.Controls.Add(Me.Label4)
        Me.Kokona.Location = New System.Drawing.Point(138, 12)
        Me.Kokona.Name = "Kokona"
        Me.Kokona.Size = New System.Drawing.Size(515, 217)
        Me.Kokona.TabIndex = 3
        Me.Kokona.Visible = False
        '
        'AgnesDigital
        '
        Me.AgnesDigital.Location = New System.Drawing.Point(312, 176)
        Me.AgnesDigital.Name = "AgnesDigital"
        Me.AgnesDigital.Size = New System.Drawing.Size(75, 23)
        Me.AgnesDigital.TabIndex = 3
        Me.AgnesDigital.Text = "Reset"
        Me.AgnesDigital.UseVisualStyleBackColor = True
        '
        'HarikitteIkou
        '
        Me.HarikitteIkou.Location = New System.Drawing.Point(88, 176)
        Me.HarikitteIkou.Name = "HarikitteIkou"
        Me.HarikitteIkou.Size = New System.Drawing.Size(75, 23)
        Me.HarikitteIkou.TabIndex = 2
        Me.HarikitteIkou.Text = "Inicio"
        Me.HarikitteIkou.UseVisualStyleBackColor = True
        '
        'Manhattancafe
        '
        Me.Manhattancafe.AutoSize = True
        Me.Manhattancafe.Font = New System.Drawing.Font("Papyrus", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manhattancafe.Location = New System.Drawing.Point(100, 66)
        Me.Manhattancafe.Name = "Manhattancafe"
        Me.Manhattancafe.Size = New System.Drawing.Size(287, 76)
        Me.Manhattancafe.TabIndex = 1
        Me.Manhattancafe.Text = "00:00:00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ScriptC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(135, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 60)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cronómetro"
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.BackColor = System.Drawing.Color.DarkRed
        Me.Seconds.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(425, 154)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(76, 31)
        Me.Seconds.TabIndex = 10
        Me.Seconds.Text = "Label4"
        '
        'Timer3
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Practica4.My.Resources.Resources.cronometro
        Me.PictureBox2.Location = New System.Drawing.Point(714, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Practica4.My.Resources.Resources.Hoshino
        Me.PictureBox3.Location = New System.Drawing.Point(393, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 110)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Matikanetannhauser1
        '
        Me.Matikanetannhauser1.Image = Global.Practica4.My.Resources.Resources.Not_mambo
        Me.Matikanetannhauser1.Location = New System.Drawing.Point(788, 12)
        Me.Matikanetannhauser1.Name = "Matikanetannhauser1"
        Me.Matikanetannhauser1.Size = New System.Drawing.Size(163, 124)
        Me.Matikanetannhauser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Matikanetannhauser1.TabIndex = 9
        Me.Matikanetannhauser1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Practica4.My.Resources.Resources.Manhattan_Cafe
        Me.PictureBox4.Location = New System.Drawing.Point(203, 69)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 148)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica4.My.Resources.Resources.Mambo
        Me.PictureBox1.Location = New System.Drawing.Point(-180, 262)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1364, 597)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(963, 654)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Kokona)
        Me.Controls.Add(Me.Matikanetannhauser1)
        Me.Controls.Add(Me.Calstone)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Seconds)
        Me.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Name = "Form1"
        Me.Text = "Agemasen (Reloj Digital)"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Calstone.ResumeLayout(False)
        Me.Calstone.PerformLayout()
        Me.Kokona.ResumeLayout(False)
        Me.Kokona.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Matikanetannhauser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Hours As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Minutes As Label
    Friend WithEvents Days As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Calstone As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Matikanetannhauser1 As PictureBox
    Friend WithEvents ElCondorPasa As ComboBox
    Friend WithEvents Seconds As Label
    Friend WithEvents Kokona As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents AgnesDigital As Button
    Friend WithEvents HarikitteIkou As Button
    Friend WithEvents Manhattancafe As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
