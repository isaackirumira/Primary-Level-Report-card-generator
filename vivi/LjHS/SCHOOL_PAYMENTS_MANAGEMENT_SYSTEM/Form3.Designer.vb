<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_condition = New System.Windows.Forms.ComboBox()
        Me.CONDITION = New System.Windows.Forms.Label()
        Me.txt_sex = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_term = New System.Windows.Forms.ComboBox()
        Me.txt_year = New System.Windows.Forms.ComboBox()
        Me.txt_class = New System.Windows.Forms.ComboBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_telephone = New System.Windows.Forms.TextBox()
        Me.txt_parent = New System.Windows.Forms.TextBox()
        Me.txt_oname = New System.Windows.Forms.TextBox()
        Me.txt_sname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHBYNAMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPLOADSTUDENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_condition)
        Me.GroupBox1.Controls.Add(Me.CONDITION)
        Me.GroupBox1.Controls.Add(Me.txt_sex)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_term)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.txt_class)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_telephone)
        Me.GroupBox1.Controls.Add(Me.txt_parent)
        Me.GroupBox1.Controls.Add(Me.txt_oname)
        Me.GroupBox1.Controls.Add(Me.txt_sname)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1266, 705)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENTS DETAILS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(235, 419)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 36)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Reset Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(235, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 37)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Browse Photo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_condition
        '
        Me.txt_condition.FormattingEnabled = True
        Me.txt_condition.Items.AddRange(New Object() {"NONE", "USE", "NONUSE", "UPOLET", "NONUPOLET"})
        Me.txt_condition.Location = New System.Drawing.Point(189, 331)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.Size = New System.Drawing.Size(175, 23)
        Me.txt_condition.TabIndex = 32
        '
        'CONDITION
        '
        Me.CONDITION.AutoSize = True
        Me.CONDITION.Location = New System.Drawing.Point(37, 339)
        Me.CONDITION.Name = "CONDITION"
        Me.CONDITION.Size = New System.Drawing.Size(77, 15)
        Me.CONDITION.TabIndex = 31
        Me.CONDITION.Text = "CONDITION"
        '
        'txt_sex
        '
        Me.txt_sex.FormattingEnabled = True
        Me.txt_sex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.txt_sex.Location = New System.Drawing.Point(189, 304)
        Me.txt_sex.Name = "txt_sex"
        Me.txt_sex.Size = New System.Drawing.Size(175, 23)
        Me.txt_sex.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "SEX"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(6, 66)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(18, 22)
        Me.txt_id.TabIndex = 28
        Me.txt_id.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(173, 22)
        Me.DateTimePicker1.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "DATE"
        '
        'txt_term
        '
        Me.txt_term.FormattingEnabled = True
        Me.txt_term.Items.AddRange(New Object() {"ONE", "TWO", "THREE"})
        Me.txt_term.Location = New System.Drawing.Point(190, 273)
        Me.txt_term.Name = "txt_term"
        Me.txt_term.Size = New System.Drawing.Size(174, 23)
        Me.txt_term.TabIndex = 18
        '
        'txt_year
        '
        Me.txt_year.FormattingEnabled = True
        Me.txt_year.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.txt_year.Location = New System.Drawing.Point(189, 246)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(175, 23)
        Me.txt_year.TabIndex = 17
        '
        'txt_class
        '
        Me.txt_class.FormattingEnabled = True
        Me.txt_class.Items.AddRange(New Object() {"BABY", "MIDDLE", "TOP", "P1", "P2", "P3", "P4", "P5", "P6", "P7"})
        Me.txt_class.Location = New System.Drawing.Point(189, 217)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(175, 23)
        Me.txt_class.TabIndex = 16
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(189, 180)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(175, 22)
        Me.txt_address.TabIndex = 15
        '
        'txt_telephone
        '
        Me.txt_telephone.Location = New System.Drawing.Point(191, 145)
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.Size = New System.Drawing.Size(173, 22)
        Me.txt_telephone.TabIndex = 14
        '
        'txt_parent
        '
        Me.txt_parent.Location = New System.Drawing.Point(189, 112)
        Me.txt_parent.Name = "txt_parent"
        Me.txt_parent.Size = New System.Drawing.Size(175, 22)
        Me.txt_parent.TabIndex = 13
        '
        'txt_oname
        '
        Me.txt_oname.Location = New System.Drawing.Point(6, 45)
        Me.txt_oname.Name = "txt_oname"
        Me.txt_oname.Size = New System.Drawing.Size(18, 22)
        Me.txt_oname.TabIndex = 12
        Me.txt_oname.Visible = False
        '
        'txt_sname
        '
        Me.txt_sname.Location = New System.Drawing.Point(6, 19)
        Me.txt_sname.Name = "txt_sname"
        Me.txt_sname.Size = New System.Drawing.Size(22, 22)
        Me.txt_sname.TabIndex = 11
        Me.txt_sname.Visible = False
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(190, 74)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(174, 22)
        Me.txt_fname.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(370, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(890, 634)
        Me.DataGridView1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TERM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "YEAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CLASS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TELEPHONE NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PARENT/GUARDIAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT`SNAME"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.ToolStripMenuItem1, Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPDATEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.REPORTToolStripMenuItem, Me.CToolStripMenuItem, Me.SAVEToolStripMenuItem1})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHBYNAMEToolStripMenuItem})
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'SEARCHBYNAMEToolStripMenuItem
        '
        Me.SEARCHBYNAMEToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SEARCHBYNAMEToolStripMenuItem.Name = "SEARCHBYNAMEToolStripMenuItem"
        Me.SEARCHBYNAMEToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.SEARCHBYNAMEToolStripMenuItem.Text = "SEARCH BY STUDENTS NAME"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'IMPORTSTUDENTSFROMEXCELLToolStripMenuItem
        '
        Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPLOADSTUDENTSToolStripMenuItem})
        Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem.Name = "IMPORTSTUDENTSFROMEXCELLToolStripMenuItem"
        Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem.Size = New System.Drawing.Size(201, 20)
        Me.IMPORTSTUDENTSFROMEXCELLToolStripMenuItem.Text = "IMPORT STUDENTS FROM EXCELL"
        '
        'UPLOADSTUDENTSToolStripMenuItem
        '
        Me.UPLOADSTUDENTSToolStripMenuItem.Name = "UPLOADSTUDENTSToolStripMenuItem"
        Me.UPLOADSTUDENTSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UPLOADSTUDENTSToolStripMenuItem.Text = "UPLOAD STUDENTS"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Side_Banner_51
        Me.PictureBox2.Location = New System.Drawing.Point(6, 521)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(302, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(6, 357)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = ""
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATEToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UPDATEToolStripMenuItem.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Actions_document_save_as_icon
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETEToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DELETEToolStripMenuItem.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Button_Delete_icon
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.REPORTToolStripMenuItem.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Drive_Floppy_blue_icon
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.REPORTToolStripMenuItem.Text = "REPORT"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CToolStripMenuItem.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Side_Banner_44
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CToolStripMenuItem.Text = "CONDITION"
        Me.CToolStripMenuItem.Visible = False
        '
        'SAVEToolStripMenuItem1
        '
        Me.SAVEToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.SAVEToolStripMenuItem1.Image = Global.ORIONSCHOOLACCOUNTSWIZARD.My.Resources.Resources.Top_Banner_43
        Me.SAVEToolStripMenuItem1.Name = "SAVEToolStripMenuItem1"
        Me.SAVEToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.SAVEToolStripMenuItem1.Text = "SAVE"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 702)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "ORION ACCOUNTS DEPARTMENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_term As System.Windows.Forms.ComboBox
    Friend WithEvents txt_year As System.Windows.Forms.ComboBox
    Friend WithEvents txt_class As System.Windows.Forms.ComboBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_telephone As System.Windows.Forms.TextBox
    Friend WithEvents txt_parent As System.Windows.Forms.TextBox
    Friend WithEvents txt_oname As System.Windows.Forms.TextBox
    Friend WithEvents txt_sname As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_sex As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_condition As System.Windows.Forms.ComboBox
    Friend WithEvents CONDITION As System.Windows.Forms.Label
    Friend WithEvents SEARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHBYNAMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMPORTSTUDENTSFROMEXCELLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPLOADSTUDENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
