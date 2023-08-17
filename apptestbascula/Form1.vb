Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports SapNwRfc

Public Class Form1

    Dim connectionString As String = "AppServerHost=173.45.87.26; SystemNumber=00; User=eosoriop; Password=Michi.1000; Client=100; Language=ES"
    Dim connection = New SapConnection(connectionString)
    Public Class ZFuncInputParams
        <SapName("COMPANIA")>
        Public Property I_CCODE() As String
    End Class

    Public Class ZFuncOutputParams
        <SapName("DATE")>
        Public Property Result() As String
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sapConnect.Click
        connection.Connect()
    End Sub

    Private Sub RFC_func_Click(sender As Object, e As EventArgs) Handles RFC_func.Click
        Using zFuncPrueba = connection.CreateFunction("Z_EJEMPLO_SIMPLE")
            Dim input As New ZFuncInputParams()
            input.I_CCODE = txb_ccode.Text

            ' Invocar función pasando entrada  
            Dim output As ZFuncOutputParams = zFuncPrueba.Invoke(Of ZFuncOutputParams)(input)

            ' Leer resultado
            Dim result = output.Result
            c_date.Text = result


        End Using
    End Sub
End Class
