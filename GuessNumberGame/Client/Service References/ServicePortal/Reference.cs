﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServicePortal {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool loggedInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServicePortal.Player opponentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
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
        public bool loggedIn {
            get {
                return this.loggedInField;
            }
            set {
                if ((this.loggedInField.Equals(value) != true)) {
                    this.loggedInField = value;
                    this.RaisePropertyChanged("loggedIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ServicePortal.Player opponent {
            get {
                return this.opponentField;
            }
            set {
                if ((object.ReferenceEquals(this.opponentField, value) != true)) {
                    this.opponentField = value;
                    this.RaisePropertyChanged("opponent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Server", ConfigurationName="ServicePortal.IPortal", CallbackContract=typeof(Client.ServicePortal.IPortalCallback))]
    public interface IPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserRegister", ReplyAction="Server/IPortal/UserRegisterResponse")]
        bool UserRegister(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserRegister", ReplyAction="Server/IPortal/UserRegisterResponse")]
        System.Threading.Tasks.Task<bool> UserRegisterAsync(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/logIn", ReplyAction="Server/IPortal/logInResponse")]
        bool logIn(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/logIn", ReplyAction="Server/IPortal/logInResponse")]
        System.Threading.Tasks.Task<bool> logInAsync(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/InvitePlayer", ReplyAction="Server/IPortal/InvitePlayerResponse")]
        bool InvitePlayer(Client.ServicePortal.Player send, Client.ServicePortal.Player receive);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/InvitePlayer", ReplyAction="Server/IPortal/InvitePlayerResponse")]
        System.Threading.Tasks.Task<bool> InvitePlayerAsync(Client.ServicePortal.Player send, Client.ServicePortal.Player receive);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserLogOut", ReplyAction="Server/IPortal/UserLogOutResponse")]
        void UserLogOut(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserLogOut", ReplyAction="Server/IPortal/UserLogOutResponse")]
        System.Threading.Tasks.Task UserLogOutAsync(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/ChatMessage", ReplyAction="Server/IPortal/ChatMessageResponse")]
        void ChatMessage(Client.ServicePortal.Player p, string m);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/ChatMessage", ReplyAction="Server/IPortal/ChatMessageResponse")]
        System.Threading.Tasks.Task ChatMessageAsync(Client.ServicePortal.Player p, string m);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnInvitation", ReplyAction="Server/IPortal/OnInvitationResponse")]
        bool OnInvitation(Client.ServicePortal.Player sender);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnLoggingIn", ReplyAction="Server/IPortal/OnLoggingInResponse")]
        void OnLoggingIn(Client.ServicePortal.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnLoggingOut", ReplyAction="Server/IPortal/OnLoggingOutResponse")]
        void OnLoggingOut(Client.ServicePortal.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/messageRecieved", ReplyAction="Server/IPortal/messageRecievedResponse")]
        void messageRecieved(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalChannel : Client.ServicePortal.IPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PortalClient : System.ServiceModel.DuplexClientBase<Client.ServicePortal.IPortal>, Client.ServicePortal.IPortal {
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PortalClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool UserRegister(Client.ServicePortal.Player p) {
            return base.Channel.UserRegister(p);
        }
        
        public System.Threading.Tasks.Task<bool> UserRegisterAsync(Client.ServicePortal.Player p) {
            return base.Channel.UserRegisterAsync(p);
        }
        
        public bool logIn(Client.ServicePortal.Player p) {
            return base.Channel.logIn(p);
        }
        
        public System.Threading.Tasks.Task<bool> logInAsync(Client.ServicePortal.Player p) {
            return base.Channel.logInAsync(p);
        }
        
        public bool InvitePlayer(Client.ServicePortal.Player send, Client.ServicePortal.Player receive) {
            return base.Channel.InvitePlayer(send, receive);
        }
        
        public System.Threading.Tasks.Task<bool> InvitePlayerAsync(Client.ServicePortal.Player send, Client.ServicePortal.Player receive) {
            return base.Channel.InvitePlayerAsync(send, receive);
        }
        
        public void UserLogOut(Client.ServicePortal.Player p) {
            base.Channel.UserLogOut(p);
        }
        
        public System.Threading.Tasks.Task UserLogOutAsync(Client.ServicePortal.Player p) {
            return base.Channel.UserLogOutAsync(p);
        }
        
        public void ChatMessage(Client.ServicePortal.Player p, string m) {
            base.Channel.ChatMessage(p, m);
        }
        
        public System.Threading.Tasks.Task ChatMessageAsync(Client.ServicePortal.Player p, string m) {
            return base.Channel.ChatMessageAsync(p, m);
        }
    }
}