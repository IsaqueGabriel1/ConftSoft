<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataPedido = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(57, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(199, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 46)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Pedidos"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnEnviar.Location = New System.Drawing.Point(137, 443)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(226, 39)
        Me.btnEnviar.TabIndex = 32
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Observações do pedido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(57, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Data do pedido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(118, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Celular:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nome do cliente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(118, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Pedido:"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Location = New System.Drawing.Point(207, 303)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(256, 116)
        Me.txtObs.TabIndex = 24
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.Location = New System.Drawing.Point(185, 152)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 20)
        Me.txtCliente.TabIndex = 21
        '
        'txtPedido
        '
        Me.txtPedido.BackColor = System.Drawing.Color.White
        Me.txtPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPedido.Location = New System.Drawing.Point(185, 107)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(278, 20)
        Me.txtPedido.TabIndex = 20
        '
        'txtCel
        '
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Location = New System.Drawing.Point(185, 206)
        Me.txtCel.Mask = "(99) 99000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(85, 20)
        Me.txtCel.TabIndex = 36
        '
        'txtDataPedido
        '
        Me.txtDataPedido.CalendarMonthBackground = System.Drawing.Color.White
        Me.txtDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataPedido.Location = New System.Drawing.Point(185, 254)
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.Size = New System.Drawing.Size(113, 20)
        Me.txtDataPedido.TabIndex = 37
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 507)
        Me.Controls.Add(Me.txtDataPedido)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents txtCel As MaskedTextBox
    Friend WithEvents txtDataPedido As DateTimePicker
End Class
