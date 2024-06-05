<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SynoA1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SynoA1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Btnreturn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(372, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(243, 280)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 15)
        Label1.TabIndex = 1
        Label1.Text = "5 Centimeter Per Second"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 2
        Label2.Text = "Synopsis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(342, 60)
        Label3.TabIndex = 3
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Btnreturn
        ' 
        Btnreturn.Location = New Point(6, 12)
        Btnreturn.Name = "Btnreturn"
        Btnreturn.Size = New Size(81, 26)
        Btnreturn.TabIndex = 4
        Btnreturn.Text = "Return"
        Btnreturn.UseVisualStyleBackColor = True
        ' 
        ' SynoA1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 316)
        Controls.Add(Btnreturn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SynoA1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "5 Centimeter Per Second"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btnreturn As Button
End Class
