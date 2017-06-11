<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(help))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.About = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Helptab = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tabs.SuspendLayout()
        Me.About.SuspendLayout()
        Me.Helptab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.About)
        Me.Tabs.Controls.Add(Me.Helptab)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Tabs.Location = New System.Drawing.Point(0, 0)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.Padding = New System.Drawing.Point(16, 3)
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(361, 299)
        Me.Tabs.TabIndex = 0
        '
        'About
        '
        Me.About.Controls.Add(Me.LinkLabel1)
        Me.About.Controls.Add(Me.Label3)
        Me.About.Controls.Add(Me.Label1)
        Me.About.Location = New System.Drawing.Point(4, 28)
        Me.About.Name = "About"
        Me.About.Padding = New System.Windows.Forms.Padding(3)
        Me.About.Size = New System.Drawing.Size(353, 267)
        Me.About.TabIndex = 0
        Me.About.Text = "About cryptr"
        Me.About.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 154)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(233, 19)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/lunaevans/cryptr."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "© Ben Cooley and Luna Evans, 2017"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 261)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Helptab
        '
        Me.Helptab.Controls.Add(Me.Label4)
        Me.Helptab.Controls.Add(Me.Label2)
        Me.Helptab.Location = New System.Drawing.Point(4, 28)
        Me.Helptab.Name = "Helptab"
        Me.Helptab.Padding = New System.Windows.Forms.Padding(3)
        Me.Helptab.Size = New System.Drawing.Size(353, 267)
        Me.Helptab.TabIndex = 1
        Me.Helptab.Text = "Help"
        Me.Helptab.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "© Ben Cooley and Luna Evans, 2017"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 261)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 299)
        Me.Controls.Add(Me.Tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(377, 338)
        Me.MinimumSize = New System.Drawing.Size(377, 338)
        Me.Name = "help"
        Me.Text = "cryptr Help"
        Me.Tabs.ResumeLayout(False)
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        Me.Helptab.ResumeLayout(False)
        Me.Helptab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents About As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Helptab As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
