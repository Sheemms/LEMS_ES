Imports System.Security.Cryptography
Module EncryptDecrypt
    Private tripleDes As New TripleDESCryptoServiceProvider

    Public Function EncryptData(ByVal ptext As String) As String
        Dim ptextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(ptext)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(ptextBytes, 0, ptextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function DecryptData(ByVal encryptedText As String) As String
        Dim encBytes() As Byte = Convert.FromBase64String(encryptedText)
        Dim ms As New System.IO.MemoryStream
        Dim decStream As New CryptoStream(ms, tripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        decStream.Write(encBytes, 0, encBytes.Length)
        decStream.FlushFinalBlock()

        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Module
