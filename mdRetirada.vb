Module mdRetirada
    Public contRetirada As Integer
    Public numPedido As Integer
    Sub proximoPedido()
        contRetirada = contRetirada + 1
        With frmAreaChefeCozinha
            sql = "select * from tb_pedidos where numeroPedido = " & contRetirada & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                numPedido = rs.Fields(0).Value
            End If


            If contRetirada = 0 Then
                .btnVoltar.Enabled = False
            Else
                .btnVoltar.Enabled = True
            End If

            If rs.EOF = False Then
                .Pedido.Text = rs.Fields(1).Value
                .statusPedido.Text = rs.Fields(4).Value
            Else
                MsgBox("Não existe mais pedidos a serem carregados", MsgBoxStyle.Critical, "ATENÇÃO")
                contRetirada = contRetirada - 1
            End If
            .puxarEstoque()
        End With
    End Sub

    Sub pedidoAnterior()
        contRetirada = contRetirada - 1
        With frmAreaChefeCozinha
            sql = "select * from tb_pedidos where numeroPedido = " & contRetirada & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                numPedido = rs.Fields(0).Value
            End If


            If contRetirada = 0 Then
                .btnVoltar.Enabled = False
            Else
                .btnVoltar.Enabled = True
            End If

            If rs.EOF = False Then
                .Pedido.Text = rs.Fields(1).Value
                .statusPedido.Text = rs.Fields(4).Value
            Else
                MsgBox("Não existe mais pedidos a serem carregados", MsgBoxStyle.Critical, "ATENÇÃO")
                contRetirada = contRetirada + 1
            End If
            .puxarEstoque()
        End With
    End Sub


    Sub retirarEstoque()
        With frmAreaChefeCozinha
            Dim QuantidadeRetirada = 0
            Try
                If .txtEmail.Text = "" Or .txtQnt.Text = "" Then
                    MsgBox("Preecha todos os campos", MsgBoxStyle.Critical, "AVISO")
                Else
                    sql = "select * from tb_cadastro where Email = '" & .txtEmail.Text & "' and nivelAcesso = " & 2 & ""
                    rs = db.Execute(sql)
                    If .statusPedido.Text = "aceito" Then
                        If rs.EOF = True Then
                            MsgBox("Esse usuario não esta altorizado a retirar produtos do estoque", MsgBoxStyle.Critical, "ALERTA")
                        Else
                            QuantidadeRetirada = .txtQntP.Text - .txtQnt.Text
                            sql = "insert into retirada_produtos (pedido, produto, quantidadeRetirada, Email)  values(" & numPedido & ", '" & .ComboBox1.Text & "', '" & .txtQnt.Text & "', '" & .txtEmail.Text & "')"
                            sql2 = "update tb_estoque set qntEPeso = " & QuantidadeRetirada & " where nomeProduto = '" & .ComboBox1.Text & "'"
                            rs = db.Execute(sql)
                            rs = db.Execute(sql2)
                            MsgBox("Pedido retirado com sucesso", MsgBoxStyle.Information, "AVISO")
                        End If
                    Else
                        MsgBox("Não é possivel fazer a retirada do estoque pois esse pedido não foi aceito", MsgBoxStyle.Critical, "ATENÇÃO")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Algo de errado")
            End Try
        End With
    End Sub

End Module
