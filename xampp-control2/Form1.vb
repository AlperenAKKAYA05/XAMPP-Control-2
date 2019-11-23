Imports System.Runtime.InteropServices
Imports System.IO
Imports System.ComponentModel

Partial Class Form1
    Dim kapatma = 0
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Process.Start(Application.StartupPath & "/apache_start.exe", AppWinStyle.Hide)
            TrueApache.Visible = True
            FalseApache.Visible = False
            Label1.Text = "Apache | On"


        End If
        If CheckBox1.Checked = False Then
            Process.Start(Application.StartupPath & "/apache_stop.bat", AppWinStyle.Hide)
            Shell("TASKKILL /F /IM cmd.exe")
            Shell("TASKKILL /F /IM httpd.exe")
            Shell("TASKKILL /F /IM conhost.exe")
            TrueApache.Visible = False
            FalseApache.Visible = True
            Label1.Text = "Apache | Off"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Process.Start(Application.StartupPath & "/mysql_start.exe", AppWinStyle.Hide)
            TrueMySQL.Visible = True
            FalseMySQL.Visible = False
            Label2.Text = "MySQL | On"
        End If
        If CheckBox2.Checked = False Then
            Process.Start(Application.StartupPath & "/mysql_stop.bat", AppWinStyle.Hide)
            Shell("TASKKILL /F /IM cmd.exe")
            Shell("TASKKILL /F /IM mysqld.exe")
            TrueMySQL.Visible = False
            FalseMySQL.Visible = True
            Label2.Text = "MySQL | Off"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrueApache.Visible = False
        TrueMySQL.Visible = False
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        NotifyIcon.ShowBalloonTip(10, "Başlık", "Uyarı", ToolTipIcon.Info)
    End Sub

    Private Sub GirişToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GirişToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub UyarıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UyarıToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ÇıkışToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem1.Click
        kapatma = 1
        Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIcon.ShowBalloonTip(10, "Başlık", "Uyarı", ToolTipIcon.Info)
        Me.Hide()
        If kapatma = 1 Then
            Process.Start(Application.StartupPath & "/apache_stop.bat", AppWinStyle.Hide)
            Process.Start(Application.StartupPath & "/mysql_stop.bat", AppWinStyle.Hide)
            Shell("TASKKILL /F /IM cmd.exe")
            Shell("TASKKILL /F /IM mysqld.exe")
            Shell("TASKKILL /F /IM httpd.exe")
            Shell("TASKKILL /F /IM conhost.exe")
            e.Cancel = False
        End If
        If kapatma = 0 Then
            e.Cancel = True
        End If
    End Sub
End Class