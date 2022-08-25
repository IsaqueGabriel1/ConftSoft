Public Class frmAdicionarProduto
    Private Sub frmAdicionarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
    End Sub

    Sub limparCampos()
        txtDescricao.Text = ""
        txtMarca.Text = ""
        txtNomeProduto.Text = ""
        txtQntPeso.Text = ""
        txtVencimento.Text = ""
    End Sub

    Private Sub txtNomeProduto_MouseLeave(sender As Object, e As EventArgs) Handles txtNomeProduto.MouseLeave
        sql = "select * from tb_estoque where nomeProduto ='" & txtNomeProduto.Text & "'"
        rs = db.Execute(sql)
        If txtNomeProduto.Text = "" Then
            limparCampos()
        End If
        If rs.EOF = False Then
            txtMarca.Text = rs.Fields(2).Value
            txtQntPeso.Text = rs.Fields(3).Value
            txtVencimento.Text = rs.Fields(4).Value
            txtDescricao.Text = rs.Fields(5).Value
        Else
            'MsgBox("Não foi encontrado")
        End If
    End Sub

    Sub adicionarNovoProduto()
        conecta_bd()
        sql = "insert into tb_estoque (nomeProduto, marcaProduto, qntEPeso, dataVenci, descricaoProduto) values ('" & txtNomeProduto.Text & "', '" & txtMarca.Text & "', '" & txtQntPeso.Text & "', '" & txtVencimento.Text & "', '" & txtDescricao.Text & "')"
        rs = db.Execute(sql)
        MsgBox("Novo produto cadastrado com sucesso", MsgBoxStyle.Information, "AVISO")
        limparCampos()
        carregar_dados()
    End Sub

    Sub atualizarProduto()
        conecta_bd()
        sql = "update tb_estoque set nomeProduto = '" & txtNomeProduto.Text & "', marcaProduto = '" & txtMarca.Text & "', qntEPeso = '" & txtQntPeso.Text & "', dataVenci = '" & txtVencimento.Text & "', descricaoProduto = '" & txtDescricao.Text & "' where nomeProduto = '" & txtNomeProduto.Text & "'"
        rs = db.Execute(sql)
        MsgBox("Atualizacao realizada com sucesso", MsgBoxStyle.Information, "AVISO")
        limparCampos()
        carregar_dados()
    End Sub

    Private Sub btnAtualizar_Click_1(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try
            If txtDescricao.Text = "" Or txtMarca.Text = "" Or txtNomeProduto.Text = "" Or txtQntPeso.Text = "" Or txtVencimento.Text = "" Then
                MsgBox("Preencha todos os campos")
            Else
                sql = "select * from tb_estoque where nomeProduto ='" & txtNomeProduto.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    atualizarProduto()

                Else
                    adicionarNovoProduto()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro inexperado", MsgBoxStyle.Information, "AVISO")
        End Try
    End Sub
End Class