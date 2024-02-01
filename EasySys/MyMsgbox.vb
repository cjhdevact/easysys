Public NotInheritable Class MyMsgbox
    Public res_str As String
    Private Sub MyMsgbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ResStrWrite(res_str, SaveFileDialog1.FileName, False)
        End If
    End Sub
End Class
