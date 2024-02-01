<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.tbDimension = New System.Windows.Forms.TextBox()
        Me.gbResultados = New System.Windows.Forms.GroupBox()
        Me.lbResultados = New System.Windows.Forms.ListBox()
        Me.bSiguiente = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        Me.gbResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DIMENSION"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.bAceptar)
        Me.gbDatos.Controls.Add(Me.tbDimension)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(250, 123)
        Me.gbDatos.TabIndex = 1
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS"
        '
        'bAceptar
        '
        Me.bAceptar.Location = New System.Drawing.Point(85, 80)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(94, 29)
        Me.bAceptar.TabIndex = 2
        Me.bAceptar.Text = "ACEPTAR"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'tbDimension
        '
        Me.tbDimension.Location = New System.Drawing.Point(103, 33)
        Me.tbDimension.Name = "tbDimension"
        Me.tbDimension.Size = New System.Drawing.Size(56, 27)
        Me.tbDimension.TabIndex = 1
        '
        'gbResultados
        '
        Me.gbResultados.Controls.Add(Me.lbResultados)
        Me.gbResultados.Location = New System.Drawing.Point(18, 159)
        Me.gbResultados.Name = "gbResultados"
        Me.gbResultados.Size = New System.Drawing.Size(250, 226)
        Me.gbResultados.TabIndex = 3
        Me.gbResultados.TabStop = False
        Me.gbResultados.Text = "RESULTADOS"
        '
        'lbResultados
        '
        Me.lbResultados.FormattingEnabled = True
        Me.lbResultados.ItemHeight = 20
        Me.lbResultados.Location = New System.Drawing.Point(7, 27)
        Me.lbResultados.Name = "lbResultados"
        Me.lbResultados.Size = New System.Drawing.Size(237, 184)
        Me.lbResultados.TabIndex = 0
        '
        'bSiguiente
        '
        Me.bSiguiente.Location = New System.Drawing.Point(174, 403)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(94, 29)
        Me.bSiguiente.TabIndex = 4
        Me.bSiguiente.Text = "SIGUIENTE"
        Me.bSiguiente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 444)
        Me.Controls.Add(Me.bSiguiente)
        Me.Controls.Add(Me.gbResultados)
        Me.Controls.Add(Me.gbDatos)
        Me.Name = "Form1"
        Me.Text = "LAB5 PROG1"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbResultados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents tbDimension As TextBox
    Friend WithEvents bAceptar As Button
    Friend WithEvents gbResultados As GroupBox
    Friend WithEvents lbResultados As ListBox
    Friend WithEvents bSiguiente As Button
End Class
