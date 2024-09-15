' Dragon Quest on Visual Basic Written by Kyosuke Miyazawa 2024
Public Class Form1
    'コントローラのボタン
    Const KEY_UP = 1
    Const KEY_DOWN = 2
    Const KEY_LEFT = 3
    Const KEY_RIGHT = 4
    Const KEY_A = 5
    Const KEY_B = 6

    'ゲームシーン遷移
    Const TITLE_SCENE = 1
    Const MAP_SCENE = 2
    Const BATTLE_SCENE = 3
    Private SCENE_STATE = MAP_SCENE

    'ウインドウ表示文字列群
    Private PLAYER_STATUS As String
    Private BATTLE_COMMAND() As String = {"　", "＞"}
    Private BC = BATTLE_COMMAND
    Private CURSOR_NUM() = {0, 0, 0, 0, 0}
    Private CURSOR_POS = 0
    Private BATTLE_MESSAGE As String

    '地図画面でのキャラ座標
    Private HERO_POSITION_X = 0
    Private HERO_POSITION_Y = 0

    'キャラステータス
    Private HERO_HP = 99
    Private HERO_MP = 99
    Private HERO_ST = 3
    Private HERO_DF = 3

    Private MESSAGE_1 = ""
    Private MESSAGE_2 = ""

    Private TURN = 0
    Private ATTACK = 0
    Private DEFFENCE = 0

    Private ENEMY_HP = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RenderMessage()
        SceneChange(SCENE_STATE)
    End Sub
    Private WINNER_FLAG = False
    Private Sub InitBattle()
        WINNER_FLAG = False
        Dim msg1 As String = "スライムがあらわれた　！      "
        Dim msg2 As String = ""
        Call WriteMessage(msg1, msg2)
        ENEMY_HP = 5
        Call RenderMessage()
    End Sub
    Private HP_STR = "００"
    Private MP_STR = "９９"
    Private Sub CalcDisp()
        If HERO_HP < 0 Then
            Exit Sub
        End If
        Static NUM() = {"０", "１", "２", "３", "４", "５", "６", "７", "８", "９"}
        Dim d As Integer = HERO_HP Mod 10
        Dim u As Integer = (HERO_HP - d) / 10
        HP_STR = NUM(u) + NUM(d)
    End Sub
    Private Sub WriteMessage(ByVal msg1 As String, ByVal msg2 As String)
        MESSAGE_1 = msg1
        MESSAGE_2 = msg2
    End Sub
    Private Sub RenderMessage()
        Call CalcDisp()
        Dim msg1 = MESSAGE_1
        Dim msg2 = MESSAGE_2
        If msg1 = "" Then
            msg1 = "                             "
        End If
        If msg2 = "" Then
            msg2 = "                             "
        End If
        Dim CM() = {0, 0, 0, 0, 0}
        CM(CURSOR_POS) = 1
        PLAYER_STATUS = "+--- ゆうしゃ ---+" + vbCrLf + "|   ＨＰ　" + HP_STR + "   |" + vbCrLf + "|   ＭＰ　９９   |" + vbCrLf + "+----------------+"
        BATTLE_MESSAGE = "|" + BC(CM(0)) + "たたかう| +-----------------------------+" + vbCrLf + "|" + BC(CM(1)) + "にげる　| |" + msg1 + "|" + vbCrLf + "|" + BC(CM(2)) + "じゅもん| |" + msg2 + "|" + vbCrLf + "|" + BC(CM(3)) + "どうぐ　| +-----------------------------+"
        RichTextBox1.Text = BATTLE_MESSAGE
        RichTextBox2.Text = PLAYER_STATUS
    End Sub
    Private CRITICAL_INT As Integer = 0
    Private DAMAGE_INT As Integer = 0
    Private DAMAGE_STR = "０"
    Private Sub CalcDamage(ByVal k As Integer)
        Static NUM() = {"０", "１", "２", "３", "４", "５", "６", "７", "８", "９"}
        DAMAGE_INT = Rnd(9) * k
        CRITICAL_INT = Rnd(9) * 2
        DAMAGE_STR = NUM(DAMAGE_INT)
        If (DAMAGE_INT = k) And (2 = CRITICAL_INT) Then
            CRITICAL_INT = DAMAGE_INT * 2
            DAMAGE_STR = NUM(CRITICAL_INT)
        Else
            CRITICAL_INT = 0
        End If
    End Sub
    Private Function DoEscape() As Boolean
        DoEscape = True
        Dim esc As Integer = Rnd(4) * 4
        If 0 = esc Then
            DoEscape = False
        End If
        Return DoEscape
    End Function

    Private CURSOR_MEMORY = 0
    Private TURN_START = 0
    Private Sub BattleTurn(ByVal cmd)
        If cmd = 0 Or cmd = 4 Then ' たたかう
            If TURN = TURN_START Then
                TURN = TURN + 1
                ATTACK = 1
                DEFFENCE = 1
                CURSOR_MEMORY = CURSOR_POS
                CURSOR_POS = 4
            End If
            If ATTACK = 1 Then
                Call CalcDamage(HERO_ST)
                If CRITICAL_INT = 0 Then
                    Dim msg1 As String = "ゆうしゃのこうげき　！        "
                    Dim msg2 As String = "スライムに" + DAMAGE_STR + "ダメージあたえた  "
                    If DAMAGE_INT = 0 Then
                        msg2 = "ミス！ダメージをあたえられない"
                    End If
                    ENEMY_HP = ENEMY_HP - DAMAGE_INT
                    Call WriteMessage(msg1, msg2)
                Else
                    Dim msg1 As String = "かいしんのいちげき　！        "
                    Dim msg2 As String = "スライムに" + DAMAGE_STR + "ダメージあたえた  "
                    ENEMY_HP = ENEMY_HP - CRITICAL_INT
                    Call WriteMessage(msg1, msg2)
                End If
                ATTACK = 0
                Exit Sub
            End If
            If DEFFENCE = 1 Then
                If 0 < ENEMY_HP Then
                    Call CalcDamage(2)
                    Dim msg1 As String = "スライムのこうげき　！        "
                    Dim msg2 As String = "ゆうしゃは" + DAMAGE_STR + "ダメージうけた    "
                    HERO_HP = HERO_HP - DAMAGE_INT
                    Call WriteMessage(msg1, msg2)
                Else
                    Dim msg1 As String = "スライムをやっつけた　！      "
                    Dim msg2 As String = "                             "
                    Call WriteMessage(msg1, msg2)
                    WINNER_FLAG = True
                End If
                DEFFENCE = 0
                Exit Sub
            End If
            If TURN > 0 And ATTACK = 0 And DEFFENCE = 0 Then
                Dim msg1 As String = "コマンドをえらんでください    "
                Dim msg2 As String = "                             "
                Call WriteMessage(msg1, msg2)
                CURSOR_POS = CURSOR_MEMORY
                TURN_START = TURN
                Exit Sub
            End If
        End If
        If cmd = 1 Then ' にげる
            Dim msg1 As String = "ゆうしゃはにげた　！          "
            Dim msg2 As String = "しかし　まわりこまれた        "
            If DoEscape() = True Then
                msg2 = "うまく　にげのびた            "
            End If

            Call WriteMessage(msg1, msg2)
        End If
    End Sub
    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        ClickButtons(KEY_A, SCENE_STATE)
    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click

    End Sub

    Private Sub ButtonL_Click(sender As Object, e As EventArgs) Handles ButtonL.Click
        ClickButtons(KEY_LEFT, SCENE_STATE)

    End Sub
    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        ClickButtons(KEY_RIGHT, SCENE_STATE)

    End Sub
    Private Sub ButtonU_Click(sender As Object, e As EventArgs) Handles ButtonU.Click
        ClickButtons(KEY_UP, SCENE_STATE)
    End Sub
    Private Sub ClickButtons(ByVal key As Integer, ByVal ss As Integer)
        If ss = BATTLE_SCENE Then
            If key = KEY_A And WINNER_FLAG Then
                SceneChange(MAP_SCENE)
            End If
            If key = KEY_A Then
                BattleTurn(CURSOR_POS)
            End If
            If key = KEY_UP Then
                If CURSOR_POS > 0 Then
                    CURSOR_POS = CURSOR_POS - 1
                Else
                    CURSOR_POS = 3
                End If
            End If
            If key = KEY_DOWN Then
                If CURSOR_POS < 3 Then
                    CURSOR_POS = CURSOR_POS + 1
                Else
                    CURSOR_POS = 0
                End If
            End If
            Call RenderMessage()
        End If
        If ss = MAP_SCENE Then
            If key = KEY_DOWN Then
                HERO_POSITION_X = 0
                HERO_POSITION_Y = -16
            End If
            If key = KEY_UP Then
                HERO_POSITION_X = 0
                HERO_POSITION_Y = 16
            End If
            If key = KEY_LEFT Then
                HERO_POSITION_X = 16
                HERO_POSITION_Y = 0
            End If
            If key = KEY_RIGHT Then
                HERO_POSITION_X = -16
                HERO_POSITION_Y = 0
            End If
            Dim bmp As Bitmap = New Bitmap(PictureBoxMap.Image)
            Dim g = Graphics.FromImage(bmp)
            g.DrawImage(bmp, HERO_POSITION_X, HERO_POSITION_Y)
            g.Dispose()
            PictureBoxMap.Image = bmp
            Dim r = Rnd() * 24
            If r < 2 Then
                SceneChange(BATTLE_SCENE)
            End If
        End If
    End Sub
    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        ClickButtons(KEY_DOWN, SCENE_STATE)
    End Sub

    Private Sub ButtonBattle_Click(sender As Object, e As EventArgs) Handles ButtonBattle.Click
        SceneChange(BATTLE_SCENE)
    End Sub

    Private Sub ButtonMap_Click(sender As Object, e As EventArgs) Handles ButtonMap.Click
        SceneChange(MAP_SCENE)
    End Sub

    Private Sub SceneChange(ByVal ss As Integer)
        SCENE_STATE = ss
        If SCENE_STATE = MAP_SCENE Then
            PictureBoxMap.Visible = True
            PictureBoxHero.Visible = True
            PictureBoxMonster.Visible = False
            RichTextBox1.Visible = False
        End If
        If SCENE_STATE = BATTLE_SCENE Then
            InitBattle()
            PictureBoxMap.Visible = False
            PictureBoxHero.Visible = False
            PictureBoxMonster.Visible = True
            RichTextBox1.Visible = True
        End If
    End Sub
End Class
