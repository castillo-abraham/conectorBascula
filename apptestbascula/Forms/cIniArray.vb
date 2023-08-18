
Public Class cIniArray
    Private sBuffer As String ' Para usarla en las funciones GetSection(s)

    '--- Declaraciones para leer ficheros INI ---
    ' Leer todas las secciones de un fichero INI, esto seguramente no funciona en Win95
    ' Esta función no estaba en las declaraciones del API que se incluye con el VB
    Private Declare Function GetPrivateProfileSectionNames Lib "kernel32" Alias "GetPrivateProfileSectionNamesA" (ByVal lpszReturnBuffer As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    ' Leer una sección completa
    Private Declare Function GetPrivateProfileSection Lib "kernel32" Alias "GetPrivateProfileSectionA" (ByVal lpAppName As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    ' Leer una clave de un fichero INI
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    ' Escribir una clave de un fichero INI (también para borrar claves y secciones)
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Integer, ByVal lpString As Integer, ByVal lpFileName As String) As Integer

    Public Sub IniDeleteKey(ByVal sIniFile As String, ByVal sSection As String, Optional ByVal sKey As String = "")
        '--------------------------------------------------------------------------
        ' Borrar una clave o entrada de un fichero INI                  (16/Feb/99)
        ' Si no se indica sKey, se borrará la sección indicada en sSection
        ' En otro caso, se supone que es la entrada (clave) lo que se quiere borrar
        '
        ' Para borrar una sección se debería usar IniDeleteSection
        '
        If Len(sKey) = 0 Then
            ' Borrar una sección
            Call WritePrivateProfileString(sSection, 0, 0, sIniFile)
        Else
            ' Borrar una entrada
            Call WritePrivateProfileString(sSection, sKey, 0, sIniFile)
        End If
    End Sub

    Public Sub IniDeleteSection(ByVal sIniFile As String, ByVal sSection As String)
        '--------------------------------------------------------------------------
        ' Borrar una sección de un fichero INI                          (04/Abr/01)
        ' Borrar una sección
        Call WritePrivateProfileString(sSection, 0, 0, sIniFile)
    End Sub

    Public Function IniGet(ByVal sFileName As String, ByVal sSection As String, ByVal sKeyName As String, Optional ByVal sDefault As String = "") As String
        '--------------------------------------------------------------------------
        ' Devuelve el valor de una clave de un fichero INI
        ' Los parámetros son:
        '   sFileName   El fichero INI
        '   sSection    La sección de la que se quiere leer
        '   sKeyName    Clave
        '   sDefault    Valor opcional que devolverá si no se encuentra la clave
        '--------------------------------------------------------------------------
        Dim ret As Integer
        Dim sRetVal As String
        '
        sRetVal = New String(Chr(0), 255)
        '
        ret = GetPrivateProfileString(sSection, sKeyName, sDefault, sRetVal, Len(sRetVal), sFileName)
        If ret = 0 Then
            Return sDefault
        Else
            Return Left(sRetVal, ret)
        End If
    End Function

    Public Sub IniWrite(ByVal sFileName As String, ByVal sSection As String, ByVal sKeyName As String, ByVal sValue As String)
        '--------------------------------------------------------------------------
        ' Guarda los datos de configuración
        ' Los parámetros son los mismos que en LeerIni
        ' Siendo sValue el valor a guardar
        '
        Call WritePrivateProfileString(sSection, sKeyName, sValue, sFileName)
    End Sub

    Public Function IniGetSection(ByVal sFileName As String, ByVal sSection As String) As String()

        Dim aSeccion() As String
        Dim n As Integer
        '
        ReDim aSeccion(0)
        '
        ' El tamaño máximo para Windows 95
        sBuffer = New String(ChrW(0), 32767)
        '
        n = GetPrivateProfileSection(sSection, sBuffer, sBuffer.Length, sFileName)
        '
        If n > 0 Then
            '
            ' Cortar la cadena al número de caracteres devueltos
            ' menos los dos últimos que indican el final de la cadena
            sBuffer = sBuffer.Substring(0, n - 2).TrimEnd()
            ' Cada elemento estará separado por un Chr(0)
            ' y cada valor estará en la forma: clave = valor
            aSeccion = sBuffer.Split(New Char() {ChrW(0), "="c})
        End If
        ' Devolver el array
        Return aSeccion
    End Function

    Public Function IniGetSections(ByVal sFileName As String) As String()

        Dim n As Integer
        Dim aSections() As String
        '
        ReDim aSections(0)
        '
        ' El tamaño máximo para Windows 95
        sBuffer = New String(ChrW(0), 32767)
        '
        ' Esta función del API no está definida en el fichero TXT
        n = GetPrivateProfileSectionNames(sBuffer, sBuffer.Length, sFileName)
        '
        If n > 0 Then
            ' Cortar la cadena al número de caracteres devueltos
            ' menos los dos últimos que indican el final de la cadena
            sBuffer = sBuffer.Substring(0, n - 2).TrimEnd()
            aSections = sBuffer.Split(ChrW(0))
        End If
        ' Devolver el array
        Return aSections
    End Function
    '
    Public Shared Function AppPath(
            Optional ByVal backSlash As Boolean = False
            ) As String

        Dim s As String =
            IO.Path.GetDirectoryName(
            Reflection.Assembly.GetCallingAssembly.Location)
        ' si hay que añadirle el backslash
        If backSlash Then
            s &= "\"
        End If
        Return s
    End Function

    ' Encriptar contraseña..
    Public Function Encripta(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Clave = "%ü&/@#$A" 'Clave definida puede cambiar...
        Pass2 = ""
        For i = 1 To Len(Pass)
            CAR = Mid(Pass, i, 1)
            Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Mid("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Encripta = Pass2
    End Function

    ' Desencriptar pwd..
    Public Function DesEncripta(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Dim j As Integer

        Clave = "%ü&/@#$A" 'Clave definida puede cambiar...
        Pass2 = ""
        j = 1
        For i = 1 To Len(Pass) Step 2
            CAR = Mid(Pass, i, 2)
            Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        DesEncripta = Pass2
    End Function

    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
End Class
