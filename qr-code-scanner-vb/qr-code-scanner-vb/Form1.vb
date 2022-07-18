﻿Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Public Class form1
    Dim captureCamera As VideoCaptureDevice
    Dim bitmapQRCode As Bitmap

    Private Sub captureFrame(sender As Object, eventargs As NewFrameEventArgs)
        bitmapQRCode = DirectCast(eventargs.Frame.Clone(), Bitmap)
        qrCodePicureBox.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim cameraOption As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameraOption.ShowDialog() = DialogResult.OK Then
            captureCamera = cameraOption.VideoDevice
            AddHandler captureCamera.NewFrame, New NewFrameEventHandler(AddressOf captureFrame)
            captureCamera.Start()
            frameTimer.Start()

        End If
    End Sub

    Private Sub frameTimer_Tick(sender As Object, e As EventArgs) Handles frameTimer.Tick
        If qrCodePicureBox.Image IsNot Nothing Then
            Dim bcReader As BarcodeReader = New BarcodeReader
            Dim scanText As Result = bcReader.Decode(DirectCast(qrCodePicureBox.Image, Bitmap))

            If scanText IsNot Nothing Then
                ResultTextBox.Text = scanText.ToString
            End If
        End If
    End Sub
End Class
