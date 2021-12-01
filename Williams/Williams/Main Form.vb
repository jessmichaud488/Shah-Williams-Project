Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim packageAmount As Integer

        If RadBasic.Checked = True Then
            packageAmount = 24.99
        End If

        If RadSilver.Checked = True Then
            packageAmount = 42.99
        End If

        If RadGold.Checked = True Then
            packageAmount = 84.99
        End If

        If RadDiamond.Checked = True Then
            packageAmount = 99.99
        End If


        If ChkCinnematic.Checked = True Then
            packageAmount = packageAmount + 9.5
        End If

        If chkHBI.Checked = True Then
            packageAmount = packageAmount + 9.5
        End If

        If ChkShowtimer.Checked = True Then
            packageAmount = packageAmount + 10.5
        End If

        If ChkLocal.Checked = True Then
            packageAmount = packageAmount + 6.0
        End If

        lblTotalBox.Text = packageAmount.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ChkCinnematic_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCinnematic.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub chkHBI_CheckedChanged(sender As Object, e As EventArgs) Handles chkHBI.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub ChkShowtimer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowtimer.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub ChkLocal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLocal.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub RadBasic_CheckedChanged(sender As Object, e As EventArgs) Handles RadBasic.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub RadSilver_CheckedChanged(sender As Object, e As EventArgs) Handles RadSilver.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub RadGold_CheckedChanged(sender As Object, e As EventArgs) Handles RadGold.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub

    Private Sub RadDiamond_CheckedChanged(sender As Object, e As EventArgs) Handles RadDiamond.CheckedChanged
        lblTotalBox.Text = String.Empty
    End Sub
End Class
