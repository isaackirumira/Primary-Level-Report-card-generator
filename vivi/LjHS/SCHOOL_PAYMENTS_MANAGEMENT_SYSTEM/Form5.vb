Imports MySql.Data.MySqlClient
Public Class Form5
    Dim myConnection As String
    Dim mycon As MySqlConnection
    Dim SelectCommand As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim am As String
    Dim sumpaid As String
    Dim actual As Integer
    Public Sub fill_namev()
        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(fname) from school_payments.registration ;", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()
        myReader = SelectCommand.ExecuteReader()
        While (myReader.Read())


            Dim sn As String = myReader.GetString("fname").ToString()


            txt_name.Items.Add(sn)

        End While

        mycon.Close()



    End Sub
    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection)

        Dim connetionString As String = Nothing
        Dim connection As MySqlConnection
        Dim command As MySqlCommand
        Dim adapter As New MySqlDataAdapter()
        Dim ds As New DataSet()
        connetionString = "datasource=localhost;port=3306;username=root;"
        Dim sql As String = "Select distinct(fname) from school_payments.registration"
        connection = New MySqlConnection(connetionString)
        Try
            connection.Open()
            command = New MySqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Public Sub updatebalance()

        If (txt_other.Text.Length < 0) Then

            getamountpaidbystudent()

            getamounttobepaidbystudent()

            Dim amout_to_be_paid_by_student As Integer = Integer.Parse(am)
            Dim amout_paid_by_student As Integer = Integer.Parse(sumpaid)

            actual = (amout_to_be_paid_by_student - amout_paid_by_student)

        ElseIf (txt_other.Text.Length > 0) Then

            actual = 0
        Else
            getamountpaidbystudent()

            getamounttobepaidbystudent()

            Dim amout_to_be_paid_by_student As Integer = Integer.Parse(am)
            Dim amout_paid_by_student As Integer = Integer.Parse(sumpaid)

            actual = (amout_to_be_paid_by_student - amout_paid_by_student)
        End If

        Try

            myConnection = "datasource=localhost;port=3306;username=root;"
            mycon = New MySqlConnection(myConnection)
            SelectCommand = New MySqlCommand("update  school_payments.meal_ream set balance= '" & txt_balance.Text & "'  where class='" & txt_class.Text & "' and term='" & txt_term.Text & "' and year='" & txt_year.Text & "' and name='" + txt_name.Text + "' and payment='" + txt_payment.Text + "' ", mycon)


            mycon.Open()

            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("balance updated")
            'FUNCTIONALPAYMENTSLIP.Show()

            fill_data_grid()



            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub

    Public Sub getamountpaidbystudent()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(amount) from school_payments.meal_ream where payment='" + txt_payment.Text + "' and class='" + txt_class.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and name='" + txt_name.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                sumpaid = myReader.GetString("sum(amount)").ToString()
                txtsum.Text = sumpaid

            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub


    Public Sub getamounttobepaidbystudent()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select amount from school_payments.payments where payment='" + txt_payment.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                am = myReader.GetString("amount").ToString()


            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub fill_paymentsdata()

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.payments ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim names As String = myReader.GetString("payment").ToString()

                txt_payment.Items.Add(names)
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
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.meal_ream ;", conDatabase)
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
    Public Sub pay()


         Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.pay(name ,term,class,year,payment ,amount) values('" & txt_name.Text & "','" & txt_term.Text & "','" & txt_class.Text & "','" & txt_year.Text & "','" & txt_payment.Text & "','" & txt_amount.Text & "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
             



                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
       
    End Sub


    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then

            pay()

            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.meal_ream(name ,class,term,year,payment ,amount,other,date) values('" & txt_name.Text & "','" & txt_class.Text & "','" & txt_term.Text & "','" & txt_year.Text & "','" & txt_payment.Text & "','" & txt_amount.Text & "','" + txt_other.Text + "','" & DateTimePicker1.Text & "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")

                updatebalance()
                FUNCTIONALPAYMENTSLIP.Show()
                fill_data_grid()
                txt_name.Text = ""
                txt_amount.Text = ""
                txt_class.Text = ""
                txt_amount.Text = ""
                txt_id.Text = ""

                txt_term.Text = ""
                txt_year.Text = ""


                txt_other.Text = ""
                txt_payment.Text = ""
                txt_balance.Text = ""

                txt_tobepaid.Text = ""
                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEToolStripMenuItem.Click
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.meal_ream set name='" & txt_name.Text & "' ,class='" & txt_class.Text & "',term='" & txt_term.Text & "',year='" & txt_year.Text & "',amount='" & txt_amount.Text & "' ,other='" & txt_other.Text & "',payment='" + txt_payment.Text + "',date='" & DateTimePicker1.Text & "' where id='" + txt_id.Text + "'", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")
                fill_data_grid()
                txt_name.Text = ""
                txt_amount.Text = ""
                txt_class.Text = ""
                txt_amount.Text = ""
                txt_id.Text = ""
                txt_tobepaid.Text = ""
                txt_term.Text = ""
                txt_year.Text = ""


                txt_other.Text = ""
                txt_payment.Text = ""
                txt_balance.Text = ""

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.meal_ream  where id='" + txt_id.Text + "'", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("Data has been deleted")
            fill_data_grid()
            txt_name.Text = ""
            txt_amount.Text = ""
            txt_class.Text = ""
            txt_amount.Text = ""
            txt_id.Text = ""
            txt_tobepaid.Text = ""
            txt_term.Text = ""
            txt_year.Text = ""


            txt_other.Text = ""
            txt_payment.Text = ""
            txt_balance.Text = ""

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_name.Text = DataGridView1.Item(1, i).Value
        Me.txt_amount.Text = DataGridView1.Item(6, i).Value
        Me.txt_balance.Text = DataGridView1.Item(7, i).Value
        Me.txt_class.Text = DataGridView1.Item(2, i).Value
        Me.txt_other.Text = DataGridView1.Item(8, i).Value
        Me.txt_term.Text = DataGridView1.Item(3, i).Value
        Me.txt_year.Text = DataGridView1.Item(4, i).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(9, i).Value
        Me.txt_payment.Text = DataGridView1.Item(5, i).Value

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        fill_paymentsdata()
        fill_namev()
        txt_name.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_name.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim combData As New AutoCompleteStringCollection()
        getData(combData)
        txt_name.AutoCompleteCustomSource = combData
        Me.ResizeRedraw = False

    End Sub

    Private Sub txt_name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub txt_amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter characters in this field please")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.meal_ream where name='" + txt_name.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and class='" + txt_class.Text + "';", conDatabase)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fill_data_grid()
        txt_amount.Enabled = True
        txt_other.Enabled = True
        txt_name.Text = ""
        txt_amount.Text = ""
        txt_class.Text = ""
        txt_amount.Text = ""
        txt_id.Text = ""

        txt_term.Text = ""
        txt_year.Text = ""


        txt_other.Text = ""
        txt_payment.Text = ""
        txt_balance.Text = ""
        txt_tobepaid.Text = ""
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        meal_report.Show()
    End Sub

    Private Sub txt_uniform_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter characters in this field please")
        End If
    End Sub

    Private Sub REPORTONUNIFORMPAYMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        uniformpaymentsreport.Show()
    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged
        txt_balance.Text = (Val(txt_tobepaid.Text) - (Val(txt_amount.Text) + Val(txtsum.Text))).ToString()

    End Sub

    Private Sub txt_other_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_other.TextChanged
        
    End Sub

    Private Sub txt_payment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_payment.SelectedIndexChanged
        Try
            getamountpaidbystudent()
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.payments where payment='" + txt_payment.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim amu As String = myReader.GetString("amount").ToString()

                txt_tobepaid.Text = amu
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub SINGLEPAYMENTSTYPEREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        S.Show()
    End Sub

    Private Sub DETORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DETORSToolStripMenuItem.Click
        debtorsrep.Show()
    End Sub
End Class