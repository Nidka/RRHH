Imports System.Data.SqlClient

Public Interface IAsistenciaService
    Function Access2Sql(importador As ISedeImportador,
                        fechaInicial As Date,
                        fechaFinal As Date,
                        forzar As Boolean,
                        Optional cnSql As SqlConnection = Nothing) As Boolean
End Interface
