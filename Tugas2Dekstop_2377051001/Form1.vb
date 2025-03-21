Public Class Form1
    Dim selectedRowIndex As Integer = -1 ' Menyimpan index baris yang dipilih

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Membersihkan ComboBox
        cmbFakultas.Items.Clear()
        cmbJurusan.Items.Clear()

        ' Menambahkan pilihan ke ComboBox
        cmbFakultas.Items.AddRange(New String() {"Fakultas Ekonomi dan Bisnis", "Fakultas Teknik", "Fakultas Kedokteran", "Fakultas Matematika dan Ilmu Pengetahuan Alam"})
        cmbJurusan.Items.AddRange(New String() {"Informatika", "Ilmu Komputer", "Akuntansi", "Manajemen"})

        ' Menyiapkan DataGridView
        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).Name = "NPM"
        DataGridView1.Columns(1).Name = "Nama"
        DataGridView1.Columns(2).Name = "Jenis Kelamin"
        DataGridView1.Columns(3).Name = "Fakultas"
        DataGridView1.Columns(4).Name = "Jurusan"
        DataGridView1.Columns(5).Name = "Nilai Akhir"
        DataGridView1.Columns(6).Name = "Grade"
    End Sub

    ' Perhitungan GRADE otomatis
    Private Sub HitungGrade()
        Dim tugas As Double = Val(txtTugas.Text)
        Dim uts As Double = Val(txtUTS.Text)
        Dim uas As Double = Val(txtUAS.Text)

        ' Hitung nilai akhir
        Dim nilaiAkhir As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)
        Dim grade As String

        ' Tentukan GRADE
        If nilaiAkhir >= 78 And nilaiAkhir <= 90 Then
            grade = "A"
        ElseIf nilaiAkhir >= 65 And nilaiAkhir <= 77 Then
            grade = "B"
        ElseIf nilaiAkhir >= 50 And nilaiAkhir <= 64 Then
            grade = "C"
        ElseIf nilaiAkhir >= 40 And nilaiAkhir <= 49 Then
            grade = "D"
        Else
            grade = "E"
        End If

        ' Update label Grade
        btnGrade.Text = grade
    End Sub

    ' Ketika nilai diubah, hitung ulang Grade
    Private Sub txtTugas_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged, txtUTS.TextChanged, txtUAS.TextChanged
        HitungGrade()
    End Sub

    ' Tombol "New" - Bersihkan form
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNPM.Clear()
        txtNama.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        cmbFakultas.SelectedIndex = -1
        cmbJurusan.SelectedIndex = -1
        rbLakiLaki.Checked = False
        rbPerempuan.Checked = False
        btnGrade.Text = "-"
        txtNPM.Enabled = True
        txtNPM.Focus()
        selectedRowIndex = -1 ' Reset index
    End Sub

    ' Tombol "Save" - Simpan atau Update data
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNPM.Text = "" Or txtNama.Text = "" Or cmbFakultas.Text = "" Or cmbJurusan.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim jenisKelamin As String = If(rbLakiLaki.Checked, "Laki-laki", If(rbPerempuan.Checked, "Perempuan", ""))
        If jenisKelamin = "" Then
            MessageBox.Show("Harap pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek apakah ini update atau insert data baru
        If selectedRowIndex = -1 Then
            ' Tambahkan data baru
            DataGridView1.Rows.Add(txtNPM.Text, txtNama.Text, jenisKelamin, cmbFakultas.Text, cmbJurusan.Text, (Val(txtTugas.Text) * 0.3 + Val(txtUTS.Text) * 0.3 + Val(txtUAS.Text) * 0.4).ToString("0.00"), btnGrade.Text)
        Else
            ' Update data pada baris yang dipilih
            DataGridView1.Rows(selectedRowIndex).SetValues(txtNPM.Text, txtNama.Text, jenisKelamin, cmbFakultas.Text, cmbJurusan.Text, (Val(txtTugas.Text) * 0.3 + Val(txtUTS.Text) * 0.3 + Val(txtUAS.Text) * 0.4).ToString("0.00"), btnGrade.Text)
        End If

        btnNew.PerformClick() ' Bersihkan form setelah menyimpan
    End Sub

    ' Tombol "Delete" - Hapus data terpilih
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedRowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(selectedRowIndex)
                btnNew.PerformClick() ' Bersihkan form
            End If
        Else
            MessageBox.Show("Silakan pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Tombol "Close" - Keluar dari aplikasi
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Event ketika memilih data pada DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtNPM.Text = row.Cells(0).Value.ToString()
            txtNama.Text = row.Cells(1).Value.ToString()
            If row.Cells(2).Value.ToString() = "Laki-laki" Then
                rbLakiLaki.Checked = True
                rbPerempuan.Checked = False
            Else
                rbLakiLaki.Checked = False
                rbPerempuan.Checked = True
            End If
            cmbFakultas.Text = row.Cells(3).Value.ToString()
            cmbJurusan.Text = row.Cells(4).Value.ToString()
            txtTugas.Text = ""
            txtUTS.Text = ""
            txtUAS.Text = ""
            btnGrade.Text = row.Cells(6).Value.ToString()

            txtNPM.Enabled = False ' NPM tidak bisa diubah
        End If
    End Sub

    Private Sub txtNpm_TextChanged(sender As Object, e As EventArgs) Handles txtNpm.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class