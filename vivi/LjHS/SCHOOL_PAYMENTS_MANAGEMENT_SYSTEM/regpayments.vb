Imports MySql.Data.MySqlClient
Public Class regpayments

    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.payments ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to save?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_payment.Text.Length > 0 And txt_amount.Text.Length > 0) Then
                Try

                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.payments(payment,amount) values('" & txt_payment.Text & "','" & txt_amount.Text & "') ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been saved")
                    fill_data_grid()
                    txt_payment.Text = ""
                    txt_amount.Text = ""



                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If


        Else



        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to update?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_payment.Text.Length > 0 And txt_amount.Text.Length > 0) Then
                Try

                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.payments set payment='" & txt_payment.Text & "',amount='" & txt_amount.Text & "' where id='" + txt_id.Text + "'", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been updated")
                    fill_data_grid()
                    txt_payment.Text = ""
                    txt_amount.Text = ""



                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If


        Else



        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_payment.Text.Length > 0 And txt_amount.Text.Length > 0) Then
                Try

                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.payments  where id='" + txt_id.Text + "'", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been deleted")
                    fill_data_grid()
                    txt_payment.Text = ""
                    txt_amount.Text = ""



                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If


        Else



        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_payment.Text = DataGridView1.Item(1, i).Value
        Me.txt_amount.Text = DataGridView1.Item(2, i).Value

    End Sub

    Private Sub regpayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
    End Sub
End Class