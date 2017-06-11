Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Main

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        help.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        help.Show()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        help.Show()
    End Sub

    Function GenerateKey() As String
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()
        Return ASCIIEncoding.ASCII.GetString(desCrypto.Key)
    End Function

    Sub EncryptFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)
        Dim fsInput As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFilename, FileMode.Create, FileAccess.Write)
        Dim DES As New DESCryptoServiceProvider()
        DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey)
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)
        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim cryptostream As New CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write)
        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub

    Sub DecryptFile(ByVal sInputFilename As String, ByVal sOutputFilename As String, ByVal sKey As String)
        Dim DES As New DESCryptoServiceProvider()
        DES.Key() = ASCIIEncoding.ASCII.GetBytes(sKey)
        DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey)
        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)
        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

    Private Sub BrowseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBtn.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TxtEncrypt.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub EncryptBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptBtn.Click
        If Not TxtEncrypt.Text = "" Then
            Dim secretkey As String
            secretkey = GenerateKey()
            EncryptFile(TxtEncrypt.Text, TxtEncrypt.Text + ".encrypted", secretkey)
            txtboxkey.Text = secretkey
            TabControl1.SelectedTab = keypage
        Else
            MessageBox.Show("Select a file to encrypt", "Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BrowseBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBtn2.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            TxtDecrypt.Text = OpenFileDialog2.FileName.ToString
        End If
    End Sub

    Private Sub DecryptBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptBtn.Click
        If Not TxtDecrypt.Text = "" Then
            If Not TxtKey.Text = "" Then
                DecryptFile(TxtDecrypt.Text, TxtDecrypt.Text + ".txt", TxtKey.Text)
                MessageBox.Show("Decryption completed! File: " + TxtDecrypt.Text + ".txt", "Decryption", MessageBoxButtons.OK)
            Else
                MessageBox.Show("You need a key to decrypt your file", "Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Select a file to decrypt", "Decrypt", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
