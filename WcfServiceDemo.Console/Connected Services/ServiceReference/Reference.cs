//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceDemo.Console.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDemo")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IIpAddressService")]
    public interface IIpAddressService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIpAddressService/GetIpAddress", ReplyAction="http://tempuri.org/IIpAddressService/GetIpAddressResponse")]
        WcfServiceDemo.Console.ServiceReference.CompositeType GetIpAddress();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIpAddressService/GetIpAddress", ReplyAction="http://tempuri.org/IIpAddressService/GetIpAddressResponse")]
        System.Threading.Tasks.Task<WcfServiceDemo.Console.ServiceReference.CompositeType> GetIpAddressAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIpAddressServiceChannel : WcfServiceDemo.Console.ServiceReference.IIpAddressService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IpAddressServiceClient : System.ServiceModel.ClientBase<WcfServiceDemo.Console.ServiceReference.IIpAddressService>, WcfServiceDemo.Console.ServiceReference.IIpAddressService {
        
        public IpAddressServiceClient() {
        }
        
        public IpAddressServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IpAddressServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IpAddressServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfServiceDemo.Console.ServiceReference.CompositeType GetIpAddress() {
            return base.Channel.GetIpAddress();
        }
        
        public System.Threading.Tasks.Task<WcfServiceDemo.Console.ServiceReference.CompositeType> GetIpAddressAsync() {
            return base.Channel.GetIpAddressAsync();
        }
    }
}
