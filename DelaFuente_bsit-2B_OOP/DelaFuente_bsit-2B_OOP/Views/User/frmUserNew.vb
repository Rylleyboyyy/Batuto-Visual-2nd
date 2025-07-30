Public Class frmUserNew

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.TextChanged
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtPassword.Text = txtConfirmPassword.Text Then
            rylleInsert("INSERT INTO `tblusers` (`NAMEOFUSER`, `USERNAME`, `USERPASSWORD`) VALUES ('" & txtNameofUser.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')")

            With frmUserList
                .dgvUserList.Rows.Clear()
                findUser("SELECT * FROM `tblusers`")
                LoadUser(.dgvUserList, "6")

            End With
            Me.Close()
        Else
            MsgBox("Password does not match")
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmUserNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class