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
        Me.components = New System.ComponentModel.Container()
        Me.BtnPauseResume = New System.Windows.Forms.Button()
        Me.BtnSub = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.Label()
        Me.TxtPhoneNumber = New System.Windows.Forms.Label()
        Me.TxtGithub = New System.Windows.Forms.Label()
        Me.TxtNBox = New System.Windows.Forms.TextBox()
        Me.TxtEBox = New System.Windows.Forms.TextBox()
        Me.TxtPBox = New System.Windows.Forms.TextBox()
        Me.TxtGBox = New System.Windows.Forms.TextBox()
        Me.LblStopwatch = New System.Windows.Forms.Label()
        Me.TimerStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnPauseResume
        '
        Me.BtnPauseResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPauseResume.Location = New System.Drawing.Point(92, 302)
        Me.BtnPauseResume.Name = "BtnPauseResume"
        Me.BtnPauseResume.Size = New System.Drawing.Size(232, 38)
        Me.BtnPauseResume.TabIndex = 0
        Me.BtnPauseResume.Text = "Toogle Stopwatch (ctrl+t)"
        Me.BtnPauseResume.UseVisualStyleBackColor = True
        '
        'BtnSub
        '
        Me.BtnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSub.Location = New System.Drawing.Point(531, 367)
        Me.BtnSub.Name = "BtnSub"
        Me.BtnSub.Size = New System.Drawing.Size(145, 51)
        Me.BtnSub.TabIndex = 1
        Me.BtnSub.Text = "Submit (ctrl+s)"
        Me.BtnSub.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(13, 1)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 33)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "<back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Navneet Singh , Slidely Task 2 - Create Submission "
        '
        'TxtName
        '
        Me.TxtName.AutoSize = True
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(145, 104)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(48, 18)
        Me.TxtName.TabIndex = 4
        Me.TxtName.Text = "Name"
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoSize = True
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(145, 136)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(45, 18)
        Me.TxtEmail.TabIndex = 5
        Me.TxtEmail.Text = "Email"
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.AutoSize = True
        Me.TxtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(89, 169)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(108, 18)
        Me.TxtPhoneNumber.TabIndex = 6
        Me.TxtPhoneNumber.Text = "Phone Number"
        '
        'TxtGithub
        '
        Me.TxtGithub.AutoSize = True
        Me.TxtGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGithub.Location = New System.Drawing.Point(114, 208)
        Me.TxtGithub.Name = "TxtGithub"
        Me.TxtGithub.Size = New System.Drawing.Size(82, 36)
        Me.TxtGithub.TabIndex = 7
        Me.TxtGithub.Text = "Github Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Task 2"
        '
        'TxtNBox
        '
        Me.TxtNBox.Location = New System.Drawing.Point(234, 98)
        Me.TxtNBox.Name = "TxtNBox"
        Me.TxtNBox.Size = New System.Drawing.Size(149, 22)
        Me.TxtNBox.TabIndex = 8
        '
        'TxtEBox
        '
        Me.TxtEBox.Location = New System.Drawing.Point(234, 130)
        Me.TxtEBox.Name = "TxtEBox"
        Me.TxtEBox.Size = New System.Drawing.Size(149, 22)
        Me.TxtEBox.TabIndex = 9
        '
        'TxtPBox
        '
        Me.TxtPBox.Location = New System.Drawing.Point(234, 165)
        Me.TxtPBox.Name = "TxtPBox"
        Me.TxtPBox.Size = New System.Drawing.Size(149, 22)
        Me.TxtPBox.TabIndex = 10
        '
        'TxtGBox
        '
        Me.TxtGBox.Location = New System.Drawing.Point(234, 208)
        Me.TxtGBox.Multiline = True
        Me.TxtGBox.Name = "TxtGBox"
        Me.TxtGBox.Size = New System.Drawing.Size(149, 36)
        Me.TxtGBox.TabIndex = 11
        '
        'LblStopwatch
        '
        Me.LblStopwatch.Location = New System.Drawing.Point(405, 302)
        Me.LblStopwatch.Name = "LblStopwatch"
        Me.LblStopwatch.Size = New System.Drawing.Size(176, 38)
        Me.LblStopwatch.TabIndex = 12
        Me.LblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerStopwatch
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblStopwatch)
        Me.Controls.Add(Me.TxtGBox)
        Me.Controls.Add(Me.TxtPBox)
        Me.Controls.Add(Me.TxtEBox)
        Me.Controls.Add(Me.TxtNBox)
        Me.Controls.Add(Me.TxtGithub)
        Me.Controls.Add(Me.TxtPhoneNumber)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSub)
        Me.Controls.Add(Me.BtnPauseResume)
        Me.KeyPreview = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPauseResume As Button
    Friend WithEvents BtnSub As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtName As Label
    Friend WithEvents TxtEmail As Label
    Friend WithEvents TxtPhoneNumber As Label
    Friend WithEvents TxtGithub As Label
    Friend WithEvents TxtNBox As TextBox
    Friend WithEvents TxtEBox As TextBox
    Friend WithEvents TxtPBox As TextBox
    Friend WithEvents TxtGBox As TextBox
    Friend WithEvents LblStopwatch As Label
    Friend WithEvents TimerStopwatch As Timer
End Class
