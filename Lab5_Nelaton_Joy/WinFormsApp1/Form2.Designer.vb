<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.tbColum = New System.Windows.Forms.TextBox()
        Me.tbFilas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbResultados = New System.Windows.Forms.GroupBox()
        Me.lbProm = New System.Windows.Forms.ListBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.bAnterior = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        Me.gbResultados.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.bAceptar)
        Me.gbDatos.Controls.Add(Me.tbColum)
        Me.gbDatos.Controls.Add(Me.tbFilas)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Location = New System.Drawing.Point(24, 26)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(165, 174)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS"
        '
        'bAceptar
        '
        Me.bAceptar.Location = New System.Drawing.Point(27, 126)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(94, 29)
        Me.bAceptar.TabIndex = 4
        Me.bAceptar.Text = "ACEPTAR"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'tbColum
        '
        Me.tbColum.Location = New System.Drawing.Point(87, 76)
        Me.tbColum.Name = "tbColum"
        Me.tbColum.Size = New System.Drawing.Size(54, 27)
        Me.tbColum.TabIndex = 3
        '
        'tbFilas
        '
        Me.tbFilas.Location = New System.Drawing.Point(87, 37)
        Me.tbFilas.Name = "tbFilas"
        Me.tbFilas.Size = New System.Drawing.Size(54, 27)
        Me.tbFilas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Columnas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filas"
        '
        'gbResultados
        '
        Me.gbResultados.Controls.Add(Me.lbProm)
        Me.gbResultados.Controls.Add(Me.dgvResult)
        Me.gbResultados.Location = New System.Drawing.Point(219, 26)
        Me.gbResultados.Name = "gbResultados"
        Me.gbResultados.Size = New System.Drawing.Size(457, 367)
        Me.gbResultados.TabIndex = 1
        Me.gbResultados.TabStop = False
        Me.gbResultados.Text = "Resultados"
        '
        'lbProm
        '
        Me.lbProm.FormattingEnabled = True
        Me.lbProm.ItemHeight = 20
        Me.lbProm.Location = New System.Drawing.Point(7, 221)
        Me.lbProm.Name = "lbProm"
        Me.lbProm.Size = New System.Drawing.Size(444, 144)
        Me.lbProm.TabIndex = 1
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(7, 27)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.RowHeadersWidth = 51
        Me.dgvResult.RowTemplate.Height = 29
        Me.dgvResult.Size = New System.Drawing.Size(444, 176)
        Me.dgvResult.TabIndex = 0
        '
        'bAnterior
        '
        Me.bAnterior.Location = New System.Drawing.Point(12, 364)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.Size = New System.Drawing.Size(94, 29)
        Me.bAnterior.TabIndex = 5
        Me.bAnterior.Text = "ANTERIOR"
        Me.bAnterior.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 405)
        Me.Controls.Add(Me.bAnterior)
        Me.Controls.Add(Me.gbResultados)
        Me.Controls.Add(Me.gbDatos)
        Me.Name = "Form2"
        Me.Text = "LAB5 PROG2"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbResultados.ResumeLayout(False)
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents bAceptar As Button
    Friend WithEvents tbColum As TextBox
    Friend WithEvents tbFilas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbResultados As GroupBox
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents lbProm As ListBox
    Friend WithEvents bAnterior As Button
End Class
