Public Class Form1
    Dim screendsk As Integer


    Private Sub startpreview_Click(sender As Object, e As EventArgs) Handles startpreview.Click
        screendsk = 0
        Timer.Enabled = True
    End Sub

    Private Sub stoppreview_Click(sender As Object, e As EventArgs) Handles stoppreview.Click
        Timer.Enabled = False
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Take_clip()
        Save_clip()
        screendsk += 1
    End Sub

    Private Sub Take_clip()
        Dim SS As Bitmap
        Dim graph As Graphics
        Dim bnd As Rectangle = My.Computer.Screen.Bounds

        SS = New Bitmap(bnd.Width, bnd.Height, Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(SS)
        graph.CopyFromScreen(0, 5, 10, 15, bnd.Size)

        PR.Image = SS
    End Sub
    Private Sub Save_clip()
        Dim path As String = Application.StartupPath & "\img0" & screendsk & ".png"
        PR.Image.Save(path, Imaging.ImageFormat.Png)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub To_video()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PR.Hide()
    End Sub
End Class