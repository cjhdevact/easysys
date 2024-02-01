﻿Public Class AboutBox1
    Public parch As String
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置此窗体的标题。
        'Dim ApplicationTitle As String
        'If My.Application.Info.Title <> "" Then
        'ApplicationTitle = My.Application.Info.Title
        'Else
        'ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If
        'Me.Text = String.Format("关于 {0}", ApplicationTitle)
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        'Me.LabelProductName.Text = My.Application.Info.ProductName
        If System.Environment.Is64BitProcess = True Then
            parch = "x64"
        Else
            parch = "x86"
        End If
        If Form1.BuildType = "Dev" Then
            Me.Label2.Text = String.Format("版本：{0}", My.Application.Info.Version.ToString) & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Dev " & parch
        ElseIf Form1.BuildType = "Beta" Then
            Me.Label2.Text = String.Format("版本：{0}", My.Application.Info.Version.ToString) & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Beta " & parch
        ElseIf Form1.BuildType = "Preview" Then
            Me.Label2.Text = String.Format("版本：{0}", My.Application.Info.Version.ToString) & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") Preview " & parch
        ElseIf Form1.BuildType = "Release" Then
            Me.Label2.Text = String.Format("版本：{0}", My.Application.Info.Version.ToString) & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") " & parch
        Else
            Me.Label2.Text = String.Format("版本：{0}", My.Application.Info.Version.ToString) & " (Build " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & ") " & Form1.BuildType & " " & parch
        End If

        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        'Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MyMsgbox.MsgTextBox.Text = My.Resources.bugs
        MyMsgbox.Text = "Bugs"
        MyMsgbox.ShowDialog()
    End Sub
End Class
