Imports MySql.Data.MySqlClient
Public Class boarding
    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.boarding_amounts ;", conDatabase)
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
        If (txt_class.Text.Length > 0 And txt_amount.Text.Length > 0) Then
            Try

                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.boarding_amounts(class,amount,cond) values('" & txt_class.Text & "','" & txt_amount.Text & "','" + txt_condition.Text + "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                fill_data_grid()
                txt_class.Text = ""
                txt_amount.Text = ""
                txt_condition.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (txt_class.Text.Length > 0 And txt_amount.Text.Length > 0) Then
            Try

                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.boarding_amounts set class='" & txt_class.Text & "',amount='" & txt_amount.Text & "',cond='" + txt_condition.Text + "' where id='" + txt_id.Text + "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")
                fill_data_grid()
                txt_class.Text = ""
                txt_amount.Text = ""
                txt_condition.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (txt_class.Text.Length > 0 And txt_amount.Text.Length > 0) Then
            Try

                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.boarding_amounts  where id='" + txt_id.Text + "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid()
                txt_class.Text = ""
                txt_amount.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_class.Text = DataGridView1.Item(1, i).Value
        Me.txt_amount.Text = DataGridView1.Item(2, i).Value
        Me.txt_condition.Text = DataGridView1.Item(3, i).Value

    End Sub

    Private Sub boarding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class