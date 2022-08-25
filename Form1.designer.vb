<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnLogar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_verSenha = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(153, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(96, 162)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(229, 23)
        Me.txtNome.TabIndex = 5
        '
        'btnLogar
        '
        Me.btnLogar.AccessibleName = "Clique aqui para logar"
        Me.btnLogar.BackColor = System.Drawing.Color.White
        Me.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnLogar.Location = New System.Drawing.Point(162, 263)
        Me.btnLogar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogar.Name = "btnLogar"
        Me.btnLogar.Size = New System.Drawing.Size(108, 28)
        Me.btnLogar.TabIndex = 8
        Me.btnLogar.Text = "Entrar"
        Me.btnLogar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.Location = New System.Drawing.Point(96, 216)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(229, 23)
        Me.txtSenha.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(93, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nome do usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(93, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Senha"
        '
        'cb_verSenha
        '
        Me.cb_verSenha.AutoSize = True
        Me.cb_verSenha.ForeColor = System.Drawing.Color.White
        Me.cb_verSenha.Location = New System.Drawing.Point(332, 221)
        Me.cb_verSenha.Name = "cb_verSenha"
        Me.cb_verSenha.Size = New System.Drawing.Size(74, 17)
        Me.cb_verSenha.TabIndex = 13
        Me.cb_verSenha.Text = "Ver senha"
        Me.cb_verSenha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 325)
        Me.Controls.Add(Me.cb_verSenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnLogar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNome)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnLogar As Button
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_verSenha As CheckBox
End Class
