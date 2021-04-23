<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFVI
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFVI))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblPnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lblcountgood = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblcountng = New System.Windows.Forms.Label()
        Me.btnNG = New System.Windows.Forms.Button()
        Me.btnGOOD = New System.Windows.Forms.Button()
        Me.dgpcb = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtScan = New System.Windows.Forms.TextBox()
        Me.lblScan = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxBU = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tblPnlDefect = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbdefectname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lblCodeDesignation = New System.Windows.Forms.Label()
        Me.lblCodeAllocation = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.cbxModel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblPnlMain.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.dgpcb, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Timer1
        '
        Me.Timer1.Interval = 1000
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1370, 749)
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
        Me.tblPnlMain.Location = New System.Drawing.Point(15, 438)
        Me.tblPnlMain.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.tblPnlMain.Name = "tblPnlMain"
        Me.tblPnlMain.Padding = New System.Windows.Forms.Padding(10, 10, 15, 15)
        Me.tblPnlMain.RowCount = 3
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tblPnlMain.Size = New System.Drawing.Size(1340, 287)
        Me.tblPnlMain.TabIndex = 99
        '
        'lblcountgood
        '
        Me.lblcountgood.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcountgood.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblcountgood.Font = New System.Drawing.Font("Microsoft Sans Serif", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountgood.ForeColor = System.Drawing.Color.Black
        Me.lblcountgood.Location = New System.Drawing.Point(13, 57)
        Me.lblcountgood.Name = "lblcountgood"
        Me.lblcountgood.Size = New System.Drawing.Size(646, 115)
        Me.lblcountgood.TabIndex = 74
        Me.lblcountgood.Text = "0"
        Me.lblcountgood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(675, 57)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(647, 115)
        Me.TableLayoutPanel8.TabIndex = 148
        '
        'lblcountng
        '
        Me.lblcountng.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcountng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblcountng.Font = New System.Drawing.Font("Microsoft Sans Serif", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountng.ForeColor = System.Drawing.Color.Black
        Me.lblcountng.Location = New System.Drawing.Point(0, 0)
        Me.lblcountng.Margin = New System.Windows.Forms.Padding(0)
        Me.lblcountng.Name = "lblcountng"
        Me.lblcountng.Size = New System.Drawing.Size(647, 115)
        Me.lblcountng.TabIndex = 74
        Me.lblcountng.Text = "0"
        Me.lblcountng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNG
        '
        Me.btnNG.BackColor = System.Drawing.Color.Red
        Me.btnNG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNG.FlatAppearance.BorderSize = 2
        Me.btnNG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNG.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNG.ForeColor = System.Drawing.Color.White
        Me.btnNG.Location = New System.Drawing.Point(675, 13)
        Me.btnNG.Name = "btnNG"
        Me.btnNG.Size = New System.Drawing.Size(647, 41)
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
        Me.btnGOOD.Size = New System.Drawing.Size(646, 41)
        Me.btnGOOD.TabIndex = 57
        Me.btnGOOD.Text = "GOOD"
        Me.btnGOOD.UseVisualStyleBackColor = False
        '
        'dgpcb
        '
        Me.dgpcb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpcb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgpcb.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgpcb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPnlMain.SetColumnSpan(Me.dgpcb, 3)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpcb.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgpcb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgpcb.Location = New System.Drawing.Point(13, 175)
        Me.dgpcb.Name = "dgpcb"
        Me.dgpcb.Size = New System.Drawing.Size(1309, 94)
        Me.dgpcb.TabIndex = 87
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
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(15, 365)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1340, 70)
        Me.TableLayoutPanel7.TabIndex = 98
        '
        'txtScan
        '
        Me.txtScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScan.Enabled = False
        Me.txtScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScan.Location = New System.Drawing.Point(166, 14)
        Me.txtScan.Margin = New System.Windows.Forms.Padding(3, 14, 20, 12)
        Me.txtScan.Name = "txtScan"
        Me.txtScan.Size = New System.Drawing.Size(1154, 35)
        Me.txtScan.TabIndex = 152
        '
        'lblScan
        '
        Me.lblScan.AutoSize = True
        Me.lblScan.BackColor = System.Drawing.Color.Transparent
        Me.lblScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblScan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblScan.Location = New System.Drawing.Point(20, 0)
        Me.lblScan.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.lblScan.Name = "lblScan"
        Me.lblScan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScan.Size = New System.Drawing.Size(140, 70)
        Me.lblScan.TabIndex = 130
        Me.lblScan.Text = "SCAN PCB:"
        Me.lblScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_110
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel5.ColumnCount = 13
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cbxBU, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.tblPnlDefect, 8, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnlogout, 10, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCodeDesignation, 5, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCodeAllocation, 6, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnSet, 6, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.cbxModel, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(15, 193)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1340, 110)
        Me.TableLayoutPanel5.TabIndex = 97
        '
        'cbxBU
        '
        Me.cbxBU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxBU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbxBU.FormattingEnabled = True
        Me.cbxBU.Items.AddRange(New Object() {"GLOBAL_SKYWARE", "GLOBAL_INVACOM"})
        Me.cbxBU.Location = New System.Drawing.Point(88, 20)
        Me.cbxBU.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbxBU.Name = "cbxBU"
        Me.cbxBU.Size = New System.Drawing.Size(194, 28)
        Me.cbxBU.TabIndex = 224
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 40)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "BU: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.tblPnlDefect.Location = New System.Drawing.Point(816, 10)
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
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(26, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(119, 40)
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
        Me.cmbdefectname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdefectname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cmbdefectname.FormattingEnabled = True
        Me.cmbdefectname.Location = New System.Drawing.Point(151, 8)
        Me.cmbdefectname.Name = "cmbdefectname"
        Me.cmbdefectname.Size = New System.Drawing.Size(232, 28)
        Me.cmbdefectname.TabIndex = 80
        Me.cmbdefectname.ValueMember = "model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(129, 40)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Loc / Remarks:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtremarks
        '
        Me.txtremarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtremarks.Enabled = False
        Me.txtremarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.txtremarks.Location = New System.Drawing.Point(151, 52)
        Me.txtremarks.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(232, 26)
        Me.txtremarks.TabIndex = 81
        '
        'btnlogout
        '
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(1219, 57)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 10)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(103, 28)
        Me.btnlogout.TabIndex = 90
        Me.btnlogout.Text = "&Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'lblCodeDesignation
        '
        Me.lblCodeDesignation.AutoSize = True
        Me.lblCodeDesignation.BackColor = System.Drawing.Color.Transparent
        Me.lblCodeDesignation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodeDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeDesignation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblCodeDesignation.Location = New System.Drawing.Point(457, 15)
        Me.lblCodeDesignation.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.lblCodeDesignation.Name = "lblCodeDesignation"
        Me.lblCodeDesignation.Size = New System.Drawing.Size(157, 40)
        Me.lblCodeDesignation.TabIndex = 220
        Me.lblCodeDesignation.Text = "Code Designation:"
        Me.lblCodeDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodeAllocation
        '
        Me.lblCodeAllocation.AutoSize = True
        Me.lblCodeAllocation.BackColor = System.Drawing.Color.Transparent
        Me.lblCodeAllocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodeAllocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCodeAllocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblCodeAllocation.Location = New System.Drawing.Point(620, 15)
        Me.lblCodeAllocation.Name = "lblCodeAllocation"
        Me.lblCodeAllocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodeAllocation.Size = New System.Drawing.Size(192, 40)
        Me.lblCodeAllocation.TabIndex = 221
        Me.lblCodeAllocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSet
        '
        Me.btnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSet.Location = New System.Drawing.Point(622, 59)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(5, 4, 5, 5)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(140, 31)
        Me.btnSet.TabIndex = 222
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'cbxModel
        '
        Me.cbxModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.cbxModel.FormattingEnabled = True
        Me.cbxModel.Location = New System.Drawing.Point(88, 60)
        Me.cbxModel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.cbxModel.Name = "cbxModel"
        Me.cbxModel.Size = New System.Drawing.Size(194, 28)
        Me.cbxModel.TabIndex = 218
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 40)
        Me.Label2.TabIndex = 214
        Me.Label2.Text = "Model:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(15, 136)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1340, 52)
        Me.TableLayoutPanel4.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 52)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Operator:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(111, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(24, 52)
        Me.lblname.TabIndex = 123
        Me.lblname.Text = "..."
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(390, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 52)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Line:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.BackColor = System.Drawing.Color.Transparent
        Me.lblStation.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblStation.Location = New System.Drawing.Point(723, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStation.Size = New System.Drawing.Size(67, 52)
        Me.lblStation.TabIndex = 125
        Me.lblStation.Text = "Station"
        Me.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDT
        '
        Me.lblDT.AutoSize = True
        Me.lblDT.BackColor = System.Drawing.Color.Transparent
        Me.lblDT.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblDT.Location = New System.Drawing.Point(1002, 0)
        Me.lblDT.Name = "lblDT"
        Me.lblDT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDT.Size = New System.Drawing.Size(24, 52)
        Me.lblDT.TabIndex = 122
        Me.lblDT.Text = "..."
        Me.lblDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1281, 12)
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
        Me.lblline.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblline.Location = New System.Drawing.Point(444, 0)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(24, 52)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1340, 119)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
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
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblAssemblyVersion, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(942, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
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
        Me.lblAssemblyVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssemblyVersion.Location = New System.Drawing.Point(3, 0)
        Me.lblAssemblyVersion.Name = "lblAssemblyVersion"
        Me.lblAssemblyVersion.Size = New System.Drawing.Size(392, 119)
        Me.lblAssemblyVersion.TabIndex = 1
        Me.lblAssemblyVersion.Text = "2.1802.44.2"
        Me.lblAssemblyVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmFVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmFVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FVI"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblPnlMain.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.dgpcb, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbxModel As ComboBox
    Friend WithEvents lblCodeDesignation As Label
    Friend WithEvents lblCodeAllocation As Label
    Friend WithEvents btnSet As Button
    Friend WithEvents cbxBU As ComboBox
    Friend WithEvents Label6 As Label
End Class
