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
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Location = New System.Drawing.Point(203, 152)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(315, 50)
        Me.BtnView.TabIndex = 0
        Me.BtnView.Text = "View Submissions (ctrl + v)"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(203, 208)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(315, 50)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "Create Submission (ctrl+n)"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 49)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Navneet Singh , Slidely Task 2 - Slidely Form App"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnView)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnView As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents Label1 As Label
End Class
