Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form when it loads
    End Sub

    Private Sub CmdRun_Click(sender As Object, e As EventArgs) Handles CmdRun.Click
        ' This event handler is called when the "Run" button is clicked

        ' Clear the output TextBox
        txtOutput.Clear()

        ' Get the command from the input TextBox
        Dim command As String = txtInput.Text.Trim()

        ' Check if the command is empty
        If String.IsNullOrEmpty(command) Then
            MessageBox.Show("Please enter a command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create a new process to run the command
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Arguments = "/C " & command
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True

        ' Add an event handler for reading the output data
        AddHandler process.OutputDataReceived, AddressOf OutputDataReceived
        AddHandler process.ErrorDataReceived, AddressOf ErrorDataReceived

        ' Start the process
        process.Start()

        ' Begin asynchronous reading of the output stream
        process.BeginOutputReadLine()
        process.BeginErrorReadLine()
    End Sub

    Private Sub OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        ' This event handler is called when data is received from the standard output

        If e.Data IsNot Nothing Then
            ' Display the output data in the output TextBox
            AppendText(txtOutput, e.Data & Environment.NewLine)
        End If
    End Sub

    Private Sub ErrorDataReceived(sender As Object, e As DataReceivedEventArgs)
        ' This event handler is called when data is received from the standard error

        If Len(e.Data) > 0 Then
            ' Ignore Empty Data
            AppendText(txtOutput, e.Data & Environment.NewLine)
        End If
    End Sub

    ' Helper function to append text to a TextBox
    Private Sub AppendText(textBox As TextBox, text As String)
        If textBox.InvokeRequired Then
            textBox.Invoke(Sub() AppendText(textBox, text))
        Else
            textBox.AppendText(text)
        End If
    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub
End Class
