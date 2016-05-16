

Class MainWindow

    Public Parser As MyParser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Parser = New MyParser
        Parser.ReadXML()

    End Sub

    Public Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' MessageBox.Show(String.Format("Hi {0}", Me.txtName.Text))
        Parser = New MyParser
        Parser.ReadXML()
    End Sub
    Public Sub OpenFileDialog_Inputs(sender As Object, e As RoutedEventArgs)
        ' MessageBox.Show(String.Format("Hi {0}", Me.txtName.Text))

        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension 
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"
        dlg.Multiselect = True
        ' Display OpenFileDialog by calling ShowDialog method 
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox 
        If result = True Then
            ' Open document .
            Dim filename As String = ""
            Debug.Print(dlg.FileNames.Count)

            For i = 0 To dlg.FileNames.Count - 1
                filename = filename & dlg.FileNames(i) & Environment.NewLine
            Next

            InputFileList.Text = InputFileList.Text & filename
        End If
    End Sub
    Public Sub OpenFileDialog_Output(sender As Object, e As RoutedEventArgs)
        ' MessageBox.Show(String.Format("Hi {0}", Me.txtName.Text))

        Dim dlg = New System.Windows.Forms.FolderBrowserDialog()

        Dim btn As Button = sender

        ' Display OpenFileDialog by calling ShowDialog method 
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()
        Debug.Print(btn.Name)
        ' Get the selected file name and display in a TextBox 
        If result = True Then
            ' Open document .
            Dim pathname As String = dlg.SelectedPath
            If btn.Name = "btnBrowseOutputFolder" Then
                txtOutputPath.Text = pathname
            Else
                txtReportPath.Text = pathname
            End If

        End If
    End Sub
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        '   MessageBox.Show(String.Format("I'm loading"))
        'Parser = New MyParser
        'Parser.ReadXML()
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs)
        If Parser Is Nothing Then
            Parser = New MyParser
        End If
        Parser.ReadXML()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

    End Sub
End Class


