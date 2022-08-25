<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAreaChefeCozinha
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreaChefeCozinha))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblStatus_ = New System.Windows.Forms.Label()
        Me.lblNumPedido_ = New System.Windows.Forms.Label()
        Me.btnPedidoAceito_ = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnProximoPedido_ = New System.Windows.Forms.Button()
        Me.btnPedidoAnterior_ = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblobsPedido_ = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NomePedido = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.statusPedido = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnProximoPedido = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQntP = New System.Windows.Forms.TextBox()
        Me.btnRetirarEstoque = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Pedido = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblDataPedido_ = New System.Windows.Forms.Label()
        Me.lblPedido_ = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-12, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(84, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(535, 660)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.lblStatus_)
        Me.TabPage4.Controls.Add(Me.lblNumPedido_)
        Me.TabPage4.Controls.Add(Me.btnPedidoAceito_)
        Me.TabPage4.Controls.Add(Me.btnSair)
        Me.TabPage4.Controls.Add(Me.btnProximoPedido_)
        Me.TabPage4.Controls.Add(Me.btnPedidoAnterior_)
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.NomePedido)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(527, 620)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Visualizar pedido"
        '
        'lblStatus_
        '
        Me.lblStatus_.AutoSize = True
        Me.lblStatus_.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus_.ForeColor = System.Drawing.Color.White
        Me.lblStatus_.Location = New System.Drawing.Point(49, 98)
        Me.lblStatus_.Name = "lblStatus_"
        Me.lblStatus_.Size = New System.Drawing.Size(291, 20)
        Me.lblStatus_.TabIndex = 20
        Me.lblStatus_.Text = "Esse pedido ja está em andamento"
        Me.lblStatus_.Visible = False
        '
        'lblNumPedido_
        '
        Me.lblNumPedido_.AutoSize = True
        Me.lblNumPedido_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumPedido_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblNumPedido_.Location = New System.Drawing.Point(425, 49)
        Me.lblNumPedido_.Name = "lblNumPedido_"
        Me.lblNumPedido_.Size = New System.Drawing.Size(19, 21)
        Me.lblNumPedido_.TabIndex = 19
        Me.lblNumPedido_.Text = "0"
        '
        'btnPedidoAceito_
        '
        Me.btnPedidoAceito_.BackColor = System.Drawing.Color.White
        Me.btnPedidoAceito_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidoAceito_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPedidoAceito_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnPedidoAceito_.Location = New System.Drawing.Point(158, 547)
        Me.btnPedidoAceito_.Name = "btnPedidoAceito_"
        Me.btnPedidoAceito_.Size = New System.Drawing.Size(294, 37)
        Me.btnPedidoAceito_.TabIndex = 18
        Me.btnPedidoAceito_.Text = "Pedido aceito"
        Me.btnPedidoAceito_.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSair.Location = New System.Drawing.Point(82, 547)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(70, 37)
        Me.btnSair.TabIndex = 17
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnProximoPedido_
        '
        Me.btnProximoPedido_.BackColor = System.Drawing.Color.White
        Me.btnProximoPedido_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProximoPedido_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProximoPedido_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnProximoPedido_.Location = New System.Drawing.Point(255, 505)
        Me.btnProximoPedido_.Name = "btnProximoPedido_"
        Me.btnProximoPedido_.Size = New System.Drawing.Size(197, 37)
        Me.btnProximoPedido_.TabIndex = 16
        Me.btnProximoPedido_.Text = "Proximo pedido"
        Me.btnProximoPedido_.UseVisualStyleBackColor = False
        '
        'btnPedidoAnterior_
        '
        Me.btnPedidoAnterior_.BackColor = System.Drawing.Color.White
        Me.btnPedidoAnterior_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidoAnterior_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPedidoAnterior_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnPedidoAnterior_.Location = New System.Drawing.Point(82, 505)
        Me.btnPedidoAnterior_.Name = "btnPedidoAnterior_"
        Me.btnPedidoAnterior_.Size = New System.Drawing.Size(167, 37)
        Me.btnPedidoAnterior_.TabIndex = 15
        Me.btnPedidoAnterior_.Text = "Voltar pedido"
        Me.btnPedidoAnterior_.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.lblobsPedido_)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(53, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 216)
        Me.Panel3.TabIndex = 14
        '
        'lblobsPedido_
        '
        Me.lblobsPedido_.BackColor = System.Drawing.Color.Transparent
        Me.lblobsPedido_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblobsPedido_.ForeColor = System.Drawing.Color.White
        Me.lblobsPedido_.Location = New System.Drawing.Point(25, 16)
        Me.lblobsPedido_.Name = "lblobsPedido_"
        Me.lblobsPedido_.Size = New System.Drawing.Size(372, 186)
        Me.lblobsPedido_.TabIndex = 0
        Me.lblobsPedido_.Text = "Observações do pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(389, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nº"
        '
        'NomePedido
        '
        Me.NomePedido.AutoSize = True
        Me.NomePedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NomePedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.NomePedido.Location = New System.Drawing.Point(49, 49)
        Me.NomePedido.Name = "NomePedido"
        Me.NomePedido.Size = New System.Drawing.Size(187, 21)
        Me.NomePedido.TabIndex = 11
        Me.NomePedido.Text = "Informações do pedido"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.statusPedido)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnProximoPedido)
        Me.TabPage2.Controls.Add(Me.btnVoltar)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtQntP)
        Me.TabPage2.Controls.Add(Me.btnRetirarEstoque)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtQnt)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Pedido)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblNumeroPedido)
        Me.TabPage2.Controls.Add(Me.label)
        Me.TabPage2.Controls.Add(Me.lblPedido)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(527, 620)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Retirada de ingredientes"
        '
        'statusPedido
        '
        Me.statusPedido.AutoSize = True
        Me.statusPedido.BackColor = System.Drawing.Color.White
        Me.statusPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.statusPedido.Location = New System.Drawing.Point(188, 220)
        Me.statusPedido.Name = "statusPedido"
        Me.statusPedido.Size = New System.Drawing.Size(159, 17)
        Me.statusPedido.TabIndex = 37
        Me.statusPedido.Text = "Selecione um pedido"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(77, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Status Pedido:"
        '
        'btnProximoPedido
        '
        Me.btnProximoPedido.BackColor = System.Drawing.Color.White
        Me.btnProximoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProximoPedido.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnProximoPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnProximoPedido.Location = New System.Drawing.Point(411, 220)
        Me.btnProximoPedido.Name = "btnProximoPedido"
        Me.btnProximoPedido.Size = New System.Drawing.Size(85, 29)
        Me.btnProximoPedido.TabIndex = 35
        Me.btnProximoPedido.Text = "Proximo"
        Me.btnProximoPedido.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.White
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnVoltar.Location = New System.Drawing.Point(411, 255)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(85, 29)
        Me.btnVoltar.TabIndex = 34
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(239, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "De"
        '
        'txtQntP
        '
        Me.txtQntP.Enabled = False
        Me.txtQntP.Location = New System.Drawing.Point(272, 343)
        Me.txtQntP.Name = "txtQntP"
        Me.txtQntP.Size = New System.Drawing.Size(58, 20)
        Me.txtQntP.TabIndex = 32
        '
        'btnRetirarEstoque
        '
        Me.btnRetirarEstoque.BackColor = System.Drawing.Color.White
        Me.btnRetirarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirarEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetirarEstoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnRetirarEstoque.Location = New System.Drawing.Point(151, 474)
        Me.btnRetirarEstoque.Name = "btnRetirarEstoque"
        Me.btnRetirarEstoque.Size = New System.Drawing.Size(238, 39)
        Me.btnRetirarEstoque.TabIndex = 30
        Me.btnRetirarEstoque.Text = "Retirar ingredientes"
        Me.btnRetirarEstoque.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(82, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(174, 385)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(77, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Quantidade:"
        '
        'txtQnt
        '
        Me.txtQnt.Location = New System.Drawing.Point(174, 343)
        Me.txtQnt.Name = "txtQnt"
        Me.txtQnt.Size = New System.Drawing.Size(58, 20)
        Me.txtQnt.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(79, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Ingrediente:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 297)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'Pedido
        '
        Me.Pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Pedido.Location = New System.Drawing.Point(148, 262)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(226, 21)
        Me.Pedido.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(82, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Pedido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Retirda de ingredientes"
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumeroPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(526, -32)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(19, 21)
        Me.lblNumeroPedido.TabIndex = 19
        Me.lblNumeroPedido.Text = "0"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label.Location = New System.Drawing.Point(490, -32)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(30, 21)
        Me.label.TabIndex = 12
        Me.label.Text = "Nº"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPedido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblPedido.Location = New System.Drawing.Point(179, -32)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(187, 21)
        Me.lblPedido.TabIndex = 11
        Me.lblPedido.Text = "Informações do pedido"
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(0, 0)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(200, 100)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Visualizar pedidos"
        '
        'lblDataPedido_
        '
        Me.lblDataPedido_.BackColor = System.Drawing.Color.Transparent
        Me.lblDataPedido_.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDataPedido_.ForeColor = System.Drawing.Color.White
        Me.lblDataPedido_.Location = New System.Drawing.Point(219, 26)
        Me.lblDataPedido_.Name = "lblDataPedido_"
        Me.lblDataPedido_.Size = New System.Drawing.Size(172, 21)
        Me.lblDataPedido_.TabIndex = 0
        Me.lblDataPedido_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPedido_
        '
        Me.lblPedido_.AutoSize = True
        Me.lblPedido_.BackColor = System.Drawing.Color.Transparent
        Me.lblPedido_.ForeColor = System.Drawing.Color.White
        Me.lblPedido_.Location = New System.Drawing.Point(51, 26)
        Me.lblPedido_.Name = "lblPedido_"
        Me.lblPedido_.Size = New System.Drawing.Size(171, 21)
        Me.lblPedido_.TabIndex = 1
        Me.lblPedido_.Text = "Pedido realizado em:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.lblPedido_)
        Me.Panel4.Controls.Add(Me.lblDataPedido_)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(53, 154)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(420, 68)
        Me.Panel4.TabIndex = 13
        '
        'frmAreaChefeCozinha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAreaChefeCozinha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chefe de cozinha"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblStatus_ As Label
    Friend WithEvents lblNumPedido_ As Label
    Friend WithEvents btnPedidoAceito_ As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnProximoPedido_ As Button
    Friend WithEvents btnPedidoAnterior_ As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblobsPedido_ As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NomePedido As Label
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents label As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQnt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Pedido As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRetirarEstoque As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQntP As TextBox
    Friend WithEvents btnProximoPedido As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents statusPedido As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPedido_ As Label
    Friend WithEvents lblDataPedido_ As Label
End Class
