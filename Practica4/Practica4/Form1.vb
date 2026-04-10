Public Class Form1
    Dim formato As Boolean = True
    Dim start_Uma As Boolean = False
    Dim tiempo_crono As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Crear una variable, le asigna un valor, el valor es la fecha de hoy convertida a string
        'En el formato es "dd 'de' yyyy" [dd- numero de día, MMMM- el mes en texto, yyyy- para el año]
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""

        'Quizas este sea el formato de 24h... M-Mambo! Unu
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        Hours.Text = Time_mod(0)
        Minutes.Text = Time_mod(1)
        Seconds.Text = Time_mod(2)
        Days.Text = Day_o
        Fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Matikanetannhauser1.Click
        If Calstone.Visible = False Then
            Calstone.Visible = True
        ElseIf Calstone.Visible = True Then
            Calstone.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ElCondorPasa.SelectedIndexChanged
        Dim color_texto As String = ElCondorPasa.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            Hours.ForeColor = Color.White
            Minutes.ForeColor = Color.White
            Label1.ForeColor = Color.White
            Days.ForeColor = Color.White
            Fecha.ForeColor = Color.White
            Seconds.ForeColor = Color.White
            Label2.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            Hours.ForeColor = Color.IndianRed
            Minutes.ForeColor = Color.IndianRed
            Label1.ForeColor = Color.IndianRed
            Days.ForeColor = Color.IndianRed
            Fecha.ForeColor = Color.IndianRed
            Seconds.ForeColor = Color.IndianRed
            Label2.ForeColor = Color.IndianRed
        ElseIf color_texto = "Azul" Then
            Hours.ForeColor = Color.DarkTurquoise
            Minutes.ForeColor = Color.DarkTurquoise
            Label1.ForeColor = Color.DarkTurquoise
            Days.ForeColor = Color.DarkTurquoise
            Fecha.ForeColor = Color.DarkTurquoise
            Seconds.ForeColor = Color.DarkTurquoise
            Label2.ForeColor = Color.DarkTurquoise
        ElseIf color_texto = "Naranja" Then
            Hours.ForeColor = Color.LightSalmon
            Minutes.ForeColor = Color.LightSalmon
            Label1.ForeColor = Color.LightSalmon
            Days.ForeColor = Color.LightSalmon
            Fecha.ForeColor = Color.LightSalmon
            Seconds.ForeColor = Color.LightSalmon
            Label2.ForeColor = Color.LightSalmon
        ElseIf color_texto = "Verde" Then
            Hours.ForeColor = Color.MediumSpringGreen
            Minutes.ForeColor = Color.MediumSpringGreen
            Label1.ForeColor = Color.MediumSpringGreen
            Days.ForeColor = Color.MediumSpringGreen
            Fecha.ForeColor = Color.MediumSpringGreen
            Seconds.ForeColor = Color.MediumSpringGreen
            Label2.ForeColor = Color.MediumSpringGreen
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub
    Private StartTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles HarikitteIkou.Click
        If start_Uma = False Then
            Timer3.Enabled = True
            start_Uma = True
            HarikitteIkou.Text = "Detenerse"
            StartTime = DateTime.Now
        ElseIf start_Uma = True Then
            Timer3.Enabled = False
            start_Uma = False
            HarikitteIkou.Text = "Inicio"
            elapsed += DateTime.Now - StartTime
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AgnesDigital.Click
        elapsed = TimeSpan.Zero
        Timer3.Enabled = False
        Manhattancafe.Text = "00:00:00.00"
        start_Uma = False
        HarikitteIkou.Text = "Inicio"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim current = elapsed + (DateTime.Now - StartTime)
        Manhattancafe.Text = current.ToString("hh\:mm\:ss\.ff")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Hoshino.Visible = False Then
            Hoshino.Visible = True
        ElseIf Hoshino.Visible = True Then
            Hoshino.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If OrphieAndMagus.Visible = True Then
            OrphieAndMagus.Visible = False
        ElseIf OrphieAndMagus.Visible = False Then
            OrphieAndMagus.Visible = True
        End If
    End Sub
End Class
