Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sustituir el Gerente ID dependiendo de quien haya accesado'
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()
            Dim query As String = "UPDATE Inventario SET GerenteID = @ID"
            Using command As New SqlCommand(query, conexion)
                command.Parameters.AddWithValue("@ID", ID)
                command.ExecuteNonQuery()
            End Using
            conexion.Close()
        End Using

        'Mostramos los datos de la tabla productos'
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()
            Dim query As String = "SELECT * FROM Inventario"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet, "Inventario")
            DataGridView1.DataSource = dataSet.Tables("Inventario")
            conexion.Close() ' Cierra la conexión al finalizar
        End Using


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Muestra una confirmación
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de vaciar la tabla?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            ' El usuario confirmó la acción, procede a actualizar los valores
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim queryActualizar As String = "UPDATE Inventario SET Piezas = 0, Tiras = 0, BigKrunch = 0, PapasMedianas = 0, PureFamiliar = 0, PureIndividual=0, EnsaladaFamiliar = 0, EnsaladaIndividual = 0, Bisquets = 0, RefrescoLata= 0"
                Using commandActualizar As New SqlCommand(queryActualizar, conexion)
                    commandActualizar.ExecuteNonQuery()
                End Using

                conexion.Close()
            End Using

            ' Actualiza el DataGridView para mostrar los valores actualizados
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close()
            End Using
        Else
            ' El usuario canceló la acción'
        End If
    End Sub
End Class