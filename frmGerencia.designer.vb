<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerencia))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cb_verSenha = New System.Windows.Forms.CheckBox()
        Me.txt_confiSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txt_nivelAcesso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomeUser = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnAjudaEstoque = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtEstoque = New System.Windows.Forms.ToolStripTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGerarRelátorio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAjudaFun = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dvg_controle = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dvg_controle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-6, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(119, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(861, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.lblCadastro)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(853, 422)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Cadastro"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Location = New System.Drawing.Point(812, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 24)
        Me.Panel2.TabIndex = 5
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.BackColor = System.Drawing.Color.Transparent
        Me.lblCadastro.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblCadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblCadastro.Location = New System.Drawing.Point(337, 64)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(191, 54)
        Me.lblCadastro.TabIndex = 4
        Me.lblCadastro.Text = "Cadastro"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.cb_verSenha)
        Me.Panel1.Controls.Add(Me.txt_confiSenha)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.btnEnviar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Controls.Add(Me.txt_nivelAcesso)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_nomeUser)
        Me.Panel1.Location = New System.Drawing.Point(14, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 257)
        Me.Panel1.TabIndex = 1
        '
        'cb_verSenha
        '
        Me.cb_verSenha.AutoSize = True
        Me.cb_verSenha.BackColor = System.Drawing.Color.Transparent
        Me.cb_verSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.cb_verSenha.Location = New System.Drawing.Point(612, 130)
        Me.cb_verSenha.Name = "cb_verSenha"
        Me.cb_verSenha.Size = New System.Drawing.Size(74, 17)
        Me.cb_verSenha.TabIndex = 15
        Me.cb_verSenha.Text = "Ver senha"
        Me.cb_verSenha.UseVisualStyleBackColor = False
        '
        'txt_confiSenha
        '
        Me.txt_confiSenha.BackColor = System.Drawing.Color.White
        Me.txt_confiSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_confiSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confiSenha.ForeColor = System.Drawing.Color.Black
        Me.txt_confiSenha.Location = New System.Drawing.Point(440, 132)
        Me.txt_confiSenha.Name = "txt_confiSenha"
        Me.txt_confiSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confiSenha.Size = New System.Drawing.Size(165, 16)
        Me.txt_confiSenha.TabIndex = 14
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.White
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.ForeColor = System.Drawing.Color.Black
        Me.txt_senha.Location = New System.Drawing.Point(440, 71)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(165, 16)
        Me.txt_senha.TabIndex = 5
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.White
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEnviar.Location = New System.Drawing.Point(627, 181)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(168, 36)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(39, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nivel de acesso"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.White
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSair.Location = New System.Drawing.Point(437, 181)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(168, 36)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'txt_nivelAcesso
        '
        Me.txt_nivelAcesso.BackColor = System.Drawing.Color.White
        Me.txt_nivelAcesso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nivelAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nivelAcesso.ForeColor = System.Drawing.Color.Black
        Me.txt_nivelAcesso.Location = New System.Drawing.Point(39, 200)
        Me.txt_nivelAcesso.Name = "txt_nivelAcesso"
        Me.txt_nivelAcesso.Size = New System.Drawing.Size(358, 16)
        Me.txt_nivelAcesso.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(437, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Confirmar senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(437, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(42, 135)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(358, 16)
        Me.txt_email.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nome do usuario"
        '
        'txt_nomeUser
        '
        Me.txt_nomeUser.BackColor = System.Drawing.Color.White
        Me.txt_nomeUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nomeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeUser.ForeColor = System.Drawing.Color.Black
        Me.txt_nomeUser.Location = New System.Drawing.Point(42, 71)
        Me.txt_nomeUser.Name = "txt_nomeUser"
        Me.txt_nomeUser.Size = New System.Drawing.Size(358, 16)
        Me.txt_nomeUser.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.btnAjudaEstoque)
        Me.TabPage4.Controls.Add(Me.ToolStrip2)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.btnGerarRelátorio)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.btnExit)
        Me.TabPage4.Controls.Add(Me.dgv_dados)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(853, 422)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Estoque"
        '
        'btnAjudaEstoque
        '
        Me.btnAjudaEstoque.BackgroundImage = CType(resources.GetObject("btnAjudaEstoque.BackgroundImage"), System.Drawing.Image)
        Me.btnAjudaEstoque.Location = New System.Drawing.Point(814, 28)
        Me.btnAjudaEstoque.Name = "btnAjudaEstoque"
        Me.btnAjudaEstoque.Size = New System.Drawing.Size(24, 24)
        Me.btnAjudaEstoque.TabIndex = 26
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txtEstoque})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(853, 25)
        Me.ToolStrip2.TabIndex = 25
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripLabel2.Text = "DIGITE UM PARÂMETRO DE BUSCA:"
        '
        'txtEstoque
        '
        Me.txtEstoque.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(100, 25)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(338, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 54)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Estoque"
        '
        'btnGerarRelátorio
        '
        Me.btnGerarRelátorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnGerarRelátorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerarRelátorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerarRelátorio.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGerarRelátorio.ForeColor = System.Drawing.Color.White
        Me.btnGerarRelátorio.Location = New System.Drawing.Point(344, 370)
        Me.btnGerarRelátorio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGerarRelátorio.Name = "btnGerarRelátorio"
        Me.btnGerarRelátorio.Size = New System.Drawing.Size(175, 36)
        Me.btnGerarRelátorio.TabIndex = 17
        Me.btnGerarRelátorio.Text = "Relatório"
        Me.btnGerarRelátorio.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(112, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(577, 370)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Sair"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados.GridColor = System.Drawing.Color.Black
        Me.dgv_dados.Location = New System.Drawing.Point(131, 176)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(586, 172)
        Me.dgv_dados.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "nome produto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 89
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "marca"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 61
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "quantidade/peso"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 113
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "data de vencimento"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 140
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "descriçao do produto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 140
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnAjudaFun)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.dvg_controle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(853, 422)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Funcionarios"
        '
        'btnAjudaFun
        '
        Me.btnAjudaFun.BackgroundImage = CType(resources.GetObject("btnAjudaFun.BackgroundImage"), System.Drawing.Image)
        Me.btnAjudaFun.Location = New System.Drawing.Point(814, 28)
        Me.btnAjudaFun.Name = "btnAjudaFun"
        Me.btnAjudaFun.Size = New System.Drawing.Size(24, 24)
        Me.btnAjudaFun.TabIndex = 27
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(853, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(206, 22)
        Me.ToolStripLabel1.Text = "DIGITE UM PARÂMETRO DE BUSCA:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(68, 25)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(183, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(486, 54)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Controle de funcionarios"
        '
        'dvg_controle
        '
        Me.dvg_controle.AllowUserToAddRows = False
        Me.dvg_controle.AllowUserToDeleteRows = False
        Me.dvg_controle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_controle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewImageColumn1, Me.Column6})
        Me.dvg_controle.Location = New System.Drawing.Point(92, 226)
        Me.dvg_controle.Name = "dvg_controle"
        Me.dvg_controle.ReadOnly = True
        Me.dvg_controle.Size = New System.Drawing.Size(664, 150)
        Me.dvg_controle.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome Usuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nivel de acesso"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Delete"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Redefinir senha"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frmGerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Área do gerente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dvg_controle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nivelAcesso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nomeUser As TextBox
    Friend WithEvents lblCadastro As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGerarRelátorio As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents txt_confiSenha As MaskedTextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dvg_controle As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtEstoque As ToolStripTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents cb_verSenha As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAjudaEstoque As Panel
    Friend WithEvents btnAjudaFun As Panel
End Class
