Imports MySql.Data.MySqlClient
Public Class regassets
    Dim a3 As Integer
    Public Sub savereducedvote()



        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.asset_expenditure(vote,expence,estimated,actual,cummulative,balance,date,term,year) values('" & txt_expence_type.Text & "','" & txt_on.Text & "','" + txt_est.Text + "','" + txt_amount.Text + "','" + txt_cummulative.Text + "','" + txt_reducedvote.Text + "','" + DateTimePicker1.Text + "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()

        myReader = SelectCommand.ExecuteReader()
        MessageBox.Show("Supplement from " & " " & txt_expence_type.Text & " " & "to" & " " & txt_asset.Text & " " & "has been made")

        fill_data_grid()


        txt_expence_type.Text = ""

        txt_year.Text = ""
        txt_id.Text = ""
        txt_balance.Text = ""
        txt_cummulative.Text = ""

        txt_expence_type.Text = ""
        txt_expence_type.Text = ""
        txt_amount.Text = ""
        txt_id.Text = ""
        txt_on.Text = ""
        txt_term.Text = ""

        mycon.Close()
     
    End Sub

    Public Sub sumactual()
        a3 = 0
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(actual) from school_payments.asset_expenditure where vote='" + txt_expence_type.Text + "'  ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())

                If (myReader.HasRows) Then
                    a3 = myReader.GetString("sum(actual)").ToString()
                ElseIf (Not myReader.HasRows) Then

                End If

            End While

            txt_cummulative.Text = a3

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub


    Public Sub loadvotes()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(asset) from school_payments.regassets  ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim a2 As String
                a2 = myReader.GetString("asset").ToString()
                txt_expence_type.Items.Add(a2)


            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub


    Public Sub initialactual()

        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.asset_expenditure(vote,actual,term,year) values('" & txt_asset.Text & "','" + txt_ac.Text + "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()

        myReader = SelectCommand.ExecuteReader()


        mycon.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_asset.Text = DataGridView1.Item(2, i).Value
        Me.txt_quantity.Text = DataGridView1.Item(3, i).Value
        Me.txt_amount.Text = DataGridView1.Item(1, i).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(4, i).Value
        Me.txt_term.Text = DataGridView1.Item(5, i).Value
        Me.txt_year.Text = DataGridView1.Item(6, i).Value


    End Sub
    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from school_payments.regassets ;", conDatabase)
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
    Public Sub saveinitialnetassets()

        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.netassets(asset,quantity) values('" & txt_asset.Text & "','" & txt_quantity.Text & "') ", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()

        myReader = SelectCommand.ExecuteReader()
        MessageBox.Show("Budget Supplimented")



        mycon.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txt_asset.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.regassets(asset,quantity,amount,date,term,year) values('" & txt_asset.Text & "','" & txt_quantity.Text & "','" + txt_amount.Text + "','" & DateTimePicker1.Text & "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                saveinitialnetassets()
                initialactual()
                fill_data_grid()
                txt_asset.Text = ""
                txt_quantity.Text = ""
                txt_year.Text = ""
                txt_id.Text = ""



                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (txt_asset.Text.Length > 0 And txt_quantity.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.regassets set asset='" & txt_asset.Text & "',quantity='" & txt_quantity.Text & "',amount='" + txt_amount.Text + "',date='" & DateTimePicker1.Text & "', term='" + txt_term.Text + "',year='" + txt_year.Text + "' where id='" + txt_id.Text + "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")
                fill_data_grid()
                txt_asset.Text = ""
                txt_quantity.Text = ""
                txt_year.Text = ""
                txt_id.Text = ""



                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (txt_asset.Text.Length > 0 And txt_quantity.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from  school_payments.regassets  where id='" + txt_id.Text + "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid()
                txt_asset.Text = ""
                txt_quantity.Text = ""
                txt_year.Text = ""
                txt_id.Text = ""



                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_asset.Text = ""
        txt_quantity.Text = ""
        txt_id.Text = ""
        txt_year.Text = ""
        txt_balance.Text = ""
    End Sub

    Private Sub regassets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        loadvotes()
    End Sub

    Private Sub txt_quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_quantity.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        newassetreport.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_expence_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expence_type.SelectedIndexChanged
        If (txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(amount) from school_payments.regassets where asset='" + txt_expence_type.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' ;", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()
                myReader = SelectCommand.ExecuteReader()

                While (myReader.Read())
                    Dim a1 As String
                    a1 = myReader.GetString("sum(amount)").ToString()
                    txt_est.Text = a1


                End While

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)


            End Try
            sumactual()
            txt_balance.Text = Val(txt_est.Text) - Val(txt_cummulative.Text)
            txt_reducedvote.Text = Val(txt_balance.Text) - Val(txt_amount.Text)
            txt_on.Text = "Money from" & " " & txt_expence_type.Text & " " & " to" & " " & txt_asset.Text



        Else
            MessageBox.Show("Please first fill term and year")

            txt_expence_type.Text = ""
            txt_asset.Text = ""
            txt_quantity.Text = ""
            txt_id.Text = ""
            txt_year.Text = ""
            txt_balance.Text = ""

        End If
    End Sub
    Public Sub savesuppliment()

        If (txt_asset.Text.Length > 0 And txt_quantity.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.regassets(asset,quantity,amount,date,term,year) values('" & txt_asset.Text & "','" & txt_quantity.Text & "','" + txt_amount.Text + "','" & DateTimePicker1.Text & "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                saveinitialnetassets()
                initialactual()
                fill_data_grid()
                txt_asset.Text = ""
                txt_quantity.Text = ""
                txt_year.Text = ""
                txt_id.Text = ""



                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        savesuppliment()
        savereducedvote()
    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged
        txt_reducedvote.Text = Val(txt_balance.Text) - Val(txt_amount.Text)
        txt_on.Text = "Money from" & " " & txt_expence_type.Text & " " & " to" & " " & txt_asset.Text
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class