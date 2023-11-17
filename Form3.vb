Imports System.Data.SqlClient
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
        PictureBox1.Image = My.Resources.LogoKFC
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Verifica si TextBox1 o ComboBox1 están vacíos '
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(ComboBox1.Text) Then
            MessageBox.Show("Por favor, complete todos los campos antes de realizar la simulacion de venta.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else


            Dim cantidadARestar As Integer
            Dim ventaExitosa As Boolean = True ' Inicializar la variable como verdadera

            'Esto es para las piezas'
            ' Verifica que el ComboBox tenga un valor de texto no vacío
            If Not String.IsNullOrEmpty(ComboBox2.Text) Then
                ' Intenta convertir el valor del ComboBox a un número
                If Integer.TryParse(ComboBox2.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente
                                Dim queryVerificarPiezas As String = "SELECT Piezas FROM Inventario"
                                Using commandVerificarPiezas As New SqlCommand(queryVerificarPiezas, conexion)
                                    Dim piezasEnInventario As Integer = CInt(commandVerificarPiezas.ExecuteScalar())
                                    ' Verificar si hay suficientes piezas en el inventario para la venta
                                    If piezasEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario
                                        Dim query As String = "UPDATE Inventario SET Piezas = Piezas - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficientes Piezas en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If


            ' Esto es para las Tiras '
            If Not String.IsNullOrEmpty(ComboBox3.Text) Then
                ' Intenta convertir el valor del ComboBox a un número '
                If Integer.TryParse(ComboBox3.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero '
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarTiras As String = "SELECT Tiras FROM Inventario"
                                Using commandVerificarTiras As New SqlCommand(queryVerificarTiras, conexion)
                                    Dim TirasEnInventario As Integer = CInt(commandVerificarTiras.ExecuteScalar())
                                    ' Verificar si hay suficientes Tiras en el inventario para la venta '
                                    If TirasEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET Tiras = Tiras - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficientes Tiras en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If


            ' Esto es para el Pure Familiar '
            If Not String.IsNullOrEmpty(ComboBox4.Text) Then
                ' Intenta convertir el valor del ComboBox a un número '
                If Integer.TryParse(ComboBox4.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero '
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarPureFamiliar As String = "SELECT PureFamiliar FROM Inventario"
                                Using commandVerificarPureFamiliar As New SqlCommand(queryVerificarPureFamiliar, conexion)
                                    Dim PureFamiliarEnInventario As Integer = CInt(commandVerificarPureFamiliar.ExecuteScalar())
                                    ' Verificar si hay suficiente Pure Familiar en el inventario para la venta '
                                    If PureFamiliarEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET PureFamiliar = PureFamiliar - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficiente Pure familiar en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If


            ' Esto es para el Pure Individual '
            If Not String.IsNullOrEmpty(ComboBox10.Text) Then
                ' Intenta convertir el valor del ComboBox a un número '
                If Integer.TryParse(ComboBox10.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero '
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarPureIndividual As String = "SELECT PureIndividual FROM Inventario"
                                Using commandVerificarPureIndividual As New SqlCommand(queryVerificarPureIndividual, conexion)
                                    Dim PureIndividualEnInventario As Integer = CInt(commandVerificarPureIndividual.ExecuteScalar())
                                    ' Verificar si hay suficiente Pure Individual en el inventario para la venta '
                                    If PureIndividualEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET PureIndividual = PureIndividual - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficiente Pure individual en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If



            ' Esto es para la Ensalada Familiar '
            If Not String.IsNullOrEmpty(ComboBox5.Text) Then
                ' Intenta convertir el valor del ComboBox a un número '
                If Integer.TryParse(ComboBox5.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero '
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarEnsaladaFamiliar As String = "SELECT EnsaladaFamiliar FROM Inventario"
                                Using commandVerificarEnsaladaFamiliar As New SqlCommand(queryVerificarEnsaladaFamiliar, conexion)
                                    Dim EnsaladaFamiliarEnInventario As Integer = CInt(commandVerificarEnsaladaFamiliar.ExecuteScalar())
                                    ' Verificar si hay suficiente Ensalada Familiar en el inventario para la venta '
                                    If EnsaladaFamiliarEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET EnsaladaFamiliar = EnsaladaFamiliar - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficiente Ensalada familiar en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If


            ' Esto es para la Ensalada Individual '
            If Not String.IsNullOrEmpty(ComboBox11.Text) Then
                ' Intenta convertir el valor del ComboBox a un número '
                If Integer.TryParse(ComboBox11.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero '
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarEnsaladaIndividual As String = "SELECT EnsaladaIndividual FROM Inventario"
                                Using commandVerificarEnsaladaIndividual As New SqlCommand(queryVerificarEnsaladaIndividual, conexion)
                                    Dim EnsaladaIndividualEnInventario As Integer = CInt(commandVerificarEnsaladaIndividual.ExecuteScalar())
                                    ' Verificar si hay suficiente Ensalada Individual en el inventario para la venta '
                                    If EnsaladaIndividualEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET EnsaladaIndividual = EnsaladaIndividual - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficiente Ensalada individual en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
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
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarBisquets As String = "SELECT Bisquets FROM Inventario"
                                Using commandVerificarBisquets As New SqlCommand(queryVerificarBisquets, conexion)
                                    Dim BisquetsEnInventario As Integer = CInt(commandVerificarBisquets.ExecuteScalar())
                                    ' Verificar si hay suficientes Bisquets en el inventario para la venta '
                                    If BisquetsEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET Bisquets = Bisquets - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficientes Bisquets en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If

            'Esto es para las hamburguesas'
            If Not String.IsNullOrEmpty(ComboBox7.Text) Then
                ' Intenta convertir el valor del ComboBox a un número
                If Integer.TryParse(ComboBox7.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarHamburguesa As String = "SELECT BigKrunch FROM Inventario"
                                Using commandVerificarHamburguesa As New SqlCommand(queryVerificarHamburguesa, conexion)
                                    Dim HamburguesaEnInventario As Integer = CInt(commandVerificarHamburguesa.ExecuteScalar())
                                    ' Verificar si hay suficientes hamburguesas en el inventario para la venta '
                                    If HamburguesaEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET BigKrunch = BigKrunch - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficientes BigKrunch en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If

            'Esto es para el Refresco Lata'
            If Not String.IsNullOrEmpty(ComboBox8.Text) Then
                ' Intenta convertir el valor del ComboBox a un número
                If Integer.TryParse(ComboBox8.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarRefrescoLata As String = "SELECT RefrescoLata FROM Inventario"
                                Using commandVerificarRefrescoLata As New SqlCommand(queryVerificarRefrescoLata, conexion)
                                    Dim RefrescoLataEnInventario As Integer = CInt(commandVerificarRefrescoLata.ExecuteScalar())
                                    ' Verificar si hay suficiente Refresco en Lata en el inventario para la venta '
                                    If RefrescoLataEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET RefrescoLata = RefrescoLata - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficiente Refresco en lata en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If


            'Esto es para las Papas Medianas'
            If Not String.IsNullOrEmpty(ComboBox9.Text) Then
                ' Intenta convertir el valor del ComboBox a un número
                If Integer.TryParse(ComboBox9.Text, cantidadARestar) Then
                    ' Verifica si la cantidad a restar es mayor que cero
                    If cantidadARestar > 0 Then
                        ' Recorrer las filas del DataGridView2 '
                        For Each fila As DataGridViewRow In DataGridView2.Rows
                            ' Obtener el valor de la cantidad vendida desde la fila actual del DataGridView2 '
                            Dim cantidadVendida As Integer = CInt(fila.Cells(0).Value)
                            ' Calcular la cantidad a restar multiplicando la cantidad ingresada por la cantidad vendida '
                            Dim cantidadARestarPorProducto As Integer = cantidadARestar * cantidadVendida

                            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                                conexion.Open()
                                ' Verificar si la cantidad en el inventario es suficiente '
                                Dim queryVerificarPapasMedianas As String = "SELECT PapasMedianas FROM Inventario"
                                Using commandVerificarPapasMedianas As New SqlCommand(queryVerificarPapasMedianas, conexion)
                                    Dim PapasMedianasEnInventario As Integer = CInt(commandVerificarPapasMedianas.ExecuteScalar())
                                    ' Verificar si hay suficientes Papas Medianas en el inventario para la venta '
                                    If PapasMedianasEnInventario >= cantidadARestarPorProducto Then
                                        ' Restar la cantidad calculada a la columna correspondiente en la tabla Inventario '
                                        Dim query As String = "UPDATE Inventario SET PapasMedianas = PapasMedianas - @CantidadARestar"
                                        Using command As New SqlCommand(query, conexion)
                                            command.Parameters.AddWithValue("@CantidadARestar", cantidadARestarPorProducto)
                                            command.ExecuteNonQuery()
                                        End Using
                                    Else
                                        ' Si no hay suficientes piezas en el inventario, cambiar ventaExitosa a False
                                        ventaExitosa = False
                                        MessageBox.Show("No hay suficientes Papas medianas en el inventario para realizar la venta.", "Venta Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                End Using
                                conexion.Close()
                            End Using
                        Next
                    Else
                        MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                    End If
                End If
            End If

            ' Verificar si la venta fue exitosa
            If ventaExitosa Then
                MessageBox.Show("¡Venta exitosa! Todas las ventas se han realizado con éxito.", "Ventas Exitosas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Sección del código para registrar las ventas en la base de datos '
                For Each fila As DataGridViewRow In DataGridView2.Rows
                    Dim ProductoID As Integer = CInt(fila.Cells(1).Value)
                    Dim CantidadVendida As Integer = CInt(fila.Cells(0).Value)
                    Dim PrecioVenta As Decimal = CDec(fila.Cells(3).Value) * CInt(fila.Cells(0).Value)

                    Dim GerenteId = ID
                    Dim IDVenta = 0

                    Dim FechaVenta = ComboBox1.Text
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
            End If
        End If
    End Sub
End Class