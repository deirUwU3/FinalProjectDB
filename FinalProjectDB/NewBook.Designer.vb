<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBook
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
        Label1 = New Label()
        Txt1 = New TextBox()
        Txt2 = New TextBox()
        Label2 = New Label()
        Txt3 = New TextBox()
        Label3 = New Label()
        Txt4 = New TextBox()
        Label4 = New Label()
        Txt5 = New TextBox()
        Label5 = New Label()
        Badd = New Button()
        Bcancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 0
        Label1.Text = "New ID"
        ' 
        ' Txt1
        ' 
        Txt1.BorderStyle = BorderStyle.FixedSingle
        Txt1.Location = New Point(17, 41)
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(256, 23)
        Txt1.TabIndex = 1
        ' 
        ' Txt2
        ' 
        Txt2.BorderStyle = BorderStyle.FixedSingle
        Txt2.Location = New Point(17, 85)
        Txt2.Name = "Txt2"
        Txt2.Size = New Size(256, 23)
        Txt2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 2
        Label2.Text = "New Book Name"
        ' 
        ' Txt3
        ' 
        Txt3.BorderStyle = BorderStyle.FixedSingle
        Txt3.Location = New Point(17, 131)
        Txt3.Name = "Txt3"
        Txt3.Size = New Size(256, 23)
        Txt3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 4
        Label3.Text = "Author Name"
        ' 
        ' Txt4
        ' 
        Txt4.BorderStyle = BorderStyle.FixedSingle
        Txt4.Location = New Point(17, 178)
        Txt4.Name = "Txt4"
        Txt4.Size = New Size(256, 23)
        Txt4.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 6
        Label4.Text = "Publish Year"
        ' 
        ' Txt5
        ' 
        Txt5.BorderStyle = BorderStyle.FixedSingle
        Txt5.Location = New Point(17, 227)
        Txt5.Name = "Txt5"
        Txt5.Size = New Size(256, 23)
        Txt5.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 8
        Label5.Text = "Price"
        ' 
        ' Badd
        ' 
        Badd.Enabled = False
        Badd.Location = New Point(17, 268)
        Badd.Name = "Badd"
        Badd.Size = New Size(116, 38)
        Badd.TabIndex = 10
        Badd.Text = "Add and Save"
        Badd.UseVisualStyleBackColor = True
        ' 
        ' Bcancel
        ' 
        Bcancel.Location = New Point(139, 268)
        Bcancel.Name = "Bcancel"
        Bcancel.Size = New Size(116, 38)
        Bcancel.TabIndex = 11
        Bcancel.Text = "Cancel"
        Bcancel.UseVisualStyleBackColor = True
        ' 
        ' NewBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(357, 343)
        ControlBox = False
        Controls.Add(Bcancel)
        Controls.Add(Badd)
        Controls.Add(Txt5)
        Controls.Add(Label5)
        Controls.Add(Txt4)
        Controls.Add(Label4)
        Controls.Add(Txt3)
        Controls.Add(Label3)
        Controls.Add(Txt2)
        Controls.Add(Label2)
        Controls.Add(Txt1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "NewBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Book Add"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Badd As Button
    Friend WithEvents Bcancel As Button
End Class
