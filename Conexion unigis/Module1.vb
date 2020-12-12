Module Module1

    Sub Main()

        'Dentro de la solución se agregó una referencia de servicio web soap'
        'la referencia de servicio tiene el nombre de WS_UNIGIS'


        'Generamos un nuevo cliente de soap'
        Dim client As WS_UNIGIS.ServiceSoapClient = New WS_UNIGIS.ServiceSoapClient()

        'Obtenemos los eventos por reportar'
        Dim arrayEventos() As WS_UNIGIS.pEvento = ObtenerEventosGPS()

        If arrayEventos.Length > 0 Then
            Console.WriteLine("INICIANDO REPORTE DE EVENTOS A UNIGIS")
            Console.WriteLine(arrayEventos.Length.ToString() + " eventos por reportar")

            'Dentro del cliente SOAP ejecutamos el servicio LoginYInsertarEventos'

            '===>>> esto es lo que comenta la documentación'  'LoginYInsertarEventos: Loguea e inserta multiples eventos en modo batch'

            Dim intEstatusResponse() As Integer = client.LoginYInsertarEventos("Quicktrack", "Quicktrack8945", arrayEventos)

            'Unigis retorna un estatus > 0 cuando el evento se guardó correctamente'
            'En caso de error nos retorna un valor < 0'
            'Nos retornan un valor por cada evento gps que enviamos'

            Console.WriteLine("RESPUESTA UNIGIS")

            Dim indexResponse As Integer = 0
            For indexResponse = 0 To (intEstatusResponse.Length - 1) Step 1

                Console.WriteLine("Evento[" + intEstatusResponse(indexResponse).ToString() + "] : " + IIf(intEstatusResponse(indexResponse) >= 0, "Ok", "Fail"))

                If intEstatusResponse(indexResponse) < 0 Then
                    'Aqui tus validaciones en caso de error'
                    'Puedes guardar logs de los eventos que han fallado'
                    'el evento fallido es arrayEventos(indexResponse)'
                End If
            Next
        Else
            Console.WriteLine("SIN EVENTOS POR REPORTAR A UNIGIS")
        End If

    End Sub



    Function ObtenerEventosGPS() As WS_UNIGIS.pEvento()

        'Aqui puedes ejecutar tu consulta para obtener todos los eventos'
        'Sobre el resultado de tu consulta aplica un .length'
        Dim totalEventosGPS As Int16 = 10

        'Validamos si hay eventos por castear'
        If totalEventosGPS > 0 Then

            Dim arrayEventos() As WS_UNIGIS.pEvento = New WS_UNIGIS.pEvento((totalEventosGPS - 1)) {}
            Dim index As Int16 = 0

            For index = 0 To (totalEventosGPS - 1) Step 1
                'Aqui recorremos cada evento gps que has obtenido desde tu base de datos'
                'Damos el formato correcto a los eventos gps por reportar'
                Dim evento As New WS_UNIGIS.pEvento()
                evento.Codigo = "POSICIONAMIENTO"
                evento.Dominio = "QWE12331" 'NUMERO DE PLACAS DEL TRACTO'
                evento.Altitud = 0
                evento.Latitud = 25.714795886515788
                evento.Longitud = -100.34231029895318
                evento.FechaHoraEvento = Date.Parse("2020-12-11 23:00:00")
                evento.FechaHoraRecepcion = Date.Parse("2020-12-11 23:05:00")
                evento.NroSerie = ""
                evento.Velocidad = 0
                'añadimos el evento al array'
                arrayEventos(index) = evento
            Next

            Return arrayEventos
        Else
            Return New WS_UNIGIS.pEvento() {}
        End If



    End Function




End Module
