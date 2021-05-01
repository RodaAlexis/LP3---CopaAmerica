Public Class Form1
    Dim ObjEQU As New Equipos
    Dim ObjPAR As New Partidos
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ObjEQU.Ver(TV)
    End Sub

    Private Sub TV_NodeMouseClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TV.NodeMouseClick
        SS.Items.Clear()
        ObjEQU.Buscar(e.Node.Tag)

        If e.Node.Level = 1 Then
            ObjPAR.Ver(LV, Val(e.Node.Tag))
            Dim REQU As DataRow = ObjEQU.Buscar(Val(e.Node.Tag))
            SS.Items.Add("GRUPO ----->")
            SS.Items.Add(REQU("grupo"))
        End If
    End Sub
End Class
