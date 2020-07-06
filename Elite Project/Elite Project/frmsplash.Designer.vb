<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsplash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox_PngSource = New System.Windows.Forms.PictureBox()
        Me.PictureBox_SplashImage = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_PngSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'PictureBox_PngSource
        '
        Me.PictureBox_PngSource.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox_PngSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox_PngSource.Image = Global.ELITE_GI.My.Resources.Resources.elite_gi_splash
        Me.PictureBox_PngSource.Location = New System.Drawing.Point(402, 29)
        Me.PictureBox_PngSource.Name = "PictureBox_PngSource"
        Me.PictureBox_PngSource.Size = New System.Drawing.Size(512, 380)
        Me.PictureBox_PngSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_PngSource.TabIndex = 1
        Me.PictureBox_PngSource.TabStop = False
        '
        'PictureBox_SplashImage
        '
        Me.PictureBox_SplashImage.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_SplashImage.Name = "PictureBox_SplashImage"
        Me.PictureBox_SplashImage.Size = New System.Drawing.Size(380, 380)
        Me.PictureBox_SplashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_SplashImage.TabIndex = 2
        Me.PictureBox_SplashImage.TabStop = False
        '
        'frmsplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1258, 449)
        Me.Controls.Add(Me.PictureBox_SplashImage)
        Me.Controls.Add(Me.PictureBox_PngSource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsplash"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox_PngSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_SplashImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox_PngSource As PictureBox
    Friend WithEvents PictureBox_SplashImage As PictureBox
End Class
