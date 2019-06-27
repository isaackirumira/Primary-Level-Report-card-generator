Imports MySql.Data.MySqlClient
Public Class Form4
    Dim myConnection As String
    Dim mycon As MySqlConnection
    Dim SelectCommand As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim amout_to_be_paid_by_student_per_class As Integer
    Dim amout_to_be_paid_by_student_per_class_sponser As Integer
    Dim amout_paid_by_student_per_termyear As Integer
    Dim am As String
    Dim amx As String
    Dim am_sponser As String
    Dim sumpaid As String
    Dim actual As Integer = 0
    Dim jn As String
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
    Public Sub zeyakasasula()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(paid) from school_payments.installments where class='" + txt_class.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and name='" + txt_name.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                sumpaid = myReader.GetString("sum(paid)").ToString()
                TextBox1.Text = sumpaid ''

            End While

            mycon.Close()


        Catch ex As Exception
            '  MessageBox.Show(ex.Message)


        End Try
    End Sub
    Public Sub fillimagenames()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(imagename) from school_payments.photos ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim names As String = myReader.GetString("imagename").ToString()

                txt_searchbyyear.Items.Add(names)
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub
    Public Sub fill_image()

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter("select image from school_payments.photos where imagename= '" & txt_name.Text & "'", mycon)
            Dim cmd As MySqlCommandBuilder = New MySqlCommandBuilder
            Dim dt As DataTable = New DataTable
            adptr.Fill(dt)
            Dim lb() As Byte = dt.Rows(0).Item("image")
            Dim lstr As New System.IO.MemoryStream(lb)
            PictureBox1.Image = Image.FromStream(lstr)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()


        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub fill_sponsers()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.sponsers ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim names As String = myReader.GetString("name").ToString()

                txt_sponser.Items.Add(names)
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub updatebalance()

        If (txt_condition.Text.Length > 0 And txt_day.Text = "DAY") Then
            'getamountpaidbystudent()
            'getamounttobepaidbystudent()

            'amout_to_be_paid_by_student_per_class = Integer.Parse(am)
            'amout_paid_by_student_per_termyear = Integer.Parse(sumpaid)


            ' actual = TextBox2.Text
        End If

        If (txt_condition.Text.Length > 0 And txt_day.Text = "BOARDING") Then
            ' getamountpaidbystudent()
            ' getamounttobepaidbystudent_boarding()

            ' amout_to_be_paid_by_student_per_class = Integer.Parse(amx)
            ' amout_paid_by_student_per_termyear = Integer.Parse(sumpaid)


            'actual = actual = TextBox2.Text

        End If

        If (txt_condition.Text.Length = 0 And txt_day.Text = "BOARDING" Or txt_day.Text = "DAY") Then
            ' getamounttobepaidbystudent_sponser()
            ' getamountpaidbystudent()

            ' amout_to_be_paid_by_student_per_class_sponser = Integer.Parse(am_sponser)
            ' amout_paid_by_student_per_termyear = Integer.Parse(sumpaid)

            'actual = TextBox2.Text

        End If


        Try

            myConnection = "datasource=localhost;port=3306;username=root;"
            mycon = New MySqlConnection(myConnection)
            SelectCommand = New MySqlCommand("update  school_payments.fees_payments set balance= '" & TextBox3.Text & "'  where class='" & txt_class.Text & "' and term='" & txt_term.Text & "' and year='" & txt_year.Text & "' and name='" & txt_name.Text & "' ", mycon)


            mycon.Open()

            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("balance updated")
            fill_data_grid2()
            fill_data_grid()
            feespayments_reciept.Show()
            txt_balace.Text = ""
            txt_name.Text = ""
            txt_class.Text = ""
            txt_id.Text = ""
            txt_paid.Text = ""
            txt_term.Text = ""
            txt_year.Text = ""
            txt_totalamount.Text = ""
            txt_paid2.Text = ""
            id.Text = ""
            txt_bankslipno.Text = ""
            txt_searchbyyear.Text = ""
            PictureBox1.Image = Nothing
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            txt_condition.Text = ""
            txt_day.Text = ""


            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)




        End Try
    End Sub

    Public Sub getamountpaidbystudent()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(paid) from school_payments.installments where class='" + txt_class.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and name='" + txt_name.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                sumpaid = myReader.GetString("sum(paid)").ToString()
                TextBox1.Text = sumpaid ''

            End While

            mycon.Close()


        Catch ex As Exception
            '  MessageBox.Show(ex.Message)


        End Try
    End Sub


    Public Sub getamounttobepaidbystudent()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select amount from school_payments.amounts where class='" + txt_class.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                am = myReader.GetString("amount").ToString()


            End While

            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub getamounttobepaidbystudent_boarding()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select amount from school_payments.boarding_amounts where class='" + txt_class.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                amx = myReader.GetString("amount").ToString()


            End While

            mycon.Close()


        Catch ex As Exception
            ' MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub getamounttobepaidbystudent_sponser()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select amount from school_payments.sponsers where class='" + txt_class.Text + "' And name='" + txt_sponser.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                am_sponser = myReader.GetString("amount").ToString()


            End While

            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        End Try
    End Sub
    Public Sub saveinstallements2()

        Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
        Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
        Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.fees_payments where name='" & txt_name.Text & "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and class='" & txt_class.Text & "';", mycon)
        Dim myReader As MySqlDataReader

        mycon.Open()
        myReader = SelectCommand.ExecuteReader()
        Dim count As Integer = 0
        If (myReader.HasRows()) Then
            count = count + 1

        End If


        If (count < 1) Then
            If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
                Try

                    myConnection = "datasource=localhost;port=3306;username=root;"
                    mycon = New MySqlConnection(myConnection)
                    SelectCommand = New MySqlCommand("insert into school_payments.installments(date,name,paid,bankslipno,class,term,year) values('" & DateTimePicker1.Text & "','" & txt_name.Text & "','" & txt_paid.Text & "','" + txt_bankslipno.Text + "','" & txt_class.Text & "','" & txt_term.Text & "','" & txt_year.Text & "') ", mycon)


                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()

                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("Please name,term,year,date paid,class must be filled in order to save this installement")
            End If
        ElseIf (count = 1) Then
            MessageBox.Show("Already this student paid his first payment in term" & " " & txt_term.Text & " " & txt_year.Text & " " & " so" & " " & "this payment should be entered from the right panel ok")
        End If
    End Sub

    Public Sub saveinstallements()
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_paid.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try

                myConnection = "datasource=localhost;port=3306;username=root;"
                mycon = New MySqlConnection(myConnection)
                SelectCommand = New MySqlCommand("insert into school_payments.installments(date,name,paid,bankslipno,class,term,year) values('" & DateTimePicker1.Text & "','" & txt_name.Text & "','" & txt_paid.Text & "','" + txt_bankslipno.Text + "','" & txt_class.Text & "','" & txt_term.Text & "','" & txt_year.Text & "') ", mycon)


                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been saved")
                updatebalance()

                fill_data_grid()
                fill_data_grid2()
                'feespayments_reciept.Show()

               


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("Please name,term,year,date paid,class must be filled in order to save this installement")
        End If
    End Sub
    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.fees_payments ;", conDatabase)
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

    Public Sub fill_data_grid2()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.installments ;", conDatabase)
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
    Public Sub fill_namesbyclass()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.registration where class='" + txt_class.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim fname As String = myReader.GetString("fname").ToString()
                
                txt_searchbyyear.Items.Add(fname)
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub fill_amounts()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.amounts where class='" + txt_class.Text + "' and cond='" + txt_condition.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim Totalamount As String = myReader.GetString("amount").ToString()

                txt_totalamount.Text = Totalamount
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Public Sub fill_amountsboarding()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.boarding_amounts where class='" + txt_class.Text + "' and cond='" + txt_condition.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim Totalamount As String = myReader.GetString("amount").ToString()

                txt_totalamount.Text = Totalamount
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Sub fill_sponsersamount()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.sponsers where name='" + txt_sponser.Text + "' and class='" + txt_class.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim amt As String = myReader.GetString("amount").ToString()

                txt_totalamount.Text = amt
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub


    Private Sub txt_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_class.SelectedIndexChanged
        If (txt_day.Text = "DAY") Then
            fill_amounts()
            zeyakasasula()
        ElseIf (txt_day.Text = "BOARDING") Then

            fill_amountsboarding()
            zeyakasasula()
        End If

        'fill_namesbyclass()
        fill_sponsersamount()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_searchbyyear.Items.Clear()
        txt_searchbyyear.Text = ""
        txt_condition.Text = ""
        txt_sponser.Text = ""
        txt_day.Text = ""
        txt_totalamount.Text = ""
        txt_condition.Enabled = True
        txt_sponser.Enabled = True
        fill_data_grid()
    End Sub

    Private Sub txt_searchbyyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_searchbyyear.SelectedIndexChanged
        txt_name.Text = txt_searchbyyear.Text
        fill_image()
    End Sub

    Private Sub txt_balace_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_balace.TextChanged
        'TextBox3.Text = txt_balace.Text
        'TextBox2.Text = (Val(txt_totalamount.Text) - (Val(TextBox3.Text) + Val(txt_paid.Text))).ToString()
    End Sub

    Private Sub txt_paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_paid.TextChanged

        txt_balace.Text = (Val(txt_totalamount.Text) - Val(txt_paid.Text)).ToString()
        TextBox4.Text = (Val(TextBox1.Text) + Val(txt_paid.Text)).ToString()

        ' TextBox3.Text = txt_balace.Text
        'TextBox2.Text = (Val(txt_totalamount.Text) - (Val(TextBox3.Text) + Val(txt_paid.Text))).ToString()
    End Sub

    Private Sub txt_name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub txt_paid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_paid.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter characters in this field please")
        End If
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim Aa As String

        Aa = MsgBox("are you sure you have entered the right amount if yes press ok, if no press cancel and ckeck?", vbYesNo, "Question")

        If Aa = vbYes Then



            saveinstallements2()
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from school_payments.fees_payments where name='" & txt_name.Text & "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and class='" & txt_class.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If


            If (count < 1) Then


                If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
                    Try

                        myConnection = "datasource=localhost;port=3306;username=root;"
                        mycon = New MySqlConnection(myConnection)
                        SelectCommand = New MySqlCommand("insert into school_payments.fees_payments(date,name,class,total_amount,paid,bankslipno,balance,year,term) values('" & DateTimePicker1.Text & "','" & txt_name.Text & "','" & txt_class.Text & "','" & txt_totalamount.Text & "','" & txt_paid.Text & "','" + txt_bankslipno.Text + "','" + txt_balace.Text + "','" & txt_year.Text & "','" & txt_term.Text & "' ) ", mycon)


                        mycon.Open()

                        myReader = SelectCommand.ExecuteReader()
                        MessageBox.Show("Data has been saved succesfully")
                        updatebalance()
                        fill_data_grid()
                        fill_data_grid2()
                        'feespayments_reciept.Show()

                        txt_balace.Text = ""
                        txt_name.Text = ""
                        txt_class.Text = ""
                        txt_id.Text = ""
                        txt_paid.Text = ""
                        txt_term.Text = ""
                        txt_year.Text = ""
                        txt_totalamount.Text = ""
                        txt_bankslipno.Text = ""
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                        txt_condition.Text = ""
                        txt_day.Text = ""
                        mycon.Close()


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)




                    End Try
                Else
                    MessageBox.Show("None of the fields should be blank")
                End If

            ElseIf (count = 1) Then
                MessageBox.Show("Already this student paid his first payment in term" & " " & txt_term.Text & " " & txt_year.Text & " " & " so" & " " & "this payment should be entered from the right panel ok")
            End If

        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.DateTimePicker1.Text = DataGridView1.Item(1, i).Value
        Me.txt_name.Text = DataGridView1.Item(2, i).Value
        Me.txt_class.Text = DataGridView1.Item(3, i).Value
        Me.txt_totalamount.Text = DataGridView1.Item(4, i).Value
        Me.txt_paid.Text = DataGridView1.Item(5, i).Value
        Me.txt_bankslipno.Text = DataGridView1.Item(6, i).Value
        Me.txt_balace.Text = DataGridView1.Item(7, i).Value
        Me.txt_year.Text = DataGridView1.Item(8, i).Value
        Me.txt_term.Text = DataGridView1.Item(9, i).Value

        fill_image()

    End Sub

    Private Sub txt_term_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_term.SelectedIndexChanged
        getamountpaidbystudent()
        zeyakasasula()
        txt_balace.Text = (Val(txt_totalamount.Text) - Val(txt_paid.Text)).ToString()

    End Sub
    Public Sub autofillgrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select fname from school_payments.registration   ;", conDatabase)
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
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        fill_data_grid2()
        fill_sponsers()
        fillimagenames()
        fill_namev()
        txt_name.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_name.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim combData As New AutoCompleteStringCollection()
        getData(combData)
        txt_name.AutoCompleteCustomSource = combData
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEToolStripMenuItem.Click
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try

                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.fees_payments set date='" & DateTimePicker1.Text & "',name='" & txt_name.Text & "',class='" & txt_class.Text & "',total_amount='" & txt_totalamount.Text & "',paid='" & txt_paid.Text & "',bankslipno='" + txt_bankslipno.Text + "',balance='" + txt_balace.Text + "',year='" & txt_year.Text & "',term='" & txt_term.Text & "' where id='" + txt_id.Text + "'  ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")
              
                fill_data_grid()
                txt_balace.Text = ""
                txt_name.Text = ""
                txt_class.Text = ""
                txt_id.Text = ""
                txt_paid.Text = ""
                txt_term.Text = ""
                txt_year.Text = ""
                txt_totalamount.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try

                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.fees_payments  where id='" + txt_id.Text + "'  ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid()
                txt_balace.Text = ""
                txt_name.Text = ""
                txt_class.Text = ""
                txt_id.Text = ""
                txt_paid.Text = ""
                txt_term.Text = ""
                txt_year.Text = ""
                txt_totalamount.Text = ""
                txt_bankslipno.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub FILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.fees_payments where class='" + txt_class.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' ;", conDatabase)
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

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_searchbyyear.Text = txt_name.Text
    End Sub

    Private Sub txt_totalamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totalamount.TextChanged
        txt_balace.Text = (Val(txt_totalamount.Text) - Val(txt_paid.Text)).ToString()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.fees_payments where name='" + txt_name.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' ;", conDatabase)
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (txt_balace.Text.Length > 0 And TextBox3.Text.Length > 0) Then
            saveinstallements()
        Else
            MessageBox.Show("Please fill field for Paid")

        End If

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index

        Me.id.Text = DataGridView2.Item(0, i).Value
        Me.txt_name.Text = DataGridView2.Item(2, i).Value
        Me.txt_class.Text = DataGridView2.Item(5, i).Value
        Me.txt_paid2.Text = DataGridView2.Item(3, i).Value
        Me.txt_paid.Text = DataGridView2.Item(3, i).Value
        Me.txt_bankslipno.Text = DataGridView2.Item(4, i).Value
        Me.txt_term.Text = DataGridView2.Item(6, i).Value
        Me.txt_year.Text = DataGridView2.Item(7, i).Value
        Me.DateTimePicker1.Text = DataGridView2.Item(1, i).Value
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select *  from school_payments.installments where name='" + txt_name.Text + "' and term='" + txt_term.Text + "' and year='" + txt_year.Text + "' ;", conDatabase)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (txt_name.Text.Length > 0 And txt_class.Text.Length > 0 And txt_paid.Text.Length > 0 And txt_term.Text.Length > 0 And txt_year.Text.Length > 0) Then
            Try

                myConnection = "datasource=localhost;port=3306;username=root;"
                mycon = New MySqlConnection(myConnection)
                SelectCommand = New MySqlCommand("update  school_payments.installments set date='" & DateTimePicker1.Text & "',name='" & txt_name.Text & "',paid='" & txt_paid.Text & "',class='" & txt_class.Text & "',term='" & txt_term.Text & "',year='" & txt_year.Text & "' where id='" + id.Text + "'", mycon)


                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been updated")
                fill_data_grid2()
                txt_balace.Text = ""
                txt_name.Text = ""
                txt_class.Text = ""
                txt_id.Text = ""
                txt_paid.Text = ""
                txt_term.Text = ""
                txt_year.Text = ""
                txt_totalamount.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("Please name,term,year,date paid,class must be filled in order to save this installement")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (id.Text.Length > 0) Then
            Try

                myConnection = "datasource=localhost;port=3306;username=root;"
                mycon = New MySqlConnection(myConnection)
                SelectCommand = New MySqlCommand("delete from  school_payments.installments  where id='" + id.Text + "'", mycon)


                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("Data has been deleted")
                fill_data_grid2()
                txt_balace.Text = ""
                txt_name.Text = ""
                txt_class.Text = ""
                txt_id.Text = ""
                txt_paid.Text = ""
                txt_term.Text = ""
                txt_year.Text = ""
                txt_totalamount.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("Please you need id field to delete this record")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_balace.Text = ""
        txt_name.Text = ""
        txt_class.Text = ""
        txt_id.Text = ""
        txt_paid.Text = ""
        txt_term.Text = ""
        txt_year.Text = ""
        txt_totalamount.Text = ""
        txt_paid2.Text = ""
        id.Text = ""
        txt_bankslipno.Text = ""
        txt_searchbyyear.Text = ""
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        txt_condition.Text = ""
        txt_day.Text = ""
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(paid) from school_payments.installments where term='" + txt_term.Text + "' and year='" + txt_year.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim totalpaid As String = myReader.GetString("sum(paid)").ToString()

                MessageBox.Show("The total amount of fees paid in" & " " & txt_term.Text & " " & "in" & " " & txt_year.Text & " " & "is" & " " & totalpaid & " " & "sh")
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(balance) from school_payments.fees_payments where term='" + txt_term.Text + "' and year='" + txt_year.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim totalbal As String = myReader.GetString("sum(balance)").ToString()

                MessageBox.Show("The total balance on fees in" & " " & txt_term.Text & " " & "in" & " " & txt_year.Text & " " & "is" & " " & TextBox2.Text & "sh")
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select sum(paid) from school_payments.installments where term='" + txt_term.Text + "' and year='" + txt_year.Text + "' and name='" + txt_name.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            While (myReader.Read())

                Dim totalbal As String = myReader.GetString("sum(paid)").ToString()

                MessageBox.Show("The total fees  paid by " & " " & txt_name.Text & " " & " in" & " " & txt_term.Text & " " & "in" & " " & txt_year.Text & " " & "is" & " " & totalbal & " " & "sh")
            End While

            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        fees_payments_report.Show()
    End Sub

    Private Sub FEESPAYMENTSREPORTBYTERMYEARCLASSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FEESPAYMENTSREPORTBYTERMYEARCLASSToolStripMenuItem.Click
        payments_report.Show()
    End Sub

    Private Sub FEESPAYMENTSREPORTFORASINGLESTUDENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FEESPAYMENTSREPORTFORASINGLESTUDENTToolStripMenuItem.Click
        single_report.Show()
    End Sub

    Private Sub txt_condition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_condition.SelectedIndexChanged
        txt_sponser.Enabled = False
    End Sub

    Private Sub txt_day_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_day.SelectedIndexChanged

    End Sub

    Private Sub txt_sponser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sponser.SelectedIndexChanged

        txt_condition.Enabled = False
        fill_sponsersamount()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txt_paid2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_paid2.TextChanged

    End Sub

    Private Sub txt_year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year.SelectedIndexChanged
        getamountpaidbystudent()
        txt_balace.Text = (Val(txt_totalamount.Text) - Val(txt_paid.Text)).ToString()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Val(txt_totalamount.Text) - Val(TextBox1.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox3.Text = (Val(txt_totalamount.Text) - Val(TextBox4.Text)).ToString()
    End Sub

    Private Sub txt_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.SelectedIndexChanged
        txt_searchbyyear.Text = txt_name.Text
    End Sub
End Class