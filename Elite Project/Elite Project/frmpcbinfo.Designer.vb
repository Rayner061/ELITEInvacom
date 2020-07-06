<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpcbinfo
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
        Me.framepcb = New System.Windows.Forms.GroupBox()
        Me.txtremain = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblosp = New System.Windows.Forms.Label()
        Me.cmbmaker = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpwblot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpcbcancel = New System.Windows.Forms.Button()
        Me.btnpcbsave = New System.Windows.Forms.Button()
        Me.cmbpcbtype = New System.Windows.Forms.ComboBox()
        Me.cmbpetname = New System.Windows.Forms.ComboBox()
        Me.cmbmodel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtinputrev = New System.Windows.Forms.ComboBox()
        Me.framepcb.SuspendLayout()
        Me.SuspendLayout()
        '
        'framepcb
        '
        Me.framepcb.Controls.Add(Me.txtinputrev)
        Me.framepcb.Controls.Add(Me.txtremain)
        Me.framepcb.Controls.Add(Me.Label3)
        Me.framepcb.Controls.Add(Me.DateTimePicker1)
        Me.framepcb.Controls.Add(Me.lblosp)
        Me.framepcb.Controls.Add(Me.cmbmaker)
        Me.framepcb.Controls.Add(Me.Label2)
        Me.framepcb.Controls.Add(Me.txtpwblot)
        Me.framepcb.Controls.Add(Me.Label1)
        Me.framepcb.Controls.Add(Me.btnpcbcancel)
        Me.framepcb.Controls.Add(Me.btnpcbsave)
        Me.framepcb.Controls.Add(Me.cmbpcbtype)
        Me.framepcb.Controls.Add(Me.cmbpetname)
        Me.framepcb.Controls.Add(Me.cmbmodel)
        Me.framepcb.Controls.Add(Me.Label12)
        Me.framepcb.Controls.Add(Me.Label13)
        Me.framepcb.Controls.Add(Me.Label14)
        Me.framepcb.Controls.Add(Me.Label15)
        Me.framepcb.Location = New System.Drawing.Point(1, 1)
        Me.framepcb.Name = "framepcb"
        Me.framepcb.Size = New System.Drawing.Size(361, 370)
        Me.framepcb.TabIndex = 39
        Me.framepcb.TabStop = False
        Me.framepcb.Text = "PCB Information"
        '
        'txtremain
        '
        Me.txtremain.Enabled = False
        Me.txtremain.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremain.Location = New System.Drawing.Point(141, 285)
        Me.txtremain.Name = "txtremain"
        Me.txtremain.Size = New System.Drawing.Size(206, 27)
        Me.txtremain.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Remaining Days:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 25)
        Me.DateTimePicker1.TabIndex = 32
        '
        'lblosp
        '
        Me.lblosp.BackColor = System.Drawing.SystemColors.Control
        Me.lblosp.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblosp.Location = New System.Drawing.Point(24, 251)
        Me.lblosp.Name = "lblosp"
        Me.lblosp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblosp.Size = New System.Drawing.Size(111, 20)
        Me.lblosp.TabIndex = 31
        Me.lblosp.Text = "Finishing Date:"
        Me.lblosp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbmaker
        '
        Me.cmbmaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmaker.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmaker.FormattingEnabled = True
        Me.cmbmaker.Items.AddRange(New Object() {"APEX", "MEIKO", "TRIPOD"})
        Me.cmbmaker.Location = New System.Drawing.Point(141, 212)
        Me.cmbmaker.Name = "cmbmaker"
        Me.cmbmaker.Size = New System.Drawing.Size(206, 28)
        Me.cmbmaker.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "PWB Maker:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtpwblot
        '
        Me.txtpwblot.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwblot.Location = New System.Drawing.Point(141, 175)
        Me.txtpwblot.Name = "txtpwblot"
        Me.txtpwblot.Size = New System.Drawing.Size(206, 27)
        Me.txtpwblot.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "PWB Lot No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnpcbcancel
        '
        Me.btnpcbcancel.Location = New System.Drawing.Point(196, 335)
        Me.btnpcbcancel.Name = "btnpcbcancel"
        Me.btnpcbcancel.Size = New System.Drawing.Size(112, 24)
        Me.btnpcbcancel.TabIndex = 26
        Me.btnpcbcancel.Text = "&Cancel"
        Me.btnpcbcancel.UseVisualStyleBackColor = True
        '
        'btnpcbsave
        '
        Me.btnpcbsave.Location = New System.Drawing.Point(53, 335)
        Me.btnpcbsave.Name = "btnpcbsave"
        Me.btnpcbsave.Size = New System.Drawing.Size(112, 24)
        Me.btnpcbsave.TabIndex = 25
        Me.btnpcbsave.Text = "&Save"
        Me.btnpcbsave.UseVisualStyleBackColor = True
        '
        'cmbpcbtype
        '
        Me.cmbpcbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpcbtype.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpcbtype.FormattingEnabled = True
        Me.cmbpcbtype.Location = New System.Drawing.Point(141, 100)
        Me.cmbpcbtype.Name = "cmbpcbtype"
        Me.cmbpcbtype.Size = New System.Drawing.Size(206, 28)
        Me.cmbpcbtype.TabIndex = 15
        '
        'cmbpetname
        '
        Me.cmbpetname.DisplayMember = "petname"
        Me.cmbpetname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpetname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpetname.FormattingEnabled = True
        Me.cmbpetname.Location = New System.Drawing.Point(141, 62)
        Me.cmbpetname.Name = "cmbpetname"
        Me.cmbpetname.Size = New System.Drawing.Size(206, 28)
        Me.cmbpetname.TabIndex = 14
        Me.cmbpetname.ValueMember = "petname"
        '
        'cmbmodel
        '
        Me.cmbmodel.DisplayMember = "model"
        Me.cmbmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmodel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmodel.FormattingEnabled = True
        Me.cmbmodel.Location = New System.Drawing.Point(141, 24)
        Me.cmbmodel.Name = "cmbmodel"
        Me.cmbmodel.Size = New System.Drawing.Size(206, 28)
        Me.cmbmodel.TabIndex = 13
        Me.cmbmodel.ValueMember = "model"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(95, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Group / Rev:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(59, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "PCB Type:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(52, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "PET Name:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(78, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Model:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtinputrev
        '
        Me.txtinputrev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtinputrev.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputrev.FormattingEnabled = True
        Me.txtinputrev.Location = New System.Drawing.Point(141, 137)
        Me.txtinputrev.Name = "txtinputrev"
        Me.txtinputrev.Size = New System.Drawing.Size(206, 28)
        Me.txtinputrev.TabIndex = 35
        '
        'frmpcbinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 377)
        Me.Controls.Add(Me.framepcb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpcbinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCB Information"
        Me.framepcb.ResumeLayout(False)
        Me.framepcb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents framepcb As GroupBox
    Friend WithEvents btnpcbcancel As Button
    Friend WithEvents btnpcbsave As Button
    Friend WithEvents cmbpcbtype As ComboBox
    Friend WithEvents cmbpetname As ComboBox
    Friend WithEvents cmbmodel As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtpwblot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblosp As Label
    Friend WithEvents cmbmaker As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtremain As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtinputrev As ComboBox
End Class
