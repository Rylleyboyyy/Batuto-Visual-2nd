Imports MySql.Data.MySqlClient

Module Routes
    Public server As String = "localhost"
    Public serveruser As String = "root"
    Public password As String = ""
    Public databasename As String = "DelaFuente_bsit-2B_OOP"

    Public con As MySqlConnection = myconn()

    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=" & server & ";user id=" & serveruser & ";password=" & password & ";database=" & databasename & "")


    End Function
    Public Sub findUser(ByVal sql As String)
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
                    MsgBox("No Data Inserted!")
                    Return False
                Else
                    MsgBox("Data Inserted!")
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
    Public Function rylleUpdate(ByVal sql As String) As Boolean
        Dim result As Integer
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("No Data Inserted!")
                    Return False
                Else
                    MsgBox("Data Inserted!")
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
    Public Function rylleDelete(ByVal sql As String) As Boolean
        Dim result As Integer
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("No Data Deleted!")
                    Return False
                Else
                    MsgBox("Data Deleted!")
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
