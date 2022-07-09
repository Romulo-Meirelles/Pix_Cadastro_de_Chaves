<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensagem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mensagem))
        Me.Control_TaskBar_Top1 = New ToolsBox.Control_TaskBar_Top()
        Me.Mensagem_lbl = New System.Windows.Forms.Label()
        Me.Fechar_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Yes_btn = New System.Windows.Forms.Button()
        Me.No_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Control_TaskBar_Top1.Size = New System.Drawing.Size(418, 32)
        Me.Control_TaskBar_Top1.TabIndex = 15
        Me.Control_TaskBar_Top1.TaskBarClickRightMenu = False
        Me.Control_TaskBar_Top1.TaskColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Control_TaskBar_Top1.TitleColor = System.Drawing.Color.White
        Me.Control_TaskBar_Top1.TitleEnable = True
        Me.Control_TaskBar_Top1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Control_TaskBar_Top1.TitleText = "Mensagem."
        Me.Control_TaskBar_Top1.ToolTip = True
        '
        'Mensagem_lbl
        '
        Me.Mensagem_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensagem_lbl.ForeColor = System.Drawing.Color.White
        Me.Mensagem_lbl.Location = New System.Drawing.Point(74, 48)
        Me.Mensagem_lbl.Name = "Mensagem_lbl"
        Me.Mensagem_lbl.Size = New System.Drawing.Size(312, 100)
        Me.Mensagem_lbl.TabIndex = 16
        Me.Mensagem_lbl.Text = "Texto da Mensagem"
        Me.Mensagem_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fechar_btn
        '
        Me.Fechar_btn.BackColor = System.Drawing.Color.Indigo
        Me.Fechar_btn.FlatAppearance.BorderSize = 0
        Me.Fechar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Fechar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Fechar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fechar_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar_btn.ForeColor = System.Drawing.Color.White
        Me.Fechar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Fechar_btn.Location = New System.Drawing.Point(323, 156)
        Me.Fechar_btn.Name = "Fechar_btn"
        Me.Fechar_btn.Size = New System.Drawing.Size(83, 35)
        Me.Fechar_btn.TabIndex = 0
        Me.Fechar_btn.Text = "Fechar"
        Me.Fechar_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pix_Inovation_Chaves_Leatoria_e_Fixa.My.Resources.Resources.ok_50px
        Me.PictureBox1.Location = New System.Drawing.Point(20, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Yes_btn
        '
        Me.Yes_btn.BackColor = System.Drawing.Color.Indigo
        Me.Yes_btn.FlatAppearance.BorderSize = 0
        Me.Yes_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Yes_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Yes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Yes_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Yes_btn.ForeColor = System.Drawing.Color.LightGreen
        Me.Yes_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Yes_btn.Location = New System.Drawing.Point(124, 156)
        Me.Yes_btn.Name = "Yes_btn"
        Me.Yes_btn.Size = New System.Drawing.Size(83, 35)
        Me.Yes_btn.TabIndex = 1
        Me.Yes_btn.Text = "Sim"
        Me.Yes_btn.UseVisualStyleBackColor = False
        Me.Yes_btn.Visible = False
        '
        'No_btn
        '
        Me.No_btn.BackColor = System.Drawing.Color.Indigo
        Me.No_btn.FlatAppearance.BorderSize = 0
        Me.No_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.No_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.No_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.No_btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_btn.ForeColor = System.Drawing.Color.LightCoral
        Me.No_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.No_btn.Location = New System.Drawing.Point(229, 156)
        Me.No_btn.Name = "No_btn"
        Me.No_btn.Size = New System.Drawing.Size(83, 35)
        Me.No_btn.TabIndex = 2
        Me.No_btn.Text = "Não"
        Me.No_btn.UseVisualStyleBackColor = False
        Me.No_btn.Visible = False
        '
        'Mensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 201)
        Me.Controls.Add(Me.No_btn)
        Me.Controls.Add(Me.Yes_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Fechar_btn)
        Me.Controls.Add(Me.Mensagem_lbl)
        Me.Controls.Add(Me.Control_TaskBar_Top1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mensagem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensagem."
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Control_TaskBar_Top1 As ToolsBox.Control_TaskBar_Top
    Friend WithEvents Mensagem_lbl As Label
    Friend WithEvents Fechar_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Yes_btn As Button
    Friend WithEvents No_btn As Button
End Class
