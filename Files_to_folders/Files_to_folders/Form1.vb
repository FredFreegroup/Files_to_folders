Imports System.Collections
Imports System.IO
Public Class Form1
    Public _dataFormat As String = "yy.MM.dd"
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        DataGridView1.Rows.Clear()
        Dim _path_for_file As String = ""
        Dim _searchOpt As Integer = Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories
        If _folders.Checked = False Then
            _searchOpt = Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly
        End If

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(_path.Text, _searchOpt)
            Dim Information = My.Computer.FileSystem.GetFileInfo(foundFile)
            Dim s = _exception.Text.IndexOf(Information.Extension)
            If _exception.Text.IndexOf(Information.Extension) <> 1 Then
                Dim row0 As String() = {Information.Name.ToString, Format(Information.CreationTime, "dd.MM.yy").ToString, Format(Information.LastAccessTime, "dd.MM.yy").ToString, Format(Information.LastWriteTime, "dd.MM.yy").ToString}
                With Me.DataGridView1.Rows.
                    Add(row0)
                End With
            End If
        Next
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(_path.Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories)
            Dim _path_for_file As String = ""
            Dim Information = My.Computer.FileSystem.GetFileInfo(foundFile)
            Dim s = _exception.Text.IndexOf(Information.Extension)
            If _exception.Text.IndexOf(Information.Extension) <> 1 Then
                If _by_data.Checked Then
                    If RadioButton1.Checked Then
                        _path_for_file = "\" & Format(Information.CreationTime, _dataFormat)
                    End If
                    If RadioButton2.Checked Then
                        _path_for_file = "\" & Format(Information.LastAccessTime, _dataFormat)
                    End If
                    If RadioButton3.Checked Then
                        _path_for_file = "\" & Format(Information.LastWriteTime, _dataFormat)
                    End If
                End If
                If _by_type.Checked Then
                    _path_for_file = _path_for_file & "\" & Replace(Information.Extension, ".", "")
                End If
                _path_for_file = _path.Text & _path_for_file

                If My.Computer.FileSystem.DirectoryExists(_path_for_file) = False Then
                    My.Computer.FileSystem.CreateDirectory(_path_for_file)
                End If
                If foundFile <> _path_for_file & "\" & Information.Name Then
                    Try
                        My.Computer.FileSystem.MoveFile(foundFile, _path_for_file & "\" & Information.Name)

                    Catch ex As System.IO.IOException
                        Dim Information2 = My.Computer.FileSystem.GetFileInfo(_path_for_file & "\" & Information.Name)
                        Dim ans As String = ""

                        If RadioButton1.Checked Then
                            ans = MessageBox.Show("File exist exception. Overwrite? " & ControlChars.CrLf & Information.Name & ControlChars.Tab & Math.Round(Information.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information.CreationTime & ControlChars.CrLf & Information2.Name & ControlChars.Tab & Math.Round(Information2.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information2.CreationTime, "File exist", MessageBoxButtons.YesNoCancel)
                        End If
                        If RadioButton2.Checked Then
                            ans = MessageBox.Show("File exist exception. Overwrite? " & ControlChars.CrLf & Information.Name & ControlChars.Tab & Math.Round(Information.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information.LastAccessTime & ControlChars.CrLf & Information2.Name & ControlChars.Tab & Math.Round(Information2.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information2.LastAccessTime, "File exist", MessageBoxButtons.YesNoCancel)
                        End If
                        If RadioButton3.Checked Or (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                            ans = MessageBox.Show("File exist exception. Overwrite? " & ControlChars.CrLf & Information.Name & ControlChars.Tab & Math.Round(Information.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information.LastWriteTime & ControlChars.CrLf & Information2.Name & ControlChars.Tab & Math.Round(Information2.Length / 1024, 2) & "Kb." & ControlChars.Tab & Information2.LastWriteTime, "File exist", MessageBoxButtons.YesNoCancel)
                        End If
                        If ans = System.Windows.Forms.DialogResult.Yes Then
                            Try
                                My.Computer.FileSystem.MoveFile(foundFile, _path_for_file & "\" & Information.Name, True)
                            Catch ex2 As Exception
                                MessageBox.Show(ex2.ToString)
                            End Try
                        ElseIf ans = System.Windows.Forms.DialogResult.Cancel Then
                            Exit Sub
                        End If
                    Catch ex As UnauthorizedAccessException

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            End If
        Next
        MessageBox.Show("Done")

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            FolderBrowserDialog2.SelectedPath = _path.Text
        Catch ex As Exception
            FolderBrowserDialog2.SelectedPath = ""
        End Try

        If FolderBrowserDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _path.Text = FolderBrowserDialog2.SelectedPath
            My.Settings.save_path = _path.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub _by_data_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _by_data.CheckedChanged
        If _by_data.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = True
        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Form1_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _path.Text = My.Settings.save_path
        _exception.Text = My.Settings.exception

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            _dataFormat = "yy.MM.dd"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            _dataFormat = "dd.MM.yy"
        End If
    End Sub

    Private Sub _path_TextChanged(sender As System.Object, e As System.EventArgs) Handles _path.TextChanged
        My.Settings.save_path = _path.Text
        My.Settings.Save()
    End Sub

    Private Sub _exception_TextChanged(sender As System.Object, e As System.EventArgs) Handles _exception.TextChanged
        My.Settings.exception = _exception.Text
        My.Settings.Save()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            _dataFormat = "yy.MM"
        End If
    End Sub
End Class
