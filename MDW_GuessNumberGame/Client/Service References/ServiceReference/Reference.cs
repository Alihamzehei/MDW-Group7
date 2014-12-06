﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/GameContract")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string PassWord {
            get {
                return this.PassWordField;
            }
            set {
                if ((object.ReferenceEquals(this.PassWordField, value) != true)) {
                    this.PassWordField = value;
                    this.RaisePropertyChanged("PassWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="MDW_GuessNumberGame", ConfigurationName="ServiceReference.IGame", CallbackContract=typeof(Client.ServiceReference.IGameCallback))]
    public interface IGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/StartGame", ReplyAction="MDW_GuessNumberGame/IGame/StartGameResponse")]
        void StartGame(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/StartGame", ReplyAction="MDW_GuessNumberGame/IGame/StartGameResponse")]
        System.Threading.Tasks.Task StartGameAsync(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/CountGuessTime", ReplyAction="MDW_GuessNumberGame/IGame/CountGuessTimeResponse")]
        void CountGuessTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/CountGuessTime", ReplyAction="MDW_GuessNumberGame/IGame/CountGuessTimeResponse")]
        System.Threading.Tasks.Task CountGuessTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/InvitePlayer", ReplyAction="MDW_GuessNumberGame/IGame/InvitePlayerResponse")]
        bool InvitePlayer(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/InvitePlayer", ReplyAction="MDW_GuessNumberGame/IGame/InvitePlayerResponse")]
        System.Threading.Tasks.Task<bool> InvitePlayerAsync(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="MDW_GuessNumberGame/IGame/SendMessage", ReplyAction="MDW_GuessNumberGame/IGame/SendMessageResponse")]
        void SendMessage(Client.ServiceReference.Player p1, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameChannel : Client.ServiceReference.IGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameClient : System.ServiceModel.DuplexClientBase<Client.ServiceReference.IGame>, Client.ServiceReference.IGame {
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartGame(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2) {
            base.Channel.StartGame(p1, p2);
        }
        
        public System.Threading.Tasks.Task StartGameAsync(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2) {
            return base.Channel.StartGameAsync(p1, p2);
        }
        
        public void CountGuessTime() {
            base.Channel.CountGuessTime();
        }
        
        public System.Threading.Tasks.Task CountGuessTimeAsync() {
            return base.Channel.CountGuessTimeAsync();
        }
        
        public bool InvitePlayer(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2) {
            return base.Channel.InvitePlayer(p1, p2);
        }
        
        public System.Threading.Tasks.Task<bool> InvitePlayerAsync(Client.ServiceReference.Player p1, Client.ServiceReference.Player p2) {
            return base.Channel.InvitePlayerAsync(p1, p2);
        }
    }
}
