Imports MySql.Data.MySqlClient

Public Class expendassets
    Dim myConnection As String
    Dim mycon As MySqlConnection
    Dim SelectCommand As MySqlCommand
    Dim myReader As MySqlDataReader
    Public Sub fill_data_grid2()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from school_payments.expences ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView2.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Public Sub delete_expence()


        If (txt_expence_on.Text.Length > 0 And txt_expence_on.Text.Length > 0 And txt_amount.Text.Length > 0) Then

            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.expences where id='" & txt_id2.Text & "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")

                fill_data_grid2()

                txt_year.Text = ""
                txt_id.Text = ""
                txt_expence_on.Text = ""
                txt_expence_type.Text = ""
                txt_term.Text = ""
                txt_on.Text = ""
                txt_amount.Text = ""

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Public Sub update_expence()

        If (txt_expence_on.Text.Length > 0 And txt_expence_on.Text.Length > 0 And txt_amount.Text.Length > 0) Then

            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.expences set expence_type='" & txt_expence_type.Text & "',expence='" & txt_expence_on.Text & "',expenceon='" + txt_on.Text + "',amount='" & txt_amount.Text & "',date='" & DateTimePicker1.Text & "',term='" + txt_term.Text + "',year='" + txt_year.Text + "' where id='" & txt_id2.Text & "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")

                fill_data_grid2()

                txt_year.Text = ""
                txt_id.Text = ""
                txt_expence_on.Text = ""
                txt_expence_type.Text = ""
                txt_term.Text = ""
                txt_on.Text = ""
                txt_amount.Text = ""

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub



    Public Sub save_expence()
        If (txt_expence_on.Text.Length > 0 And txt_expence_on.Text.Length > 0 And txt_amount.Text.Length > 0) Then

            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.expences(expence_type,expence,expenceon,amount,date,term,year) values('" & txt_expence_type.Text & "','" & txt_expence_on.Text & "','" + txt_on.Text + "','" & txt_amount.Text & "','" & DateTimePicker1.Text & "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")

                fill_data_grid2()


                txt_year.Text = ""
                txt_id.Text = ""
                txt_expence_on.Text = ""
                txt_expence_type.Text = ""
                txt_term.Text = ""
                txt_on.Text = ""
                txt_amount.Text = ""
                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub
    Public Sub getTotalQuantity()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(quantity) from school_payments.netassets where asset='" + txt_asset.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim a1 As String
                a1 = myReader.GetString("sum(quantity)").ToString()
                Dim answer As Integer


                answer = a1 - Val(txt_quantity.Text)
                txt_remaining.Text = answer
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub expendassets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        fill_data_grid2()
        fill_assets()
    End Sub
    Public Sub fill_assets()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(asset) from school_payments.regassets ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim a As String
                a = myReader.GetString("asset").ToString()
                txt_asset.Items.Add(a)

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
        Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.netassets set quantity='" & txt_remaining.Text & "' where asset='" & txt_asset.Text & "' ", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()

        myReader = SelectCommand.ExecuteReader()
        MessageBox.Show("Net assets updated")
        txt_remaining.Text = ""



        mycon.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Aa As String

        Aa = MsgBox("are you sure u want to save?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_asset.Text.Length > 0 And txt_quantity.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.asset_expenditure(asset,quantity,date,term,year) values('" & txt_asset.Text & "','" & txt_quantity.Text & "','" & DateTimePicker1.Text & "','" + txt_term.Text + "','" + txt_year.Text + "') ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been saved")

                    fill_data_grid()


                    txt_year.Text = ""
                    txt_id.Text = ""
                    txt_remaining.Text = ""
                    txt_expence_on.Text = ""
                    txt_term.Text = ""
                    txt_amount.Text = ""

                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If
            getTotalQuantity()
            updatenetassets()

        Else



        End If



        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (txt_asset.Text.Length > 0 And txt_quantity.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.asset_expenditure set asset='" & txt_asset.Text & "',quantity='" & txt_quantity.Text & "',date='" & DateTimePicker1.Text & "', term='" + txt_term.Text + "',year='" + txt_year.Text + "' where id='" + txt_id.Text + "' ", mycon)
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
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from  school_payments.asset_expenditure  where id='" + txt_id.Text + "' ", mycon)
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
        txt_year.Text = ""
        txt_id.Text = ""
        txt_remaining.Text = ""
        txt_asset.Text = ""
        txt_quantity.Text = ""
        txt_remaining.Text = ""
        txt_expence_on.Text = ""
        txt_expence_type.Text = ""
        txt_amount.Text = ""
        txt_id2.Text = ""
        txt_on.Text = ""
        txt_term.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_asset.Text = DataGridView1.Item(1, i).Value
        Me.txt_quantity.Text = DataGridView1.Item(2, i).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(3, i).Value
        Me.txt_term.Text = DataGridView1.Item(4, i).Value
        Me.txt_year.Text = DataGridView1.Item(5, i).Value
    End Sub

    Public Sub autolisttotalasset()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(quantity) from school_payments.netassets where asset='" + txt_asset.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim a As String
                a = myReader.GetString("sum(quantity)").ToString()
                txt_remaining.Text = a

            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub txt_asset_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_asset.SelectedIndexChanged
        autolisttotalasset()
        If (txt_asset.Text.Length > 0) Then
            txt_expence_on.Enabled = False
            txt_expence_type.Enabled = False
            txt_amount.Enabled = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False

            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        ElseIf (txt_asset.Text.Length < 0) Then
            txt_asset.Enabled = False
            txt_quantity.Enabled = False
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True


            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
        End If
    End Sub

    Private Sub txt_quantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_quantity.TextChanged
        getTotalQuantity()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        assetexpe.Show()
    End Sub

    Private Sub txt_expence_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_expence_type.SelectedIndexChanged
        If (txt_expence_type.Text.Length > 0) Then
            txt_asset.Enabled = False
            txt_quantity.Enabled = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
        ElseIf (txt_expence_type.Text.Length < 0) Then
            txt_expence_on.Enabled = True
            txt_expence_type.Enabled = True
            txt_amount.Enabled = True
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True


            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txt_expence_on.Enabled = True
        txt_expence_type.Enabled = True
        txt_amount.Enabled = True
        txt_asset.Enabled = True
        txt_quantity.Enabled = True
        txt_asset.Text = ""
        txt_quantity.Text = ""
        txt_remaining.Text = ""
        txt_expence_on.Text = ""
        txt_expence_type.Text = ""
        txt_amount.Text = ""
        txt_id.Text = ""
        txt_id2.Text = ""
        Button7.Visible = True
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button8.Visible = True
        Button9.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        save_expence()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        Me.txt_id2.Text = DataGridView2.Item(0, i).Value
        Me.txt_expence_type.Text = DataGridView2.Item(1, i).Value
        Me.txt_expence_on.Text = DataGridView2.Item(2, i).Value
        Me.txt_on.Text = DataGridView2.Item(3, i).Value
        Me.txt_amount.Text = DataGridView2.Item(4, i).Value
        Me.DateTimePicker1.Text = DataGridView2.Item(5, i).Value
        Me.txt_term.Text = DataGridView2.Item(6, i).Value
        Me.txt_year.Text = DataGridView2.Item(7, i).Value

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        update_expence()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        delete_expence()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        report_expences.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Allexp.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class