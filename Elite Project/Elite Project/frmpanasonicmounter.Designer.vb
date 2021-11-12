<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmpanasonicmounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpanasonicmounter))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgTransfer = New System.ComponentModel.BackgroundWorker()
        Me.lblElapsedlabel = New System.Windows.Forms.Label()
        Me.progressTransfer = New MetroFramework.Controls.MetroProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlinkNotify = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblstation = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblline = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblscan = New System.Windows.Forms.Label()
        Me.lblpalletlast = New System.Windows.Forms.Label()
        Me.txtscan = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblElapsed = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgPCB = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAssemblyVersion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.dgPCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblElapsedlabel
        '
        Me.lblElapsedlabel.AutoSize = True
        Me.lblElapsedlabel.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsedlabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsedlabel.ForeColor = System.Drawing.Color.White
        Me.lblElapsedlabel.Location = New System.Drawing.Point(141, 0)
        Me.lblElapsedlabel.Name = "lblElapsedlabel"
        Me.lblElapsedlabel.Size = New System.Drawing.Size(77, 13)
        Me.lblElapsedlabel.TabIndex = 64
        Me.lblElapsedlabel.Text = "Elapsed Time:"
        Me.lblElapsedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblElapsedlabel.Visible = False
        '
        'progressTransfer
        '
        Me.progressTransfer.Location = New System.Drawing.Point(3, 3)
        Me.progressTransfer.Name = "progressTransfer"
        Me.progressTransfer.Size = New System.Drawing.Size(132, 9)
        Me.progressTransfer.Step = 1
        Me.progressTransfer.Style = MetroFramework.MetroColorStyle.Blue
        Me.progressTransfer.TabIndex = 70
        Me.progressTransfer.Value = 50
        Me.progressTransfer.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1001, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 15)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "emscai manufacturing systems development group"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'tmrBlinkNotify
        '
        Me.tmrBlinkNotify.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(15)
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1284, 701)
        Me.TableLayoutPanel1.TabIndex = 93
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 398.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel9, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1254, 119)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(470, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 92
        Me.PictureBox3.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_50
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.lblname, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnlogout, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbldt, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblstation, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblline, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(15, 136)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1254, 52)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(102, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(25, 52)
        Me.lblname.TabIndex = 51
        Me.lblname.Text = " ..."
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(20, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(20, 0, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 52)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Operator:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnlogout
        '
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnlogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnlogout.Location = New System.Drawing.Point(1117, 15)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(15)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(122, 22)
        Me.btnlogout.TabIndex = 28
        Me.btnlogout.Text = "&Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.BackColor = System.Drawing.Color.Transparent
        Me.lbldt.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbldt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lbldt.Location = New System.Drawing.Point(866, 0)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldt.Size = New System.Drawing.Size(25, 52)
        Me.lbldt.TabIndex = 50
        Me.lbldt.Text = " ..."
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblstation
        '
        Me.lblstation.AutoSize = True
        Me.lblstation.BackColor = System.Drawing.Color.Transparent
        Me.lblstation.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblstation.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblstation.Location = New System.Drawing.Point(627, 0)
        Me.lblstation.Name = "lblstation"
        Me.lblstation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstation.Size = New System.Drawing.Size(25, 52)
        Me.lblstation.TabIndex = 53
        Me.lblstation.Text = " ..."
        Me.lblstation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(341, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 52)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Line:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblline
        '
        Me.lblline.AutoSize = True
        Me.lblline.BackColor = System.Drawing.Color.Transparent
        Me.lblline.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblline.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblline.Location = New System.Drawing.Point(388, 0)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(25, 52)
        Me.lblline.TabIndex = 52
        Me.lblline.Text = " ..."
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel5.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_110
        Me.TableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.lblscan, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblpalletlast, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtscan, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCount, 3, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(15, 345)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1254, 100)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'lblscan
        '
        Me.lblscan.AutoSize = True
        Me.lblscan.BackColor = System.Drawing.Color.Transparent
        Me.lblscan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblscan.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblscan.Location = New System.Drawing.Point(15, 40)
        Me.lblscan.Margin = New System.Windows.Forms.Padding(15, 0, 3, 15)
        Me.lblscan.Name = "lblscan"
        Me.lblscan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblscan.Size = New System.Drawing.Size(160, 45)
        Me.lblscan.TabIndex = 58
        Me.lblscan.Text = "SCAN PANEL:"
        Me.lblscan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpalletlast
        '
        Me.lblpalletlast.AutoSize = True
        Me.lblpalletlast.BackColor = System.Drawing.Color.Transparent
        Me.lblpalletlast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblpalletlast.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpalletlast.ForeColor = System.Drawing.Color.DimGray
        Me.lblpalletlast.Location = New System.Drawing.Point(181, 10)
        Me.lblpalletlast.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblpalletlast.Name = "lblpalletlast"
        Me.lblpalletlast.Size = New System.Drawing.Size(75, 30)
        Me.lblpalletlast.TabIndex = 61
        Me.lblpalletlast.Text = "palletl"
        Me.lblpalletlast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtscan
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.txtscan, 2)
        Me.txtscan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtscan.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscan.Location = New System.Drawing.Point(181, 43)
        Me.txtscan.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtscan.Name = "txtscan"
        Me.txtscan.Size = New System.Drawing.Size(907, 39)
        Me.txtscan.TabIndex = 57
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(1094, 43)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(3, 3, 18, 18)
        Me.lblCount.MinimumSize = New System.Drawing.Size(140, 2)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(142, 39)
        Me.lblCount.TabIndex = 69
        Me.lblCount.Text = "00000"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(15, 665)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1254, 21)
        Me.TableLayoutPanel6.TabIndex = 92
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 5
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.lblElapsed, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lblElapsedlabel, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.progressTransfer, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1248, 15)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'lblElapsed
        '
        Me.lblElapsed.AutoSize = True
        Me.lblElapsed.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsed.ForeColor = System.Drawing.Color.White
        Me.lblElapsed.Location = New System.Drawing.Point(224, 0)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(10, 13)
        Me.lblElapsed.TabIndex = 65
        Me.lblElapsed.Text = " "
        Me.lblElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblElapsed.Visible = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel8.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_214
        Me.TableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.dgPCB, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(15, 465)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1254, 190)
        Me.TableLayoutPanel8.TabIndex = 93
        '
        'dgPCB
        '
        Me.dgPCB.AllowUserToAddRows = False
        Me.dgPCB.AllowUserToDeleteRows = False
        Me.dgPCB.AllowUserToResizeColumns = False
        Me.dgPCB.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver
        Me.dgPCB.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgPCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPCB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgPCB.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPCB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgPCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPCB.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgPCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPCB.GridColor = System.Drawing.Color.White
        Me.dgPCB.Location = New System.Drawing.Point(15, 15)
        Me.dgPCB.Margin = New System.Windows.Forms.Padding(15)
        Me.dgPCB.Name = "dgPCB"
        Me.dgPCB.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPCB.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgPCB.Size = New System.Drawing.Size(1224, 160)
        Me.dgPCB.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "pcbid"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column1.HeaderText = "PCB ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "injectiontime"
        Me.Column2.HeaderText = "Injection Time"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "injectionoperator"
        Me.Column3.HeaderText = "Injection Operator"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "mountertime"
        Me.Column4.HeaderText = "Mounter Time"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "mounteroperator"
        Me.Column5.HeaderText = "Mounter Operator"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_110
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.0!))
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(15, 193)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1254, 110)
        Me.TableLayoutPanel4.TabIndex = 94
        Me.TableLayoutPanel4.Visible = False
        '
        'lblAssemblyVersion
        '
        Me.lblAssemblyVersion.AutoSize = True
        Me.lblAssemblyVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAssemblyVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAssemblyVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssemblyVersion.Location = New System.Drawing.Point(3, 0)
        Me.lblAssemblyVersion.Name = "lblAssemblyVersion"
        Me.lblAssemblyVersion.Size = New System.Drawing.Size(386, 113)
        Me.lblAssemblyVersion.TabIndex = 94
        Me.lblAssemblyVersion.Text = "2.1802.44.2"
        Me.lblAssemblyVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.elite_banner_GI
        Me.TableLayoutPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.lblAssemblyVersion, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(859, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(392, 113)
        Me.TableLayoutPanel9.TabIndex = 95
        '
        'frmpanasonicmounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)
        Me.Name = "frmpanasonicmounter"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        CType(Me.dgPCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnlogout As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblstation As Label
    Friend WithEvents lblline As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents dgPCB As DataGridView
    Friend WithEvents txtscan As TextBox
    Friend WithEvents lblscan As Label
    Friend WithEvents lblpalletlast As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents bgTransfer As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblElapsedlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents progressTransfer As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lblCount As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tmrBlinkNotify As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblElapsed As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblAssemblyVersion As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
End Class
