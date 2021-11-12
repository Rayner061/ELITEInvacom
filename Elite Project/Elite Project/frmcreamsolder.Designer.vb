<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcreamsolder
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btncreamcancel = New System.Windows.Forms.Button()
        Me.txtline = New System.Windows.Forms.TextBox()
        Me.lblissuancetime = New System.Windows.Forms.Label()
        Me.lblmixtime = New System.Windows.Forms.Label()
        Me.lblthawtime = New System.Windows.Forms.Label()
        Me.lblreftime = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btncreamsave = New System.Windows.Forms.Button()
        Me.txtcsinput = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtmodelmatrix = New System.Windows.Forms.TextBox()
        Me.txtdt = New System.Windows.Forms.TextBox()
        Me.framecream = New System.Windows.Forms.GroupBox()
        Me.framecream.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btncreamcancel
        '
        Me.btncreamcancel.Location = New System.Drawing.Point(214, 215)
        Me.btncreamcancel.Name = "btncreamcancel"
        Me.btncreamcancel.Size = New System.Drawing.Size(112, 24)
        Me.btncreamcancel.TabIndex = 26
        Me.btncreamcancel.Text = "&Cancel"
        Me.btncreamcancel.UseVisualStyleBackColor = True
        '
        'txtline
        '
        Me.txtline.Location = New System.Drawing.Point(288, 219)
        Me.txtline.Name = "txtline"
        Me.txtline.Size = New System.Drawing.Size(24, 20)
        Me.txtline.TabIndex = 51
        '
        'lblissuancetime
        '
        Me.lblissuancetime.AutoSize = True
        Me.lblissuancetime.BackColor = System.Drawing.Color.White
        Me.lblissuancetime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissuancetime.Location = New System.Drawing.Point(146, 143)
        Me.lblissuancetime.Name = "lblissuancetime"
        Me.lblissuancetime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblissuancetime.Size = New System.Drawing.Size(13, 20)
        Me.lblissuancetime.TabIndex = 34
        Me.lblissuancetime.Text = " "
        Me.lblissuancetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmixtime
        '
        Me.lblmixtime.AutoSize = True
        Me.lblmixtime.BackColor = System.Drawing.Color.White
        Me.lblmixtime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmixtime.Location = New System.Drawing.Point(146, 176)
        Me.lblmixtime.Name = "lblmixtime"
        Me.lblmixtime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmixtime.Size = New System.Drawing.Size(13, 20)
        Me.lblmixtime.TabIndex = 33
        Me.lblmixtime.Text = " "
        Me.lblmixtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmixtime.Visible = False
        '
        'lblthawtime
        '
        Me.lblthawtime.AutoSize = True
        Me.lblthawtime.BackColor = System.Drawing.Color.White
        Me.lblthawtime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthawtime.Location = New System.Drawing.Point(146, 110)
        Me.lblthawtime.Name = "lblthawtime"
        Me.lblthawtime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblthawtime.Size = New System.Drawing.Size(13, 20)
        Me.lblthawtime.TabIndex = 32
        Me.lblthawtime.Text = " "
        Me.lblthawtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblreftime
        '
        Me.lblreftime.AutoSize = True
        Me.lblreftime.BackColor = System.Drawing.Color.White
        Me.lblreftime.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreftime.Location = New System.Drawing.Point(146, 77)
        Me.lblreftime.Name = "lblreftime"
        Me.lblreftime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblreftime.Size = New System.Drawing.Size(13, 20)
        Me.lblreftime.TabIndex = 31
        Me.lblreftime.Text = " "
        Me.lblreftime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(70, 143)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(70, 20)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Issuance:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(79, 176)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(61, 20)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Mixing:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label23.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(69, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(71, 20)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Thawing:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(105, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(36, 20)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Ref:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncreamsave
        '
        Me.btncreamsave.Location = New System.Drawing.Point(71, 215)
        Me.btncreamsave.Name = "btncreamsave"
        Me.btncreamsave.Size = New System.Drawing.Size(112, 24)
        Me.btncreamsave.TabIndex = 25
        Me.btncreamsave.Text = "&Save"
        Me.btncreamsave.UseVisualStyleBackColor = True
        '
        'txtcsinput
        '
        Me.txtcsinput.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcsinput.Location = New System.Drawing.Point(145, 39)
        Me.txtcsinput.Name = "txtcsinput"
        Me.txtcsinput.Size = New System.Drawing.Size(206, 27)
        Me.txtcsinput.TabIndex = 16
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(35, 46)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(106, 20)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Cream Solder:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmodelmatrix
        '
        Me.txtmodelmatrix.Enabled = False
        Me.txtmodelmatrix.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelmatrix.Location = New System.Drawing.Point(318, 39)
        Me.txtmodelmatrix.Name = "txtmodelmatrix"
        Me.txtmodelmatrix.Size = New System.Drawing.Size(33, 27)
        Me.txtmodelmatrix.TabIndex = 49
        Me.txtmodelmatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdt
        '
        Me.txtdt.Location = New System.Drawing.Point(170, 46)
        Me.txtdt.Name = "txtdt"
        Me.txtdt.Size = New System.Drawing.Size(142, 20)
        Me.txtdt.TabIndex = 50
        '
        'framecream
        '
        Me.framecream.Controls.Add(Me.btncreamcancel)
        Me.framecream.Controls.Add(Me.txtline)
        Me.framecream.Controls.Add(Me.lblissuancetime)
        Me.framecream.Controls.Add(Me.lblmixtime)
        Me.framecream.Controls.Add(Me.lblthawtime)
        Me.framecream.Controls.Add(Me.lblreftime)
        Me.framecream.Controls.Add(Me.Label24)
        Me.framecream.Controls.Add(Me.Label23)
        Me.framecream.Controls.Add(Me.Label22)
        Me.framecream.Controls.Add(Me.Label21)
        Me.framecream.Controls.Add(Me.btncreamsave)
        Me.framecream.Controls.Add(Me.txtcsinput)
        Me.framecream.Controls.Add(Me.Label25)
        Me.framecream.Controls.Add(Me.txtmodelmatrix)
        Me.framecream.Controls.Add(Me.txtdt)
        Me.framecream.Location = New System.Drawing.Point(8, 6)
        Me.framecream.Margin = New System.Windows.Forms.Padding(10)
        Me.framecream.Name = "framecream"
        Me.framecream.Size = New System.Drawing.Size(391, 262)
        Me.framecream.TabIndex = 39
        Me.framecream.TabStop = False
        Me.framecream.Text = "Cream Solder Information"
        '
        'frmcreamsolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 275)
        Me.Controls.Add(Me.framecream)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcreamsolder"
        Me.Text = "frmcreamsolder"
        Me.framecream.ResumeLayout(False)
        Me.framecream.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btncreamcancel As Button
    Friend WithEvents txtline As TextBox
    Friend WithEvents lblissuancetime As Label
    Friend WithEvents lblmixtime As Label
    Friend WithEvents lblthawtime As Label
    Friend WithEvents lblreftime As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btncreamsave As Button
    Friend WithEvents txtcsinput As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtmodelmatrix As TextBox
    Friend WithEvents txtdt As TextBox
    Friend WithEvents framecream As GroupBox
End Class
