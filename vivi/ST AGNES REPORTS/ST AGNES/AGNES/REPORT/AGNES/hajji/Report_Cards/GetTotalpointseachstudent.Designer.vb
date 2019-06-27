<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetTotalpointseachstudent
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
        Me.txt_name = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTBEST8 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_headteacher = New System.Windows.Forms.RichTextBox()
        Me.txt_classteacher = New System.Windows.Forms.RichTextBox()
        Me.txt_warden = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_totalpoints = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.FormattingEnabled = True
        Me.txt_name.Location = New System.Drawing.Point(16, 66)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(681, 24)
        Me.txt_name.TabIndex = 105
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblName.Location = New System.Drawing.Point(16, 27)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(627, 20)
        Me.lblName.TabIndex = 104
        Me.lblName.Text = "CLICK ON ANY STUDENT TO AUTOMATICALLY GENERATE TO POINTS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXTBEST8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_headteacher)
        Me.GroupBox1.Controls.Add(Me.txt_classteacher)
        Me.GroupBox1.Controls.Add(Me.txt_warden)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1180, 801)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "S5 AND S6 GRADING"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(17, 678)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 61)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'TXTBEST8
        '
        Me.TXTBEST8.Enabled = False
        Me.TXTBEST8.Location = New System.Drawing.Point(1412, 511)
        Me.TXTBEST8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTBEST8.Name = "TXTBEST8"
        Me.TXTBEST8.Size = New System.Drawing.Size(267, 54)
        Me.TXTBEST8.TabIndex = 9
        Me.TXTBEST8.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1417, 449)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 47)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BEST EIGHT"
        Me.Label5.Visible = False
        '
        'txt_headteacher
        '
        Me.txt_headteacher.Location = New System.Drawing.Point(1412, 368)
        Me.txt_headteacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_headteacher.Name = "txt_headteacher"
        Me.txt_headteacher.Size = New System.Drawing.Size(349, 53)
        Me.txt_headteacher.TabIndex = 7
        Me.txt_headteacher.Text = ""
        Me.txt_headteacher.Visible = False
        '
        'txt_classteacher
        '
        Me.txt_classteacher.Location = New System.Drawing.Point(1412, 251)
        Me.txt_classteacher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_classteacher.Name = "txt_classteacher"
        Me.txt_classteacher.Size = New System.Drawing.Size(349, 62)
        Me.txt_classteacher.TabIndex = 6
        Me.txt_classteacher.Text = ""
        Me.txt_classteacher.Visible = False
        '
        'txt_warden
        '
        Me.txt_warden.Location = New System.Drawing.Point(1412, 138)
        Me.txt_warden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_warden.Name = "txt_warden"
        Me.txt_warden.Size = New System.Drawing.Size(349, 58)
        Me.txt_warden.TabIndex = 5
        Me.txt_warden.Text = ""
        Me.txt_warden.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1403, 318)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HEADTEACHER"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1403, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 47)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CLASS_TEACHER"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1403, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WARDEN"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1403, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COMMENTS"
        Me.Label1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 54)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 596)
        Me.DataGridView1.TabIndex = 0
        '
        'txt_totalpoints
        '
        Me.txt_totalpoints.Enabled = False
        Me.txt_totalpoints.Location = New System.Drawing.Point(737, 66)
        Me.txt_totalpoints.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_totalpoints.Name = "txt_totalpoints"
        Me.txt_totalpoints.Size = New System.Drawing.Size(267, 22)
        Me.txt_totalpoints.TabIndex = 11
        '
        'GetTotalpointseachstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 939)
        Me.Controls.Add(Me.txt_totalpoints)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GetTotalpointseachstudent"
        Me.Text = "GetTotalpointseachstudent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_name As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTBEST8 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_headteacher As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_classteacher As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_warden As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_totalpoints As System.Windows.Forms.TextBox
End Class
