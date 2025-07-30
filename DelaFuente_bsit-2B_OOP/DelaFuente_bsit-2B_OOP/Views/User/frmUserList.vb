Public Class frmUserList

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUserList.CellContentClick

    End Sub

    Private Sub frmUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findthis("SELECT * FROM `tblusers`")
        LoadUser(dgvUserList, "6")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmUserNew.Show()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub
End Class