<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balance_Enquiry
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
        Me.balanceenq = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.button7 = New System.Windows.Forms.Button
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.balanceen = New System.Windows.Forms.Label
        Me.balanceenq.SuspendLayout()
        Me.SuspendLayout()
        '
        'balanceenq
        '
        Me.balanceenq.Controls.Add(Me.Button1)
        Me.balanceenq.Controls.Add(Me.button7)
        Me.balanceenq.Controls.Add(Me.textBox2)
        Me.balanceenq.Controls.Add(Me.textBox1)
        Me.balanceenq.Controls.Add(Me.comboBox1)
        Me.balanceenq.Controls.Add(Me.label4)
        Me.balanceenq.Controls.Add(Me.label3)
        Me.balanceenq.Controls.Add(Me.label2)
        Me.balanceenq.Controls.Add(Me.balanceen)
        Me.balanceenq.Location = New System.Drawing.Point(88, 50)
        Me.balanceenq.Margin = New System.Windows.Forms.Padding(2)
        Me.balanceenq.Name = "balanceenq"
        Me.balanceenq.Padding = New System.Windows.Forms.Padding(2)
        Me.balanceenq.Size = New System.Drawing.Size(418, 262)
        Me.balanceenq.TabIndex = 8
        Me.balanceenq.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 19)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Check Balance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button7
        '
        Me.button7.Location = New System.Drawing.Point(268, 174)
        Me.button7.Margin = New System.Windows.Forms.Padding(2)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(110, 19)
        Me.button7.TabIndex = 11
        Me.button7.Text = "back"
        Me.button7.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(250, 130)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(92, 20)
        Me.textBox2.TabIndex = 10
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(250, 93)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(92, 20)
        Me.textBox1.TabIndex = 9
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(250, 55)
        Me.comboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(92, 21)
        Me.comboBox1.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(70, 58)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(102, 17)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Select Account"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(70, 93)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(146, 17)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Account Holder Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(70, 132)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(119, 17)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Available balance"
        '
        'balanceen
        '
        Me.balanceen.AutoSize = True
        Me.balanceen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceen.Location = New System.Drawing.Point(4, 0)
        Me.balanceen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.balanceen.Name = "balanceen"
        Me.balanceen.Size = New System.Drawing.Size(111, 17)
        Me.balanceen.TabIndex = 5
        Me.balanceen.Text = "Balance Enquiry"
        '
        'balance_Enquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 335)
        Me.Controls.Add(Me.balanceenq)
        Me.Name = "balance_Enquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "balance_Enquiry"
        Me.balanceenq.ResumeLayout(False)
        Me.balanceenq.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents balanceenq As System.Windows.Forms.GroupBox
    Public WithEvents button7 As System.Windows.Forms.Button
    Public WithEvents textBox2 As System.Windows.Forms.TextBox
    Public WithEvents textBox1 As System.Windows.Forms.TextBox
    Public WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents balanceen As System.Windows.Forms.Label
    Public WithEvents Button1 As System.Windows.Forms.Button
End Class
