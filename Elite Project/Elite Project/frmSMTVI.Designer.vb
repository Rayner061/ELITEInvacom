<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSMTVI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMTVI))
        Me.btnNG = New System.Windows.Forms.Button()
        Me.btnGOOD = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblcountng = New System.Windows.Forms.Label()
        Me.lblcountgood = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.dgpcb = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.lblScan = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPnlDefect = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbdefectname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxModel = New System.Windows.Forms.ComboBox()
        Me.cbxCodeRev = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodeAllocation = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDT = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblline = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAssemblyVersion = New System.Windows.Forms.Label()
        CType(Me.dgpcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblPnlMain.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.tblPnlDefect.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNG
        '
        Me.btnNG.BackColor = System.Drawing.Color.Red
        Me.btnNG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNG.FlatAppearance.BorderSize = 2
        Me.btnNG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNG.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNG.ForeColor = System.Drawing.Color.White
        Me.btnNG.Location = New System.Drawing.Point(942, 13)
        Me.btnNG.Name = "btnNG"
        Me.btnNG.Size = New System.Drawing.Size(914, 41)
        Me.btnNG.TabIndex = 56
        Me.btnNG.Text = "NG"
        Me.btnNG.UseVisualStyleBackColor = False
        '
        'btnGOOD
        '
        Me.btnGOOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGOOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGOOD.FlatAppearance.BorderSize = 2
        Me.btnGOOD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGOOD.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGOOD.ForeColor = System.Drawing.Color.White
        Me.btnGOOD.Location = New System.Drawing.Point(13, 13)
        Me.btnGOOD.Name = "btnGOOD"
        Me.btnGOOD.Size = New System.Drawing.Size(913, 41)
        Me.btnGOOD.TabIndex = 57
        Me.btnGOOD.Text = "GOOD"
        Me.btnGOOD.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblcountng
        '
        Me.lblcountng.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcountng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblcountng.Font = New System.Drawing.Font("Ubuntu", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountng.ForeColor = System.Drawing.Color.Black
        Me.lblcountng.Location = New System.Drawing.Point(3, 0)
        Me.lblcountng.Name = "lblcountng"
        Me.lblcountng.Size = New System.Drawing.Size(908, 115)
        Me.lblcountng.TabIndex = 74
        Me.lblcountng.Text = "0"
        Me.lblcountng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcountgood
        '
        Me.lblcountgood.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcountgood.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblcountgood.Font = New System.Drawing.Font("Ubuntu", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountgood.ForeColor = System.Drawing.Color.Black
        Me.lblcountgood.Location = New System.Drawing.Point(13, 57)
        Me.lblcountgood.Name = "lblcountgood"
        Me.lblcountgood.Size = New System.Drawing.Size(913, 115)
        Me.lblcountgood.TabIndex = 74
        Me.lblcountgood.Text = "0"
        Me.lblcountgood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'dgpcb
        '
        Me.dgpcb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpcb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgpcb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPnlMain.SetColumnSpan(Me.dgpcb, 3)
        Me.dgpcb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgpcb.Location = New System.Drawing.Point(13, 175)
        Me.dgpcb.Name = "dgpcb"
        Me.dgpcb.Size = New System.Drawing.Size(1843, 94)
        Me.dgpcb.TabIndex = 87
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblPnlMain, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(15)
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1904, 1041)
        Me.TableLayoutPanel1.TabIndex = 95
        '
        'tblPnlMain
        '
        Me.tblPnlMain.BackColor = System.Drawing.Color.Transparent
        Me.tblPnlMain.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_214
        Me.tblPnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblPnlMain.ColumnCount = 3
        Me.tblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlMain.Controls.Add(Me.lblcountgood, 0, 1)
        Me.tblPnlMain.Controls.Add(Me.TableLayoutPanel8, 2, 1)
        Me.tblPnlMain.Controls.Add(Me.btnNG, 2, 0)
        Me.tblPnlMain.Controls.Add(Me.btnGOOD, 0, 0)
        Me.tblPnlMain.Controls.Add(Me.dgpcb, 0, 2)
        Me.tblPnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPnlMain.Location = New System.Drawing.Point(15, 704)
        Me.tblPnlMain.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tblPnlMain.Name = "tblPnlMain"
        Me.tblPnlMain.Padding = New System.Windows.Forms.Padding(10, 10, 15, 15)
        Me.tblPnlMain.RowCount = 3
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblPnlMain.Size = New System.Drawing.Size(1874, 287)
        Me.tblPnlMain.TabIndex = 99
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lblcountng, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(942, 57)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(914, 115)
        Me.TableLayoutPanel8.TabIndex = 148
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_64
        Me.TableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txtScan, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lblScan, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(15, 628)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1874, 70)
        Me.TableLayoutPanel7.TabIndex = 98
        '
        'txtScan
        '
        Me.txtScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScan.Enabled = False
        Me.txtScan.Font = New System.Drawing.Font("Ubuntu Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.Location = New System.Drawing.Point(186, 14)
        Me.txtScan.Margin = New System.Windows.Forms.Padding(3, 14, 20, 12)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(1668, 35)
        Me.txtScan.TabIndex = 152
        '
        'lblScan
        '
        Me.lblScan.AutoSize = True
        Me.lblScan.BackColor = System.Drawing.Color.Transparent
        Me.lblScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScan.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScan.ForeColor = System.Drawing.Color.Black
        Me.lblScan.Location = New System.Drawing.Point(20, 0)
        Me.lblScan.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.lblScan.Name = "lblScan"
        Me.lblScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScan.Size = New System.Drawing.Size(160, 70)
        Me.lblScan.TabIndex = 130
        Me.lblScan.Text = "SCAN PANEL:"
        Me.lblScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_110
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel5.ColumnCount = 10
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.tblPnlDefect, 6, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnlogout, 8, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.cbxModel, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cbxCodeRev, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCodeAllocation, 4, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnSet, 4, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(15, 222)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1874, 110)
        Me.TableLayoutPanel5.TabIndex = 97
        '
        'tblPnlDefect
        '
        Me.tblPnlDefect.ColumnCount = 4
        Me.tblPnlDefect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblPnlDefect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblPnlDefect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tblPnlDefect.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblPnlDefect.Controls.Add(Me.Label4, 1, 1)
        Me.tblPnlDefect.Controls.Add(Me.cmbdefectname, 2, 1)
        Me.tblPnlDefect.Controls.Add(Me.Label5, 1, 2)
        Me.tblPnlDefect.Controls.Add(Me.txtremarks, 2, 2)
        Me.tblPnlDefect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPnlDefect.Location = New System.Drawing.Point(1280, 10)
        Me.tblPnlDefect.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.tblPnlDefect.Name = "tblPnlDefect"
        Me.tblPnlDefect.RowCount = 4
        Me.TableLayoutPanel5.SetRowSpan(Me.tblPnlDefect, 4)
        Me.tblPnlDefect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlDefect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblPnlDefect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblPnlDefect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPnlDefect.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblPnlDefect.Size = New System.Drawing.Size(400, 90)
        Me.tblPnlDefect.TabIndex = 212
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(114, 40)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Defect Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbdefectname
        '
        Me.cmbdefectname.DisplayMember = "model"
        Me.cmbdefectname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbdefectname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdefectname.Enabled = False
        Me.cmbdefectname.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdefectname.FormattingEnabled = True
        Me.cmbdefectname.Location = New System.Drawing.Point(144, 8)
        Me.cmbdefectname.Name = "cmbdefectname"
        Me.cmbdefectname.Size = New System.Drawing.Size(238, 29)
        Me.cmbdefectname.TabIndex = 80
        Me.cmbdefectname.ValueMember = "model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(122, 40)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Loc / Remarks:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremarks
        '
        Me.txtremarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtremarks.Enabled = False
        Me.txtremarks.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(144, 52)
        Me.txtremarks.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(238, 26)
        Me.txtremarks.TabIndex = 81
        '
        'btnlogout
        '
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlogout.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(1747, 57)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 10)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(94, 28)
        Me.btnlogout.TabIndex = 90
        Me.btnlogout.Text = "&Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 40)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Model:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 40)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "Code/Revision:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxModel
        '
        Me.cbxModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModel.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModel.FormattingEnabled = True
        Me.cbxModel.Location = New System.Drawing.Point(200, 20)
        Me.cbxModel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbxModel.Name = "cbxModel"
        Me.cbxModel.Size = New System.Drawing.Size(194, 29)
        Me.cbxModel.TabIndex = 219
        '
        'cbxCodeRev
        '
        Me.cbxCodeRev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCodeRev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCodeRev.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCodeRev.FormattingEnabled = True
        Me.cbxCodeRev.Location = New System.Drawing.Point(200, 60)
        Me.cbxCodeRev.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbxCodeRev.Name = "cbxCodeRev"
        Me.cbxCodeRev.Size = New System.Drawing.Size(194, 29)
        Me.cbxCodeRev.TabIndex = 220
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 40)
        Me.Label7.TabIndex = 226
        Me.Label7.Text = "Code Allocation:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodeAllocation
        '
        Me.lblCodeAllocation.AutoSize = True
        Me.lblCodeAllocation.BackColor = System.Drawing.Color.Transparent
        Me.lblCodeAllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodeAllocation.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeAllocation.Location = New System.Drawing.Point(557, 15)
        Me.lblCodeAllocation.Name = "lblCodeAllocation"
        Me.lblCodeAllocation.Size = New System.Drawing.Size(144, 40)
        Me.lblCodeAllocation.TabIndex = 227
        Me.lblCodeAllocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSet
        '
        Me.btnSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSet.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.Location = New System.Drawing.Point(559, 59)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(5, 4, 5, 5)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(140, 31)
        Me.btnSet.TabIndex = 228
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_50
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblname, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblStation, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblDT, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PictureBox3, 6, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblline, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(15, 145)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1874, 52)
        Me.TableLayoutPanel4.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 52)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Operator:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblname.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(110, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(25, 52)
        Me.lblname.TabIndex = 123
        Me.lblname.Text = "..."
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 52)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Line:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.BackColor = System.Drawing.Color.Transparent
        Me.lblStation.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStation.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStation.Location = New System.Drawing.Point(990, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStation.Size = New System.Drawing.Size(65, 52)
        Me.lblStation.TabIndex = 125
        Me.lblStation.Text = "Station"
        Me.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDT
        '
        Me.lblDT.AutoSize = True
        Me.lblDT.BackColor = System.Drawing.Color.Transparent
        Me.lblDT.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDT.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDT.Location = New System.Drawing.Point(1404, 0)
        Me.lblDT.Name = "lblDT"
        Me.lblDT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDT.Size = New System.Drawing.Size(25, 52)
        Me.lblDT.TabIndex = 122
        Me.lblDT.Text = "..."
        Me.lblDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1818, 12)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 12, 12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 206
        Me.PictureBox3.TabStop = False
        '
        'lblline
        '
        Me.lblline.AutoSize = True
        Me.lblline.BackColor = System.Drawing.Color.Transparent
        Me.lblline.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblline.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.Location = New System.Drawing.Point(576, 0)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(25, 52)
        Me.lblline.TabIndex = 124
        Me.lblline.Text = "..."
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1874, 119)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ELITE_GI.My.Resources.Resources.emscai_logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(470, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_banner_GI
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblAssemblyVersion, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1476, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(398, 119)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblAssemblyVersion
        '
        Me.lblAssemblyVersion.AutoSize = True
        Me.lblAssemblyVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAssemblyVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAssemblyVersion.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssemblyVersion.Location = New System.Drawing.Point(13, 0)
        Me.lblAssemblyVersion.Name = "lblAssemblyVersion"
        Me.lblAssemblyVersion.Size = New System.Drawing.Size(382, 119)
        Me.lblAssemblyVersion.TabIndex = 1
        Me.lblAssemblyVersion.Text = "2.1802.44.2"
        Me.lblAssemblyVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmSMTVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSMTVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AOI Scanning Station"
        CType(Me.dgpcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblPnlMain.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.tblPnlDefect.ResumeLayout(False)
        Me.tblPnlDefect.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNG As Button
    Friend WithEvents btnGOOD As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblcountng As Label
    Friend WithEvents lblcountgood As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents dgpcb As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblAssemblyVersion As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblDT As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblline As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents tblPnlDefect As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbdefectname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents btnlogout As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents txtScan As TextBox
    Friend WithEvents lblScan As Label
    Friend WithEvents tblPnlMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxModel As ComboBox
    Friend WithEvents cbxCodeRev As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodeAllocation As Label
    Friend WithEvents btnSet As Button
End Class
