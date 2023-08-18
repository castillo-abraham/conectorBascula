Imports System.Collections.ObjectModel
Imports System.Security.Principal
Imports SapNwRfc
Public Class BaseCapturaSAP
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

    End Class

    'Entrada Z_CARGA_MB31
    Public Class Z_CARGA_MB31_IP

        <SapName("I_AUFNR")>
        Public Property AUFNR As String

        <SapName("I_PRUEFLOS")>
        Public Property PRUEFLOS As String

        <SapName("I_DATUM")>
        Public Property DATUM As String

        <SapName("I_WERKS")>
        Public Property WERKS As String

        <SapName("I_MATNR")>
        Public Property MATNR As String

        <SapName("I_GAMNG")>
        Public Property GAMNG As String

        <SapName("I_POS")>
        Public Property POS As String

        <SapName("I_SUPERV")>
        Public Property SUPERV As String

        <SapName("I_TEXTO")>
        Public Property TEXTO As String

        <SapName("I_ANCHO")>
        Public Property ANCHO As String

        <SapName("I_LARGO")>
        Public Property LARGO As String

    End Class

    'Salida Z_CARGA_MB31 
    Public Class Z_CARGA_MB31_OP
        <SapName("E_AUFNR")>
        Public Property AUFNR As String

        <SapName("E_TIPO")>
        Public Property TIPO As String

        <SapName("E_PRUEFLOS")>
        Public Property PRUEFLOS As String
        <SapName("E_DATUM")>
        Public Property DATUM As String

        <SapName("E_WERKS")>
        Public Property WERKS As String

        <SapName("E_MATNR")>
        Public Property MATNR As String

        <SapName("E_GAMNG")>
        Public Property GAMNG As String

        <SapName("E_POS")>
        Public Property POS As String

        <SapName("E_SUPERV")>
        Public Property SUPERV As String

        <SapName("E_TEXTO")>
        Public Property TEXTO As String

        <SapName("E_ANCHO")>
        Public Property ANCHO As String

        <SapName("E_LARGO")>
        Public Property LARGO As String
        <SapName("E_NOPASA")>
        Public Property NOPASA As String

        <SapName("E_MENSAJE")>
        Public Property MENSAJE As String

        <SapName("E_CHARG")>
        Public Property CHARG As String

    End Class


    Private mod_ini As New cIniArray

    ' variables globales de formulario
    Dim caption As String = "Conexión"

    Dim conn = SapConnectionManager.GetInstance().GetConnection()

    Dim sSeccion As String = "BASCULA Last Logon".Trim
    'Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & "BasculaAddin\"
    'Dim sFicINI As String = path & "Parameters.ini".Trim
    Dim sFicINI As String = mod_ini.App_Path & "Parameters.ini".Trim
    Dim s_app_path As String = mod_ini.App_Path

    Dim sclient As String = "Client".Trim,
        sServer As String = "Server".Trim,
        sInsNumber As String = "Insnumber".Trim,
        sSysId As String = "Sysid".Trim,
        slangu As String = "Langu".Trim,
        sUser As String = "User".Trim,
        sPwd As String = "Pwd".Trim,
        sValor As String = "".Trim


    Dim sport As String = "Port".Trim,
        sBaudRate As String = "BaudRate".Trim,
        sDataBits As String = "DataBits".Trim,
        sParity As String = "Parity".Trim,
        sReadBufferSize As String = "ReadBufferSize".Trim

    Dim sHorad As String = "Horad".Trim,
        sHorah As String = "Horah".Trim,
        sActHo As String = "ActHo".Trim

    Dim l_SAPLogonControl As Object 'Nuevo objeto del Control de Sap logon
    Dim l_conn As Object 'Variable para establecer conexión
    'Dim l_SAPFunction As New SAPFunctionsOCX.SAPFunctions 'Control de Funciones SAP

    Dim connection As SapNwRfc.SapConnection


    'Dim conn As SapNwRfc.RfcConfigParameters = SapNwRfc.RfcConfigParameters()
    'Dim l_SAPFunction As SapNwRfc.RfcDestination = SapNwRfc.RfcDestination(conn)

    'Dim l_Function As SAPFunctionsOCX.Function
    'Dim l_Table As SAPTableFactoryCtrl.Table

    Dim l_conect_Sap As Boolean,
        l_conect_Bas As Boolean,
        l_knownWords As New AutoCompleteStringCollection
    Dim lPeso As String            'utilizada para almacenar los datos que se reciben por el puerto
    Delegate Sub MostrarRecepcion(ByVal Texto As String) 'Delegado para asignar el valor recibido




    Private Sub ConectarSapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConectarSapToolStripMenuItem.Click
        l_conect_Sap = Me.conect_sap()
    End Sub

    Private Sub ConectarBasculaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConectarBasculaToolStripMenuItem.Click
        l_conect_Bas = Me.conect_bas()
    End Sub

    Private Sub TextBox_orden_Validating(sender As System.Object, e As System.EventArgs)

        If l_conect_Sap = True Then

            'l_SAPFunction = CreateObject("SAP.Functions")
            'l_SAPFunction.Connection = l_conn

            Dim connectionString = ""
            connection = New SapConnection(connectionString)
            connection.Connect()

            'l_Function = l_SAPFunction.Add("Z_DATA_MB31")
            Dim zDataMb31 = connection.CreateFunction("Z_DATA_MB31")
            Dim zDataMb31_input As New Z_DATA_MB31_IP()
            Dim zCargaMb31_input As New Z_CARGA_MB31_IP()


            'l_Function.Exports("I_AUFNR").value = Me.TextBox_orden.Text
            'zDataMb31_input.Exports("I_AUFNR").value = Me.TextBox_orden.Text
            'l_Function.Exports("I_PRUEFLOS").value = Me.TextBox_bach.Text

            zDataMb31_input.AUFNR = Me.TextBox_orden.Text
            Dim zDataMb31_output As Z_DATA_MB31_OP = zDataMb31.Invoke(Of Z_DATA_MB31_OP)(zDataMb31_input)

            Dim zCargaMb31 = connection.CreateFunction("Z_CARGA_MB31")
            Dim zCargaMb31_output As Z_CARGA_MB31_OP = zCargaMb31.Invoke(Of Z_CARGA_MB31_OP)(zCargaMb31_input)

            'If zDataMb31.Call = True Then
            If zDataMb31_output.NOPASA Then

                Me.TextBox_centro.Text = zCargaMb31_output.WERKS
                Me.TextBox_material.Text = zCargaMb31_output.MATNR
                Me.TextBox_lote.Text = zCargaMb31_output.PRUEFLOS
                Me.TextBox_tipo.Text = zCargaMb31_output.TIPO
                Me.TextBox_ancho_real.Text = zCargaMb31_output.ANCHO
                Me.TextBox_largo_real.Text = zCargaMb31_output.LARGO

                If zCargaMb31_output.NOPASA = "X" Then
                    Dim result = MessageBox.Show(zDataMb31_output.MENSAJE, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question)

                    Me.TextBox_material.Text = ""
                    Me.TextBox_lote.Text = ""
                    Me.TextBox_tipo.Text = ""
                    Me.TextBox_ancho_real.Text = ""
                    Me.TextBox_largo_real.Text = ""
                Else
                    l_knownWords.Add(Me.TextBox_orden.Text)
                End If

            End If
        End If

    End Sub

    Private Sub TextBox_lote_Validating(sender As System.Object, e As System.EventArgs)
        If l_conect_Sap = True Then

            Dim connectionString = ""
            connection = New SapConnection(connectionString)
            connection.Connect()

            'l_Function = l_SAPFunction.Add("Z_DATA_MB31")
            Dim zDataMb31 = connection.CreateFunction("Z_DATA_MB31")
            Dim zDataMb31_input As New Z_DATA_MB31_IP()

            'l_Function.Exports("I_AUFNR").value = Me.TextBox_orden.Text
            'l_Function.Exports("I_PRUEFLOS").value = Me.TextBox_lote.Text
            zDataMb31_input.AUFNR = Me.TextBox_orden.Text
            zDataMb31_input.PRUEFLOS = Me.TextBox_lote.Text


            Dim zDataMb31_output As Z_CARGA_MB31_OP = zDataMb31.Invoke(Of Z_CARGA_MB31_OP)(zDataMb31_input)

            'If zDataMb31.Call = True Then
            'If zDataMb31_output. = True Then
            If zDataMb31_output.NOPASA = "X" Then
                Dim result = MessageBox.Show(zDataMb31_output.MENSAJE, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question)
                Me.TextBox_lote.Text = ""
            End If

            'End If

        End If
    End Sub

    Private Sub Button_save_Click(sender As System.Object, e As System.EventArgs) Handles Button_save.Click

        If l_conect_Sap = True Then

            Dim connectionString = ""
            connection = New SapConnection(connectionString)
            connection.Connect()

            'l_Function = l_SAPFunction.Add("Z_DATA_MB31")
            'l_Function.Exports("I_AUFNR").value = Me.TextBox_orden.Text
            'l_Function.Exports("I_PRUEFLOS").value = Me.TextBox_lote.Text

            Dim zDataMb31 = connection.CreateFunction("Z_DATA_MB31")
            Dim zDataMb31_input As New Z_DATA_MB31_IP()
            zDataMb31_input.AUFNR = Me.TextBox_orden.Text
            zDataMb31_input.PRUEFLOS = Me.TextBox_lote.Text

            ''Try

            ''    ' Llamar función
            ''    Dim zDataMb31_output As Z_CARGA_MB31_OP = zDataMb31.Invoke(Of Z_CARGA_MB31_OP)(zDataMb31_input)

            ''    'Dim result = zDataMb31.Invoke(Input)

            ''    ' Procesar resultados normalmente

            ''Catch ex As SapNwRfcException

            ''    ' Hubo un error al llamar la función
            ''    MsgBox(ex.Message)

            ''End Try





            Dim zDataMb31_output As Z_DATA_MB31_OP = zDataMb31.Invoke(Of Z_DATA_MB31_OP)(zDataMb31_input)
            'If zDataMb31.Call = True Then
            If zDataMb31_output.NOPASA = "X" Then
                Dim result = MessageBox.Show(zDataMb31_output.MENSAJE, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question)

            Else
                Dim l_fecha_sap As String,
                        thisDate As Date,
                        l_Checka As Boolean

                l_Checka = check_auto()
                If l_Checka = True Then
                    Me.DateTimePicker_fecha.Text = date_turno()
                End If

                'l_Function = l_SAPFunction.Add("Z_CARGA_MB31")
                Dim zCargaMb31 = connection.CreateFunction("Z_CARGA_MB31")
                Dim zCargaMB31_input As New Z_CARGA_MB31_IP()

                thisDate = Me.DateTimePicker_fecha.Text
                l_fecha_sap = thisDate.ToString("yyyyMMdd")
                zCargaMB31_input.DATUM = l_fecha_sap
                zCargaMB31_input.AUFNR = Me.TextBox_orden.Text
                zCargaMB31_input.WERKS = Me.TextBox_centro.Text
                zCargaMB31_input.MATNR = Me.TextBox_material.Text
                zCargaMB31_input.GAMNG = Me.TextBox_peso.Text
                zCargaMB31_input.POS = Me.TextBox_posicion.Text
                zCargaMB31_input.PRUEFLOS = Me.TextBox_lote.Text
                zCargaMB31_input.SUPERV = Me.TextBox_supervisor.Text
                zCargaMB31_input.TEXTO = Me.TextBox_texto.Text
                zCargaMB31_input.ANCHO = Me.TextBox_ancho_real.Text
                zCargaMB31_input.LARGO = Me.TextBox_largo_real.Text

                Dim zCargaMb31_output As Z_CARGA_MB31_OP = zCargaMb31.Invoke(Of Z_CARGA_MB31_OP)(zCargaMB31_input)
                'If zCargaMb31.Call = True Then
                If zCargaMb31_output.NOPASA = "X" Then
                    Me.TextBox_bach.Clear()
                    Dim result = MessageBox.Show(zCargaMb31_output.MENSAJE, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question)

                Else
                    Me.TextBox_bach.Text = zCargaMb31_output.CHARG
                    Dim result = MessageBox.Show(zCargaMb31_output.MENSAJE, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question)

                    My.Computer.Clipboard.SetText(zCargaMb31_output.MENSAJE)

                End If

                'End If
            End If
        Else
            Dim result = MessageBox.Show("No hay conexión a Sap", caption,
             MessageBoxButtons.OK,
             MessageBoxIcon.Question)
        End If

        'Else

        '    Dim result = MessageBox.Show("No hay conexión a Sap", caption,
        '     MessageBoxButtons.OK,
        '     MessageBoxIcon.Question)

        'End If


    End Sub

    Private Sub base_captura_sap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim currentUser As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As New WindowsPrincipal(currentUser)

        Dim esAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator)

        'Dim esAdmin As Boolean = My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator)
        'Me.ParametrosToolStripMenuItem.Enabled = esAdmin

        Me.TextBox_orden.AutoCompleteCustomSource = l_knownWords
        Me.TextBox_orden.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TextBox_orden.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParametrosToolStripMenuItem.Click
        Dim fpara As New Parametros
        fpara.ShowDialog(Me)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim facercade As New AboutBox
        facercade.ShowDialog(Me)
    End Sub

    Private Function conect_sap() As Boolean

        Dim lNewPwd As String

        'Logon SAP...
        l_SAPLogonControl = CreateObject("SAP.LogonControl.1")
        l_conn = l_SAPLogonControl.NewConnection
        l_conn.Client = mod_ini.IniGet(sFicINI, sSeccion, sclient, sValor)
        l_conn.ApplicationServer = mod_ini.IniGet(sFicINI, sSeccion, sServer, sValor)
        l_conn.SystemNumber = mod_ini.IniGet(sFicINI, sSeccion, sInsNumber, sValor)
        l_conn.System = mod_ini.IniGet(sFicINI, sSeccion, sSysId, sValor)
        l_conn.User = mod_ini.IniGet(sFicINI, sSeccion, sUser, sValor)
        lNewPwd = mod_ini.IniGet(sFicINI, sSeccion, sPwd, sValor)
        l_conn.Password = mod_ini.DesEncripta(lNewPwd)

        If l_conn.Logon(0, False) Then
            Me.ToolStripStatusLabel_sap.Text = "Conexion SAP ON"
            Me.ToolStripStatusLabel_sap.ForeColor = Color.Green
            Return True
        Else
            Dim message As String = "No se pudo establecer la Conexion a SAP, verifique parametros"
            Dim result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question)
            Me.ToolStripStatusLabel_sap.Text = "Conexion SAP OFF"
            Me.ToolStripStatusLabel_sap.ForeColor = Color.Red
            Return False
        End If

    End Function
    Private Function ConnectSap() As Boolean

        ' Leer parámetros de conexión del INI
        Dim sFicINI As String = "..."
        Dim sSeccion As String = "..."
        Dim sServer As String = mod_ini.IniGet(sFicINI, sSeccion, "Server", "")
        Dim sSystemNumber As String = mod_ini.IniGet(sFicINI, sSeccion, "SystemNumber", "")
        Dim sUser As String = mod_ini.IniGet(sFicINI, sSeccion, "User", "")
        Dim sPassword As String = mod_ini.IniGet(sFicINI, sSeccion, "Password", "")
        Dim sClient As String = mod_ini.IniGet(sFicINI, sSeccion, "Client", "")
        Dim sLanguage As String = mod_ini.IniGet(sFicINI, sSeccion, "Language", "")

        ' Crear cadena de conexión 
        Dim connectionString As String =
    "AppServerHost={0};SystemNumber={1};User={2};Password={3};Client={4};Language={5}"

        connectionString = String.Format(connectionString, sServer, sSystemNumber, sUser, sPassword, sClient, sLanguage)

        ' Intentar conectar
        Try

            Using connection As New SapConnection(connectionString)
                connection.Connect()

                ' Éxito
                ToolStripStatusLabel_sap.Text = "Conexión SAP ON"
                ToolStripStatusLabel_sap.ForeColor = Color.Green

                Return True

            End Using

        Catch ex As SapNwRfc.Exceptions.SapException

            ' Error 
            ToolStripStatusLabel_sap.Text = "Conexión SAP OFF"
            ToolStripStatusLabel_sap.ForeColor = Color.Red

            Return False

        End Try

    End Function
    Private Function conect_bas() As Boolean

        Dim lPort As String,
            LBaudRate As String,
            LDataBits As String,
            LParity As String,
            LReadBufferSize As String

        lPort = mod_ini.IniGet(sFicINI, sSeccion, sport, sValor)
        LBaudRate = mod_ini.IniGet(sFicINI, sSeccion, sBaudRate, sValor)
        LDataBits = mod_ini.IniGet(sFicINI, sSeccion, sDataBits, sValor)
        LParity = mod_ini.IniGet(sFicINI, sSeccion, sParity, sValor)
        LReadBufferSize = mod_ini.IniGet(sFicINI, sSeccion, sReadBufferSize, sValor)

        If Me.SerialPort_bascula.IsOpen = False Then
            Try
                With SerialPort_bascula
                    .PortName = lPort
                    .BaudRate = LBaudRate '// 9600 baud rate
                    .DataBits = LDataBits '// 8 data bits
                    .ReadBufferSize = LReadBufferSize '// 2048

                    If LParity = "None" Then
                        .Parity = IO.Ports.Parity.None
                    ElseIf LParity = "Odd" Then
                        .Parity = IO.Ports.Parity.Odd
                    ElseIf LParity = "Even" Then
                        .Parity = IO.Ports.Parity.Even
                    ElseIf LParity = "Mark" Then
                        .Parity = IO.Ports.Parity.Mark
                    ElseIf LParity = "Space" Then
                        .Parity = IO.Ports.Parity.Space
                    End If

                    .Handshake = IO.Ports.Handshake.None
                    .StopBits = IO.Ports.StopBits.One '// 1 Stop bit
                    '.DtrEnable = False
                    '.WriteBufferSize = 1024
                    '.WriteTimeout = 500
                    '.Encoding = System.Text.Encoding.Default
                    .Open() ' ABRE EL PUERTO SERIE
                End With

            Catch ex As Exception
                MsgBox("No se pudo establecer la Conexion a la Bascula, verifique parametros: " & ex.Message, MsgBoxStyle.Critical)
            End Try

            If Me.SerialPort_bascula.IsOpen = True Then
                Me.ToolStripStatusLabel_bascula.Text = "Conexión Bascula ON"
                Me.ToolStripStatusLabel_bascula.ForeColor = Color.Green
                Return True
            Else
                Return False
            End If

        Else

            Me.SerialPort_bascula.Close()
            Me.ToolStripStatusLabel_bascula.Text = "Conexión Bascula OFF"
            Me.ToolStripStatusLabel_bascula.ForeColor = Color.Red
            Return False
        End If

    End Function

    Private Sub SerialPort_bascula_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_bascula.DataReceived
        Try

            Dim indata As String = SerialPort_bascula.ReadExisting()

            MostrarRececibidos(indata)

        Catch ex As Exception

            '        MsgBox(ex.Message)

        End Try

    End Sub

    ' Mostrar los bytes recibidos en el Label recibidos
    Private Sub MostrarRececibidos(ByVal [texto] As String)
        If Me.TextBox_peso.InvokeRequired Then

            Dim delegado As New MostrarRecepcion(AddressOf MostrarRececibidos)
            Me.Invoke(delegado, New Object() {[texto]})

        Else

            lPeso = [texto]
            lPeso = lPeso.Remove(0, 5)
            lPeso = lPeso.Remove(7)

            Me.TextBox_peso.Text = lPeso / 1000

        End If

    End Sub

    Private Function date_turno() As Date

        Dim l_hora As String,
            lHorad As String,
            lHorah As String

        ' Revisamos que la hora sea de un turno anterior
        lHorad = mod_ini.IniGet(sFicINI, sSeccion, sHorad, sValor)
        lHorah = mod_ini.IniGet(sFicINI, sSeccion, sHorah, sValor)
        l_hora = Date.Now.ToString("HH:mm:ss")
        If l_hora < lHorah Then
            Return Date.Now.AddDays(-1)
        Else
            Return Date.Now
        End If

    End Function

    Private Function check_auto() As Boolean

        Dim lActHo As String,
            lcheckac As Boolean

        lActHo = mod_ini.IniGet(sFicINI, sSeccion, sActHo, sValor)

        If lActHo = "" Then
            lcheckac = False
        Else
            lcheckac = lActHo
        End If

        Return lcheckac

    End Function

    Private Sub LimpiarDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarDatosToolStripMenuItem.Click

        Dim l_Checka As Boolean

        l_Checka = check_auto()
        If l_Checka = True Then
            Me.DateTimePicker_fecha.Text = date_turno()
        End If

        Me.TextBox_orden.Clear()
        Me.TextBox_centro.Clear()
        Me.TextBox_material.Clear()
        Me.TextBox_lote.Clear()
        Me.TextBox_supervisor.Clear()
        Me.TextBox_texto.Clear()
        Me.TextBox_tipo.Clear()
        Me.TextBox_ancho_real.Clear()
        Me.TextBox_largo_real.Clear()
        Me.TextBox_peso.Clear()
        Me.TextBox_bach.Clear()
        Me.RadioButton_A.Checked = False
        Me.RadioButton_B.Checked = False
        Me.RadioButton_C.Checked = False
        Me.RadioButton_D.Checked = False
        Me.RadioButton_E.Checked = False
        Me.RadioButton_F.Checked = False
        Me.TextBox_posicion.Clear()

    End Sub

    Private Sub RadioButton_A_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_A.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_A.Text
    End Sub

    Private Sub RadioButton_B_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_B.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_B.Text
    End Sub

    Private Sub RadioButton_C_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_C.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_C.Text
    End Sub

    Private Sub RadioButton_D_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_D.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_D.Text
    End Sub

    Private Sub RadioButton_E_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_E.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_E.Text
    End Sub

    Private Sub RadioButton_F_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_F.CheckedChanged
        Me.TextBox_posicion.Text = Me.RadioButton_F.Text
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        ' LA DESCONEXION DE SAP Y DE LA BASCULA ANTES DEL CLOSE HACE QUE SE PASME LA APLICACIÓN
        'If l_conect_Sap = True Then
        '    l_conn.Logoff()
        'End If
        'Me.SerialPort_bascula.Close()

        Me.Close()
    End Sub

    Private Sub HerramientasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HerramientasToolStripMenuItem.Click

    End Sub

    Private Sub ToolTip_captura_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip_captura.Popup

    End Sub
End Class