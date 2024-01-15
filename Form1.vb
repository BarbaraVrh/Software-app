Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCostLicensing As Decimal 'Cost of software licensing'
        Dim decCostOptional As Decimal  'Cost of optional features'



        'Constants for base fees'
        Const dec_YEARLY_FEE = 5000D
        Const dec_one_PURCHASE_FEE = 20000D
        'Constants for optional fees'
        Const declevel_3_FEE = 3500D
        Const decon_site_FEE = 2000D
        Const deccloud_FEE = 300D

        'Check for base service'
        If radYear.Checked = True Then
            decCostLicensing = dec_YEARLY_FEE
        ElseIf radOne.Checked = True Then
            decCostLicensing = dec_one_PURCHASE_FEE

        End If

        'Check for optional services'

        If chkTech.Checked Then
            decCostOptional += declevel_3_FEE
        End If

        If chkSite.Checked Then
            decCostOptional += decon_site_FEE
        End If

        If chkCloud.Checked Then
            decCostOptional += deccloud_FEE
        End If

        'Display the fees'

        lblCostLicensing.Text = decCostLicensing.ToString("n")
        lblCostOptional.Text = decCostOptional.ToString("n")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the yearly lease radio button'
        radYear.Checked = True
        'Clear the check boxes'
        chkTech.Checked = False
        chkSite.Checked = False
        chkCloud.Checked = False

        'Clear the fee labels'
        lblCostLicensing.Text = String.Empty
        lblCostOptional.Text = String.Empty


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form'
        Me.Close()
    End Sub
End Class
