Imports Microsoft.Win32
Imports System.IO

Class MainWindow

    Private Sub nuevoClick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MenuItem1.Click
        document.Text = ""
    End Sub

    Private Sub guardarClick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MenuItem1.Click
        Dim save As New SaveFileDialog
        Dim mistreamwrite As StreamWriter
        save.Filter = "text (*.txt)|*.txt|html(*.html)|*.html|all files(*.*)|*.*"
        save.CheckPathExists = True
        save.Title = "guardar como"
        save.ShowDialog(Me)
        Try
            mistreamwrite = File.AppendText(save.FileName)
            mistreamwrite.Write(document.Text)
            mistreamwrite.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub abrirClick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MenuItem1.Click
        Dim open As New OpenFileDialog
        Dim mistreamwrite As StreamReader
        open.Filter = "text (*.txt)|*.txt"
        open.CheckFileExists = True
        open.Title = "abrir"
        open.ShowDialog()
        Try
            open.OpenFile()
            mistreamwrite = New StreamReader((open.FileName))
            document.Text = mistreamwrite.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub

End Class
