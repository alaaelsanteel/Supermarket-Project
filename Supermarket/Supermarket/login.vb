Imports System.Data.SqlClient
Public Class login
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\سبحان الله وبحمده\OneDrive\Documents\supermarketVb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If UidTb.Text = "" Then
            MsgBox("Enter Admin ID")
        ElseIf UpassTb.Text = "" Then
            MsgBox("Enter Pass")
        Else
            con.Open()
            Dim query = "select *from ADMINTBL Where AdmName='" & UidTb.Text & "'and AdmPass= '" & UpassTb.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("WRONG ADMIN OR PASSWORD")
            Else
                Dim prod = New product
                prod.Show()
                Me.Hide()


            End If
            con.Close()
        End If


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub
End Class
