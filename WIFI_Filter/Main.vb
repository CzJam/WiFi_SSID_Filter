Imports System.IO

Public Class Main
    Private Sub ShowSSID_Click(sender As Object, e As EventArgs) Handles ShowSSID.Click

        SC("netsh wlan add filter permission=allow ssid=" & WifiList.Text & " networktype=infrastructure")
        MsgBox("操作完成",, "完成")
    End Sub

    Private Sub HideSSID_Click(sender As Object, e As EventArgs) Handles HideSSID.Click

        SC("netsh wlan delete filter permission=allow ssid=" & WifiList.Text & " networktype=infrastructure")
        MsgBox("操作完成",, "完成")
    End Sub

    Private Sub ShowAllSSID_Click(sender As Object, e As EventArgs) Handles ShowAllSSID.Click
        SC("netsh wlan delete filter permission=denyall networktype=infrastructure")

        MsgBox("操作完成",, "完成")

    End Sub


    Private Sub Website_Click(sender As Object, e As EventArgs) Handles Website.Click
        SC("start https://jamcz.com")
    End Sub

    Private Sub Author_Click(sender As Object, e As EventArgs) Handles Author.Click
        SC("start https://space.bilibili.com/251013709")
    End Sub



    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WifiWhiteList.Text = Replace(SC("netsh wlan show filters | findstr SSID"), "，类型: 结构", "")
    End Sub


    Public Function SC(ByVal strCMD As String) As String
        Dim p As New Process

        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = "/c " + strCMD
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        p.Start()

        Dim result As String = p.StandardOutput.ReadToEnd()
        p.Close()
        Return result

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WifiWhiteList.Text = Replace(Replace(SC("netsh wlan show filters | findstr SSID"), "，类型: 结构", ""), "SSID: " + Chr(34) + Chr(34), "")

    End Sub

    Private Sub HideAllSSID_Click(sender As Object, e As EventArgs) Handles HideAllSSID.Click
        SC("netsh wlan set blockednetworks display=hide")
        SC("netsh wlan add filter permission=denyall networktype=infrastructure")
        MsgBox("操作完成",, "完成")
    End Sub
End Class
