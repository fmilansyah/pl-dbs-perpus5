Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConn()
        record.Open("select * from tbl_jenis_buku", dbConn, 3, 2)
        Do While Not record.EOF
            cb_jenis_buku.Items.Add(record.Fields("nama_jenis_buku").Value)
            record.MoveNext()
        Loop
        closeConn()
    End Sub

    Private Sub cb_jenis_buku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_jenis_buku.SelectedIndexChanged
        openConn()
        record.Open("select * from tbl_jenis_buku where nama_jenis_buku='" & cb_jenis_buku.SelectedItem & "'", dbConn, 3, 2)
        If Not record.EOF Then
            txt_kd_jenis_buku.Text = record.Fields("kd_jenis_buku").Value
        End If
        closeConn()
    End Sub
End Class
