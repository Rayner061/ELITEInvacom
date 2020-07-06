<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwash))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblline = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblstation = New System.Windows.Forms.Label()
        Me.lblpcbid = New System.Windows.Forms.Label()
        Me.lblmatrix = New System.Windows.Forms.Label()
        Me.lblrev = New System.Windows.Forms.Label()
        Me.txtmatrix = New System.Windows.Forms.TextBox()
        Me.lblpcbtype = New System.Windows.Forms.Label()
        Me.lblpetname = New System.Windows.Forms.Label()
        Me.lblmodel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.txtscan = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(351, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 20)
        Me.Label19.TabIndex = 178
        Me.Label19.Text = "Line:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 177
        Me.Label12.Text = "User Name:"
        '
        'lblline
        '
        Me.lblline.AutoSize = True
        Me.lblline.BackColor = System.Drawing.Color.Transparent
        Me.lblline.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.Location = New System.Drawing.Point(398, 106)
        Me.lblline.Name = "lblline"
        Me.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblline.Size = New System.Drawing.Size(13, 20)
        Me.lblline.TabIndex = 175
        Me.lblline.Text = " "
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(125, 106)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(0, 20)
        Me.lblname.TabIndex = 174
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.BackColor = System.Drawing.Color.Transparent
        Me.lbldt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(850, 106)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldt.Size = New System.Drawing.Size(13, 20)
        Me.lbldt.TabIndex = 173
        Me.lbldt.Text = " "
        Me.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstation
        '
        Me.lblstation.AutoSize = True
        Me.lblstation.BackColor = System.Drawing.Color.Transparent
        Me.lblstation.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstation.Location = New System.Drawing.Point(617, 106)
        Me.lblstation.Name = "lblstation"
        Me.lblstation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstation.Size = New System.Drawing.Size(13, 20)
        Me.lblstation.TabIndex = 176
        Me.lblstation.Text = " "
        Me.lblstation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpcbid
        '
        Me.lblpcbid.BackColor = System.Drawing.Color.White
        Me.lblpcbid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpcbid.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpcbid.Location = New System.Drawing.Point(697, 232)
        Me.lblpcbid.Name = "lblpcbid"
        Me.lblpcbid.Size = New System.Drawing.Size(134, 26)
        Me.lblpcbid.TabIndex = 212
        '
        'lblmatrix
        '
        Me.lblmatrix.BackColor = System.Drawing.Color.White
        Me.lblmatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmatrix.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatrix.Location = New System.Drawing.Point(697, 198)
        Me.lblmatrix.Name = "lblmatrix"
        Me.lblmatrix.Size = New System.Drawing.Size(134, 26)
        Me.lblmatrix.TabIndex = 211
        '
        'lblrev
        '
        Me.lblrev.BackColor = System.Drawing.Color.White
        Me.lblrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblrev.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrev.Location = New System.Drawing.Point(697, 161)
        Me.lblrev.Name = "lblrev"
        Me.lblrev.Size = New System.Drawing.Size(134, 26)
        Me.lblrev.TabIndex = 209
        '
        'txtmatrix
        '
        Me.txtmatrix.Location = New System.Drawing.Point(795, 164)
        Me.txtmatrix.Name = "txtmatrix"
        Me.txtmatrix.Size = New System.Drawing.Size(27, 20)
        Me.txtmatrix.TabIndex = 210
        '
        'lblpcbtype
        '
        Me.lblpcbtype.BackColor = System.Drawing.Color.White
        Me.lblpcbtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpcbtype.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpcbtype.Location = New System.Drawing.Point(443, 233)
        Me.lblpcbtype.Name = "lblpcbtype"
        Me.lblpcbtype.Size = New System.Drawing.Size(197, 26)
        Me.lblpcbtype.TabIndex = 208
        '
        'lblpetname
        '
        Me.lblpetname.BackColor = System.Drawing.Color.White
        Me.lblpetname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpetname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpetname.Location = New System.Drawing.Point(443, 198)
        Me.lblpetname.Name = "lblpetname"
        Me.lblpetname.Size = New System.Drawing.Size(197, 26)
        Me.lblpetname.TabIndex = 207
        '
        'lblmodel
        '
        Me.lblmodel.BackColor = System.Drawing.Color.White
        Me.lblmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodel.Location = New System.Drawing.Point(443, 161)
        Me.lblmodel.Name = "lblmodel"
        Me.lblmodel.Size = New System.Drawing.Size(197, 26)
        Me.lblmodel.TabIndex = 206
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Rev:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "PCB Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(358, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "PET Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Model:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "PCB ID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(967, 345)
        Me.DataGridView1.TabIndex = 215
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(872, 233)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(112, 24)
        Me.btnlogout.TabIndex = 216
        Me.btnlogout.Text = "&Log Out"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'txtscan
        '
        Me.txtscan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscan.Location = New System.Drawing.Point(97, 161)
        Me.txtscan.Name = "txtscan"
        Me.txtscan.Size = New System.Drawing.Size(251, 25)
        Me.txtscan.TabIndex = 217
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmwash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 689)
        Me.Controls.Add(Me.txtscan)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblpcbid)
        Me.Controls.Add(Me.lblmatrix)
        Me.Controls.Add(Me.lblrev)
        Me.Controls.Add(Me.txtmatrix)
        Me.Controls.Add(Me.lblpcbtype)
        Me.Controls.Add(Me.lblpetname)
        Me.Controls.Add(Me.lblmodel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblline)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblstation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmwash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblline As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbldt As Label
    Friend WithEvents lblstation As Label
    Friend WithEvents lblpcbid As Label
    Friend WithEvents lblmatrix As Label
    Friend WithEvents lblrev As Label
    Friend WithEvents txtmatrix As TextBox
    Friend WithEvents lblpcbtype As Label
    Friend WithEvents lblpetname As Label
    Friend WithEvents lblmodel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnlogout As Button
    Friend WithEvents txtscan As TextBox
    Friend WithEvents Timer1 As Timer
End Class
