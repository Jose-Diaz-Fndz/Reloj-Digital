<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Days = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reloj Digital c:"
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.Font = New System.Drawing.Font("Rage Italic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours.ForeColor = System.Drawing.Color.Crimson
        Me.Hours.Location = New System.Drawing.Point(227, 126)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(100, 80)
        Me.Hours.TabIndex = 1
        Me.Hours.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rage Italic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(340, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 80)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Rage Italic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.ForeColor = System.Drawing.Color.Crimson
        Me.Minutes.Location = New System.Drawing.Point(399, 126)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(100, 80)
        Me.Minutes.TabIndex = 3
        Me.Minutes.Text = "00"
        '
        'Days
        '
        Me.Days.AutoSize = True
        Me.Days.Font = New System.Drawing.Font("Perpetua", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days.Location = New System.Drawing.Point(140, 237)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(98, 42)
        Me.Days.TabIndex = 4
        Me.Days.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Segoe Print", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(244, 223)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(444, 61)
        Me.Fecha.TabIndex = 5
        Me.Fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(736, 450)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Days)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Agemasen (Reloj Digital)"
        Me.TransparencyKey = System.Drawing.Color.White
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
End Class
