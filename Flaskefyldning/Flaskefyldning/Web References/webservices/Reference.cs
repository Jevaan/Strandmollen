﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.7905
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.7905.
// 
namespace Flaskefyldning.webservices {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://srv-web-03/webservices")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://webservices.strandmollen.local/WSString/StringWriter.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://srv-web-03/webservices/StringWriter", RequestNamespace="http://srv-web-03/webservices", ResponseNamespace="http://srv-web-03/webservices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool StringWriter(string WriteMe, string Filename, string Location) {
            object[] results = this.Invoke("StringWriter", new object[] {
                        WriteMe,
                        Filename,
                        Location});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStringWriter(string WriteMe, string Filename, string Location, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StringWriter", new object[] {
                        WriteMe,
                        Filename,
                        Location}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndStringWriter(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://srv-web-03/webservices/StringWriterChecked", RequestNamespace="http://srv-web-03/webservices", ResponseNamespace="http://srv-web-03/webservices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool StringWriterChecked(string WriteMe, string Filename, string Location) {
            object[] results = this.Invoke("StringWriterChecked", new object[] {
                        WriteMe,
                        Filename,
                        Location});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStringWriterChecked(string WriteMe, string Filename, string Location, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StringWriterChecked", new object[] {
                        WriteMe,
                        Filename,
                        Location}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndStringWriterChecked(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://srv-web-03/webservices/StringReader", RequestNamespace="http://srv-web-03/webservices", ResponseNamespace="http://srv-web-03/webservices", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ArticleFile StringReader(string Filename, string Location) {
            object[] results = this.Invoke("StringReader", new object[] {
                        Filename,
                        Location});
            return ((ArticleFile)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginStringReader(string Filename, string Location, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("StringReader", new object[] {
                        Filename,
                        Location}, callback, asyncState);
        }
        
        /// <remarks/>
        public ArticleFile EndStringReader(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ArticleFile)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://srv-web-03/webservices")]
    public partial class ArticleFile {
        
        private string[] allLinesField;
        
        private string nameField;
        
        /// <remarks/>
        public string[] AllLines {
            get {
                return this.allLinesField;
            }
            set {
                this.allLinesField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}