Imports System.Reflection
Imports System.Threading
Public Class frmsplash

    Private Declare Function BitBlt Lib "gdi32" Alias "BitBlt" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
    Private Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As IntPtr) As Integer
    Private Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As Integer) As Integer
    Private Const SRCCOPY = &HCC0020

    Private Sub SplashForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Read the PNG picture into PictureBox_PngSource -- the PNG is compiled as an embedded resource
        'Me.PictureBox_PngSource.Image = Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream("SplashPNG.Splash.png"))

        ' Determine the Width and Height of the splash form
        Dim FormWidth As Integer = Me.PictureBox_PngSource.Width
        Dim FormHeight As Integer = Me.PictureBox_PngSource.Height

        ' Determine the Left and Top parameters of the splash form -- the form will be centered on screen
        Dim ScreenSize As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim FormLeft As Integer = (ScreenSize.Width - Me.PictureBox_PngSource.Width) / 2
        Dim FormTop As Integer = (ScreenSize.Height - Me.PictureBox_PngSource.Height) / 2

        ' Create a bitmap buffer to draw things into
        Dim BufferBitmap As Bitmap = New Bitmap(FormWidth, FormHeight)
        Dim BufferGraphics As Graphics = Graphics.FromImage(BufferBitmap)

        ' Get a screenshot of the desktop area where the splash form will show
        Dim DesktopDC As Integer = GetDC(Nothing)
        Dim BufferGraphicsDC As IntPtr = BufferGraphics.GetHdc
        BitBlt(BufferGraphicsDC.ToInt32, 0, 0, FormWidth, FormHeight, DesktopDC, FormLeft, FormTop, SRCCOPY)
        ReleaseDC(Nothing, DesktopDC)
        BufferGraphics.ReleaseHdc(BufferGraphicsDC)

        ' Draw the PNG image over the desktop screenshot
        BufferGraphics.DrawImage(Me.PictureBox_PngSource.Image, 0, 0, FormWidth, FormHeight)

        ' Draw some text -- this is where some product license info could be drawn on the splash picture
        Dim TextBrush As New SolidBrush(Me.ForeColor)
        'BufferGraphics.DrawString(Application.ProductVersion, Me.Font, TextBrush, 25, 40)
        TextBrush.Dispose()

        BufferGraphics.Dispose()

        ' Put the final result into the PictureBox_SplashImage which will cover the entire splash form
        Me.PictureBox_SplashImage.Size = New Size(FormWidth, FormHeight)
        Me.PictureBox_SplashImage.Image = BufferBitmap

        ' Position the splash form exactly over the desktop area that was previously captured
        Me.Width = FormWidth
        Me.Height = FormHeight
        Me.Top = FormTop
        Me.Left = FormLeft
        Me.WindowState = FormWindowState.Normal

        ' Allow the splash form to show itself properly
        Application.DoEvents()
        Me.Update()
        Thread.Sleep(2000)

        frmlogin.Show()
    End Sub

    Private Sub SplashForm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        ' Since the splash form is just an illusion of a transparent image hovering over the desktop
        ' it must be closed as soon as it loses focus, otherwise the user might notice the trick when
        ' the desktop changes.
        Me.Close()

        ' Closing the splash form on LostFocus is just a simple example -- the purpose of this demo
        ' is just to show how to "splash" a PNG over the desktop. Implementing more advanced
        ' splash "schemes" requires additional work. So, good luck to you on that! :)
    End Sub
End Class