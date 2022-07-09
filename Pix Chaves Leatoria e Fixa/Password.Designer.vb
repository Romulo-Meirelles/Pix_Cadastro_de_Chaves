<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password))
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.Password_txb = New System.Windows.Forms.TextBox()
        Me.Entrar_btn = New System.Windows.Forms.Button()
        Me.Esqueci_Senha_llb = New System.Windows.Forms.LinkLabel()
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(350, 32)
        Me.Control_TaskBar_Top1.TabIndex = 14
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Password."
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.ForeColor = System.Drawing.Color.White
        Me.Password_lbl.Location = New System.Drawing.Point(34, 71)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Password_lbl.TabIndex = 15
        Me.Password_lbl.Text = "Password:"
        '
        'Password_txb
        '
        Me.Password_txb.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Password_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password_txb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txb.ForeColor = System.Drawing.Color.White
        Me.Password_txb.Location = New System.Drawing.Point(37, 96)
        Me.Password_txb.MaxLength = 60
        Me.Password_txb.Name = "Password_txb"
        Me.Password_txb.Size = New System.Drawing.Size(273, 29)
        Me.Password_txb.TabIndex = 0
        Me.Password_txb.UseSystemPasswordChar = True
        '
        'Entrar_btn
        '
        Me.Entrar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Entrar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Entrar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Entrar_btn.FlatAppearance.BorderSize = 0
        Me.Entrar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Entrar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Entrar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entrar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entrar_btn.ForeColor = System.Drawing.Color.White
        Me.Entrar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.key_24px
        Me.Entrar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Entrar_btn.Location = New System.Drawing.Point(230, 174)
        Me.Entrar_btn.Name = "Entrar_btn"
        Me.Entrar_btn.Size = New System.Drawing.Size(80, 34)
        Me.Entrar_btn.TabIndex = 1
        Me.Entrar_btn.Text = "Entrar"
        Me.Entrar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Entrar_btn.UseVisualStyleBackColor = False
        '
        'Esqueci_Senha_llb
        '
        Me.Esqueci_Senha_llb.ActiveLinkColor = System.Drawing.Color.Blue
        Me.Esqueci_Senha_llb.AutoSize = True
        Me.Esqueci_Senha_llb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Esqueci_Senha_llb.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.Esqueci_Senha_llb.Location = New System.Drawing.Point(221, 131)
        Me.Esqueci_Senha_llb.Name = "Esqueci_Senha_llb"
        Me.Esqueci_Senha_llb.Size = New System.Drawing.Size(89, 13)
        Me.Esqueci_Senha_llb.TabIndex = 16
        Me.Esqueci_Senha_llb.TabStop = True
        Me.Esqueci_Senha_llb.Text = "Esqueci a senha!"
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.Esqueci_Senha_llb)
        Me.Controls.Add(Me.Entrar_btn)
        Me.Controls.Add(Me.Password_txb)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Password_lbl As Label
    Friend WithEvents Password_txb As TextBox
    Friend WithEvents Entrar_btn As Button
    Friend WithEvents Esqueci_Senha_llb As LinkLabel
End Class
