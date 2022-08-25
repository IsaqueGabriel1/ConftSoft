Imports System.Data.OleDb

Public Class frmAreaChefeCozinha

    Private Sub PCarregaDados()
        Using con As OleDbConnection = getConnection()
            Try
                con.Open()
                Dim a As String = "SELECT  * FROM tb_estoque"
                Dim cmd As OleDbCommand = New OleDbCommand(a, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable

                da.Fill(dt)
                ComboBox1.ValueMember = "codProduto"
                ComboBox1.DisplayMember = "nomeProduto"

                ComboBox1.DataSource = dt

            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub frmAreaChefeCozinha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
        retirarProdutos()
        PCarregaDados()
        puxarEstoque()
        contPedido = 1
        cont = 0

        sql = "select count(*) as qtde from tb_pedidos'"
        rs = db.Execute(sql)
        aux = rs.Fields("qtde").Value
        Pedido.Text = ""
    End Sub

    Private Sub btnProximoPedido__Click(sender As Object, e As EventArgs) Handles btnProximoPedido_.Click
        lblNumPedido_.Text = contPedido
        sql = "select * from tb_pedidos where numeroPedido = " & contPedido & ""
        rs = db.Execute(sql)

        Try
            If contPedido <= aux And contPedido > 0 Then
                contPedido = contPedido + 1
                If rs.Fields(4).Value = "Espera" Then
                    lblStatus_.Visible = False
                    NomePedido.Text = rs.Fields(1).Value
                    lblDataPedido_.Text = rs.Fields(2).Value
                    lblobsPedido_.Text = rs.Fields(3).Value
                    btnPedidoAceito_.Enabled = True
                ElseIf rs.Fields(4).Value = "aceito" Then
                    lblStatus_.Visible = True
                    NomePedido.Text = rs.Fields(1).Value
                    lblDataPedido_.Text = rs.Fields(2).Value
                    lblobsPedido_.Text = rs.Fields(3).Value
                    btnPedidoAceito_.Enabled = False
                End If
            Else
                MsgBox("Não foi possivel carregar novos pedidos", MsgBoxStyle.Information, "AVISO")
                contPedido = contPedido - 1
                lblStatus_.Visible = False
                NomePedido.Text = "Informações do pedido"
                lblDataPedido_.Text = ""
                lblobsPedido_.Text = ""
                btnPedidoAceito_.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro na execução dessa rotina", MsgBoxStyle.Information, "AVISO")
            Exit Sub
        End Try
    End Sub

    Private Sub btnPedidoAceito__Click(sender As Object, e As EventArgs) Handles btnPedidoAceito_.Click
        sql = "update tb_pedidos set statusPedido = 'aceito' where numeroPedido = " & lblNumPedido_.Text & ""
        rs = db.Execute(sql)
        MsgBox("Pedido aceito com sucesso", MsgBoxStyle.Information, "AVISO")
        conecta_bd()
    End Sub

    Private Sub btnPedidoAnterior__Click(sender As Object, e As EventArgs) Handles btnPedidoAnterior_.Click
        lblNumPedido_.Text = contPedido
        sql = "select * from tb_pedidos where numeroPedido = " & contPedido & ""
        rs = db.Execute(sql)

        Try
            If contPedido <= aux And contPedido > 0 And contPedido <> 0 Then
                contPedido = contPedido - 1
                If rs.Fields(4).Value = "Espera" Then
                    lblStatus_.Visible = False
                    NomePedido.Text = rs.Fields(1).Value
                    lblDataPedido_.Text = rs.Fields(2).Value
                    lblobsPedido_.Text = rs.Fields(3).Value
                    btnPedidoAceito_.Enabled = True
                ElseIf rs.Fields(4).Value = "aceito" Then
                    lblStatus_.Visible = True
                    NomePedido.Text = rs.Fields(1).Value
                    lblDataPedido_.Text = rs.Fields(2).Value
                    lblobsPedido_.Text = rs.Fields(3).Value
                    btnPedidoAceito_.Enabled = False
                End If
            Else
                contPedido = contPedido + 1
                lblStatus_.Visible = False
                NomePedido.Text = "Informações do pedido"
                lblDataPedido_.Text = ""
                lblobsPedido_.Text = ""
                btnPedidoAceito_.Enabled = True
                MsgBox("Não foi possivel carregar novos pedidos", MsgBoxStyle.Information, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro na execução dessa rotina", MsgBoxStyle.Information, "AVISO")
            Exit Sub
        End Try
    End Sub

    Sub retirarProdutos()
        carregar_produtos()
        contRetirar = 1
        sql = "select * from tb_pedidos where numeroPedido = " & contRetirar & ""
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Pedido.Text = rs.Fields(1).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetirarEstoque.Click
        'o código desse componente se encontra em mdRetirada.vb
        If statusPedido.Text = "Selecione um pedido" Then
            MsgBox("Selecione um pedido para possa retirar o produto", MsgBoxStyle.Critical, "ATENÇÃO")
        Else
            retirarEstoque()
        End If
    End Sub

    Sub puxarEstoque()
        sql = "select * from tb_estoque where nomeProduto = '" & ComboBox1.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txtQntP.Text = rs.Fields(3).Value
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        sql = "select * from tb_estoque where nomeProduto = '" & ComboBox1.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            txtQntP.Text = rs.Fields(3).Value
        End If
    End Sub

    Private Sub btnProximoPedido_Click_1(sender As Object, e As EventArgs) Handles btnProximoPedido.Click
        'o código desse componente se encontra em mdRetirada.vb
        proximoPedido()
    End Sub

    Private Sub btnVoltar_Click_1(sender As Object, e As EventArgs) Handles btnVoltar.Click
        'o código desse componente se encontra em mdRetirada.vb
        pedidoAnterior()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtQnt_MouseLeave(sender As Object, e As EventArgs) Handles txtQnt.MouseLeave
        If txtQnt.Text = "" Then

        ElseIf CInt(txtQnt.Text) > CInt(txtQntP.Text) Then
            MsgBox("O total de produtos retirados é maior que o total de produtos em estoque", MsgBoxStyle.Critical, "ATENÇÃO")
            txtQnt.Text = ""
        End If
    End Sub

    Private Sub lblNumPedido__TextChanged(sender As Object, e As EventArgs) Handles lblNumPedido_.TextChanged
        If contPedido = 0 Then
            btnPedidoAnterior_.Enabled = False
        Else
            btnPedidoAnterior_.Enabled = True
        End If
    End Sub

End Class