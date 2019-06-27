<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENTS_EXTRA_SUBJECTS_ALEVEL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_student = New System.Windows.Forms.ComboBox()
        Me.txt_class = New System.Windows.Forms.ComboBox()
        Me.txt_term = New System.Windows.Forms.ComboBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_subject = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLASS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TERM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "YEAR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "DELETE EXTRA SUBJECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SUBJECT"
        '
        'txt_student
        '
        Me.txt_student.FormattingEnabled = True
        Me.txt_student.Location = New System.Drawing.Point(78, 177)
        Me.txt_student.Name = "txt_student"
        Me.txt_student.Size = New System.Drawing.Size(251, 21)
        Me.txt_student.TabIndex = 6
        '
        'txt_class
        '
        Me.txt_class.FormattingEnabled = True
        Me.txt_class.Location = New System.Drawing.Point(78, 25)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(251, 21)
        Me.txt_class.TabIndex = 7
        '
        'txt_term
        '
        Me.txt_term.FormattingEnabled = True
        Me.txt_term.Items.AddRange(New Object() {"ONE", "TWO", "THREE"})
        Me.txt_term.Location = New System.Drawing.Point(78, 137)
        Me.txt_term.Name = "txt_term"
        Me.txt_term.Size = New System.Drawing.Size(251, 21)
        Me.txt_term.TabIndex = 8
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(78, 99)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(251, 20)
        Me.txt_year.TabIndex = 9
        '
        'txt_subject
        '
        Me.txt_subject.FormattingEnabled = True
        Me.txt_subject.Items.AddRange(New Object() {"MATHEMATICS", "PHYSICS", "CHEMISTRY", "BIOLOGY", "AGRICULTURE", "HISTORY", "GEOGRAPHY", "COMMERCE", "IRE", "DIVINITY", "ENTRPRENUERSHIP", "GP", "ICT", "FINE ART"})
        Me.txt_subject.Location = New System.Drawing.Point(78, 221)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(251, 21)
        Me.txt_subject.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(335, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(36, 17)
        Me.DataGridView1.TabIndex = 11
        Me.DataGridView1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "LOAD STUDENTS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'STUDENTS_EXTRA_SUBJECTS_ALEVEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 304)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_term)
        Me.Controls.Add(Me.txt_class)
        Me.Controls.Add(Me.txt_student)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "STUDENTS_EXTRA_SUBJECTS_ALEVEL"
        Me.Text = "STUDENTS_EXTRA_SUBJECTS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_student As System.Windows.Forms.ComboBox
    Friend WithEvents txt_class As System.Windows.Forms.ComboBox
    Friend WithEvents txt_term As System.Windows.Forms.ComboBox
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents txt_subject As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
