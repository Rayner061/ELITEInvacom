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
        Me.cbxProduct = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpcbcancel = New System.Windows.Forms.Button()
        Me.btnpcbsave = New System.Windows.Forms.Button()
        Me.cbxModel = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.framepcb.SuspendLayout()
        Me.SuspendLayout()
        '
        'framepcb
        '
        Me.framepcb.Controls.Add(Me.lblDesc)
        Me.framepcb.Controls.Add(Me.Label3)
        Me.framepcb.Controls.Add(Me.cbxProduct)
        Me.framepcb.Controls.Add(Me.Label2)
        Me.framepcb.Controls.Add(Me.cbxPO)
        Me.framepcb.Controls.Add(Me.Label1)
        Me.framepcb.Controls.Add(Me.btnpcbcancel)
        Me.framepcb.Controls.Add(Me.btnpcbsave)
        Me.framepcb.Controls.Add(Me.cbxModel)
        Me.framepcb.Controls.Add(Me.Label15)
        Me.framepcb.Location = New System.Drawing.Point(5, 2)
        Me.framepcb.Name = "framepcb"
        Me.framepcb.Size = New System.Drawing.Size(375, 217)
        Me.framepcb.TabIndex = 39
        Me.framepcb.TabStop = False
        Me.framepcb.Text = "PCB Information"
        '
        'cbxProduct
        '
        Me.cbxProduct.DisplayMember = "model"
        Me.cbxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProduct.FormattingEnabled = True
        Me.cbxProduct.Items.AddRange(New Object() {"GLOBAL_INVACOM", "GLOBAL_SKYWARE"})
        Me.cbxProduct.Location = New System.Drawing.Point(146, 41)
        Me.cbxProduct.Name = "cbxProduct"
        Me.cbxProduct.Size = New System.Drawing.Size(212, 28)
        Me.cbxProduct.TabIndex = 30
        Me.cbxProduct.ValueMember = "model"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Product:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPO
        '
        Me.cbxPO.DisplayMember = "model"
        Me.cbxPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPO.Enabled = False
        Me.cbxPO.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPO.FormattingEnabled = True
        Me.cbxPO.Location = New System.Drawing.Point(146, 74)
        Me.cbxPO.Name = "cbxPO"
        Me.cbxPO.Size = New System.Drawing.Size(212, 28)
        Me.cbxPO.TabIndex = 28
        Me.cbxPO.ValueMember = "model"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Production Order:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnpcbcancel
        '
        Me.btnpcbcancel.Location = New System.Drawing.Point(213, 174)
        Me.btnpcbcancel.Name = "btnpcbcancel"
        Me.btnpcbcancel.Size = New System.Drawing.Size(112, 24)
        Me.btnpcbcancel.TabIndex = 26
        Me.btnpcbcancel.Text = "&Cancel"
        Me.btnpcbcancel.UseVisualStyleBackColor = True
        '
        'btnpcbsave
        '
        Me.btnpcbsave.Location = New System.Drawing.Point(68, 174)
        Me.btnpcbsave.Name = "btnpcbsave"
        Me.btnpcbsave.Size = New System.Drawing.Size(112, 24)
        Me.btnpcbsave.TabIndex = 25
        Me.btnpcbsave.Text = "&Save"
        Me.btnpcbsave.UseVisualStyleBackColor = True
        '
        'cbxModel
        '
        Me.cbxModel.DisplayMember = "model"
        Me.cbxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModel.FormattingEnabled = True
        Me.cbxModel.Location = New System.Drawing.Point(146, 108)
        Me.cbxModel.Name = "cbxModel"
        Me.cbxModel.Size = New System.Drawing.Size(212, 28)
        Me.cbxModel.TabIndex = 13
        Me.cbxModel.ValueMember = "model"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(89, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Model:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Description :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDesc
        '
        Me.lblDesc.BackColor = System.Drawing.SystemColors.Control
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(142, 142)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDesc.Size = New System.Drawing.Size(216, 20)
        Me.lblDesc.TabIndex = 32
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmpcbinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 225)
        Me.Controls.Add(Me.framepcb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpcbinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PCB Information"
        Me.framepcb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents framepcb As GroupBox
    Friend WithEvents btnpcbcancel As Button
    Friend WithEvents btnpcbsave As Button
    Friend WithEvents cbxModel As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxPO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxProduct As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDesc As Label
End Class
