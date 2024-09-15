<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.ButtonL = New System.Windows.Forms.Button()
        Me.ButtonR = New System.Windows.Forms.Button()
        Me.ButtonU = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxMap = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMonster = New System.Windows.Forms.PictureBox()
        Me.ButtonBattle = New System.Windows.Forms.Button()
        Me.ButtonMap = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMonster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 381)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(552, 115)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(13, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(552, 121)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = ""
        '
        'ButtonL
        '
        Me.ButtonL.BackColor = System.Drawing.Color.Black
        Me.ButtonL.ForeColor = System.Drawing.Color.White
        Me.ButtonL.Location = New System.Drawing.Point(12, 32)
        Me.ButtonL.Name = "ButtonL"
        Me.ButtonL.Size = New System.Drawing.Size(30, 23)
        Me.ButtonL.TabIndex = 3
        Me.ButtonL.Text = "L"
        Me.ButtonL.UseVisualStyleBackColor = False
        '
        'ButtonR
        '
        Me.ButtonR.BackColor = System.Drawing.Color.Black
        Me.ButtonR.ForeColor = System.Drawing.Color.White
        Me.ButtonR.Location = New System.Drawing.Point(48, 32)
        Me.ButtonR.Name = "ButtonR"
        Me.ButtonR.Size = New System.Drawing.Size(30, 23)
        Me.ButtonR.TabIndex = 4
        Me.ButtonR.Text = "R"
        Me.ButtonR.UseVisualStyleBackColor = False
        '
        'ButtonU
        '
        Me.ButtonU.BackColor = System.Drawing.Color.Black
        Me.ButtonU.ForeColor = System.Drawing.Color.White
        Me.ButtonU.Location = New System.Drawing.Point(29, 3)
        Me.ButtonU.Name = "ButtonU"
        Me.ButtonU.Size = New System.Drawing.Size(30, 23)
        Me.ButtonU.TabIndex = 5
        Me.ButtonU.Text = "U"
        Me.ButtonU.UseVisualStyleBackColor = False
        '
        'ButtonD
        '
        Me.ButtonD.BackColor = System.Drawing.Color.Black
        Me.ButtonD.ForeColor = System.Drawing.Color.White
        Me.ButtonD.Location = New System.Drawing.Point(29, 61)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(30, 23)
        Me.ButtonD.TabIndex = 6
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = False
        '
        'ButtonB
        '
        Me.ButtonB.BackColor = System.Drawing.Color.Black
        Me.ButtonB.ForeColor = System.Drawing.Color.White
        Me.ButtonB.Location = New System.Drawing.Point(90, 61)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(30, 23)
        Me.ButtonB.TabIndex = 7
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = False
        '
        'ButtonA
        '
        Me.ButtonA.BackColor = System.Drawing.Color.Black
        Me.ButtonA.ForeColor = System.Drawing.Color.White
        Me.ButtonA.Location = New System.Drawing.Point(128, 61)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(30, 23)
        Me.ButtonA.TabIndex = 8
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonA)
        Me.Panel1.Controls.Add(Me.ButtonU)
        Me.Panel1.Controls.Add(Me.ButtonB)
        Me.Panel1.Controls.Add(Me.ButtonR)
        Me.Panel1.Controls.Add(Me.ButtonD)
        Me.Panel1.Controls.Add(Me.ButtonL)
        Me.Panel1.Location = New System.Drawing.Point(580, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 111)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kyosuke Miyazawa 2024"
        '
        'PictureBoxMap
        '
        Me.PictureBoxMap.Image = Global.DragonQuest.My.Resources.Resources.地図
        Me.PictureBoxMap.Location = New System.Drawing.Point(6, 6)
        Me.PictureBoxMap.Name = "PictureBoxMap"
        Me.PictureBoxMap.Size = New System.Drawing.Size(568, 494)
        Me.PictureBoxMap.TabIndex = 10
        Me.PictureBoxMap.TabStop = False
        Me.PictureBoxMap.Visible = False
        '
        'PictureBoxMonster
        '
        Me.PictureBoxMonster.Image = Global.DragonQuest.My.Resources.Resources.スライム
        Me.PictureBoxMonster.Location = New System.Drawing.Point(161, 139)
        Me.PictureBoxMonster.Name = "PictureBoxMonster"
        Me.PictureBoxMonster.Size = New System.Drawing.Size(233, 236)
        Me.PictureBoxMonster.TabIndex = 0
        Me.PictureBoxMonster.TabStop = False
        '
        'ButtonBattle
        '
        Me.ButtonBattle.Location = New System.Drawing.Point(585, 283)
        Me.ButtonBattle.Name = "ButtonBattle"
        Me.ButtonBattle.Size = New System.Drawing.Size(152, 27)
        Me.ButtonBattle.TabIndex = 11
        Me.ButtonBattle.Text = "Battle"
        Me.ButtonBattle.UseVisualStyleBackColor = True
        '
        'ButtonMap
        '
        Me.ButtonMap.Location = New System.Drawing.Point(585, 316)
        Me.ButtonMap.Name = "ButtonMap"
        Me.ButtonMap.Size = New System.Drawing.Size(152, 27)
        Me.ButtonMap.TabIndex = 12
        Me.ButtonMap.Text = "Map"
        Me.ButtonMap.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(753, 512)
        Me.Controls.Add(Me.ButtonMap)
        Me.Controls.Add(Me.ButtonBattle)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBoxMonster)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxMap)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMonster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxMonster As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents ButtonL As Button
    Friend WithEvents ButtonR As Button
    Friend WithEvents ButtonU As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents ButtonB As Button
    Friend WithEvents ButtonA As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxMap As PictureBox
    Friend WithEvents ButtonBattle As Button
    Friend WithEvents ButtonMap As Button
End Class
