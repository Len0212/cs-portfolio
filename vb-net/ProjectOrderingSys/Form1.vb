Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Declare variables to hold prices, quantity, And total bill'
        Dim cupPrice As Double = 0
        Dim addonPrice As Double = 0
        Dim quantity As Integer = 0
        Dim unitPrice As Double = 0
        Dim totalBill As Double = 0

        'Input validation'

        ' 1. Validate Customer Name
        If txtName.Text = "" Then
            MsgBox("Please enter customer name.", vbOKOnly + vbCritical, "Error")
            Exit Sub
        End If

        ' 2. Validate Quantity (Must be a number)
        If txtQty.Text = "" Or Not IsNumeric(txtQty.Text) Then
            MsgBox("Please enter a valid number for quantity.", vbOKOnly + vbCritical, "Error")
            Exit Sub
        End If

        ' 3. Validate Quantity (Must be greater than zero)
        If Val(txtQty.Text) <= 0 Then
            MsgBox("Quantity must be greater than zero.", vbOKOnly + vbCritical, "Error")
            Exit Sub
        End If

        'Determine cup price based on selected size'
        quantity = Val(txtQty.Text)
        If rbSmall.Checked = True Then
            cupPrice = 49.0
            lblResSize.Text = "Small"
        ElseIf rbMedium.Checked = True Then
            cupPrice = 69.0
            lblResSize.Text = "Medium"
        ElseIf rbLarge.Checked = True Then
            cupPrice = 89.0
            lblResSize.Text = "Large"
        End If

        'Determine addon price based on selected addon'
        If rbNone.Checked = True Then
            addonPrice = 0.0
            lblResAddon.Text = "None"
        ElseIf rbPearls.Checked = True Then
            addonPrice = 10.0
            lblResAddon.Text = "Pearls"
        ElseIf rbNata.Checked = True Then
            addonPrice = 10.0
            lblResAddon.Text = "Nata de Coco"
        ElseIf rbCheese.Checked = True Then
            addonPrice = 20.0
            lblResAddon.Text = "Cream Cheese"
        End If

        'Calculate unit price and total bill'
        unitPrice = cupPrice + addonPrice
        totalBill = unitPrice * quantity

        'Display results'
        lblResName.Text = txtName.Text
        lblResQty.Text = quantity
        lblResUnit.Text = "Php " & unitPrice.ToString("N2")
        lblResTotal.Text = "Php " & totalBill.ToString("N2")
    End Sub

    'Clear all inputs and outputs'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear() ' Or txtName.Text = ""
        txtQty.Clear()  ' Or txtQty.Text = ""

        rbSmall.Checked = False
        rbMedium.Checked = False
        rbLarge.Checked = False

        rbNone.Checked = False
        rbPearls.Checked = False
        rbNata.Checked = False
        rbCheese.Checked = False

        lblResName.Text = ""
        lblResSize.Text = ""
        lblResAddon.Text = ""
        lblResQty.Text = ""
        lblResUnit.Text = ""
        lblResTotal.Text = ""

        txtName.Focus()
    End Sub

    'Exit the application'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub
End Class
