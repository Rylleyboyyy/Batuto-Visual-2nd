Public Class frmUserNew

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.TextChanged
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        rylleInsert("INSERT INTO `tblusers` (`NAMEOFUSER`, `USERNAME`, `USERPASSWORD`) VALUES ('" & txtNameofUser.Text _
                    & "','" & txtUsername.Text _
                    & "','" & txtPassword.Text & "')")

        With frmUserList
            .dgvUserList.Rows.Clear()
            findthis("SELECT * FROM `tblusers`")
            LoadUser(.dgvUserList, "6")
        End With
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class