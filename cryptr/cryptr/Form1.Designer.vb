<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Encrypt = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.TxtEncrypt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKey = New System.Windows.Forms.TextBox()
        Me.TxtDecrypt = New System.Windows.Forms.TextBox()
        Me.DecryptBtn = New System.Windows.Forms.Button()
        Me.BrowseBtn2 = New System.Windows.Forms.Button()
        Me.keypage = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtboxkey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.Encrypt.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.keypage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Encrypt)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.keypage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TabControl1.ItemSize = New System.Drawing.Size(48, 22)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(16, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 117)
        Me.TabControl1.TabIndex = 0
        '
        'Encrypt
        '
        Me.Encrypt.Controls.Add(Me.Label7)
        Me.Encrypt.Controls.Add(Me.Label1)
        Me.Encrypt.Controls.Add(Me.EncryptBtn)
        Me.Encrypt.Controls.Add(Me.BrowseBtn)
        Me.Encrypt.Controls.Add(Me.TxtEncrypt)
        Me.Encrypt.Location = New System.Drawing.Point(4, 26)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Padding = New System.Windows.Forms.Padding(3)
        Me.Encrypt.Size = New System.Drawing.Size(372, 87)
        Me.Encrypt.TabIndex = 0
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(333, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "© Ben Cooley and Luna Evans, 2017"
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(6, 39)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(360, 27)
        Me.EncryptBtn.TabIndex = 4
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Location = New System.Drawing.Point(251, 6)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(115, 27)
        Me.BrowseBtn.TabIndex = 3
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'TxtEncrypt
        '
        Me.TxtEncrypt.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TxtEncrypt.Location = New System.Drawing.Point(6, 6)
        Me.TxtEncrypt.Name = "TxtEncrypt"
        Me.TxtEncrypt.Size = New System.Drawing.Size(239, 26)
        Me.TxtEncrypt.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtKey)
        Me.TabPage2.Controls.Add(Me.TxtDecrypt)
        Me.TabPage2.Controls.Add(Me.DecryptBtn)
        Me.TabPage2.Controls.Add(Me.BrowseBtn2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 87)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(333, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Help"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "© Ben Cooley and Luna Evans, 2017"
        '
        'TxtKey
        '
        Me.TxtKey.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TxtKey.Location = New System.Drawing.Point(6, 38)
        Me.TxtKey.Name = "TxtKey"
        Me.TxtKey.Size = New System.Drawing.Size(239, 26)
        Me.TxtKey.TabIndex = 3
        '
        'TxtDecrypt
        '
        Me.TxtDecrypt.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.TxtDecrypt.Location = New System.Drawing.Point(6, 6)
        Me.TxtDecrypt.Name = "TxtDecrypt"
        Me.TxtDecrypt.Size = New System.Drawing.Size(239, 26)
        Me.TxtDecrypt.TabIndex = 2
        '
        'DecryptBtn
        '
        Me.DecryptBtn.Location = New System.Drawing.Point(251, 38)
        Me.DecryptBtn.Name = "DecryptBtn"
        Me.DecryptBtn.Size = New System.Drawing.Size(115, 27)
        Me.DecryptBtn.TabIndex = 1
        Me.DecryptBtn.Text = "Decrypt"
        Me.DecryptBtn.UseVisualStyleBackColor = True
        '
        'BrowseBtn2
        '
        Me.BrowseBtn2.Location = New System.Drawing.Point(251, 6)
        Me.BrowseBtn2.Name = "BrowseBtn2"
        Me.BrowseBtn2.Size = New System.Drawing.Size(115, 27)
        Me.BrowseBtn2.TabIndex = 0
        Me.BrowseBtn2.Text = "Browse"
        Me.BrowseBtn2.UseVisualStyleBackColor = True
        '
        'keypage
        '
        Me.keypage.Controls.Add(Me.Label6)
        Me.keypage.Controls.Add(Me.Label4)
        Me.keypage.Controls.Add(Me.txtboxkey)
        Me.keypage.Controls.Add(Me.Label3)
        Me.keypage.Location = New System.Drawing.Point(4, 26)
        Me.keypage.Name = "keypage"
        Me.keypage.Padding = New System.Windows.Forms.Padding(3)
        Me.keypage.Size = New System.Drawing.Size(372, 87)
        Me.keypage.TabIndex = 2
        Me.keypage.Text = "Passkey"
        Me.keypage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(333, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Help"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Label4.Size = New System.Drawing.Size(330, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Copy this somewhere safe. You'll need it to decrypt your files!"
        '
        'txtboxkey
        '
        Me.txtboxkey.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtboxkey.Location = New System.Drawing.Point(9, 34)
        Me.txtboxkey.Name = "txtboxkey"
        Me.txtboxkey.Size = New System.Drawing.Size(356, 26)
        Me.txtboxkey.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "© Ben Cooley and Luna Evans, 2017"
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(276, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(358, 27)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 117)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(396, 156)
        Me.MinimumSize = New System.Drawing.Size(396, 156)
        Me.Name = "Main"
        Me.Text = " cryptr - simple file encrypter/decrypter"
        Me.TabControl1.ResumeLayout(False)
        Me.Encrypt.ResumeLayout(False)
        Me.Encrypt.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.keypage.ResumeLayout(False)
        Me.keypage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Encrypt As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TxtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents EncryptBtn As System.Windows.Forms.Button
    Friend WithEvents BrowseBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DecryptBtn As System.Windows.Forms.Button
    Friend WithEvents BrowseBtn2 As System.Windows.Forms.Button
    Friend WithEvents TxtKey As System.Windows.Forms.TextBox
    Friend WithEvents TxtDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents keypage As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtboxkey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
