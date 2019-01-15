Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Button1.Enabled = True
        Button3.Enabled = False
        TextBox1.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

        Dim s As String = TextBox1.Text
        Dim ipa As String = s.Split(".")(0)
        Dim ipb As String = s.Split(".")(1)
        Dim ipc As String = s.Split(".")(2)
        Dim ipd As String = s.Split(".")(3)
        Dim i As String
        Dim num As String
        num = ipa + "." + ipb + "." + ipc + "." + ipd
        If My.Computer.Network.Ping(s) Then
            ListBox1.Items.Add(s + "   Online")
            i = ipd + 1
            TextBox1.Text = ipa + "." + ipb + "." + ipc + "." + i
        Else
            ListBox1.Items.Add(s + "   Offline")
            i = ipd + 1
            TextBox1.Text = ipa + "." + ipb + "." + ipc + "." + i
        End If
        Button1.Enabled = False
        Button3.Enabled = True
        TextBox1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim s As String = TextBox1.Text
        Dim ipa As String = s.Split(".")(0)
        Dim ipb As String = s.Split(".")(1)
        Dim ipc As String = s.Split(".")(2)
        Dim ipd As String = s.Split(".")(3)
        Dim i As String
        Dim num As String
        num = ipa + "." + ipb + "." + ipc + "." + ipd
        If My.Computer.Network.Ping(s) Then
            ListBox1.Items.Add(s + "   Online")
            i = ipd + 1
            TextBox1.Text = ipa + "." + ipb + "." + ipc + "." + i
        Else
            ListBox1.Items.Add(s + "   Offline")
            i = ipd + 1
            TextBox1.Text = ipa + "." + ipb + "." + ipc + "." + i
        End If
        If ipd = 255 Then
            Timer1.Stop()
            TextBox1.Enabled = True
            Button1.Enabled = True
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


End Class
