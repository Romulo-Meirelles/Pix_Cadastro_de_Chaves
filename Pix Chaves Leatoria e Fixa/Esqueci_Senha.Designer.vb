<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Esqueci_Senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Esqueci_Senha))
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Enviar_btn = New System.Windows.Forms.Button()
        Me.EMail_txb = New System.Windows.Forms.TextBox()
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.Trocar_btn = New System.Windows.Forms.Button()
        Me.Reenviar_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(349, 32)
        Me.Control_TaskBar_Top1.TabIndex = 15
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Esqueci a Senha!"
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'Enviar_btn
        '
        Me.Enviar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Enviar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Enviar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enviar_btn.FlatAppearance.BorderSize = 0
        Me.Enviar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Enviar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Enviar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enviar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enviar_btn.ForeColor = System.Drawing.Color.White
        Me.Enviar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.email_send_24px
        Me.Enviar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Enviar_btn.Location = New System.Drawing.Point(233, 158)
        Me.Enviar_btn.Name = "Enviar_btn"
        Me.Enviar_btn.Size = New System.Drawing.Size(81, 34)
        Me.Enviar_btn.TabIndex = 17
        Me.Enviar_btn.Text = "Enviar"
        Me.Enviar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Enviar_btn.UseVisualStyleBackColor = False
        '
        'EMail_txb
        '
        Me.EMail_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.EMail_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EMail_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMail_txb.ForeColor = System.Drawing.Color.White
        Me.EMail_txb.Location = New System.Drawing.Point(38, 80)
        Me.EMail_txb.MaxLength = 1000
        Me.EMail_txb.Name = "EMail_txb"
        Me.EMail_txb.Size = New System.Drawing.Size(273, 29)
        Me.EMail_txb.TabIndex = 16
        '
        'Email_lbl
        '
        Me.Email_lbl.ForeColor = System.Drawing.Color.White
        Me.Email_lbl.Location = New System.Drawing.Point(38, 35)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(273, 42)
        Me.Email_lbl.TabIndex = 18
        Me.Email_lbl.Text = "Insira seu e-mail cadastrado."
        Me.Email_lbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Trocar_btn
        '
        Me.Trocar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Trocar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Trocar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Trocar_btn.FlatAppearance.BorderSize = 0
        Me.Trocar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Trocar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Trocar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Trocar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trocar_btn.ForeColor = System.Drawing.Color.White
        Me.Trocar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Binary_Code_24px
        Me.Trocar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Trocar_btn.Location = New System.Drawing.Point(233, 158)
        Me.Trocar_btn.Name = "Trocar_btn"
        Me.Trocar_btn.Size = New System.Drawing.Size(81, 34)
        Me.Trocar_btn.TabIndex = 19
        Me.Trocar_btn.Text = "Trocar"
        Me.Trocar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Trocar_btn.UseVisualStyleBackColor = False
        Me.Trocar_btn.Visible = False
        '
        'Reenviar_btn
        '
        Me.Reenviar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reenviar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Reenviar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reenviar_btn.FlatAppearance.BorderSize = 0
        Me.Reenviar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Reenviar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Reenviar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reenviar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reenviar_btn.ForeColor = System.Drawing.Color.White
        Me.Reenviar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.email_send_24px
        Me.Reenviar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reenviar_btn.Location = New System.Drawing.Point(135, 158)
        Me.Reenviar_btn.Name = "Reenviar_btn"
        Me.Reenviar_btn.Size = New System.Drawing.Size(92, 34)
        Me.Reenviar_btn.TabIndex = 20
        Me.Reenviar_btn.Text = "Reenviar"
        Me.Reenviar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Reenviar_btn.UseVisualStyleBackColor = False
        Me.Reenviar_btn.Visible = False
        '
        'Esqueci_Senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 208)
        Me.Controls.Add(Me.Reenviar_btn)
        Me.Controls.Add(Me.Trocar_btn)
        Me.Controls.Add(Me.Enviar_btn)
        Me.Controls.Add(Me.EMail_txb)
        Me.Controls.Add(Me.Email_lbl)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Esqueci_Senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Enviar_btn As Button
    Friend WithEvents EMail_txb As TextBox
    Friend WithEvents Email_lbl As Label
    Friend WithEvents Trocar_btn As Button
    Friend WithEvents Reenviar_btn As Button
End Class
