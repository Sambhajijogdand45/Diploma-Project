<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrapeImages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScrapeImages))
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pBar = New System.Windows.Forms.ProgressBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPath = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkOpen = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(376, 139)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(295, 139)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(11, 115)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(440, 18)
        Me.pBar.TabIndex = 2
        Me.pBar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NLSFT_WB.My.Resources.Resources.Download_2
        Me.PictureBox1.Location = New System.Drawing.Point(14, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(137, 34)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(276, 21)
        Me.txtPath.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(89, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Save to:"
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(419, 32)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(32, 23)
        Me.btnPath.TabIndex = 6
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grab all images from webpage."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(92, 65)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(359, 39)
        Me.lblStatus.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPath)
        Me.Panel1.Controls.Add(Me.chkOpen)
        Me.Panel1.Controls.Add(Me.pBar)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPath)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(459, 175)
        Me.Panel1.TabIndex = 9
        '
        'chkOpen
        '
        Me.chkOpen.Location = New System.Drawing.Point(11, 143)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(278, 19)
        Me.chkOpen.TabIndex = 9
        Me.chkOpen.Text = "Open save directory when complete."
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'frmScrapeImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(479, 195)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScrapeImages"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Images Grabber"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkOpen As System.Windows.Forms.CheckBox
End Class
