﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BotControlClient.CheckControl {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckResponse", Namespace="http://schemas.datacontract.org/2004/07/BotControlServer")]
    [System.SerializableAttribute()]
    public partial class CheckResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan CheckTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FolderNameField;
        
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
        public System.TimeSpan CheckTime {
            get {
                return this.CheckTimeField;
            }
            set {
                if ((this.CheckTimeField.Equals(value) != true)) {
                    this.CheckTimeField = value;
                    this.RaisePropertyChanged("CheckTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodeNumber {
            get {
                return this.CodeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeNumberField, value) != true)) {
                    this.CodeNumberField = value;
                    this.RaisePropertyChanged("CodeNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FolderName {
            get {
                return this.FolderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FolderNameField, value) != true)) {
                    this.FolderNameField = value;
                    this.RaisePropertyChanged("FolderName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CheckControl.ICheckControl")]
    public interface ICheckControl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckControl/GetData", ReplyAction="http://tempuri.org/ICheckControl/GetDataResponse")]
        BotControlClient.CheckControl.CheckResponse[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICheckControl/GetData", ReplyAction="http://tempuri.org/ICheckControl/GetDataResponse")]
        System.Threading.Tasks.Task<BotControlClient.CheckControl.CheckResponse[]> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICheckControlChannel : BotControlClient.CheckControl.ICheckControl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckControlClient : System.ServiceModel.ClientBase<BotControlClient.CheckControl.ICheckControl>, BotControlClient.CheckControl.ICheckControl {
        
        public CheckControlClient() {
        }
        
        public CheckControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CheckControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BotControlClient.CheckControl.CheckResponse[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<BotControlClient.CheckControl.CheckResponse[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
