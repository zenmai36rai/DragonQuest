Public Class Form1
    Private BATTLE_LOG As String
    Private PLAYER_STATUS As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PLAYER_STATUS = "+--- ゆうしゃ ---+" + vbCrLf + "|     HP 99     |" + vbCrLf + "|     MP 99     |" + vbCrLf + "+---------------+"
        BATTLE_LOG = "+---------------------+" + vbCrLf + "| スライムがあらわれた |" + vbCrLf + "+---------------------+"
        RichTextBox1.Text = BATTLE_LOG
        RichTextBox2.Text = PLAYER_STATUS
    End Sub
End Class
