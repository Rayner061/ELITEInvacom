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
        Me.btnpcbcancel = New System.Windows.Forms.Button()
        Me.btnpcbsave = New System.Windows.Forms.Button()
        Me.cbxModel = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.framepcb.SuspendLayout()
        Me.SuspendLayout()
        '
        'framepcb
        '
        Me.framepcb.Controls.Add(Me.btnpcbcancel)
        Me.framepcb.Controls.Add(Me.btnpcbsave)
        Me.framepcb.Controls.Add(Me.cbxModel)
        Me.framepcb.Controls.Add(Me.Label15)
        Me.framepcb.Location = New System.Drawing.Point(5, 2)
        Me.framepcb.Name = "framepcb"
        Me.framepcb.Size = New System.Drawing.Size(351, 161)
        Me.framepcb.TabIndex = 39
        Me.framepcb.TabStop = False
        Me.framepcb.Text = "PCB Information"
        '
        'btnpcbcancel
        '
        Me.btnpcbcancel.Location = New System.Drawing.Point(195, 110)
        Me.btnpcbcancel.Name = "btnpcbcancel"
        Me.btnpcbcancel.Size = New System.Drawing.Size(112, 24)
        Me.btnpcbcancel.TabIndex = 26
        Me.btnpcbcancel.Text = "&Cancel"
        Me.btnpcbcancel.UseVisualStyleBackColor = True
        '
        'btnpcbsave
        '
        Me.btnpcbsave.Location = New System.Drawing.Point(50, 110)
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
        Me.cbxModel.Location = New System.Drawing.Point(117, 32)
        Me.cbxModel.Name = "cbxModel"
        Me.cbxModel.Size = New System.Drawing.Size(206, 28)
        Me.cbxModel.TabIndex = 13
        Me.cbxModel.ValueMember = "model"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(57, 20)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Model:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmpcbinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 168)
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
End Class
