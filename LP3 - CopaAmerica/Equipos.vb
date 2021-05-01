Imports System.Data.OleDb

Public Class Equipos




    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Equipos"
        ADAPTADOR.Fill(TABLA)
        Dim VEC(0) As DataColumn
        VEC(0) = TABLA.Columns("equipo")
        TABLA.PrimaryKey = VEC
    End Sub

    Public Sub Ver(TV As TreeView)
        Dim ABUELO As TreeNode
        ABUELO = TV.Nodes.Add("EQUIPOS", "EQUIPOS", 0, 0)

        For Each FILA As DataRow In TABLA.Rows
            Dim PADRE As TreeNode
            PADRE = ABUELO.Nodes.Add(FILA("nombre"), FILA("nombre"), FILA("equipo"), FILA("equipo"))
            PADRE.Tag = FILA("equipo")
        Next


    End Sub

    Public Function Buscar(EQUIPO As Integer) As DataRow
        Dim FILA As DataRow = TABLA.Rows.Find(EQUIPO)
        Return FILA
    End Function

End Class
