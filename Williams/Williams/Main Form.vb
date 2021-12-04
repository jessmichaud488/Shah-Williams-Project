Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intPackageAmount As Integer

        If radBasic.Checked = True Then
            intPackageAmount = 24.99
        End If

        If radSilver.Checked = True Then
            intPackageAmount = 42.99
        End If

        If radGold.Checked = True Then
            intPackageAmount = 84.99
        End If

        If radDiamond.Checked = True Then
            intPackageAmount = 99.99
        End If


        If chkCinnematic.Checked = True Then
           intPackageAmount = intPackageAmount + 9.5
        End If

        If chkHBI.Checked = True Then
            intPackageAmount = intPackageAmount + 9.5
        End If

        If chkShowtimer.Checked = True Then
            intPackageAmount = intPackageAmount + 10.5
        End If

        If chkLocal.Checked = True Then
            intPackageAmount = intPackageAmount + 6.0
        End If

        lblTotalBox.Text = intPackageAmount.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkCinnematic_CheckedChanged(sender As Object, e As EventArgs) Handles chkCinnematic.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub chkHBI_CheckedChanged(sender As Object, e As EventArgs) Handles chkHBI.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub chkShowtimer_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowtimer.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub chkLocal_CheckedChanged(sender As Object, e As EventArgs) Handles chkLocal.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub radBasic_CheckedChanged(sender As Object, e As EventArgs) Handles radBasic.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub radSilver_CheckedChanged(sender As Object, e As EventArgs) Handles radSilver.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub radGold_CheckedChanged(sender As Object, e As EventArgs) Handles radGold.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub radDiamond_CheckedChanged(sender As Object, e As EventArgs) Handles radDiamond.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub
End Class
