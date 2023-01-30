<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rs_name = New System.Windows.Forms.Label()
        Me.rs_point_amount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.car_chs = New System.Windows.Forms.ComboBox()
        Me.meter_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(45, 198)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(175, 35)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Point Amount:"
        '
        'rs_name
        '
        Me.rs_name.AutoSize = True
        Me.rs_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rs_name.Location = New System.Drawing.Point(70, 317)
        Me.rs_name.Name = "rs_name"
        Me.rs_name.Size = New System.Drawing.Size(12, 18)
        Me.rs_name.TabIndex = 5
        Me.rs_name.Text = ":"
        '
        'rs_point_amount
        '
        Me.rs_point_amount.AutoSize = True
        Me.rs_point_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rs_point_amount.Location = New System.Drawing.Point(119, 347)
        Me.rs_point_amount.Name = "rs_point_amount"
        Me.rs_point_amount.Size = New System.Drawing.Size(12, 18)
        Me.rs_point_amount.TabIndex = 6
        Me.rs_point_amount.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Enter Student Name:"
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(57, 57)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(156, 20)
        Me.name_txt.TabIndex = 8
        '
        'car_chs
        '
        Me.car_chs.FormattingEnabled = True
        Me.car_chs.Items.AddRange(New Object() {"--Type of Car--", "metal", "wood"})
        Me.car_chs.Location = New System.Drawing.Point(56, 152)
        Me.car_chs.Name = "car_chs"
        Me.car_chs.Size = New System.Drawing.Size(152, 21)
        Me.car_chs.TabIndex = 10
        Me.car_chs.Text = "--Type of Car--"
        '
        'meter_txt
        '
        Me.meter_txt.Location = New System.Drawing.Point(54, 106)
        Me.meter_txt.Name = "meter_txt"
        Me.meter_txt.Size = New System.Drawing.Size(156, 20)
        Me.meter_txt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Number of meters travelled by car:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 405)
        Me.Controls.Add(Me.meter_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.car_chs)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rs_point_amount)
        Me.Controls.Add(Me.rs_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Lyonard Spencer Orap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_enter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rs_name As Label
    Friend WithEvents rs_point_amount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents name_txt As TextBox
    Friend WithEvents car_chs As ComboBox
    Friend WithEvents meter_txt As TextBox
    Friend WithEvents Label6 As Label
End Class
