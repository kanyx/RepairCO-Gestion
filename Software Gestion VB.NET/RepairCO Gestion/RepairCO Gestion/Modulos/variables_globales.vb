Module variables_globales
    Public _globalUserData As ArrayList ' # ARREGLO QUE CONTIENE LOS DATOS DEL USUARIO PARA USAR EN TODA LA APLICACION.
    Public _globalClientes As List(Of KeyValuePair(Of String, String)) ' # ARREGLO QUE CONTIENE LA INFORMACION DE LOS CLIENTES PARA DESPLEGAR EN LOS FORMULARIOS.
    Public _globalTipos As List(Of KeyValuePair(Of String, String)) ' # ARREGLO QUE CONTIENE LOS TIPOS DE PRODUCTOS (CARGA DESDE LA BASE DE DATOS).
    Public _globalMarcas As List(Of KeyValuePair(Of String, String)) ' # ARREGLO QUE CONTIENE TODAS LAS MARCAS DE PRODUCTOS (CARGA DESDE LA BASE DE DATOS).
    Public _globalModelos As List(Of KeyValuePair(Of String, String))  ' # ARREGLO QUE CONTIENE TODOS LOS MODELOS DE LAS MARCAS (CARGA DE LA BASE DE DATOS)
    Public _globalEstados As ArrayList ' # ARREGLO QUE CONTIENE LOS ESTADOS USADOS PARA LAS ORDENES DE TRABAJO. (CARGA DESDE LA BASE DE DATOS).
    Public _globalPaises As List(Of KeyValuePair(Of String, String)) ' # CARGA LA LISTA DE PAISES. (CARGA DESDE BASE DE DATOS).
    Public _globalSAMBAU As String = "software" ' # NOMBRE DE USUARIO DE LA CUENTA CON ACCESO AL SERVIDOR SAMBA.
    Public _globalSAMBAP As String = "gestion2016" ' # PASSWORD DEL USUARIO DE LA CUENTA CON ACCESO AL SERVIDOR SAMBA.
End Module
