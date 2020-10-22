Public Class Form1

    Dim panel As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define the starting pannel for the program when it loads
        panel = 1
        'Call the main panel switcher
        mainPanelSwitch()
        'Define the newest date possible for the date picket
        dtpDOB.MaxDate = New DateTime(Today.Year - 24, Today.Month, Today.Day)
    End Sub

    Private Sub mainPanelSwitch()
        'This sub deals with the bulk of the program
        'it is called everytime a navigation button is hit
        'it deals with the following:
        ' • Enabling and disabling the right navigation buttons
        ' • Showing and hiding the correct panels
        ' • Any error checking
        ' • Copying and storing data to and from the right location 
        Select Case panel
            'If this is 1 the name, dob, nationality etc page is shown
            Case 1
                'Navigation buttons set to enable and disable as they should
                btuNavBack.Enabled = False
                btuNavNext.Enabled = True
                btuNavFinish.Enabled = False

                'This sets the correct panels to be visible to the user so they have the correct menu
                One.Visible = True
                Two.Visible = False
                Three.Visible = False
                Four.Visible = False

            Case 2
                'This error checking method apears multiple times to make sure the varible is declared in the right way
                'This one in particular makes sure the names are defined
                If (txtForname.Text = "" Or txtSurname.Text = "") Then
                    'Show an error respective to the data that is missing
                    MessageBox.Show("Please Enter Your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Go back a panel as we cant move forward without the data
                    panel -= 1
                    'Recalculate the panels to be shown
                    mainPanelSwitch()
                    Return
                End If
                If (cboNationality.Text = "") Then
                    MessageBox.Show("Please Enter Your Nationality", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    panel -= 1
                    mainPanelSwitch()
                    Return
                End If
                If (nupYears.Value + nupMonths.Value <= 0) Then
                    MessageBox.Show("Please Enter A License Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    panel -= 1
                    mainPanelSwitch()
                    Return
                End If
                If (txtForname.Text.Length > 20 Or txtSurname.Text.Length > 20) Then
                    MessageBox.Show("Name Is Too Long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    panel -= 1
                    mainPanelSwitch()
                    Return
                End If
                ptbLargeCar.Visible = False
                ptbMediumCar.Visible = False
                ptbSmallCar.Visible = False

                btuNavBack.Enabled = True
                btuNavNext.Enabled = True
                btuNavFinish.Enabled = False

                One.Visible = False
                Two.Visible = True
                Three.Visible = False
                Four.Visible = False

                'This just deals with an edge case where the user has selected a car size, cleared the box and then tried to continue, the picture wouldnt show for the respective option
                'so this just simply checks with the data in the box what image needs to be shown as if the user changed the option
                Dim temp1 As Object
                Dim temp2 As EventArgs
                cboSize_SelectedIndexChanged(temp1, temp2)
            Case 3

                If (cboSize.SelectedIndex < 0) Then
                    MessageBox.Show("Please Pick A Car Size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    panel -= 1
                    mainPanelSwitch()
                    Return
                End If
                btuNavBack.Enabled = True
                btuNavNext.Enabled = True
                btuNavFinish.Enabled = False

                One.Visible = False
                Two.Visible = False
                Three.Visible = True
                Four.Visible = False
            Case 4
                If (cboDuration.SelectedIndex < 0) Then
                    MessageBox.Show("Please Pick A Rental Duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    panel -= 1
                    mainPanelSwitch()
                    Return
                End If
                btuNavBack.Enabled = True
                btuNavNext.Enabled = False
                btuNavFinish.Enabled = True

                One.Visible = False
                Two.Visible = False
                Three.Visible = False
                Four.Visible = True

                'This is a mass data copy from all stages of the form to the final screen where all the data is shown on the screen
                'For one final review by the user before they finish and close the program
                lblFinalForename.Text = txtForname.Text
                lblFinalSurname.Text = txtSurname.Text
                lblFinalDOB.Text = dtpDOB.Text
                lblFinalNationality.Text = cboNationality.Text
                lblFinalRentalTime.Text = cboDuration.Text
                lblFinalSize.Text = cboSize.Text

                Dim price As Double
                'We use the index of this combo box to know what price they have chosen so we can show and calculate the correct price + VAT
                Select Case cboDuration.SelectedIndex
                    Case 0
                        price = 30
                    Case 1
                        price = 95
                    Case 2
                        price = 270
                End Select

                'Calculate the VAT (simple maths)
                Dim vat As Double
                vat = price / 5

                'Define the text for the rich text box show the user gets a breakdown of the price
                rtxtPriceBreakdown.Text = "Rental: | " & FormatCurrency(price) & vbCrLf & "VAT:    | " & FormatCurrency(vat) & vbCrLf & "-------------------------------------------" & vbCrLf & "Total:   | " & FormatCurrency(price + vat)
            Case Else
        End Select
    End Sub

    'All these are the navigation buttons
    'These subs simply change the pannel number and update the display
    'for the correct panel and information
    Private Sub btuNavBack_Click(sender As Object, e As EventArgs) Handles btuNavBack.Click
        panel -= 1
        mainPanelSwitch()
    End Sub

    Private Sub btuNavNext_Click(sender As Object, e As EventArgs) Handles btuNavNext.Click
        panel += 1
        mainPanelSwitch()
    End Sub

    Private Sub btuNavFinish_Click(sender As Object, e As EventArgs) Handles btuNavFinish.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        'Chose the right image to be shown
        Select Case cboSize.SelectedIndex
            Case < 0
                ptbSmallCar.Visible = False
                ptbMediumCar.Visible = False
                ptbLargeCar.Visible = False
            Case 0
                ptbSmallCar.Visible = True
                ptbMediumCar.Visible = False
                ptbLargeCar.Visible = False
            Case 1
                ptbSmallCar.Visible = False
                ptbMediumCar.Visible = True
                ptbLargeCar.Visible = False
            Case 2
                ptbSmallCar.Visible = False
                ptbMediumCar.Visible = False
                ptbLargeCar.Visible = True
        End Select
    End Sub

    Private Sub cboDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDuration.SelectedIndexChanged
        'Show the correct prize for the option chosen
        Select Case cboDuration.SelectedIndex
            Case < 0
                lblCostsPreview.Text = ""
            Case 0
                lblCostsPreview.Text = "Price : £30 + VAT"
            Case 1
                lblCostsPreview.Text = "Price : £95 + VAT"
            Case 2
                lblCostsPreview.Text = "Price : £270 + VAT"
        End Select
    End Sub
End Class