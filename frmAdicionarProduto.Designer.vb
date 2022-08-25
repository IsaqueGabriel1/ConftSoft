<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarProduto))
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQntPeso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.txtVencimento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Location = New System.Drawing.Point(49, 143)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.Size = New System.Drawing.Size(205, 20)
        Me.txtNomeProduto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(264, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marca do produto"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(267, 143)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(154, 20)
        Me.txtMarca.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantidade/peso"
        '
        'txtQntPeso
        '
        Me.txtQntPeso.Location = New System.Drawing.Point(49, 193)
        Me.txtQntPeso.Name = "txtQntPeso"
        Me.txtQntPeso.Size = New System.Drawing.Size(205, 20)
        Me.txtQntPeso.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(264, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data de vencimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(46, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Descrição do produto"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(49, 249)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(178, 20)
        Me.txtDescricao.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(133, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Atualizar produtos"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.White
        Me.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnAtualizar.Location = New System.Drawing.Point(154, 308)
        Me.btnAtualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(175, 36)
        Me.btnAtualizar.TabIndex = 18
        Me.btnAtualizar.Text = "Enviar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'txtVencimento
        '
        Me.txtVencimento.CalendarMonthBackground = System.Drawing.Color.White
        Me.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtVencimento.Location = New System.Drawing.Point(267, 193)
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(100, 20)
        Me.txtVencimento.TabIndex = 38
        '
        'frmAdicionarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 363)
        Me.Controls.Add(Me.txtVencimento)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQntPeso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeProduto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdicionarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualizar produtos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomeProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQntPeso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents txtVencimento As DateTimePicker
End Class
