Imports System.Data.OleDb
Public Class Dao
    Dim rutaConexion As String
    Public ruta As String = "C:\Terminal\Terminal\bin\Debug\StockVentas.accdb"
    Dim conexion As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim cadena As String = "Provider = Microsoft.Ace.oledb.12.0; Data Source =" & RutaConexion & "; Persist security info = false"


    Protected Sub abrirConexion()
        Try
            conexion.ConnectionString = cadena
            conexion.Open()

        Catch ex As Exception
            MsgBox("Hubo algun error al abrir la conexion a la base de datos --> " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Protected Sub cerrarConexion()
        Try
            conexion.Close()
            ds.Dispose()
        Catch ex As Exception

        End Try


    End Sub

    Public Sub busqueda(sql As String, ByRef ObjDS As DataSet)
        Try
            abrirConexion()
            Dim da As New OleDbDataAdapter(sql, conexion)
            Dim ds As New DataSet
            da.Fill(ds, 0)
            ObjDS = ds
            cerrarConexion()
        Catch ex As Exception
            MsgBox("hubo algun error al ejecutar la consulta --> " & ex.Message.ToString, vbCritical, "Error")
        End Try


    End Sub

    Public Function ABM(sql As String)

        Try
            abrirConexion()

            Dim comando As OleDbCommand = conexion.CreateCommand()
            comando.CommandText = sql


            comando.ExecuteNonQuery()
            cerrarConexion()
            Return 1
        Catch ex As Exception
            MsgBox("hubo un erroral cargar / actualizar producto ----> " & ex.Message.ToString)
            cerrarConexion()
            Return 0
        End Try

    End Function



End Class
