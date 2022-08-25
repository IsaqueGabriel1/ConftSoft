Imports System.Data.OleDb

Module Modulo
    Public aux_codP
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, sql2, aux_user As String
    Public banco = Application.StartupPath & "\banco_dados\BancoCS.mdb"
    Public resp, trueOrFalse, nomeUser As String
    Public nivel, teste, aux, cont, contLogin, contRetirar As Integer
    Public contPedido As Integer
    Sub conecta_bd()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
            ' MsgBox("Conexao com o banco de dados Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            MsgBox(banco)
        End Try
    End Sub

    Public Function getConnection() As OleDbConnection
        Dim a As String = ("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
        Return New OleDbConnection(a)
    End Function

    Sub carregar_dados()
        sql = "select * from tb_estoque order by codProduto asc"
        rs = db.Execute(sql)
        With frmGerencia.dgv_dados
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_produtos()
        sql = "select * from tb_estoque order by codProduto asc"
        rs = db.Execute(sql)
        With frmGerencia.dgv_dados
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub


    Sub carregar_usuarios()
        sql = "select * from tb_cadastro"
        rs = db.Execute(sql)
        With frmGerencia.dvg_controle
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_retiradas()
        conecta_bd()
        sql = "SELECT tipoPedido,retirada, produto, quantidadeRetirada, horaRetirada, [Email] FROM retirada_produtos, tb_pedidos where numeroPedido = pedido;"
        rs = db.Execute(sql)
        With frmRelatorio.dvg_retiradas
            cont = 0
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
End Module
