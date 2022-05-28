Imports System.Data.SqlClient
Public Class Admin
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\سبحان الله وبحمده\OneDrive\Documents\supermarketVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub elements()
        Con.Open()
        Dim sql = " select * from ADMINTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim dS As DataSet
        dS = New DataSet
        adapter.Fill(dS)
        ADMINDGV.DataSource = dS.Tables(0)

        Con.Close()
    End Sub
    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click
        Con.Open()
        Dim query As String
        query = "insert into ADMINTbl values(" & AId.Text & " ,'" & AName.Text & "',' " & APASS.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("ADMINT Added Successfully")
        Con.Close()
        elements()

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Cat = New category
        Cat.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim prod = New product
        prod.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim log = New login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elements()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CLEARButton_Click(sender As Object, e As EventArgs) Handles CLEARButton.Click
        AId.Text = ""
        AName.Text = ""
        APASS.Text = ""
    End Sub

    Private Sub DELETEButton_Click(sender As Object, e As EventArgs) Handles DELETEButton.Click
        If AId.Text = "" Then
            MsgBox("Select The ADMIN To Be Deleted")
        Else
            Con.Open()
            Dim query As String
            query = "delete from ADMINTbl where AdmId = " & AId.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("ADMIN deleted Successfully")
            Con.Close()
            elements()
        End If
    End Sub

    Private Sub EDITButton_Click(sender As Object, e As EventArgs) Handles EDITButton.Click
        If AId.Text = "" Or AName.Text = "" Or APASS.Text = "" Then
            MsgBox("missing information")

        Else
            Con.Open()
            Dim query As String
            query = "Update ADMINTbl set AdmName =  '" & AName.Text & "',Admpass =  '" & APASS.Text & "' where AdmId = " & AId.Text & ""

            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("ADMIN updated")
            Con.Close()
            elements()
        End If
    End Sub


End Class