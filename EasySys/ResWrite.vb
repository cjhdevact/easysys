Module ResWrite
    Public errcode
    Public Sub ResStrWrite(ByVal respath As String, ByVal wrtpath As String, ByVal uselog As Boolean)
        errcode = 0
        Try
            If wrtpath <> "" Then
                If System.IO.File.Exists(wrtpath) = False Then
                    '设置释放路径   导出路径
                    Dim fs As New System.IO.FileStream(wrtpath, IO.FileMode.Create)
                    fs.Close()
                    Dim fs2 As New IO.StreamWriter(wrtpath)
                    fs2.WriteLine(respath)
                    fs2.Close()

                Else
                    IO.File.Delete(wrtpath)
                    '设置释放路径   导出路径
                    Dim fs As New System.IO.FileStream(wrtpath, IO.FileMode.Create)
                    fs.Close()
                    Dim fs2 As New IO.StreamWriter(wrtpath)
                    fs2.WriteLine(respath)
                    fs2.Close()
                End If
            End If

        Catch ex As Exception
            errcode = 1
            If uselog = True Then
                mainlog("将文件写入到 " & wrtpath & " 时发生错误" & ex.Message)
            Else
                MessageBox.Show("将文件写入到 " & wrtpath & " 时发生错误" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
        If errcode = 0 Then
            If uselog = True Then
                mainlog("将文件写入到 " & wrtpath & " 成功")
            End If
        End If

    End Sub

End Module
