Public Class Form1
    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        Try
            If txtNome.Text = "" Or txtSenha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information, "AVISO")
            Else
                If contLogin < 4 Then
                    sql = "select * from tb_cadastro where nomeUser = '" & txtNome.Text & "' and senha = '" & txtSenha.Text & "' and statusConta = 'ativo'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        If rs.Fields(3).Value = 1 Then
                            frmPedidos.Show()
                            contLogin = 0
                            txtNome.Text = ""
                            txtSenha.Text = ""
                        ElseIf rs.Fields(3).Value = 2 Then
                            frmAreaChefeCozinha.Show()
                            cont = 0
                            txtNome.Text = ""
                            txtSenha.Text = ""
                        ElseIf rs.Fields(3).Value = 10 Then
                            frmGerencia.Show()
                            contLogin = 0
                            txtNome.Text = ""
                            txtSenha.Text = ""
                        End If
                    Else
                        MsgBox("Usuario ou senha incorretos", MsgBoxStyle.Information, "AVISO")
                        txtNome.Text = ""
                        txtSenha.Text = ""
                        contLogin = contLogin + 1
                    End If
                Else
                    sql = "select * from tb_cadastro where nomeUser = '" & txtNome.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        If rs.Fields(0).Value = "adm123@gmail.com" Then
                            MsgBox("A senha desse usuario foi redefinida", MsgBoxStyle.Information, "AVISO")
                            sql = "update tb_cadastro set senha = 'salçisa' where nomeUser = 'Adm'"
                            rs = db.Execute(sql)
                            txtNome.Text = ""
                            txtSenha.Text = ""
                            contLogin = 0
                        Else
                            MsgBox("Esse usuario será bloqueado!", MsgBoxStyle.Critical, "AVISO")
                            sql = "update tb_cadastro set statusConta = 'bloqueado' where nomeUser = '" & txtNome.Text & "'"
                            rs = db.Execute(sql)
                            txtNome.Text = ""
                            txtSenha.Text = ""
                            contLogin = 0
                        End If
                    Else
                        MsgBox("Esse usuario não existes", MsgBoxStyle.Critical, "AVISO")
                        txtNome.Text = ""
                        txtSenha.Text = ""
                        contLogin = 0
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Algo de errado")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
        frmSplash.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        NovaSenha.Show()
    End Sub

    Private Sub txtNome_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNome.MouseClick
        'lblErroSenha.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        conecta_bd()
    End Sub

    Private Sub cb_verSenha_CheckStateChanged(sender As Object, e As EventArgs) Handles cb_verSenha.CheckStateChanged
        If cb_verSenha.Checked = True Then
            txtSenha.PasswordChar = ""
        Else
            txtSenha.PasswordChar = "*"
        End If
    End Sub
End Class