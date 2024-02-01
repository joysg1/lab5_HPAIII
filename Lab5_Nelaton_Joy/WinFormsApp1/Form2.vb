Public Class Form2

    Dim filas, columnas As Integer
    Dim matriz(,) As Integer
    Dim prom() As Integer
    Dim sum As Integer

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Verificar()
    End Sub

    Sub Verificar()
        If (tbFilas.Text = "" Or tbColum.Text = "") Then
            MsgBox("Dato faltante")
        ElseIf (Val(tbFilas.Text <= 0) Or Val(tbColum.Text <= 0)) Then
            MsgBox("Favor verifique los datos")
        ElseIf (Val(tbFilas.Text > 0) And Val(tbColum.Text > 0)) Then
            Ingresar()
            Mostrar()
            CalcularProm()
            MostrarProm()

        End If
    End Sub

    Sub Ingresar()
        filas = tbFilas.Text
        columnas = tbColum.Text
        ReDim matriz(filas, columnas)
        For i = 0 To (filas - 1)
            For j = 0 To (columnas - 1)
                matriz(i, j) = Val(InputBox("Ingrese el elemento " & i & "," & j))
            Next

        Next

    End Sub

    Sub Mostrar()
        gbResultados.Enabled = True
        dgvResult.RowCount = filas
        dgvResult.ColumnCount = columnas

        dgvResult.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For i = 0 To (filas - 1)
            For j = 0 To (columnas - 1)
                dgvResult.Rows(i).Cells(j).Value = matriz(i, j)

            Next

        Next


    End Sub

    Sub CalcularProm()
        ReDim prom(filas)

        sum = 0


        For i = 0 To filas - 1
            For j = 0 To columnas - 1
                If (i Mod 2 <> 0) Then

                    sum = sum + matriz(i, j)

                End If

            Next


            prom(i) = sum / filas

            sum = 0


        Next
    End Sub

    Sub MostrarProm()
        For i = 0 To filas - 1
            If (prom(i) <> 0) Then
                lbProm.Items.Add("Promedio fila #" & i & " = " & Str(prom(i)))
            End If

        Next
    End Sub

    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbResultados.Enabled = False
    End Sub
End Class