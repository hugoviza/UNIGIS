Module Module1

    Sub Main()

        'Dentro de la solución se agregó una referencia de servicio web soap'
        'la referencia de servicio tiene el nombre de WS_UNIGIS y almacena los datos que ofrece el ws de unigis'

        'Si se requiere cambiar la referencia o crearla desde 0 en tu sistema principal entonces:'
        '=> Abre el explorador de soluciones'
        '=> ´Si estás creando la referencia desde 0 omite este paso **** En la seccion de "Connected Services" Eliminar la referencia WS_UNIGIS '
        '=> Busca la sección de "Referencias" da clic derecho y selecciona la opcion de "Agregar referencia de servicio" y se abrirá un modal'
        '=> Sobre el campo de dirección pega la ruta del asmx ej. http://186.122.152.69/unigis_mx/MAPI/SOAP/GPS/Service.asmx y da clic sobre el botón "Ir"'
        '=> Sobre el campo "Espacio de nombres" agrega el nombre WS_UNIGIS'
        '=> Da clic sobre aceptar y automáticamente se agregará toda la información del ws de unigis'

        'Generamos un nuevo cliente de soap'
        Dim client As WS_UNIGIS.ServiceSoapClient = New WS_UNIGIS.ServiceSoapClient()

        Console.WriteLine("INICIANDO REPORTE DE EVENTOS A UNIGIS")

        Dim codigo As String = "POSICIONAMIENTO"
        Dim dominio As String = "QWE12331" 'NUMERO DE PLACAS DEL TRACTO'
        Dim altitud As Double = 0
        Dim latitud As Double = 25.714795886515788
        Dim longitud As Double = -100.34231029895318
        Dim fechaHoraEvento As Date = Date.Parse("2020-12-11 23:00:00")
        Dim fechaHoraRecepcion As Date = Date.Parse("2020-12-11 23:05:00")
        Dim NoSerie As String = ""
        Dim velocidad As Double = 0
        Dim intEstatusResponse As Integer = client.LoginYInsertarEvento(
                "Quicktrack",
                "Quicktrack8945",
                dominio,
                NoSerie,
                codigo,
                latitud,
                longitud,
                altitud,
                velocidad,
                fechaHoraEvento,
                fechaHoraRecepcion)

        'Unigis retorna un estatus > 0 cuando el evento se guardó correctamente'
        'En caso de error nos retorna un valor < 0'
        'Nos retornan un valor por cada evento gps que enviamos'

        Console.WriteLine("RESPUESTA UNIGIS: " + IIf(intEstatusResponse >= 0, "Ok", "Fail"))

        If intEstatusResponse < 0 Then
            'Aqui tus validaciones en caso de error'
            'Puedes guardar logs de los eventos que han fallado'
        End If

    End Sub

End Module
