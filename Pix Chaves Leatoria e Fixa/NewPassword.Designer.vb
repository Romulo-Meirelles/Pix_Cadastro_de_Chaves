<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassword
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPassword))
        Me.Concluir_btn = New System.Windows.Forms.Button()
        Me.Antigo_Password_txb = New System.Windows.Forms.TextBox()
        Me.Antigo_Password_lbl = New System.Windows.Forms.Label()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.ReescrevaPassword_txb = New System.Windows.Forms.TextBox()
        Me.Reescreva_lbl = New System.Windows.Forms.Label()
        Me.PopLabel_lbl = New System.Windows.Forms.Label()
        Me.Novo_Password_txb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Concluir_btn
        '
        Me.Concluir_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Concluir_btn.BackColor = System.Drawing.Color.Indigo
        Me.Concluir_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Concluir_btn.FlatAppearance.BorderSize = 0
        Me.Concluir_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Concluir_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Concluir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Concluir_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concluir_btn.ForeColor = System.Drawing.Color.White
        Me.Concluir_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.key_24px
        Me.Concluir_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Concluir_btn.Location = New System.Drawing.Point(220, 271)
        Me.Concluir_btn.Name = "Concluir_btn"
        Me.Concluir_btn.Size = New System.Drawing.Size(95, 34)
        Me.Concluir_btn.TabIndex = 3
        Me.Concluir_btn.Text = "Concluir"
        Me.Concluir_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Concluir_btn.UseVisualStyleBackColor = False
        '
        'Antigo_Password_txb
        '
        Me.Antigo_Password_txb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Antigo_Password_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Antigo_Password_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Antigo_Password_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Antigo_Password_txb.ForeColor = System.Drawing.Color.White
        Me.Antigo_Password_txb.Location = New System.Drawing.Point(37, 79)
        Me.Antigo_Password_txb.MaxLength = 60
        Me.Antigo_Password_txb.Name = "Antigo_Password_txb"
        Me.Antigo_Password_txb.Size = New System.Drawing.Size(278, 29)
        Me.Antigo_Password_txb.TabIndex = 0
        Me.Antigo_Password_txb.UseSystemPasswordChar = True
        '
        'Antigo_Password_lbl
        '
        Me.Antigo_Password_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Antigo_Password_lbl.AutoSize = True
        Me.Antigo_Password_lbl.ForeColor = System.Drawing.Color.White
        Me.Antigo_Password_lbl.Location = New System.Drawing.Point(34, 58)
        Me.Antigo_Password_lbl.Name = "Antigo_Password_lbl"
        Me.Antigo_Password_lbl.Size = New System.Drawing.Size(89, 13)
        Me.Antigo_Password_lbl.TabIndex = 20
        Me.Antigo_Password_lbl.Text = "Antigo Password:"
        '
        'Control_TaskBar_Top1
        '
        Me.Control_TaskBar_Top1.BalloonTipTime = 0
        Me.Control_TaskBar_Top1.BorderRadius = 0
        Me.Control_TaskBar_Top1.CloseEnable = True
        Me.Control_TaskBar_Top1.CloseToClose = ToolsBox.Control_TaskBar_Top.Closerme.MeClose
        Me.Control_TaskBar_Top1.ControlBoxEnable = False
        Me.Control_TaskBar_Top1.ControlColorButtonBorder = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Control_TaskBar_Top1.ControlColorButtonItem = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.ControlColorButtonOne = System.Drawing.Color.Transparent
        Me.Control_TaskBar_Top1.ControlColorButtonTwo = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Control_TaskBar_Top1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Control_TaskBar_Top1.HideEnable = False
        Me.Control_TaskBar_Top1.Icon = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_24x24
        Me.Control_TaskBar_Top1.IconEnable = True
        Me.Control_TaskBar_Top1.IconSize = ToolsBox.Control_TaskBar_Top.Modifier.Size_24X24
        Me.Control_TaskBar_Top1.Location = New System.Drawing.Point(0, 0)
        Me.Control_TaskBar_Top1.MaxEnable = False
        Me.Control_TaskBar_Top1.MiniEnable = False
        Me.Control_TaskBar_Top1.MouseStateRetangle = True
        Me.Control_TaskBar_Top1.Name = "Control_TaskBar_Top1"
        Me.Control_TaskBar_Top1.Notifyicon = True
        Me.Control_TaskBar_Top1.NotifyIconIcon = CType(resources.GetObject("Control_TaskBar_Top1.NotifyIconIcon"), System.Drawing.Icon)
        Me.Control_TaskBar_Top1.NotifyIconText = Nothing
        Me.Control_TaskBar_Top1.NotifyIconTitle = Nothing
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(350, 32)
        Me.Control_TaskBar_Top1.TabIndex = 19
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Troca de Password"
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'ReescrevaPassword_txb
        '
        Me.ReescrevaPassword_txb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReescrevaPassword_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ReescrevaPassword_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReescrevaPassword_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReescrevaPassword_txb.ForeColor = System.Drawing.Color.White
        Me.ReescrevaPassword_txb.Location = New System.Drawing.Point(37, 204)
        Me.ReescrevaPassword_txb.MaxLength = 60
        Me.ReescrevaPassword_txb.Name = "ReescrevaPassword_txb"
        Me.ReescrevaPassword_txb.Size = New System.Drawing.Size(278, 29)
        Me.ReescrevaPassword_txb.TabIndex = 2
        Me.ReescrevaPassword_txb.UseSystemPasswordChar = True
        '
        'Reescreva_lbl
        '
        Me.Reescreva_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reescreva_lbl.AutoSize = True
        Me.Reescreva_lbl.ForeColor = System.Drawing.Color.White
        Me.Reescreva_lbl.Location = New System.Drawing.Point(34, 184)
        Me.Reescreva_lbl.Name = "Reescreva_lbl"
        Me.Reescreva_lbl.Size = New System.Drawing.Size(147, 13)
        Me.Reescreva_lbl.TabIndex = 23
        Me.Reescreva_lbl.Text = "Reescreva o novo Password:"
        '
        'PopLabel_lbl
        '
        Me.PopLabel_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PopLabel_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopLabel_lbl.ForeColor = System.Drawing.Color.Red
        Me.PopLabel_lbl.Location = New System.Drawing.Point(37, 242)
        Me.PopLabel_lbl.Name = "PopLabel_lbl"
        Me.PopLabel_lbl.Size = New System.Drawing.Size(278, 13)
        Me.PopLabel_lbl.TabIndex = 25
        Me.PopLabel_lbl.Text = "Os Caracteres diferem!"
        Me.PopLabel_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PopLabel_lbl.Visible = False
        '
        'Novo_Password_txb
        '
        Me.Novo_Password_txb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Novo_Password_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Novo_Password_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Novo_Password_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Novo_Password_txb.ForeColor = System.Drawing.Color.White
        Me.Novo_Password_txb.Location = New System.Drawing.Point(37, 142)
        Me.Novo_Password_txb.MaxLength = 60
        Me.Novo_Password_txb.Name = "Novo_Password_txb"
        Me.Novo_Password_txb.Size = New System.Drawing.Size(278, 29)
        Me.Novo_Password_txb.TabIndex = 1
        Me.Novo_Password_txb.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Novo Password:"
        '
        'NewPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 330)
        Me.Controls.Add(Me.Novo_Password_txb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PopLabel_lbl)
        Me.Controls.Add(Me.ReescrevaPassword_txb)
        Me.Controls.Add(Me.Reescreva_lbl)
        Me.Controls.Add(Me.Concluir_btn)
        Me.Controls.Add(Me.Antigo_Password_txb)
        Me.Controls.Add(Me.Antigo_Password_lbl)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPassword"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Concluir_btn As Button
    Friend WithEvents Antigo_Password_txb As TextBox
    Friend WithEvents Antigo_Password_lbl As Label
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents ReescrevaPassword_txb As TextBox
    Friend WithEvents Reescreva_lbl As Label
    Friend WithEvents PopLabel_lbl As Label
    Friend WithEvents Novo_Password_txb As TextBox
    Friend WithEvents Label1 As Label
End Class
