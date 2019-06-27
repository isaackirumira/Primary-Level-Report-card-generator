Public Class sms

    Private Sub sms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim l As String = "http://localhost/sms/tourists2.php"

        WebBrowser1.Navigate(l)

    End Sub
    Private Sub WebBrowser1_DocumentCompleted( _
                              ByVal sender As Object, _
                              ByVal e As WebBrowserDocumentCompletedEventArgs) _
                              Handles WebBrowser1.DocumentCompleted
        If (WebBrowser1.ReadyState = WebBrowserReadyState.Complete) Then
            For Each ClientControl As HtmlElement In WebBrowser1.Document.Links
                Debug.Print(ClientControl.GetAttribute("href"))
            Next
        End If
    End Sub
End Class