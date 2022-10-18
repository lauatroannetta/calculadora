Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Dim operation As String
    Dim valorresultado As Nullable(Of Double) = Nothing 'Me declara valorresultado como un nullable que sea doble y que empieze en 0'
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim presionaoperador As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        evaluarrestricciones()
        Txtresultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        evaluarrestricciones()
        Txtresultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        evaluarrestricciones()
        Txtresultado.Text &= "3"

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        evaluarrestricciones()
        Txtresultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        evaluarrestricciones()
        Txtresultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        evaluarrestricciones()
        Txtresultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        evaluarrestricciones()
        Txtresultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        evaluarrestricciones()
        Txtresultado.Text &= "8"

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        evaluarrestricciones()
        Txtresultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        evaluarrestricciones()
        Txtresultado.Text &= "0"
    End Sub

    Private Sub Buttonpunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonpunto.Click
        If InStr(Txtresultado.Text, ".", CompareMethod.Text) = 0 Then
            Txtresultado.Text &= "."
        End If
    End Sub

    Private Sub Buttonsumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsumar.Click
        EvaluaconOperacion()
        operation = "+"
    End Sub

    Private Sub Buttonrestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonrestar.Click
        EvaluaconOperacion()
        operation = "-"
    End Sub

    Private Sub buttonmultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonmultiplicar.Click
        EvaluaconOperacion()
        operation = "*"
    End Sub

    Private Sub Buttondividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttondividir.Click
        EvaluaconOperacion()
        operation = "/"
    End Sub

    Private Sub Buttonigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonigual.Click
        EvaluaconOperacion()
        operation = ""
    End Sub

    Private Sub Buttonborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonborrar.Click
        Txtresultado.Text = "0"
        valor2 = Nothing
        valorresultado = Nothing
    End Sub

    Public Sub EvaluaconOperacion()
        presionaoperador = True
        valor2 = Val(Txtresultado.Text)
        If valorresultado IsNot Nothing Then
            Select Case operation
                Case "+"
                    valorresultado = valorresultado + valor2
                Case "-"
                    valorresultado -= valor2
                Case "*"
                    valorresultado *= valor2
                Case "/"
                    valorresultado /= valor2
            End Select
            Txtresultado.Text = valorresultado
        Else
            valorresultado = valor2
        End If
    End Sub

    Public Sub evaluarrestricciones()
        If presionaoperador = True Then 'cuando se presione el operador nos premitira ingresar otro numero, entonces hay que borrar lo que ya se ingreso' 
            Txtresultado.text = ""
            presionaoperador = False
        ElseIf Txtresultado.text = "0" Then 'si hay un 0 se borra para ingresar otro digito'
            Txtresultado.text = ""
        End If
    End Sub



End Class
