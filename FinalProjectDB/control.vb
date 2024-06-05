Imports System.Data.OleDb
Public Class control
    'Create Connetion
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
                                          "Data Source=Alfaro FD(Premils)#1.accdb;")
    'DB command
    Private DbCmd As OleDbCommand
    'Db Data
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    'Query Parameter
    Public Para As New List(Of OleDbParameter)
    'Query Statistic
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'Reset Query 
        RecordCount = 0
        Exception = ""
        Try
            'open A connection
            DBCon.Open()
            'Create Db Command
            DbCmd = New OleDbCommand(Query, DBCon)
            'load Parameter
            Para.ForEach(Sub(a) DbCmd.Parameters.Add(a))
            'Clear List
            Para.Clear()
            'Execute Command & Fill Datatable
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DbCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try
        'Close the Connection
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub
    'Include Query & Command Parameter
    Public Sub AddPara(Name As String, Value As Object)
        Dim NewPara As New OleDbParameter(Name, Value)
        Para.Add(NewPara)
    End Sub
End Class
