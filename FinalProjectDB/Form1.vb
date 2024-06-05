Public Class Form1
    Private Access As New control

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub
    Public Sub RefreshGrid()
        'Run Query
        Access.ExecQuery("SELECT * FROM [Selling Novel Table] ") 'ORDER BY [Selling Novel Name] ASC
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        'Fill Datagrid
        Data.DataSource = Access.DBDT
        'clear box
        combo1.Items.Clear()
        'Fill combo1 with every 9th term
        Dim i As Integer = 0
        For Each a As DataRow In Access.DBDT.Rows
            If i Mod 9 = 0 Then ' Check if it's the 9th term
                combo1.Items.Add(a("Book Case Id"))
            End If
            i += 1
        Next 'Fill combo1 with every 9th term
        'display First Name Found
        'If Access.RecordCount > 0 Then combo1.SelectedIndex = 0
    End Sub
    Private Sub BarMember(Name As String)
        'Add Parameters & Run Query 
        Access.AddPara("@User", Name & "%")
        Access.ExecQuery("SELECT [Selling Novel Table].[Novel Selling ID],[Selling Novel Table].[Selling Novel Name],[Novel Author Table].[Author Name],[Novel Publish Table].[Year Publish],[Selling Novel Table].[Novel Price Id],[BookCase Table].[BookCase Num]" &
                         "From ((([Selling Novel Table]" &
                         "Inner Join [Novel Publish Table]" &
                         "ON [Novel Publish Table].[Novel Publish ID] = [Selling Novel Table].[Novel Publish Id])" &
                         "Inner Join [Novel Author Table]" &
                         "ON [Novel Author Table].[Novel Author Id] = [Selling Novel Table].[Novel Author Id])" &
                         "Inner Join [BookCase Table]" &
                         "ON [Selling Novel Table].[Book Case Id] = [BookCase Table].[Book Case ID])" &
                         "WHERE [Selling Novel Table].[Book Case Id] LIKE @User")

        'Report & Abort On Errors
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        'Fill Combo

        Data.DataSource = Access.DBDT

    End Sub
    Private Sub SearchMember(Name As String)
        'Add Parameters & Run Query 
        Access.AddPara("@User", Name & "%")
        Access.ExecQuery("SELECT [Selling Novel Table].[Novel Selling ID],[Selling Novel Table].[Selling Novel Name],[Novel Author Table].[Author Name],[Novel Publish Table].[Year Publish],[Selling Novel Table].[Novel Price Id],[BookCase Table].[BookCase Num]" &
                         "From ((([Selling Novel Table]" &
                         "Inner Join [Novel Publish Table]" &
                         "ON [Novel Publish Table].[Novel Publish ID] = [Selling Novel Table].[Novel Publish Id])" &
                         "Inner Join [Novel Author Table]" &
                         "ON [Novel Author Table].[Novel Author Id] = [Selling Novel Table].[Novel Author Id])" &
                         "Inner Join [BookCase Table]" &
                         "ON [Selling Novel Table].[Book Case Id] = [BookCase Table].[Book Case ID])" &
                         "WHERE [Selling Novel Table].[Selling Novel Name] LIKE @User")

        'Report & Abort On Errors
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        'Fill Combo
        combo1.SelectedIndex = -1
        Data.DataSource = Access.DBDT

    End Sub
    Private Sub combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo1.SelectedIndexChanged
        If combo1.Text = "" Then

        Else
            BarMember(combo1.Text)
            Box1.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchMember(Box1.Text)
    End Sub

    Private Sub NewAddedNovelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAddedNovelToolStripMenuItem.Click
        NewBook.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnId_Click(sender As Object, e As EventArgs) Handles BtnId.Click
        If TxtSummary.Text = "A1" Then
            TxtSummary.Clear()
            SynoA1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A2" Then
            TxtSummary.Clear()
            SynoA2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A3" Then
            TxtSummary.Clear()
            SynoA3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A4" Then
            TxtSummary.Clear()
            SynoA4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A5" Then
            TxtSummary.Clear()
            SynoA5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A6" Then
            TxtSummary.Clear()
            SynoA6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A7" Then
            TxtSummary.Clear()
            SynoA7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A8" Then
            TxtSummary.Clear()
            SynoA8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "A9" Then
            TxtSummary.Clear()
            SynoA9.Show()
            Me.Hide()
            'B
            'B
        ElseIf TxtSummary.Text = "B1" Then
            TxtSummary.Clear()
            SynoB1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B2" Then
            TxtSummary.Clear()
            SynoB2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B3" Then
            TxtSummary.Clear()
            SynoB3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B4" Then
            TxtSummary.Clear()
            SynoB4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B5" Then
            TxtSummary.Clear()
            SynoB5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B6" Then
            TxtSummary.Clear()
            SynoB6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B7" Then
            TxtSummary.Clear()
            SynoB7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B8" Then
            TxtSummary.Clear()
            SynoB8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "B9" Then
            TxtSummary.Clear()
            SynoB9.Show()
            Me.Hide()
            'C
            'C
        ElseIf TxtSummary.Text = "C1" Then
            TxtSummary.Clear()
            SynoC1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C2" Then
            TxtSummary.Clear()
            SynoC2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C3" Then
            TxtSummary.Clear()
            SynoC3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C4" Then
            TxtSummary.Clear()
            SynoC4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C5" Then
            TxtSummary.Clear()
            SynoC5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C6" Then
            TxtSummary.Clear()
            SynoC6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C7" Then
            TxtSummary.Clear()
            SynoC7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C8" Then
            TxtSummary.Clear()
            SynoC8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "C9" Then
            TxtSummary.Clear()
            SynoC9.Show()
            Me.Hide()
            'D
            'D
        ElseIf TxtSummary.Text = "D1" Then
            TxtSummary.Clear()
            SynoD1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D2" Then
            TxtSummary.Clear()
            SynoD2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D3" Then
            TxtSummary.Clear()
            SynoD3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D4" Then
            TxtSummary.Clear()
            SynoD4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D5" Then
            TxtSummary.Clear()
            SynoD5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D6" Then
            TxtSummary.Clear()
            SynoD6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D7" Then
            TxtSummary.Clear()
            SynoD7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D8" Then
            TxtSummary.Clear()
            SynoD8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "D9" Then
            TxtSummary.Clear()
            SynoD9.Show()
            Me.Hide()
            'E
            'E
        ElseIf TxtSummary.Text = "E1" Then
            TxtSummary.Clear()
            SynoE1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E2" Then
            TxtSummary.Clear()
            SynoE2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E3" Then
            TxtSummary.Clear()
            SynoE3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E4" Then
            TxtSummary.Clear()
            SynoE4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E5" Then
            TxtSummary.Clear()
            SynoE5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E6" Then
            TxtSummary.Clear()
            SynoE6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E7" Then
            TxtSummary.Clear()
            SynoE7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E8" Then
            TxtSummary.Clear()
            SynoE8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "E9" Then
            TxtSummary.Clear()
            SynoE9.Show()
            Me.Hide()
            'F
            'F
        ElseIf TxtSummary.Text = "F1" Then
            TxtSummary.Clear()
            SynoF1.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F2" Then
            TxtSummary.Clear()
            SynoF2.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F3" Then
            TxtSummary.Clear()
            SynoF3.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F4" Then
            TxtSummary.Clear()
            SynoF4.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F5" Then
            TxtSummary.Clear()
            SynoF5.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F6" Then
            TxtSummary.Clear()
            SynoF6.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F7" Then
            TxtSummary.Clear()
            SynoF7.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F8" Then
            TxtSummary.Clear()
            SynoF8.Show()
            Me.Hide()
        ElseIf TxtSummary.Text = "F9" Then
            TxtSummary.Clear()
            SynoF9.Show()
            Me.Hide()
        Else
            MsgBox("Error:Novel Id is New in The Databased or not in the Databased")
        End If
    End Sub
End Class
