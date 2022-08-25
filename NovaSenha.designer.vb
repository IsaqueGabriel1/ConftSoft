<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NovaSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovaSenha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSenha2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_senha = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Atualizar senha"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(125, 313)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(108, 27)
        Me.btnEnviar.TabIndex = 10
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Location = New System.Drawing.Point(44, 41)
        Me.txtNome.Multiline = True
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(229, 23)
        Me.txtNome.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome do Usuario"
        '
        'txtSenha1
        '
        Me.txtSenha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.txtSenha1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha1.Location = New System.Drawing.Point(44, 92)
        Me.txtSenha1.Multiline = True
        Me.txtSenha1.Name = "txtSenha1"
        Me.txtSenha1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha1.Size = New System.Drawing.Size(229, 23)
        Me.txtSenha1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nova senha"
        '
        'txtSenha2
        '
        Me.txtSenha2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.txtSenha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha2.Location = New System.Drawing.Point(44, 150)
        Me.txtSenha2.Multiline = True
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha2.Size = New System.Drawing.Size(229, 23)
        Me.txtSenha2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Repita a senha"
        '
        'cb_senha
        '
        Me.cb_senha.AutoSize = True
        Me.cb_senha.Location = New System.Drawing.Point(279, 159)
        Me.cb_senha.Name = "cb_senha"
        Me.cb_senha.Size = New System.Drawing.Size(15, 14)
        Me.cb_senha.TabIndex = 17
        Me.cb_senha.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cb_senha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSenha2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSenha1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Location = New System.Drawing.Point(22, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 200)
        Me.Panel1.TabIndex = 2
        '
        'NovaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 361)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NovaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova senha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSenha1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSenha2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_senha As CheckBox
    Friend WithEvents Panel1 As Panel
End Class
