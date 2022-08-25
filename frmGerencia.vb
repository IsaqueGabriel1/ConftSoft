Public Class frmGerencia
    Sub Limpar_dados()
        txt_confiSenha.Text = ""
        txt_email.Text = ""
        txt_nivelAcesso.Text = ""
        txt_nomeUser.Text = ""
        txt_senha.Text = ""
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txt_nomeUser.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or txt_confiSenha.Text = "" Or txt_nivelAcesso.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                If txt_nivelAcesso.Text <> 1 And txt_nivelAcesso.Text <> 2 Then
                    MsgBox("No campo nivel de acesso, só é permitido os seguintes niveis: [1] para balconista ou [2] para cozinheiro.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_nivelAcesso.Text = ""
                Else
                    If txt_senha.Text = txt_confiSenha.Text Then
                        sql = "select * from tb_cadastro where email = '" & txt_email.Text & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = True Then
                            sql = "insert into tb_cadastro (Email, nomeUser, senha, nivelAcesso, statusConta) 
                               values ('" & txt_email.Text & "', '" & txt_nomeUser.Text & "', '" & txt_senha.Text & "', " &
                                   "'" & txt_nivelAcesso.Text & "', 'ativo')"
                            rs = db.Execute(sql)
                            MsgBox("Cadastro realizado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            resp = MsgBox("Deseja realizar um novo cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Novo Cadastro")
                            If resp = True Then
                                Limpar_dados()
                            Else
                                Me.Close()
                            End If
                        Else
                            MsgBox("Estas informações ja foram cadastradas no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                            Limpar_dados()
                        End If
                    Else
                        MsgBox("As senha estão diferentes!", MsgBoxStyle.Critical, "AVISO")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de exception")
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub lblCadastro_MouseMove(sender As Object, e As MouseEventArgs) Handles lblCadastro.MouseMove
        lblCadastro.ForeColor = Color.White
    End Sub

    Private Sub lblCadastro_MouseLeave(sender As Object, e As EventArgs) Handles lblCadastro.MouseLeave
        lblCadastro.ForeColor = Color.FromArgb(211, 104, 90)
    End Sub

    Private Sub frmGerencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
        carregar_dados()
        carregar_usuarios()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAdicionarProduto.Show()
    End Sub


    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        sql = "select * from tb_cadastro where email like '" & txt_busca.Text & "%'"
        rs = db.Execute(sql)
        With dvg_controle
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub dvg_controle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_controle.CellContentClick
        Try
            With dvg_controle
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_user = .CurrentRow.Cells(0).Value
                    sql = "select * from tb_cadastro where email = '" & aux_user & "' and statusConta = 'ativo'"
                    rs = db.Execute(sql)
                    If aux_user = "adm123@gmail.com" Then
                        MsgBox("Esse usuario não pode ser bloqueado", MsgBoxStyle.Information, "AVISO")
                        Exit Sub
                    Else
                        If rs.EOF = False Then
                            sql = "update tb_cadastro set statusConta = 'bloqueado' where email = '" & aux_user & "'"
                            rs = db.Execute(sql)
                        Else
                            sql = "update tb_cadastro set statusConta = 'ativo' where email = '" & aux_user & "'"
                            rs = db.Execute(sql)

                        End If
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_user = .CurrentRow.Cells(0).Value
                    If aux_user = "adm123@gmail.com" Then
                        MsgBox("O ADM não pode ser excluido", MsgBoxStyle.Critical, "ATEÇÃO")
                    Else
                        resp = MsgBox("Deseja excluir o email: " & aux_user & "", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
                        If resp = MsgBoxResult.Yes Then
                            sql = "delete * from tb_cadastro where email = '" & aux_user & "'"
                            rs = db.Execute(sql)
                        End If
                    End If
                Else
                    If .CurrentRow.Cells(5).Selected = True Then
                        nomeUser = .CurrentRow.Cells(1).Value
                        NovaSenha.Show()
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro")
        End Try
        carregar_usuarios()
    End Sub

    Private Sub txtEstoque_TextChanged(sender As Object, e As EventArgs) Handles txtEstoque.TextChanged
        sql = "select * from tb_estoque where nomeProduto like '" & txtEstoque.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dados
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGerarRelátorio.Click
        frmRelatorio.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb_verSenha.CheckedChanged
        If cb_verSenha.Checked = True Then
            txt_senha.PasswordChar = ""
            txt_confiSenha.PasswordChar = ""
        Else
            txt_confiSenha.PasswordChar = "*"
            txt_senha.PasswordChar = "*"
        End If
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        MsgBox("No campo nivel de acesso utilize [1] para balconista e [2] para cozinheiro", MsgBoxStyle.Information, "AJUDA")
    End Sub



    Private Sub btnAjudaEstoque_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAjudaEstoque.MouseClick
        MsgBox("Utilize o filtro para fazer uma pesquisa mais apurada do estoque. Clique no botão relatório para saber as ritiradas diarias dos produtos" & MsgBoxStyle.Information, "AJUDA")
    End Sub


    Private Sub btnAjudaFun_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAjudaFun.MouseClick
        MsgBox("Se deseja atualizar o status do usuario, clique na palavra ativo ou bloqueado correspondente ao usuario.", MsgBoxStyle.Information, "AVISO")
    End Sub


End Class