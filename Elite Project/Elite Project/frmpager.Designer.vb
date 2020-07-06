<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpager))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbpic = New System.Windows.Forms.ComboBox()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcharcount = New System.Windows.Forms.Label()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.lblline = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(292, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 20)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Line:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "User Name:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.White
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(117, 126)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(0, 20)
        Me.lblname.TabIndex = 63
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldt
        '
        Me.lbldt.BackColor = System.Drawing.Color.White
        Me.lbldt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(389, 126)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldt.Size = New System.Drawing.Size(183, 20)
        Me.lbldt.TabIndex = 62
        Me.lbldt.Text = " "
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcategory
        '
        Me.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"Equipment", "Quality", "Process", "System"})
        Me.cmbcategory.Location = New System.Drawing.Point(114, 178)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(172, 25)
        Me.cmbcategory.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "PIC:"
        '
        'cmbpic
        '
        Me.cmbpic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpic.FormattingEnabled = True
        Me.cmbpic.Items.AddRange(New Object() {"Maintenance Personnel", "QA Personnel", "Production Personnel", "MSD Personnel"})
        Me.cmbpic.Location = New System.Drawing.Point(337, 178)
        Me.cmbpic.Name = "cmbpic"
        Me.cmbpic.Size = New System.Drawing.Size(172, 25)
        Me.cmbpic.TabIndex = 71
        '
        'txtremarks
        '
        Me.txtremarks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(114, 214)
        Me.txtremarks.MaxLength = 100
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(395, 89)
        Me.txtremarks.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Details:"
        '
        'lblcharcount
        '
        Me.lblcharcount.AutoSize = True
        Me.lblcharcount.Location = New System.Drawing.Point(111, 315)
        Me.lblcharcount.Name = "lblcharcount"
        Me.lblcharcount.Size = New System.Drawing.Size(0, 13)
        Me.lblcharcount.TabIndex = 74
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(448, 307)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(60, 20)
        Me.btnsend.TabIndex = 75
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'lblline
        '
        Me.lblline.AutoSize = True
        Me.lblline.BackColor = System.Drawing.Color.White
        Me.lblline.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.Location = New System.Drawing.Point(339, 126)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(13, 20)
        Me.lblline.TabIndex = 64
        Me.lblline.Text = " "
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmpager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 361)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.lblcharcount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.cmbpic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblline)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbldt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmpager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMSCAI Production Notifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents cmbcategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbpic As ComboBox
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcharcount As Label
    Friend WithEvents btnsend As Button
    Friend WithEvents lblline As Label
    Friend WithEvents Timer1 As Timer
End Class
