<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PruebaConexion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbl_numOrden = New Label()
        lbl_lote = New Label()
        txb_numOrden = New TextBox()
        txb_lote = New TextBox()
        Consultar = New Button()
        lbl_respNoPasa = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txb_cliente = New TextBox()
        txb_server = New TextBox()
        txb_systemNum = New TextBox()
        txb_systemID = New TextBox()
        txb_lang = New TextBox()
        txb_user = New TextBox()
        txb_pass = New TextBox()
        btn_SAP_conn = New Button()
        btn_basc_conn = New Button()
        lbl_SAP_conn = New Label()
        lbl_pesobasc = New Label()
        btn_stop = New Button()
        txb_dataBits = New TextBox()
        txb_baudRate = New TextBox()
        txb_Port = New TextBox()
        txb_parity = New TextBox()
        txb_readBuffer = New TextBox()
        lbl_port = New Label()
        lbl_baudRate = New Label()
        lbl_dataBits = New Label()
        lbl_parity = New Label()
        lbl_readBuffer = New Label()
        lbl_respMsg = New Label()
        SuspendLayout()
        ' 
        ' lbl_numOrden
        ' 
        lbl_numOrden.AutoSize = True
        lbl_numOrden.Location = New Point(346, 17)
        lbl_numOrden.Name = "lbl_numOrden"
        lbl_numOrden.Size = New Size(101, 15)
        lbl_numOrden.TabIndex = 0
        lbl_numOrden.Text = "Número de orden"
        ' 
        ' lbl_lote
        ' 
        lbl_lote.AutoSize = True
        lbl_lote.Location = New Point(346, 50)
        lbl_lote.Name = "lbl_lote"
        lbl_lote.Size = New Size(90, 15)
        lbl_lote.TabIndex = 1
        lbl_lote.Text = "Número de lote"
        ' 
        ' txb_numOrden
        ' 
        txb_numOrden.Location = New Point(489, 17)
        txb_numOrden.Name = "txb_numOrden"
        txb_numOrden.Size = New Size(100, 23)
        txb_numOrden.TabIndex = 2
        ' 
        ' txb_lote
        ' 
        txb_lote.Location = New Point(489, 50)
        txb_lote.Name = "txb_lote"
        txb_lote.Size = New Size(100, 23)
        txb_lote.TabIndex = 3
        ' 
        ' Consultar
        ' 
        Consultar.Location = New Point(514, 89)
        Consultar.Name = "Consultar"
        Consultar.Size = New Size(75, 23)
        Consultar.TabIndex = 4
        Consultar.Text = "Consultar"
        Consultar.UseVisualStyleBackColor = True
        ' 
        ' lbl_respNoPasa
        ' 
        lbl_respNoPasa.AutoSize = True
        lbl_respNoPasa.Location = New Point(346, 87)
        lbl_respNoPasa.Name = "lbl_respNoPasa"
        lbl_respNoPasa.Size = New Size(22, 15)
        lbl_respNoPasa.TabIndex = 5
        lbl_respNoPasa.Text = "---"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 6
        Label1.Text = "Client"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 7
        Label2.Text = "Aplication Server"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 8
        Label3.Text = "Instance Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 9
        Label4.Text = "System ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 10
        Label5.Text = "Languaje"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 11
        Label6.Text = "User"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 275)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 15)
        Label7.TabIndex = 12
        Label7.Text = "Password"
        ' 
        ' txb_cliente
        ' 
        txb_cliente.Location = New Point(132, 50)
        txb_cliente.Name = "txb_cliente"
        txb_cliente.Size = New Size(100, 23)
        txb_cliente.TabIndex = 13
        txb_cliente.Text = "040"
        ' 
        ' txb_server
        ' 
        txb_server.Location = New Point(132, 84)
        txb_server.Name = "txb_server"
        txb_server.Size = New Size(100, 23)
        txb_server.TabIndex = 14
        txb_server.Text = "mxqas001"
        ' 
        ' txb_systemNum
        ' 
        txb_systemNum.Location = New Point(132, 117)
        txb_systemNum.Name = "txb_systemNum"
        txb_systemNum.Size = New Size(100, 23)
        txb_systemNum.TabIndex = 15
        txb_systemNum.Text = "00"
        ' 
        ' txb_systemID
        ' 
        txb_systemID.Location = New Point(132, 152)
        txb_systemID.Name = "txb_systemID"
        txb_systemID.Size = New Size(100, 23)
        txb_systemID.TabIndex = 16
        txb_systemID.Text = "QAS"
        ' 
        ' txb_lang
        ' 
        txb_lang.Location = New Point(132, 193)
        txb_lang.Name = "txb_lang"
        txb_lang.Size = New Size(100, 23)
        txb_lang.TabIndex = 17
        txb_lang.Text = "EN"
        ' 
        ' txb_user
        ' 
        txb_user.Location = New Point(132, 230)
        txb_user.Name = "txb_user"
        txb_user.Size = New Size(100, 23)
        txb_user.TabIndex = 18
        ' 
        ' txb_pass
        ' 
        txb_pass.Location = New Point(132, 267)
        txb_pass.Name = "txb_pass"
        txb_pass.Size = New Size(100, 23)
        txb_pass.TabIndex = 19
        ' 
        ' btn_SAP_conn
        ' 
        btn_SAP_conn.Location = New Point(12, 335)
        btn_SAP_conn.Name = "btn_SAP_conn"
        btn_SAP_conn.Size = New Size(100, 23)
        btn_SAP_conn.TabIndex = 20
        btn_SAP_conn.Text = "Conectar SAP"
        btn_SAP_conn.UseVisualStyleBackColor = True
        ' 
        ' btn_basc_conn
        ' 
        btn_basc_conn.Location = New Point(468, 339)
        btn_basc_conn.Name = "btn_basc_conn"
        btn_basc_conn.Size = New Size(119, 23)
        btn_basc_conn.TabIndex = 21
        btn_basc_conn.Text = "Conectar Bascula"
        btn_basc_conn.UseVisualStyleBackColor = True
        ' 
        ' lbl_SAP_conn
        ' 
        lbl_SAP_conn.AutoSize = True
        lbl_SAP_conn.Location = New Point(12, 375)
        lbl_SAP_conn.Name = "lbl_SAP_conn"
        lbl_SAP_conn.Size = New Size(22, 15)
        lbl_SAP_conn.TabIndex = 22
        lbl_SAP_conn.Text = "---"
        ' 
        ' lbl_pesobasc
        ' 
        lbl_pesobasc.AutoSize = True
        lbl_pesobasc.Location = New Point(374, 343)
        lbl_pesobasc.Name = "lbl_pesobasc"
        lbl_pesobasc.Size = New Size(22, 15)
        lbl_pesobasc.TabIndex = 23
        lbl_pesobasc.Text = "---"
        ' 
        ' btn_stop
        ' 
        btn_stop.Location = New Point(348, 339)
        btn_stop.Name = "btn_stop"
        btn_stop.Size = New Size(20, 23)
        btn_stop.TabIndex = 24
        btn_stop.Text = ">>"
        btn_stop.UseVisualStyleBackColor = True
        ' 
        ' txb_dataBits
        ' 
        txb_dataBits.Location = New Point(486, 235)
        txb_dataBits.Name = "txb_dataBits"
        txb_dataBits.Size = New Size(100, 23)
        txb_dataBits.TabIndex = 25
        txb_dataBits.Text = "8"
        ' 
        ' txb_baudRate
        ' 
        txb_baudRate.Location = New Point(486, 206)
        txb_baudRate.Name = "txb_baudRate"
        txb_baudRate.Size = New Size(100, 23)
        txb_baudRate.TabIndex = 26
        txb_baudRate.Text = "9600"
        ' 
        ' txb_Port
        ' 
        txb_Port.Location = New Point(486, 177)
        txb_Port.Name = "txb_Port"
        txb_Port.Size = New Size(100, 23)
        txb_Port.TabIndex = 27
        txb_Port.Text = "COM3"
        ' 
        ' txb_parity
        ' 
        txb_parity.Location = New Point(486, 264)
        txb_parity.Name = "txb_parity"
        txb_parity.Size = New Size(100, 23)
        txb_parity.TabIndex = 28
        txb_parity.Text = "EVEN"
        ' 
        ' txb_readBuffer
        ' 
        txb_readBuffer.Location = New Point(486, 293)
        txb_readBuffer.Name = "txb_readBuffer"
        txb_readBuffer.Size = New Size(100, 23)
        txb_readBuffer.TabIndex = 29
        txb_readBuffer.Text = "4096"
        ' 
        ' lbl_port
        ' 
        lbl_port.AutoSize = True
        lbl_port.Location = New Point(346, 180)
        lbl_port.Name = "lbl_port"
        lbl_port.Size = New Size(29, 15)
        lbl_port.TabIndex = 30
        lbl_port.Text = "Port"
        ' 
        ' lbl_baudRate
        ' 
        lbl_baudRate.AutoSize = True
        lbl_baudRate.Location = New Point(346, 209)
        lbl_baudRate.Name = "lbl_baudRate"
        lbl_baudRate.Size = New Size(57, 15)
        lbl_baudRate.TabIndex = 31
        lbl_baudRate.Text = "BaudRate"
        ' 
        ' lbl_dataBits
        ' 
        lbl_dataBits.AutoSize = True
        lbl_dataBits.Location = New Point(346, 238)
        lbl_dataBits.Name = "lbl_dataBits"
        lbl_dataBits.Size = New Size(50, 15)
        lbl_dataBits.TabIndex = 32
        lbl_dataBits.Text = "DataBits"
        ' 
        ' lbl_parity
        ' 
        lbl_parity.AutoSize = True
        lbl_parity.Location = New Point(346, 267)
        lbl_parity.Name = "lbl_parity"
        lbl_parity.Size = New Size(37, 15)
        lbl_parity.TabIndex = 33
        lbl_parity.Text = "parity"
        ' 
        ' lbl_readBuffer
        ' 
        lbl_readBuffer.AutoSize = True
        lbl_readBuffer.Location = New Point(348, 296)
        lbl_readBuffer.Name = "lbl_readBuffer"
        lbl_readBuffer.Size = New Size(85, 15)
        lbl_readBuffer.TabIndex = 34
        lbl_readBuffer.Text = "ReadBufferSize"
        ' 
        ' lbl_respMsg
        ' 
        lbl_respMsg.AutoSize = True
        lbl_respMsg.Location = New Point(348, 117)
        lbl_respMsg.Name = "lbl_respMsg"
        lbl_respMsg.Size = New Size(22, 15)
        lbl_respMsg.TabIndex = 35
        lbl_respMsg.Text = "---"
        ' 
        ' PruebaConexion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 450)
        Controls.Add(lbl_respMsg)
        Controls.Add(lbl_readBuffer)
        Controls.Add(lbl_parity)
        Controls.Add(lbl_dataBits)
        Controls.Add(lbl_baudRate)
        Controls.Add(lbl_port)
        Controls.Add(txb_readBuffer)
        Controls.Add(txb_parity)
        Controls.Add(txb_Port)
        Controls.Add(txb_baudRate)
        Controls.Add(txb_dataBits)
        Controls.Add(btn_stop)
        Controls.Add(lbl_pesobasc)
        Controls.Add(lbl_SAP_conn)
        Controls.Add(btn_basc_conn)
        Controls.Add(btn_SAP_conn)
        Controls.Add(txb_pass)
        Controls.Add(txb_user)
        Controls.Add(txb_lang)
        Controls.Add(txb_systemID)
        Controls.Add(txb_systemNum)
        Controls.Add(txb_server)
        Controls.Add(txb_cliente)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_respNoPasa)
        Controls.Add(Consultar)
        Controls.Add(txb_lote)
        Controls.Add(txb_numOrden)
        Controls.Add(lbl_lote)
        Controls.Add(lbl_numOrden)
        Name = "PruebaConexion"
        Text = "PruebaConexion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_numOrden As Label
    Friend WithEvents lbl_lote As Label
    Friend WithEvents txb_numOrden As TextBox
    Friend WithEvents txb_lote As TextBox
    Friend WithEvents Consultar As Button
    Friend WithEvents lbl_respNoPasa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txb_cliente As TextBox
    Friend WithEvents txb_server As TextBox
    Friend WithEvents txb_systemNum As TextBox
    Friend WithEvents txb_systemID As TextBox
    Friend WithEvents txb_lang As TextBox
    Friend WithEvents txb_user As TextBox
    Friend WithEvents txb_pass As TextBox
    Friend WithEvents btn_SAP_conn As Button
    Friend WithEvents btn_basc_conn As Button
    Friend WithEvents lbl_SAP_conn As Label
    Friend WithEvents lbl_pesobasc As Label
    Friend WithEvents btn_stop As Button
    Friend WithEvents txb_dataBits As TextBox
    Friend WithEvents txb_baudRate As TextBox
    Friend WithEvents txb_Port As TextBox
    Friend WithEvents txb_parity As TextBox
    Friend WithEvents txb_readBuffer As TextBox
    Friend WithEvents lbl_port As Label
    Friend WithEvents lbl_baudRate As Label
    Friend WithEvents lbl_dataBits As Label
    Friend WithEvents lbl_parity As Label
    Friend WithEvents lbl_readBuffer As Label
    Friend WithEvents lbl_respMsg As Label
End Class
