Imports MySql.Data.MySqlClient

Module Routes
    Public server As String = "localhost"
    Public serveruser As String = "root"
    Public password As String = ""
    Public databasename As String = "DelaFuente_bsit-2B_OOP"

    Public con As MySqlConnection = myconn()

    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=" & server & ";user id=" & _
            serveruser & ";password=" & password & ";database=" & databasename & "")


    End Function
    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally

            da.Dispose()
            con.Close()
        End Try
    End Sub
    Public Function rylleInsert(ByVal sql As String) As Boolean
        Dim result As Integer
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Function
End Module
