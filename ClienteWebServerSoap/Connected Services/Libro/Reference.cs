﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWebServerSoap.Libro {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", ConfigurationName="Libro.LibrosPort")]
    public interface LibrosPort {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación deleteLibro no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClienteWebServerSoap.Libro.deleteLibroResponse1 deleteLibro(ClienteWebServerSoap.Libro.deleteLibroRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.deleteLibroResponse1> deleteLibroAsync(ClienteWebServerSoap.Libro.deleteLibroRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación getLibro no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClienteWebServerSoap.Libro.getLibroResponse1 getLibro(ClienteWebServerSoap.Libro.getLibroRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.getLibroResponse1> getLibroAsync(ClienteWebServerSoap.Libro.getLibroRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación createLibro no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClienteWebServerSoap.Libro.createLibroResponse1 createLibro(ClienteWebServerSoap.Libro.createLibroRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.createLibroResponse1> createLibroAsync(ClienteWebServerSoap.Libro.createLibroRequest1 request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación updateLibro no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClienteWebServerSoap.Libro.updateLibroResponse1 updateLibro(ClienteWebServerSoap.Libro.updateLibroRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.updateLibroResponse1> updateLibroAsync(ClienteWebServerSoap.Libro.updateLibroRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class deleteLibroRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class libro : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        private bool idFieldSpecified;
        
        private string tituloField;
        
        private string autorField;
        
        private string editorialField;
        
        private int anoPublicacionField;
        
        private string isbnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string titulo {
            get {
                return this.tituloField;
            }
            set {
                this.tituloField = value;
                this.RaisePropertyChanged("titulo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string autor {
            get {
                return this.autorField;
            }
            set {
                this.autorField = value;
                this.RaisePropertyChanged("autor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string editorial {
            get {
                return this.editorialField;
            }
            set {
                this.editorialField = value;
                this.RaisePropertyChanged("editorial");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int anoPublicacion {
            get {
                return this.anoPublicacionField;
            }
            set {
                this.anoPublicacionField = value;
                this.RaisePropertyChanged("anoPublicacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string isbn {
            get {
                return this.isbnField;
            }
            set {
                this.isbnField = value;
                this.RaisePropertyChanged("isbn");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class deleteLibroResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteLibroRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.deleteLibroRequest deleteLibroRequest;
        
        public deleteLibroRequest1() {
        }
        
        public deleteLibroRequest1(ClienteWebServerSoap.Libro.deleteLibroRequest deleteLibroRequest) {
            this.deleteLibroRequest = deleteLibroRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class deleteLibroResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.deleteLibroResponse deleteLibroResponse;
        
        public deleteLibroResponse1() {
        }
        
        public deleteLibroResponse1(ClienteWebServerSoap.Libro.deleteLibroResponse deleteLibroResponse) {
            this.deleteLibroResponse = deleteLibroResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class getLibroRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class getLibroResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private libro libroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public libro libro {
            get {
                return this.libroField;
            }
            set {
                this.libroField = value;
                this.RaisePropertyChanged("libro");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getLibroRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.getLibroRequest getLibroRequest;
        
        public getLibroRequest1() {
        }
        
        public getLibroRequest1(ClienteWebServerSoap.Libro.getLibroRequest getLibroRequest) {
            this.getLibroRequest = getLibroRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getLibroResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.getLibroResponse getLibroResponse;
        
        public getLibroResponse1() {
        }
        
        public getLibroResponse1(ClienteWebServerSoap.Libro.getLibroResponse getLibroResponse) {
            this.getLibroResponse = getLibroResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class createLibroRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private libro libroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public libro libro {
            get {
                return this.libroField;
            }
            set {
                this.libroField = value;
                this.RaisePropertyChanged("libro");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class createLibroResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private libro libroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public libro libro {
            get {
                return this.libroField;
            }
            set {
                this.libroField = value;
                this.RaisePropertyChanged("libro");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createLibroRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.createLibroRequest createLibroRequest;
        
        public createLibroRequest1() {
        }
        
        public createLibroRequest1(ClienteWebServerSoap.Libro.createLibroRequest createLibroRequest) {
            this.createLibroRequest = createLibroRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class createLibroResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.createLibroResponse createLibroResponse;
        
        public createLibroResponse1() {
        }
        
        public createLibroResponse1(ClienteWebServerSoap.Libro.createLibroResponse createLibroResponse) {
            this.createLibroResponse = createLibroResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class updateLibroRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private libro libroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public libro libro {
            get {
                return this.libroField;
            }
            set {
                this.libroField = value;
                this.RaisePropertyChanged("libro");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://spring.io/guides/gs-producing-web-service")]
    public partial class updateLibroResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private libro libroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public libro libro {
            get {
                return this.libroField;
            }
            set {
                this.libroField = value;
                this.RaisePropertyChanged("libro");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateLibroRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.updateLibroRequest updateLibroRequest;
        
        public updateLibroRequest1() {
        }
        
        public updateLibroRequest1(ClienteWebServerSoap.Libro.updateLibroRequest updateLibroRequest) {
            this.updateLibroRequest = updateLibroRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateLibroResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://spring.io/guides/gs-producing-web-service", Order=0)]
        public ClienteWebServerSoap.Libro.updateLibroResponse updateLibroResponse;
        
        public updateLibroResponse1() {
        }
        
        public updateLibroResponse1(ClienteWebServerSoap.Libro.updateLibroResponse updateLibroResponse) {
            this.updateLibroResponse = updateLibroResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibrosPortChannel : ClienteWebServerSoap.Libro.LibrosPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibrosPortClient : System.ServiceModel.ClientBase<ClienteWebServerSoap.Libro.LibrosPort>, ClienteWebServerSoap.Libro.LibrosPort {
        
        public LibrosPortClient() {
        }
        
        public LibrosPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibrosPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWebServerSoap.Libro.deleteLibroResponse1 ClienteWebServerSoap.Libro.LibrosPort.deleteLibro(ClienteWebServerSoap.Libro.deleteLibroRequest1 request) {
            return base.Channel.deleteLibro(request);
        }
        
        public ClienteWebServerSoap.Libro.deleteLibroResponse deleteLibro(ClienteWebServerSoap.Libro.deleteLibroRequest deleteLibroRequest) {
            ClienteWebServerSoap.Libro.deleteLibroRequest1 inValue = new ClienteWebServerSoap.Libro.deleteLibroRequest1();
            inValue.deleteLibroRequest = deleteLibroRequest;
            ClienteWebServerSoap.Libro.deleteLibroResponse1 retVal = ((ClienteWebServerSoap.Libro.LibrosPort)(this)).deleteLibro(inValue);
            return retVal.deleteLibroResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.deleteLibroResponse1> ClienteWebServerSoap.Libro.LibrosPort.deleteLibroAsync(ClienteWebServerSoap.Libro.deleteLibroRequest1 request) {
            return base.Channel.deleteLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.deleteLibroResponse1> deleteLibroAsync(ClienteWebServerSoap.Libro.deleteLibroRequest deleteLibroRequest) {
            ClienteWebServerSoap.Libro.deleteLibroRequest1 inValue = new ClienteWebServerSoap.Libro.deleteLibroRequest1();
            inValue.deleteLibroRequest = deleteLibroRequest;
            return ((ClienteWebServerSoap.Libro.LibrosPort)(this)).deleteLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWebServerSoap.Libro.getLibroResponse1 ClienteWebServerSoap.Libro.LibrosPort.getLibro(ClienteWebServerSoap.Libro.getLibroRequest1 request) {
            return base.Channel.getLibro(request);
        }
        
        public ClienteWebServerSoap.Libro.getLibroResponse getLibro(ClienteWebServerSoap.Libro.getLibroRequest getLibroRequest) {
            ClienteWebServerSoap.Libro.getLibroRequest1 inValue = new ClienteWebServerSoap.Libro.getLibroRequest1();
            inValue.getLibroRequest = getLibroRequest;
            ClienteWebServerSoap.Libro.getLibroResponse1 retVal = ((ClienteWebServerSoap.Libro.LibrosPort)(this)).getLibro(inValue);
            return retVal.getLibroResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.getLibroResponse1> ClienteWebServerSoap.Libro.LibrosPort.getLibroAsync(ClienteWebServerSoap.Libro.getLibroRequest1 request) {
            return base.Channel.getLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.getLibroResponse1> getLibroAsync(ClienteWebServerSoap.Libro.getLibroRequest getLibroRequest) {
            ClienteWebServerSoap.Libro.getLibroRequest1 inValue = new ClienteWebServerSoap.Libro.getLibroRequest1();
            inValue.getLibroRequest = getLibroRequest;
            return ((ClienteWebServerSoap.Libro.LibrosPort)(this)).getLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWebServerSoap.Libro.createLibroResponse1 ClienteWebServerSoap.Libro.LibrosPort.createLibro(ClienteWebServerSoap.Libro.createLibroRequest1 request) {
            return base.Channel.createLibro(request);
        }
        
        public ClienteWebServerSoap.Libro.createLibroResponse createLibro(ClienteWebServerSoap.Libro.createLibroRequest createLibroRequest) {
            ClienteWebServerSoap.Libro.createLibroRequest1 inValue = new ClienteWebServerSoap.Libro.createLibroRequest1();
            inValue.createLibroRequest = createLibroRequest;
            ClienteWebServerSoap.Libro.createLibroResponse1 retVal = ((ClienteWebServerSoap.Libro.LibrosPort)(this)).createLibro(inValue);
            return retVal.createLibroResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.createLibroResponse1> ClienteWebServerSoap.Libro.LibrosPort.createLibroAsync(ClienteWebServerSoap.Libro.createLibroRequest1 request) {
            return base.Channel.createLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.createLibroResponse1> createLibroAsync(ClienteWebServerSoap.Libro.createLibroRequest createLibroRequest) {
            ClienteWebServerSoap.Libro.createLibroRequest1 inValue = new ClienteWebServerSoap.Libro.createLibroRequest1();
            inValue.createLibroRequest = createLibroRequest;
            return ((ClienteWebServerSoap.Libro.LibrosPort)(this)).createLibroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteWebServerSoap.Libro.updateLibroResponse1 ClienteWebServerSoap.Libro.LibrosPort.updateLibro(ClienteWebServerSoap.Libro.updateLibroRequest1 request) {
            return base.Channel.updateLibro(request);
        }
        
        public ClienteWebServerSoap.Libro.updateLibroResponse updateLibro(ClienteWebServerSoap.Libro.updateLibroRequest updateLibroRequest) {
            ClienteWebServerSoap.Libro.updateLibroRequest1 inValue = new ClienteWebServerSoap.Libro.updateLibroRequest1();
            inValue.updateLibroRequest = updateLibroRequest;
            ClienteWebServerSoap.Libro.updateLibroResponse1 retVal = ((ClienteWebServerSoap.Libro.LibrosPort)(this)).updateLibro(inValue);
            return retVal.updateLibroResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.updateLibroResponse1> ClienteWebServerSoap.Libro.LibrosPort.updateLibroAsync(ClienteWebServerSoap.Libro.updateLibroRequest1 request) {
            return base.Channel.updateLibroAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClienteWebServerSoap.Libro.updateLibroResponse1> updateLibroAsync(ClienteWebServerSoap.Libro.updateLibroRequest updateLibroRequest) {
            ClienteWebServerSoap.Libro.updateLibroRequest1 inValue = new ClienteWebServerSoap.Libro.updateLibroRequest1();
            inValue.updateLibroRequest = updateLibroRequest;
            return ((ClienteWebServerSoap.Libro.LibrosPort)(this)).updateLibroAsync(inValue);
        }
    }
}