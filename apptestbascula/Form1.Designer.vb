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
        sapConnect = New Button()
        txb_ccode = New TextBox()
        C_code = New Label()
        c_date = New Label()
        RFC_func = New Button()
        SuspendLayout()
        ' 
        ' sapConnect
        ' 
        sapConnect.Location = New Point(28, 12)
        sapConnect.Name = "sapConnect"
        sapConnect.Size = New Size(75, 23)
        sapConnect.TabIndex = 0
        sapConnect.Text = "Conectar"
        sapConnect.UseVisualStyleBackColor = True
        ' 
        ' txb_ccode
        ' 
        txb_ccode.Location = New Point(103, 73)
        txb_ccode.Name = "txb_ccode"
        txb_ccode.Size = New Size(100, 23)
        txb_ccode.TabIndex = 1
        ' 
        ' C_code
        ' 
        C_code.AutoSize = True
        C_code.Location = New Point(28, 76)
        C_code.Name = "C_code"
        C_code.Size = New Size(62, 15)
        C_code.TabIndex = 2
        C_code.Text = "Compania"
        ' 
        ' c_date
        ' 
        c_date.AutoSize = True
        c_date.Location = New Point(230, 81)
        c_date.Name = "c_date"
        c_date.Size = New Size(17, 15)
        c_date.TabIndex = 3
        c_date.Text = "--"
        ' 
        ' RFC_func
        ' 
        RFC_func.Location = New Point(28, 122)
        RFC_func.Name = "RFC_func"
        RFC_func.Size = New Size(75, 23)
        RFC_func.TabIndex = 4
        RFC_func.Text = "Consultar"
        RFC_func.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RFC_func)
        Controls.Add(c_date)
        Controls.Add(C_code)
        Controls.Add(txb_ccode)
        Controls.Add(sapConnect)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents sapConnect As Button
    Friend WithEvents txb_ccode As TextBox
    Friend WithEvents C_code As Label
    Friend WithEvents c_date As Label
    Friend WithEvents RFC_func As Button
End Class
