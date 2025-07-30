Public Class frmUserList

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserList.CellContentClick

    End Sub

    Private Sub frmUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findUser("SELECT * FROM `tblusers`")
        LoadUser(dgvUserList, "6")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmUserNew.Show()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        With frmUserNew
            .Text = dgvUserList.CurrentRow.Cells(0).Value
            .txtNameofUser.Text = dgvUserList.CurrentRow.Cells(1).Value
            .txtUsername.Text = dgvUserList.CurrentRow.Cells(2).Value
            .txtPassword.Text = dgvUserList.CurrentRow.Cells(3).Value
            .txtConfirmPassword.Text = dgvUserList.CurrentRow.Cells(3).Value
            .Show()
        End With
    End Sub
End Class