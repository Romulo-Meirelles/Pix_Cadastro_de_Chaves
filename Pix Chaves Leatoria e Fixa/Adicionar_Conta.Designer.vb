<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adicionar_Conta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adicionar_Conta))
        Me.Banco_Cbx = New System.Windows.Forms.ComboBox()
        Me.Chave_Pix_txt = New System.Windows.Forms.TextBox()
        Me.Banco_lbl = New System.Windows.Forms.Label()
        Me.Chave_Pix_lbl = New System.Windows.Forms.Label()
        Me.Banco_Pic = New System.Windows.Forms.PictureBox()
        Me.Adicionar_btn = New System.Windows.Forms.Button()
        Me.Bancos_Images = New System.Windows.Forms.ImageList(Me.components)
        Me.Nome_lbl = New System.Windows.Forms.Label()
        Me.Nome_txb = New System.Windows.Forms.TextBox()
        Me.Procurar_lbl = New System.Windows.Forms.Label()
        Me.Procurar_txb = New System.Windows.Forms.TextBox()
        Me.Chave_Tipo_Cbx = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.GroupBox_Transparent1 = New ToolsBox.GroupBox_Transparent()
        Me.Tipo_Conta_cbx = New System.Windows.Forms.ComboBox()
        Me.Tipo_Conta_lbl = New System.Windows.Forms.Label()
        Me.Operacao_lbl = New System.Windows.Forms.Label()
        Me.Operacao_txt = New System.Windows.Forms.TextBox()
        Me.Conta_lbl = New System.Windows.Forms.Label()
        Me.Conta_txt = New System.Windows.Forms.TextBox()
        Me.Agencia_lbl = New System.Windows.Forms.Label()
        Me.Agencia_txt = New System.Windows.Forms.TextBox()
        Me.Codigo_Conta_lbl = New System.Windows.Forms.Label()
        Me.Codigo_Banco_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Add_Bancos_btn = New System.Windows.Forms.Button()
        Me.Editar_Conta_btn = New System.Windows.Forms.Button()
        CType(Me.Banco_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Transparent1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Banco_Cbx
        '
        Me.Banco_Cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Banco_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Banco_Cbx.Location = New System.Drawing.Point(40, 65)
        Me.Banco_Cbx.Name = "Banco_Cbx"
        Me.Banco_Cbx.Size = New System.Drawing.Size(185, 21)
        Me.Banco_Cbx.Sorted = True
        Me.Banco_Cbx.TabIndex = 0
        '
        'Chave_Pix_txt
        '
        Me.Chave_Pix_txt.Location = New System.Drawing.Point(40, 198)
        Me.Chave_Pix_txt.Name = "Chave_Pix_txt"
        Me.Chave_Pix_txt.Size = New System.Drawing.Size(185, 20)
        Me.Chave_Pix_txt.TabIndex = 1
        '
        'Banco_lbl
        '
        Me.Banco_lbl.AutoSize = True
        Me.Banco_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banco_lbl.ForeColor = System.Drawing.Color.White
        Me.Banco_lbl.Location = New System.Drawing.Point(37, 46)
        Me.Banco_lbl.Name = "Banco_lbl"
        Me.Banco_lbl.Size = New System.Drawing.Size(53, 15)
        Me.Banco_lbl.TabIndex = 2
        Me.Banco_lbl.Text = "Bancos:"
        '
        'Chave_Pix_lbl
        '
        Me.Chave_Pix_lbl.AutoSize = True
        Me.Chave_Pix_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chave_Pix_lbl.ForeColor = System.Drawing.Color.White
        Me.Chave_Pix_lbl.Location = New System.Drawing.Point(37, 180)
        Me.Chave_Pix_lbl.Name = "Chave_Pix_lbl"
        Me.Chave_Pix_lbl.Size = New System.Drawing.Size(70, 15)
        Me.Chave_Pix_lbl.TabIndex = 3
        Me.Chave_Pix_lbl.Text = "Chave Pix:"
        '
        'Banco_Pic
        '
        Me.Banco_Pic.Location = New System.Drawing.Point(271, 108)
        Me.Banco_Pic.Name = "Banco_Pic"
        Me.Banco_Pic.Size = New System.Drawing.Size(74, 74)
        Me.Banco_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Banco_Pic.TabIndex = 4
        Me.Banco_Pic.TabStop = False
        '
        'Adicionar_btn
        '
        Me.Adicionar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Adicionar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Adicionar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adicionar_btn.FlatAppearance.BorderSize = 0
        Me.Adicionar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Adicionar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Adicionar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adicionar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adicionar_btn.ForeColor = System.Drawing.Color.White
        Me.Adicionar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.add_key_24px
        Me.Adicionar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adicionar_btn.Location = New System.Drawing.Point(379, 427)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(125, 34)
        Me.Adicionar_btn.TabIndex = 5
        Me.Adicionar_btn.Text = "Add Pix Conta"
        Me.Adicionar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adicionar_btn.UseVisualStyleBackColor = False
        '
        'Bancos_Images
        '
        Me.Bancos_Images.ImageStream = CType(resources.GetObject("Bancos_Images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Bancos_Images.TransparentColor = System.Drawing.Color.Transparent
        Me.Bancos_Images.Images.SetKeyName(0, "Bradesco")
        Me.Bancos_Images.Images.SetKeyName(1, "Santander")
        Me.Bancos_Images.Images.SetKeyName(2, "Itau")
        Me.Bancos_Images.Images.SetKeyName(3, "HSBC")
        Me.Bancos_Images.Images.SetKeyName(4, "Caixa Econômica")
        Me.Bancos_Images.Images.SetKeyName(5, "Banco do Brasil")
        Me.Bancos_Images.Images.SetKeyName(6, "Original")
        Me.Bancos_Images.Images.SetKeyName(7, "Nubank")
        Me.Bancos_Images.Images.SetKeyName(8, "Inter")
        Me.Bancos_Images.Images.SetKeyName(9, "C6")
        Me.Bancos_Images.Images.SetKeyName(10, "Neon")
        Me.Bancos_Images.Images.SetKeyName(11, "BS2")
        Me.Bancos_Images.Images.SetKeyName(12, "PagBank")
        Me.Bancos_Images.Images.SetKeyName(13, "Next")
        Me.Bancos_Images.Images.SetKeyName(14, "PicPay")
        Me.Bancos_Images.Images.SetKeyName(15, "Mercado Pago")
        Me.Bancos_Images.Images.SetKeyName(16, "Recarga Pay")
        Me.Bancos_Images.Images.SetKeyName(17, "AgiBank")
        Me.Bancos_Images.Images.SetKeyName(18, "Alter")
        Me.Bancos_Images.Images.SetKeyName(19, "Banco da Amazônia")
        Me.Bancos_Images.Images.SetKeyName(20, "Banco de Brasilia")
        Me.Bancos_Images.Images.SetKeyName(21, "Banco do Nordeste")
        Me.Bancos_Images.Images.SetKeyName(22, "Banrisul")
        Me.Bancos_Images.Images.SetKeyName(23, "Benestes")
        Me.Bancos_Images.Images.SetKeyName(24, "BTG Pactual")
        Me.Bancos_Images.Images.SetKeyName(25, "CitiBank")
        Me.Bancos_Images.Images.SetKeyName(26, "Digio")
        Me.Bancos_Images.Images.SetKeyName(27, "Iti")
        Me.Bancos_Images.Images.SetKeyName(28, "Modal Mais")
        Me.Bancos_Images.Images.SetKeyName(29, "Pag!")
        Me.Bancos_Images.Images.SetKeyName(30, "PAN")
        Me.Bancos_Images.Images.SetKeyName(31, "Safra")
        Me.Bancos_Images.Images.SetKeyName(32, "Sicoob")
        Me.Bancos_Images.Images.SetKeyName(33, "Sicredi")
        Me.Bancos_Images.Images.SetKeyName(34, "Sofisa")
        Me.Bancos_Images.Images.SetKeyName(35, "Super Digital")
        Me.Bancos_Images.Images.SetKeyName(36, "UnoBank")
        Me.Bancos_Images.Images.SetKeyName(37, "Mercado Bitcoin")
        Me.Bancos_Images.Images.SetKeyName(38, "AcessoBank")
        Me.Bancos_Images.Images.SetKeyName(39, "Banco BMG")
        Me.Bancos_Images.Images.SetKeyName(40, "Banco BV")
        Me.Bancos_Images.Images.SetKeyName(41, "Banco Digimais")
        Me.Bancos_Images.Images.SetKeyName(42, "Banese")
        Me.Bancos_Images.Images.SetKeyName(43, "Banestes")
        Me.Bancos_Images.Images.SetKeyName(44, "Banpará")
        Me.Bancos_Images.Images.SetKeyName(45, "BanQi")
        Me.Bancos_Images.Images.SetKeyName(46, "Claro Pay")
        Me.Bancos_Images.Images.SetKeyName(47, "Cora Pagamentos")
        Me.Bancos_Images.Images.SetKeyName(48, "MeuBank")
        Me.Bancos_Images.Images.SetKeyName(49, "Sansung Pay")
        Me.Bancos_Images.Images.SetKeyName(50, "Stone")
        Me.Bancos_Images.Images.SetKeyName(51, "Topazio")
        Me.Bancos_Images.Images.SetKeyName(52, "Vivo Pay")
        Me.Bancos_Images.Images.SetKeyName(53, "Ausente")
        '
        'Nome_lbl
        '
        Me.Nome_lbl.AutoSize = True
        Me.Nome_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_lbl.ForeColor = System.Drawing.Color.White
        Me.Nome_lbl.Location = New System.Drawing.Point(37, 91)
        Me.Nome_lbl.Name = "Nome_lbl"
        Me.Nome_lbl.Size = New System.Drawing.Size(85, 15)
        Me.Nome_lbl.TabIndex = 8
        Me.Nome_lbl.Text = "Nome Titular:"
        '
        'Nome_txb
        '
        Me.Nome_txb.Location = New System.Drawing.Point(40, 110)
        Me.Nome_txb.Name = "Nome_txb"
        Me.Nome_txb.Size = New System.Drawing.Size(185, 20)
        Me.Nome_txb.TabIndex = 7
        '
        'Procurar_lbl
        '
        Me.Procurar_lbl.AutoSize = True
        Me.Procurar_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Procurar_lbl.ForeColor = System.Drawing.Color.White
        Me.Procurar_lbl.Location = New System.Drawing.Point(239, 46)
        Me.Procurar_lbl.Name = "Procurar_lbl"
        Me.Procurar_lbl.Size = New System.Drawing.Size(100, 15)
        Me.Procurar_lbl.TabIndex = 10
        Me.Procurar_lbl.Text = "Procurar Banco:"
        '
        'Procurar_txb
        '
        Me.Procurar_txb.Location = New System.Drawing.Point(242, 65)
        Me.Procurar_txb.Name = "Procurar_txb"
        Me.Procurar_txb.Size = New System.Drawing.Size(142, 20)
        Me.Procurar_txb.TabIndex = 9
        '
        'Chave_Tipo_Cbx
        '
        Me.Chave_Tipo_Cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chave_Tipo_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Chave_Tipo_Cbx.FormattingEnabled = True
        Me.Chave_Tipo_Cbx.Items.AddRange(New Object() {"Telefone", "Email", "CPF", "CNPJ", "Outros"})
        Me.Chave_Tipo_Cbx.Location = New System.Drawing.Point(40, 154)
        Me.Chave_Tipo_Cbx.Name = "Chave_Tipo_Cbx"
        Me.Chave_Tipo_Cbx.Size = New System.Drawing.Size(140, 21)
        Me.Chave_Tipo_Cbx.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo Chave:"
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(517, 32)
        Me.Control_TaskBar_Top1.TabIndex = 13
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Adicionar Chaves."
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'GroupBox_Transparent1
        '
        Me.GroupBox_Transparent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox_Transparent1.BorderColor = System.Drawing.Color.White
        Me.GroupBox_Transparent1.Controls.Add(Me.Tipo_Conta_cbx)
        Me.GroupBox_Transparent1.Controls.Add(Me.Tipo_Conta_lbl)
        Me.GroupBox_Transparent1.Controls.Add(Me.Operacao_lbl)
        Me.GroupBox_Transparent1.Controls.Add(Me.Operacao_txt)
        Me.GroupBox_Transparent1.Controls.Add(Me.Conta_lbl)
        Me.GroupBox_Transparent1.Controls.Add(Me.Conta_txt)
        Me.GroupBox_Transparent1.Controls.Add(Me.Agencia_lbl)
        Me.GroupBox_Transparent1.Controls.Add(Me.Agencia_txt)
        Me.GroupBox_Transparent1.Controls.Add(Me.Codigo_Conta_lbl)
        Me.GroupBox_Transparent1.Controls.Add(Me.Codigo_Banco_txt)
        Me.GroupBox_Transparent1.Location = New System.Drawing.Point(26, 233)
        Me.GroupBox_Transparent1.Name = "GroupBox_Transparent1"
        Me.GroupBox_Transparent1.Opacity = 50
        Me.GroupBox_Transparent1.Size = New System.Drawing.Size(315, 228)
        Me.GroupBox_Transparent1.TabIndex = 16
        Me.GroupBox_Transparent1.TabStop = False
        Me.GroupBox_Transparent1.Text = "Opcional"
        Me.GroupBox_Transparent1.TextColor = System.Drawing.Color.White
        '
        'Tipo_Conta_cbx
        '
        Me.Tipo_Conta_cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tipo_Conta_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_Conta_cbx.Items.AddRange(New Object() {"Conta Corrente", "Conta Exterior", "Conta Investimento", "Conta Poupança", "Corretora", "Plataforma Pagamento"})
        Me.Tipo_Conta_cbx.Location = New System.Drawing.Point(174, 39)
        Me.Tipo_Conta_cbx.Name = "Tipo_Conta_cbx"
        Me.Tipo_Conta_cbx.Size = New System.Drawing.Size(120, 21)
        Me.Tipo_Conta_cbx.Sorted = True
        Me.Tipo_Conta_cbx.TabIndex = 14
        '
        'Tipo_Conta_lbl
        '
        Me.Tipo_Conta_lbl.AutoSize = True
        Me.Tipo_Conta_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Tipo_Conta_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_Conta_lbl.ForeColor = System.Drawing.Color.White
        Me.Tipo_Conta_lbl.Location = New System.Drawing.Point(171, 21)
        Me.Tipo_Conta_lbl.Name = "Tipo_Conta_lbl"
        Me.Tipo_Conta_lbl.Size = New System.Drawing.Size(92, 15)
        Me.Tipo_Conta_lbl.TabIndex = 13
        Me.Tipo_Conta_lbl.Text = "Tipo de Conta:"
        '
        'Operacao_lbl
        '
        Me.Operacao_lbl.AutoSize = True
        Me.Operacao_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Operacao_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operacao_lbl.ForeColor = System.Drawing.Color.White
        Me.Operacao_lbl.Location = New System.Drawing.Point(13, 152)
        Me.Operacao_lbl.Name = "Operacao_lbl"
        Me.Operacao_lbl.Size = New System.Drawing.Size(67, 15)
        Me.Operacao_lbl.TabIndex = 11
        Me.Operacao_lbl.Text = "Operação:"
        '
        'Operacao_txt
        '
        Me.Operacao_txt.Location = New System.Drawing.Point(16, 171)
        Me.Operacao_txt.Name = "Operacao_txt"
        Me.Operacao_txt.Size = New System.Drawing.Size(125, 20)
        Me.Operacao_txt.TabIndex = 10
        '
        'Conta_lbl
        '
        Me.Conta_lbl.AutoSize = True
        Me.Conta_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Conta_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conta_lbl.ForeColor = System.Drawing.Color.White
        Me.Conta_lbl.Location = New System.Drawing.Point(13, 108)
        Me.Conta_lbl.Name = "Conta_lbl"
        Me.Conta_lbl.Size = New System.Drawing.Size(46, 15)
        Me.Conta_lbl.TabIndex = 9
        Me.Conta_lbl.Text = "Conta:"
        '
        'Conta_txt
        '
        Me.Conta_txt.Location = New System.Drawing.Point(16, 127)
        Me.Conta_txt.Name = "Conta_txt"
        Me.Conta_txt.Size = New System.Drawing.Size(125, 20)
        Me.Conta_txt.TabIndex = 8
        '
        'Agencia_lbl
        '
        Me.Agencia_lbl.AutoSize = True
        Me.Agencia_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Agencia_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agencia_lbl.ForeColor = System.Drawing.Color.White
        Me.Agencia_lbl.Location = New System.Drawing.Point(13, 64)
        Me.Agencia_lbl.Name = "Agencia_lbl"
        Me.Agencia_lbl.Size = New System.Drawing.Size(57, 15)
        Me.Agencia_lbl.TabIndex = 7
        Me.Agencia_lbl.Text = "Agência:"
        '
        'Agencia_txt
        '
        Me.Agencia_txt.Location = New System.Drawing.Point(16, 83)
        Me.Agencia_txt.Name = "Agencia_txt"
        Me.Agencia_txt.Size = New System.Drawing.Size(125, 20)
        Me.Agencia_txt.TabIndex = 6
        '
        'Codigo_Conta_lbl
        '
        Me.Codigo_Conta_lbl.AutoSize = True
        Me.Codigo_Conta_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Codigo_Conta_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Conta_lbl.ForeColor = System.Drawing.Color.White
        Me.Codigo_Conta_lbl.Location = New System.Drawing.Point(11, 21)
        Me.Codigo_Conta_lbl.Name = "Codigo_Conta_lbl"
        Me.Codigo_Conta_lbl.Size = New System.Drawing.Size(109, 15)
        Me.Codigo_Conta_lbl.TabIndex = 5
        Me.Codigo_Conta_lbl.Text = "Código do Banco:"
        '
        'Codigo_Banco_txt
        '
        Me.Codigo_Banco_txt.Location = New System.Drawing.Point(14, 40)
        Me.Codigo_Banco_txt.Name = "Codigo_Banco_txt"
        Me.Codigo_Banco_txt.Size = New System.Drawing.Size(125, 20)
        Me.Codigo_Banco_txt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Agência:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Conta:"
        '
        'Add_Bancos_btn
        '
        Me.Add_Bancos_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Bancos_btn.BackColor = System.Drawing.Color.Indigo
        Me.Add_Bancos_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Bancos_btn.FlatAppearance.BorderSize = 0
        Me.Add_Bancos_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Add_Bancos_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Add_Bancos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Bancos_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Bancos_btn.ForeColor = System.Drawing.Color.White
        Me.Add_Bancos_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Bank_Account_24px
        Me.Add_Bancos_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add_Bancos_btn.Location = New System.Drawing.Point(393, 58)
        Me.Add_Bancos_btn.Name = "Add_Bancos_btn"
        Me.Add_Bancos_btn.Size = New System.Drawing.Size(111, 34)
        Me.Add_Bancos_btn.TabIndex = 17
        Me.Add_Bancos_btn.Text = "Add Bancos"
        Me.Add_Bancos_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Add_Bancos_btn.UseVisualStyleBackColor = False
        '
        'Editar_Conta_btn
        '
        Me.Editar_Conta_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Editar_Conta_btn.BackColor = System.Drawing.Color.Indigo
        Me.Editar_Conta_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_Conta_btn.FlatAppearance.BorderSize = 0
        Me.Editar_Conta_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Editar_Conta_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Editar_Conta_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_Conta_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar_Conta_btn.ForeColor = System.Drawing.Color.White
        Me.Editar_Conta_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Edit_24px
        Me.Editar_Conta_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_Conta_btn.Location = New System.Drawing.Point(379, 427)
        Me.Editar_Conta_btn.Name = "Editar_Conta_btn"
        Me.Editar_Conta_btn.Size = New System.Drawing.Size(125, 34)
        Me.Editar_Conta_btn.TabIndex = 18
        Me.Editar_Conta_btn.Text = "Editar Conta"
        Me.Editar_Conta_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Editar_Conta_btn.UseVisualStyleBackColor = False
        Me.Editar_Conta_btn.Visible = False
        '
        'Adicionar_Conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.Add_Bancos_btn)
        Me.Controls.Add(Me.GroupBox_Transparent1)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chave_Tipo_Cbx)
        Me.Controls.Add(Me.Procurar_lbl)
        Me.Controls.Add(Me.Procurar_txb)
        Me.Controls.Add(Me.Nome_lbl)
        Me.Controls.Add(Me.Nome_txb)
        Me.Controls.Add(Me.Adicionar_btn)
        Me.Controls.Add(Me.Banco_Pic)
        Me.Controls.Add(Me.Chave_Pix_lbl)
        Me.Controls.Add(Me.Banco_lbl)
        Me.Controls.Add(Me.Chave_Pix_txt)
        Me.Controls.Add(Me.Banco_Cbx)
        Me.Controls.Add(Me.Editar_Conta_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adicionar_Conta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar"
        CType(Me.Banco_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Transparent1.ResumeLayout(False)
        Me.GroupBox_Transparent1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_Cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Chave_Pix_txt As System.Windows.Forms.TextBox
    Friend WithEvents Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents Chave_Pix_lbl As System.Windows.Forms.Label
    Friend WithEvents Banco_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Adicionar_btn As System.Windows.Forms.Button
    Friend WithEvents Bancos_Images As System.Windows.Forms.ImageList
    Friend WithEvents Nome_lbl As System.Windows.Forms.Label
    Friend WithEvents Nome_txb As System.Windows.Forms.TextBox
    Friend WithEvents Procurar_lbl As System.Windows.Forms.Label
    Friend WithEvents Procurar_txb As System.Windows.Forms.TextBox
    Friend WithEvents Chave_Tipo_Cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents GroupBox_Transparent1 As ToolsBox.GroupBox_Transparent
    Friend WithEvents Tipo_Conta_cbx As ComboBox
    Friend WithEvents Tipo_Conta_lbl As Label
    Friend WithEvents Operacao_lbl As Label
    Friend WithEvents Operacao_txt As TextBox
    Friend WithEvents Conta_lbl As Label
    Friend WithEvents Conta_txt As TextBox
    Friend WithEvents Agencia_lbl As Label
    Friend WithEvents Agencia_txt As TextBox
    Friend WithEvents Codigo_Conta_lbl As Label
    Friend WithEvents Codigo_Banco_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Add_Bancos_btn As Button
    Friend WithEvents Editar_Conta_btn As Button
End Class
