Public Class NovaSenha
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtNome.Text = "" Or txtSenha1.Text = "" Or txtSenha2.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "select * from tb_cadastro where nomeUser = '" & txtNome.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    If txtSenha1.Text = txtSenha2.Text Then
                        sql = "update tb_cadastro set senha = '" & txtSenha2.Text & "' where nomeUser = '" & txtNome.Text & "'"
                        rs = db.Execute(sql)
                        MsgBox("Senha atualizada com sucesso!!!", MsgBoxStyle.Information, "AVISO")
                        Me.Close()
                    Else
                        MsgBox("Diferença nas senhas!", MsgBoxStyle.Critical, "AVISO")
                    End If
                Else
                    MsgBox("Esse usuario não existe", MsgBoxStyle.Critical, "AVISO")
                    txtNome.Text = ""
                    txtSenha1.Text = ""
                    txtSenha2.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Um erro foi detectado ao iniciar o programa", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATEÇÃO")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb_senha.CheckedChanged
        If cb_senha.Checked = True Then
            txtSenha1.PasswordChar = ""
            txtSenha2.PasswordChar = ""
        Else
            txtSenha1.PasswordChar = "*"
            txtSenha2.PasswordChar = "*"
        End If
    End Sub

    Private Sub NovaSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Text = nomeUser
    End Sub
End Class