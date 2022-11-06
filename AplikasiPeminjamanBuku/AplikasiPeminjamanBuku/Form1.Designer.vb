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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBPerempuan = New System.Windows.Forms.RadioButton()
        Me.RBLaki = New System.Windows.Forms.RadioButton()
        Me.ComboKelas = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBukuDirektori = New System.Windows.Forms.CheckBox()
        Me.CheckBukuEnsiklopedia = New System.Windows.Forms.CheckBox()
        Me.CheckBukuKamus = New System.Windows.Forms.CheckBox()
        Me.CheckBukuAjar = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnTampilkan = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Peminjaman Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Jenis Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tanggal Pinjam"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(115, 51)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(182, 20)
        Me.TxtNama.TabIndex = 1
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(115, 75)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(182, 20)
        Me.TxtNIM.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBPerempuan)
        Me.GroupBox1.Controls.Add(Me.RBLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Plihan"
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(87, 20)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.RBPerempuan.TabIndex = 0
        Me.RBPerempuan.TabStop = True
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'RBLaki
        '
        Me.RBLaki.AutoSize = True
        Me.RBLaki.Location = New System.Drawing.Point(7, 20)
        Me.RBLaki.Name = "RBLaki"
        Me.RBLaki.Size = New System.Drawing.Size(74, 17)
        Me.RBLaki.TabIndex = 0
        Me.RBLaki.TabStop = True
        Me.RBLaki.Text = "Laki - Laki"
        Me.RBLaki.UseVisualStyleBackColor = True
        '
        'ComboKelas
        '
        Me.ComboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboKelas.FormattingEnabled = True
        Me.ComboKelas.Items.AddRange(New Object() {"TI.19.A.RPL.1", "TI.19.A.RPL.2"})
        Me.ComboKelas.Location = New System.Drawing.Point(115, 153)
        Me.ComboKelas.Name = "ComboKelas"
        Me.ComboKelas.Size = New System.Drawing.Size(182, 21)
        Me.ComboKelas.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBukuDirektori)
        Me.GroupBox2.Controls.Add(Me.CheckBukuEnsiklopedia)
        Me.GroupBox2.Controls.Add(Me.CheckBukuKamus)
        Me.GroupBox2.Controls.Add(Me.CheckBukuAjar)
        Me.GroupBox2.Location = New System.Drawing.Point(115, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 116)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilihan"
        '
        'CheckBukuDirektori
        '
        Me.CheckBukuDirektori.AutoSize = True
        Me.CheckBukuDirektori.Location = New System.Drawing.Point(7, 89)
        Me.CheckBukuDirektori.Name = "CheckBukuDirektori"
        Me.CheckBukuDirektori.Size = New System.Drawing.Size(93, 17)
        Me.CheckBukuDirektori.TabIndex = 0
        Me.CheckBukuDirektori.Text = "Buku Direktori"
        Me.CheckBukuDirektori.UseVisualStyleBackColor = True
        '
        'CheckBukuEnsiklopedia
        '
        Me.CheckBukuEnsiklopedia.AutoSize = True
        Me.CheckBukuEnsiklopedia.Location = New System.Drawing.Point(7, 66)
        Me.CheckBukuEnsiklopedia.Name = "CheckBukuEnsiklopedia"
        Me.CheckBukuEnsiklopedia.Size = New System.Drawing.Size(114, 17)
        Me.CheckBukuEnsiklopedia.TabIndex = 0
        Me.CheckBukuEnsiklopedia.Text = "Buku Ensiklopedia"
        Me.CheckBukuEnsiklopedia.UseVisualStyleBackColor = True
        '
        'CheckBukuKamus
        '
        Me.CheckBukuKamus.AutoSize = True
        Me.CheckBukuKamus.Location = New System.Drawing.Point(7, 43)
        Me.CheckBukuKamus.Name = "CheckBukuKamus"
        Me.CheckBukuKamus.Size = New System.Drawing.Size(86, 17)
        Me.CheckBukuKamus.TabIndex = 0
        Me.CheckBukuKamus.Text = "Buku Kamus"
        Me.CheckBukuKamus.UseVisualStyleBackColor = True
        '
        'CheckBukuAjar
        '
        Me.CheckBukuAjar.AutoSize = True
        Me.CheckBukuAjar.Location = New System.Drawing.Point(7, 20)
        Me.CheckBukuAjar.Name = "CheckBukuAjar"
        Me.CheckBukuAjar.Size = New System.Drawing.Size(72, 17)
        Me.CheckBukuAjar.TabIndex = 0
        Me.CheckBukuAjar.Text = "Buku Ajar"
        Me.CheckBukuAjar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 303)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(182, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.Location = New System.Drawing.Point(105, 371)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.Size = New System.Drawing.Size(103, 48)
        Me.BtnTampilkan.TabIndex = 6
        Me.BtnTampilkan.Text = "Tampilkan"
        Me.BtnTampilkan.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tanggal Batas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pengembalian"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(115, 334)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(182, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 431)
        Me.Controls.Add(Me.BtnTampilkan)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboKelas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Peminjaman Buku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtNIM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RBLaki As System.Windows.Forms.RadioButton
    Friend WithEvents ComboKelas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBukuDirektori As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBukuEnsiklopedia As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBukuKamus As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBukuAjar As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnTampilkan As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker

End Class
