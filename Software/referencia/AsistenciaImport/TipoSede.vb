' =====================================================================
' TipoSede.vb
' ---------------------------------------------------------------------
' Catálogo enumerado de sedes soportadas por el sistema.
' Para añadir una nueva sede al sistema basta con:
'   1. Añadir el nuevo elemento aquí (ej. FilialNorte).
'   2. Crear la clase concreta heredando de ImportadorSedeBase.
'   3. Registrarla en SedeImportadorFactory.
' Ningún código existente de importación se ve modificado (Principio OCP).
' =====================================================================

Public Enum TipoSede
    Principal = 1
    FueraSede = 2
    Proind = 3
    Consejo = 4
    ' Extensión futura (ejemplo):
    ' FilialNorte = 5
End Enum

