Imports SapNwRfc
Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class PruebaConexion
    Dim connectionString As String
    'Dim connection = New SapConnection(connectionString)
    Dim WithEvents serialPort As SerialPort

    'Entrada Z_DATA_MB31
    Public Class Z_DATA_MB31_IP

        <SapName("I_AUFNR")>
        Public Property AUFNR As String

        <SapName("I_PRUEFLOS")>
        Public Property PRUEFLOS As String

    End Class

    'Salida Z_DATA_MB31 
    Public Class Z_DATA_MB31_OP

        <SapName("E_NOPASA")>
        Public Property NOPASA As String

        <SapName("E_MENSAJE")>
        Public Property MENSAJE As String
        i
    End Class

    Private Function ConectBasc() As Boolean
        MsgBox("jjjjdddddeeeiiihhhhhhhhhhh")
        Dim lPort As String = txb_Port.Text
        Dim LBaudRate As Integer = Convert.ToInt32(txb_baudRate.Text)
        Dim LDataBits As Integer = Convert.ToInt32(txb_dataBits.Text)
        'Dim LParity As String = "None"
        Dim lparityNumber As Integer
        Dim LReadBufferSize As Integer = Convert.ToInt32(txb_readBuffer.Text)

        Select Case txb_parity.Text
            Case "None"
                lparityNumber = Parity.None

            Case "Odd"
                lparityNumber = Parity.Odd

            Case "Even"
                lparityNumber = Parity.Even

            Case "Mark"
                lparityNumber = Parity.Mark

            Case "Space"
                lparityNumber = Parity.Space

            Case Else
                ' Valor inválido
                lparityNumber = Parity.None
        End Select

        serialPort = New SerialPort(lPort, LBaudRate, lparityNumber, LDataBits, StopBits.One) With {
            .ReadBufferSize = LReadBufferSize
        }

        Try
            ' Intentar abrir puerto
            serialPort.Open()
            Threading.Thread.Sleep(1000)

            ' Verificar que se abrió
            If serialPort.IsOpen Then
                ' Mostrar mensaje de éxito
                MsgBox("Conectado a báscula")

            Else
                ' Lanzar error si no se abrió
                Throw New Exception("No se pudo abrir el puerto COM")
            End If

        Catch ex As Exception
            ' Manejar error
            MsgBox(ex.Message)
            serialPort.Close()
        End Try

    End Function

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived

        Dim data As String = serialPort.ReadExisting()

        Dim peso As String = GetWeightValue(data)


        lbl_pesobasc.Invoke(Sub()
                                lbl_pesobasc.Text = peso & " Tn"
                            End Sub)

    End Sub

    Function GetWeightValue(data As String) As String

        ' Quitar caracteres no numéricos
        Dim cleanData = Regex.Replace(data, "\D", "")

        ' Convierte a número decimal
        Return Convert.ToDecimal(cleanData)

    End Function

    Private Sub btn_SAP_conn_Click(sender As Object, e As EventArgs) Handles btn_SAP_conn.Click
        ' Obtener parámetros 
        Dim server As String = txb_server.Text
        Dim sysNumber As String = txb_systemNum.Text
        Dim sysID As String = txb_systemID.Text
        Dim user As String = txb_user.Text
        Dim password As String = txb_pass.Text
        Dim client As String = txb_cliente.Text
        Dim lang As String = txb_lang.Text

        'Crear cadena de conexión 
        connectionString = $"AppServerHost={server};SystemNumber={sysNumber};User={user};Password={password};Client={client};Lang={lang}"

        ' Conectar a SAP
        Dim connection As New SapConnection(connectionString)

        Try
            connection.Connect()

            'Conexión ok
            lbl_SAP_conn.Text = "Conectado a SAP!"
            lbl_SAP_conn.BackColor = Color.Green


        Catch ex As Exception
            'Error en conexión
            lbl_SAP_conn.Text = "Error al conectar a SAP: " & ex.Message
            lbl_SAP_conn.BackColor = Color.Red
        End Try


        ' Código para ejecutar funciones, BAPIs, etc

        'connection.Disconnect()

    End Sub

    Private Sub btn_basc_conn_Click(sender As Object, e As EventArgs) Handles btn_basc_conn.Click
        ConectBasc()
    End Sub

    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Dim connection = New SapConnection(connectionString)

        Using zFunc = connection.CreateFunction("Z_DATA_MB31")
            Dim input As New Z_DATA_MB31_IP()
            input.AUFNR = txb_numOrden.Text
            input.PRUEFLOS = txb_lote.Text

            ' Invocar función pasando entrada  
            Dim output As Z_DATA_MB31_OP = zFunc.Invoke(Of Z_DATA_MB31_OP)(input)

            ' Leer resultado
            Dim noPasa As String = output.NOPASA
            Dim msg As String = output.MENSAJE

            lbl_respNoPasa.Text = noPasa
            lbl_respMsg.Text = msg
        End Using

    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs, conn As SapConnection)
        conn.Disconnect()
        serialPort.Close()
    End Sub

End Class


