Public Class Form1
    Dim matriz(,) As Integer
    Dim N As Integer
    Dim vec() As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbResultados.Enabled = False
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Verificar()
    End Sub

    Sub Verificar()
        If (tbDimension.Text = "") Then
            MsgBox("Dato no ingresado")
        ElseIf (Val(tbDimension.Text <= 0)) Then
            MsgBox("Favor verifique el dato ingresado")

        Else
            Ingresar()

            Asignar()

            Mostrar()


        End If

    End Sub

    Sub Ingresar()
        N = Val(tbDimension.Text)

        ReDim matriz(N, N)



        For i = 1 To N

            For j = 1 To N
                matriz(i, j) = Val(InputBox("Ingrese el elemento " & i & "," & j))




            Next


        Next



    End Sub



    Sub Asignar()

        gbResultados.Enabled = True
        ReDim vec(N)
        Dim c As Integer
        c = 0

        For i = 1 To N
            For j = 1 To N
                If (i + j = N + 1) Then
                    vec(c) = matriz(i, j)
                    c = c + 1
                End If
            Next

        Next







    End Sub

    Sub Mostrar()
        Array.Sort(vec)
        Array.Reverse(vec)
        lbResultados.Enabled = True
        For i = 0 To N - 1
            lbResultados.Items.Add(vec(i))

        Next
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
