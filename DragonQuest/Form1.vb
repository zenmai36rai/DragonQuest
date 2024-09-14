' Dragon Quest on Visual Basic Written by Kyosuke Miyazawa 2024
Public Class Form1
    Private PLAYER_STATUS As String
    Private BATTLE_COMMAND() As String = {"　", "＞"}
    Private BC = BATTLE_COMMAND
    Private CURSOR_NUM() = {0, 0, 0, 0}
    Private CURSOR_POS = 0
    Private BATTLE_MESSAGE As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RenderMessage()
    End Sub
    Private Sub RenderMessage()
        Dim CM() = {0, 0, 0, 0}
        CM(CURSOR_POS) = 1
        PLAYER_STATUS = "+--- ゆうしゃ ---+" + vbCrLf + "|   ＨＰ　９９   |" + vbCrLf + "|   ＭＰ　９９   |" + vbCrLf + "+----------------+"
        BATTLE_MESSAGE = "|" + BC(CM(0)) + "たたかう| +-----------------------------+" + vbCrLf + "|" + BC(CM(1)) + "にげる　| | スライムがあらわれた　！     |" + vbCrLf + "|" + BC(CM(2)) + "じゅもん| |                             |" + vbCrLf + "|" + BC(CM(3)) + "どうぐ　| +-----------------------------+"
        RichTextBox1.Text = BATTLE_MESSAGE
        RichTextBox2.Text = PLAYER_STATUS
    End Sub
    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click

    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click

    End Sub

    Private Sub ButtonL_Click(sender As Object, e As EventArgs) Handles ButtonL.Click

    End Sub
    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click

    End Sub
    Private Sub ButtonU_Click(sender As Object, e As EventArgs) Handles ButtonU.Click
        If CURSOR_POS > 0 Then
            CURSOR_POS = CURSOR_POS - 1
        Else
            CURSOR_POS = 3
        End If
        Call RenderMessage()
    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        If CURSOR_POS < 3 Then
            CURSOR_POS = CURSOR_POS + 1
        Else
            CURSOR_POS = 0
        End If
        Call RenderMessage()
    End Sub
End Class
