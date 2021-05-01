<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TV = New System.Windows.Forms.TreeView()
        Me.LV = New System.Windows.Forms.ListView()
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.PARTIDO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FECHA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HORA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EQUIPO1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EQUIPO3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'TV
        '
        Me.TV.ImageIndex = 0
        Me.TV.ImageList = Me.IL
        Me.TV.Location = New System.Drawing.Point(12, 12)
        Me.TV.Name = "TV"
        Me.TV.SelectedImageIndex = 0
        Me.TV.Size = New System.Drawing.Size(282, 407)
        Me.TV.TabIndex = 0
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PARTIDO, Me.FECHA, Me.HORA, Me.EQUIPO1, Me.EQUIPO3})
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(318, 12)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(457, 407)
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "logoCuadrado.png")
        Me.IL.Images.SetKeyName(1, "BOLIVIA.png")
        Me.IL.Images.SetKeyName(2, "BRASIL.png")
        Me.IL.Images.SetKeyName(3, "PERU.png")
        Me.IL.Images.SetKeyName(4, "VENEZUELA.png")
        Me.IL.Images.SetKeyName(5, "ARGENTINA.png")
        Me.IL.Images.SetKeyName(6, "COLOMBIA.png")
        Me.IL.Images.SetKeyName(7, "PARAGUAY.png")
        Me.IL.Images.SetKeyName(8, "CATAR.png")
        Me.IL.Images.SetKeyName(9, "CHILE.png")
        Me.IL.Images.SetKeyName(10, "ECUADOR.png")
        Me.IL.Images.SetKeyName(11, "JAPON.png")
        Me.IL.Images.SetKeyName(12, "URUGUAY.png")
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(0, 429)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(787, 22)
        Me.SS.TabIndex = 2
        Me.SS.Text = "StatusStrip1"
        '
        'PARTIDO
        '
        Me.PARTIDO.Text = "PARTIDO"
        Me.PARTIDO.Width = 83
        '
        'FECHA
        '
        Me.FECHA.Text = "FECHA"
        Me.FECHA.Width = 74
        '
        'HORA
        '
        Me.HORA.Text = "HORA"
        Me.HORA.Width = 75
        '
        'EQUIPO1
        '
        Me.EQUIPO1.Text = "EQUIPO 1"
        Me.EQUIPO1.Width = 91
        '
        'EQUIPO3
        '
        Me.EQUIPO3.Text = "EQUIPO 2"
        Me.EQUIPO3.Width = 81
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 451)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.TV)
        Me.Name = "Form1"
        Me.Text = "Fixture Copa America 2019"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents IL As System.Windows.Forms.ImageList
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents PARTIDO As System.Windows.Forms.ColumnHeader
    Friend WithEvents FECHA As System.Windows.Forms.ColumnHeader
    Friend WithEvents HORA As System.Windows.Forms.ColumnHeader
    Friend WithEvents EQUIPO1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents EQUIPO3 As System.Windows.Forms.ColumnHeader

End Class
