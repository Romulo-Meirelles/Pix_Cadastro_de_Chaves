<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagamento))
        Me.Gerar_QRCode_btn = New System.Windows.Forms.Button()
        Me.Tipo_Chave_CBX = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nome_txb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cidade_txb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Valor_txb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Codigo_txb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChavePix_txb = New System.Windows.Forms.TextBox()
        Me.Mensagem_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ServProd_txb = New System.Windows.Forms.TextBox()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.SuspendLayout()
        '
        'Gerar_QRCode_btn
        '
        Me.Gerar_QRCode_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gerar_QRCode_btn.BackColor = System.Drawing.Color.Indigo
        Me.Gerar_QRCode_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Gerar_QRCode_btn.FlatAppearance.BorderSize = 0
        Me.Gerar_QRCode_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Gerar_QRCode_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gerar_QRCode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gerar_QRCode_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gerar_QRCode_btn.ForeColor = System.Drawing.Color.White
        Me.Gerar_QRCode_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.qr_code_24px
        Me.Gerar_QRCode_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Gerar_QRCode_btn.Location = New System.Drawing.Point(313, 355)
        Me.Gerar_QRCode_btn.Name = "Gerar_QRCode_btn"
        Me.Gerar_QRCode_btn.Size = New System.Drawing.Size(125, 34)
        Me.Gerar_QRCode_btn.TabIndex = 8
        Me.Gerar_QRCode_btn.Text = "Gerar QRCode"
        Me.Gerar_QRCode_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Gerar_QRCode_btn.UseVisualStyleBackColor = False
        '
        'Tipo_Chave_CBX
        '
        Me.Tipo_Chave_CBX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tipo_Chave_CBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_Chave_CBX.FormattingEnabled = True
        Me.Tipo_Chave_CBX.Items.AddRange(New Object() {"Telefone", "Email", "CPF", "CNPJ", "Outros"})
        Me.Tipo_Chave_CBX.Location = New System.Drawing.Point(25, 57)
        Me.Tipo_Chave_CBX.Name = "Tipo_Chave_CBX"
        Me.Tipo_Chave_CBX.Size = New System.Drawing.Size(224, 21)
        Me.Tipo_Chave_CBX.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Informe o tipo da chave:"
        '
        'Nome_txb
        '
        Me.Nome_txb.Location = New System.Drawing.Point(25, 151)
        Me.Nome_txb.MaxLength = 25
        Me.Nome_txb.Name = "Nome_txb"
        Me.Nome_txb.Size = New System.Drawing.Size(172, 20)
        Me.Nome_txb.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nome do beneficiário. (25 Letras):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(22, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cidade do beneficiário ou da transação (até 15 letras):"
        '
        'Cidade_txb
        '
        Me.Cidade_txb.Location = New System.Drawing.Point(25, 243)
        Me.Cidade_txb.MaxLength = 15
        Me.Cidade_txb.Name = "Cidade_txb"
        Me.Cidade_txb.Size = New System.Drawing.Size(259, 20)
        Me.Cidade_txb.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Valor para transferência (Opcional):"
        '
        'Valor_txb
        '
        Me.Valor_txb.Location = New System.Drawing.Point(25, 290)
        Me.Valor_txb.MaxLength = 15
        Me.Valor_txb.Name = "Valor_txb"
        Me.Valor_txb.Size = New System.Drawing.Size(136, 20)
        Me.Valor_txb.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Código da transferência - (Letras e/ou Números) (Opcional):"
        '
        'Codigo_txb
        '
        Me.Codigo_txb.Location = New System.Drawing.Point(25, 339)
        Me.Codigo_txb.MaxLength = 20
        Me.Codigo_txb.Name = "Codigo_txb"
        Me.Codigo_txb.Size = New System.Drawing.Size(136, 20)
        Me.Codigo_txb.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Chave Pix:"
        '
        'ChavePix_txb
        '
        Me.ChavePix_txb.Location = New System.Drawing.Point(25, 104)
        Me.ChavePix_txb.MaxLength = 59
        Me.ChavePix_txb.Name = "ChavePix_txb"
        Me.ChavePix_txb.Size = New System.Drawing.Size(172, 20)
        Me.ChavePix_txb.TabIndex = 19
        '
        'Mensagem_Timer
        '
        Me.Mensagem_Timer.Interval = 3000
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.Red
        Me.Mensagem_lbl.Location = New System.Drawing.Point(22, 365)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(262, 23)
        Me.Mensagem_lbl.TabIndex = 21
        Me.Mensagem_lbl.Text = "Mensagem:"
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mensagem_lbl.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(22, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Serviços ou Produtos Nomes. (25 Letras):"
        '
        'ServProd_txb
        '
        Me.ServProd_txb.Location = New System.Drawing.Point(25, 197)
        Me.ServProd_txb.MaxLength = 25
        Me.ServProd_txb.Name = "ServProd_txb"
        Me.ServProd_txb.Size = New System.Drawing.Size(172, 20)
        Me.ServProd_txb.TabIndex = 22
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(450, 32)
        Me.Control_TaskBar_Top1.TabIndex = 25
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Histórico - QRCode Pix Gerados."
        '
        'Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ServProd_txb)
        Me.Controls.Add(Me.Mensagem_lbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChavePix_txb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Codigo_txb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Valor_txb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cidade_txb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nome_txb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tipo_Chave_CBX)
        Me.Controls.Add(Me.Gerar_QRCode_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerar QRCode"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerar_QRCode_btn As System.Windows.Forms.Button
    Friend WithEvents Tipo_Chave_CBX As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nome_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cidade_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Valor_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Codigo_txb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChavePix_txb As System.Windows.Forms.TextBox
    Protected WithEvents Mensagem_Timer As System.Windows.Forms.Timer
    Friend WithEvents Mensagem_lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ServProd_txb As System.Windows.Forms.TextBox
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
End Class
