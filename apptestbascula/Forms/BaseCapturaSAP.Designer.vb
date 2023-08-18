<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseCapturaSAP
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
        components = New ComponentModel.Container()
        Dim AsciiEncoding1 As Text.ASCIIEncoding = New Text.ASCIIEncoding()
        Dim DecoderReplacementFallback1 As Text.DecoderReplacementFallback = New Text.DecoderReplacementFallback()
        Dim EncoderReplacementFallback1 As Text.EncoderReplacementFallback = New Text.EncoderReplacementFallback()
        GroupBox_bach = New GroupBox()
        TextBox_bach = New TextBox()
        GroupBox_peso = New GroupBox()
        TextBox_peso = New TextBox()
        GroupBox_caracteristicas = New GroupBox()
        Label_tipo = New Label()
        TextBox_tipo = New TextBox()
        Label_ancho_real = New Label()
        TextBox_ancho_real = New TextBox()
        Label_largo_real = New Label()
        TextBox_largo_real = New TextBox()
        GroupBox_datap = New GroupBox()
        RadioButton_F = New RadioButton()
        RadioButton_E = New RadioButton()
        RadioButton_D = New RadioButton()
        RadioButton_C = New RadioButton()
        RadioButton_B = New RadioButton()
        RadioButton_A = New RadioButton()
        DateTimePicker_fecha = New DateTimePicker()
        TextBox_texto = New TextBox()
        Label_supervisor = New Label()
        Label_lote = New Label()
        Label_posicion = New Label()
        Label_material = New Label()
        Label_texto = New Label()
        Label_centro = New Label()
        TextBox_supervisor = New TextBox()
        TextBox_lote = New TextBox()
        TextBox_posicion = New TextBox()
        TextBox_material = New TextBox()
        TextBox_centro = New TextBox()
        TextBox_orden = New TextBox()
        Label_orden = New Label()
        Label_fecha = New Label()
        BottomToolStripPanel = New ToolStripPanel()
        TopToolStripPanel = New ToolStripPanel()
        RightToolStripPanel = New ToolStripPanel()
        ToolStripPanel = New ToolStripPanel()
        ContentPanel = New ToolStripContentPanel()
        Button_save = New Button()
        PictureBox_smurfit = New PictureBox()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel_mb31 = New ToolStripStatusLabel()
        ToolStripStatusLabel_slash2 = New ToolStripStatusLabel()
        ToolStripStatusLabel_bascula = New ToolStripStatusLabel()
        ToolStripStatusLabel_slash1 = New ToolStripStatusLabel()
        ToolStripStatusLabel_sap = New ToolStripStatusLabel()
        ToolTip_captura = New ToolTip(components)
        SerialPort_bascula = New IO.Ports.SerialPort(components)
        MenuStrip_Bascula = New MenuStrip()
        INICIOToolStripMenuItem = New ToolStripMenuItem()
        ConectarSapToolStripMenuItem = New ToolStripMenuItem()
        ConectarBasculaToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        LimpiarDatosToolStripMenuItem = New ToolStripMenuItem()
        SistemasToolStripMenuItem = New ToolStripMenuItem()
        ParametrosToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        GroupBox_bach.SuspendLayout()
        GroupBox_peso.SuspendLayout()
        GroupBox_caracteristicas.SuspendLayout()
        GroupBox_datap.SuspendLayout()
        CType(PictureBox_smurfit, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip.SuspendLayout()
        MenuStrip_Bascula.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox_bach
        ' 
        GroupBox_bach.Controls.Add(TextBox_bach)
        GroupBox_bach.Font = New Font("Harrington", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox_bach.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        GroupBox_bach.Location = New Point(902, 638)
        GroupBox_bach.Margin = New Padding(4, 3, 4, 3)
        GroupBox_bach.Name = "GroupBox_bach"
        GroupBox_bach.Padding = New Padding(4, 3, 4, 3)
        GroupBox_bach.Size = New Size(468, 151)
        GroupBox_bach.TabIndex = 49
        GroupBox_bach.TabStop = False
        GroupBox_bach.Text = "Bach "
        ' 
        ' TextBox_bach
        ' 
        TextBox_bach.BorderStyle = BorderStyle.None
        TextBox_bach.Font = New Font("Modern No. 20", 48.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_bach.ForeColor = Color.Red
        TextBox_bach.Location = New Point(7, 46)
        TextBox_bach.Margin = New Padding(4, 3, 4, 3)
        TextBox_bach.Name = "TextBox_bach"
        TextBox_bach.ReadOnly = True
        TextBox_bach.Size = New Size(441, 69)
        TextBox_bach.TabIndex = 24
        TextBox_bach.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox_peso
        ' 
        GroupBox_peso.Controls.Add(TextBox_peso)
        GroupBox_peso.Font = New Font("Harrington", 24.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox_peso.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        GroupBox_peso.Location = New Point(902, 402)
        GroupBox_peso.Margin = New Padding(4, 3, 4, 3)
        GroupBox_peso.Name = "GroupBox_peso"
        GroupBox_peso.Padding = New Padding(4, 3, 4, 3)
        GroupBox_peso.Size = New Size(468, 238)
        GroupBox_peso.TabIndex = 48
        GroupBox_peso.TabStop = False
        GroupBox_peso.Text = "Peso en Toneladas"
        ' 
        ' TextBox_peso
        ' 
        TextBox_peso.BackColor = SystemColors.Control
        TextBox_peso.BorderStyle = BorderStyle.None
        TextBox_peso.Font = New Font("Modern No. 20", 48.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_peso.ForeColor = Color.Blue
        TextBox_peso.Location = New Point(28, 85)
        TextBox_peso.Margin = New Padding(4, 3, 4, 3)
        TextBox_peso.Name = "TextBox_peso"
        TextBox_peso.Size = New Size(420, 69)
        TextBox_peso.TabIndex = 24
        TextBox_peso.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox_caracteristicas
        ' 
        GroupBox_caracteristicas.Controls.Add(Label_tipo)
        GroupBox_caracteristicas.Controls.Add(TextBox_tipo)
        GroupBox_caracteristicas.Controls.Add(Label_ancho_real)
        GroupBox_caracteristicas.Controls.Add(TextBox_ancho_real)
        GroupBox_caracteristicas.Controls.Add(Label_largo_real)
        GroupBox_caracteristicas.Controls.Add(TextBox_largo_real)
        GroupBox_caracteristicas.Font = New Font("Harrington", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox_caracteristicas.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        GroupBox_caracteristicas.Location = New Point(902, 132)
        GroupBox_caracteristicas.Margin = New Padding(4, 3, 4, 3)
        GroupBox_caracteristicas.Name = "GroupBox_caracteristicas"
        GroupBox_caracteristicas.Padding = New Padding(4, 3, 4, 3)
        GroupBox_caracteristicas.Size = New Size(468, 261)
        GroupBox_caracteristicas.TabIndex = 47
        GroupBox_caracteristicas.TabStop = False
        GroupBox_caracteristicas.Text = "Caracteristicas"
        ' 
        ' Label_tipo
        ' 
        Label_tipo.AutoSize = True
        Label_tipo.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_tipo.Location = New Point(20, 60)
        Label_tipo.Margin = New Padding(4, 0, 4, 0)
        Label_tipo.Name = "Label_tipo"
        Label_tipo.Size = New Size(80, 37)
        Label_tipo.TabIndex = 17
        Label_tipo.Text = "Tipo"
        ' 
        ' TextBox_tipo
        ' 
        TextBox_tipo.Enabled = False
        TextBox_tipo.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_tipo.Location = New Point(233, 54)
        TextBox_tipo.Margin = New Padding(4, 3, 4, 3)
        TextBox_tipo.Name = "TextBox_tipo"
        TextBox_tipo.Size = New Size(214, 54)
        TextBox_tipo.TabIndex = 10
        ' 
        ' Label_ancho_real
        ' 
        Label_ancho_real.AutoSize = True
        Label_ancho_real.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_ancho_real.Location = New Point(20, 129)
        Label_ancho_real.Margin = New Padding(4, 0, 4, 0)
        Label_ancho_real.Name = "Label_ancho_real"
        Label_ancho_real.Size = New Size(182, 37)
        Label_ancho_real.TabIndex = 19
        Label_ancho_real.Text = "Ancho Real"
        ' 
        ' TextBox_ancho_real
        ' 
        TextBox_ancho_real.Enabled = False
        TextBox_ancho_real.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_ancho_real.Location = New Point(233, 123)
        TextBox_ancho_real.Margin = New Padding(4, 3, 4, 3)
        TextBox_ancho_real.Name = "TextBox_ancho_real"
        TextBox_ancho_real.Size = New Size(214, 54)
        TextBox_ancho_real.TabIndex = 18
        ' 
        ' Label_largo_real
        ' 
        Label_largo_real.AutoSize = True
        Label_largo_real.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_largo_real.Location = New Point(20, 198)
        Label_largo_real.Margin = New Padding(4, 0, 4, 0)
        Label_largo_real.Name = "Label_largo_real"
        Label_largo_real.Size = New Size(173, 37)
        Label_largo_real.TabIndex = 21
        Label_largo_real.Text = "Largo Real"
        ' 
        ' TextBox_largo_real
        ' 
        TextBox_largo_real.Enabled = False
        TextBox_largo_real.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_largo_real.Location = New Point(233, 193)
        TextBox_largo_real.Margin = New Padding(4, 3, 4, 3)
        TextBox_largo_real.Name = "TextBox_largo_real"
        TextBox_largo_real.Size = New Size(214, 54)
        TextBox_largo_real.TabIndex = 20
        ' 
        ' GroupBox_datap
        ' 
        GroupBox_datap.Controls.Add(RadioButton_F)
        GroupBox_datap.Controls.Add(RadioButton_E)
        GroupBox_datap.Controls.Add(RadioButton_D)
        GroupBox_datap.Controls.Add(RadioButton_C)
        GroupBox_datap.Controls.Add(RadioButton_B)
        GroupBox_datap.Controls.Add(RadioButton_A)
        GroupBox_datap.Controls.Add(DateTimePicker_fecha)
        GroupBox_datap.Controls.Add(TextBox_texto)
        GroupBox_datap.Controls.Add(Label_supervisor)
        GroupBox_datap.Controls.Add(Label_lote)
        GroupBox_datap.Controls.Add(Label_posicion)
        GroupBox_datap.Controls.Add(Label_material)
        GroupBox_datap.Controls.Add(Label_texto)
        GroupBox_datap.Controls.Add(Label_centro)
        GroupBox_datap.Controls.Add(TextBox_supervisor)
        GroupBox_datap.Controls.Add(TextBox_lote)
        GroupBox_datap.Controls.Add(TextBox_posicion)
        GroupBox_datap.Controls.Add(TextBox_material)
        GroupBox_datap.Controls.Add(TextBox_centro)
        GroupBox_datap.Controls.Add(TextBox_orden)
        GroupBox_datap.Controls.Add(Label_orden)
        GroupBox_datap.Controls.Add(Label_fecha)
        GroupBox_datap.Font = New Font("Harrington", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBox_datap.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        GroupBox_datap.Location = New Point(18, 133)
        GroupBox_datap.Margin = New Padding(4, 3, 4, 3)
        GroupBox_datap.Name = "GroupBox_datap"
        GroupBox_datap.Padding = New Padding(4, 3, 4, 3)
        GroupBox_datap.Size = New Size(864, 650)
        GroupBox_datap.TabIndex = 52
        GroupBox_datap.TabStop = False
        GroupBox_datap.Text = "Principal"
        ' 
        ' RadioButton_F
        ' 
        RadioButton_F.Appearance = Appearance.Button
        RadioButton_F.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_F.Location = New Point(684, 348)
        RadioButton_F.Margin = New Padding(4, 3, 4, 3)
        RadioButton_F.Name = "RadioButton_F"
        RadioButton_F.Size = New Size(68, 63)
        RadioButton_F.TabIndex = 54
        RadioButton_F.Text = "F"
        ' 
        ' RadioButton_E
        ' 
        RadioButton_E.Appearance = Appearance.Button
        RadioButton_E.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_E.Location = New Point(608, 347)
        RadioButton_E.Margin = New Padding(4, 3, 4, 3)
        RadioButton_E.Name = "RadioButton_E"
        RadioButton_E.Size = New Size(68, 63)
        RadioButton_E.TabIndex = 53
        RadioButton_E.Text = "E"
        ' 
        ' RadioButton_D
        ' 
        RadioButton_D.Appearance = Appearance.Button
        RadioButton_D.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_D.Location = New Point(540, 347)
        RadioButton_D.Margin = New Padding(4, 3, 4, 3)
        RadioButton_D.Name = "RadioButton_D"
        RadioButton_D.Size = New Size(68, 63)
        RadioButton_D.TabIndex = 52
        RadioButton_D.Text = "D"
        ' 
        ' RadioButton_C
        ' 
        RadioButton_C.Appearance = Appearance.Button
        RadioButton_C.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_C.Location = New Point(472, 347)
        RadioButton_C.Margin = New Padding(4, 3, 4, 3)
        RadioButton_C.Name = "RadioButton_C"
        RadioButton_C.Size = New Size(68, 63)
        RadioButton_C.TabIndex = 51
        RadioButton_C.Text = "C"
        ' 
        ' RadioButton_B
        ' 
        RadioButton_B.Appearance = Appearance.Button
        RadioButton_B.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_B.Location = New Point(405, 347)
        RadioButton_B.Margin = New Padding(4, 3, 4, 3)
        RadioButton_B.Name = "RadioButton_B"
        RadioButton_B.Size = New Size(68, 63)
        RadioButton_B.TabIndex = 50
        RadioButton_B.Text = "B"
        ' 
        ' RadioButton_A
        ' 
        RadioButton_A.Appearance = Appearance.Button
        RadioButton_A.Font = New Font("Century Schoolbook", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_A.Location = New Point(337, 347)
        RadioButton_A.Margin = New Padding(4, 3, 4, 3)
        RadioButton_A.Name = "RadioButton_A"
        RadioButton_A.Size = New Size(68, 63)
        RadioButton_A.TabIndex = 49
        RadioButton_A.Text = "A"
        ' 
        ' DateTimePicker_fecha
        ' 
        DateTimePicker_fecha.Checked = False
        DateTimePicker_fecha.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker_fecha.Format = DateTimePickerFormat.Short
        DateTimePicker_fecha.Location = New Point(246, 53)
        DateTimePicker_fecha.Margin = New Padding(4, 3, 4, 3)
        DateTimePicker_fecha.Name = "DateTimePicker_fecha"
        DateTimePicker_fecha.Size = New Size(274, 54)
        DateTimePicker_fecha.TabIndex = 48
        ' 
        ' TextBox_texto
        ' 
        TextBox_texto.CharacterCasing = CharacterCasing.Upper
        TextBox_texto.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_texto.Location = New Point(241, 577)
        TextBox_texto.Margin = New Padding(4, 3, 4, 3)
        TextBox_texto.Name = "TextBox_texto"
        TextBox_texto.Size = New Size(601, 54)
        TextBox_texto.TabIndex = 47
        ' 
        ' Label_supervisor
        ' 
        Label_supervisor.AutoSize = True
        Label_supervisor.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_supervisor.Location = New Point(10, 505)
        Label_supervisor.Margin = New Padding(4, 0, 4, 0)
        Label_supervisor.Name = "Label_supervisor"
        Label_supervisor.Size = New Size(169, 37)
        Label_supervisor.TabIndex = 45
        Label_supervisor.Text = "Supervisor"
        ' 
        ' Label_lote
        ' 
        Label_lote.AutoSize = True
        Label_lote.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_lote.Location = New Point(10, 429)
        Label_lote.Margin = New Padding(4, 0, 4, 0)
        Label_lote.Name = "Label_lote"
        Label_lote.Size = New Size(284, 37)
        Label_lote.TabIndex = 44
        Label_lote.Text = "Lote de Inspección"
        ' 
        ' Label_posicion
        ' 
        Label_posicion.AutoSize = True
        Label_posicion.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_posicion.Location = New Point(10, 354)
        Label_posicion.Margin = New Padding(4, 0, 4, 0)
        Label_posicion.Name = "Label_posicion"
        Label_posicion.Size = New Size(138, 37)
        Label_posicion.TabIndex = 43
        Label_posicion.Text = "Posición"
        ' 
        ' Label_material
        ' 
        Label_material.AutoSize = True
        Label_material.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_material.Location = New Point(10, 278)
        Label_material.Margin = New Padding(4, 0, 4, 0)
        Label_material.Name = "Label_material"
        Label_material.Size = New Size(130, 37)
        Label_material.TabIndex = 42
        Label_material.Text = "Material"
        ' 
        ' Label_texto
        ' 
        Label_texto.AutoSize = True
        Label_texto.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_texto.Location = New Point(10, 590)
        Label_texto.Margin = New Padding(4, 0, 4, 0)
        Label_texto.Name = "Label_texto"
        Label_texto.Size = New Size(96, 37)
        Label_texto.TabIndex = 46
        Label_texto.Text = "Texto"
        ' 
        ' Label_centro
        ' 
        Label_centro.AutoSize = True
        Label_centro.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_centro.Location = New Point(10, 204)
        Label_centro.Margin = New Padding(4, 0, 4, 0)
        Label_centro.Name = "Label_centro"
        Label_centro.Size = New Size(113, 37)
        Label_centro.TabIndex = 41
        Label_centro.Text = "Centro"
        ' 
        ' TextBox_supervisor
        ' 
        TextBox_supervisor.CharacterCasing = CharacterCasing.Upper
        TextBox_supervisor.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_supervisor.Location = New Point(241, 500)
        TextBox_supervisor.Margin = New Padding(4, 3, 4, 3)
        TextBox_supervisor.Name = "TextBox_supervisor"
        TextBox_supervisor.Size = New Size(601, 54)
        TextBox_supervisor.TabIndex = 39
        ' 
        ' TextBox_lote
        ' 
        TextBox_lote.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_lote.Location = New Point(391, 423)
        TextBox_lote.Margin = New Padding(4, 3, 4, 3)
        TextBox_lote.Name = "TextBox_lote"
        TextBox_lote.Size = New Size(452, 54)
        TextBox_lote.TabIndex = 38
        ' 
        ' TextBox_posicion
        ' 
        TextBox_posicion.AutoCompleteCustomSource.AddRange(New String() {"A", "B"})
        TextBox_posicion.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox_posicion.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox_posicion.CharacterCasing = CharacterCasing.Upper
        TextBox_posicion.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_posicion.Location = New Point(246, 348)
        TextBox_posicion.Margin = New Padding(4, 3, 4, 3)
        TextBox_posicion.Name = "TextBox_posicion"
        TextBox_posicion.Size = New Size(67, 54)
        TextBox_posicion.TabIndex = 37
        TextBox_posicion.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_material
        ' 
        TextBox_material.Enabled = False
        TextBox_material.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_material.Location = New Point(246, 272)
        TextBox_material.Margin = New Padding(4, 3, 4, 3)
        TextBox_material.Name = "TextBox_material"
        TextBox_material.Size = New Size(444, 54)
        TextBox_material.TabIndex = 36
        ' 
        ' TextBox_centro
        ' 
        TextBox_centro.Enabled = False
        TextBox_centro.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_centro.Location = New Point(246, 198)
        TextBox_centro.Margin = New Padding(4, 3, 4, 3)
        TextBox_centro.Name = "TextBox_centro"
        TextBox_centro.Size = New Size(150, 54)
        TextBox_centro.TabIndex = 35
        ' 
        ' TextBox_orden
        ' 
        TextBox_orden.Font = New Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_orden.Location = New Point(246, 126)
        TextBox_orden.Margin = New Padding(4, 3, 4, 3)
        TextBox_orden.Name = "TextBox_orden"
        TextBox_orden.Size = New Size(332, 54)
        TextBox_orden.TabIndex = 34
        ' 
        ' Label_orden
        ' 
        Label_orden.AutoSize = True
        Label_orden.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_orden.Location = New Point(10, 132)
        Label_orden.Margin = New Padding(4, 0, 4, 0)
        Label_orden.Name = "Label_orden"
        Label_orden.Size = New Size(106, 37)
        Label_orden.TabIndex = 33
        Label_orden.Text = "Orden"
        ' 
        ' Label_fecha
        ' 
        Label_fecha.AutoSize = True
        Label_fecha.Font = New Font("Microsoft Sans Serif", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label_fecha.Location = New Point(10, 58)
        Label_fecha.Margin = New Padding(4, 0, 4, 0)
        Label_fecha.Name = "Label_fecha"
        Label_fecha.Size = New Size(106, 37)
        Label_fecha.TabIndex = 31
        Label_fecha.Text = "Fecha"
        ' 
        ' BottomToolStripPanel
        ' 
        BottomToolStripPanel.Location = New Point(0, 0)
        BottomToolStripPanel.Name = "BottomToolStripPanel"
        BottomToolStripPanel.Orientation = Orientation.Horizontal
        BottomToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        BottomToolStripPanel.Size = New Size(0, 0)
        ' 
        ' TopToolStripPanel
        ' 
        TopToolStripPanel.Location = New Point(0, 0)
        TopToolStripPanel.Name = "TopToolStripPanel"
        TopToolStripPanel.Orientation = Orientation.Horizontal
        TopToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        TopToolStripPanel.Size = New Size(0, 0)
        ' 
        ' RightToolStripPanel
        ' 
        RightToolStripPanel.Location = New Point(0, 0)
        RightToolStripPanel.Name = "RightToolStripPanel"
        RightToolStripPanel.Orientation = Orientation.Horizontal
        RightToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        RightToolStripPanel.Size = New Size(0, 0)
        ' 
        ' ToolStripPanel
        ' 
        ToolStripPanel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ToolStripPanel.ForeColor = Color.Yellow
        ToolStripPanel.Location = New Point(0, 0)
        ToolStripPanel.Name = "ToolStripPanel"
        ToolStripPanel.Orientation = Orientation.Horizontal
        ToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
        ToolStripPanel.Size = New Size(0, 0)
        ' 
        ' ContentPanel
        ' 
        ContentPanel.AutoScroll = True
        ContentPanel.Size = New Size(1174, 747)
        ' 
        ' Button_save
        ' 
        Button_save.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button_save.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button_save.Location = New Point(546, 62)
        Button_save.Margin = New Padding(4, 3, 4, 3)
        Button_save.Name = "Button_save"
        Button_save.Size = New Size(332, 88)
        Button_save.TabIndex = 57
        Button_save.Text = "Guardar"
        Button_save.TextAlign = ContentAlignment.BottomCenter
        Button_save.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' PictureBox_smurfit
        ' 
        PictureBox_smurfit.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox_smurfit.Location = New Point(1073, 55)
        PictureBox_smurfit.Margin = New Padding(4, 3, 4, 3)
        PictureBox_smurfit.Name = "PictureBox_smurfit"
        PictureBox_smurfit.Size = New Size(296, 88)
        PictureBox_smurfit.TabIndex = 58
        PictureBox_smurfit.TabStop = False
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel_mb31, ToolStripStatusLabel_slash2, ToolStripStatusLabel_bascula, ToolStripStatusLabel_slash1, ToolStripStatusLabel_sap})
        StatusStrip.Location = New Point(0, 800)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(16, 0, 1, 0)
        StatusStrip.RightToLeft = RightToLeft.Yes
        StatusStrip.Size = New Size(1384, 22)
        StatusStrip.TabIndex = 59
        ' 
        ' ToolStripStatusLabel_mb31
        ' 
        ToolStripStatusLabel_mb31.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel_mb31.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ToolStripStatusLabel_mb31.Name = "ToolStripStatusLabel_mb31"
        ToolStripStatusLabel_mb31.Size = New Size(37, 17)
        ToolStripStatusLabel_mb31.Text = "MB31"
        ' 
        ' ToolStripStatusLabel_slash2
        ' 
        ToolStripStatusLabel_slash2.ForeColor = Color.DarkRed
        ToolStripStatusLabel_slash2.LinkColor = Color.FromArgb(CByte(0), CByte(0), CByte(255))
        ToolStripStatusLabel_slash2.Name = "ToolStripStatusLabel_slash2"
        ToolStripStatusLabel_slash2.Size = New Size(10, 17)
        ToolStripStatusLabel_slash2.Text = "|"
        ' 
        ' ToolStripStatusLabel_bascula
        ' 
        ToolStripStatusLabel_bascula.Font = New Font("Copperplate Gothic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel_bascula.ForeColor = Color.Red
        ToolStripStatusLabel_bascula.Name = "ToolStripStatusLabel_bascula"
        ToolStripStatusLabel_bascula.Size = New Size(162, 17)
        ToolStripStatusLabel_bascula.Text = "Conexión Bascula OFF"
        ' 
        ' ToolStripStatusLabel_slash1
        ' 
        ToolStripStatusLabel_slash1.ForeColor = Color.DarkRed
        ToolStripStatusLabel_slash1.LinkColor = Color.FromArgb(CByte(0), CByte(0), CByte(255))
        ToolStripStatusLabel_slash1.Name = "ToolStripStatusLabel_slash1"
        ToolStripStatusLabel_slash1.Size = New Size(10, 17)
        ToolStripStatusLabel_slash1.Text = "|"
        ' 
        ' ToolStripStatusLabel_sap
        ' 
        ToolStripStatusLabel_sap.Font = New Font("Copperplate Gothic Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel_sap.ForeColor = Color.Red
        ToolStripStatusLabel_sap.Name = "ToolStripStatusLabel_sap"
        ToolStripStatusLabel_sap.Size = New Size(131, 17)
        ToolStripStatusLabel_sap.Text = "Conexión Sap OFF"
        ' 
        ' ToolTip_captura
        ' 
        ToolTip_captura.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ToolTip_captura.IsBalloon = True
        ' 
        ' SerialPort_bascula
        ' 
        SerialPort_bascula.BaudRate = 9600
        SerialPort_bascula.DataBits = 8
        SerialPort_bascula.DiscardNull = False
        SerialPort_bascula.DtrEnable = False
        AsciiEncoding1.DecoderFallback = DecoderReplacementFallback1
        AsciiEncoding1.EncoderFallback = EncoderReplacementFallback1
        SerialPort_bascula.Encoding = AsciiEncoding1
        SerialPort_bascula.Handshake = IO.Ports.Handshake.None
        SerialPort_bascula.NewLine = vbLf
        SerialPort_bascula.Parity = IO.Ports.Parity.None
        SerialPort_bascula.ParityReplace = CByte(63)
        SerialPort_bascula.PortName = "COM1"
        SerialPort_bascula.ReadBufferSize = 4096
        SerialPort_bascula.ReadTimeout = -1
        SerialPort_bascula.ReceivedBytesThreshold = 16
        SerialPort_bascula.RtsEnable = False
        SerialPort_bascula.StopBits = IO.Ports.StopBits.One
        SerialPort_bascula.WriteBufferSize = 2048
        SerialPort_bascula.WriteTimeout = -1
        ' 
        ' MenuStrip_Bascula
        ' 
        MenuStrip_Bascula.Font = New Font("Harrington", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip_Bascula.Items.AddRange(New ToolStripItem() {INICIOToolStripMenuItem, HerramientasToolStripMenuItem, AcercaDeToolStripMenuItem})
        MenuStrip_Bascula.Location = New Point(0, 0)
        MenuStrip_Bascula.Name = "MenuStrip_Bascula"
        MenuStrip_Bascula.Padding = New Padding(7, 2, 0, 2)
        MenuStrip_Bascula.Size = New Size(1384, 44)
        MenuStrip_Bascula.TabIndex = 60
        MenuStrip_Bascula.Text = "MenuStrip"
        ' 
        ' INICIOToolStripMenuItem
        ' 
        INICIOToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConectarSapToolStripMenuItem, ConectarBasculaToolStripMenuItem, SalirToolStripMenuItem})
        INICIOToolStripMenuItem.Font = New Font("Baskerville Old Face", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        INICIOToolStripMenuItem.Name = "INICIOToolStripMenuItem"
        INICIOToolStripMenuItem.Size = New Size(102, 40)
        INICIOToolStripMenuItem.Text = "Inicio"
        ' 
        ' ConectarSapToolStripMenuItem
        ' 
        ConectarSapToolStripMenuItem.Name = "ConectarSapToolStripMenuItem"
        ConectarSapToolStripMenuItem.Size = New Size(311, 40)
        ConectarSapToolStripMenuItem.Text = "Conectar Sap"
        ' 
        ' ConectarBasculaToolStripMenuItem
        ' 
        ConectarBasculaToolStripMenuItem.Name = "ConectarBasculaToolStripMenuItem"
        ConectarBasculaToolStripMenuItem.Size = New Size(311, 40)
        ConectarBasculaToolStripMenuItem.Text = "Conectar Bascula"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(311, 40)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LimpiarDatosToolStripMenuItem, SistemasToolStripMenuItem})
        HerramientasToolStripMenuItem.Font = New Font("Baskerville Old Face", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(201, 40)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' LimpiarDatosToolStripMenuItem
        ' 
        LimpiarDatosToolStripMenuItem.Name = "LimpiarDatosToolStripMenuItem"
        LimpiarDatosToolStripMenuItem.Size = New Size(277, 40)
        LimpiarDatosToolStripMenuItem.Text = "Limpiar Datos"
        ' 
        ' SistemasToolStripMenuItem
        ' 
        SistemasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ParametrosToolStripMenuItem})
        SistemasToolStripMenuItem.Name = "SistemasToolStripMenuItem"
        SistemasToolStripMenuItem.Size = New Size(277, 40)
        SistemasToolStripMenuItem.Text = "Sistemas"
        ' 
        ' ParametrosToolStripMenuItem
        ' 
        ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        ParametrosToolStripMenuItem.Size = New Size(235, 40)
        ParametrosToolStripMenuItem.Text = "Parametros"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Font = New Font("Baskerville Old Face", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(153, 40)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        ' 
        ' BaseCapturaSAP
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1384, 822)
        Controls.Add(StatusStrip)
        Controls.Add(MenuStrip_Bascula)
        Controls.Add(PictureBox_smurfit)
        Controls.Add(Button_save)
        Controls.Add(GroupBox_bach)
        Controls.Add(GroupBox_peso)
        Controls.Add(GroupBox_caracteristicas)
        Controls.Add(GroupBox_datap)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MainMenuStrip = MenuStrip_Bascula
        Margin = New Padding(4, 3, 4, 3)
        Name = "BaseCapturaSAP"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox_bach.ResumeLayout(False)
        GroupBox_bach.PerformLayout()
        GroupBox_peso.ResumeLayout(False)
        GroupBox_peso.PerformLayout()
        GroupBox_caracteristicas.ResumeLayout(False)
        GroupBox_caracteristicas.PerformLayout()
        GroupBox_datap.ResumeLayout(False)
        GroupBox_datap.PerformLayout()
        CType(PictureBox_smurfit, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        MenuStrip_Bascula.ResumeLayout(False)
        MenuStrip_Bascula.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox_bach As GroupBox
    Friend WithEvents TextBox_bach As TextBox
    Friend WithEvents GroupBox_peso As GroupBox
    Friend WithEvents GroupBox_caracteristicas As GroupBox
    Friend WithEvents Label_tipo As Label
    Friend WithEvents TextBox_tipo As TextBox
    Friend WithEvents Label_ancho_real As Label
    Friend WithEvents TextBox_ancho_real As TextBox
    Friend WithEvents Label_largo_real As Label
    Friend WithEvents TextBox_largo_real As TextBox
    Friend WithEvents Label_texto As Label
    Friend WithEvents Label_supervisor As Label
    Friend WithEvents Label_lote As Label
    Friend WithEvents Label_posicion As Label
    Friend WithEvents Label_material As Label
    Friend WithEvents Label_centro As Label
    Friend WithEvents TextBox_supervisor As TextBox
    Friend WithEvents TextBox_lote As TextBox
    Friend WithEvents TextBox_posicion As TextBox
    Friend WithEvents TextBox_material As TextBox
    Friend WithEvents TextBox_centro As TextBox
    Friend WithEvents TextBox_orden As TextBox
    Friend WithEvents Label_orden As Label
    Friend WithEvents Label_fecha As Label
    Friend WithEvents GroupBox_datap As GroupBox
    Friend WithEvents TextBox_texto As TextBox
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents ToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents Button_save As Button
    Friend WithEvents DateTimePicker_fecha As DateTimePicker
    Friend WithEvents TextBox_peso As TextBox
    Friend WithEvents PictureBox_smurfit As PictureBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel_mb31 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_bascula As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_sap As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_slash2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_slash1 As ToolStripStatusLabel
    Friend WithEvents ToolTip_captura As ToolTip
    Friend WithEvents SerialPort_bascula As System.IO.Ports.SerialPort
    Friend WithEvents MenuStrip_Bascula As MenuStrip
    Friend WithEvents INICIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConectarSapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConectarBasculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioButton_B As RadioButton
    Friend WithEvents RadioButton_A As RadioButton
    Friend WithEvents RadioButton_C As RadioButton
    Friend WithEvents RadioButton_F As RadioButton
    Friend WithEvents RadioButton_E As RadioButton
    Friend WithEvents RadioButton_D As RadioButton


End Class
