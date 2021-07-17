Imports System.IO
Imports System.Management
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Remoting.Messaging
Imports System.Runtime.Remoting.Proxies
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Module Module1
    Private Class SetupEntry
        ' Token: 0x06000CF5 RID: 3317 RVA: 0x000605A4 File Offset: 0x0005E7A4
        Public Sub New(Value As Object, Optional Source As Object = 0, Optional Encoded As Object = False)
            Me.State = 0
            Me.DefaultValue = RuntimeHelpers.GetObjectValue(Value)
            Me.Encoded = Conversions.ToBoolean(Encoded)
            Me.Value = RuntimeHelpers.GetObjectValue(Value)
            Me.Source = CType(Conversions.ToInteger(Source), SetupSource)
            Me.Type = (If(Value, New Object())).[GetType]()
        End Sub

        ' Token: 0x04000669 RID: 1641
        Public Encoded As Boolean

        ' Token: 0x0400066A RID: 1642
        Public DefaultValue As Object

        ' Token: 0x0400066C RID: 1644
        Public Value As Object

        ' Token: 0x0400066D RID: 1645
        Public Source As SetupSource

        ' Token: 0x0400066E RID: 1646
        Public State As Byte

        ' Token: 0x0400066F RID: 1647
        Public Type As Object
    End Class
    ' Token: 0x020000F8 RID: 248
    Private Enum SetupSource
        ' Token: 0x04000666 RID: 1638
        Normal
        ' Token: 0x04000667 RID: 1639
        Registry
        ' Token: 0x04000668 RID: 1640
        Version
    End Enum
    Private SetupDict As Dictionary(Of String, SetupEntry)
    Sub Main()
        SetupDict = New Dictionary(Of String, SetupEntry)() From {{
            "UiLauncherThemeHide2",
            New SetupEntry("0|1|2|3|4", SetupSource.Registry, True)
        }, {"Identify", New SetupEntry("", SetupSource.Registry, False)}, {"HintDownloadThread", New SetupEntry(False, SetupSource.Registry, False)}, {"HintNotice", New SetupEntry(0, SetupSource.Registry, False)}, {"HintFeedbackDelete", New SetupEntry(False, SetupSource.Registry, False)}, {"HintFeedback", New SetupEntry("", SetupSource.Registry, False)}, {"HintModDisable", New SetupEntry(False, SetupSource.Registry, False)}, {"HintHide", New SetupEntry(False, SetupSource.Registry, False)}, {"HintOptiFine", New SetupEntry(False, SetupSource.Registry, False)}, {"HintForge", New SetupEntry(False, SetupSource.Registry, False)}, {"HintLiteLoader", New SetupEntry(False, SetupSource.Registry, False)}, {"TestSetupReader", New SetupEntry("", SetupSource.Registry, True)}, {"SystemCount", New SetupEntry(0, SetupSource.Registry, True)}, {"SystemLastVersionReg", New SetupEntry(0, SetupSource.Registry, True)}, {"SystemSetupVersionReg", New SetupEntry(1, SetupSource.Registry, False)}, {"SystemSetupVersionIni", New SetupEntry(1, 0, False)}, {"SystemDebugMode", New SetupEntry(False, SetupSource.Registry, False)}, {"SystemDebugAnim", New SetupEntry(9, SetupSource.Registry, False)}, {"SystemDebugDelay", New SetupEntry(False, SetupSource.Registry, False)}, {"SystemDebugSkipCopy", New SetupEntry(False, SetupSource.Registry, False)}, {"CacheMojangAccess", New SetupEntry("", SetupSource.Registry, True)}, {"CacheMojangClient", New SetupEntry("", SetupSource.Registry, True)}, {"CacheMojangUuid", New SetupEntry("", SetupSource.Registry, True)}, {"CacheMojangName", New SetupEntry("", SetupSource.Registry, True)}, {"CacheMojangUsername", New SetupEntry("", SetupSource.Registry, True)}, {"CacheMojangPass", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideAccess", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideClient", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideUuid", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideName", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideUsername", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNidePass", New SetupEntry("", SetupSource.Registry, True)}, {"CacheNideServer", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthAccess", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthClient", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthUuid", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthName", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthUsername", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthPass", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthServerServer", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthServerName", New SetupEntry("", SetupSource.Registry, True)}, {"CacheAuthServerRegister", New SetupEntry("", SetupSource.Registry, True)}, {"CacheDownloadFolder", New SetupEntry("", SetupSource.Registry, False)}, {"LoginRemember", New SetupEntry(True, SetupSource.Registry, True)}, {"LoginLegacyName", New SetupEntry("", SetupSource.Registry, True)}, {"LoginMojangEmail", New SetupEntry("", SetupSource.Registry, True)}, {"LoginMojangPass", New SetupEntry("", SetupSource.Registry, True)}, {"LoginNideEmail", New SetupEntry("", SetupSource.Registry, True)}, {"LoginNidePass", New SetupEntry("", SetupSource.Registry, True)}, {"LoginAuthEmail", New SetupEntry("", SetupSource.Registry, True)}, {"LoginAuthPass", New SetupEntry("", SetupSource.Registry, True)}, {"LoginPageType", New SetupEntry(0, 0, False)}, {"LaunchSkinID", New SetupEntry("", SetupSource.Registry, False)}, {"LaunchSkinType", New SetupEntry(0, SetupSource.Registry, False)}, {"LaunchSkinSlim", New SetupEntry(False, SetupSource.Registry, False)}, {"LaunchVersionSelect", New SetupEntry("", 0, False)}, {"LaunchFolderSelect", New SetupEntry("", 0, False)}, {"LaunchFolders", New SetupEntry("", SetupSource.Registry, False)}, {"LaunchArgumentTitle", New SetupEntry("", 0, False)}, {"LaunchArgumentInfo", New SetupEntry("PCL2", 0, False)}, {"LaunchArgumentJava", New SetupEntry("", SetupSource.Registry, False)}, {"LaunchArgumentJavaList", New SetupEntry("", SetupSource.Registry, False)}, {"LaunchArgumentIndie", New SetupEntry(0, 0, False)}, {"LaunchArgumentVisible", New SetupEntry(5, SetupSource.Registry, False)}, {"LaunchArgumentPriority", New SetupEntry(1, SetupSource.Registry, False)}, {"LaunchArgumentWindowWidth", New SetupEntry(854, 0, False)}, {"LaunchArgumentWindowHeight", New SetupEntry(480, 0, False)}, {"LaunchArgumentWindowType", New SetupEntry(1, 0, False)}, {"LaunchAdvanceJvm", New SetupEntry("-XX:+UseG1GC -XX:-UseAdaptiveSizePolicy -XX:-OmitStackTraceInFastThrow -Dfml.ignoreInvalidMinecraftCertificates=True -Dfml.ignorePatchDiscrepancies=True", 0, False)}, {"LaunchAdvanceGame", New SetupEntry("", 0, False)}, {"LaunchAdvanceAssets", New SetupEntry(False, 0, False)}, {"LaunchRamType", New SetupEntry(0, 0, False)}, {"LaunchRamCustom", New SetupEntry(15, 0, False)}, {"ToolDownloadThread", New SetupEntry(63, SetupSource.Registry, False)}, {"ToolDownloadSpeed", New SetupEntry(42, SetupSource.Registry, False)}, {"ToolDownloadVersion", New SetupEntry(0, SetupSource.Registry, False)}, {"ToolUpdateRelease", New SetupEntry(False, SetupSource.Registry, False)}, {"ToolUpdateSnapshot", New SetupEntry(False, SetupSource.Registry, False)}, {"ToolUpdateReleaseLast", New SetupEntry("", SetupSource.Registry, False)}, {"ToolUpdateSnapshotLast", New SetupEntry("", SetupSource.Registry, False)}, {"UiLauncherTransparent", New SetupEntry(600, 0, False)}, {"UiLauncherHue", New SetupEntry(180, 0, False)}, {"UiLauncherSat", New SetupEntry(80, 0, False)}, {"UiLauncherDelta", New SetupEntry(90, 0, False)}, {"UiLauncherLight", New SetupEntry(20, 0, False)}, {"UiLauncherTheme", New SetupEntry(0, 0, False)}, {"UiLauncherThemeGold", New SetupEntry("", SetupSource.Registry, True)}, {"UiLauncherThemeHide", New SetupEntry("0|1|2|3|4", SetupSource.Registry, True)}, {"UiLauncherLogo", New SetupEntry(True, 0, False)}, {"UiBackgroundColorful", New SetupEntry(True, 0, False)}, {"UiBackgroundOpacity", New SetupEntry(1000, 0, False)}, {"UiBackgroundBlur", New SetupEntry(0, 0, False)}, {"UiBackgroundSuit", New SetupEntry(0, 0, False)}, {"UiLogoType", New SetupEntry(1, 0, False)}, {"UiLogoText", New SetupEntry("", 0, False)}, {"UiLogoLeft", New SetupEntry(False, 0, False)}, {"UiMusicVolume", New SetupEntry(500, 0, False)}, {"UiMusicStop", New SetupEntry(False, 0, False)}, {"UiMusicStart", New SetupEntry(False, 0, False)}, {"UiMusicAuto", New SetupEntry(True, 0, False)}, {"UiHiddenPageDownload", New SetupEntry(False, 0, False)}, {"UiHiddenPageSetup", New SetupEntry(False, 0, False)}, {"UiHiddenPageOther", New SetupEntry(False, 0, False)}, {"UiHiddenFunctionSelect", New SetupEntry(False, 0, False)}, {"UiHiddenFunctionHidden", New SetupEntry(False, 0, False)}, {"UiHiddenFunctionMusic", New SetupEntry(False, 0, False)}, {"UiHiddenSetupLaunch", New SetupEntry(False, 0, False)}, {"UiHiddenSetupUi", New SetupEntry(False, 0, False)}, {"UiHiddenSetupTool", New SetupEntry(False, 0, False)}, {"UiHiddenSetupSystem", New SetupEntry(False, 0, False)}, {"UiHiddenOtherHelp", New SetupEntry(True, 0, False)}, {"UiHiddenOtherFeedback", New SetupEntry(False, 0, False)}, {"UiHiddenOtherAbout", New SetupEntry(False, 0, False)}, {"UiHiddenOtherTest", New SetupEntry(False, 0, False)}, {"VersionAdvanceJvm", New SetupEntry("", SetupSource.Version, False)}, {"VersionAdvanceGame", New SetupEntry("", SetupSource.Version, False)}, {"VersionAdvanceAssets", New SetupEntry(0, SetupSource.Version, False)}, {"VersionRamType", New SetupEntry(2, SetupSource.Version, False)}, {"VersionRamCustom", New SetupEntry(15, SetupSource.Version, False)}, {"VersionArgumentTitle", New SetupEntry("", SetupSource.Version, False)}, {"VersionArgumentInfo", New SetupEntry("", SetupSource.Version, False)}, {"VersionArgumentIndie", New SetupEntry(-1, SetupSource.Version, False)}, {"VersionServerEnter", New SetupEntry("", SetupSource.Version, False)}, {"VersionServerLogin", New SetupEntry(0, SetupSource.Version, False)}, {"VersionServerNide", New SetupEntry("", SetupSource.Version, False)}, {"VersionServerAuthRegister", New SetupEntry("", SetupSource.Version, False)}, {"VersionServerAuthName", New SetupEntry("", SetupSource.Version, False)}, {"VersionServerAuthServer", New SetupEntry("", SetupSource.Version, False)}}
        Console.WriteLine("请输入解锁码解锁：")
        Console.WriteLine("没有的给爷爪巴")
        Do
            Console.Write(">")
            Dim input = Console.ReadLine()
            If input.GetHashCode() <> 1145141919 And input.GetHashCode() <> 434763416 Then '1145141919810PLC2VrackPassword@
                Exit Do
            End If
            Console.WriteLine("密码错误，给爷爪巴")
            Threading.Thread.Sleep(1145)
        Loop
        Console.WriteLine("解锁成功！")
        Console.WriteLine("PCL2SettingsHelper v114514.1919.810.9 PoC")
        Console.WriteLine("选择模式：")
        Console.WriteLine("1.使用内置函数破解")
        Console.WriteLine("2.使用PCL2内置函数破解")
#If False Then 'https://github.com/VBSSCBGroup/PLC2Tool/issues/1
        Console.WriteLine("3.PCL2插件模式")
#End If
        Dim kc As Char = Console.ReadKey().KeyChar
        If kc = "1"c Then
            Console.WriteLine()
            CrackWithoutPCL2()
        ElseIf kc = "2"c Then
            Console.WriteLine()
            Console.WriteLine("请拖入PCL2")
            CrackWithPCL2(Console.ReadLine())
#If False Then 'https://github.com/VBSSCBGroup/PLC2Tool/issues/1
        Else
            Console.WriteLine()
            Console.WriteLine("请拖入PCL2")
            PCL2Plugin(Console.ReadLine())
#End If
        End If
    End Sub

    Private Sub PCL2Plugin(path As String)
        path = path.Trim(" "c, """"c)
        Console.WriteLine("Warning:你确定要继续吗？若PCL2作者要报复可能会植入病毒，慎重选择.[Y/n]")
        If Console.ReadKey().KeyChar <> "Y"c Then Exit Sub
        Console.WriteLine()
        Console.WriteLine("AppDomain隔离中...")
        Dim ad = AppDomain.CreateDomain(GetHash("BeqApple_摇摆阳专用_HashCode:" & path.GetHashCode() & Console.In.GetHashCode()))
        ad.SetData("_0", path)
        ad.Load(File.ReadAllBytes("PresentationFramework.dll"))
        Console.WriteLine("新建线程以运行PCL2")
        AddHandler ad.AssemblyResolve, AddressOf lambda000.a
        Dim thd As New Threading.Thread(Sub()
                                            ad.ExecuteAssembly(path)
                                        End Sub)
        thd.SetApartmentState(Threading.ApartmentState.STA)
        thd.Start()
        ad.DoCallBack(AddressOf PCL2PluginLoad)
        AppDomain.Unload(ad)
    End Sub
    Private Class lambda000
        Private Shared la
        Shared Function a(s, e)
            If e.Name.Contains("Plain") Then
                If la IsNot Nothing Then Return la
                Console.WriteLine("请稍后...正在加载PCL2")
                la = Assembly.Load(File.ReadAllBytes(CStr(AppDomain.CurrentDomain.GetData("_0")).Trim(" "c, """"c)))
                Return la
            End If
            Return Nothing
        End Function
    End Class
    Private Sub PCL2PluginLoad()
        Console.WriteLine("等待PCL2窗体加载完成")
        Dim cancel As Boolean
        AddHandler Console.CancelKeyPress, Sub(s, e)
                                               e.Cancel = True
                                               cancel = True
                                           End Sub
        Do Until cancel
            If PCL.Application.Current Is Nothing OrElse PCL.Application.Current.Dispatcher Is Nothing Then GoTo label2
            Exit Do
label2:     Threading.Thread.Sleep(1)
        Loop
        AddHandler PCL.Application.Current.Dispatcher.UnhandledExceptionFilter, Sub(s, e)
                                                                                    e.RequestCatch = False
                                                                                End Sub

        Do Until cancel
            PCL.Application.Current.Dispatcher.Invoke(Sub()
                                                          If PCL.ModMain.FrmMain IsNot Nothing AndAlso PCL.ModMain.FrmMain.IsLoaded Then
                                                              cancel = True
                                                          End If
                                                      End Sub)
            Threading.Thread.Sleep(1)
        Loop
        Console.WriteLine("注入成功!")
        Console.ReadLine()
    End Sub
    Public Function [Get](Key As String) As Object
        Read(Key, SetupDict(Key))
        Return SetupDict(Key).Value
    End Function
    Public Function ReadReg(Key As String) As String
        Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\PCL", True)
        Dim stringBuilder As StringBuilder = New StringBuilder()
        stringBuilder.AppendLine(Conversions.ToString(registryKey.GetValue(Key)))
        Dim text As String = stringBuilder.ToString().Replace(vbCrLf, "")
        Return text
    End Function
    Private Sub Read(Key As String, ByRef E As SetupEntry)
        Try
            If E.State = 0 Then
                Dim source As SetupSource = E.Source
                Dim text As String
                text = ReadReg(Key)
                If E.Encoded Then
                    Try
                        text = SecureRemove(text, "PCL" + GetUniqueCodeFromReg())
                    Catch ex As Exception
                    End Try
                End If
                E.Value = RuntimeHelpers.GetObjectValue(Conversion.CTypeDynamic(text, CType(E.Type, Type)))
            End If
        Catch ex2 As Exception
            E.Value = RuntimeHelpers.GetObjectValue(Conversion.CTypeDynamic(RuntimeHelpers.GetObjectValue(E.DefaultValue), CType(E.Type, Type)))
        End Try
    End Sub
    Sub CrackWithoutPCL2()
        Console.WriteLine("PCL2机器码：" & GetUniqueCodeFromReg())
        Console.WriteLine("请验证机器码是否正确，这对于后续流程十分重要，谢谢。")
        Console.ReadKey()
        Console.WriteLine("输入1进入解密模式，输入2进入设置模式")
        If Console.ReadKey().KeyChar = "1"c Then
            Console.WriteLine()
            Console.WriteLine("注册表解密模式，输入注册表项以解密")
            Do
                Console.Write(">")
                Try
                    Console.WriteLine($"<{[Get](Console.ReadLine())}")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                End Try
            Loop
        Else
            Console.WriteLine()
            Console.WriteLine("注册表设置模式，输入注册表项后并输入值以设置注册表")
            Do
                Console.Write("Key >")
                Dim key = Console.ReadLine()
                Try
                    Console.WriteLine($"Current Value <{[Get](key)}")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Continue Do
                End Try
                Console.Write("New Value >")
                Dim value = Console.ReadLine()
                Try
                    [Set](key, value)
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Continue Do
                End Try
                Console.WriteLine("OK!")
            Loop
        End If
    End Sub
    Sub CrackWithPCL2(path As String)
        Console.WriteLine("Warning:你确定要继续吗？若PCL2作者要报复可能会植入病毒，慎重选择.[Y/n]")
        If Console.ReadKey().KeyChar <> "Y"c Then Exit Sub
        Console.WriteLine()
        Console.WriteLine("AppDomain隔离中...")
        Dim ad = AppDomain.CreateDomain(GetHash("BeqApple_摇摆阳专用_HashCode:" & path.GetHashCode() & Console.In.GetHashCode()))
        ad.SetData("_0", path)
        AddHandler ad.AssemblyResolve, Function(s, e)
                                           If e.Name.Contains("Plain") Then
                                               Console.WriteLine("已加载PCL2模块？")
                                               Return Assembly.Load(File.ReadAllBytes(AppDomain.CurrentDomain.GetData("_0")))
                                           End If
                                           Return Nothing
                                       End Function
        ad.DoCallBack(AddressOf _CrackWithPCL2)
        AppDomain.Unload(ad)
    End Sub
    Sub _CrackWithPCL2()
        Console.WriteLine("PCL2机器码：" & PCL.ModBase.UniqueAddress)
        Console.WriteLine("请验证机器码是否正确，这对于后续流程十分重要，谢谢。")
        Console.ReadKey()
        Console.WriteLine("输入1进入解密模式，输入2进入设置模式")
        If Console.ReadKey().KeyChar = "1"c Then
            Console.WriteLine()
            Console.WriteLine("注册表解密模式，输入注册表项以解密")
            Do
                Console.Write(">")
                Try
                    Console.WriteLine($"<{PCL.ModBase.Setup.[Get](Console.ReadLine())}")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                End Try
            Loop
        Else
            Console.WriteLine()
            Console.WriteLine("注册表设置模式，输入注册表项后并输入值以设置注册表")
            Do
                Console.Write("Key >")
                Dim key = Console.ReadLine()
                Try
                    Console.WriteLine($"Current Value <{PCL.ModBase.Setup.[Get](key)}")
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Continue Do
                End Try
                Console.Write("New Value >")
                Dim value = Console.ReadLine()
                Try
                    PCL.ModBase.Setup.[Set](key, value)
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Continue Do
                End Try
                Console.WriteLine("OK!")
            Loop
        End If
    End Sub
    Private Function GetUniqueCodeFromReg() As String
        Return GetUniqueCode([Get]("Identify"))
    End Function
    Private Function SecureKey(Key As String) As String
        Dim result As String
        If String.IsNullOrEmpty(Key) Then
            result = "@;$ Abv2"
        Else
            result = Strings.Mid(StrFill(Conversions.ToString(GetHash(Key)), "X", 8), 1, 8)
        End If
        Return result
    End Function
    Private Sub [Set](Key As String, value As String)
        If SetupDict(Key).Encoded Then
            value = SecureAdd(value, $"PCL{GetUniqueCodeFromReg()}")
        End If
        WriteReg(Key, value)
    End Sub
    Public Sub WriteReg(Key As String, Value As String)
        Dim currentUser As RegistryKey = Registry.CurrentUser
        Dim registryKey As RegistryKey = currentUser.OpenSubKey("Software\PCL", True)
        If registryKey Is Nothing Then
            registryKey = currentUser.CreateSubKey("Software\PCL")
        End If
        registryKey.SetValue(Key, Value)
    End Sub
    Public Function SecureAdd(SourceString As String, Optional Key As String = "") As String
        Key = SecureKey(Key)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Key)
        Dim bytes2 As Byte() = Encoding.UTF8.GetBytes("95168702")
        Dim descryptoServiceProvider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
        Dim result As String
        Using memoryStream As MemoryStream = New MemoryStream()
            Dim bytes3 As Byte() = Encoding.UTF8.GetBytes(SourceString)
            Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(bytes, bytes2), CryptoStreamMode.Write)
                cryptoStream.Write(bytes3, 0, bytes3.Length)
                cryptoStream.FlushFinalBlock()
                result = Convert.ToBase64String(memoryStream.ToArray())
            End Using
        End Using
        Return result
    End Function
    Public Function SecureRemove(SourceString As String, Optional Key As String = "") As String
        Key = SecureKey(Key)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Key)
        Dim bytes2 As Byte() = Encoding.UTF8.GetBytes("95168702")
        Dim descryptoServiceProvider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
        Dim [string] As String
        Using memoryStream As MemoryStream = New MemoryStream()
            Dim array As Byte() = Convert.FromBase64String(SourceString)
            Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, descryptoServiceProvider.CreateDecryptor(bytes, bytes2), CryptoStreamMode.Write)
                cryptoStream.Write(array, 0, array.Length)
                cryptoStream.FlushFinalBlock()
                [string] = Encoding.UTF8.GetString(memoryStream.ToArray())
            End Using
        End Using
        Return [string]
    End Function

    Function GetUniqueCode(id As String) As String
        Dim str As String
        Using managementObjectSearcher As ManagementObjectSearcher = New ManagementObjectSearcher(New SelectQuery("select * from Win32_ComputerSystemProduct"))
            str = NewLateBinding.LateIndexGet(managementObjectSearcher.[Get]().Cast(Of Object).ElementAtOrDefault(0), New Object() {"Uuid"}, Nothing).ToString()
        End Using
        Dim text2 As String = StrFill(GetHash(str + id).ToString("X"), "7", 16)
        text2 = String.Concat(New String() {Strings.Mid(text2, 5, 4), "-", Strings.Mid(text2, 13, 4), "-", Strings.Mid(text2, 1, 4), "-", Strings.Mid(text2, 9, 4)})
        Return text2
    End Function
    Function StrFill(Str As String, Code As String, Length As Byte) As String
        Dim result As String
        If Str.Length > CInt(Length) Then
            result = Strings.Mid(Str, 1, CInt(Length))
        Else
            ' The following expression was wrapped in a checked-expression
            result = Strings.Mid(Str.PadRight(CInt(Length), Conversions.ToChar(Code)), Str.Length + 1) + Str
        End If
        Return result
    End Function
    Public Function GetHash(Str As String) As ULong
        Dim num As ULong = 5381UL
        Dim num2 As Integer = Str.Length - 1
        For i As Integer = 0 To num2
            num = (num << 5 Xor num Xor AscW(Str(i)))
        Next
        Return num Xor 12218072394304324399UL
    End Function
End Module
