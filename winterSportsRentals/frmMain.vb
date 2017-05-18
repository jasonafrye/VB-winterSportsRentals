'Program:	winterSportsRentals
'Developer:	Jason A. Frye
'Purpose:	This application will let the user (a store clerk) enter information about each customer’s rental. 
'           The user should be able to select multiple equipment items, a rental duration, and insurance.
'Date:	    9/18/2011

Option Strict On
Option Explicit On

Public Class frmMain
    'Declare class level variables
    Private msngDeposit As Single = 0


#Region "Form Events"

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Set the date label to today's date
        lblDate.Text = Date.Today.ToString("dddd, MMMM dd, yyyy")

    End Sub

#End Region

#Region "Click Events"

    Private Sub tsbClose_Click(sender As Object, e As System.EventArgs) Handles tsbClose.Click
        'Terminates current application
        Me.Close()

    End Sub

    Private Sub lnkWeather_Click(sender As Object, e As System.EventArgs) Handles lnkWeather.Click
        'Loads frmBrowse as Dialogue Box
        frmBrowse.ShowDialog()

    End Sub

    Private Sub tsbCalc_Click(sender As Object, e As System.EventArgs) Handles tsbCalc.Click
        'Validates that all user input is valid, then computes the prices, tax, 
        'and Total of all selected pieces of equipment and displays them in the text boxes. 

        'declare constants
        Const sngTaxRate As Single = 0.075
        'declare variables
        Dim sngCost As Single = 0
        Dim intDuration As Integer = cboLength.SelectedIndex
        Dim intChecked As Integer
        Dim sngTaxTotal As Single
        Dim sngDamage As Single
        Dim sngGrand As Single
        'clear text boxes from last calcuation
        txtGrand.Clear()
        txtSub.Clear()
        txtTax.Clear()
        'verify that equipment has been checked
        If cklEquip.CheckedItems.Count > 0 Then
            'verify that duration has been checked
            If cboLength.SelectedIndex > -1 Then
                'loop through each selected piece of equipment and add it's price for the selected duration by calling the appropriate 
                'procedure from the custom class
                For Each i As Integer In cklEquip.CheckedIndices
                    intChecked = i
                    sngCost = CSng(sngCost + rental.GetRentalPrice(CType(intDuration, rental.DurationType), CType(intChecked, rental.EquipmentType)))
                Next
                'check if damage insurance has been chosen. 
                If chkDamage.Checked Then
                    'call the procedure to determine insurance cost
                    sngDamage = CSng(rental.InsuranceCost(sngCost))
                    'add insruance cost to eqnuipmen price
                    sngCost += sngDamage
                End If
                'calcuate the total tax amount
                sngTaxTotal = (sngCost * sngTaxRate)
                'calculate the grand total
                sngGrand = (sngCost + sngTaxTotal - msngDeposit)
                'display all pricing information to user
                txtSub.Text = sngCost.ToString("c")
                txtTax.Text = sngTaxTotal.ToString("C")
                txtDeposit.Text = msngDeposit.ToString()
                txtGrand.Text = sngGrand.ToString("C")
            Else
                'if rental duration is not selected, display error and focus to control
                ErrorProvider1.SetError(cboLength, "Please Select Rental Duration")
                cboLength.Focus()
            End If
        Else
            'If no equipment has been selected, display error and focus to control
            ErrorProvider1.SetError(cklEquip, "Please Select Equipment for Rental")
            cklEquip.Focus()
        End If

    End Sub

#End Region

#Region "Input Validation Events"

    Private Sub cboLength_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboLength.SelectedIndexChanged
        'Verifies a valid index is selected and removes error indicator

        If cboLength.SelectedIndex >= 0 Then
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cklEquip_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles cklEquip.ItemCheck
        'Removes Error Indicator
        ErrorProvider1.Clear()

    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As System.EventArgs) Handles txtDeposit.TextChanged
        'Verifies that only numbers larger than zero are entered. 
        'It not this event sets the Error Alert, focuses on the text box, and resents the deposit value to 0

        If txtDeposit.Text <> Nothing Then
            'Try to convert text entry to number and clear error
            Try
                msngDeposit = Convert.ToSingle(txtDeposit.Text)
                ErrorProvider1.Clear()
            Catch ex As Exception
                'display error provider and clear contents of textbox to try again
                ErrorProvider1.SetError(txtDeposit, "Please Enter a Positive Number")
                txtDeposit.Clear()
            End Try
            'verify that deposit amount is a non-negative number
            If msngDeposit < 0 Then
                'display error provider and clear contents of textbox to try again
                ErrorProvider1.SetError(txtDeposit, "Please Enter a Positive Number")
                txtDeposit.Clear()
                'reset deposit to 0 to minimize calculation errors. 
                msngDeposit = 0
            End If
        End If
    End Sub

#End Region


End Class
