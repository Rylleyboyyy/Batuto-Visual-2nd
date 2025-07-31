Public Class frmUserNew

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.TextChanged
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If btnSave.Text = "Update" Then
            'For Update
            If txtPassword.Text = txtConfirmPassword.Text Then
                rylleUpdate("UPDATE `tblusers` SET `NAMEOFUSER`='" & txtNameofUser.Text & "', `USERNAME`='" & txtUsername.Text & "', `USERPASSWORD`='" & txtPassword.Text & "', `DATEMODIFIED`='" & Format(Today, "yyyy-MM-dd") & "' WHERE `AUTOID`='" & Me.Text & "'")
                With frmUserList
                    .dgvUserList.Rows.Clear()
                    findUser("SELECT * FROM `tblusers`")
                    LoadUser(.dgvUserList, "6")
                End With
                Me.Close()

            Else
                MsgBox("Password does not match!")

            End If

        Else
            'For Insert


            If txtPassword.Text = txtConfirmPassword.Text Then
                rylleInsert("INSERT INTO `tblusers` (`NAMEOFUSER`, `USERNAME`, `USERPASSWORD`) VALUES ('" & txtNameofUser.Text _
                            & "','" & txtUsername.Text _
                            & "','" & txtPassword.Text & "')")

                With frmUserList
                    .dgvUserList.Rows.Clear()
                    findUser("SELECT * FROM `tblusers`")
                    loadUser(.dgvUserList, "6")

                End With
                Me.Close()
            Else
                MsgBox("Password does not match")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmUserNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class