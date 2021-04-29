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
        Me.Superior_Panel = New System.Windows.Forms.Panel()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Minimize_Pic = New System.Windows.Forms.PictureBox()
        Me.Close_Pic = New System.Windows.Forms.PictureBox()
        Me.Pix_Icon_Pic = New System.Windows.Forms.PictureBox()
        Me.Lateral_Panel = New System.Windows.Forms.Panel()
        Me.Information_Pic = New System.Windows.Forms.PictureBox()
        Me.QR_Code_Banco_lbl = New System.Windows.Forms.Label()
        Me.Version_lbl = New System.Windows.Forms.Label()
        Me.QR_Code_lbl = New System.Windows.Forms.Label()
        Me.QR_Code_Pix_Pic = New System.Windows.Forms.PictureBox()
        Me.Remover_btn = New System.Windows.Forms.Button()
        Me.Adicionar_btn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel_Principal = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Banco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_Mensagem = New System.Windows.Forms.Panel()
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.Timer_Mensagem = New System.Windows.Forms.Timer(Me.components)
        Me.Superior_Panel.SuspendLayout()
        CType(Me.Minimize_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pix_Icon_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lateral_Panel.SuspendLayout()
        CType(Me.Information_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QR_Code_Pix_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Principal.SuspendLayout()
        Me.Panel_Mensagem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Superior_Panel
        '
        Me.Superior_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Superior_Panel.Controls.Add(Me.Title_Label)
        Me.Superior_Panel.Controls.Add(Me.Minimize_Pic)
        Me.Superior_Panel.Controls.Add(Me.Close_Pic)
        Me.Superior_Panel.Controls.Add(Me.Pix_Icon_Pic)
        Me.Superior_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Superior_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Superior_Panel.Name = "Superior_Panel"
        Me.Superior_Panel.Size = New System.Drawing.Size(750, 30)
        Me.Superior_Panel.TabIndex = 0
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.ForeColor = System.Drawing.Color.White
        Me.Title_Label.Location = New System.Drawing.Point(42, 8)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(298, 15)
        Me.Title_Label.TabIndex = 3
        Me.Title_Label.Text = "Pix Chaves Leatórias e Fixa - By Romulo Meirelles."
        '
        'Minimize_Pic
        '
        Me.Minimize_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimize_Pic.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Minimize
        Me.Minimize_Pic.Location = New System.Drawing.Point(684, 3)
        Me.Minimize_Pic.Name = "Minimize_Pic"
        Me.Minimize_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Minimize_Pic.TabIndex = 2
        Me.Minimize_Pic.TabStop = False
        '
        'Close_Pic
        '
        Me.Close_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Pic.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Close
        Me.Close_Pic.Location = New System.Drawing.Point(714, 3)
        Me.Close_Pic.Name = "Close_Pic"
        Me.Close_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Close_Pic.TabIndex = 1
        Me.Close_Pic.TabStop = False
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
        'Lateral_Panel
        '
        Me.Lateral_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Lateral_Panel.Controls.Add(Me.Information_Pic)
        Me.Lateral_Panel.Controls.Add(Me.QR_Code_Banco_lbl)
        Me.Lateral_Panel.Controls.Add(Me.Version_lbl)
        Me.Lateral_Panel.Controls.Add(Me.QR_Code_lbl)
        Me.Lateral_Panel.Controls.Add(Me.QR_Code_Pix_Pic)
        Me.Lateral_Panel.Controls.Add(Me.Remover_btn)
        Me.Lateral_Panel.Controls.Add(Me.Adicionar_btn)
        Me.Lateral_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lateral_Panel.Location = New System.Drawing.Point(0, 30)
        Me.Lateral_Panel.Name = "Lateral_Panel"
        Me.Lateral_Panel.Size = New System.Drawing.Size(170, 470)
        Me.Lateral_Panel.TabIndex = 1
        '
        'Information_Pic
        '
        Me.Information_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Information_Pic.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.information_24px
        Me.Information_Pic.Location = New System.Drawing.Point(138, 438)
        Me.Information_Pic.Name = "Information_Pic"
        Me.Information_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Information_Pic.TabIndex = 9
        Me.Information_Pic.TabStop = False
        '
        'QR_Code_Banco_lbl
        '
        Me.QR_Code_Banco_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QR_Code_Banco_lbl.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.QR_Code_Banco_lbl.Location = New System.Drawing.Point(22, 329)
        Me.QR_Code_Banco_lbl.Name = "QR_Code_Banco_lbl"
        Me.QR_Code_Banco_lbl.Size = New System.Drawing.Size(128, 13)
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
        Me.Version_lbl.Location = New System.Drawing.Point(12, 448)
        Me.Version_lbl.Name = "Version_lbl"
        Me.Version_lbl.Size = New System.Drawing.Size(81, 13)
        Me.Version_lbl.TabIndex = 7
        Me.Version_lbl.Text = "Version: 0.0.0.0"
        '
        'QR_Code_lbl
        '
        Me.QR_Code_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QR_Code_lbl.AutoSize = True
        Me.QR_Code_lbl.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.QR_Code_lbl.Location = New System.Drawing.Point(41, 176)
        Me.QR_Code_lbl.Name = "QR_Code_lbl"
        Me.QR_Code_lbl.Size = New System.Drawing.Size(95, 13)
        Me.QR_Code_lbl.TabIndex = 6
        Me.QR_Code_lbl.Tag = " "
        Me.QR_Code_lbl.Text = "QR Code. (Celular)"
        Me.QR_Code_lbl.Visible = False
        '
        'QR_Code_Pix_Pic
        '
        Me.QR_Code_Pix_Pic.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QR_Code_Pix_Pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QR_Code_Pix_Pic.Location = New System.Drawing.Point(22, 195)
        Me.QR_Code_Pix_Pic.Name = "QR_Code_Pix_Pic"
        Me.QR_Code_Pix_Pic.Size = New System.Drawing.Size(128, 128)
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
        Me.Remover_btn.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.remove_key_24px
        Me.Remover_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Remover_btn.Location = New System.Drawing.Point(12, 79)
        Me.Remover_btn.Name = "Remover_btn"
        Me.Remover_btn.Size = New System.Drawing.Size(146, 54)
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
        Me.Adicionar_btn.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.add_key_24px
        Me.Adicionar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adicionar_btn.Location = New System.Drawing.Point(12, 19)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(146, 54)
        Me.Adicionar_btn.TabIndex = 3
        Me.Adicionar_btn.Text = "Adicionar"
        Me.Adicionar_btn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Pix - Chaves Leatórias e Fixa."
        Me.NotifyIcon1.Visible = True
        '
        'Panel_Principal
        '
        Me.Panel_Principal.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Principal.Controls.Add(Me.ListView1)
        Me.Panel_Principal.Controls.Add(Me.Panel_Mensagem)
        Me.Panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Principal.Location = New System.Drawing.Point(170, 30)
        Me.Panel_Principal.Name = "Panel_Principal"
        Me.Panel_Principal.Size = New System.Drawing.Size(580, 470)
        Me.Panel_Principal.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ListView1.BackgroundImage = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Pix_480_370
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Banco, Me.Chave})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 18)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(580, 452)
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
        'Chave
        '
        Me.Chave.Text = "Chave"
        Me.Chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Chave.Width = 310
        '
        'Panel_Mensagem
        '
        Me.Panel_Mensagem.Controls.Add(Me.Mensagem_lbl)
        Me.Panel_Mensagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Mensagem.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Mensagem.Name = "Panel_Mensagem"
        Me.Panel_Mensagem.Size = New System.Drawing.Size(580, 18)
        Me.Panel_Mensagem.TabIndex = 5
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Mensagem_lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mensagem_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.Red
        Me.Mensagem_lbl.Location = New System.Drawing.Point(0, 0)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(580, 18)
        Me.Mensagem_lbl.TabIndex = 0
        Me.Mensagem_lbl.Text = "Dê 2 cliques para copiar a chave."
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_Mensagem
        '
        Me.Timer_Mensagem.Interval = 3000
        '
        'Pix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Principal)
        Me.Controls.Add(Me.Lateral_Panel)
        Me.Controls.Add(Me.Superior_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pix Chaves - By Romulo Meirelles."
        Me.Superior_Panel.ResumeLayout(False)
        Me.Superior_Panel.PerformLayout()
        CType(Me.Minimize_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pix_Icon_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lateral_Panel.ResumeLayout(False)
        Me.Lateral_Panel.PerformLayout()
        CType(Me.Information_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QR_Code_Pix_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Principal.ResumeLayout(False)
        Me.Panel_Mensagem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Superior_Panel As System.Windows.Forms.Panel
    Friend WithEvents Lateral_Panel As System.Windows.Forms.Panel
    Friend WithEvents Pix_Icon_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Close_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents Minimize_Pic As System.Windows.Forms.PictureBox
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
    Friend WithEvents Timer_Mensagem As System.Windows.Forms.Timer
    Friend WithEvents QR_Code_Pix_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents QR_Code_lbl As System.Windows.Forms.Label
    Friend WithEvents Version_lbl As System.Windows.Forms.Label
    Friend WithEvents QR_Code_Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents Information_Pic As System.Windows.Forms.PictureBox

End Class
