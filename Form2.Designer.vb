<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        pbLogo = New PictureBox()
        btnStart = New Button()
        btnExit = New Button()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbLogo
        ' 
        pbLogo.BackColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        pbLogo.Image = My.Resources.Resources.Orange_Playful_Illustrative_Thai_Tea_Milktea_Drink_Logo__2_
        pbLogo.Location = New Point(102, -315)
        pbLogo.Margin = New Padding(4, 5, 4, 5)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(656, 831)
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.FromArgb(CByte(235), CByte(120), CByte(50))
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(100), CByte(40))
        btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(140), CByte(70))
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = Color.White
        btnStart.Location = New Point(230, 361)
        btnStart.Margin = New Padding(4, 5, 4, 5)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(429, 66)
        btnStart.TabIndex = 1
        btnStart.Text = "START ORDERING"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ActiveBorder
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        btnExit.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(230, 448)
        btnExit.Margin = New Padding(4, 5, 4, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(429, 68)
        btnExit.TabIndex = 2
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        ClientSize = New Size(884, 561)
        Controls.Add(btnExit)
        Controls.Add(btnStart)
        Controls.Add(pbLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Haven Tea Ordering System"
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
End Class
