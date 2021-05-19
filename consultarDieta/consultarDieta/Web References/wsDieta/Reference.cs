﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace consultarDieta.wsDieta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsDietaSoap", Namespace="http://tempuri.org/")]
    public partial class wsDieta : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback guardarDietaOperationCompleted;
        
        private System.Threading.SendOrPostCallback modificarDietaOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarDietaOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarDietaPorClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarClientePorNombreOperationCompleted;
        
        private System.Threading.SendOrPostCallback mostrarTodosOperationCompleted;
        
        private System.Threading.SendOrPostCallback guardarClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback modificarClienteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsDieta() {
            this.Url = global::consultarDieta.Properties.Settings.Default.consultarDieta_wsDieta_wsDieta;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event guardarDietaCompletedEventHandler guardarDietaCompleted;
        
        /// <remarks/>
        public event modificarDietaCompletedEventHandler modificarDietaCompleted;
        
        /// <remarks/>
        public event eliminarDietaCompletedEventHandler eliminarDietaCompleted;
        
        /// <remarks/>
        public event buscarDietaPorClienteCompletedEventHandler buscarDietaPorClienteCompleted;
        
        /// <remarks/>
        public event buscarClientePorNombreCompletedEventHandler buscarClientePorNombreCompleted;
        
        /// <remarks/>
        public event mostrarTodosCompletedEventHandler mostrarTodosCompleted;
        
        /// <remarks/>
        public event guardarClienteCompletedEventHandler guardarClienteCompleted;
        
        /// <remarks/>
        public event eliminarClienteCompletedEventHandler eliminarClienteCompleted;
        
        /// <remarks/>
        public event modificarClienteCompletedEventHandler modificarClienteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/guardarDieta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet guardarDieta(string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario) {
            object[] results = this.Invoke("guardarDieta", new object[] {
                        nombre,
                        fechaInicio,
                        fechaFinal,
                        idCliente,
                        idUsuario});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void guardarDietaAsync(string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario) {
            this.guardarDietaAsync(nombre, fechaInicio, fechaFinal, idCliente, idUsuario, null);
        }
        
        /// <remarks/>
        public void guardarDietaAsync(string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario, object userState) {
            if ((this.guardarDietaOperationCompleted == null)) {
                this.guardarDietaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnguardarDietaOperationCompleted);
            }
            this.InvokeAsync("guardarDieta", new object[] {
                        nombre,
                        fechaInicio,
                        fechaFinal,
                        idCliente,
                        idUsuario}, this.guardarDietaOperationCompleted, userState);
        }
        
        private void OnguardarDietaOperationCompleted(object arg) {
            if ((this.guardarDietaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.guardarDietaCompleted(this, new guardarDietaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/modificarDieta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet modificarDieta(string idDieta, string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario) {
            object[] results = this.Invoke("modificarDieta", new object[] {
                        idDieta,
                        nombre,
                        fechaInicio,
                        fechaFinal,
                        idCliente,
                        idUsuario});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void modificarDietaAsync(string idDieta, string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario) {
            this.modificarDietaAsync(idDieta, nombre, fechaInicio, fechaFinal, idCliente, idUsuario, null);
        }
        
        /// <remarks/>
        public void modificarDietaAsync(string idDieta, string nombre, string fechaInicio, string fechaFinal, string idCliente, string idUsuario, object userState) {
            if ((this.modificarDietaOperationCompleted == null)) {
                this.modificarDietaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmodificarDietaOperationCompleted);
            }
            this.InvokeAsync("modificarDieta", new object[] {
                        idDieta,
                        nombre,
                        fechaInicio,
                        fechaFinal,
                        idCliente,
                        idUsuario}, this.modificarDietaOperationCompleted, userState);
        }
        
        private void OnmodificarDietaOperationCompleted(object arg) {
            if ((this.modificarDietaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.modificarDietaCompleted(this, new modificarDietaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarDieta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet eliminarDieta(string idDieta) {
            object[] results = this.Invoke("eliminarDieta", new object[] {
                        idDieta});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarDietaAsync(string idDieta) {
            this.eliminarDietaAsync(idDieta, null);
        }
        
        /// <remarks/>
        public void eliminarDietaAsync(string idDieta, object userState) {
            if ((this.eliminarDietaOperationCompleted == null)) {
                this.eliminarDietaOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarDietaOperationCompleted);
            }
            this.InvokeAsync("eliminarDieta", new object[] {
                        idDieta}, this.eliminarDietaOperationCompleted, userState);
        }
        
        private void OneliminarDietaOperationCompleted(object arg) {
            if ((this.eliminarDietaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarDietaCompleted(this, new eliminarDietaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarDietaPorCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet buscarDietaPorCliente(string buscar) {
            object[] results = this.Invoke("buscarDietaPorCliente", new object[] {
                        buscar});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void buscarDietaPorClienteAsync(string buscar) {
            this.buscarDietaPorClienteAsync(buscar, null);
        }
        
        /// <remarks/>
        public void buscarDietaPorClienteAsync(string buscar, object userState) {
            if ((this.buscarDietaPorClienteOperationCompleted == null)) {
                this.buscarDietaPorClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarDietaPorClienteOperationCompleted);
            }
            this.InvokeAsync("buscarDietaPorCliente", new object[] {
                        buscar}, this.buscarDietaPorClienteOperationCompleted, userState);
        }
        
        private void OnbuscarDietaPorClienteOperationCompleted(object arg) {
            if ((this.buscarDietaPorClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarDietaPorClienteCompleted(this, new buscarDietaPorClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarClientePorNombre", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet buscarClientePorNombre(string nombre1) {
            object[] results = this.Invoke("buscarClientePorNombre", new object[] {
                        nombre1});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void buscarClientePorNombreAsync(string nombre1) {
            this.buscarClientePorNombreAsync(nombre1, null);
        }
        
        /// <remarks/>
        public void buscarClientePorNombreAsync(string nombre1, object userState) {
            if ((this.buscarClientePorNombreOperationCompleted == null)) {
                this.buscarClientePorNombreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarClientePorNombreOperationCompleted);
            }
            this.InvokeAsync("buscarClientePorNombre", new object[] {
                        nombre1}, this.buscarClientePorNombreOperationCompleted, userState);
        }
        
        private void OnbuscarClientePorNombreOperationCompleted(object arg) {
            if ((this.buscarClientePorNombreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarClientePorNombreCompleted(this, new buscarClientePorNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/mostrarTodos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet mostrarTodos(string nombre) {
            object[] results = this.Invoke("mostrarTodos", new object[] {
                        nombre});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void mostrarTodosAsync(string nombre) {
            this.mostrarTodosAsync(nombre, null);
        }
        
        /// <remarks/>
        public void mostrarTodosAsync(string nombre, object userState) {
            if ((this.mostrarTodosOperationCompleted == null)) {
                this.mostrarTodosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmostrarTodosOperationCompleted);
            }
            this.InvokeAsync("mostrarTodos", new object[] {
                        nombre}, this.mostrarTodosOperationCompleted, userState);
        }
        
        private void OnmostrarTodosOperationCompleted(object arg) {
            if ((this.mostrarTodosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.mostrarTodosCompleted(this, new mostrarTodosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/guardarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet guardarCliente(string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo) {
            object[] results = this.Invoke("guardarCliente", new object[] {
                        nombre1,
                        paterno,
                        materno,
                        fecha,
                        correo,
                        telefono,
                        sexo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void guardarClienteAsync(string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo) {
            this.guardarClienteAsync(nombre1, paterno, materno, fecha, correo, telefono, sexo, null);
        }
        
        /// <remarks/>
        public void guardarClienteAsync(string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo, object userState) {
            if ((this.guardarClienteOperationCompleted == null)) {
                this.guardarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnguardarClienteOperationCompleted);
            }
            this.InvokeAsync("guardarCliente", new object[] {
                        nombre1,
                        paterno,
                        materno,
                        fecha,
                        correo,
                        telefono,
                        sexo}, this.guardarClienteOperationCompleted, userState);
        }
        
        private void OnguardarClienteOperationCompleted(object arg) {
            if ((this.guardarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.guardarClienteCompleted(this, new guardarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet eliminarCliente(string id) {
            object[] results = this.Invoke("eliminarCliente", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarClienteAsync(string id) {
            this.eliminarClienteAsync(id, null);
        }
        
        /// <remarks/>
        public void eliminarClienteAsync(string id, object userState) {
            if ((this.eliminarClienteOperationCompleted == null)) {
                this.eliminarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarClienteOperationCompleted);
            }
            this.InvokeAsync("eliminarCliente", new object[] {
                        id}, this.eliminarClienteOperationCompleted, userState);
        }
        
        private void OneliminarClienteOperationCompleted(object arg) {
            if ((this.eliminarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarClienteCompleted(this, new eliminarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/modificarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet modificarCliente(string id, string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo) {
            object[] results = this.Invoke("modificarCliente", new object[] {
                        id,
                        nombre1,
                        paterno,
                        materno,
                        fecha,
                        correo,
                        telefono,
                        sexo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void modificarClienteAsync(string id, string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo) {
            this.modificarClienteAsync(id, nombre1, paterno, materno, fecha, correo, telefono, sexo, null);
        }
        
        /// <remarks/>
        public void modificarClienteAsync(string id, string nombre1, string paterno, string materno, string fecha, string correo, string telefono, string sexo, object userState) {
            if ((this.modificarClienteOperationCompleted == null)) {
                this.modificarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmodificarClienteOperationCompleted);
            }
            this.InvokeAsync("modificarCliente", new object[] {
                        id,
                        nombre1,
                        paterno,
                        materno,
                        fecha,
                        correo,
                        telefono,
                        sexo}, this.modificarClienteOperationCompleted, userState);
        }
        
        private void OnmodificarClienteOperationCompleted(object arg) {
            if ((this.modificarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.modificarClienteCompleted(this, new modificarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void guardarDietaCompletedEventHandler(object sender, guardarDietaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class guardarDietaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal guardarDietaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void modificarDietaCompletedEventHandler(object sender, modificarDietaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modificarDietaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal modificarDietaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarDietaCompletedEventHandler(object sender, eliminarDietaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarDietaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarDietaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarDietaPorClienteCompletedEventHandler(object sender, buscarDietaPorClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarDietaPorClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarDietaPorClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void buscarClientePorNombreCompletedEventHandler(object sender, buscarClientePorNombreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarClientePorNombreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarClientePorNombreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void mostrarTodosCompletedEventHandler(object sender, mostrarTodosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class mostrarTodosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal mostrarTodosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void guardarClienteCompletedEventHandler(object sender, guardarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class guardarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal guardarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void eliminarClienteCompletedEventHandler(object sender, eliminarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void modificarClienteCompletedEventHandler(object sender, modificarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modificarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal modificarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591