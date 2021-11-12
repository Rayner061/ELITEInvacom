<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbarcodereplace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbarcodereplace))
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstOrig = New System.Windows.Forms.ListBox()
        Me.lstNew = New System.Windows.Forms.ListBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lbldt = New System.Windows.Forms.Label()
        Me.lblcodenew = New System.Windows.Forms.Label()
        Me.lblmodelorig = New System.Windows.Forms.Label()
        Me.lblcodeorig = New System.Windows.Forms.Label()
        Me.lblaccount = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.txtoriginal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblAssemblyVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(414, 476)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 26)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstOrig
        '
        Me.lstOrig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstOrig.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrig.ForeColor = System.Drawing.Color.Red
        Me.lstOrig.FormattingEnabled = True
        Me.lstOrig.Location = New System.Drawing.Point(160, 420)
        Me.lstOrig.Name = "lstOrig"
        Me.lstOrig.Size = New System.Drawing.Size(213, 52)
        Me.lstOrig.TabIndex = 47
        '
        'lstNew
        '
        Me.lstNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNew.ForeColor = System.Drawing.Color.Red
        Me.lstNew.FormattingEnabled = True
        Me.lstNew.Location = New System.Drawing.Point(498, 418)
        Me.lstNew.Name = "lstNew"
        Me.lstNew.Size = New System.Drawing.Size(213, 52)
        Me.lstNew.TabIndex = 46
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(616, 476)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(95, 26)
        Me.btncancel.TabIndex = 45
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(515, 476)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(95, 26)
        Me.btnsave.TabIndex = 44
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'lbldt
        '
        Me.lbldt.BackColor = System.Drawing.Color.Transparent
        Me.lbldt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldt.Location = New System.Drawing.Point(482, 191)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(213, 24)
        Me.lbldt.TabIndex = 43
        '
        'lblcodenew
        '
        Me.lblcodenew.BackColor = System.Drawing.Color.Transparent
        Me.lblcodenew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodenew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodenew.Location = New System.Drawing.Point(498, 344)
        Me.lblcodenew.Name = "lblcodenew"
        Me.lblcodenew.Size = New System.Drawing.Size(213, 24)
        Me.lblcodenew.TabIndex = 41
        '
        'lblmodelorig
        '
        Me.lblmodelorig.BackColor = System.Drawing.Color.Transparent
        Me.lblmodelorig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodelorig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodelorig.Location = New System.Drawing.Point(160, 388)
        Me.lblmodelorig.Name = "lblmodelorig"
        Me.lblmodelorig.Size = New System.Drawing.Size(213, 24)
        Me.lblmodelorig.TabIndex = 40
        '
        'lblcodeorig
        '
        Me.lblcodeorig.BackColor = System.Drawing.Color.Transparent
        Me.lblcodeorig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodeorig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodeorig.Location = New System.Drawing.Point(160, 344)
        Me.lblcodeorig.Name = "lblcodeorig"
        Me.lblcodeorig.Size = New System.Drawing.Size(213, 24)
        Me.lblcodeorig.TabIndex = 39
        '
        'lblaccount
        '
        Me.lblaccount.BackColor = System.Drawing.Color.Transparent
        Me.lblaccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblaccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccount.Location = New System.Drawing.Point(160, 236)
        Me.lblaccount.Name = "lblaccount"
        Me.lblaccount.Size = New System.Drawing.Size(213, 24)
        Me.lblaccount.TabIndex = 38
        '
        'lblname
        '
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(160, 192)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(213, 24)
        Me.lblname.TabIndex = 37
        '
        'txtnew
        '
        Me.txtnew.Enabled = False
        Me.txtnew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnew.Location = New System.Drawing.Point(498, 298)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.Size = New System.Drawing.Size(213, 25)
        Me.txtnew.TabIndex = 36
        '
        'txtoriginal
        '
        Me.txtoriginal.Enabled = False
        Me.txtoriginal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoriginal.Location = New System.Drawing.Point(160, 298)
        Me.txtoriginal.Name = "txtoriginal"
        Me.txtoriginal.Size = New System.Drawing.Size(213, 25)
        Me.txtoriginal.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(393, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Code Allocation:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "New PCB ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Model:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Code Allocation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Original PCB ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Date / Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Account level:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblAssemblyVersion
        '
        Me.lblAssemblyVersion.AutoSize = True
        Me.lblAssemblyVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAssemblyVersion.Location = New System.Drawing.Point(553, 151)
        Me.lblAssemblyVersion.Name = "lblAssemblyVersion"
        Me.lblAssemblyVersion.Size = New System.Drawing.Size(193, 13)
        Me.lblAssemblyVersion.TabIndex = 49
        Me.lblAssemblyVersion.Text = "Version 21.06.253.1  (General Release)"
        '
        'frmbarcodereplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ELITE_GI.My.Resources.Resources.replac
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 554)
        Me.Controls.Add(Me.lblAssemblyVersion)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstOrig)
        Me.Controls.Add(Me.lstNew)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.lblcodenew)
        Me.Controls.Add(Me.lblmodelorig)
        Me.Controls.Add(Me.lblcodeorig)
        Me.Controls.Add(Me.lblaccount)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.txtoriginal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmbarcodereplace"
        Me.Text = "frmbarcodereplace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents lstOrig As ListBox
    Friend WithEvents lstNew As ListBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lbldt As Label
    Friend WithEvents lblcodenew As Label
    Friend WithEvents lblmodelorig As Label
    Friend WithEvents lblcodeorig As Label
    Friend WithEvents lblaccount As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtnew As TextBox
    Friend WithEvents txtoriginal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblAssemblyVersion As Label
End Class
