'Importa a DLL responsável.
Imports System.Data.SQLite
Imports System.Data.SQLite.Linq
Imports System.Data.SQLite.EF6

Module SQL_Lite

    Private ReadOnly DataBase As String = "Data Source=PixDB.pix; Version=3" 'Compress=TRUE; Integrated Security=true; Password=GySksZqGQrqhNJie
    Private Quantidades As Integer = 0

    Public Sub CreatorTable()

        If System.IO.File.Exists("PixDB.pix") Then
            Exit Sub
        End If

        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand

        'Se conecta com o banco de dados.
        SQLconnect.ConnectionString = DataBase

        'Abre a conexão com SQLite
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandTimeout = 5

        'Cria tabela com o nome do Grupo
        SQLcommand.CommandText = "CREATE TABLE Pix (ID INTEGER PRIMARY KEY, Banco TEXT, Nome TEXT, Chave TEXT);"

        'Executa a Query Acima
        SQLcommand.ExecuteNonQuery()
        SQLconnect.Cancel()
        SQLcommand.Cancel()
        SQLconnect.Close()
        SQLconnect.Dispose()
        SQLcommand.Dispose()
        
    End Sub

    Public Sub Insert(ByVal Banco As String, ByVal Nome As String, ByVal Chave As String)

        Quantidades = 1

LL:
        If CheckExist(Quantidades) = True Then
            Quantidades += 1
            GoTo LL
        End If

        Dim ID As Integer = Quantidades

        'Declara as variaveis para a conexão.
        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand

        'Se conecta com o banco de dados.
        SQLconnect.ConnectionString = DataBase

        'Abre a conexão com SQLite
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandTimeout = 5



        'Cria tabela com o nome do Grupo
        SQLcommand.CommandText = "INSERT INTO Pix (ID, Banco, Nome, Chave) values (" & "'" & ID & "'" & "," & "'" & Banco & "'" & "," & "'" & Nome & "'" & "," & "'" & Chave & "'" & ")"

        'Executa a Query Acima
        SQLcommand.ExecuteNonQuery()

        SQLconnect.Cancel()
        SQLcommand.Cancel()
        SQLconnect.Close()
        SQLconnect.Dispose()
        SQLcommand.Dispose()

    End Sub

    Public Sub Update(ByVal ID As Integer, ByVal Banco As String, ByVal Nome As String, ByVal Chave As String)

        If CheckExist(Banco) = False Then
            Exit Sub
        End If

        'Declara as variaveis para a conexão.
        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand

        'Se conecta com o banco de dados.
        SQLconnect.ConnectionString = DataBase

        'Abre a conexão com SQLite
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandTimeout = 5

        'Cria tabela com o nome do Grupo
        SQLcommand.CommandText = "UPDATE Pix SET Banco = " & Banco & ", Nome = " & Nome & ", Chave =  " & Chave & " WHERE ID = " & ID & ""

        'Executa a Query Acima
        SQLcommand.ExecuteNonQuery()
        SQLconnect.Cancel()
        SQLcommand.Cancel()
        SQLconnect.Close()
        SQLconnect.Dispose()
        SQLcommand.Dispose()

    End Sub

    Public Sub Delete(ByVal ID As String)

        If CheckExist(ID) = False Then
            Exit Sub
        End If

        'Declara as variaveis para a conexão.
        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand

        'Se conecta com o banco de dados.
        SQLconnect.ConnectionString = DataBase

        'Abre a conexão com SQLite
        SQLconnect.Open()
        SQLcommand = SQLconnect.CreateCommand
        SQLcommand.CommandTimeout = 5

        'Cria tabela com o nome do Grupo
        SQLcommand.CommandText = "DELETE FROM Pix WHERE ID = " & "'" & ID & "'" & ""

        'Executa a Query Acima
        SQLcommand.ExecuteNonQuery()
        SQLconnect.Cancel()
        SQLcommand.Cancel()
        SQLconnect.Close()
        SQLconnect.Dispose()
        SQLcommand.Dispose()
        
    End Sub
    Public Sub LoadPix(ByVal Lista As ListView)

        'Declara as variaveis para a conexão.
        Dim SQLconnect As New SQLiteConnection()
        Dim SQLcommand As SQLiteCommand

        Try
            'Se conecta com o banco de dados.
            SQLconnect.ConnectionString = DataBase

            'Abre a conexão com SQLite
            SQLconnect.Open()

            SQLcommand = SQLconnect.CreateCommand
            SQLcommand.CommandTimeout = 5

            Dim Query As String = "SELECT * FROM Pix"
            Dim sadapter As New SQLiteDataAdapter
            SQLcommand = New SQLiteCommand
            Dim sqltable As New DataTable

            Dim i As Integer
            With SQLcommand
                .CommandText = Query
                .Connection = SQLconnect
            End With

            With sadapter
                .SelectCommand = SQLcommand
                .Fill(sqltable)
            End With

            Quantidades = 0
            Dim GA As New ListViewGroup
            For i = 0 To sqltable.Rows.Count - 1

                With Lista
                    .Items.Add(sqltable.Rows(i)("ID"), 0)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(sqltable.Rows(i)("Banco"))
                        .Add(sqltable.Rows(i)("Nome"))
                        .Add(sqltable.Rows(i)("Chave"))
                        Quantidades += 1

                    End With
                End With
            Next

            SQLconnect.Cancel()
            SQLcommand.Cancel()
            sadapter.Dispose()
            sqltable.Dispose()
            SQLconnect.Close()
            SQLconnect.Dispose()
            SQLcommand.Dispose()

            INSERTICON(Lista, 1)
            ColorSelect(Lista, 3)
        Catch
            SQLconnect.Close()
            SQLconnect.Dispose()

        End Try
    End Sub

    Private Function CheckExist(ByVal ID As String) As Boolean

        Try
            'Declara as variaveis para a conexão.
            Dim SQLconnect As New SQLiteConnection

            'SQLconnect = New SQLiteConnection
            Using SQLCommand As New SQLiteCommand()
                SQLCommand.CommandTimeout = 5
                SQLconnect.ConnectionString = DataBase
                SQLconnect.Open()

                With SQLCommand
                    .Connection = SQLconnect
                    .CommandText = "SELECT * FROM Pix WHERE ID = @ID"
                    .Parameters.AddWithValue("@ID", ID)
                End With

                Dim Reader As SQLite.SQLiteDataReader = SQLCommand.ExecuteReader

                If Reader.HasRows Then
                    SQLconnect.Cancel()
                    SQLCommand.Cancel()
                    SQLconnect.Close()
                    Reader.Close()
                    Reader.Dispose()
                    SQLCommand.Dispose()
                    SQLconnect.Dispose()
                    Return True
                Else
                    SQLconnect.Cancel()
                    SQLCommand.Cancel()
                    SQLconnect.Close()
                    Reader.Close()
                    Reader.Dispose()
                    SQLCommand.Dispose()
                    SQLconnect.Dispose()
                    Return False
                End If
            End Using

        Catch
            Return False
        End Try

    End Function

    Private Sub INSERTICON(ByVal LIST As ListView, ByVal SubItemIndex As Int16)

        Dim MyImagesIcons As New ImageList
        MyImagesIcons = LoadImagesWithSize(New Size(30, 30))

        LIST.SmallImageList = MyImagesIcons


        For Each L As ListViewItem In LIST.Items
            Dim NAMES As String = L.SubItems(SubItemIndex).Text
            Dim Index As Integer = Adicionar.Bancos_Images.Images.IndexOfKey(NAMES)
            LIST.Items(L.Index).ImageIndex = Index

        Next
    End Sub
    Private Function LoadImagesWithSize(sz As Size) As ImageList
        Dim MyImagesIcons As New ImageList

        MyImagesIcons.ImageSize = sz
        MyImagesIcons.Images.Clear()
        For n As Int32 = 0 To Adicionar.Bancos_Images.Images.Count - 1
            MyImagesIcons.Images.Add(Adicionar.Bancos_Images.Images(n))
        Next

        Return MyImagesIcons

    End Function
    Public Sub ColorSelect(ByVal lstV As ListView, ByVal SubItemIndex As Int16)

        'CONTA OS ITEMS NA LISTVIEW E VAI INDO ADICIONANDO
        Dim ITEMCOUNT As Integer = 0

        'SUBITEMINDEX VERIFICA A COLUNA COM O NOME
        For Each L As ListViewItem In lstV.Items
            lstV.Items(ITEMCOUNT).UseItemStyleForSubItems = False
            lstV.Items(ITEMCOUNT).SubItems(SubItemIndex).ForeColor = Color.DeepSkyBlue
            ITEMCOUNT += 1
        Next
    End Sub
End Module
