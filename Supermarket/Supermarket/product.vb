Imports System.Data.SqlClient
Public Class product
    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elements()

    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\سبحان الله وبحمده\OneDrive\Documents\supermarketVb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub elements()
        con.Open()
        Dim sql = " select * from proudectTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim dataS As DataSet
        dataS = New DataSet
        adapter.Fill(dataS)
        ProdectDGV.DataSource = dataS.Tables(0)

        con.Close()
    End Sub
    Private Sub fillCombo()
        con.Open()
        Dim sql = " select * from CategoryTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        catCb.DisplayMember = "CatName"
        catCb.ValueMember = "CatName"
        con.Close()

    End Sub
    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDButton.Click
        con.Open()
        Dim query As String
        query = "insert into proudectTbl values(" & prodId.Text & " ,'" & prodName.Text & "'," & prodPrice.Text & ", '" & catCb.SelectedItem.ToString() & "'  )"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Product Added Successfully")
        con.Close()
        elements()
    End Sub

    Private Sub DELETEButton_Click(sender As Object, e As EventArgs) Handles DELETEButton.Click
        If prodId.Text = "" Then
            MsgBox("Select The Product To Be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "delete from proudectTbl where prodId = " & prodId.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Product deleted Successfully")
            con.Close()
            elements()
        End If
    End Sub

    Private Sub CLEARButton_Click(sender As Object, e As EventArgs) Handles CLEARButton.Click
        prodId.Text = ""
        prodName.Text = ""
        prodPrice.Text = ""
    End Sub

    Private Sub EDITButton_Click(sender As Object, e As EventArgs) Handles EDITButton.Click
        If prodId.Text = "" Or prodName.Text = "" Or prodPrice.Text = "" Then
            MsgBox("missing information")
        Else
            con.Open()
            Dim query As String
            query = "Update ProudectTbl set prodName =  '" & prodName.Text & "',prodprice =  " & prodPrice.Text & " , catCb = '" & catCb.SelectedItem.ToString() & "'where prodId = " & prodId.Text & ""

            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("proudect updated")
            con.Close()
            elements()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class