<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bancos_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bancos_Add))
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Codigo_lbl = New System.Windows.Forms.Label()
        Me.Codigo_txb = New System.Windows.Forms.TextBox()
        Me.Nome_lbl = New System.Windows.Forms.Label()
        Me.Nome_txb = New System.Windows.Forms.TextBox()
        Me.Foto_lbl = New System.Windows.Forms.Label()
        Me.Foto_txb = New System.Windows.Forms.TextBox()
        Me.Adicionar_btn = New System.Windows.Forms.Button()
        Me.Browser_btn = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Codigo_Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Foto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remover_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(897, 32)
        Me.Control_TaskBar_Top1.TabIndex = 14
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = True
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Adicionar Bancos."
        Me.Control_TaskBar_Top1.ToolTip = True
        Me.Control_TaskBar_Top1.TwoClicks = True
        '
        'Codigo_lbl
        '
        Me.Codigo_lbl.AutoSize = True
        Me.Codigo_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_lbl.ForeColor = System.Drawing.Color.White
        Me.Codigo_lbl.Location = New System.Drawing.Point(12, 47)
        Me.Codigo_lbl.Name = "Codigo_lbl"
        Me.Codigo_lbl.Size = New System.Drawing.Size(109, 15)
        Me.Codigo_lbl.TabIndex = 16
        Me.Codigo_lbl.Text = "Código do Banco:"
        '
        'Codigo_txb
        '
        Me.Codigo_txb.Location = New System.Drawing.Point(15, 66)
        Me.Codigo_txb.MaxLength = 6
        Me.Codigo_txb.Name = "Codigo_txb"
        Me.Codigo_txb.Size = New System.Drawing.Size(152, 20)
        Me.Codigo_txb.TabIndex = 15
        '
        'Nome_lbl
        '
        Me.Nome_lbl.AutoSize = True
        Me.Nome_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_lbl.ForeColor = System.Drawing.Color.White
        Me.Nome_lbl.Location = New System.Drawing.Point(12, 92)
        Me.Nome_lbl.Name = "Nome_lbl"
        Me.Nome_lbl.Size = New System.Drawing.Size(84, 15)
        Me.Nome_lbl.TabIndex = 18
        Me.Nome_lbl.Text = "Nome Banco:"
        '
        'Nome_txb
        '
        Me.Nome_txb.Location = New System.Drawing.Point(15, 111)
        Me.Nome_txb.Name = "Nome_txb"
        Me.Nome_txb.Size = New System.Drawing.Size(185, 20)
        Me.Nome_txb.TabIndex = 17
        '
        'Foto_lbl
        '
        Me.Foto_lbl.AutoSize = True
        Me.Foto_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Foto_lbl.ForeColor = System.Drawing.Color.White
        Me.Foto_lbl.Location = New System.Drawing.Point(12, 138)
        Me.Foto_lbl.Name = "Foto_lbl"
        Me.Foto_lbl.Size = New System.Drawing.Size(130, 15)
        Me.Foto_lbl.TabIndex = 20
        Me.Foto_lbl.Text = "Imagem Logo Banco:"
        '
        'Foto_txb
        '
        Me.Foto_txb.Location = New System.Drawing.Point(15, 157)
        Me.Foto_txb.Name = "Foto_txb"
        Me.Foto_txb.ReadOnly = True
        Me.Foto_txb.Size = New System.Drawing.Size(185, 20)
        Me.Foto_txb.TabIndex = 19
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
        Me.Adicionar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Bank_Account_24px
        Me.Adicionar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adicionar_btn.Location = New System.Drawing.Point(535, 414)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(97, 34)
        Me.Adicionar_btn.TabIndex = 21
        Me.Adicionar_btn.Text = "Adicionar"
        Me.Adicionar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adicionar_btn.UseVisualStyleBackColor = False
        '
        'Browser_btn
        '
        Me.Browser_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Browser_btn.BackColor = System.Drawing.Color.Indigo
        Me.Browser_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Browser_btn.FlatAppearance.BorderSize = 0
        Me.Browser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Browser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Browser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Browser_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browser_btn.ForeColor = System.Drawing.Color.White
        Me.Browser_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Browser_24px
        Me.Browser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Browser_btn.Location = New System.Drawing.Point(206, 149)
        Me.Browser_btn.Name = "Browser_btn"
        Me.Browser_btn.Size = New System.Drawing.Size(87, 34)
        Me.Browser_btn.TabIndex = 22
        Me.Browser_btn.Text = "Browser"
        Me.Browser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Browser_btn.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ListView1.BackgroundImage = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_630x452
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Codigo_Banco, Me.Banco, Me.Foto})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(299, 38)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(586, 367)
        Me.ListView1.TabIndex = 23
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 70
        '
        'Codigo_Banco
        '
        Me.Codigo_Banco.Text = "Código Banco"
        Me.Codigo_Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Codigo_Banco.Width = 100
        '
        'Banco
        '
        Me.Banco.Text = "Banco"
        Me.Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Banco.Width = 145
        '
        'Foto
        '
        Me.Foto.Text = "Foto"
        Me.Foto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Foto.Width = 265
        '
        'Remover_btn
        '
        Me.Remover_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Remover_btn.BackColor = System.Drawing.Color.Indigo
        Me.Remover_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Remover_btn.FlatAppearance.BorderSize = 0
        Me.Remover_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Remover_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Remover_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remover_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remover_btn.ForeColor = System.Drawing.Color.White
        Me.Remover_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.remove_key_24px
        Me.Remover_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Remover_btn.Location = New System.Drawing.Point(743, 414)
        Me.Remover_btn.Name = "Remover_btn"
        Me.Remover_btn.Size = New System.Drawing.Size(142, 34)
        Me.Remover_btn.TabIndex = 24
        Me.Remover_btn.Text = "Remover Banco"
        Me.Remover_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Remover_btn.UseVisualStyleBackColor = False
        '
        'Editar_btn
        '
        Me.Editar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Editar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Editar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Editar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Editar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar_btn.ForeColor = System.Drawing.Color.White
        Me.Editar_btn.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Edit_24px
        Me.Editar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Editar_btn.Location = New System.Drawing.Point(638, 414)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(99, 34)
        Me.Editar_btn.TabIndex = 25
        Me.Editar_btn.Text = "Alterar   "
        Me.Editar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Editar_btn.UseVisualStyleBackColor = False
        '
        'Bancos_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 460)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Remover_btn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Browser_btn)
        Me.Controls.Add(Me.Adicionar_btn)
        Me.Controls.Add(Me.Foto_lbl)
        Me.Controls.Add(Me.Foto_txb)
        Me.Controls.Add(Me.Nome_lbl)
        Me.Controls.Add(Me.Nome_txb)
        Me.Controls.Add(Me.Codigo_lbl)
        Me.Controls.Add(Me.Codigo_txb)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bancos_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos_Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Codigo_lbl As Label
    Friend WithEvents Codigo_txb As TextBox
    Friend WithEvents Nome_lbl As Label
    Friend WithEvents Nome_txb As TextBox
    Friend WithEvents Foto_lbl As Label
    Friend WithEvents Foto_txb As TextBox
    Friend WithEvents Adicionar_btn As Button
    Friend WithEvents Browser_btn As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Codigo_Banco As ColumnHeader
    Friend WithEvents Banco As ColumnHeader
    Friend WithEvents Foto As ColumnHeader
    Friend WithEvents Remover_btn As Button
    Friend WithEvents Editar_btn As Button
End Class
