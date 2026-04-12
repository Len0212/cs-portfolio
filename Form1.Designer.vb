<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        txtQty = New TextBox()
        grpSize = New GroupBox()
        rbLarge = New RadioButton()
        rbMedium = New RadioButton()
        rbSmall = New RadioButton()
        grpAddon = New GroupBox()
        rbPearls = New RadioButton()
        rbNone = New RadioButton()
        rbCheese = New RadioButton()
        rbNata = New RadioButton()
        btnExit = New Button()
        btnClear = New Button()
        btnCompute = New Button()
        pnlCustomerInfo = New Panel()
        lblResTotal = New Label()
        lblTotal = New Label()
        LblPrice = New Label()
        lblQty = New Label()
        lblAdd = New Label()
        lblCupSize = New Label()
        lblCustomer = New Label()
        lblResUnit = New Label()
        lblResQty = New Label()
        lblResAddon = New Label()
        lblResSize = New Label()
        lblResName = New Label()
        lblOrderTitle = New Label()
        grpSize.SuspendLayout()
        grpAddon.SuspendLayout()
        pnlCustomerInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblTitle.Location = New Point(276, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(377, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "HAVEN TEA ORDERING SYSTEM"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        Label1.Location = New Point(27, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 19)
        Label1.TabIndex = 1
        Label1.Text = "Customer Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        Label2.Location = New Point(556, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 19)
        Label2.TabIndex = 2
        Label2.Text = "Quantity: "
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.ForeColor = Color.Black
        txtName.Location = New Point(208, 77)
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 25)
        txtName.TabIndex = 3
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = Color.White
        txtQty.BorderStyle = BorderStyle.FixedSingle
        txtQty.ForeColor = Color.Black
        txtQty.Location = New Point(664, 75)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(60, 25)
        txtQty.TabIndex = 4
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpSize
        ' 
        grpSize.Controls.Add(rbLarge)
        grpSize.Controls.Add(rbMedium)
        grpSize.Controls.Add(rbSmall)
        grpSize.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSize.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        grpSize.Location = New Point(21, 124)
        grpSize.Name = "grpSize"
        grpSize.Size = New Size(430, 155)
        grpSize.TabIndex = 6
        grpSize.TabStop = False
        grpSize.Text = "Select Cup Size"
        ' 
        ' rbLarge
        ' 
        rbLarge.AutoSize = True
        rbLarge.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLarge.Location = New Point(6, 114)
        rbLarge.Margin = New Padding(0, 5, 0, 5)
        rbLarge.Name = "rbLarge"
        rbLarge.Size = New Size(117, 23)
        rbLarge.TabIndex = 2
        rbLarge.TabStop = True
        rbLarge.Text = "Large (Php 89)"
        rbLarge.UseVisualStyleBackColor = True
        ' 
        ' rbMedium
        ' 
        rbMedium.AutoSize = True
        rbMedium.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbMedium.Location = New Point(6, 76)
        rbMedium.Margin = New Padding(0, 5, 0, 5)
        rbMedium.Name = "rbMedium"
        rbMedium.Size = New Size(134, 23)
        rbMedium.TabIndex = 1
        rbMedium.TabStop = True
        rbMedium.Text = "Medium (Php 69)"
        rbMedium.UseVisualStyleBackColor = True
        ' 
        ' rbSmall
        ' 
        rbSmall.AutoSize = True
        rbSmall.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSmall.Location = New Point(6, 38)
        rbSmall.Margin = New Padding(0, 5, 0, 5)
        rbSmall.Name = "rbSmall"
        rbSmall.Size = New Size(115, 23)
        rbSmall.TabIndex = 0
        rbSmall.TabStop = True
        rbSmall.Text = "Small (Php 49)"
        rbSmall.UseVisualStyleBackColor = True
        ' 
        ' grpAddon
        ' 
        grpAddon.Controls.Add(rbPearls)
        grpAddon.Controls.Add(rbNone)
        grpAddon.Controls.Add(rbCheese)
        grpAddon.Controls.Add(rbNata)
        grpAddon.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpAddon.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        grpAddon.Location = New Point(21, 296)
        grpAddon.Name = "grpAddon"
        grpAddon.Size = New Size(430, 210)
        grpAddon.TabIndex = 7
        grpAddon.TabStop = False
        grpAddon.Text = "Choose Add-On"
        ' 
        ' rbPearls
        ' 
        rbPearls.AutoSize = True
        rbPearls.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPearls.Location = New Point(10, 78)
        rbPearls.Margin = New Padding(0, 5, 0, 5)
        rbPearls.Name = "rbPearls"
        rbPearls.Size = New Size(128, 23)
        rbPearls.TabIndex = 5
        rbPearls.TabStop = True
        rbPearls.Text = "Pearls (+Php 10)"
        rbPearls.UseVisualStyleBackColor = True
        ' 
        ' rbNone
        ' 
        rbNone.AutoSize = True
        rbNone.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbNone.Location = New Point(11, 40)
        rbNone.Margin = New Padding(0, 5, 0, 5)
        rbNone.Name = "rbNone"
        rbNone.Size = New Size(108, 23)
        rbNone.TabIndex = 4
        rbNone.TabStop = True
        rbNone.Text = "None (Php 0)"
        rbNone.UseVisualStyleBackColor = True
        ' 
        ' rbCheese
        ' 
        rbCheese.AutoSize = True
        rbCheese.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbCheese.Location = New Point(9, 157)
        rbCheese.Margin = New Padding(0, 5, 0, 5)
        rbCheese.Name = "rbCheese"
        rbCheese.Size = New Size(181, 23)
        rbCheese.TabIndex = 3
        rbCheese.TabStop = True
        rbCheese.Text = "Cream Cheese (+Php 20)"
        rbCheese.UseVisualStyleBackColor = True
        ' 
        ' rbNata
        ' 
        rbNata.AutoSize = True
        rbNata.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbNata.Location = New Point(10, 117)
        rbNata.Margin = New Padding(0, 5, 0, 5)
        rbNata.Name = "rbNata"
        rbNata.Size = New Size(176, 23)
        rbNata.TabIndex = 2
        rbNata.TabStop = True
        rbNata.Text = "Nata de Coco (+Php 10)"
        rbNata.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(180), CByte(40), CByte(40))
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(80), CByte(80))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        btnExit.Location = New Point(782, 461)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(140, 45)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(140), CByte(140), CByte(140))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(110), CByte(110), CByte(110))
        btnClear.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        btnClear.Location = New Point(630, 461)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(140, 45)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.FromArgb(CByte(60), CByte(150), CByte(65))
        btnCompute.FlatAppearance.BorderSize = 0
        btnCompute.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(50), CByte(120), CByte(50))
        btnCompute.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(80), CByte(180), CByte(90))
        btnCompute.FlatStyle = FlatStyle.Flat
        btnCompute.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompute.ForeColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        btnCompute.Location = New Point(474, 461)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(140, 45)
        btnCompute.TabIndex = 12
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' pnlCustomerInfo
        ' 
        pnlCustomerInfo.Anchor = AnchorStyles.Top
        pnlCustomerInfo.BackColor = Color.White
        pnlCustomerInfo.BorderStyle = BorderStyle.FixedSingle
        pnlCustomerInfo.Controls.Add(lblResTotal)
        pnlCustomerInfo.Controls.Add(lblTotal)
        pnlCustomerInfo.Controls.Add(LblPrice)
        pnlCustomerInfo.Controls.Add(lblQty)
        pnlCustomerInfo.Controls.Add(lblAdd)
        pnlCustomerInfo.Controls.Add(lblCupSize)
        pnlCustomerInfo.Controls.Add(lblCustomer)
        pnlCustomerInfo.Controls.Add(lblResUnit)
        pnlCustomerInfo.Controls.Add(lblResQty)
        pnlCustomerInfo.Controls.Add(lblResAddon)
        pnlCustomerInfo.Controls.Add(lblResSize)
        pnlCustomerInfo.Controls.Add(lblResName)
        pnlCustomerInfo.Controls.Add(lblOrderTitle)
        pnlCustomerInfo.Location = New Point(474, 136)
        pnlCustomerInfo.Name = "pnlCustomerInfo"
        pnlCustomerInfo.Size = New Size(448, 300)
        pnlCustomerInfo.TabIndex = 13
        ' 
        ' lblResTotal
        ' 
        lblResTotal.AutoSize = True
        lblResTotal.BackColor = Color.FromArgb(CByte(242), CByte(229), CByte(215))
        lblResTotal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResTotal.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResTotal.Location = New Point(262, 256)
        lblResTotal.Margin = New Padding(0, 5, 0, 5)
        lblResTotal.Name = "lblResTotal"
        lblResTotal.Size = New Size(147, 19)
        lblResTotal.TabIndex = 12
        lblResTotal.Text = "_______________________"
        lblResTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.FromArgb(CByte(242), CByte(229), CByte(215))
        lblTotal.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblTotal.Location = New Point(28, 255)
        lblTotal.Margin = New Padding(0, 5, 0, 5)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(58, 19)
        lblTotal.TabIndex = 11
        lblTotal.Text = "TOTAL: "
        lblTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblPrice
        ' 
        LblPrice.AutoSize = True
        LblPrice.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPrice.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        LblPrice.Location = New Point(25, 209)
        LblPrice.Margin = New Padding(0, 5, 0, 5)
        LblPrice.Name = "LblPrice"
        LblPrice.Size = New Size(71, 19)
        LblPrice.TabIndex = 10
        LblPrice.Text = "Unit Price:"
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQty.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblQty.Location = New Point(23, 171)
        lblQty.Margin = New Padding(0, 5, 0, 5)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(66, 19)
        lblQty.TabIndex = 9
        lblQty.Text = "Quantity:"
        ' 
        ' lblAdd
        ' 
        lblAdd.AutoSize = True
        lblAdd.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAdd.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblAdd.Location = New Point(23, 136)
        lblAdd.Margin = New Padding(0, 5, 0, 5)
        lblAdd.Name = "lblAdd"
        lblAdd.Size = New Size(62, 19)
        lblAdd.TabIndex = 8
        lblAdd.Text = "Add-On:"
        ' 
        ' lblCupSize
        ' 
        lblCupSize.AutoSize = True
        lblCupSize.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCupSize.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblCupSize.Location = New Point(23, 100)
        lblCupSize.Margin = New Padding(0, 5, 0, 5)
        lblCupSize.Name = "lblCupSize"
        lblCupSize.Size = New Size(64, 19)
        lblCupSize.TabIndex = 7
        lblCupSize.Text = "Cup Size:"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomer.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblCustomer.Location = New Point(23, 65)
        lblCustomer.Margin = New Padding(0, 5, 0, 5)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(72, 19)
        lblCustomer.TabIndex = 6
        lblCustomer.Text = "Customer:"
        ' 
        ' lblResUnit
        ' 
        lblResUnit.AutoSize = True
        lblResUnit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResUnit.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResUnit.Location = New Point(262, 208)
        lblResUnit.Margin = New Padding(0, 5, 0, 5)
        lblResUnit.Name = "lblResUnit"
        lblResUnit.Size = New Size(147, 19)
        lblResUnit.TabIndex = 5
        lblResUnit.Text = "_______________________"
        ' 
        ' lblResQty
        ' 
        lblResQty.AutoSize = True
        lblResQty.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResQty.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResQty.Location = New Point(262, 172)
        lblResQty.Margin = New Padding(0, 5, 0, 5)
        lblResQty.Name = "lblResQty"
        lblResQty.Size = New Size(147, 19)
        lblResQty.TabIndex = 4
        lblResQty.Text = "_______________________"
        ' 
        ' lblResAddon
        ' 
        lblResAddon.AutoSize = True
        lblResAddon.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResAddon.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResAddon.Location = New Point(262, 137)
        lblResAddon.Margin = New Padding(0, 5, 0, 5)
        lblResAddon.Name = "lblResAddon"
        lblResAddon.Size = New Size(147, 19)
        lblResAddon.TabIndex = 3
        lblResAddon.Text = "_______________________"
        ' 
        ' lblResSize
        ' 
        lblResSize.AutoSize = True
        lblResSize.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResSize.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResSize.Location = New Point(262, 101)
        lblResSize.Margin = New Padding(0, 5, 0, 5)
        lblResSize.Name = "lblResSize"
        lblResSize.Size = New Size(147, 19)
        lblResSize.TabIndex = 2
        lblResSize.Text = "_______________________"
        ' 
        ' lblResName
        ' 
        lblResName.AutoSize = True
        lblResName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblResName.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblResName.Location = New Point(262, 66)
        lblResName.Margin = New Padding(0, 5, 0, 5)
        lblResName.Name = "lblResName"
        lblResName.Size = New Size(147, 19)
        lblResName.TabIndex = 1
        lblResName.Text = "_______________________"
        ' 
        ' lblOrderTitle
        ' 
        lblOrderTitle.AutoSize = True
        lblOrderTitle.BackColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        lblOrderTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderTitle.ForeColor = Color.FromArgb(CByte(93), CByte(64), CByte(55))
        lblOrderTitle.Location = New Point(134, 5)
        lblOrderTitle.Margin = New Padding(0, 5, 0, 5)
        lblOrderTitle.Name = "lblOrderTitle"
        lblOrderTitle.Size = New Size(177, 25)
        lblOrderTitle.TabIndex = 0
        lblOrderTitle.Text = "ORDER SUMMARY"
        lblOrderTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(250), CByte(243), CByte(224))
        ClientSize = New Size(934, 561)
        Controls.Add(pnlCustomerInfo)
        Controls.Add(btnCompute)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Controls.Add(grpAddon)
        Controls.Add(grpSize)
        Controls.Add(txtQty)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HAVEN TEA ORDERING SYTSEM"
        grpSize.ResumeLayout(False)
        grpSize.PerformLayout()
        grpAddon.ResumeLayout(False)
        grpAddon.PerformLayout()
        pnlCustomerInfo.ResumeLayout(False)
        pnlCustomerInfo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents RadioButton2 As RadioButton


    Friend WithEvents grpAddon As GroupBox
    Friend WithEvents rbCheese As RadioButton
    Friend WithEvents rbNata As RadioButton
    Friend WithEvents rbPearls As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents pnlCustomerInfo As Panel
    Friend WithEvents lblOrderTitle As Label
    Friend WithEvents lblResUnit As Label
    Friend WithEvents lblResQty As Label
    Friend WithEvents lblResAddon As Label
    Friend WithEvents lblResSize As Label
    Friend WithEvents lblResName As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblCupSize As Label
    Friend WithEvents lblResTotal As Label


End Class
