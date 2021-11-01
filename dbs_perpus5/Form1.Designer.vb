<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kd_buku = New System.Windows.Forms.TextBox()
        Me.txt_nama_buku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pengarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_penerbit = New System.Windows.Forms.TextBox()
        Me.txt_jml_buku = New System.Windows.Forms.TextBox()
        Me.cb_jenis_buku = New System.Windows.Forms.ComboBox()
        Me.txt_kd_jenis_buku = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'txt_kd_buku
        '
        Me.txt_kd_buku.Location = New System.Drawing.Point(117, 12)
        Me.txt_kd_buku.MaxLength = 2
        Me.txt_kd_buku.Name = "txt_kd_buku"
        Me.txt_kd_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_kd_buku.TabIndex = 1
        '
        'txt_nama_buku
        '
        Me.txt_nama_buku.Location = New System.Drawing.Point(117, 41)
        Me.txt_nama_buku.Name = "txt_nama_buku"
        Me.txt_nama_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_nama_buku.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Buku"
        '
        'txt_pengarang
        '
        Me.txt_pengarang.Location = New System.Drawing.Point(117, 128)
        Me.txt_pengarang.Name = "txt_pengarang"
        Me.txt_pengarang.Size = New System.Drawing.Size(200, 23)
        Me.txt_pengarang.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pengarang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah Buku"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(242, 215)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 12
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_penerbit
        '
        Me.txt_penerbit.Location = New System.Drawing.Point(117, 157)
        Me.txt_penerbit.Name = "txt_penerbit"
        Me.txt_penerbit.Size = New System.Drawing.Size(200, 23)
        Me.txt_penerbit.TabIndex = 13
        '
        'txt_jml_buku
        '
        Me.txt_jml_buku.Location = New System.Drawing.Point(117, 186)
        Me.txt_jml_buku.MaxLength = 2
        Me.txt_jml_buku.Name = "txt_jml_buku"
        Me.txt_jml_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_jml_buku.TabIndex = 14
        '
        'cb_jenis_buku
        '
        Me.cb_jenis_buku.FormattingEnabled = True
        Me.cb_jenis_buku.Location = New System.Drawing.Point(117, 70)
        Me.cb_jenis_buku.Name = "cb_jenis_buku"
        Me.cb_jenis_buku.Size = New System.Drawing.Size(200, 23)
        Me.cb_jenis_buku.TabIndex = 15
        '
        'txt_kd_jenis_buku
        '
        Me.txt_kd_jenis_buku.Location = New System.Drawing.Point(117, 99)
        Me.txt_kd_jenis_buku.Name = "txt_kd_jenis_buku"
        Me.txt_kd_jenis_buku.ReadOnly = True
        Me.txt_kd_jenis_buku.Size = New System.Drawing.Size(200, 23)
        Me.txt_kd_jenis_buku.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kode Jenis Buku"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 269)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_kd_jenis_buku)
        Me.Controls.Add(Me.cb_jenis_buku)
        Me.Controls.Add(Me.txt_jml_buku)
        Me.Controls.Add(Me.txt_penerbit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_pengarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nama_buku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kd_buku)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kd_buku As TextBox
    Friend WithEvents txt_nama_buku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pengarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents txt_penerbit As TextBox
    Friend WithEvents txt_jml_buku As TextBox
    Friend WithEvents cb_jenis_buku As ComboBox
    Friend WithEvents txt_kd_jenis_buku As TextBox
    Friend WithEvents Label7 As Label
End Class
