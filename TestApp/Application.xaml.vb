Class Application
    Private Sub Application_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
        ' MessageBox.Show(String.Format("I starting up"))
        Test.MainTest()
    End Sub

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

End Class
