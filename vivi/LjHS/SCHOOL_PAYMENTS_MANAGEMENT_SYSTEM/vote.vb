Imports MySql.Data.MySqlClient
Public Class vote
    Dim a3 As Integer
    Public Sub insert()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to save?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_expence_type.Text.Length > 0 And txt_voucherno.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.asset_expenditure(vote,subvote,expence,voucherno,estimated,actual,cummulative,balance,date,term,year) values('" & txt_expence_type.Text & "','" & txt_expence_on.Text & "','" & txt_on.Text & "','" + txt_voucherno.Text + "','" + txt_amount.Text + "','" + txt_actual.Text + "','" + txt_cummulative.Text + "','" + txt_balance.Text + "','" + DateTimePicker1.Text + "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been saved")

                    fill_data_grid()


                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""
                    txt_year.Text = ""
                    txt_id.Text = ""
                    txt_balance.Text = ""
                    txt_cummulative.Text = ""
                    txt_actual.Text = ""
                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""

                    txt_expence_on.Text = ""
                    txt_expence_type.Text = ""
                    txt_amount.Text = ""
                    txt_id.Text = ""
                    txt_on.Text = ""
                    txt_term.Text = ""

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
    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from school_payments.asset_expenditure ;", conDatabase)
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


    Public Sub updatenetassets()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.netassets set quantity='" & txt_remaining.Text & "' where asset='" & txt_expence_type.Text & "' ", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()

        myReader = SelectCommand.ExecuteReader()
        MessageBox.Show("Net assets updated")
        'txt_remaining.Text = ""



        mycon.Close()
    End Sub


    Public Sub getTotalQuantity()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(quantity) from school_payments.netassets where asset='" + txt_expence_type.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim a1 As String
                a1 = myReader.GetString("sum(quantity)").ToString()
                Dim answer As Integer


                answer = a1 - Val(txt_voucherno.Text)
                ' txt_remaining.Text = answer
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(txt_amount.Text) - Val(txt_cummulative.Text) < 100000) Then
            MessageBox.Show("Please your estimate on this vote is running low")
        End If
        If (Val(txt_cummulative.Text) = Val(txt_amount.Text)) Then
            MessageBox.Show("Please you have completely used your estimate")

        End If

        If (Val(txt_actual.Text) > Val(txt_balance.Text)) Then
            MessageBox.Show("Please you dont have enough balance on this vote check balance")

        End If

        If (Val(txt_actual.Text) <= Val(txt_balance.Text)) Then
            insert()

        End If

       


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to update?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_expence_type.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.asset_expenditure set vote='" & txt_expence_type.Text & "',subvote='" & txt_expence_on.Text & "',expence='" & txt_on.Text & "',voucherno='" + txt_voucherno.Text + "',estimated='" + txt_amount.Text + "',actual='" + txt_actual.Text + "',cummulative='" + txt_cummulative.Text + "',balance='" + txt_balance.Text + "',date='" + DateTimePicker1.Text + "',term='" + txt_term.Text + "',year='" + txt_year.Text + "' where id='" + txt_id.Text + "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been updated")

                    fill_data_grid()


                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""
                    txt_year.Text = ""
                    txt_id.Text = ""
                    txt_balance.Text = ""
                    txt_cummulative.Text = ""
                    txt_actual.Text = ""
                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""

                    txt_expence_on.Text = ""
                    txt_expence_type.Text = ""
                    txt_amount.Text = ""
                    txt_id.Text = ""
                    txt_on.Text = ""
                    txt_term.Text = ""

                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If
            ' getTotalQuantity()
            ' updatenetassets()

        Else



        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_expence_type.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.asset_expenditure  where id='" + txt_id.Text + "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been deleted")

                    fill_data_grid()


                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""
                    txt_year.Text = ""
                    txt_id.Text = ""
                    txt_balance.Text = ""
                    txt_cummulative.Text = ""
                    txt_actual.Text = ""
                    txt_expence_type.Text = ""
                    txt_voucherno.Text = ""

                    txt_expence_on.Text = ""
                    txt_expence_type.Text = ""
                    txt_amount.Text = ""
                    txt_id.Text = ""
                    txt_on.Text = ""
                    txt_term.Text = ""

                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If
            ' getTotalQuantity()
            ' updatenetassets()

        Else



        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txt_expence_type.Text = ""
        txt_voucherno.Text = ""
        txt_year.Text = ""
        txt_id.Text = ""
        txt_balance.Text = ""
        txt_cummulative.Text = ""
        txt_actual.Text = ""
        txt_expence_type.Text = ""
        txt_voucherno.Text = ""

        txt_expence_on.Text = ""
        txt_expence_type.Text = ""
        txt_amount.Text = ""
        txt_id.Text = ""
        txt_on.Text = ""
        txt_term.Text = ""
    End Sub

    Private Sub vote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadvotes()
        fill_data_grid()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txt_expence_on.Enabled = True
        txt_expence_type.Enabled = True
        txt_amount.Enabled = True

        txt_voucherno.Enabled = True

        txt_voucherno.Text = ""

        txt_expence_on.Text = ""
        txt_expence_type.Text = ""
        txt_amount.Text = ""
        txt_id.Text = ""
        txt_id.Text = ""

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub txt_on_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_on.TextChanged

    End Sub

    Private Function txt_remaining() As Object
        Throw New NotImplementedException
    End Function

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
                    txt_amount.Text = a1


                End While

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)


            End Try
            sumactual()
            txt_balance.Text = Val(txt_amount.Text) - Val(txt_cummulative.Text)
        Else
            MessageBox.Show("Please first fill term and year")

            txt_expence_type.Text = ""
            txt_voucherno.Text = ""
            txt_year.Text = ""
            txt_id.Text = ""
            txt_balance.Text = ""
            txt_cummulative.Text = ""
            txt_actual.Text = ""
            txt_expence_type.Text = ""
            txt_voucherno.Text = ""

            txt_expence_on.Text = ""
            txt_expence_type.Text = ""
            txt_amount.Text = ""
            txt_id.Text = ""
            txt_on.Text = ""
            txt_term.Text = ""

        End If
    End Sub

    Private Sub txt_cummulative_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cummulative.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value.ToString()
        Me.txt_expence_type.Text = DataGridView1.Item(1, i).Value.ToString()
        Me.txt_expence_on.Text = DataGridView1.Item(2, i).Value.ToString()
        Me.txt_amount.Text = DataGridView1.Item(5, i).Value.ToString()
        Me.DateTimePicker1.Text = DataGridView1.Item(9, i).Value
        Me.txt_term.Text = DataGridView1.Item(10, i).Value.ToString()
        Me.txt_year.Text = DataGridView1.Item(11, i).Value.ToString()
        Me.txt_actual.Text = DataGridView1.Item(6, i).Value.ToString()
        Me.txt_cummulative.Text = DataGridView1.Item(7, i).Value.ToString()
        Me.txt_balance.Text = DataGridView1.Item(8, i).Value.ToString()
        Me.txt_voucherno.Text = DataGridView1.Item(4, i).Value.ToString()
        Me.txt_on.Text = DataGridView1.Item(3, i).Value.ToString()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        votereport.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        sirp.Show()
    End Sub
End Class