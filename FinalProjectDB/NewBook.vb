Public Class NewBook
    Private Access As New control

    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
        Me.Close()
    End Sub
    Private Sub TxtBoxval(sender As Object, e As EventArgs) Handles Txt1.TextChanged, Txt2.TextChanged, Txt3.TextChanged, Txt4.TextChanged, Txt5.TextChanged
        If Not String.IsNullOrWhiteSpace(Txt1.Text) AndAlso Not String.IsNullOrWhiteSpace(Txt2.Text) AndAlso Not String.IsNullOrWhiteSpace(Txt3.Text) AndAlso Not String.IsNullOrWhiteSpace(Txt4.Text) AndAlso Not String.IsNullOrWhiteSpace(Txt5.Text) Then Badd.Enabled = True
    End Sub
    Private Sub Adduser()
        'Add Parameter
        Access.AddPara("@ID", Txt1.Text)
        Access.AddPara("@novelname", Txt2.Text)
        Access.AddPara("@act", "B1")
        Access.AddPara("@author", Txt3.Text)
        Access.AddPara("@Publish", Txt4.Text)
        Access.AddPara("@Price", Txt5.Text)
        Access.AddPara("@soon", "FutureUpdate")
        'exe insert
        Access.ExecQuery("Insert Into [Selling Novel Table]([Novel Selling ID],[Selling Novel Name],[Book Category Id],[Novel Author Id],[Novel Publish Id],[Novel Price Id],[Book Case Id])" &'
                         "Values (@ID,@novelname,@act,@author,@Publish,@Price,@soon);") '


        'report nd abort
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        MsgBox("Book as Added Succesfully.")
        Form1.RefreshGrid()

        Me.Close()

    End Sub

    Private Sub Badd_Click(sender As Object, e As EventArgs) Handles Badd.Click
        Adduser()

    End Sub
End Class