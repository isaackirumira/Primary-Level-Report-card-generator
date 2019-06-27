Public Class Form2

    Private Sub REGISTERSTUDENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERSTUDENTSToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub REGISTERPAYEMENTAMOUNTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERPAYEMENTAMOUNTSToolStripMenuItem.Click
        Amounts.Show()
    End Sub

    Private Sub ADDFEESPAYMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDFEESPAYMENTSToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ADDMEALPAYMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDMEALPAYMENTSToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub FILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub

    Private Sub REGISTERPAYMENTAMOUNTSFORBOARDINGSTUDENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERPAYMENTAMOUNTSFORBOARDINGSTUDENTSToolStripMenuItem.Click
        boarding.Show()
    End Sub

    Private Sub REGISTERASSETSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERASSETSToolStripMenuItem.Click
        regassets.Show()
    End Sub

    Private Sub ASSETEXPENDITUREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASSETEXPENDITUREToolStripMenuItem.Click
        expendassets.Show()
    End Sub

    Private Sub FEESDEFAULTERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FEESDEFAULTERSToolStripMenuItem.Click
        fees.Show()
    End Sub

    Private Sub SPONSERSREGISTRATIONPANELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SPONSERSREGISTRATIONPANELToolStripMenuItem.Click
        sponsers.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub REGISTERPAYMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERPAYMENTSToolStripMenuItem.Click
        regpayments.Show()
    End Sub

    Private Sub SENDSMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SENDSMSToolStripMenuItem.Click
        sms.Show()
    End Sub

    Private Sub VOTEBOOKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOTEBOOKToolStripMenuItem.Click
        vote.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class