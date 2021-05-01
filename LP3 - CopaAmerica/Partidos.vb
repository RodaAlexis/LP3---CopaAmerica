Imports System.Data.OleDb
Public Class Partidos
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Partidos"
        ADAPTADOR.Fill(TABLA)
        Dim VEC(0) As DataColumn
        VEC(0) = TABLA.Columns("partido")
        TABLA.PrimaryKey = VEC
    End Sub

    Public Sub Ver(LV As ListView, EQUIPO As Integer)
        LV.Items.Clear()
        Dim objEQU As New Equipos

        For Each RPAR As DataRow In TABLA.Rows
            If RPAR("equipo1") = EQUIPO Or RPAR("equipo2") = EQUIPO Then
                Dim LVI As ListViewItem = LV.Items.Add(RPAR("partido"))
                LVI.SubItems.Add(RPAR("fecha"))
                LVI.SubItems.Add(RPAR("hora"))
                Dim E1 As DataRow = objEQU.Buscar(RPAR("equipo1"))
                Dim E2 As DataRow = objEQU.Buscar(RPAR("equipo2"))
                LVI.SubItems.Add(E1("nombre"))
                LVI.SubItems.Add(E2("nombre"))

            End If
        Next

    End Sub

End Class
