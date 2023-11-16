﻿Imports System.Data.SqlClient
Imports System.Text

Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostramos los datos de la tabla productos'
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()
            Dim query As String = "SELECT * FROM Productos"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet, "Productos")
            DataGridView1.DataSource = dataSet.Tables("Productos")
            conexion.Close() ' Cierra la conexión al finalizar

            DataGridView2.Columns.Add(0, "Piezas")
            DataGridView2.Columns.Add(0, "ProductoID")
            DataGridView2.Columns.Add(0, "Nombre")
            DataGridView2.Columns.Add(0, "Precio")
            DataGridView2.Columns.Add(0, "Descripcion")

        End Using

        'Ponemos los datos de fecha en el label'
        Label7.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verifica si la celda clicada está en una fila válida (no en el encabezado)
        If e.RowIndex >= 0 Then



            Dim fila As Integer
            'Mover a la lista'
            fila = DataGridView1.CurrentRow.Index
            ' Obtén el valor de la celda de la columna deseada
            Dim valorColumna As String = DataGridView1.Rows(e.RowIndex).Cells("ProductoID").Value.ToString()

            Dim existe As Boolean

            existe = False
            valorColumna = 0
            While ((valorColumna < DataGridView2.Rows.Count)) And (Not (existe))

                If (DataGridView2.Rows(valorColumna).Cells(1).Value = DataGridView1.Rows(fila).Cells(0).Value) Then
                    existe = True
                    Dim piezas As Integer = DataGridView2.Rows(valorColumna).Cells(0).Value
                    DataGridView2.Rows(valorColumna).Cells(0).Value = piezas + 1

                End If
                valorColumna = valorColumna + 1
            End While
            'Si no existe'
            If Not (existe) Then
                DataGridView2.Rows.Add(0, DataGridView1.Rows(fila).Cells(0).Value, DataGridView1.Rows(fila).Cells(1).Value, DataGridView1.Rows(fila).Cells(2).Value, DataGridView1.Rows(fila).Cells(3).Value)
            End If
            DataGridView2.Visible = True


            '8 piezas'
            If valorColumna = 1 Then
                ' Llena los ComboBoxes con los valores obtenidos
                ComboBox2.Text = 8 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = 1 'Valor del pure familiar'
                ComboBox5.Text = 1 'Valor de la ensalada familiar'
                ComboBox6.Text = 3 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = "" 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._8pzas
            End If

            '10 piezas'
            If valorColumna = 2 Then
                ComboBox2.Text = 10 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = 1 'Valor del pure familiar'
                ComboBox5.Text = 1 'Valor de la ensalada familiar'
                ComboBox6.Text = 3 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = "" 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._8pzas
            End If

            '12 piezas'
            If valorColumna = 3 Then
                ComboBox2.Text = 12 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = 1 'Valor del pure familiar'
                ComboBox5.Text = 1 'Valor de la ensalada familiar'
                ComboBox6.Text = 3 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = "" 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._8pzas
            End If

            'Ke tiras love'
            If valorColumna = 4 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox3.Text = 9 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = "" 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco de lata'
                ComboBox9.Text = 1 'valor de las papas '
                ComboBox10.Text = "" 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources.KTiras
            End If

            'Hamburgesa big krunch'
            If valorColumna = 5 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = "" 'valor de los bisquets'
                ComboBox7.Text = 1 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = 1 'valor de las papas '
                ComboBox10.Text = "" 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources.bigcrunch

            End If

            'Paquete de 2 Piezas'
            If valorColumna = 6 Then
                ComboBox2.Text = 2 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._2piezas

            End If

            'Paquete de 3 Piezas'
            If valorColumna = 7 Then
                ComboBox2.Text = 3 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = 1 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._3piezas

            End If

            'Paquete de 4 Piezas'
            If valorColumna = 8 Then
                ComboBox2.Text = 4 'Valor de las piezas'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = 1 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._4piezas

            End If

            'Paquete de 2 Tiras'
            If valorColumna = 9 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox3.Text = 2 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = "" 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._2tiras

            End If

            'Paquete de 3 Tiras'
            If valorColumna = 10 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox3.Text = 3 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = 1 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._3tiras

            End If

            If valorColumna = 11 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox3.Text = 4 'valor de las tiras'
                ComboBox4.Text = "" 'Valor del pure familiar'
                ComboBox5.Text = "" 'Valor de la ensalada familiar'
                ComboBox6.Text = 1 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco de lata'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox10.Text = 1 'Valor del pure individual'
                ComboBox11.Text = 1 'Valor de la ensalada individual'
                PictureBox1.Image = My.Resources._4tiras

            End If

        End If
    End Sub

    'Filtro De Busqueda'
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim filtro As String = TextBox2.Text
        Dim vista As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView

        Dim filtroGlobal As New StringBuilder()

        If Not String.IsNullOrEmpty(filtro) Then
            filtroGlobal.Append("(")
            Dim primeraColumna As Boolean = True

            For Each columna As DataGridViewColumn In DataGridView1.Columns
                If columna.ValueType Is GetType(String) Then
                    If primeraColumna Then
                        primeraColumna = False
                    Else
                        filtroGlobal.Append(" OR ")
                    End If
                    filtroGlobal.Append(columna.DataPropertyName)
                    filtroGlobal.Append(" LIKE '%")
                    filtroGlobal.Append(filtro)
                    filtroGlobal.Append("%'")
                End If
            Next

            filtroGlobal.Append(")")
        End If

        vista.RowFilter = filtroGlobal.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox2.Text = "" 'Valor de las piezas'
        ComboBox4.Text = "" 'Valor del pure'
        ComboBox5.Text = "" 'Valor de la ensalada'
        ComboBox6.Text = "" 'valor de los bisquets'
        ComboBox3.Text = "" 'valor de las tiras'
        ComboBox9.Text = "" 'valor de las papas familiares'
        ComboBox7.Text = "" 'valor de la hamburgesa'
        ComboBox8.Text = "" 'valor del refresco'
        TextBox2.Text = ""
        TextBox1.Text = ""
        PictureBox1.Image = My.Resources.LogoKFC
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For Each fila As DataGridViewRow In DataGridView2.Rows
            Dim ProductoID As Integer = CInt(fila.Cells(1).Value)
            Dim CantidadVendida As Integer = CInt(fila.Cells(0).Value)
            Dim PrecioVenta As Decimal = CDec(fila.Cells(3).Value)

            Dim GerenteId = ID
            Dim IDVenta = 0

            Dim FechaVenta = Label7.Text
            Dim Cliente = TextBox1.Text

            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()

                ' Construir la cadena de consulta con parámetros
                Dim AltaRegistroVentas As String = "INSERT INTO RegistroVentas (GerenteID, DiaDeVenta, ProductoID, CantidadVendida, PrecioVenta, Cliente) " &
                                          "VALUES (@GerenteId, @FechaVenta, @ProductoID, @CantidadVendida, @PrecioVenta, @Cliente)"

                Using command As New SqlCommand(AltaRegistroVentas, conexion)
                    ' Asignar valores a los parámetros
                    command.Parameters.AddWithValue("@GerenteId", GerenteId)

                    command.Parameters.AddWithValue("@FechaVenta", FechaVenta)
                    command.Parameters.AddWithValue("@ProductoID", ProductoID)
                    command.Parameters.AddWithValue("@CantidadVendida", CantidadVendida)
                    command.Parameters.AddWithValue("@PrecioVenta", PrecioVenta)
                    command.Parameters.AddWithValue("@Cliente", Cliente)

                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                End Using

                conexion.Close()
            End Using
        Next





        Dim cantidadARestar As Integer ' Declarar la variable
        'Esto es para las Piezas'
        ' Verifica que el ComboBox tenga un valor de texto no vacío
        If Not String.IsNullOrEmpty(ComboBox2.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox2.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPiezas As String = "SELECT Piezas FROM Inventario"
                        Using commandVerificarPiezas As New SqlCommand(queryVerificarPiezas, conexion)
                            Dim piezasEnInventario As Integer = CInt(commandVerificarPiezas.ExecuteScalar())
                            If piezasEnInventario > 0 AndAlso piezasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Piezas = Piezas - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Piezas en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las Tiras'
        If Not String.IsNullOrEmpty(ComboBox3.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox3.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarTiras As String = "SELECT Tiras FROM Inventario"
                        Using commandVerificarTiras As New SqlCommand(queryVerificarTiras, conexion)
                            Dim TirasEnInventario As Integer = CInt(commandVerificarTiras.ExecuteScalar())
                            If TirasEnInventario > 0 AndAlso TirasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Tiras = Tiras - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Tiras en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para el Pure Familiar'
        If Not String.IsNullOrEmpty(ComboBox4.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox4.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPureFamiliar As String = "SELECT PureFamiliar FROM Inventario"
                        Using commandVerificarPureFamiliar As New SqlCommand(queryVerificarPureFamiliar, conexion)
                            Dim PureFamiliarEnInventario As Integer = CInt(commandVerificarPureFamiliar.ExecuteScalar())
                            If PureFamiliarEnInventario > 0 AndAlso PureFamiliarEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET PureFamiliar = PureFamiliar - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Pure Familiar en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para la Ensalada Familiar'
        If Not String.IsNullOrEmpty(ComboBox5.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox5.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarEnsalada As String = "SELECT Ensalada FROM Inventario"
                        Using commandVerificarEnsalada As New SqlCommand(queryVerificarEnsalada, conexion)
                            Dim EnsaladaEnInventario As Integer = CInt(commandVerificarEnsalada.ExecuteScalar())
                            If EnsaladaEnInventario > 0 AndAlso EnsaladaEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Ensalada = Ensalada - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Ensalada en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para los bisquets'
        If Not String.IsNullOrEmpty(ComboBox6.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox6.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarBisquets As String = "SELECT Bisquets FROM Inventario"
                        Using commandVerificarBisquets As New SqlCommand(queryVerificarBisquets, conexion)
                            Dim BisquetsEnInventario As Integer = CInt(commandVerificarBisquets.ExecuteScalar())
                            If BisquetsEnInventario > 0 AndAlso BisquetsEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Bisquets = Bisquets - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Bisquets en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las hamburgesas'
        If Not String.IsNullOrEmpty(ComboBox7.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox7.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarHamburgesa As String = "SELECT BigKrunch FROM Inventario"
                        Using commandVerificarHamburgesa As New SqlCommand(queryVerificarHamburgesa, conexion)
                            Dim HamburgesaEnInventario As Integer = CInt(commandVerificarHamburgesa.ExecuteScalar())
                            If HamburgesaEnInventario > 0 AndAlso HamburgesaEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET BigKrunch = BigKrunch - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes BigKrunch en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para el Refresco'
        If Not String.IsNullOrEmpty(ComboBox8.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox8.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarRefresco As String = "SELECT Refresco FROM Inventario"
                        Using commandVerificarRefresco As New SqlCommand(queryVerificarRefresco, conexion)
                            Dim RefrescoEnInventario As Integer = CInt(commandVerificarRefresco.ExecuteScalar())
                            If RefrescoEnInventario > 0 AndAlso RefrescoEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Refresco = Refresco  - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Refrescos en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las Papas'
        If Not String.IsNullOrEmpty(ComboBox9.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox9.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPapas As String = "SELECT Papas FROM Inventario"
                        Using commandVerificarPapas As New SqlCommand(queryVerificarPapas, conexion)
                            Dim PapasEnInventario As Integer = CInt(commandVerificarPapas.ExecuteScalar())
                            If PapasEnInventario > 0 AndAlso PapasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Papas = Papas  - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Papas en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If






        'Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
        'conexion.Open()

        ' Verificar si la cantidad de piezas en el inventario es suficiente


        ' Dim VentaID = 0
        'Dim DiaVenta = Label7.Text

        'For Each fila As DataGridViewRow In DataGridView2.Rows
        'Dim ProductoID = CInt(fila.Cells(0).Value)
        'Dim CantidadVendida =

        'Next

        'Using commandVerificarPiezas As New SqlCommand(consultaVerificarPiezas, conexion)
        ' Utiliza ExecuteScalar para obtener un único valor (en este caso, la cantidad de piezas)
        'Dim cantidadPiezas As Integer = Convert.ToInt32(commandVerificarPiezas.ExecuteScalar())

        ' Aquí puedes poner tu lógica para verificar si la cantidad es suficiente
        ' Por ejemplo, comparar con la cantidad que estás intentando vender

        ' Después de verificar, puedes realizar la actualización del inventario u otras acciones necesarias

        'MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Using
        'End Using

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class