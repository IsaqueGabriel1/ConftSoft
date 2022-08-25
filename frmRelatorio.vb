Public Class frmRelatorio
    Private Sub frmRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_retiradas()
        conecta_bd()
    End Sub

    Private Sub ToolStripTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtData.TextChanged
        sql = "SELECT tipoPedido,retirada, produto, quantidadeRetirada, horaRetirada, [Email] FROM retirada_produtos, tb_pedidos where numeroPedido = pedido and horaRetirada like '" & txtData.Text & "%'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            With dvg_retiradas
                cont = 0
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Else
            carregar_retiradas()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        sql = "SELECT tipoPedido,retirada, produto, quantidadeRetirada, horaRetirada, [Email] FROM retirada_produtos, tb_pedidos where numeroPedido = pedido and Email like '" & txtEmail.Text & "%'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            With dvg_retiradas
                cont = 0
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Else
            carregar_retiradas()
        End If
    End Sub
End Class