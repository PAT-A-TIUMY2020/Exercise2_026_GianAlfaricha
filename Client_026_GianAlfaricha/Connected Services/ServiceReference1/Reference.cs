﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_026_GianAlfaricha.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Mahasiswa", Namespace="http://schemas.datacontract.org/2004/07/Service_026_GianAlfaricha")]
    [System.SerializableAttribute()]
    public partial class Mahasiswa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nimField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prodiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string angkatanField;
        
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
        public string nama {
            get {
                return this.namaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaField, value) != true)) {
                    this.namaField = value;
                    this.RaisePropertyChanged("nama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nim {
            get {
                return this.nimField;
            }
            set {
                if ((object.ReferenceEquals(this.nimField, value) != true)) {
                    this.nimField = value;
                    this.RaisePropertyChanged("nim");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prodi {
            get {
                return this.prodiField;
            }
            set {
                if ((object.ReferenceEquals(this.prodiField, value) != true)) {
                    this.prodiField = value;
                    this.RaisePropertyChanged("prodi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string angkatan {
            get {
                return this.angkatanField;
            }
            set {
                if ((object.ReferenceEquals(this.angkatanField, value) != true)) {
                    this.angkatanField = value;
                    this.RaisePropertyChanged("angkatan");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITI_UMY")]
    public interface ITI_UMY {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetAllMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/GetAllMahasiswaResponse")]
        Client_026_GianAlfaricha.ServiceReference1.Mahasiswa[] GetAllMahasiswa();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetAllMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/GetAllMahasiswaResponse")]
        System.Threading.Tasks.Task<Client_026_GianAlfaricha.ServiceReference1.Mahasiswa[]> GetAllMahasiswaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/GetMahasiswaByNIMResponse")]
        Client_026_GianAlfaricha.ServiceReference1.Mahasiswa GetMahasiswaByNIM(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/GetMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/GetMahasiswaByNIMResponse")]
        System.Threading.Tasks.Task<Client_026_GianAlfaricha.ServiceReference1.Mahasiswa> GetMahasiswaByNIMAsync(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/CreateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/CreateMahasiswaResponse")]
        string CreateMahasiswa(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/CreateMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/CreateMahasiswaResponse")]
        System.Threading.Tasks.Task<string> CreateMahasiswaAsync(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/DeleteMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/DeleteMahasiswaResponse")]
        string DeleteMahasiswa(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/DeleteMahasiswa", ReplyAction="http://tempuri.org/ITI_UMY/DeleteMahasiswaResponse")]
        System.Threading.Tasks.Task<string> DeleteMahasiswaAsync(string nim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/UpdateMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/UpdateMahasiswaByNIMResponse")]
        string UpdateMahasiswaByNIM(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITI_UMY/UpdateMahasiswaByNIM", ReplyAction="http://tempuri.org/ITI_UMY/UpdateMahasiswaByNIMResponse")]
        System.Threading.Tasks.Task<string> UpdateMahasiswaByNIMAsync(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITI_UMYChannel : Client_026_GianAlfaricha.ServiceReference1.ITI_UMY, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TI_UMYClient : System.ServiceModel.ClientBase<Client_026_GianAlfaricha.ServiceReference1.ITI_UMY>, Client_026_GianAlfaricha.ServiceReference1.ITI_UMY {
        
        public TI_UMYClient() {
        }
        
        public TI_UMYClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TI_UMYClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TI_UMYClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TI_UMYClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_026_GianAlfaricha.ServiceReference1.Mahasiswa[] GetAllMahasiswa() {
            return base.Channel.GetAllMahasiswa();
        }
        
        public System.Threading.Tasks.Task<Client_026_GianAlfaricha.ServiceReference1.Mahasiswa[]> GetAllMahasiswaAsync() {
            return base.Channel.GetAllMahasiswaAsync();
        }
        
        public Client_026_GianAlfaricha.ServiceReference1.Mahasiswa GetMahasiswaByNIM(string nim) {
            return base.Channel.GetMahasiswaByNIM(nim);
        }
        
        public System.Threading.Tasks.Task<Client_026_GianAlfaricha.ServiceReference1.Mahasiswa> GetMahasiswaByNIMAsync(string nim) {
            return base.Channel.GetMahasiswaByNIMAsync(nim);
        }
        
        public string CreateMahasiswa(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs) {
            return base.Channel.CreateMahasiswa(mhs);
        }
        
        public System.Threading.Tasks.Task<string> CreateMahasiswaAsync(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs) {
            return base.Channel.CreateMahasiswaAsync(mhs);
        }
        
        public string DeleteMahasiswa(string nim) {
            return base.Channel.DeleteMahasiswa(nim);
        }
        
        public System.Threading.Tasks.Task<string> DeleteMahasiswaAsync(string nim) {
            return base.Channel.DeleteMahasiswaAsync(nim);
        }
        
        public string UpdateMahasiswaByNIM(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs) {
            return base.Channel.UpdateMahasiswaByNIM(mhs);
        }
        
        public System.Threading.Tasks.Task<string> UpdateMahasiswaByNIMAsync(Client_026_GianAlfaricha.ServiceReference1.Mahasiswa mhs) {
            return base.Channel.UpdateMahasiswaByNIMAsync(mhs);
        }
    }
}
