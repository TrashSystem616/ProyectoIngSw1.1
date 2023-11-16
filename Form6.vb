Imports System.Data.SqlClient

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Modificacion As Integer

        ' Muestra una advertencia general
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de realizar las modificaciones?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            'Piezas'
            If Not String.IsNullOrEmpty(TextBox1.Text) AndAlso Integer.TryParse(TextBox1.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET Piezas = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Tiras'
            If Not String.IsNullOrEmpty(TextBox2.Text) AndAlso Integer.TryParse(TextBox2.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET Tiras = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'BigKrunch'
            If Not String.IsNullOrEmpty(TextBox3.Text) AndAlso Integer.TryParse(TextBox3.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET BigKrunch = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Refresco Lata'
            If Not String.IsNullOrEmpty(TextBox10.Text) AndAlso Integer.TryParse(TextBox10.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET RefrescoLata = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Papas Medianas'
            If Not String.IsNullOrEmpty(TextBox4.Text) AndAlso Integer.TryParse(TextBox4.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET PapasMedianas = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Pure Familiar'
            If Not String.IsNullOrEmpty(TextBox5.Text) AndAlso Integer.TryParse(TextBox5.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET PureFamiliar = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Pure Individual'
            If Not String.IsNullOrEmpty(TextBox7.Text) AndAlso Integer.TryParse(TextBox7.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET PureIndividual = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Ensalada Familiar'
            If Not String.IsNullOrEmpty(TextBox6.Text) AndAlso Integer.TryParse(TextBox6.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET EnsaladaFamiliar = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Ensalada Individual'
            If Not String.IsNullOrEmpty(TextBox8.Text) AndAlso Integer.TryParse(TextBox8.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET EnsaladaIndividual = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            'Bisquets'
            If Not String.IsNullOrEmpty(TextBox7.Text) AndAlso Integer.TryParse(TextBox7.Text, Modificacion) Then
                If Modificacion > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        Dim query As String = "UPDATE Inventario SET Bisquets = @Modificacion"
                        Using command As New SqlCommand(query, conexion)
                            command.Parameters.AddWithValue("@Modificacion", Modificacion)
                            command.ExecuteNonQuery()
                        End Using
                        conexion.Close()
                    End Using
                End If
            End If

            ' Muestra un mensaje de éxito
            MessageBox.Show("Modificaciones realizadas con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0
    End Sub
End Class