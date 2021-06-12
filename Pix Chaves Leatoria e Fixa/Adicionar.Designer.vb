<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adicionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adicionar))
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
        Me.Superior_Panel = New System.Windows.Forms.Panel()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Pix_Icon_Pic = New System.Windows.Forms.PictureBox()
        CType(Me.Banco_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Superior_Panel.SuspendLayout()
        CType(Me.Pix_Icon_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Banco_Cbx
        '
        Me.Banco_Cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Banco_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Banco_Cbx.Location = New System.Drawing.Point(26, 63)
        Me.Banco_Cbx.Name = "Banco_Cbx"
        Me.Banco_Cbx.Size = New System.Drawing.Size(185, 21)
        Me.Banco_Cbx.Sorted = True
        Me.Banco_Cbx.TabIndex = 0
        '
        'Chave_Pix_txt
        '
        Me.Chave_Pix_txt.Location = New System.Drawing.Point(26, 219)
        Me.Chave_Pix_txt.Name = "Chave_Pix_txt"
        Me.Chave_Pix_txt.Size = New System.Drawing.Size(185, 20)
        Me.Chave_Pix_txt.TabIndex = 1
        '
        'Banco_lbl
        '
        Me.Banco_lbl.AutoSize = True
        Me.Banco_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banco_lbl.ForeColor = System.Drawing.Color.White
        Me.Banco_lbl.Location = New System.Drawing.Point(23, 44)
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
        Me.Chave_Pix_lbl.Location = New System.Drawing.Point(23, 200)
        Me.Chave_Pix_lbl.Name = "Chave_Pix_lbl"
        Me.Chave_Pix_lbl.Size = New System.Drawing.Size(70, 15)
        Me.Chave_Pix_lbl.TabIndex = 3
        Me.Chave_Pix_lbl.Text = "Chave Pix:"
        '
        'Banco_Pic
        '
        Me.Banco_Pic.Location = New System.Drawing.Point(267, 91)
        Me.Banco_Pic.Name = "Banco_Pic"
        Me.Banco_Pic.Size = New System.Drawing.Size(74, 74)
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
        Me.Adicionar_btn.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.add_key_24px
        Me.Adicionar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adicionar_btn.Location = New System.Drawing.Point(278, 235)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(109, 34)
        Me.Adicionar_btn.TabIndex = 5
        Me.Adicionar_btn.Text = "Adicionar"
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
        Me.Nome_lbl.Location = New System.Drawing.Point(23, 97)
        Me.Nome_lbl.Name = "Nome_lbl"
        Me.Nome_lbl.Size = New System.Drawing.Size(85, 15)
        Me.Nome_lbl.TabIndex = 8
        Me.Nome_lbl.Text = "Nome Titular:"
        '
        'Nome_txb
        '
        Me.Nome_txb.Location = New System.Drawing.Point(26, 116)
        Me.Nome_txb.Name = "Nome_txb"
        Me.Nome_txb.Size = New System.Drawing.Size(185, 20)
        Me.Nome_txb.TabIndex = 7
        '
        'Procurar_lbl
        '
        Me.Procurar_lbl.AutoSize = True
        Me.Procurar_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Procurar_lbl.ForeColor = System.Drawing.Color.White
        Me.Procurar_lbl.Location = New System.Drawing.Point(231, 44)
        Me.Procurar_lbl.Name = "Procurar_lbl"
        Me.Procurar_lbl.Size = New System.Drawing.Size(100, 15)
        Me.Procurar_lbl.TabIndex = 10
        Me.Procurar_lbl.Text = "Procurar Banco:"
        '
        'Procurar_txb
        '
        Me.Procurar_txb.Location = New System.Drawing.Point(234, 63)
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
        Me.Chave_Tipo_Cbx.Location = New System.Drawing.Point(26, 167)
        Me.Chave_Tipo_Cbx.Name = "Chave_Tipo_Cbx"
        Me.Chave_Tipo_Cbx.Size = New System.Drawing.Size(140, 21)
        Me.Chave_Tipo_Cbx.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tipo Chave:"
        '
        'Superior_Panel
        '
        Me.Superior_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Superior_Panel.Controls.Add(Me.Close_btn)
        Me.Superior_Panel.Controls.Add(Me.Title_Label)
        Me.Superior_Panel.Controls.Add(Me.Pix_Icon_Pic)
        Me.Superior_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Superior_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Superior_Panel.Name = "Superior_Panel"
        Me.Superior_Panel.Size = New System.Drawing.Size(400, 30)
        Me.Superior_Panel.TabIndex = 13
        '
        'Close_btn
        '
        Me.Close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Close_btn.BackgroundImage = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Close
        Me.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_btn.FlatAppearance.BorderSize = 0
        Me.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_btn.Location = New System.Drawing.Point(370, 4)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(24, 24)
        Me.Close_btn.TabIndex = 5
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(42, 8)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(111, 15)
        Me.Title_Label.TabIndex = 3
        Me.Title_Label.Text = "Adicionar Chaves."
        '
        'Pix_Icon_Pic
        '
        Me.Pix_Icon_Pic.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_24x24
        Me.Pix_Icon_Pic.Location = New System.Drawing.Point(9, 3)
        Me.Pix_Icon_Pic.Name = "Pix_Icon_Pic"
        Me.Pix_Icon_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Pix_Icon_Pic.TabIndex = 0
        Me.Pix_Icon_Pic.TabStop = False
        '
        'Adicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.Superior_Panel)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adicionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar"
        Me.TopMost = True
        CType(Me.Banco_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Superior_Panel.ResumeLayout(False)
        Me.Superior_Panel.PerformLayout()
        CType(Me.Pix_Icon_Pic, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Superior_Panel As System.Windows.Forms.Panel
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents Pix_Icon_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Close_btn As System.Windows.Forms.Button
End Class
