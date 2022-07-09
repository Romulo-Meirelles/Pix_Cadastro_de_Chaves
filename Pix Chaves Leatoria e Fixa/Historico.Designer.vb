<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historico))
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Servico = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QRCodePix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_Control = New System.Windows.Forms.Panel()
        Me.QRCode_btn = New System.Windows.Forms.Button()
        Me.Copiar_btn = New System.Windows.Forms.Button()
        Me.Limpar_Historico_btn = New System.Windows.Forms.Button()
        Me.Timer_Copia_Cola = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QRCodePIX_lbl = New System.Windows.Forms.Label()
        Me.Data_lbl = New System.Windows.Forms.Label()
        Me.Codigo_lbl = New System.Windows.Forms.Label()
        Me.Cidade_lbl = New System.Windows.Forms.Label()
        Me.Servico_lbl = New System.Windows.Forms.Label()
        Me.Tipo_lbl = New System.Windows.Forms.Label()
        Me.Valor_lbl = New System.Windows.Forms.Label()
        Me.Chave_lbl = New System.Windows.Forms.Label()
        Me.Nome_lbl = New System.Windows.Forms.Label()
        Me.Banco_lbl = New System.Windows.Forms.Label()
        Me.ID_lbl = New System.Windows.Forms.Label()
        Me.Panel_BlockScroll = New System.Windows.Forms.Panel()
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Panel_Control.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Mensagem_lbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Mensagem_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.Red
        Me.Mensagem_lbl.Location = New System.Drawing.Point(354, 6)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(345, 18)
        Me.Mensagem_lbl.TabIndex = 4
        Me.Mensagem_lbl.Text = "Dê 2 cliques para ""Copia e Cola"" Chave Gerada."
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Banco, Me.Nome, Me.Chave, Me.Valor, Me.Tipo, Me.Servico, Me.Cidade, Me.Codigo, Me.Data, Me.QRCodePix})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 62)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(800, 439)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 50
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Banco.Width = 74
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Nome.Width = 77
        '
        'Chave
        '
        Me.Chave.Text = "Chave"
        Me.Chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chave.Width = 75
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Valor.Width = 54
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tipo.Width = 61
        '
        'Servico
        '
        Me.Servico.Text = "Serviço"
        Me.Servico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Servico.Width = 68
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        Me.Cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cidade.Width = 59
        '
        'Codigo
        '
        Me.Codigo.Text = "Código"
        Me.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data
        '
        Me.Data.Text = "Data"
        Me.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Data.Width = 80
        '
        'QRCodePix
        '
        Me.QRCodePix.Text = "QRCode Pix"
        Me.QRCodePix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QRCodePix.Width = 121
        '
        'Panel_Control
        '
        Me.Panel_Control.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel_Control.Controls.Add(Me.QRCode_btn)
        Me.Panel_Control.Controls.Add(Me.Copiar_btn)
        Me.Panel_Control.Controls.Add(Me.Limpar_Historico_btn)
        Me.Panel_Control.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Control.Location = New System.Drawing.Point(0, 501)
        Me.Panel_Control.Name = "Panel_Control"
        Me.Panel_Control.Size = New System.Drawing.Size(800, 49)
        Me.Panel_Control.TabIndex = 6
        '
        'QRCode_btn
        '
        Me.QRCode_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QRCode_btn.BackColor = System.Drawing.Color.Indigo
        Me.QRCode_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QRCode_btn.FlatAppearance.BorderSize = 0
        Me.QRCode_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.QRCode_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QRCode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QRCode_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QRCode_btn.ForeColor = System.Drawing.Color.White
        Me.QRCode_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.qr_code_24px
        Me.QRCode_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QRCode_btn.Location = New System.Drawing.Point(535, 8)
        Me.QRCode_btn.Name = "QRCode_btn"
        Me.QRCode_btn.Size = New System.Drawing.Size(112, 34)
        Me.QRCode_btn.TabIndex = 11
        Me.QRCode_btn.Text = "QRCode Pix"
        Me.QRCode_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QRCode_btn.UseVisualStyleBackColor = False
        '
        'Copiar_btn
        '
        Me.Copiar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Copiar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Copiar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Copiar_btn.FlatAppearance.BorderSize = 0
        Me.Copiar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Copiar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Copiar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Copiar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copiar_btn.ForeColor = System.Drawing.Color.White
        Me.Copiar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Copy_24x24
        Me.Copiar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Copiar_btn.Location = New System.Drawing.Point(381, 8)
        Me.Copiar_btn.Name = "Copiar_btn"
        Me.Copiar_btn.Size = New System.Drawing.Size(148, 34)
        Me.Copiar_btn.TabIndex = 10
        Me.Copiar_btn.Text = "Copiar Chave Pix"
        Me.Copiar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Copiar_btn.UseVisualStyleBackColor = False
        '
        'Limpar_Historico_btn
        '
        Me.Limpar_Historico_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Limpar_Historico_btn.BackColor = System.Drawing.Color.Indigo
        Me.Limpar_Historico_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpar_Historico_btn.FlatAppearance.BorderSize = 0
        Me.Limpar_Historico_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Limpar_Historico_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Limpar_Historico_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Limpar_Historico_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpar_Historico_btn.ForeColor = System.Drawing.Color.White
        Me.Limpar_Historico_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Erase_24x24px
        Me.Limpar_Historico_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Limpar_Historico_btn.Location = New System.Drawing.Point(653, 8)
        Me.Limpar_Historico_btn.Name = "Limpar_Historico_btn"
        Me.Limpar_Historico_btn.Size = New System.Drawing.Size(138, 34)
        Me.Limpar_Historico_btn.TabIndex = 9
        Me.Limpar_Historico_btn.Text = "Limpar Histórico"
        Me.Limpar_Historico_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Limpar_Historico_btn.UseVisualStyleBackColor = False
        '
        'Timer_Copia_Cola
        '
        Me.Timer_Copia_Cola.Interval = 3000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.Controls.Add(Me.QRCodePIX_lbl)
        Me.Panel1.Controls.Add(Me.Data_lbl)
        Me.Panel1.Controls.Add(Me.Codigo_lbl)
        Me.Panel1.Controls.Add(Me.Cidade_lbl)
        Me.Panel1.Controls.Add(Me.Servico_lbl)
        Me.Panel1.Controls.Add(Me.Tipo_lbl)
        Me.Panel1.Controls.Add(Me.Valor_lbl)
        Me.Panel1.Controls.Add(Me.Chave_lbl)
        Me.Panel1.Controls.Add(Me.Nome_lbl)
        Me.Panel1.Controls.Add(Me.Banco_lbl)
        Me.Panel1.Controls.Add(Me.ID_lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 30)
        Me.Panel1.TabIndex = 7
        '
        'QRCodePIX_lbl
        '
        Me.QRCodePIX_lbl.AutoSize = True
        Me.QRCodePIX_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.QRCodePIX_lbl.Location = New System.Drawing.Point(691, 8)
        Me.QRCodePIX_lbl.Name = "QRCodePIX_lbl"
        Me.QRCodePIX_lbl.Size = New System.Drawing.Size(68, 13)
        Me.QRCodePIX_lbl.TabIndex = 10
        Me.QRCodePIX_lbl.Text = "QR Code Pix"
        '
        'Data_lbl
        '
        Me.Data_lbl.AutoSize = True
        Me.Data_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Data_lbl.Location = New System.Drawing.Point(608, 8)
        Me.Data_lbl.Name = "Data_lbl"
        Me.Data_lbl.Size = New System.Drawing.Size(30, 13)
        Me.Data_lbl.TabIndex = 9
        Me.Data_lbl.Text = "Data"
        '
        'Codigo_lbl
        '
        Me.Codigo_lbl.AutoSize = True
        Me.Codigo_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Codigo_lbl.Location = New System.Drawing.Point(533, 8)
        Me.Codigo_lbl.Name = "Codigo_lbl"
        Me.Codigo_lbl.Size = New System.Drawing.Size(40, 13)
        Me.Codigo_lbl.TabIndex = 8
        Me.Codigo_lbl.Text = "Código"
        '
        'Cidade_lbl
        '
        Me.Cidade_lbl.AutoSize = True
        Me.Cidade_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Cidade_lbl.Location = New System.Drawing.Point(472, 8)
        Me.Cidade_lbl.Name = "Cidade_lbl"
        Me.Cidade_lbl.Size = New System.Drawing.Size(40, 13)
        Me.Cidade_lbl.TabIndex = 7
        Me.Cidade_lbl.Text = "Cidade"
        '
        'Servico_lbl
        '
        Me.Servico_lbl.AutoSize = True
        Me.Servico_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Servico_lbl.Location = New System.Drawing.Point(406, 8)
        Me.Servico_lbl.Name = "Servico_lbl"
        Me.Servico_lbl.Size = New System.Drawing.Size(43, 13)
        Me.Servico_lbl.TabIndex = 6
        Me.Servico_lbl.Text = "Serviço"
        '
        'Tipo_lbl
        '
        Me.Tipo_lbl.AutoSize = True
        Me.Tipo_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Tipo_lbl.Location = New System.Drawing.Point(348, 8)
        Me.Tipo_lbl.Name = "Tipo_lbl"
        Me.Tipo_lbl.Size = New System.Drawing.Size(28, 13)
        Me.Tipo_lbl.TabIndex = 5
        Me.Tipo_lbl.Text = "Tipo"
        '
        'Valor_lbl
        '
        Me.Valor_lbl.AutoSize = True
        Me.Valor_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Valor_lbl.Location = New System.Drawing.Point(285, 8)
        Me.Valor_lbl.Name = "Valor_lbl"
        Me.Valor_lbl.Size = New System.Drawing.Size(31, 13)
        Me.Valor_lbl.TabIndex = 4
        Me.Valor_lbl.Text = "Valor"
        '
        'Chave_lbl
        '
        Me.Chave_lbl.AutoSize = True
        Me.Chave_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Chave_lbl.Location = New System.Drawing.Point(214, 8)
        Me.Chave_lbl.Name = "Chave_lbl"
        Me.Chave_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Chave_lbl.TabIndex = 3
        Me.Chave_lbl.Text = "Chave"
        '
        'Nome_lbl
        '
        Me.Nome_lbl.AutoSize = True
        Me.Nome_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Nome_lbl.Location = New System.Drawing.Point(146, 8)
        Me.Nome_lbl.Name = "Nome_lbl"
        Me.Nome_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Nome_lbl.TabIndex = 2
        Me.Nome_lbl.Text = "Nome"
        '
        'Banco_lbl
        '
        Me.Banco_lbl.AutoSize = True
        Me.Banco_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.Banco_lbl.Location = New System.Drawing.Point(65, 8)
        Me.Banco_lbl.Name = "Banco_lbl"
        Me.Banco_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Banco_lbl.TabIndex = 1
        Me.Banco_lbl.Text = "Banco"
        '
        'ID_lbl
        '
        Me.ID_lbl.AutoSize = True
        Me.ID_lbl.ForeColor = System.Drawing.Color.Turquoise
        Me.ID_lbl.Location = New System.Drawing.Point(15, 8)
        Me.ID_lbl.Name = "ID_lbl"
        Me.ID_lbl.Size = New System.Drawing.Size(18, 13)
        Me.ID_lbl.TabIndex = 0
        Me.ID_lbl.Text = "ID"
        '
        'Panel_BlockScroll
        '
        Me.Panel_BlockScroll.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel_BlockScroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel_BlockScroll.Location = New System.Drawing.Point(774, 60)
        Me.Panel_BlockScroll.Name = "Panel_BlockScroll"
        Me.Panel_BlockScroll.Size = New System.Drawing.Size(26, 443)
        Me.Panel_BlockScroll.TabIndex = 8
        '
        'Control_TaskBar_Top1
        '
        Me.Control_TaskBar_Top1.BorderRadius = 0
        Me.Control_TaskBar_Top1.CloseEnable = False
        Me.Control_TaskBar_Top1.CloseToClose = ToolsBox.Control_TaskBar_Top.Closerme.MeClose
        Me.Control_TaskBar_Top1.ControlBoxEnable = True
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(800, 32)
        Me.Control_TaskBar_Top1.TabIndex = 14
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Histórico - QRCode Pix Gerados."
        '
        'Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.Panel_BlockScroll)
        Me.Controls.Add(Me.Mensagem_lbl)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Control)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico"
        Me.TopMost = True
        Me.Panel_Control.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Banco As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents Chave As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Servico As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents Codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents QRCodePix As System.Windows.Forms.ColumnHeader
    Friend WithEvents Data As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel_Control As System.Windows.Forms.Panel
    Friend WithEvents Limpar_Historico_btn As System.Windows.Forms.Button
    Friend WithEvents Copiar_btn As System.Windows.Forms.Button
    Friend WithEvents QRCode_btn As System.Windows.Forms.Button
    Friend WithEvents Mensagem_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer_Copia_Cola As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents QRCodePIX_lbl As System.Windows.Forms.Label
    Friend WithEvents Data_lbl As System.Windows.Forms.Label
    Friend WithEvents Codigo_lbl As System.Windows.Forms.Label
    Friend WithEvents Cidade_lbl As System.Windows.Forms.Label
    Friend WithEvents Servico_lbl As System.Windows.Forms.Label
    Friend WithEvents Tipo_lbl As System.Windows.Forms.Label
    Friend WithEvents Valor_lbl As System.Windows.Forms.Label
    Friend WithEvents Chave_lbl As System.Windows.Forms.Label
    Friend WithEvents Nome_lbl As System.Windows.Forms.Label
    Friend WithEvents Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents ID_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel_BlockScroll As System.Windows.Forms.Panel
    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
End Class
