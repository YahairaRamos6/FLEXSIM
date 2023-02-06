Public Class Form1
    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim d As Decimal
        Dim Puntoa As New Punto3d(Txt_x1.Text, Txt_y1.Text, Txt_z1.Text)
        Dim Puntob As New Punto3d(Txt_x2.Text, Txt_y2.Text, Txt_z2.Text)
        d = Puntoa.Calcular_Distancia(Puntob)
        Txt_Resultado.Text = d.ToString()
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Txt_Resultado.Clear()
        Txt_x1.Text = ("")
        Txt_x2.Text = ("")
        Txt_y2.Text = ("")
        Txt_y1.Text = ("")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Resultado.Enabled = False
    End Sub
End Class
