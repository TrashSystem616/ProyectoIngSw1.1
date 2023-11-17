Imports System.Data.SqlClient

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear la conexión
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            ' Crear el adaptador de datos
            Dim adaptador As New SqlDataAdapter("SELECT * FROM RegistroVentas", conexion)

            ' Crear y llenar el conjunto de datos
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet, "RegistroVentas")

            ' Asignar el conjunto de datos al DataGridView
            DataGridView1.DataSource = dataSet.Tables("RegistroVentas")
        End Using
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ' Obtener el día de la semana seleccionado
        Dim diaSeleccionado As String = ComboBox3.SelectedItem.ToString()

        ' Consulta SQL para obtener los registros de ventas para el día seleccionado
        Dim consulta As String = "SELECT * FROM RegistroVentas WHERE DiaDeVenta = @DiaDeVenta"

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Try
                ' Crear el adaptador de datos
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                adaptador.SelectCommand.Parameters.AddWithValue("@DiaDeVenta", diaSeleccionado)

                ' Crear y llenar el conjunto de datos
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "RegistroVentas")

                ' Mostrar los resultados en el DataGridView
                DataGridView1.DataSource = dataSet.Tables("RegistroVentas")
            Catch ex As Exception
                MessageBox.Show("Error al recuperar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Obtener el nombre del gerente seleccionado
        Dim nombreGerenteSeleccionado As String = ComboBox2.SelectedItem.ToString()

        ' Consulta SQL para obtener el GerenteID a partir del nombre
        Dim consultaGerenteID As String = "SELECT GerenteID FROM Usuarios WHERE NombreUsuario = @NombreUsuario"

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Try
                ' Obtener el GerenteID
                Dim gerenteID As Integer
                Using command As New SqlCommand(consultaGerenteID, conexion)
                    command.Parameters.AddWithValue("@NombreUsuario", nombreGerenteSeleccionado)
                    Dim resultado As Object = command.ExecuteScalar()
                    If resultado IsNot Nothing AndAlso Integer.TryParse(resultado.ToString(), gerenteID) Then
                        ' Consulta SQL para obtener los registros de ventas para el GerenteID seleccionado
                        Dim consulta As String = "SELECT * FROM RegistroVentas WHERE GerenteID = @GerenteID"

                        ' Crear el adaptador de datos
                        Dim adaptador As New SqlDataAdapter(consulta, conexion)
                        adaptador.SelectCommand.Parameters.AddWithValue("@GerenteID", gerenteID)

                        ' Crear y llenar el conjunto de datos
                        Dim dataSet As New DataSet()
                        adaptador.Fill(dataSet, "RegistroVentas")

                        ' Mostrar los resultados en el DataGridView
                        DataGridView1.DataSource = dataSet.Tables("RegistroVentas")
                    Else
                        MessageBox.Show("No se encontró el GerenteID para el nombre seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al recuperar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class