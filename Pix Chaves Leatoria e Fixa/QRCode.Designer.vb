<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QRCode))
        Me.QR_Code_Pic = New System.Windows.Forms.PictureBox()
        Me.Chave_lbl = New System.Windows.Forms.Label()
        Me.Copiar_Code_btn = New System.Windows.Forms.Button()
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.Mensagem_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        CType(Me.QR_Code_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QR_Code_Pic
        '
        Me.QR_Code_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QR_Code_Pic.Location = New System.Drawing.Point(171, 49)
        Me.QR_Code_Pic.Name = "QR_Code_Pic"
        Me.QR_Code_Pic.Size = New System.Drawing.Size(238, 238)
        Me.QR_Code_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_Code_Pic.TabIndex = 9
        Me.QR_Code_Pic.TabStop = False
        '
        'Chave_lbl
        '
        Me.Chave_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chave_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Chave_lbl.Location = New System.Drawing.Point(12, 298)
        Me.Chave_lbl.Name = "Chave_lbl"
        Me.Chave_lbl.Size = New System.Drawing.Size(556, 122)
        Me.Chave_lbl.TabIndex = 10
        Me.Chave_lbl.Text = "Chave PIX: (54) 65454-6545" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valor: R$ 5,60" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nome:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cidade:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Código QrCode: 000201" & _
    "26330014BR.GOV.BCB.PIX01115465454654552040000530398654045.605802BR5901 6001 6207" & _
    "0503***63046BDB"
        Me.Chave_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Copiar_Code_btn
        '
        Me.Copiar_Code_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Copiar_Code_btn.BackColor = System.Drawing.Color.Indigo
        Me.Copiar_Code_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Copiar_Code_btn.FlatAppearance.BorderSize = 0
        Me.Copiar_Code_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Copiar_Code_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Copiar_Code_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Copiar_Code_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copiar_Code_btn.ForeColor = System.Drawing.Color.White
        Me.Copiar_Code_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.qr_code_24px
        Me.Copiar_Code_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Copiar_Code_btn.Location = New System.Drawing.Point(448, 428)
        Me.Copiar_Code_btn.Name = "Copiar_Code_btn"
        Me.Copiar_Code_btn.Size = New System.Drawing.Size(125, 34)
        Me.Copiar_Code_btn.TabIndex = 11
        Me.Copiar_Code_btn.Text = "Copiar Chave"
        Me.Copiar_Code_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Copiar_Code_btn.UseVisualStyleBackColor = False
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.LimeGreen
        Me.Mensagem_lbl.Location = New System.Drawing.Point(15, 430)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(427, 32)
        Me.Mensagem_lbl.TabIndex = 12
        Me.Mensagem_lbl.Text = "Chave copiada com sucesso!"
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mensagem_lbl.Visible = False
        '
        'Mensagem_Timer
        '
        Me.Mensagem_Timer.Interval = 3000
        '
        'Control_TaskBar_Top1
        '
        Me.Control_TaskBar_Top1.BorderRadius = 0
        Me.Control_TaskBar_Top1.CloseEnable = True
        Me.Control_TaskBar_Top1.CloseToClose = ToolsBox.Control_TaskBar_Top.Closerme.MeClose
        Me.Control_TaskBar_Top1.ControlBoxEnable = False
        Me.Control_TaskBar_Top1.ControlColorButtonBorder = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Control_TaskBar_Top1.ControlColorButtonItem = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.ControlColorButtonOne = System.Drawing.Color.Transparent
        Me.Control_TaskBar_Top1.ControlColorButtonTwo = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Control_TaskBar_Top1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Control_TaskBar_Top1.Icon = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_24x24
        Me.Control_TaskBar_Top1.IconEnable = True
        Me.Control_TaskBar_Top1.IconSize = ToolsBox.Control_TaskBar_Top.Modifier.Size_24X24
        Me.Control_TaskBar_Top1.Location = New System.Drawing.Point(0, 0)
        Me.Control_TaskBar_Top1.MaxEnable = False
        Me.Control_TaskBar_Top1.MiniEnable = False
        Me.Control_TaskBar_Top1.Name = "Control_TaskBar_Top1"
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(580, 32)
        Me.Control_TaskBar_Top1.TabIndex = 26
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "QRCode Gerado com sucesso!"
        '
        'QRCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.Controls.Add(Me.Mensagem_lbl)
        Me.Controls.Add(Me.Copiar_Code_btn)
        Me.Controls.Add(Me.Chave_lbl)
        Me.Controls.Add(Me.QR_Code_Pic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QRCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QRCode"
        Me.TopMost = True
        CType(Me.QR_Code_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QR_Code_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Chave_lbl As System.Windows.Forms.Label
    Friend WithEvents Copiar_Code_btn As System.Windows.Forms.Button
    Friend WithEvents Mensagem_lbl As System.Windows.Forms.Label
    Friend WithEvents Mensagem_Timer As System.Windows.Forms.Timer
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
End Class
