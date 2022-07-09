'Importa a DLL responsável.
Imports System.Data.SQLite
Imports System.Data.SQLite.Linq
Imports System.Data.SQLite.EF6
Imports ToolsBox.Utils
Imports System.Text
Module SQL_Lite

    Private ReadOnly Password As String = "PixInovation@2020"
    Private ReadOnly DataBase As String = "Data Source=Pix_DataBase.pix; Version=3; Compress=true; Integrated Security=true; Password=" & Password & ""
    Private Quantidades As Integer = 0

    Public Function OpenConnection() As SQLiteConnection
        Try
            Dim SQLiteConn As SQLiteConnection
            SQLiteConn = New SQLiteConnection
            SQLiteConn.ConnectionString = DataBase
            ' SQLiteConn.SetPassword(Password)
            SQLiteConn.Open()
            Return SQLiteConn
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function CheckDataBaseExist() As Boolean
        Try
            If System.IO.File.Exists("Pix_DataBase.pix") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Return False
        End Try

        Return False
    End Function
    Private Sub CheckTableExist()
        Try
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand

            SQLiteConnect.ConnectionString = DataBase
            ' SQLiteConnect.SetPassword(Password)
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5
            SQLiteCommand.CommandText = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'YourTable' AND type = 'U')"

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try


    End Sub
    Private Function CheckExist(ByVal Table As String, ByVal ID As String) As Boolean

        Try
            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection
            'SQLiteConnect.SetPassword(Password)
            Using SQLiteCommand As New SQLiteCommand()
                SQLiteCommand.CommandTimeout = 5
                SQLiteConnect.ConnectionString = DataBase
                SQLiteConnect.Open()

                With SQLiteCommand
                    .Connection = SQLiteConnect
                    .CommandText = "Select * FROM " & Table & " WHERE ID = @ID"
                    .Parameters.AddWithValue("@ID", ID)
                End With

                Dim Reader As SQLiteDataReader = SQLiteCommand.ExecuteReader

                If Reader.HasRows Then
                    SQLiteConnect.Cancel()
                    SQLiteCommand.Cancel()
                    SQLiteConnect.Close()
                    Reader.Close()
                    Reader.Dispose()
                    SQLiteCommand.Dispose()
                    SQLiteConnect.Dispose()
                    Return True
                Else
                    SQLiteConnect.Cancel()
                    SQLiteCommand.Cancel()
                    SQLiteConnect.Close()
                    Reader.Close()
                    Reader.Dispose()
                    SQLiteCommand.Dispose()
                    SQLiteConnect.Dispose()
                    Return False
                End If
            End Using

        Catch
            Return False
        End Try

    End Function
    Private Function CheckExistNames(ByVal Names As String, ByVal Table As String, ByVal Colums As String) As Boolean

        Try
            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection
            'SQLiteConnect.SetPassword(Password)
            'SQLconnect = New SQLiteConnection
            Using SQLiteCommand As New SQLiteCommand()
                SQLiteCommand.CommandTimeout = 5
                SQLiteConnect.ConnectionString = DataBase
                SQLiteConnect.Open()

                With SQLiteCommand
                    .Connection = SQLiteConnect
                    .CommandText = "Select * FROM " & Table & " WHERE " & Colums & " = @Item COLLATE NOCASE"
                    .Parameters.AddWithValue("@Item", Names.ToLower)
                End With

                Dim Reader As SQLiteDataReader = SQLiteCommand.ExecuteReader

                If Reader.HasRows Then
                    SQLiteConnect.Cancel()
                    SQLiteCommand.Cancel()
                    SQLiteConnect.Close()
                    Reader.Close()
                    Reader.Dispose()
                    SQLiteCommand.Dispose()
                    SQLiteConnect.Dispose()
                    Return True
                Else
                    SQLiteConnect.Close()
                    SQLiteCommand.Cancel()
                    Return False
                End If
            End Using

        Catch
            Return False
        End Try

    End Function
    Public Function CheckEmailExist(ByVal EMail As String) As String

        Try
            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection
            'SQLiteConnect.SetPassword(Password)
            Using SQLiteCommand As New SQLiteCommand()
                SQLiteCommand.CommandTimeout = 5
                SQLiteConnect.ConnectionString = DataBase
                SQLiteConnect.Open()

                With SQLiteCommand
                    .Connection = SQLiteConnect
                    .CommandText = "Select * FROM Password WHERE Email = @EMail"
                    .Parameters.AddWithValue("@EMail", EMail)
                End With

                Dim Reader As SQLiteDataReader = SQLiteCommand.ExecuteReader
                Dim REF As Boolean
                Dim Pass As String = Nothing

                If Reader.HasRows Then
                    REF = True
                Else
                    REF = False
                End If

                If REF = True Then
                    While Reader.Read
                        Pass = Reader("Senha")
                    End While
                Else
                    Pass = REF
                End If

                SQLiteConnect.Cancel()
                SQLiteCommand.Cancel()
                SQLiteConnect.Close()
                Reader.Close()
                Reader.Dispose()
                SQLiteCommand.Dispose()
                SQLiteConnect.Dispose()
                Return Pass
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Sub CreatorTable()
        Try
            Dim TablesNames() = {"Pix", "Historico", "Bancos", "Password", "Notes"}
            Dim Itens() = {"(ID Integer PRIMARY KEY, Banco TEXT, Nome TEXT, Chave TEXT, Tipo_Chave TEXT, Codigo_Banco TEXT, Agencia TEXT, Conta TEXT, Operacao TEXT, Tipo_Conta TEXT);",
                      "(ID Integer PRIMARY KEY, Banco TEXT, Nome TEXT, Chave TEXT, Valor TEXT, Tipo TEXT, Servico TEXT, Cidade TEXT, Codigo TEXT, QRCode TEXT, Data TEXT, Codigo_Banco TEXT, Agencia TEXT, Conta TEXT, Operacao TEXT, Tipo_Conta TEXT);",
                      "(ID Integer PRIMARY KEY, Codigo_Banco TEXT, Banco TEXT, Foto Byte);",
                      "(ID Integer PRIMARY KEY, Senha TEXT, EMail TEXT);",
                      "(ID Integer PRIMARY KEY, Notes Byte);"}

            If CheckDataBaseExist() Then
                Exit Sub
            End If

            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            SQLiteConnect.ConnectionString = DataBase
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5


            For i = 0 To TablesNames.Count - 1
                'Cria tabela com o nome do Grupo
                SQLiteCommand.CommandText = "CREATE TABLE " & TablesNames(i) & Itens(i) & ""

                'Executa a Query Acima
                SQLiteCommand.ExecuteNonQuery()
            Next
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Sub
    Public Function CheckPassword(ByVal Password As String) As Boolean
        Try
            Dim ID As String = Quantidades
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            Dim Reader As SQLiteDataReader
            SQLiteConnect.ConnectionString = DataBase
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5
            Dim PassHash As String = SHA256H.Hash(Password)
            SQLiteCommand.CommandText = "Select * FROM Password"
            Reader = SQLiteCommand.ExecuteReader
            While Reader.Read
                Dim MyPassDataBase = Reader("Senha")

                If PassHash = MyPassDataBase Then
                    SQLiteConnect.Cancel()
                    SQLiteCommand.Cancel()
                    SQLiteConnect.Close()
                    SQLiteConnect.Dispose()
                    SQLiteCommand.Dispose()
                    Reader.Close()
                    Return True
                Else
                    SQLiteConnect.Cancel()
                    SQLiteCommand.Cancel()
                    SQLiteConnect.Close()
                    SQLiteConnect.Dispose()
                    SQLiteCommand.Dispose()
                    Reader.Close()
                    Return False
                End If
            End While
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    Public Function CreateNewPassword(ByVal Password As String, ByVal EMail As String) As Boolean
        Try
            Dim ID As String = Quantidades
            Dim SQLiteConnect As New SQLiteConnection
            Dim SQLiteCommand As New SQLiteCommand
            SQLiteConnect.ConnectionString = DataBase
            ' SQLiteConnect.SetPassword(Password)
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5
            Dim PassHash As String = SHA256H.Hash(Password)
LL:
            If CheckExist("Password", Quantidades) = True Then
                Quantidades += 1
                GoTo LL
            End If
            SQLiteCommand.CommandText = "INSERT INTO Password (ID, Senha, EMail) VALUES  (" & "'" & ID & "'" & "," & "'" & PassHash & "'" & "," & "'" & EMail & "'" & ")"
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function ChangePassword(ByVal Password As String) As Boolean
        Try
BB:
            If CheckExist("Password", Quantidades) = False Then
                Quantidades += 1
                GoTo BB
            End If

            Dim ID As String = Quantidades
            Dim PassHash As String = SHA256H.Hash(Password)
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            SQLiteConnect.ConnectionString = DataBase
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5
            SQLiteCommand.CommandText = "UPDATE Password SET Senha = '" & PassHash & "' WHERE ID = '" & ID & "'"
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub Insert(ByVal Itens As String())
        Try
            Quantidades = 0
LL:
            If CheckExist("Pix", Quantidades) = True Then
                Quantidades += 1
                GoTo LL
            End If

            Dim ID As Integer = Quantidades

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)

            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'ORDEN DAS TABELAS
            'ID
            'BANCO
            'NOME
            'CHAVE
            'CODIGO_BANCO
            'AGENCIA
            'CONTA
            'OPERACAO
            'TIPO CONTA

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "INSERT INTO Pix (ID, Banco, Nome, Chave, Tipo_Chave, Codigo_Banco, Agencia, Conta, Operacao, Tipo_Conta) VALUES  (" & "'" & ID & "'" & "," & "'" & Itens(0) & "'" & "," & "'" & Itens(1) & "'" & "," & "'" & Itens(2) & "'" & "," & "'" & Itens(3) & "'" & "," & "'" & Itens(4) & "'" & "," & "'" & Itens(5) & "'" & "," & "'" & Itens(6) & "'" & "," & "'" & Itens(7) & "'" & "," & "'" & Itens(8) & "'" & ")"

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try


    End Sub
    Public Function InsertBancos(ByVal Itens As Object()) As Boolean
        Try
            Quantidades = 0
LL:
            If CheckExist("Bancos", Quantidades) = True Then
                Quantidades += 1
                GoTo LL
            End If

            Dim ID As Integer = Quantidades

            If CheckExistNames(Itens(0), "Bancos", "Codigo_Banco") = True Then
                MensagemBox("Esse Codigo já existe", MessageNumber.Exclamation_, "Já Existente.")
                Return False
            End If

            If CheckExistNames(Itens(1), "Bancos", "Banco") = True Then
                MensagemBox("Esse Banco já existe", MessageNumber.Exclamation_, "Já Existente.")
                Return False
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand

            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'ORDEN DAS TABELAS
            'ID
            'CODIGO_BANCO
            'BANCOS
            'FOTOS

            'Cria tabela com o nome do Grupo
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandText = New String("INSERT INTO Bancos (ID, Codigo_Banco, Banco, Foto) VALUES (@N1,@O2,@P3,@Z4)")
            SQLiteCommand.Parameters.AddWithValue("@N1", "" & ID & "")
            SQLiteCommand.Parameters.AddWithValue("@O2", "" & Itens(0) & "")
            SQLiteCommand.Parameters.AddWithValue("@P3", "" & Itens(1) & "")
            SQLiteCommand.Parameters.AddWithValue("@Z4", Itens(2))

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

            Return True
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Return False
        End Try
    End Function
    Public Sub Update(ByVal ID As Integer, ByVal Banco As String, ByVal Nome As String, ByVal Chave As String)
        Try
            If CheckExist("Pix", Banco) = False Then
                Exit Sub
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "UPDATE Pix SET Banco = " & Banco & ", Nome = " & Nome & ", Chave =  " & Chave & " WHERE ID = " & ID & ""

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try


    End Sub
    Public Function UpdateBanco(ByVal ID As Integer, ByVal Data As Object()) As Boolean
        Try
            If CheckExist("Bancos", ID) = False Then
                Return False
                Exit Function
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "UPDATE Bancos SET Codigo_Banco = '" & Data(0).ToString & "', Banco = '" & Data(1).ToString & "', Foto = @Fo WHERE ID = '" & ID & "'"
            'Dim F As Byte() = Data(2)
            SQLiteCommand.Parameters.AddWithValue("@Fo", Data(2))
            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function UpdateConta(ByVal ID As Integer, ByVal Data As Object()) As Boolean
        Try
            If CheckExist("Pix", ID) = False Then
                Return False
                Exit Function
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "UPDATE Pix SET Banco = '" & Data(0) & "', Nome = '" & Data(1) & "', Chave = '" & Data(2) & "', Tipo_Chave = '" & Data(3) & "', Codigo_Banco = '" & Data(4) & "', Agencia = '" & Data(5) & "', Conta = '" & Data(6) & "', Operacao = '" & Data(7) & "', Tipo_Conta = '" & Data(8) & "' WHERE ID = '" & ID & "'"

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub Delete(ByVal ID As String)
        Try
            If CheckExist("Pix", ID) = False Then
                Exit Sub
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "DELETE FROM Pix WHERE ID = " & "'" & ID & "'" & ""

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try


    End Sub
    Public Sub DeleteBanco(ByVal ID As String)
        Try
            If CheckExist("Bancos", ID) = False Then
                Exit Sub
            End If

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As New SQLiteCommand
            ' SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "DELETE FROM Bancos WHERE ID = " & "'" & ID & "'" & ""

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

        Catch ex As Exception
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try

    End Sub
    Public Function LoadPix(ByVal ListViewr As ListView) As ImageList
        ListViewr.Items.Clear()
        'Declara as variaveis para a conexão.
        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        'SQLiteConnect.SetPassword(Password)
        Try
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()

            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            Dim Query As String = "SELECT Pix.ID, Pix.Banco, Pix.Nome, Pix.Chave, Pix.Tipo_Chave, Pix.Codigo_Banco, Pix.Agencia, Pix.Conta, Pix.Operacao, Pix.Tipo_Conta, Bancos.Foto FROM Pix INNER JOIN Bancos ON Bancos.Banco = Pix.Banco"
            '"SELECT * FROM Pix ORDER BY CAST(ID AS INTEGER)"
            Dim sadapter As New SQLiteDataAdapter
            Dim sqltable As New DataTable

            Dim i As Integer
            With SQLiteCommand
                .CommandText = Query
                .Connection = SQLiteConnect
            End With

            With sadapter
                .SelectCommand = SQLiteCommand
                .Fill(sqltable)
            End With

            Dim imgCon As New ImageConverter()
            Dim GA As New ListViewGroup
            Dim ListImage As New ImageList
            ListViewr.Sort()

            For i = 0 To sqltable.Rows.Count - 1

                With ListViewr
                    .Items.Add(sqltable.Rows(i)("ID"), 0)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("Banco"))
                        .Add(sqltable.Rows(i)("Nome"))
                        .Add(sqltable.Rows(i)("Chave"))
                        .Add(sqltable.Rows(i)("Tipo_Chave"))
                        .Add(sqltable.Rows(i)("Codigo_Banco"))
                        .Add(sqltable.Rows(i)("Agencia"))
                        .Add(sqltable.Rows(i)("Conta"))
                        .Add(sqltable.Rows(i)("Operacao"))
                        .Add(sqltable.Rows(i)("Tipo_Conta"))
                        Dim Foto As Byte() = sqltable.Rows(i)("Foto")
                        Dim ms As New IO.MemoryStream(Foto)
                        Dim returnImage As Image = Image.FromStream(ms)
                        ListImage.Images.Add(sqltable.Rows(i)("Banco"), returnImage)
                    End With
                End With
            Next

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

            ListImage.ImageSize = New Size(30, 30)
            ListViewr.SmallImageList = ListImage

            Dim ITEMCOUNT As Integer = 0
            For Each L As ListViewItem In ListViewr.Items
                Dim NAMES As String = L.SubItems(1).Text
                ListViewr.Items(L.Index).ImageKey = NAMES
                ListViewr.Items(ITEMCOUNT).UseItemStyleForSubItems = False
                ListViewr.Items(ITEMCOUNT).SubItems(3).ForeColor = Color.DeepSkyBlue
                ITEMCOUNT += 1
            Next

            Return ListImage
        Catch ex As Exception
            SQLiteConnect.Close()
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Return Nothing
        End Try
    End Function
    Public Async Function LoadNotes(ByVal RichTextBox As ToolsBox.RichTextBox_Tools) As Threading.Tasks.Task(Of Boolean)

        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        If Not CheckExist("Notes", "1") Then
            Try
                SQLiteConnect.ConnectionString = DataBase
                SQLiteConnect.Open()
                SQLiteCommand = SQLiteConnect.CreateCommand
                SQLiteCommand.CommandTimeout = 5

                Dim MyNotes As Byte() = Security.AES_Encrypt_Bytes(System.Text.Encoding.UTF8.GetBytes(""))
                SQLiteCommand.CommandText = "INSERT INTO Notes (Notes) VALUES (@No)"
                SQLiteCommand.Parameters.AddWithValue("@No", MyNotes)
                Await SQLiteCommand.ExecuteNonQueryAsync
                SQLiteConnect.Cancel()
                SQLiteCommand.Cancel()
                SQLiteConnect.Close()
                SQLiteConnect.Dispose()
                SQLiteCommand.Dispose()
            Catch ex As Exception
                Return False
            End Try
        End If


        Try

            SQLiteConnect = New SQLiteConnection()
            SQLiteCommand = New SQLiteCommand
            SQLiteConnect.ConnectionString = DataBase
            SQLiteConnect.Open()

            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            Dim Query As String = "SELECT * FROM Notes"

            SQLiteCommand = New SQLiteCommand(Query, SQLiteConnect)
            SQLiteReader = SQLiteCommand.ExecuteReader

            While SQLiteReader.Read
                RichTextBox.LoadBytes = Security.AES_Decrypt_Bytes(DirectCast(SQLiteReader("Notes"), Byte()))
            End While

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Return False
        End Try

    End Function
    Public Async Function SaveNotes(ByVal RichTextBox As ToolsBox.RichTextBox_Tools) As Threading.Tasks.Task(Of Boolean)
        'RichTextBox.Documents.Clear()

        'Declara as variaveis para a conexão.
        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        'SQLiteConnect.SetPassword(Password)
        Try
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()

            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            Dim MyNotes As Byte() = Security.AES_Encrypt_Bytes(System.Text.Encoding.UTF8.GetBytes(RichTextBox.Documents.Rtf))
            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "UPDATE Notes SET Notes = @No WHERE ID = '" & 1 & "'"
            SQLiteCommand.Parameters.AddWithValue("@No", MyNotes)

            'Executa a Query Acima
            Await SQLiteCommand.ExecuteNonQueryAsync()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()
            Return True
        Catch ex As Exception
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
            Return False
        End Try

    End Function
    Public Function AdicionarContasLoad(ByVal Comboboxy As ComboBox, ByVal ListImage As ImageList) As ListView
        AdicionarContasLoad = New ListView
        Comboboxy.Items.Clear()
        ListImage.Images.Clear()

        'Declara as variaveis para a conexão.
        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        Try

            'SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()

            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            Dim Query As String = "Select * FROM Bancos ORDER BY CAST(ID As Integer)"
            Dim sadapter As New SQLiteDataAdapter
            Dim sqltable As New DataTable

            Dim i As Integer
            With SQLiteCommand
                .CommandText = Query
                .Connection = SQLiteConnect
            End With

            With sadapter
                .SelectCommand = SQLiteCommand
                .Fill(sqltable)
            End With


            Quantidades = 0
            Dim GA As New ListViewGroup
            'Dim Lista As New ListView
            AdicionarContasLoad.Sort()

            For i = 0 To sqltable.Rows.Count - 1

                With AdicionarContasLoad
                    .Items.Add(sqltable.Rows(i)("ID"), 0)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("Banco"))
                        .Add(sqltable.Rows(i)("Codigo_Banco"))
                        Comboboxy.Items.Add(sqltable.Rows(i)("Banco"))
                        Dim Foto As Byte() = sqltable.Rows(i)("Foto")
                        Dim ms As New IO.MemoryStream(Foto) 'This is wrong...
                        Dim returnImage As Image = Image.FromStream(ms)
                        ListImage.Images.Add(sqltable.Rows(i)("Banco"), returnImage)
                        Quantidades += 1
                    End With
                End With
            Next

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

            ListImage.ImageSize = New Size(74, 74)


        Catch ex As Exception
            SQLiteConnect.Close()
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try
    End Function
    Public Sub LoadBancos(ByVal ListViewr As ListView)
        ListViewr.Items.Clear()
        ' Call LoadListImage()
        'Declara as variaveis para a conexão.
        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        'SQLiteConnect.SetPassword(Password)
        Try
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()

            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            Dim Query As String = "Select * FROM Bancos ORDER BY CAST(ID As Integer)"
            Dim sadapter As New SQLiteDataAdapter
            Dim sqltable As New DataTable

            Dim i As Integer
            With SQLiteCommand
                .CommandText = Query
                .Connection = SQLiteConnect
            End With

            With sadapter
                .SelectCommand = SQLiteCommand
                .Fill(sqltable)
            End With


            Dim GA As New ListViewGroup
            Dim ListImage As New ImageList
            ListViewr.Sort()

            For i = 0 To sqltable.Rows.Count - 1
                With ListViewr
                    .Items.Add(sqltable.Rows(i)("ID"), 0)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("Codigo_Banco"))
                        .Add(sqltable.Rows(i)("Banco"))
                        Dim Foto As Byte() = sqltable.Rows(i)("Foto")
                        Dim ms As New IO.MemoryStream(Foto)
                        Dim returnImage As Image = Image.FromStream(ms)
                        ListImage.Images.Add(sqltable.Rows(i)("Banco"), returnImage)
                    End With
                End With
            Next

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

            ListImage.ImageSize = New Size(30, 30)
            ListViewr.SmallImageList = ListImage

            Dim ITEMCOUNT As Integer = 0
            For Each L As ListViewItem In ListViewr.Items
                Dim NAMES As String = L.SubItems(2).Text
                ListViewr.Items(L.Index).ImageKey = NAMES
                ListViewr.Items(ITEMCOUNT).UseItemStyleForSubItems = False
                ListViewr.Items(ITEMCOUNT).SubItems(2).ForeColor = Color.LightGreen
                ITEMCOUNT += 1
            Next

        Catch ex As Exception
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            MensagemBox(ex.Message, MessageNumber.Error_, "Error!")
        End Try

    End Sub
    Public Sub testbutton(ByVal Passhashh As String, ByVal IDs As String)
        Dim PassHash As String = Passhashh '"A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
        Dim ID As String = IDs
        Dim SQLiteConnect As New SQLiteConnection()
        Dim SQLiteCommand As New SQLiteCommand
        SQLiteConnect.ConnectionString = DataBase
        SQLiteConnect.Open()
        SQLiteCommand = SQLiteConnect.CreateCommand
        SQLiteCommand.CommandTimeout = 5
        SQLiteCommand.CommandText = "UPDATE Password SET Senha = '" & PassHash & "' WHERE ID = '" & ID & "'"
        SQLiteCommand.ExecuteNonQuery()
        SQLiteConnect.Cancel()
        SQLiteCommand.Cancel()
        SQLiteConnect.Close()
    End Sub
    Public Class HistoricoDataBase

        Public Sub Load_Historico(ByVal ListViewr As ListView)

            ListViewr.Items.Clear()
            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As SQLiteCommand
            'SQLiteConnect.SetPassword(Password)
            Try
                'Se conecta com o banco de dados.
                SQLiteConnect.ConnectionString = DataBase

                'Abre a conexão com SQLite
                SQLiteConnect.Open()

                SQLiteCommand = SQLiteConnect.CreateCommand
                SQLiteCommand.CommandTimeout = 5

                Dim Query As String = "SELECT Historico.ID, Historico.Banco, Historico.Nome, Historico.Chave, Historico.Valor, Historico.Tipo, Historico.Servico, Historico.Cidade, Historico.Codigo, Historico.Data, Historico.QRCode, Bancos.Foto FROM Historico INNER JOIN Bancos ON Bancos.Banco = Historico.Banco"
                '"SELECT * FROM Pix ORDER BY CAST(ID AS INTEGER)"
                Dim sadapter As New SQLiteDataAdapter
                SQLiteCommand = New SQLiteCommand
                Dim sqltable As New DataTable

                Dim i As Integer
                With SQLiteCommand
                    .CommandText = Query
                    .Connection = SQLiteConnect
                End With

                With sadapter
                    .SelectCommand = SQLiteCommand
                    .Fill(sqltable)
                End With

                Dim imgCon As New ImageConverter()
                Dim GA As New ListViewGroup
                Dim ListImage As New ImageList
                ListViewr.Sort()

                For i = 0 To sqltable.Rows.Count - 1

                    With ListViewr
                        .Items.Add(sqltable.Rows(i)("ID"), 0)
                        With .Items(.Items.Count - 1).SubItems
                            .Add(sqltable.Rows(i)("Banco"))
                            .Add(sqltable.Rows(i)("Nome"))
                            .Add(sqltable.Rows(i)("Chave"))
                            .Add(sqltable.Rows(i)("Valor"))
                            .Add(sqltable.Rows(i)("Tipo"))
                            .Add(sqltable.Rows(i)("Servico"))
                            .Add(sqltable.Rows(i)("Cidade"))
                            .Add(sqltable.Rows(i)("Codigo"))
                            .Add(sqltable.Rows(i)("Data"))
                            .Add(sqltable.Rows(i)("QRCode"))
                            Quantidades += 1
                            Dim Foto As Byte() = sqltable.Rows(i)("Foto")
                            Dim ms As New IO.MemoryStream(Foto)
                            Dim returnImage As Image = Image.FromStream(ms)
                            ListImage.Images.Add(sqltable.Rows(i)("Banco"), returnImage)
                        End With
                    End With
                Next

                SQLiteConnect.Cancel()
                SQLiteCommand.Cancel()
                SQLiteConnect.Close()

                ListImage.ImageSize = New Size(30, 30)
                ListViewr.SmallImageList = ListImage

                Dim ITEMCOUNT As Integer = 0
                For Each L As ListViewItem In ListViewr.Items
                    Dim NAMES As String = L.SubItems(1).Text
                    ListViewr.Items(L.Index).ImageKey = NAMES
                    ListViewr.Items(ITEMCOUNT).UseItemStyleForSubItems = False
                    ListViewr.Items(ITEMCOUNT).SubItems(10).ForeColor = Color.DeepSkyBlue
                    ITEMCOUNT += 1
                Next
            Catch Ex As Exception
                MensagemBox(Ex.Message, MessageNumber.Error_, "Error!")
            End Try
        End Sub
        Public Sub Insert_Historico(ByVal Banco As String, ByVal Nome As String, ByVal Chave As String, ByVal Valor As String, ByVal Tipo As String, ByVal Servico As String, ByVal Cidade As String, ByVal Codigo As String, ByVal QRCode As String, ByVal Data As String)

            Quantidades = 1

LL:
            If CheckExist("Historico", Quantidades) = True Then
                Quantidades += 1
                GoTo LL
            End If

            Dim ID As Integer = Quantidades

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As SQLiteCommand
            'SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "INSERT INTO Historico (ID, Banco, Nome, Chave, Valor, Tipo, Servico, Cidade, Codigo, QRCode, Data) VALUES (" & "'" & ID & "'" & "," & "'" & Banco & "'" & "," & "'" & Nome & "'" & "," & "'" & Chave & "'" & "," & "'" & Valor & "'" & "," & "'" & Tipo & "'" & "," & "'" & Servico & "'" & "," & "'" & Cidade & "'" & "," & "'" & Codigo & "'" & "," & "'" & QRCode & "'" & "," & "'" & Data & "'" & ")"

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()

            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

        End Sub
        Public Sub Delete_Historico()

            'Declara as variaveis para a conexão.
            Dim SQLiteConnect As New SQLiteConnection()
            Dim SQLiteCommand As SQLiteCommand
            'SQLiteConnect.SetPassword(Password)
            'Se conecta com o banco de dados.
            SQLiteConnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLiteConnect.Open()
            SQLiteCommand = SQLiteConnect.CreateCommand
            SQLiteCommand.CommandTimeout = 5

            'Cria tabela com o nome do Grupo
            SQLiteCommand.CommandText = "DELETE FROM Historico"

            'Executa a Query Acima
            SQLiteCommand.ExecuteNonQuery()
            SQLiteConnect.Cancel()
            SQLiteCommand.Cancel()
            SQLiteConnect.Close()
            SQLiteConnect.Dispose()
            SQLiteCommand.Dispose()

        End Sub

    End Class
End Module
