<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions
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
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.transfer = New System.Windows.Forms.GroupBox
        Me.transfer.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(64, 49)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Your aacount"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(64, 123)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Amount"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(64, 85)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Select Account"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(186, 123)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(92, 24)
        Me.textBox1.TabIndex = 3
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(186, 46)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(92, 24)
        Me.textBox3.TabIndex = 5
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(102, 163)
        Me.button3.Margin = New System.Windows.Forms.Padding(2)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(89, 28)
        Me.button3.TabIndex = 6
        Me.button3.Text = "Transfer"
        Me.button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(220, 163)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(186, 85)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(92, 25)
        Me.comboBox1.TabIndex = 7
        '
        'transfer
        '
        Me.transfer.Controls.Add(Me.comboBox1)
        Me.transfer.Controls.Add(Me.Button1)
        Me.transfer.Controls.Add(Me.button3)
        Me.transfer.Controls.Add(Me.textBox3)
        Me.transfer.Controls.Add(Me.textBox1)
        Me.transfer.Controls.Add(Me.label3)
        Me.transfer.Controls.Add(Me.label2)
        Me.transfer.Controls.Add(Me.label1)
        Me.transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transfer.Location = New System.Drawing.Point(52, 47)
        Me.transfer.Margin = New System.Windows.Forms.Padding(2)
        Me.transfer.Name = "transfer"
        Me.transfer.Padding = New System.Windows.Forms.Padding(2)
        Me.transfer.Size = New System.Drawing.Size(430, 217)
        Me.transfer.TabIndex = 4
        Me.transfer.TabStop = False
        Me.transfer.Text = "Transfer Money"
        '
        'transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 328)
        Me.Controls.Add(Me.transfer)
        Me.Name = "transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "transactions"
        Me.transfer.ResumeLayout(False)
        Me.transfer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents textBox1 As System.Windows.Forms.TextBox
    Public WithEvents textBox3 As System.Windows.Forms.TextBox
    Public WithEvents button3 As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents transfer As System.Windows.Forms.GroupBox
End Class
