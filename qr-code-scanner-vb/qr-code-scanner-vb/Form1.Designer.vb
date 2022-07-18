<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.qrCodePicureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.frameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.saveFileButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        CType(Me.qrCodePicureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Camera:"
        '
        'qrCodePicureBox
        '
        Me.qrCodePicureBox.Location = New System.Drawing.Point(16, 38)
        Me.qrCodePicureBox.Name = "qrCodePicureBox"
        Me.qrCodePicureBox.Size = New System.Drawing.Size(425, 306)
        Me.qrCodePicureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.qrCodePicureBox.TabIndex = 2
        Me.qrCodePicureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contact Infomation"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBox.Location = New System.Drawing.Point(451, 62)
        Me.ResultTextBox.Multiline = True
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(281, 165)
        Me.ResultTextBox.TabIndex = 3
        '
        'frameTimer
        '
        Me.frameTimer.Interval = 1000
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.Control
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(89, 6)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(37, 28)
        Me.StartButton.TabIndex = 4
        Me.StartButton.Text = "On"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'saveFileButton
        '
        Me.saveFileButton.BackColor = System.Drawing.SystemColors.Info
        Me.saveFileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveFileButton.Location = New System.Drawing.Point(657, 233)
        Me.saveFileButton.Name = "saveFileButton"
        Me.saveFileButton.Size = New System.Drawing.Size(75, 43)
        Me.saveFileButton.TabIndex = 4
        Me.saveFileButton.Text = "Save File"
        Me.saveFileButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(576, 233)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 43)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(744, 399)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.saveFileButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.qrCodePicureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "form1"
        Me.Text = "QR Code Scanner"
        CType(Me.qrCodePicureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents qrCodePicureBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents frameTimer As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents saveFileButton As Button
    Friend WithEvents clearButton As Button
End Class
