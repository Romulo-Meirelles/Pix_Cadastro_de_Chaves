<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pix))
        Me.Lateral_Panel = New System.Windows.Forms.Panel()
        Me.TestButton_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Historico_btn = New System.Windows.Forms.Button()
        Me.Gerar_Pagamentos_btn = New System.Windows.Forms.Button()
        Me.Information_Pic = New System.Windows.Forms.PictureBox()
        Me.QR_Code_Banco_lbl = New System.Windows.Forms.Label()
        Me.Version_lbl = New System.Windows.Forms.Label()
        Me.QR_Code_Pix_Pic = New System.Windows.Forms.PictureBox()
        Me.Remover_btn = New System.Windows.Forms.Button()
        Me.Adicionar_btn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel_Principal = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo_Chave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_Panel = New System.Windows.Forms.Panel()
        Me.Banco_txb = New System.Windows.Forms.TextBox()
        Me.Banco_Button_lbl = New System.Windows.Forms.Label()
        Me.Operacao_txb = New System.Windows.Forms.TextBox()
        Me.Tipo_txb = New System.Windows.Forms.TextBox()
        Me.Conta_txb = New System.Windows.Forms.TextBox()
        Me.Agencia_txb = New System.Windows.Forms.TextBox()
        Me.CodigoBanco_txb = New System.Windows.Forms.TextBox()
        Me.Operacao_lbl = New System.Windows.Forms.Label()
        Me.Tipo_lbl = New System.Windows.Forms.Label()
        Me.Conta_lbl = New System.Windows.Forms.Label()
        Me.Agencia_lbl = New System.Windows.Forms.Label()
        Me.Codigo_Banco_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tipo_Chave_lbl = New System.Windows.Forms.Label()
        Me.Chave_lbl = New System.Windows.Forms.Label()
        Me.Nome_lbl = New System.Windows.Forms.Label()
        Me.Banco_lbl = New System.Windows.Forms.Label()
        Me.ID_lbl = New System.Windows.Forms.Label()
        Me.Panel_BlockScroll = New System.Windows.Forms.Panel()
        Me.Panel_Mensagem = New System.Windows.Forms.Panel()
        Me.Note_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Switch_Grupos = New ToolsBox.Switch_Vizual_White()
        Me.Setting_btn = New System.Windows.Forms.Button()
        Me.Pesquisar_txt = New System.Windows.Forms.TextBox()
        Me.Pesquisar_lbl = New System.Windows.Forms.Label()
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.RichTextBox_Tools1 = New ToolsBox.RichTextBox_Tools()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Lateral_Panel.SuspendLayout()
        CType(Me.Information_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QR_Code_Pix_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Principal.SuspendLayout()
        Me.Button_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel_Mensagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lateral_Panel
        '
        Me.Lateral_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Lateral_Panel.Controls.Add(Me.TestButton_btn)
        Me.Lateral_Panel.Controls.Add(Me.Editar_btn)
        Me.Lateral_Panel.Controls.Add(Me.Historico_btn)
        Me.Lateral_Panel.Controls.Add(Me.Gerar_Pagamentos_btn)
        Me.Lateral_Panel.Controls.Add(Me.Information_Pic)
        Me.Lateral_Panel.Controls.Add(Me.QR_Code_Banco_lbl)
        Me.Lateral_Panel.Controls.Add(Me.Version_lbl)
        Me.Lateral_Panel.Controls.Add(Me.QR_Code_Pix_Pic)
        Me.Lateral_Panel.Controls.Add(Me.Remover_btn)
        Me.Lateral_Panel.Controls.Add(Me.Adicionar_btn)
        Me.Lateral_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lateral_Panel.Location = New System.Drawing.Point(0, 32)
        Me.Lateral_Panel.Name = "Lateral_Panel"
        Me.Lateral_Panel.Size = New System.Drawing.Size(200, 618)
        Me.Lateral_Panel.TabIndex = 1
        '
        'TestButton_btn
        '
        Me.TestButton_btn.BackColor = System.Drawing.Color.Indigo
        Me.TestButton_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TestButton_btn.FlatAppearance.BorderSize = 0
        Me.TestButton_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.TestButton_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TestButton_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestButton_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestButton_btn.ForeColor = System.Drawing.Color.White
        Me.TestButton_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Question_mark_50px
        Me.TestButton_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TestButton_btn.Location = New System.Drawing.Point(9, 342)
        Me.TestButton_btn.Name = "TestButton_btn"
        Me.TestButton_btn.Size = New System.Drawing.Size(182, 54)
        Me.TestButton_btn.TabIndex = 13
        Me.TestButton_btn.Text = "TestButton"
        Me.TestButton_btn.UseVisualStyleBackColor = False
        Me.TestButton_btn.Visible = False
        '
        'Editar_btn
        '
        Me.Editar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Editar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Editar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar_btn.ForeColor = System.Drawing.Color.White
        Me.Editar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Edit_24px
        Me.Editar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_btn.Location = New System.Drawing.Point(9, 139)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(182, 54)
        Me.Editar_btn.TabIndex = 12
        Me.Editar_btn.Text = "Editar"
        Me.Editar_btn.UseVisualStyleBackColor = False
        '
        'Historico_btn
        '
        Me.Historico_btn.BackColor = System.Drawing.Color.Indigo
        Me.Historico_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Historico_btn.FlatAppearance.BorderSize = 0
        Me.Historico_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Historico_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Historico_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Historico_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Historico_btn.ForeColor = System.Drawing.Color.White
        Me.Historico_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.order_history_24x24
        Me.Historico_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Historico_btn.Location = New System.Drawing.Point(9, 259)
        Me.Historico_btn.Name = "Historico_btn"
        Me.Historico_btn.Size = New System.Drawing.Size(182, 54)
        Me.Historico_btn.TabIndex = 11
        Me.Historico_btn.Text = "Histórico"
        Me.Historico_btn.UseVisualStyleBackColor = False
        '
        'Gerar_Pagamentos_btn
        '
        Me.Gerar_Pagamentos_btn.BackColor = System.Drawing.Color.Indigo
        Me.Gerar_Pagamentos_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Gerar_Pagamentos_btn.FlatAppearance.BorderSize = 0
        Me.Gerar_Pagamentos_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Gerar_Pagamentos_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gerar_Pagamentos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gerar_Pagamentos_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gerar_Pagamentos_btn.ForeColor = System.Drawing.Color.White
        Me.Gerar_Pagamentos_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.qr_code_24px
        Me.Gerar_Pagamentos_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Gerar_Pagamentos_btn.Location = New System.Drawing.Point(9, 199)
        Me.Gerar_Pagamentos_btn.Name = "Gerar_Pagamentos_btn"
        Me.Gerar_Pagamentos_btn.Size = New System.Drawing.Size(182, 54)
        Me.Gerar_Pagamentos_btn.TabIndex = 10
        Me.Gerar_Pagamentos_btn.Text = "Gerar Pagamento"
        Me.Gerar_Pagamentos_btn.UseVisualStyleBackColor = False
        '
        'Information_Pic
        '
        Me.Information_Pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Information_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Information_Pic.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.information_24px
        Me.Information_Pic.Location = New System.Drawing.Point(168, 588)
        Me.Information_Pic.Name = "Information_Pic"
        Me.Information_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Information_Pic.TabIndex = 9
        Me.Information_Pic.TabStop = False
        '
        'QR_Code_Banco_lbl
        '
        Me.QR_Code_Banco_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.QR_Code_Banco_lbl.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QR_Code_Banco_lbl.ForeColor = System.Drawing.Color.SpringGreen
        Me.QR_Code_Banco_lbl.Location = New System.Drawing.Point(10, 536)
        Me.QR_Code_Banco_lbl.Name = "QR_Code_Banco_lbl"
        Me.QR_Code_Banco_lbl.Size = New System.Drawing.Size(181, 27)
        Me.QR_Code_Banco_lbl.TabIndex = 8
        Me.QR_Code_Banco_lbl.Tag = " "
        Me.QR_Code_Banco_lbl.Text = "Banco:"
        Me.QR_Code_Banco_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.QR_Code_Banco_lbl.Visible = False
        '
        'Version_lbl
        '
        Me.Version_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Version_lbl.AutoSize = True
        Me.Version_lbl.ForeColor = System.Drawing.Color.Silver
        Me.Version_lbl.Location = New System.Drawing.Point(12, 596)
        Me.Version_lbl.Name = "Version_lbl"
        Me.Version_lbl.Size = New System.Drawing.Size(81, 13)
        Me.Version_lbl.TabIndex = 7
        Me.Version_lbl.Text = "Version: 0.0.0.0"
        '
        'QR_Code_Pix_Pic
        '
        Me.QR_Code_Pix_Pic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.QR_Code_Pix_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QR_Code_Pix_Pic.Location = New System.Drawing.Point(45, 430)
        Me.QR_Code_Pix_Pic.Name = "QR_Code_Pix_Pic"
        Me.QR_Code_Pix_Pic.Size = New System.Drawing.Size(100, 100)
        Me.QR_Code_Pix_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_Code_Pix_Pic.TabIndex = 5
        Me.QR_Code_Pix_Pic.TabStop = False
        Me.QR_Code_Pix_Pic.Visible = False
        '
        'Remover_btn
        '
        Me.Remover_btn.BackColor = System.Drawing.Color.Indigo
        Me.Remover_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Remover_btn.FlatAppearance.BorderSize = 0
        Me.Remover_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Remover_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Remover_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remover_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remover_btn.ForeColor = System.Drawing.Color.White
        Me.Remover_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.remove_key_24px
        Me.Remover_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Remover_btn.Location = New System.Drawing.Point(10, 79)
        Me.Remover_btn.Name = "Remover_btn"
        Me.Remover_btn.Size = New System.Drawing.Size(182, 54)
        Me.Remover_btn.TabIndex = 4
        Me.Remover_btn.Text = "Remover"
        Me.Remover_btn.UseVisualStyleBackColor = False
        '
        'Adicionar_btn
        '
        Me.Adicionar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Adicionar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adicionar_btn.FlatAppearance.BorderSize = 0
        Me.Adicionar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Adicionar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Adicionar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adicionar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adicionar_btn.ForeColor = System.Drawing.Color.White
        Me.Adicionar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.add_key_24px
        Me.Adicionar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adicionar_btn.Location = New System.Drawing.Point(10, 19)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(182, 54)
        Me.Adicionar_btn.TabIndex = 3
        Me.Adicionar_btn.Text = "Adicionar"
        Me.Adicionar_btn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Pix Inovation - Chaves Leatórias e Fixa."
        '
        'Panel_Principal
        '
        Me.Panel_Principal.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Principal.Controls.Add(Me.ListView1)
        Me.Panel_Principal.Controls.Add(Me.Button_Panel)
        Me.Panel_Principal.Controls.Add(Me.Panel1)
        Me.Panel_Principal.Controls.Add(Me.Panel_BlockScroll)
        Me.Panel_Principal.Controls.Add(Me.Panel_Mensagem)
        Me.Panel_Principal.Controls.Add(Me.RichTextBox_Tools1)
        Me.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Principal.Location = New System.Drawing.Point(200, 32)
        Me.Panel_Principal.Name = "Panel_Principal"
        Me.Panel_Principal.Size = New System.Drawing.Size(850, 618)
        Me.Panel_Principal.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ListView1.BackgroundImage = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_630x452
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Banco, Me.Nome, Me.Chave, Me.Tipo_Chave})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 66)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(850, 490)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 70
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Banco.Width = 100
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome.Width = 145
        '
        'Chave
        '
        Me.Chave.Text = "Chave"
        Me.Chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chave.Width = 281
        '
        'Tipo_Chave
        '
        Me.Tipo_Chave.Text = "Tipo Chave"
        Me.Tipo_Chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tipo_Chave.Width = 267
        '
        'Button_Panel
        '
        Me.Button_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Panel.Controls.Add(Me.Banco_txb)
        Me.Button_Panel.Controls.Add(Me.Banco_Button_lbl)
        Me.Button_Panel.Controls.Add(Me.Operacao_txb)
        Me.Button_Panel.Controls.Add(Me.Tipo_txb)
        Me.Button_Panel.Controls.Add(Me.Conta_txb)
        Me.Button_Panel.Controls.Add(Me.Agencia_txb)
        Me.Button_Panel.Controls.Add(Me.CodigoBanco_txb)
        Me.Button_Panel.Controls.Add(Me.Operacao_lbl)
        Me.Button_Panel.Controls.Add(Me.Tipo_lbl)
        Me.Button_Panel.Controls.Add(Me.Conta_lbl)
        Me.Button_Panel.Controls.Add(Me.Agencia_lbl)
        Me.Button_Panel.Controls.Add(Me.Codigo_Banco_lbl)
        Me.Button_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button_Panel.Location = New System.Drawing.Point(0, 556)
        Me.Button_Panel.Name = "Button_Panel"
        Me.Button_Panel.Size = New System.Drawing.Size(850, 62)
        Me.Button_Panel.TabIndex = 9
        '
        'Banco_txb
        '
        Me.Banco_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Banco_txb.BackColor = System.Drawing.Color.Black
        Me.Banco_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Banco_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Banco_txb.Location = New System.Drawing.Point(656, 30)
        Me.Banco_txb.Name = "Banco_txb"
        Me.Banco_txb.ReadOnly = True
        Me.Banco_txb.Size = New System.Drawing.Size(138, 20)
        Me.Banco_txb.TabIndex = 11
        Me.Banco_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Banco_Button_lbl
        '
        Me.Banco_Button_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Banco_Button_lbl.AutoSize = True
        Me.Banco_Button_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Banco_Button_lbl.Location = New System.Drawing.Point(704, 10)
        Me.Banco_Button_lbl.Name = "Banco_Button_lbl"
        Me.Banco_Button_lbl.Size = New System.Drawing.Size(41, 13)
        Me.Banco_Button_lbl.TabIndex = 10
        Me.Banco_Button_lbl.Text = "Banco:"
        '
        'Operacao_txb
        '
        Me.Operacao_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Operacao_txb.BackColor = System.Drawing.Color.Black
        Me.Operacao_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Operacao_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Operacao_txb.Location = New System.Drawing.Point(396, 30)
        Me.Operacao_txb.Name = "Operacao_txb"
        Me.Operacao_txb.ReadOnly = True
        Me.Operacao_txb.Size = New System.Drawing.Size(98, 20)
        Me.Operacao_txb.TabIndex = 9
        Me.Operacao_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tipo_txb
        '
        Me.Tipo_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Tipo_txb.BackColor = System.Drawing.Color.Black
        Me.Tipo_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tipo_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tipo_txb.Location = New System.Drawing.Point(518, 30)
        Me.Tipo_txb.Name = "Tipo_txb"
        Me.Tipo_txb.ReadOnly = True
        Me.Tipo_txb.Size = New System.Drawing.Size(114, 20)
        Me.Tipo_txb.TabIndex = 8
        Me.Tipo_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Conta_txb
        '
        Me.Conta_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Conta_txb.BackColor = System.Drawing.Color.Black
        Me.Conta_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Conta_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Conta_txb.Location = New System.Drawing.Point(258, 30)
        Me.Conta_txb.Name = "Conta_txb"
        Me.Conta_txb.ReadOnly = True
        Me.Conta_txb.Size = New System.Drawing.Size(114, 20)
        Me.Conta_txb.TabIndex = 7
        Me.Conta_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Agencia_txb
        '
        Me.Agencia_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Agencia_txb.BackColor = System.Drawing.Color.Black
        Me.Agencia_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Agencia_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Agencia_txb.Location = New System.Drawing.Point(150, 30)
        Me.Agencia_txb.Name = "Agencia_txb"
        Me.Agencia_txb.ReadOnly = True
        Me.Agencia_txb.Size = New System.Drawing.Size(86, 20)
        Me.Agencia_txb.TabIndex = 6
        Me.Agencia_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodigoBanco_txb
        '
        Me.CodigoBanco_txb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CodigoBanco_txb.BackColor = System.Drawing.Color.Black
        Me.CodigoBanco_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoBanco_txb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CodigoBanco_txb.Location = New System.Drawing.Point(57, 30)
        Me.CodigoBanco_txb.Name = "CodigoBanco_txb"
        Me.CodigoBanco_txb.ReadOnly = True
        Me.CodigoBanco_txb.Size = New System.Drawing.Size(70, 20)
        Me.CodigoBanco_txb.TabIndex = 5
        Me.CodigoBanco_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Operacao_lbl
        '
        Me.Operacao_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Operacao_lbl.AutoSize = True
        Me.Operacao_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Operacao_lbl.Location = New System.Drawing.Point(417, 10)
        Me.Operacao_lbl.Name = "Operacao_lbl"
        Me.Operacao_lbl.Size = New System.Drawing.Size(57, 13)
        Me.Operacao_lbl.TabIndex = 4
        Me.Operacao_lbl.Text = "Operação:"
        '
        'Tipo_lbl
        '
        Me.Tipo_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Tipo_lbl.AutoSize = True
        Me.Tipo_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tipo_lbl.Location = New System.Drawing.Point(557, 10)
        Me.Tipo_lbl.Name = "Tipo_lbl"
        Me.Tipo_lbl.Size = New System.Drawing.Size(31, 13)
        Me.Tipo_lbl.TabIndex = 3
        Me.Tipo_lbl.Text = "Tipo:"
        '
        'Conta_lbl
        '
        Me.Conta_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Conta_lbl.AutoSize = True
        Me.Conta_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Conta_lbl.Location = New System.Drawing.Point(298, 10)
        Me.Conta_lbl.Name = "Conta_lbl"
        Me.Conta_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Conta_lbl.TabIndex = 2
        Me.Conta_lbl.Text = "Conta:"
        '
        'Agencia_lbl
        '
        Me.Agencia_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Agencia_lbl.AutoSize = True
        Me.Agencia_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Agencia_lbl.Location = New System.Drawing.Point(170, 10)
        Me.Agencia_lbl.Name = "Agencia_lbl"
        Me.Agencia_lbl.Size = New System.Drawing.Size(49, 13)
        Me.Agencia_lbl.TabIndex = 1
        Me.Agencia_lbl.Text = "Agencia:"
        '
        'Codigo_Banco_lbl
        '
        Me.Codigo_Banco_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Codigo_Banco_lbl.AutoSize = True
        Me.Codigo_Banco_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Codigo_Banco_lbl.Location = New System.Drawing.Point(55, 10)
        Me.Codigo_Banco_lbl.Name = "Codigo_Banco_lbl"
        Me.Codigo_Banco_lbl.Size = New System.Drawing.Size(77, 13)
        Me.Codigo_Banco_lbl.TabIndex = 0
        Me.Codigo_Banco_lbl.Text = "Código Banco:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Tipo_Chave_lbl)
        Me.Panel1.Controls.Add(Me.Chave_lbl)
        Me.Panel1.Controls.Add(Me.Nome_lbl)
        Me.Panel1.Controls.Add(Me.Banco_lbl)
        Me.Panel1.Controls.Add(Me.ID_lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 24)
        Me.Panel1.TabIndex = 8
        '
        'Tipo_Chave_lbl
        '
        Me.Tipo_Chave_lbl.AutoSize = True
        Me.Tipo_Chave_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Tipo_Chave_lbl.Location = New System.Drawing.Point(698, 8)
        Me.Tipo_Chave_lbl.Name = "Tipo_Chave_lbl"
        Me.Tipo_Chave_lbl.Size = New System.Drawing.Size(62, 13)
        Me.Tipo_Chave_lbl.TabIndex = 9
        Me.Tipo_Chave_lbl.Text = "Tipo Chave"
        '
        'Chave_lbl
        '
        Me.Chave_lbl.AutoSize = True
        Me.Chave_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Chave_lbl.Location = New System.Drawing.Point(437, 8)
        Me.Chave_lbl.Name = "Chave_lbl"
        Me.Chave_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Chave_lbl.TabIndex = 3
        Me.Chave_lbl.Text = "Chave"
        '
        'Nome_lbl
        '
        Me.Nome_lbl.AutoSize = True
        Me.Nome_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Nome_lbl.Location = New System.Drawing.Point(225, 8)
        Me.Nome_lbl.Name = "Nome_lbl"
        Me.Nome_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Nome_lbl.TabIndex = 2
        Me.Nome_lbl.Text = "Nome"
        '
        'Banco_lbl
        '
        Me.Banco_lbl.AutoSize = True
        Me.Banco_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Banco_lbl.Location = New System.Drawing.Point(101, 8)
        Me.Banco_lbl.Name = "Banco_lbl"
        Me.Banco_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Banco_lbl.TabIndex = 1
        Me.Banco_lbl.Text = "Banco"
        '
        'ID_lbl
        '
        Me.ID_lbl.AutoSize = True
        Me.ID_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.ID_lbl.Location = New System.Drawing.Point(3, 8)
        Me.ID_lbl.Name = "ID_lbl"
        Me.ID_lbl.Size = New System.Drawing.Size(18, 13)
        Me.ID_lbl.TabIndex = 0
        Me.ID_lbl.Text = "ID"
        '
        'Panel_BlockScroll
        '
        Me.Panel_BlockScroll.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel_BlockScroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Panel_BlockScroll.Location = New System.Drawing.Point(823, 76)
        Me.Panel_BlockScroll.Name = "Panel_BlockScroll"
        Me.Panel_BlockScroll.Size = New System.Drawing.Size(26, 467)
        Me.Panel_BlockScroll.TabIndex = 6
        '
        'Panel_Mensagem
        '
        Me.Panel_Mensagem.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel_Mensagem.Controls.Add(Me.Note_btn)
        Me.Panel_Mensagem.Controls.Add(Me.Label1)
        Me.Panel_Mensagem.Controls.Add(Me.Switch_Grupos)
        Me.Panel_Mensagem.Controls.Add(Me.Setting_btn)
        Me.Panel_Mensagem.Controls.Add(Me.Pesquisar_txt)
        Me.Panel_Mensagem.Controls.Add(Me.Pesquisar_lbl)
        Me.Panel_Mensagem.Controls.Add(Me.Mensagem_lbl)
        Me.Panel_Mensagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Mensagem.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Mensagem.Name = "Panel_Mensagem"
        Me.Panel_Mensagem.Size = New System.Drawing.Size(850, 42)
        Me.Panel_Mensagem.TabIndex = 5
        '
        'Note_btn
        '
        Me.Note_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_btn.BackgroundImage = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.note_24px
        Me.Note_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Note_btn.FlatAppearance.BorderSize = 0
        Me.Note_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Note_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Note_btn.Location = New System.Drawing.Point(764, 9)
        Me.Note_btn.Name = "Note_btn"
        Me.Note_btn.Size = New System.Drawing.Size(24, 24)
        Me.Note_btn.TabIndex = 6
        Me.Note_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(188, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grupos:"
        '
        'Switch_Grupos
        '
        Me.Switch_Grupos.Checked = False
        Me.Switch_Grupos.Color = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Switch_Grupos.Color_Disabled = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Switch_Grupos.Color_Enabled = System.Drawing.Color.Lime
        Me.Switch_Grupos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Switch_Grupos.Customization = ""
        Me.Switch_Grupos.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Switch_Grupos.Image = Nothing
        Me.Switch_Grupos.Location = New System.Drawing.Point(237, 12)
        Me.Switch_Grupos.Name = "Switch_Grupos"
        Me.Switch_Grupos.NoRounding = False
        Me.Switch_Grupos.Size = New System.Drawing.Size(35, 19)
        Me.Switch_Grupos.TabIndex = 4
        Me.Switch_Grupos.Text = "Switch_Vizual_White1"
        Me.Switch_Grupos.Transparent = False
        '
        'Setting_btn
        '
        Me.Setting_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Setting_btn.BackgroundImage = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.settings_24px
        Me.Setting_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setting_btn.FlatAppearance.BorderSize = 0
        Me.Setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Setting_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Setting_btn.Location = New System.Drawing.Point(800, 9)
        Me.Setting_btn.Name = "Setting_btn"
        Me.Setting_btn.Size = New System.Drawing.Size(24, 24)
        Me.Setting_btn.TabIndex = 3
        Me.Setting_btn.UseVisualStyleBackColor = True
        '
        'Pesquisar_txt
        '
        Me.Pesquisar_txt.Location = New System.Drawing.Point(70, 11)
        Me.Pesquisar_txt.MaxLength = 30
        Me.Pesquisar_txt.Name = "Pesquisar_txt"
        Me.Pesquisar_txt.Size = New System.Drawing.Size(100, 20)
        Me.Pesquisar_txt.TabIndex = 2
        '
        'Pesquisar_lbl
        '
        Me.Pesquisar_lbl.AutoSize = True
        Me.Pesquisar_lbl.ForeColor = System.Drawing.Color.Silver
        Me.Pesquisar_lbl.Location = New System.Drawing.Point(8, 14)
        Me.Pesquisar_lbl.Name = "Pesquisar_lbl"
        Me.Pesquisar_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Pesquisar_lbl.TabIndex = 1
        Me.Pesquisar_lbl.Text = "Pesquisar:"
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Mensagem_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.Red
        Me.Mensagem_lbl.Location = New System.Drawing.Point(526, 9)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(210, 25)
        Me.Mensagem_lbl.TabIndex = 0
        Me.Mensagem_lbl.Text = "Dê 2 cliques para copiar a chave."
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox_Tools1
        '
        Me.RichTextBox_Tools1.ContextMenuStrip = False
        Me.RichTextBox_Tools1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox_Tools1.EnableCopy = True
        Me.RichTextBox_Tools1.EnableCut = True
        Me.RichTextBox_Tools1.EnableNew = True
        Me.RichTextBox_Tools1.EnableOpen = True
        Me.RichTextBox_Tools1.EnablePaste = True
        Me.RichTextBox_Tools1.EnableSave = True
        Me.RichTextBox_Tools1.Load = Nothing
        Me.RichTextBox_Tools1.LoadBytes = Nothing
        Me.RichTextBox_Tools1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox_Tools1.MenuStrip = True
        Me.RichTextBox_Tools1.MinimumSize = New System.Drawing.Size(300, 200)
        Me.RichTextBox_Tools1.Name = "RichTextBox_Tools1"
        Me.RichTextBox_Tools1.Size = New System.Drawing.Size(850, 618)
        Me.RichTextBox_Tools1.StatusStrip = True
        Me.RichTextBox_Tools1.TabIndex = 10
        Me.RichTextBox_Tools1.Text = "RichText_Tools1"
        Me.RichTextBox_Tools1.ToolsStrip = True
        Me.RichTextBox_Tools1.Visible = False
        '
        'Control_TaskBar_Top1
        '
        Me.Control_TaskBar_Top1.BalloonTipTime = 0
        Me.Control_TaskBar_Top1.BorderRadius = 0
        Me.Control_TaskBar_Top1.CloseEnable = False
        Me.Control_TaskBar_Top1.CloseToClose = ToolsBox.Control_TaskBar_Top.Closerme.MeClose
        Me.Control_TaskBar_Top1.ControlBoxEnable = True
        Me.Control_TaskBar_Top1.ControlColorButtonBorder = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Control_TaskBar_Top1.ControlColorButtonItem = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.ControlColorButtonOne = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(1050, 32)
        Me.Control_TaskBar_Top1.TabIndex = 4
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Pix Inovation - Chaves Leatórias e Fixa.  (By Romulo Meirelles.)"
        Me.Control_TaskBar_Top1.ToolTip = True
        Me.Control_TaskBar_Top1.TwoClicks = True
        '
        'Pix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 650)
        Me.Controls.Add(Me.Panel_Principal)
        Me.Controls.Add(Me.Lateral_Panel)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pix Chaves - By Romulo Meirelles."
        Me.Lateral_Panel.ResumeLayout(False)
        Me.Lateral_Panel.PerformLayout()
        CType(Me.Information_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QR_Code_Pix_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Principal.ResumeLayout(False)
        Me.Button_Panel.ResumeLayout(False)
        Me.Button_Panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Mensagem.ResumeLayout(False)
        Me.Panel_Mensagem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lateral_Panel As System.Windows.Forms.Panel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Adicionar_btn As System.Windows.Forms.Button
    Friend WithEvents Remover_btn As System.Windows.Forms.Button
    Friend WithEvents Panel_Principal As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Chave As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel_Mensagem As System.Windows.Forms.Panel
    Friend WithEvents Mensagem_lbl As System.Windows.Forms.Label
    Friend WithEvents QR_Code_Pix_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Version_lbl As System.Windows.Forms.Label
    Friend WithEvents Information_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel_BlockScroll As System.Windows.Forms.Panel
    Friend WithEvents Gerar_Pagamentos_btn As System.Windows.Forms.Button
    Friend WithEvents Historico_btn As System.Windows.Forms.Button
    Friend WithEvents QR_Code_Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tipo_Chave_lbl As System.Windows.Forms.Label
    Friend WithEvents Chave_lbl As System.Windows.Forms.Label
    Friend WithEvents Nome_lbl As System.Windows.Forms.Label
    Friend WithEvents Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents ID_lbl As System.Windows.Forms.Label
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Button_Panel As System.Windows.Forms.Panel
    Friend WithEvents Operacao_lbl As System.Windows.Forms.Label
    Friend WithEvents Tipo_lbl As System.Windows.Forms.Label
    Friend WithEvents Conta_lbl As System.Windows.Forms.Label
    Friend WithEvents Agencia_lbl As System.Windows.Forms.Label
    Friend WithEvents Codigo_Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents Operacao_txb As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_txb As System.Windows.Forms.TextBox
    Friend WithEvents Conta_txb As System.Windows.Forms.TextBox
    Friend WithEvents Agencia_txb As System.Windows.Forms.TextBox
    Friend WithEvents CodigoBanco_txb As System.Windows.Forms.TextBox
    Friend WithEvents Banco_txb As System.Windows.Forms.TextBox
    Friend WithEvents Banco_Button_lbl As System.Windows.Forms.Label
    Friend WithEvents Editar_btn As Button
    Friend WithEvents Tipo_Chave As ColumnHeader
    Friend WithEvents Pesquisar_txt As TextBox
    Friend WithEvents Pesquisar_lbl As Label
    Friend WithEvents Setting_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Switch_Grupos As ToolsBox.Switch_Vizual_White
    Friend WithEvents TestButton_btn As Button
    Friend WithEvents Note_btn As Button
    Friend WithEvents RichTextBox_Tools1 As ToolsBox.RichTextBox_Tools
    ' Friend ColorTransition1 As ToolsBox.Button_Gradient.ColorTransition
    ' Friend ColorTransition2 As ToolsBox.ListBox_Gradient.ColorTransition
    'Friend ColorTransition3 As ToolsBox.Panel_Gradient.ColorTransition

End Class
