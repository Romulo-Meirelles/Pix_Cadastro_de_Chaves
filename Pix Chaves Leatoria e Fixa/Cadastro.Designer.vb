<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.PopLabel_lbl = New System.Windows.Forms.Label()
        Me.RescrevaPassword_txb = New System.Windows.Forms.TextBox()
        Me.Reescreva_lbl = New System.Windows.Forms.Label()
        Me.Concluir_btn = New System.Windows.Forms.Button()
        Me.Novo_Password_txb = New System.Windows.Forms.TextBox()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Email_txb = New System.Windows.Forms.TextBox()
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.Sem_Senha_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PopLabel_lbl
        '
        Me.PopLabel_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PopLabel_lbl.ForeColor = System.Drawing.Color.Red
        Me.PopLabel_lbl.Location = New System.Drawing.Point(37, 242)
        Me.PopLabel_lbl.Name = "PopLabel_lbl"
        Me.PopLabel_lbl.Size = New System.Drawing.Size(278, 13)
        Me.PopLabel_lbl.TabIndex = 32
        Me.PopLabel_lbl.Text = "Os Caracteres diferem!"
        Me.PopLabel_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PopLabel_lbl.Visible = False
        '
        'RescrevaPassword_txb
        '
        Me.RescrevaPassword_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.RescrevaPassword_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RescrevaPassword_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RescrevaPassword_txb.ForeColor = System.Drawing.Color.White
        Me.RescrevaPassword_txb.Location = New System.Drawing.Point(37, 139)
        Me.RescrevaPassword_txb.MaxLength = 60
        Me.RescrevaPassword_txb.Name = "RescrevaPassword_txb"
        Me.RescrevaPassword_txb.Size = New System.Drawing.Size(278, 29)
        Me.RescrevaPassword_txb.TabIndex = 1
        Me.RescrevaPassword_txb.UseSystemPasswordChar = True
        '
        'Reescreva_lbl
        '
        Me.Reescreva_lbl.AutoSize = True
        Me.Reescreva_lbl.ForeColor = System.Drawing.Color.White
        Me.Reescreva_lbl.Location = New System.Drawing.Point(34, 119)
        Me.Reescreva_lbl.Name = "Reescreva_lbl"
        Me.Reescreva_lbl.Size = New System.Drawing.Size(147, 13)
        Me.Reescreva_lbl.TabIndex = 30
        Me.Reescreva_lbl.Text = "Reescreva o novo Password:"
        '
        'Concluir_btn
        '
        Me.Concluir_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Concluir_btn.Location = New System.Drawing.Point(218, 271)
        Me.Concluir_btn.Name = "Concluir_btn"
        Me.Concluir_btn.Size = New System.Drawing.Size(95, 34)
        Me.Concluir_btn.TabIndex = 3
        Me.Concluir_btn.Text = "Concluir"
        Me.Concluir_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Concluir_btn.UseVisualStyleBackColor = False
        '
        'Novo_Password_txb
        '
        Me.Novo_Password_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Novo_Password_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Novo_Password_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Novo_Password_txb.ForeColor = System.Drawing.Color.White
        Me.Novo_Password_txb.Location = New System.Drawing.Point(37, 73)
        Me.Novo_Password_txb.MaxLength = 60
        Me.Novo_Password_txb.Name = "Novo_Password_txb"
        Me.Novo_Password_txb.Size = New System.Drawing.Size(278, 29)
        Me.Novo_Password_txb.TabIndex = 0
        Me.Novo_Password_txb.UseSystemPasswordChar = True
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.ForeColor = System.Drawing.Color.White
        Me.Password_lbl.Location = New System.Drawing.Point(34, 52)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(85, 13)
        Me.Password_lbl.TabIndex = 27
        Me.Password_lbl.Text = "Novo Password:"
        '
        'Control_TaskBar_Top1
        '
        Me.Control_TaskBar_Top1.BalloonTipTime = 0
        Me.Control_TaskBar_Top1.BorderRadius = 0
        Me.Control_TaskBar_Top1.CloseEnable = True
        Me.Control_TaskBar_Top1.CloseToClose = ToolsBox.Control_TaskBar_Top.Closerme.MeExit
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
        Me.Control_TaskBar_Top1.TabIndex = 26
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Novo Cadastro."
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'Email_txb
        '
        Me.Email_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Email_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_txb.ForeColor = System.Drawing.Color.White
        Me.Email_txb.Location = New System.Drawing.Point(37, 203)
        Me.Email_txb.MaxLength = 60
        Me.Email_txb.Name = "Email_txb"
        Me.Email_txb.Size = New System.Drawing.Size(278, 29)
        Me.Email_txb.TabIndex = 2
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.ForeColor = System.Drawing.Color.White
        Me.Email_lbl.Location = New System.Drawing.Point(34, 187)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Email_lbl.TabIndex = 33
        Me.Email_lbl.Text = "E-Mail:"
        '
        'Sem_Senha_btn
        '
        Me.Sem_Senha_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sem_Senha_btn.BackColor = System.Drawing.Color.Indigo
        Me.Sem_Senha_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sem_Senha_btn.FlatAppearance.BorderSize = 0
        Me.Sem_Senha_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Sem_Senha_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sem_Senha_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sem_Senha_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sem_Senha_btn.ForeColor = System.Drawing.Color.White
        Me.Sem_Senha_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Sem_Senha_btn.Location = New System.Drawing.Point(117, 271)
        Me.Sem_Senha_btn.Name = "Sem_Senha_btn"
        Me.Sem_Senha_btn.Size = New System.Drawing.Size(95, 34)
        Me.Sem_Senha_btn.TabIndex = 34
        Me.Sem_Senha_btn.Text = "Sem Senha"
        Me.Sem_Senha_btn.UseVisualStyleBackColor = False
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 330)
        Me.Controls.Add(Me.Sem_Senha_btn)
        Me.Controls.Add(Me.Email_txb)
        Me.Controls.Add(Me.Email_lbl)
        Me.Controls.Add(Me.PopLabel_lbl)
        Me.Controls.Add(Me.RescrevaPassword_txb)
        Me.Controls.Add(Me.Reescreva_lbl)
        Me.Controls.Add(Me.Concluir_btn)
        Me.Controls.Add(Me.Novo_Password_txb)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PopLabel_lbl As Label
    Friend WithEvents RescrevaPassword_txb As TextBox
    Friend WithEvents Reescreva_lbl As Label
    Friend WithEvents Concluir_btn As Button
    Friend WithEvents Novo_Password_txb As TextBox
    Friend WithEvents Password_lbl As Label
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Email_txb As TextBox
    Friend WithEvents Email_lbl As Label
    Friend WithEvents Sem_Senha_btn As Button
End Class
