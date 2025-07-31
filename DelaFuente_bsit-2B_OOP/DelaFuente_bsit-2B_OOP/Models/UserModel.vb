Imports MySql.Data.MySqlClient

Module UserModel

    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dReader As MySqlDataReader


    Public Sub loadUser(ByVal obj As Object, ByVal param As String)
        Try

            con.Open()
            dReader = cmd.ExecuteReader

            Select Case param

                Case "6"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
                    Loop

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally

            da.Dispose()
            con.Close()
        End Try
    End Sub
End Module
