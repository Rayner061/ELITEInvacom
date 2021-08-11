<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepairendorsement
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepairendorsement))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblastation = New System.Windows.Forms.Label()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblpending = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblline_top = New System.Windows.Forms.Label()
        Me.btnpending = New System.Windows.Forms.Button()
        Me.btnprocessed = New System.Windows.Forms.Button()
        Me.lblpending2 = New System.Windows.Forms.Label()
        Me.lblprocessed = New System.Windows.Forms.Label()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblline_bot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldefect = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblngdatetime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblcodeallo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblmodel = New System.Windows.Forms.Label()
        Me.lblpcb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblmodel2 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 20)
        Me.Label15.TabIndex = 342
        Me.Label15.Text = "Station :"
        '
        'lblastation
        '
        Me.lblastation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblastation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblastation.Location = New System.Drawing.Point(154, 471)
        Me.lblastation.Name = "lblastation"
        Me.lblastation.Size = New System.Drawing.Size(228, 26)
        Me.lblastation.TabIndex = 343
        Me.lblastation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbllocation
        '
        Me.lbllocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.Location = New System.Drawing.Point(154, 432)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(228, 26)
        Me.lbllocation.TabIndex = 341
        Me.lbllocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 435)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 20)
        Me.Label19.TabIndex = 340
        Me.Label19.Text = "Location:"
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.BackColor = System.Drawing.Color.Transparent
        Me.lbldt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(771, 97)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldt.Size = New System.Drawing.Size(13, 20)
        Me.lbldt.TabIndex = 314
        Me.lbldt.Text = " "
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpending
        '
        Me.lblpending.BackColor = System.Drawing.Color.White
        Me.lblpending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpending.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpending.Location = New System.Drawing.Point(154, 639)
        Me.lblpending.Name = "lblpending"
        Me.lblpending.Size = New System.Drawing.Size(228, 26)
        Me.lblpending.TabIndex = 338
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 642)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 337
        Me.Label13.Text = "Total Pending:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "Line Top:"
        '
        'lblline_top
        '
        Me.lblline_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblline_top.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline_top.Location = New System.Drawing.Point(154, 547)
        Me.lblline_top.Name = "lblline_top"
        Me.lblline_top.Size = New System.Drawing.Size(228, 26)
        Me.lblline_top.TabIndex = 336
        Me.lblline_top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnpending
        '
        Me.btnpending.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpending.Location = New System.Drawing.Point(856, 647)
        Me.btnpending.Name = "btnpending"
        Me.btnpending.Size = New System.Drawing.Size(84, 28)
        Me.btnpending.TabIndex = 334
        Me.btnpending.Text = "Pending:"
        Me.btnpending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpending.UseVisualStyleBackColor = True
        '
        'btnprocessed
        '
        Me.btnprocessed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocessed.Location = New System.Drawing.Point(645, 647)
        Me.btnprocessed.Name = "btnprocessed"
        Me.btnprocessed.Size = New System.Drawing.Size(84, 28)
        Me.btnprocessed.TabIndex = 333
        Me.btnprocessed.Text = "Processed:"
        Me.btnprocessed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprocessed.UseVisualStyleBackColor = True
        '
        'lblpending2
        '
        Me.lblpending2.BackColor = System.Drawing.Color.White
        Me.lblpending2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpending2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpending2.Location = New System.Drawing.Point(950, 648)
        Me.lblpending2.Name = "lblpending2"
        Me.lblpending2.Size = New System.Drawing.Size(107, 26)
        Me.lblpending2.TabIndex = 332
        '
        'lblprocessed
        '
        Me.lblprocessed.BackColor = System.Drawing.Color.White
        Me.lblprocessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprocessed.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprocessed.Location = New System.Drawing.Point(739, 648)
        Me.lblprocessed.Name = "lblprocessed"
        Me.lblprocessed.Size = New System.Drawing.Size(107, 26)
        Me.lblprocessed.TabIndex = 331
        '
        'lblcount
        '
        Me.lblcount.BackColor = System.Drawing.Color.White
        Me.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(528, 648)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(107, 26)
        Me.lblcount.TabIndex = 330
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(422, 651)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 329
        Me.Label14.Text = "No. of Items:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbcategory
        '
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Repair", "MRB", "Hold", "Scrap", "RTS", "IPD"})
        Me.cmbcategory.Location = New System.Drawing.Point(496, 147)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(112, 29)
        Me.cmbcategory.TabIndex = 328
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 327
        Me.Label8.Text = "Category:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1066, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(19, 20)
        Me.Label18.TabIndex = 326
        Me.Label18.Text = "~"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpicker2
        '
        Me.dtpicker2.CustomFormat = "yyyy-MM-dd"
        Me.dtpicker2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpicker2.Location = New System.Drawing.Point(1096, 145)
        Me.dtpicker2.Name = "dtpicker2"
        Me.dtpicker2.Size = New System.Drawing.Size(192, 29)
        Me.dtpicker2.TabIndex = 325
        '
        'dtpicker1
        '
        Me.dtpicker1.CustomFormat = "yyyy-MM-dd"
        Me.dtpicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpicker1.Location = New System.Drawing.Point(866, 145)
        Me.dtpicker1.Name = "dtpicker1"
        Me.dtpicker1.Size = New System.Drawing.Size(190, 29)
        Me.dtpicker1.TabIndex = 323
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(756, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 20)
        Me.Label10.TabIndex = 322
        Me.Label10.Text = "Endorse Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 320
        Me.Label3.Text = "Line Bottom:"
        '
        'lblline_bot
        '
        Me.lblline_bot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblline_bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline_bot.Location = New System.Drawing.Point(154, 509)
        Me.lblline_bot.Name = "lblline_bot"
        Me.lblline_bot.Size = New System.Drawing.Size(228, 26)
        Me.lblline_bot.TabIndex = 321
        Me.lblline_bot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "Defect :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1245, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 317
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbldefect
        '
        Me.lbldefect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldefect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldefect.Location = New System.Drawing.Point(154, 392)
        Me.lbldefect.Name = "lbldefect"
        Me.lbldefect.Size = New System.Drawing.Size(228, 26)
        Me.lbldefect.TabIndex = 319
        Me.lbldefect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 316
        Me.Label12.Text = "User Name:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.White
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(120, 92)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(0, 20)
        Me.lblname.TabIndex = 315
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblngdatetime
        '
        Me.lblngdatetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblngdatetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblngdatetime.Location = New System.Drawing.Point(154, 351)
        Me.lblngdatetime.Name = "lblngdatetime"
        Me.lblngdatetime.Size = New System.Drawing.Size(228, 26)
        Me.lblngdatetime.TabIndex = 310
        Me.lblngdatetime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 20)
        Me.Label11.TabIndex = 309
        Me.Label11.Text = "NG Date Time :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 307
        Me.Label9.Text = "Code Allocation :"
        '
        'lblcodeallo
        '
        Me.lblcodeallo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodeallo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodeallo.Location = New System.Drawing.Point(154, 297)
        Me.lblcodeallo.Name = "lblcodeallo"
        Me.lblcodeallo.Size = New System.Drawing.Size(228, 26)
        Me.lblcodeallo.TabIndex = 306
        Me.lblcodeallo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 305
        Me.Label7.Text = "Model :"
        '
        'lblmodel
        '
        Me.lblmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodel.Location = New System.Drawing.Point(154, 249)
        Me.lblmodel.Name = "lblmodel"
        Me.lblmodel.Size = New System.Drawing.Size(228, 26)
        Me.lblmodel.TabIndex = 304
        Me.lblmodel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpcb
        '
        Me.lblpcb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpcb.Location = New System.Drawing.Point(154, 206)
        Me.lblpcb.Name = "lblpcb"
        Me.lblpcb.Size = New System.Drawing.Size(228, 26)
        Me.lblpcb.TabIndex = 302
        Me.lblpcb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "PCBID :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(420, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(910, 447)
        Me.DataGridView1.TabIndex = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 299
        Me.Label1.Text = "Scan PCB :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(154, 149)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 26)
        Me.TextBox1.TabIndex = 298
        '
        'lblmodel2
        '
        Me.lblmodel2.BackColor = System.Drawing.Color.White
        Me.lblmodel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodel2.Location = New System.Drawing.Point(623, 328)
        Me.lblmodel2.Name = "lblmodel2"
        Me.lblmodel2.Size = New System.Drawing.Size(104, 26)
        Me.lblmodel2.TabIndex = 339
        '
        'btnsearch
        '
        Me.btnsearch.BackgroundImage = CType(resources.GetObject("btnsearch.BackgroundImage"), System.Drawing.Image)
        Me.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsearch.Location = New System.Drawing.Point(1294, 144)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(36, 29)
        Me.btnsearch.TabIndex = 324
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ELITE_GI.My.Resources.Resources.emscai_logo
        Me.PictureBox2.Location = New System.Drawing.Point(18, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(372, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ELITE_GI.My.Resources.Resources.elite_banner_GI
        Me.PictureBox1.Location = New System.Drawing.Point(952, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(386, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 311
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ELITE_GI.My.Resources.Resources.elite_background_GI_50
        Me.PictureBox4.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1326, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 313
        Me.PictureBox4.TabStop = False
        '
        'frmrepairendorsement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 689)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblastation)
        Me.Controls.Add(Me.lbllocation)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblpending)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblline_top)
        Me.Controls.Add(Me.btnpending)
        Me.Controls.Add(Me.btnprocessed)
        Me.Controls.Add(Me.lblpending2)
        Me.Controls.Add(Me.lblprocessed)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpicker2)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dtpicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblline_bot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbldefect)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblngdatetime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblcodeallo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblmodel)
        Me.Controls.Add(Me.lblpcb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblmodel2)
        Me.Name = "frmrepairendorsement"
        Me.Text = "REPAIR ENDORSEMENT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents lblastation As Label
    Friend WithEvents lbllocation As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents lblpending As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblline_top As Label
    Friend WithEvents btnpending As Button
    Friend WithEvents btnprocessed As Button
    Friend WithEvents lblpending2 As Label
    Friend WithEvents lblprocessed As Label
    Friend WithEvents lblcount As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpicker2 As DateTimePicker
    Friend WithEvents btnsearch As Button
    Friend WithEvents dtpicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblline_bot As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbldefect As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblngdatetime As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblcodeallo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblmodel As Label
    Friend WithEvents lblpcb As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblmodel2 As Label
End Class
