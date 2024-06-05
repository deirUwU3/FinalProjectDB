<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Data = New DataGridView()
        combo1 = New ComboBox()
        Box1 = New TextBox()
        Button1 = New Button()
        Menu = New MenuStrip()
        NewAddedNovelToolStripMenuItem = New ToolStripMenuItem()
        TxtSummary = New TextBox()
        Label1 = New Label()
        BtnId = New Button()
        CType(Data, ComponentModel.ISupportInitialize).BeginInit()
        Menu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Data
        ' 
        Data.AllowUserToAddRows = False
        Data.AllowUserToDeleteRows = False
        Data.AllowUserToOrderColumns = True
        Data.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data.Location = New Point(12, 104)
        Data.Name = "Data"
        Data.ReadOnly = True
        Data.Size = New Size(579, 244)
        Data.TabIndex = 0
        ' 
        ' combo1
        ' 
        combo1.DropDownStyle = ComboBoxStyle.DropDownList
        combo1.FormattingEnabled = True
        combo1.Location = New Point(12, 30)
        combo1.Name = "combo1"
        combo1.Size = New Size(217, 23)
        combo1.TabIndex = 1
        ' 
        ' Box1
        ' 
        Box1.Location = New Point(12, 59)
        Box1.Name = "Box1"
        Box1.Size = New Size(130, 23)
        Box1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(148, 59)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 27)
        Button1.TabIndex = 3
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        Menu.Items.AddRange(New ToolStripItem() {NewAddedNovelToolStripMenuItem})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Size = New Size(603, 24)
        Menu.TabIndex = 4
        Menu.Text = "MenuStrip1"
        ' 
        ' NewAddedNovelToolStripMenuItem
        ' 
        NewAddedNovelToolStripMenuItem.Name = "NewAddedNovelToolStripMenuItem"
        NewAddedNovelToolStripMenuItem.Size = New Size(115, 20)
        NewAddedNovelToolStripMenuItem.Text = "New Added Novel"
        ' 
        ' TxtSummary
        ' 
        TxtSummary.Location = New Point(331, 63)
        TxtSummary.Name = "TxtSummary"
        TxtSummary.Size = New Size(164, 23)
        TxtSummary.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(331, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 6
        Label1.Text = "Synopsis/Preview"
        ' 
        ' BtnId
        ' 
        BtnId.Location = New Point(501, 59)
        BtnId.Name = "BtnId"
        BtnId.Size = New Size(75, 27)
        BtnId.TabIndex = 7
        BtnId.Text = "Search ID"
        BtnId.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 360)
        Controls.Add(BtnId)
        Controls.Add(Label1)
        Controls.Add(TxtSummary)
        Controls.Add(Button1)
        Controls.Add(Box1)
        Controls.Add(combo1)
        Controls.Add(Data)
        Controls.Add(Menu)
        MainMenuStrip = Menu
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Data, ComponentModel.ISupportInitialize).EndInit()
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data As DataGridView
    Friend WithEvents combo1 As ComboBox
    Friend WithEvents Box1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents NewAddedNovelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtSummary As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnId As Button

End Class
