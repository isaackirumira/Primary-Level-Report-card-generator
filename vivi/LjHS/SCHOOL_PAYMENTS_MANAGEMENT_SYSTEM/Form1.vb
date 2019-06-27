Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.login where username='" & txtUserID.Text & "' and password='" & txtPass.Text & "' and usertype='" & cmboxLoginType.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If
            If (cmboxLoginType.Text = "admin") Then

                If (count = 1) Then

                    MessageBox.Show("username and password correct , access granted")
                    txtPass.Text = ""
                    txtUserID.Text = ""
                    cmboxLoginType.Text = ""
                    Form2.Show()
                    Me.Visible = False


                ElseIf (count > 1) Then

                    MessageBox.Show("Duplicate user in the database and access denied")


                Else
                    MessageBox.Show("username and password do not match")

                End If
            ElseIf (cmboxLoginType.Text = "user") Then

                If (count = 1) Then

                    MessageBox.Show("username and password correct , access granted")
                    Form2.Show()
                    'disable functional button 
                    Form3.SAVEToolStripMenuItem1.Enabled = False
                    Form3.UPDATEToolStripMenuItem.Enabled = False
                    Form3.DELETEToolStripMenuItem.Enabled = False

                    Form4.SAVEToolStripMenuItem.Enabled = False
                    Form4.UPDATEToolStripMenuItem.Enabled = False
                    Form4.DELETEToolStripMenuItem.Enabled = False

                    Form4.Button4.Enabled = False
                    Form4.Button5.Enabled = False
                    Form4.Button6.Enabled = False
                    Form4.REPORTToolStripMenuItem.Enabled = False

                    Form5.SAVEToolStripMenuItem.Enabled = False
                    Form5.UPDATEToolStripMenuItem.Enabled = False
                    Form5.DELETEToolStripMenuItem.Enabled = False

                    'Amounts.Button1.Enabled = False
                    'Amounts.Button2.Enabled = False
                    'Amounts.Button3.Enabled = False
                    sponsers.SAVEToolStripMenuItem.Enabled = False
                    sponsers.UPDATEToolStripMenuItem.Enabled = False
                    sponsers.DELETEToolStripMenuItem.Enabled = False
                    







                    Me.Visible = False


                ElseIf (count > 1) Then

                    MessageBox.Show("Duplicate user in the database and access denied")


                Else
                    MessageBox.Show("username and password combination does not macth")

                End If
            End If
            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub cmboxLoginType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxLoginType.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
