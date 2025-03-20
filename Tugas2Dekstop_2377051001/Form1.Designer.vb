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
        Me.Npm = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.txtFakultas = New System.Windows.Forms.Label()
        Me.txtJurusan = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtNpm = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkLaki = New System.Windows.Forms.CheckBox()
        Me.chkPerempuan = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.btnGRADE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Npm
        '
        Me.Npm.AutoSize = True
        Me.Npm.Location = New System.Drawing.Point(32, 36)
        Me.Npm.Name = "Npm"
        Me.Npm.Size = New System.Drawing.Size(31, 13)
        Me.Npm.TabIndex = 0
        Me.Npm.Text = "NPM"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(32, 64)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(35, 13)
        Me.Nama.TabIndex = 1
        Me.Nama.Text = "Nama"
        '
        'txtFakultas
        '
        Me.txtFakultas.AutoSize = True
        Me.txtFakultas.Location = New System.Drawing.Point(32, 139)
        Me.txtFakultas.Name = "txtFakultas"
        Me.txtFakultas.Size = New System.Drawing.Size(47, 13)
        Me.txtFakultas.TabIndex = 2
        Me.txtFakultas.Text = "Fakultas"
        '
        'txtJurusan
        '
        Me.txtJurusan.AutoSize = True
        Me.txtJurusan.Location = New System.Drawing.Point(32, 177)
        Me.txtJurusan.Name = "txtJurusan"
        Me.txtJurusan.Size = New System.Drawing.Size(44, 13)
        Me.txtJurusan.TabIndex = 3
        Me.txtJurusan.Text = "Jurusan"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(0, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(128, 36)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(241, 20)
        Me.txtNpm.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(128, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(358, 20)
        Me.txtNama.TabIndex = 7
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Location = New System.Drawing.Point(128, 139)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(241, 21)
        Me.cmbFakultas.TabIndex = 8
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(128, 177)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(269, 21)
        Me.cmbJurusan.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Jenis Kelamin"
        '
        'chkLaki
        '
        Me.chkLaki.AutoSize = True
        Me.chkLaki.Location = New System.Drawing.Point(128, 100)
        Me.chkLaki.Name = "chkLaki"
        Me.chkLaki.Size = New System.Drawing.Size(69, 17)
        Me.chkLaki.TabIndex = 11
        Me.chkLaki.Text = "Laki-Laki"
        Me.chkLaki.UseVisualStyleBackColor = True
        '
        'chkPerempuan
        '
        Me.chkPerempuan.AutoSize = True
        Me.chkPerempuan.Location = New System.Drawing.Point(236, 100)
        Me.chkPerempuan.Name = "chkPerempuan"
        Me.chkPerempuan.Size = New System.Drawing.Size(80, 17)
        Me.chkPerempuan.TabIndex = 12
        Me.chkPerempuan.Text = "Perempuan"
        Me.chkPerempuan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nilai"
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(169, 215)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(66, 20)
        Me.txtTugas.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "UTS"
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(291, 216)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(66, 20)
        Me.txtUTS.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(378, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "UAS"
        '
        'txtUAS
        '
        Me.txtUAS.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUAS.Location = New System.Drawing.Point(420, 217)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(66, 20)
        Me.txtUAS.TabIndex = 18
        '
        'btnGRADE
        '
        Me.btnGRADE.Location = New System.Drawing.Point(515, 217)
        Me.btnGRADE.Name = "btnGRADE"
        Me.btnGRADE.Size = New System.Drawing.Size(75, 23)
        Me.btnGRADE.TabIndex = 24
        Me.btnGRADE.Text = "  -GRADE-"
        Me.btnGRADE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 266)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 44)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(601, 259)
        Me.DataGridView1.TabIndex = 27
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(81, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(162, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(176, 23)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(344, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(250, 23)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 605)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnGRADE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUAS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUTS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkPerempuan)
        Me.Controls.Add(Me.chkLaki)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNpm)
        Me.Controls.Add(Me.txtJurusan)
        Me.Controls.Add(Me.txtFakultas)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Npm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Npm As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents txtFakultas As System.Windows.Forms.Label
    Friend WithEvents txtJurusan As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtNpm As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkLaki As System.Windows.Forms.CheckBox
    Friend WithEvents chkPerempuan As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents btnGRADE As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
