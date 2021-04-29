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
        Me.Close_Pic = New System.Windows.Forms.PictureBox()
        Me.Bancos_Images = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Banco_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Banco_Cbx
        '
        Me.Banco_Cbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Banco_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Banco_Cbx.Location = New System.Drawing.Point(26, 36)
        Me.Banco_Cbx.Name = "Banco_Cbx"
        Me.Banco_Cbx.Size = New System.Drawing.Size(185, 21)
        Me.Banco_Cbx.TabIndex = 0
        '
        'Chave_Pix_txt
        '
        Me.Chave_Pix_txt.Location = New System.Drawing.Point(26, 91)
        Me.Chave_Pix_txt.Name = "Chave_Pix_txt"
        Me.Chave_Pix_txt.Size = New System.Drawing.Size(204, 20)
        Me.Chave_Pix_txt.TabIndex = 1
        '
        'Banco_lbl
        '
        Me.Banco_lbl.AutoSize = True
        Me.Banco_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Banco_lbl.ForeColor = System.Drawing.Color.White
        Me.Banco_lbl.Location = New System.Drawing.Point(23, 17)
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
        Me.Chave_Pix_lbl.Location = New System.Drawing.Point(23, 72)
        Me.Chave_Pix_lbl.Name = "Chave_Pix_lbl"
        Me.Chave_Pix_lbl.Size = New System.Drawing.Size(70, 15)
        Me.Chave_Pix_lbl.TabIndex = 3
        Me.Chave_Pix_lbl.Text = "Chave Pix:"
        '
        'Banco_Pic
        '
        Me.Banco_Pic.Location = New System.Drawing.Point(244, 27)
        Me.Banco_Pic.Name = "Banco_Pic"
        Me.Banco_Pic.Size = New System.Drawing.Size(74, 74)
        Me.Banco_Pic.TabIndex = 4
        Me.Banco_Pic.TabStop = False
        '
        'Adicionar_btn
        '
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
        Me.Adicionar_btn.Location = New System.Drawing.Point(244, 108)
        Me.Adicionar_btn.Name = "Adicionar_btn"
        Me.Adicionar_btn.Size = New System.Drawing.Size(101, 34)
        Me.Adicionar_btn.TabIndex = 5
        Me.Adicionar_btn.Text = "Adicionar"
        Me.Adicionar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Adicionar_btn.UseVisualStyleBackColor = False
        '
        'Close_Pic
        '
        Me.Close_Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Pic.Image = Global.Pix_Chaves_Leatoria_e_Fixa.My.Resources.Resources.Close
        Me.Close_Pic.Location = New System.Drawing.Point(323, 3)
        Me.Close_Pic.Name = "Close_Pic"
        Me.Close_Pic.Size = New System.Drawing.Size(24, 24)
        Me.Close_Pic.TabIndex = 6
        Me.Close_Pic.TabStop = False
        '
        'Bancos_Images
        '
        Me.Bancos_Images.ImageStream = CType(resources.GetObject("Bancos_Images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Bancos_Images.TransparentColor = System.Drawing.Color.Transparent
        Me.Bancos_Images.Images.SetKeyName(0, "Bradesco.jpg")
        Me.Bancos_Images.Images.SetKeyName(1, "Santander.png")
        Me.Bancos_Images.Images.SetKeyName(2, "Itau.png")
        Me.Bancos_Images.Images.SetKeyName(3, "Hsbc.png")
        Me.Bancos_Images.Images.SetKeyName(4, "Caixa.jpg")
        Me.Bancos_Images.Images.SetKeyName(5, "Banco_Do_Brasil.png")
        Me.Bancos_Images.Images.SetKeyName(6, "Original.jpg")
        Me.Bancos_Images.Images.SetKeyName(7, "Nubank.jpg")
        Me.Bancos_Images.Images.SetKeyName(8, "Inter.jpg")
        Me.Bancos_Images.Images.SetKeyName(9, "C6.png")
        Me.Bancos_Images.Images.SetKeyName(10, "Neon.jpg")
        Me.Bancos_Images.Images.SetKeyName(11, "BS2.jpg")
        Me.Bancos_Images.Images.SetKeyName(12, "PagBank.jpg")
        Me.Bancos_Images.Images.SetKeyName(13, "Next.png")
        Me.Bancos_Images.Images.SetKeyName(14, "PicPay.jpg")
        Me.Bancos_Images.Images.SetKeyName(15, "MercadoPago.png")
        Me.Bancos_Images.Images.SetKeyName(16, "RecargaPay.jpg")
        Me.Bancos_Images.Images.SetKeyName(17, "download.png")
        '
        'Adicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(352, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.Close_Pic)
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
        CType(Me.Close_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_Cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Chave_Pix_txt As System.Windows.Forms.TextBox
    Friend WithEvents Banco_lbl As System.Windows.Forms.Label
    Friend WithEvents Chave_Pix_lbl As System.Windows.Forms.Label
    Friend WithEvents Banco_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Adicionar_btn As System.Windows.Forms.Button
    Friend WithEvents Close_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Bancos_Images As System.Windows.Forms.ImageList
End Class
