﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace WS_UNIGIS
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://unisolutions.com.ar/", ConfigurationName:="WS_UNIGIS.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/Login", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Login(ByVal SystemUser As String, ByVal Password As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/Login", ReplyAction:="*")>  _
        Function LoginAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/Logout", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Logout() As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/Logout", ReplyAction:="*")>  _
        Function LogoutAsync() As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/InsertarEvento", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function InsertarEvento(ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal Rumbo As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Crudo As String) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/InsertarEvento", ReplyAction:="*")>  _
        Function InsertarEventoAsync(ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal Rumbo As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Crudo As String) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEventos", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYInsertarEventos(ByVal SystemUser As String, ByVal Password As String, ByVal Eventos() As WS_UNIGIS.pEvento) As Integer()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEventos", ReplyAction:="*")>  _
        Function LoginYInsertarEventosAsync(ByVal SystemUser As String, ByVal Password As String, ByVal Eventos() As WS_UNIGIS.pEvento) As System.Threading.Tasks.Task(Of Integer())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEvento2", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYInsertarEvento2(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Valido As Boolean, ByVal Sensores() As WS_UNIGIS.pSensor) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEvento2", ReplyAction:="*")>  _
        Function LoginYInsertarEvento2Async(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Valido As Boolean, ByVal Sensores() As WS_UNIGIS.pSensor) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEvento", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYInsertarEvento(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYInsertarEvento", ReplyAction:="*")>  _
        Function LoginYInsertarEventoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/InSession", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function InSession() As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/InSession", ReplyAction:="*")>  _
        Function InSessionAsync() As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ObtenerComando", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ObtenerComando() As WS_UNIGIS.Comando
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ObtenerComando", ReplyAction:="*")>  _
        Function ObtenerComandoAsync() As System.Threading.Tasks.Task(Of WS_UNIGIS.Comando)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ComandoProcesado", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ComandoProcesado(ByVal NUMERO As Integer, ByVal correcto As Boolean) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ComandoProcesado", ReplyAction:="*")>  _
        Function ComandoProcesadoAsync(ByVal NUMERO As Integer, ByVal correcto As Boolean) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/EstadoComando", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function EstadoComando(ByVal NUMERO As Integer, ByVal MSG As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/EstadoComando", ReplyAction:="*")>  _
        Function EstadoComandoAsync(ByVal NUMERO As Integer, ByVal MSG As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/CambiarClave", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CambiarClave(ByVal AntiguaClave As String, ByVal NuevaClave As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/CambiarClave", ReplyAction:="*")>  _
        Function CambiarClaveAsync(ByVal AntiguaClave As String, ByVal NuevaClave As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYCambiarClave", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYCambiarClave(ByVal SystemUser As String, ByVal Password As String, ByVal NuevaClave As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYCambiarClave", ReplyAction:="*")>  _
        Function LoginYCambiarClaveAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NuevaClave As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYObtenerComando", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYObtenerComando(ByVal SystemUser As String, ByVal Password As String) As WS_UNIGIS.Comando
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYObtenerComando", ReplyAction:="*")>  _
        Function LoginYObtenerComandoAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of WS_UNIGIS.Comando)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYComandoProcesado", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYComandoProcesado(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal correcto As Boolean) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYComandoProcesado", ReplyAction:="*")>  _
        Function LoginYComandoProcesadoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal correcto As Boolean) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYEstadoComando", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function LoginYEstadoComando(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal MSG As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/LoginYEstadoComando", ReplyAction:="*")>  _
        Function LoginYEstadoComandoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal MSG As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ConsultarVehiculosEnViaje", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ConsultarVehiculosEnViaje(ByVal SystemUser As String, ByVal Password As String) As WS_UNIGIS.Vehiculo()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://unisolutions.com.ar/ConsultarVehiculosEnViaje", ReplyAction:="*")>  _
        Function ConsultarVehiculosEnViajeAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of WS_UNIGIS.Vehiculo())
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://unisolutions.com.ar/")>  _
    Partial Public Class pEvento
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private dominioField As String
        
        Private nroSerieField As String
        
        Private codigoField As String
        
        Private latitudField As Double
        
        Private longitudField As Double
        
        Private altitudField As Double
        
        Private velocidadField As Double
        
        Private fechaHoraEventoField As Date
        
        Private fechaHoraRecepcionField As Date
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Dominio() As String
            Get
                Return Me.dominioField
            End Get
            Set
                Me.dominioField = value
                Me.RaisePropertyChanged("Dominio")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property NroSerie() As String
            Get
                Return Me.nroSerieField
            End Get
            Set
                Me.nroSerieField = value
                Me.RaisePropertyChanged("NroSerie")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property Codigo() As String
            Get
                Return Me.codigoField
            End Get
            Set
                Me.codigoField = value
                Me.RaisePropertyChanged("Codigo")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property Latitud() As Double
            Get
                Return Me.latitudField
            End Get
            Set
                Me.latitudField = value
                Me.RaisePropertyChanged("Latitud")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>  _
        Public Property Longitud() As Double
            Get
                Return Me.longitudField
            End Get
            Set
                Me.longitudField = value
                Me.RaisePropertyChanged("Longitud")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>  _
        Public Property Altitud() As Double
            Get
                Return Me.altitudField
            End Get
            Set
                Me.altitudField = value
                Me.RaisePropertyChanged("Altitud")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>  _
        Public Property Velocidad() As Double
            Get
                Return Me.velocidadField
            End Get
            Set
                Me.velocidadField = value
                Me.RaisePropertyChanged("Velocidad")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>  _
        Public Property FechaHoraEvento() As Date
            Get
                Return Me.fechaHoraEventoField
            End Get
            Set
                Me.fechaHoraEventoField = value
                Me.RaisePropertyChanged("FechaHoraEvento")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>  _
        Public Property FechaHoraRecepcion() As Date
            Get
                Return Me.fechaHoraRecepcionField
            End Get
            Set
                Me.fechaHoraRecepcionField = value
                Me.RaisePropertyChanged("FechaHoraRecepcion")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://unisolutions.com.ar/")>  _
    Partial Public Class Vehiculo
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private dominioField As String
        
        Private nroSerieField As String
        
        Private fechaUltimoReporteField As System.Nullable(Of Date)
        
        Private fechaRegistracionField As System.Nullable(Of Date)
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Dominio() As String
            Get
                Return Me.dominioField
            End Get
            Set
                Me.dominioField = value
                Me.RaisePropertyChanged("Dominio")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property NroSerie() As String
            Get
                Return Me.nroSerieField
            End Get
            Set
                Me.nroSerieField = value
                Me.RaisePropertyChanged("NroSerie")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Order:=2)>  _
        Public Property FechaUltimoReporte() As System.Nullable(Of Date)
            Get
                Return Me.fechaUltimoReporteField
            End Get
            Set
                Me.fechaUltimoReporteField = value
                Me.RaisePropertyChanged("FechaUltimoReporte")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Order:=3)>  _
        Public Property FechaRegistracion() As System.Nullable(Of Date)
            Get
                Return Me.fechaRegistracionField
            End Get
            Set
                Me.fechaRegistracionField = value
                Me.RaisePropertyChanged("FechaRegistracion")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://unisolutions.com.ar/")>  _
    Partial Public Class Comando
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private cMDField As String
        
        Private uNIDADField As String
        
        Private eQUIPOField As String
        
        Private nUMEROField As Integer
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property CMD() As String
            Get
                Return Me.cMDField
            End Get
            Set
                Me.cMDField = value
                Me.RaisePropertyChanged("CMD")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property UNIDAD() As String
            Get
                Return Me.uNIDADField
            End Get
            Set
                Me.uNIDADField = value
                Me.RaisePropertyChanged("UNIDAD")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property EQUIPO() As String
            Get
                Return Me.eQUIPOField
            End Get
            Set
                Me.eQUIPOField = value
                Me.RaisePropertyChanged("EQUIPO")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property NUMERO() As Integer
            Get
                Return Me.nUMEROField
            End Get
            Set
                Me.nUMEROField = value
                Me.RaisePropertyChanged("NUMERO")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://unisolutions.com.ar/")>  _
    Partial Public Class pSensor
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private claveField As String
        
        Private valorField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Clave() As String
            Get
                Return Me.claveField
            End Get
            Set
                Me.claveField = value
                Me.RaisePropertyChanged("Clave")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property Valor() As String
            Get
                Return Me.valorField
            End Get
            Set
                Me.valorField = value
                Me.RaisePropertyChanged("Valor")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits WS_UNIGIS.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of WS_UNIGIS.ServiceSoap)
        Implements WS_UNIGIS.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Login(ByVal SystemUser As String, ByVal Password As String) As Boolean Implements WS_UNIGIS.ServiceSoap.Login
            Return MyBase.Channel.Login(SystemUser, Password)
        End Function
        
        Public Function LoginAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.LoginAsync
            Return MyBase.Channel.LoginAsync(SystemUser, Password)
        End Function
        
        Public Function Logout() As Boolean Implements WS_UNIGIS.ServiceSoap.Logout
            Return MyBase.Channel.Logout
        End Function
        
        Public Function LogoutAsync() As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.LogoutAsync
            Return MyBase.Channel.LogoutAsync
        End Function
        
        Public Function InsertarEvento(ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal Rumbo As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Crudo As String) As Integer Implements WS_UNIGIS.ServiceSoap.InsertarEvento
            Return MyBase.Channel.InsertarEvento(Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, Rumbo, FechaHoraEvento, FechaHoraRecepcion, Crudo)
        End Function
        
        Public Function InsertarEventoAsync(ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal Rumbo As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Crudo As String) As System.Threading.Tasks.Task(Of Integer) Implements WS_UNIGIS.ServiceSoap.InsertarEventoAsync
            Return MyBase.Channel.InsertarEventoAsync(Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, Rumbo, FechaHoraEvento, FechaHoraRecepcion, Crudo)
        End Function
        
        Public Function LoginYInsertarEventos(ByVal SystemUser As String, ByVal Password As String, ByVal Eventos() As WS_UNIGIS.pEvento) As Integer() Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEventos
            Return MyBase.Channel.LoginYInsertarEventos(SystemUser, Password, Eventos)
        End Function
        
        Public Function LoginYInsertarEventosAsync(ByVal SystemUser As String, ByVal Password As String, ByVal Eventos() As WS_UNIGIS.pEvento) As System.Threading.Tasks.Task(Of Integer()) Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEventosAsync
            Return MyBase.Channel.LoginYInsertarEventosAsync(SystemUser, Password, Eventos)
        End Function
        
        Public Function LoginYInsertarEvento2(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Valido As Boolean, ByVal Sensores() As WS_UNIGIS.pSensor) As Integer Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEvento2
            Return MyBase.Channel.LoginYInsertarEvento2(SystemUser, Password, Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, FechaHoraEvento, FechaHoraRecepcion, Valido, Sensores)
        End Function
        
        Public Function LoginYInsertarEvento2Async(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date, ByVal Valido As Boolean, ByVal Sensores() As WS_UNIGIS.pSensor) As System.Threading.Tasks.Task(Of Integer) Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEvento2Async
            Return MyBase.Channel.LoginYInsertarEvento2Async(SystemUser, Password, Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, FechaHoraEvento, FechaHoraRecepcion, Valido, Sensores)
        End Function
        
        Public Function LoginYInsertarEvento(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date) As Integer Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEvento
            Return MyBase.Channel.LoginYInsertarEvento(SystemUser, Password, Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, FechaHoraEvento, FechaHoraRecepcion)
        End Function
        
        Public Function LoginYInsertarEventoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal Dominio As String, ByVal NroSerie As String, ByVal Codigo As String, ByVal Latitud As Double, ByVal Longitud As Double, ByVal Altitud As Double, ByVal Velocidad As Double, ByVal FechaHoraEvento As Date, ByVal FechaHoraRecepcion As Date) As System.Threading.Tasks.Task(Of Integer) Implements WS_UNIGIS.ServiceSoap.LoginYInsertarEventoAsync
            Return MyBase.Channel.LoginYInsertarEventoAsync(SystemUser, Password, Dominio, NroSerie, Codigo, Latitud, Longitud, Altitud, Velocidad, FechaHoraEvento, FechaHoraRecepcion)
        End Function
        
        Public Function InSession() As Boolean Implements WS_UNIGIS.ServiceSoap.InSession
            Return MyBase.Channel.InSession
        End Function
        
        Public Function InSessionAsync() As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.InSessionAsync
            Return MyBase.Channel.InSessionAsync
        End Function
        
        Public Function ObtenerComando() As WS_UNIGIS.Comando Implements WS_UNIGIS.ServiceSoap.ObtenerComando
            Return MyBase.Channel.ObtenerComando
        End Function
        
        Public Function ObtenerComandoAsync() As System.Threading.Tasks.Task(Of WS_UNIGIS.Comando) Implements WS_UNIGIS.ServiceSoap.ObtenerComandoAsync
            Return MyBase.Channel.ObtenerComandoAsync
        End Function
        
        Public Function ComandoProcesado(ByVal NUMERO As Integer, ByVal correcto As Boolean) As Boolean Implements WS_UNIGIS.ServiceSoap.ComandoProcesado
            Return MyBase.Channel.ComandoProcesado(NUMERO, correcto)
        End Function
        
        Public Function ComandoProcesadoAsync(ByVal NUMERO As Integer, ByVal correcto As Boolean) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.ComandoProcesadoAsync
            Return MyBase.Channel.ComandoProcesadoAsync(NUMERO, correcto)
        End Function
        
        Public Function EstadoComando(ByVal NUMERO As Integer, ByVal MSG As String) As Boolean Implements WS_UNIGIS.ServiceSoap.EstadoComando
            Return MyBase.Channel.EstadoComando(NUMERO, MSG)
        End Function
        
        Public Function EstadoComandoAsync(ByVal NUMERO As Integer, ByVal MSG As String) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.EstadoComandoAsync
            Return MyBase.Channel.EstadoComandoAsync(NUMERO, MSG)
        End Function
        
        Public Function CambiarClave(ByVal AntiguaClave As String, ByVal NuevaClave As String) As Boolean Implements WS_UNIGIS.ServiceSoap.CambiarClave
            Return MyBase.Channel.CambiarClave(AntiguaClave, NuevaClave)
        End Function
        
        Public Function CambiarClaveAsync(ByVal AntiguaClave As String, ByVal NuevaClave As String) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.CambiarClaveAsync
            Return MyBase.Channel.CambiarClaveAsync(AntiguaClave, NuevaClave)
        End Function
        
        Public Function LoginYCambiarClave(ByVal SystemUser As String, ByVal Password As String, ByVal NuevaClave As String) As Boolean Implements WS_UNIGIS.ServiceSoap.LoginYCambiarClave
            Return MyBase.Channel.LoginYCambiarClave(SystemUser, Password, NuevaClave)
        End Function
        
        Public Function LoginYCambiarClaveAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NuevaClave As String) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.LoginYCambiarClaveAsync
            Return MyBase.Channel.LoginYCambiarClaveAsync(SystemUser, Password, NuevaClave)
        End Function
        
        Public Function LoginYObtenerComando(ByVal SystemUser As String, ByVal Password As String) As WS_UNIGIS.Comando Implements WS_UNIGIS.ServiceSoap.LoginYObtenerComando
            Return MyBase.Channel.LoginYObtenerComando(SystemUser, Password)
        End Function
        
        Public Function LoginYObtenerComandoAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of WS_UNIGIS.Comando) Implements WS_UNIGIS.ServiceSoap.LoginYObtenerComandoAsync
            Return MyBase.Channel.LoginYObtenerComandoAsync(SystemUser, Password)
        End Function
        
        Public Function LoginYComandoProcesado(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal correcto As Boolean) As Boolean Implements WS_UNIGIS.ServiceSoap.LoginYComandoProcesado
            Return MyBase.Channel.LoginYComandoProcesado(SystemUser, Password, NUMERO, correcto)
        End Function
        
        Public Function LoginYComandoProcesadoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal correcto As Boolean) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.LoginYComandoProcesadoAsync
            Return MyBase.Channel.LoginYComandoProcesadoAsync(SystemUser, Password, NUMERO, correcto)
        End Function
        
        Public Function LoginYEstadoComando(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal MSG As String) As Boolean Implements WS_UNIGIS.ServiceSoap.LoginYEstadoComando
            Return MyBase.Channel.LoginYEstadoComando(SystemUser, Password, NUMERO, MSG)
        End Function
        
        Public Function LoginYEstadoComandoAsync(ByVal SystemUser As String, ByVal Password As String, ByVal NUMERO As Integer, ByVal MSG As String) As System.Threading.Tasks.Task(Of Boolean) Implements WS_UNIGIS.ServiceSoap.LoginYEstadoComandoAsync
            Return MyBase.Channel.LoginYEstadoComandoAsync(SystemUser, Password, NUMERO, MSG)
        End Function
        
        Public Function ConsultarVehiculosEnViaje(ByVal SystemUser As String, ByVal Password As String) As WS_UNIGIS.Vehiculo() Implements WS_UNIGIS.ServiceSoap.ConsultarVehiculosEnViaje
            Return MyBase.Channel.ConsultarVehiculosEnViaje(SystemUser, Password)
        End Function
        
        Public Function ConsultarVehiculosEnViajeAsync(ByVal SystemUser As String, ByVal Password As String) As System.Threading.Tasks.Task(Of WS_UNIGIS.Vehiculo()) Implements WS_UNIGIS.ServiceSoap.ConsultarVehiculosEnViajeAsync
            Return MyBase.Channel.ConsultarVehiculosEnViajeAsync(SystemUser, Password)
        End Function
    End Class
End Namespace
