' Dragon Quest on Visual Basic Written by Kyosuke Miyazawa 2024
Public Class Form1
    Private PLAYER_STATUS As String
    Private BATTLE_COMMAND As String
    Private BATTLE_MESSAGE As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLAYER_STATUS = "+--- ゆうしゃ ---+" + vbCrLf + "|   ＨＰ　９９   |" + vbCrLf + "|   ＭＰ　９９   |" + vbCrLf + "+----------------+"
        BATTLE_MESSAGE = "|＞たたかう| +-----------------------------+" + vbCrLf + "|　にげる　| | スライムがあらわれた　！     |" + vbCrLf + "|　じゅもん| |                             |" + vbCrLf + "|　どうぐ　| +-----------------------------+"
        RichTextBox1.Text = BATTLE_MESSAGE
        RichTextBox2.Text = PLAYER_STATUS
    End Sub

    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click

    End Sub

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click

    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click

    End Sub

    Private Sub ButtonL_Click(sender As Object, e As EventArgs) Handles ButtonL.Click

    End Sub

    Private Sub ButtonU_Click(sender As Object, e As EventArgs) Handles ButtonU.Click

    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click

    End Sub
End Class
