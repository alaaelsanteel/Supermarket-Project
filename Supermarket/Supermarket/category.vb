Imports System.Data.SqlClient
Public Class category
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\سبحان الله وبحمده\OneDrive\Documents\supermarketVb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub

    Private Sub CLEARButton_Click(sender As Object, e As EventArgs) Handles CLEARButton.Click
        CatId.Text = ""
        CatName.Text = ""
        CatDesc.Text = ""
    End Sub
    Private Sub elements()
        con.Open()
        Dim sql = " select * from CategoryTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim dS As DataSet
        dS = New DataSet
        adapter.Fill(dS)
        CategoryDGV.DataSource = dS.Tables(0)

        con.Close()
    End Sub
    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click
        con.Open()
        Dim query As String
        query = "insert into CategoryTbl values(" & CatId.Text & " ,'" & CatName.Text & "',' " & CatDesc.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Category Added Successfully")
        con.Close()
        elements()

    End Sub

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elements()

    End Sub

    Private Sub DELETEButton_Click(sender As Object, e As EventArgs) Handles DELETEButton.Click
        If CatId.Text = "" Then
            MsgBox("Select The Category To Be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "delete from CategoryTbl where CatId = " & CatId.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Category deleted Successfully")
            con.Close()
            elements()
        End If
    End Sub

    Private Sub EDITButton_Click(sender As Object, e As EventArgs) Handles EDITButton.Click
        If CatId.Text = "" Or CatName.Text = "" Or CatDesc.Text = "" Then
            MsgBox("missing information")
        Else
            con.Open()
            Dim query As String
            query = "Update CategoryTbl set CatName =  '" & CatName.Text & "',CatDesc =  '" & CatDesc.Text & "' where CatId = " & CatId.Text & ""

            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Category updated")
            con.Close()
            elements()
        End If
    End Sub
End Class