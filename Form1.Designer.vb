<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CmdRun = New Button()
        txtInput = New TextBox()
        txtOutput = New TextBox()
        SuspendLayout()
        ' 
        ' CmdRun
        ' 
        CmdRun.Location = New Point(12, 12)
        CmdRun.Name = "CmdRun"
        CmdRun.Size = New Size(63, 23)
        CmdRun.TabIndex = 0
        CmdRun.Text = "Run"
        CmdRun.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(81, 12)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.ScrollBars = ScrollBars.Vertical
        txtInput.Size = New Size(601, 23)
        txtInput.TabIndex = 1
        txtInput.Text = "curl -svo /dev/null https://www.fastly.com/"
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(12, 41)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.ScrollBars = ScrollBars.Both
        txtOutput.Size = New Size(776, 397)
        txtOutput.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtOutput)
        Controls.Add(txtInput)
        Controls.Add(CmdRun)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Declare form components as class members
    Friend WithEvents CmdRun As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
End Class
