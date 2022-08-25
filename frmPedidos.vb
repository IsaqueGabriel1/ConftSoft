Public Class frmPedidos

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtCel.Text = "" Or txtCliente.Text = "" Or txtDataPedido.Text = "" Or txtObs.Text = "" Or txtPedido.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cliente (celularCliente, nomeCliente) values ('" & txtCel.Text & "', '" & txtCliente.Text & "')"
                sql2 = "insert into tb_pedidos (tipoPedido, dataPedido, obsPedido, statusPedido) values ('" & txtPedido.Text & "', '" & txtDataPedido.Text & "', '" & txtObs.Text & "', 'Espera')"
                rs = db.Execute(sql)
                rs = db.Execute(sql2)
                MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limparcampos()
            End If
        Catch ex As Exception
            MsgBox("Verifique os campos ", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
    End Sub

    Sub limparcampos()
        txtCel.Text = ""
        txtCliente.Text = ""
        txtObs.Text = ""
        txtPedido.Text = ""
    End Sub

    Private Sub btnEnviar_MouseLeave(sender As Object, e As EventArgs) Handles btnEnviar.MouseLeave
        btnEnviar.BackColor = Color.FromArgb(227, 161, 152)
        btnEnviar.ForeColor = Color.FromArgb(211, 104, 90)
    End Sub

    Private Sub btnEnviar_MouseHover(sender As Object, e As EventArgs) Handles btnEnviar.MouseHover
        btnEnviar.BackColor = Color.White
        btnEnviar.ForeColor = Color.FromArgb(211, 104, 90)
    End Sub
End Class