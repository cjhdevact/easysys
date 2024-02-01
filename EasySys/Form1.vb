Public Class Form1
    Public crlog As Integer
    Public rtexts(100) As String
    Public parch As String
    ' Build Type Dev, Beta, Preview, Release
    Public Const BuildType As String = "Dev"
    '窗口加载
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        crlog = 1
        If System.Environment.Is64BitProcess = True Then
            parch = "x64"
        Else
            parch = "x86"
        End If
        If BuildType = "Dev" Then
            ToolStripLabel1.Visible = True
            ToolStripLabel1.Text = My.Application.Info.Version.ToString & " Dev " & parch
            mainlog("主程序启动 " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Dev " & parch)
            Me.Text = "EasySys                          " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Dev " & parch
        ElseIf BuildType = "Beta" Then
            ToolStripLabel1.Visible = True
            ToolStripLabel1.Text = My.Application.Info.Version.ToString & " Beta " & parch
            mainlog("主程序启动 " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Beta " & parch)
            Me.Text = "EasySys                          " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Beta " & parch
        ElseIf BuildType = "Preview" Then
            ToolStripLabel1.Visible = True
            ToolStripLabel1.Text = My.Application.Info.Version.ToString & " Preview " & parch
            mainlog("主程序启动 " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Preview " & parch)
            Me.Text = "EasySys                          " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Preview " & parch
        ElseIf BuildType = "Release" Then
            ToolStripLabel1.Visible = False
            ToolStripLabel1.Text = ""
            mainlog("主程序启动 " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ")" & parch)
            Me.Text = "EasySys"
        Else
            ToolStripLabel1.Visible = True
            ToolStripLabel1.Text = My.Application.Info.Version.ToString & " " & BuildType & " " & parch
            mainlog("主程序启动 " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") " & BuildType & " " & parch)
            Me.Text = "EasySys                          " & My.Application.Info.Version.ToString & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") " & BuildType & " " & parch
        End If
        rtexts(0) = "欢迎使用 EasySys！"
        rtexts(1) = "路漫漫其修远兮，吾将上下而求索。"
        rtexts(2) = "枯藤老树昏鸦，小桥流水人家，古道西风瘦马。"
        rtexts(3) = "月落乌啼霜满天，江风渔火对愁眠。"
        rtexts(4) = "东市买骏马，西市买鞍鞯；南市买辔头，北市买长鞭。"
        rtexts(5) = "有朋自远方来，不亦乐乎？"
        rtexts(6) = "洛阳亲友如相问，一片冰心在玉壶。"
        rtexts(7) = "一粥一饭，当思来处不易；半丝半缕，恒念.物力维艰。"
        rtexts(8) = "绿遍山原白满川，子规声里雨如烟。"
        rtexts(9) = "人有耻，则能有所不为。"
        rtexts(10) = "不识庐山真面目，只缘身在此山中。"
        rtexts(11) = "梅须逊雪三分白,雪却输梅一段香。"
        rtexts(12) = "粉骨碎身浑不怕，要留清白在人间。"
        rtexts(13) = "千磨万击还坚劲，任尔东西南北风。"
        rtexts(14) = "良药苦口利于病，忠言逆耳利于行。"
        rtexts(15) = "常将有日思无日，莫把无时当有时。"
        rtexts(16) = "穷则变，变则通，通则久。"
        rtexts(17) = "青，取之于蓝，而青于蓝。"
        rtexts(18) = "苟日新，日日新，又日新。"
        rtexts(19) = "聪明在于学习，天才在于积累。"
        rtexts(20) = "劝君更尽一杯酒，西出阳关无故人。"
        rtexts(21) = "随风潜入夜，润物细无声。"
        rtexts(22) = "春风又绿江南岸，明月何时照我还。"
        rtexts(23) = "春色满园关不住，一枝红杏出墙来。"
        rtexts(24) = "谁道人生无再少？门前流水尚能西！休将白发唱黄鸡。"
        rtexts(25) = "路遥知马力，日久见人心。"
        rtexts(26) = "人生自古谁无死？留取丹心照汗青。"
        rtexts(27) = "荷尽已无擎雨盖，菊残犹有傲霜枝。"
        rtexts(28) = "卷地风来忽吹散，望湖楼下水如天。"
        rtexts(29) = "雨后复斜阳，关山阵阵苍。"
        rtexts(30) = "等闲识得东风面，万紫千红总是春。"
        rtexts(31) = "儿童相见不相识，笑问客从何处来。"
        rtexts(32) = "故人舍我归黄壤，流水高山心自知。"
        rtexts(33) = "其实地上本没有路，走的人多了，也便成了路。"
        rtexts(34) = "无情未必真豪杰，怜子如何不丈夫。"
        rtexts(35) = "我寄愁心与明月，随君直到夜郎西。"
        rtexts(36) = "乡书何处达？归雁洛阳边。"
        rtexts(37) = "正是江南好风景，落花时节又逢君。"
        rtexts(38) = "不知何处吹芦管，一夜征人尽望乡。"
        rtexts(39) = "夜阑卧听风吹雨，铁马冰河入梦来。"
        rtexts(40) = "何当共剪西窗烛，却话巴山夜雨时。"
        rtexts(41) = "晴空一鹤排云上，便引诗情到碧霄。"
        rtexts(42) = "此夜曲中闻折柳，何人不起故园情。"
        rtexts(43) = "马上相逢无纸笔，凭君传语报平安。"
        rtexts(44) = "杨花榆荚无才思，惟解漫天作雪飞。"
        rtexts(45) = "斯是陋室，惟吾德馨。"
        rtexts(46) = "山不在高，有仙则名。水不在深，有龙则灵。"
        rtexts(47) = "予独爱莲之出淤泥而不染，濯清涟而不妖，中通外直，不蔓不枝，香远益清，亭亭净植，可远观而不可亵玩焉。"
        rtexts(48) = "会当凌绝顶，一览众山小。"
        rtexts(49) = "不畏浮云遮望眼，自缘身在最高层。"
        rtexts(50) = "落红不是无情物，化作春泥更护花。"
        rtexts(51) = "山重水复疑无路，柳暗花明又一村。"
        rtexts(52) = "烟笼寒水月笼沙，夜泊秦淮近酒家。"
        rtexts(53) = "政入万山围子里，一山放出一山拦。"
        rtexts(54) = "黄梅时节家家雨，青草池塘处处蛙。"
        rtexts(55) = "露从今夜白，月是故乡明。"
        rtexts(56) = "该操作需要一段时间，请坐和放宽。"
    End Sub
    Private Sub EasySysLogo_Click(sender As System.Object, e As System.EventArgs) Handles EasySysLogo.Click
        Dim a As New Random
        Dim i As Integer
        i = a.Next(0, 56)
        TextBox1.Text = rtexts(i)
        i = Nothing
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MyMsgbox.Text = "问题反馈"
        MyMsgbox.MsgTextBox.Text = "      欢迎为 EasySys 提出改进建议！如果你在使用过程中发现一些bug或有更好的建议或想提供注册表规则，欢迎反馈到https://github.com/cjhdevact/easysys/issues！" & vbCrLf & "      感谢您对EasySys的支持。" & vbCrLf & vbCrLf
        MyMsgbox.ShowDialog()

    End Sub
    '关于
    Private Sub AboutButton_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton.Click
        AboutBox1.ShowDialog()
    End Sub
    '系统版本
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        mainlog(System.Environment.OSVersion.ToString)
    End Sub
    '清空输出
    Private Sub OutputClean_Click(sender As System.Object, e As System.EventArgs) Handles OutputClean.Click
        OutputBox.Text = ""
    End Sub
    '保存输出
    Private Sub SaveOutput_Click(sender As System.Object, e As System.EventArgs) Handles SaveOutput.Click
        With SaveFileDialog1
            .Title = "保存输出内容"
            .Filter = "日志文件 (*.log)|*.log|所有文件 (*.*)|*.*"
        End With
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ResStrWrite(OutputBox.Text, SaveFileDialog1.FileName, False)
        End If
    End Sub
    '是否自动写入日志
    Private Sub IsSaveLog_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IsSaveLog.CheckedChanged
        If IsSaveLog.Checked = False Then
            crlog = 0
        ElseIf IsSaveLog.Checked = True Then
            crlog = 1
        End If
    End Sub
    '-----页面2 项目1-----
    Private Sub P2I1B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I1B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I1B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I1B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC下新建DWORD值 名EnableMtcUvc 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10 任务栏音量使用传统菜单 手动操作"
        MyMsgbox.ShowDialog()
    End Sub

    Private Sub P2I1B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I1B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", "HKLM")

    End Sub
    '-----页面2 项目2-----
    Private Sub P2I2B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I2B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell", "UseWin32BatteryFlyout", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I2B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I2B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell下新建DWORD值 名UseWin32BatteryFlyout 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10 任务栏电源使用传统菜单 手动操作"
        MyMsgbox.ShowDialog()
    End Sub

    Private Sub P2I2B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I2B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell", "UseWin32BatteryFlyout", "HKLM")
    End Sub
    '-----页面2 项目3-----
    Private Sub P2I3B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I3B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell", "UseWin32TrayClockExperience", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I3B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I3B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell下新建DWORD值 名UseWin32TrayClockExperience 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10 任务栏电源使用传统菜单 手动操作"
        MyMsgbox.ShowDialog()
    End Sub

    Private Sub P2I3B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I3B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\ImmersiveShell", "UseWin32TrayClockExperience", "HKLM")
    End Sub
    '-----页面2 项目4-----
    Private Sub P2I4B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I4B1.Click
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{088e3905-0323-4b02-9826-5d99428e115f}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{1CF1260C-4DD0-4ebb-811F-33C572699FDE}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{374DE290-123F-4565-9164-39C4925E467B}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A0953C92-50DC-43bf-BE83-3742FED03C9C}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{d3162b92-9365-467a-956b-92703aca08af}", "HKLM")
        addhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}", "HKLM")
    End Sub

    Private Sub P2I4B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I4B2.Click
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{088e3905-0323-4b02-9826-5d99428e115f}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{1CF1260C-4DD0-4ebb-811F-33C572699FDE}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{374DE290-123F-4565-9164-39C4925E467B}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A0953C92-50DC-43bf-BE83-3742FED03C9C}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{d3162b92-9365-467a-956b-92703aca08af}", False, "HKLM")
        delhklmkey("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}", False, "HKLM")
    End Sub

    Private Sub P2I4B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I4B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "导入以下注册表文件：" _
         & vbCrLf & vbCrLf & vbCrLf & "Windows Registry Editor Version 5.00" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{088e3905-0323-4b02-9826-5d99428e115f}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{1CF1260C-4DD0-4ebb-811F-33C572699FDE}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{374DE290-123F-4565-9164-39C4925E467B}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A0953C92-50DC-43bf-BE83-3742FED03C9C}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{d3162b92-9365-467a-956b-92703aca08af}]" _
        & vbCrLf & vbCrLf & "[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}]" _
        & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除添加的12个项。"
        MyMsgbox.Text = "说明 - Windows 10 此电脑页面6个文件夹 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面2 项目5-----
    Private Sub P2I5B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I5B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowLockOption", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I5B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I5B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowLockOption", "HKLM")
    End Sub

    Private Sub P2I5B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I5B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings下新建DWORD值 名ShowLockOption 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10-11 显示锁定 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面2 项目6-----
    Private Sub P2I6B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I6B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowHibernateOption", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I6B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I6B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowHibernateOption", "HKLM")
    End Sub

    Private Sub P2I6B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I6B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings下新建DWORD值 名ShowHibernateOption 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10-11 显示休眠 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面2 项目7-----
    Private Sub P2I7B1_Click(sender As System.Object, e As System.EventArgs) Handles P2I7B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowSleepOption", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P2I7B2_Click(sender As System.Object, e As System.EventArgs) Handles P2I7B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings", "ShowSleepOption", "HKLM")
    End Sub

    Private Sub P2I7B3_Click(sender As System.Object, e As System.EventArgs) Handles P2I7B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings下新建DWORD值 名ShowSleepOption 值00000001。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除该值。"
        MyMsgbox.Text = "说明 - Windows 10-11 显示休眠 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面3 项目1-----
    Private Sub P3I1B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I1B1.Click
        ResStrWrite(My.Resources.OldPersonalizeAdd, Application.StartupPath & "\OldPersonalizeAdd.reg", True)

        Shell("regedit.exe /s """ & Application.StartupPath & "\OldPersonalizeAdd.reg""", AppWinStyle.Hide, True, 5)
        mainlog("成功运行命令 regedit.exe /s """ & Application.StartupPath & "\OldPersonalizeAdd.reg""")
        addhklmreg("DesktopBackground\Shell\OldPersonalize", "MUIVerb", "个性化 (控制面板)", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\01Personalize", "MUIVerb", "个性化", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\02DesktopBackground", "MUIVerb", "桌面背景", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\03Color", "MUIVerb", "颜色", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\04Sounds", "MUIVerb", "声音", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\05Screen Saver", "MUIVerb", "屏幕保护程序", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\06DesktopIcons", "MUIVerb", "更改桌面图标", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("DesktopBackground\Shell\OldPersonalize\shell\07Cursors", "MUIVerb", "更改鼠标指针", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        IO.File.Delete(Application.StartupPath & "\OldPersonalizeAdd.reg")
    End Sub

    Private Sub P3I1B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I1B2.Click
        delhklmkey("DesktopBackground\Shell\OldPersonalize", True, "HKCR")
    End Sub

    Private Sub P3I1B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I1B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "保存相关文件，再导入相关文件中注册表,注意导入前把注册表文件在记事本另存为UTF-8编码再导入。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除HKEY_CLASSER_ROOT\DesktopBackground\Shell\OldPersonalize。"
        MyMsgbox.Text = "说明 - Windows 10-11 右键使用旧个性化 手动操作"
        MyMsgbox.SaveFileDialog1.Filter = "注册表文件(*.reg)|*.reg|所有文件 (*.*)|*.*"
        MyMsgbox.Button2.Visible = True
        MyMsgbox.SaveFileDialog1.FileName = "OldPersonalizeAdd.reg"
        MyMsgbox.res_str = My.Resources.OldPersonalizeAdd
        MyMsgbox.ShowDialog()
        MyMsgbox.SaveFileDialog1.FileName = Nothing
        MyMsgbox.SaveFileDialog1.Filter = Nothing
        MyMsgbox.Button2.Visible = False
        MyMsgbox.res_str = Nothing
    End Sub
    '-----页面3 项目2-----
    Private Sub P3I2B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I2B1.Click
        addhklmreg("AllFilesystemObjects\shellex\ContextMenuHandlers\MicrosoftCopyToService", "", "{C2FBB630-2971-11d1-A18C-00C04FD75D13}", Microsoft.Win32.RegistryValueKind.String, "HKCR")
    End Sub

    Private Sub P3I2B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I2B2.Click
        delhklmkey("AllFilesystemObjects\shellex\ContextMenuHandlers\MicrosoftCopyToService", False, "HKCR")
    End Sub

    Private Sub P3I2B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I2B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_CLASSER_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers下新建项名MicrosoftCopyToService 默认值为{C2FBB630-2971-11d1-A18C-00C04FD75D13}" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除MicrosoftCopyToService项即可。"
        MyMsgbox.Text = "说明 - 右键添加复制到文件夹 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面3 项目3-----
    Private Sub P3I3B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I3B1.Click
        addhklmreg("AllFilesystemObjects\shellex\ContextMenuHandlers\MicrosoftMoveToService", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}", Microsoft.Win32.RegistryValueKind.String, "HKCR")
    End Sub

    Private Sub P3I3B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I3B2.Click
        delhklmkey("AllFilesystemObjects\shellex\ContextMenuHandlers\MicrosoftMoveToService", False, "HKCR")
    End Sub

    Private Sub P3I3B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I3B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_CLASSER_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers下新建项名MicrosoftMoveToService 默认值为{C2FBB631-2971-11D1-A18C-00C04FD75D13}" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除MicrosoftMoveToService项即可。"
        MyMsgbox.Text = "说明 - 右键添加复制到文件夹 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面3 项目4-----
    Private Sub P3I4B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I4B1.Click
        addhklmreg("*\shell\OpenWithNotepad", "", "用记事本打开(&N)", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("*\shell\OpenWithNotepad\command", "", "notepad.exe ""%1""", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        'addhklmreg("*\shell\OpenWithNotepad", "icon", "%windir%\system32\notepad.exe", Microsoft.Win32.RegistryValueKind.String, "HKCR")
    End Sub

    Private Sub P3I4B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I4B2.Click
        delhklmkey("*\shell\OpenWithNotepad", True, "HKCR")
    End Sub

    Private Sub P3I4B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I4B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_CLASSER_ROOT\*\shell下新建项名OpenWithNotepad 默认值为 用记事本打开(&N),再新建子项command 默认值notepad.exe ""%1""" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除OpenWithNotepad项即可。"
        MyMsgbox.Text = "说明 - 右键添加用记事本打开菜单 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面3 项目5-----
    Private Sub P3I5B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I5B1.Click
        addhklmreg("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", "EnabledState", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", "EnabledStateOptions", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", "Variant", 0, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", "VariantPayload", 0, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", "VariantPayloadKind", 0, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P3I5B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I5B2.Click
        addhklmkey("Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32", "HKCU")
    End Sub

    Private Sub P3I5B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I5B3.Click
        delhklmkey("SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283", False, "HKLM")
    End Sub

    Private Sub P3I5B4_Click(sender As System.Object, e As System.EventArgs) Handles P3I5B4.Click
        delhklmkey("Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", True, "HKCU")
    End Sub

    Private Sub P3I5B5_Click(sender As System.Object, e As System.EventArgs) Handles P3I5B5.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "方法1：打开注册表，在HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283下新建值名EnabledState值1 新建值名EnabledStateOptions值1 新建值名Variant值0 新建值名VariantPayload值0 新建值名VariantPayloadKind值0" & vbCrLf & "方法2：新建项HKEY_CURRENT_USER\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "方法1：删除项HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FeatureManagement\Overrides\4\586118283" & vbCrLf & "方法2：删除项HKEY_CURRENT_USER\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32"
        MyMsgbox.Text = "说明 - Windows 11 使用经典右键菜单（需重启资源管理器） 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面3 项目5-----
    Private Sub P3I6B1_Click(sender As System.Object, e As System.EventArgs) Handles P3I6B1.Click
        delhklmreg("Directory\Background\shell\cmd", "Extended", "HKCR")
        delhklmreg("Directory\shell\cmd", "Extended", "HKCR")
    End Sub

    Private Sub P3I6B2_Click(sender As System.Object, e As System.EventArgs) Handles P3I6B2.Click
        addhklmreg("Directory\Background\shell\cmd", "Extended", "", Microsoft.Win32.RegistryValueKind.String, "HKCR")
        addhklmreg("Directory\shell\cmd", "Extended", "", Microsoft.Win32.RegistryValueKind.String, "HKCR")
    End Sub

    Private Sub P3I6B3_Click(sender As System.Object, e As System.EventArgs) Handles P3I6B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "删除在HKEY_CLASSES_ROOT\Directory\Background\shell\cmd和HKEY_CLASSES_ROOT\Directory\shell\cmd下 REG_SZ值项名Extended" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "添加在HKEY_CLASSES_ROOT\Directory\Background\shell\cmd和HKEY_CLASSES_ROOT\Directory\shell\cmd下 REG_SZ值项名Extended 值"""""
        MyMsgbox.Text = "说明 - 右键始终显示使用 Cmd 打开 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面4 项目1-----
    Private Sub P4I1B1_Click(sender As System.Object, e As System.EventArgs) Handles P4I1B1.Click
        addhklmreg("SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 0, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P4I1B2_Click(sender As System.Object, e As System.EventArgs) Handles P4I1B2.Click
        addhklmreg("SYSTEM\CurrentControlSet\Control\CrashControl", "AutoReboot", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
    End Sub

    Private Sub P4I1B3_Click(sender As System.Object, e As System.EventArgs) Handles P4I1B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\CrashControl DWORD值AutoReboot 0=不自动重启 1=自动重启"
        MyMsgbox.Text = "说明 - 出现蓝屏不默认重启 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面5 项目1-----
    Private Sub P5I1B1_Click(sender As System.Object, e As System.EventArgs) Handles P5I1B1.Click
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpg", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".wdp", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jfif", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".dib", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".png", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".bmp", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpe", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpeg", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".gif", "PhotoViewer.FileAssoc.Tiff", Microsoft.Win32.RegistryValueKind.String, "HKLM")
        MessageBox.Show("恢复成功，请在图片文件右键打开方式选择 Windows 照片查看器。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub P5I1B2_Click(sender As System.Object, e As System.EventArgs) Handles P5I1B2.Click
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpg", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".wdp", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jfif", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".dib", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".png", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".bmp", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpe", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".jpeg", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations", ".gif", "HKLM")
        MessageBox.Show("禁用成功，请手动修改图片文件关联。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub P5I1B3_Click(sender As System.Object, e As System.EventArgs) Handles P5I1B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "打开注册表，在HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Photo Viewer\Capabilities\FileAssociations 新建REG_SZ值.jpg .wdp .jfif .dib .png .bmp .png .bmp .jpe .jpeg .jfif 值都为PhotoViewer.FileAssoc.Tiff，再手动设置关联。" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "删除添加的值，再重新设置关联即可。"
        MyMsgbox.Text = "说明 - Windows 10-11 恢复照片查看器 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面5 项目2-----
    Private Sub P5I2B1_Click(sender As System.Object, e As System.EventArgs) Handles P5I2B1.Click
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "HKLM")
        delhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", "HKCU")
    End Sub

    Private Sub P5I2B2_Click(sender As System.Object, e As System.EventArgs) Handles P5I2B2.Click
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableRegistryTools", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKCU")
    End Sub

    Private Sub P5I2B3_Click(sender As System.Object, e As System.EventArgs) Handles P5I2B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "删除在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System DWORD值名DisableRegistryTools" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "添加在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System DWORD值名DisableRegistryTools 值1"
        MyMsgbox.Text = "说明 - 组策略管理注册表编辑器 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面5 项目3-----
    Private Sub P5I3B1_Click(sender As System.Object, e As System.EventArgs) Handles P5I3B1.Click
        delhklmreg("Software\Policies\Microsoft\Windows\System", "DisableCMD", "HKLM")
        delhklmreg("Software\Policies\Microsoft\Windows\System", "DisableCMD", "HKCU")
    End Sub

    Private Sub P5I3B2_Click(sender As System.Object, e As System.EventArgs) Handles P5I3B2.Click
        addhklmreg("Software\Policies\Microsoft\Windows\System", "DisableCMD", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("Software\Policies\Microsoft\Windows\System", "DisableCMD", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKCU")
    End Sub

    Private Sub P5I3B3_Click(sender As System.Object, e As System.EventArgs) Handles P5I3B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "删除在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Policies\Microsoft\Windows\System DWORD值名DisableCMD" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "添加在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Policies\Microsoft\Windows\System DWORD值名DisableCMD 值1"
        MyMsgbox.Text = "说明 - 组策略管理命令提示符（cmd） 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面5 项目4-----
    Private Sub P5I4B1_Click(sender As System.Object, e As System.EventArgs) Handles P5I4B1.Click
        delhklmreg("Software\Policies\Microsoft\Windows\System", "DisableTaskMgr", "HKLM")
        delhklmreg("Software\Policies\Microsoft\Windows\System", "DisableTaskMgr", "HKCU")
    End Sub

    Private Sub P5I4B2_Click(sender As System.Object, e As System.EventArgs) Handles P5I4B2.Click
        addhklmreg("Software\Policies\Microsoft\Windows\System", "DisableTaskMgr", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("Software\Policies\Microsoft\Windows\System", "DisableTaskMgr", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKCU")
    End Sub

    Private Sub P5I4B3_Click(sender As System.Object, e As System.EventArgs) Handles P5I4B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "删除在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Policies\Microsoft\Windows\System DWORD值名DisableTaskMgr" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "添加在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Policies\Microsoft\Windows\System DWORD值名DisableTaskMgr 值1"
        MyMsgbox.Text = "说明 - 组策略管理任务管理器 手动操作"
        MyMsgbox.ShowDialog()
    End Sub
    '-----页面5 项目5-----
    Private Sub P5I5B1_Click(sender As System.Object, e As System.EventArgs) Handles P5I5B1.Click
        delhklmreg("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFileMenu", "HKLM")
        delhklmreg("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFileMenu", "HKCU")
    End Sub

    Private Sub P5I5B2_Click(sender As System.Object, e As System.EventArgs) Handles P5I5B2.Click
        addhklmreg("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFileMenu", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKLM")
        addhklmreg("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoFileMenu", 1, Microsoft.Win32.RegistryValueKind.DWord, "HKCU")
    End Sub

    Private Sub P5I5B3_Click(sender As System.Object, e As System.EventArgs) Handles P5I5B3.Click
        MyMsgbox.MsgTextBox.Text = "开启：" & vbCrLf & "删除在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Microsoft\Windows\CurrentVersion\Policies\Explorer DWORD值名NoFileMenu" & vbCrLf & vbCrLf & "关闭：" & vbCrLf & "添加在HKEY_LOCAL_MACHINE和HKEY_CURRENT_USER下 Software\Microsoft\Windows\CurrentVersion\Policies\Explorer DWORD值名NoFileMenu 值1"
        MyMsgbox.Text = "说明 - 组策略文件夹选项 手动操作"
        MyMsgbox.ShowDialog()
    End Sub

    Private Sub HomeLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles HomeLink.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/cjhdevact/easysys")
    End Sub
End Class
