Module LogModule
    Public Sub mainlog(ByVal logstr As String)
        Dim crd As String
        crd = Format(Now, "yyyyMMdd")
        If Form1.OutputBox.Text = "" Then
            Form1.OutputBox.Text = Format(Now, "[yyyy-MM-dd HH:mm:ss] ") & logstr
        Else
            Form1.OutputBox.Text = Format(Now, "[yyyy-MM-dd HH:mm:ss] ") & logstr & vbCrLf & vbCrLf & Form1.OutputBox.Text
        End If
        If Form1.crlog = 1 Then
            If System.IO.File.Exists(Application.StartupPath & "\Output_" & crd & ".log") = False Then
                Dim fs As New System.IO.FileStream(Application.StartupPath & "\Output_" & crd & ".log", IO.FileMode.Create)
                fs.Close()
                Dim fs2 As New IO.StreamWriter(Application.StartupPath & "\Output_" & crd & ".log")
                fs2.WriteLine(Format(Now, "[yyyy-MM-dd HH:mm:ss] ") & logstr)
                fs2.Close()
            Else
                Dim wrdta As String
                Dim fs As New IO.StreamReader(Application.StartupPath & "\Output_" & crd & ".log")
                wrdta = fs.ReadToEnd()
                fs.Close()
                Dim fs2 As New IO.StreamWriter(Application.StartupPath & "\Output_" & crd & ".log")
                fs2.WriteLine(Format(Now, "[yyyy-MM-dd HH:mm:ss] ") & logstr & vbCrLf & vbCrLf & wrdta)
                fs2.Close()
            End If
        End If
    End Sub
End Module
