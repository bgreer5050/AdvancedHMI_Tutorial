Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************

    Dim stateTimer As System.Threading.Timer


    Private NotFirstShow As Boolean
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        stateTimer = New System.Threading.Timer(AddressOf updatemeter, vbNull, 1000, 250)




     


    End Sub


    Public Sub updatemeter(ByVal StateObj As Object)

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6. 
        Dim value As Integer = CInt(Int((99 * Rnd()) + 1))
        ' Dim meterValue As Double;
        Meter1.Value = Double.Parse(value.ToString())

    End Sub

End Class
