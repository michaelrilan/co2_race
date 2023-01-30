Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        Dim nm As String = name_txt.Text
        Dim mtrs As Integer = meter_txt.Text
        Dim car As String = car_chs.Text
        rs_name.Text = nm
        Dim Score As Integer
        If mtrs <= 5 And mtrs >= 0 Then
            Score = mtrs * 5
            If car = "wood" Then
                rs_point_amount.Text = Score + 300
            ElseIf car = "metal" Then

                rs_point_amount.Text = Score + 200
            End If

        ElseIf mtrs <= 10 And mtrs >= 6 Then
            Dim scnd As Integer
            scnd = (mtrs - 5) * 20
            Score = scnd + 50
            If car = "wood" Then
                rs_point_amount.Text = Score + 300
            ElseIf car = "metal" Then

                rs_point_amount.Text = Score + 200
            End If
        ElseIf mtrs <= 15 And mtrs >= 11 Then
            Dim thrd As Integer = (5 * 10) + (5 * 20)
            Dim remaind As Integer = (mtrs - 10) * 30
            Score = thrd + remaind
            If car = "wood" Then
                rs_point_amount.Text = Score + 300
            ElseIf car = "metal" Then

                rs_point_amount.Text = Score + 200
            End If
        Else
            Dim frth As Integer = (5 * 10) + (5 * 20) + (5 * 30)
            Dim remaind As Integer = (mtrs - 15) * 40
            Score = frth + remaind
            If car = "wood" Then
                rs_point_amount.Text = Score + 300
            ElseIf car = "metal" Then

                rs_point_amount.Text = Score + 200
            End If
        End If
    End Sub
End Class
