<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorio))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtEmail = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtData = New System.Windows.Forms.ToolStripTextBox()
        Me.dvg_retiradas = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dvg_retiradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtEmail, Me.ToolStripLabel3, Me.txtData})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(630, 25)
        Me.ToolStrip2.TabIndex = 26
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripLabel1.Text = "Email cozinheiro:"
        '
        'txtEmail
        '
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(68, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ActiveLinkColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel3.Text = "Pesquisar por Data:"
        '
        'txtData
        '
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(68, 25)
        '
        'dvg_retiradas
        '
        Me.dvg_retiradas.BackgroundColor = System.Drawing.Color.White
        Me.dvg_retiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_retiradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dvg_retiradas.Location = New System.Drawing.Point(12, 179)
        Me.dvg_retiradas.Name = "dvg_retiradas"
        Me.dvg_retiradas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvg_retiradas.Size = New System.Drawing.Size(607, 259)
        Me.dvg_retiradas.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(95, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(441, 54)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Retiradas de produtos"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Pedido"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 110
        '
        'Column1
        '
        Me.Column1.HeaderText = "Email cozinheiro"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 110
        '
        'Column2
        '
        Me.Column2.HeaderText = "Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 110
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 110
        '
        'Column4
        '
        Me.Column4.HeaderText = "Data retirada"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 123
        '
        'frmRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(630, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dvg_retiradas)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dvg_retiradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtData As ToolStripTextBox
    Friend WithEvents dvg_retiradas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtEmail As ToolStripTextBox
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
