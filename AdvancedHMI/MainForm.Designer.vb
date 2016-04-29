<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.Meter1 = New AdvancedHMIControls.Meter()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(12, 9)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(273, 104)
        Me.QuickStartLabel.TabIndex = 38
        Me.QuickStartLabel.Text = resources.GetString("QuickStartLabel.Text")
        Me.QuickStartLabel.Visible = False
        '
        'Meter1
        '
        Me.Meter1.CommComponent = Me.EthernetIPforCLXCom1
        Me.Meter1.HighlightColor = System.Drawing.Color.Red
        Me.Meter1.Location = New System.Drawing.Point(297, 170)
        Me.Meter1.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Meter1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Meter1.Name = "Meter1"
        Me.Meter1.NumericFormat = Nothing
        Me.Meter1.PLCAddressText = ""
        Me.Meter1.PLCAddressValue = ""
        Me.Meter1.PLCAddressVisible = ""
        Me.Meter1.Size = New System.Drawing.Size(269, 230)
        Me.Meter1.TabIndex = 43
        Me.Meter1.Text = "Meter1"
        Me.Meter1.Value = 0.0R
        Me.Meter1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 31)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "MMI STRESS METER"
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Meter1)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Greer Automation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    Friend WithEvents Meter1 As AdvancedHMIControls.Meter
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
