﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServicePortal {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Server", ConfigurationName="ServicePortal.IPortal", CallbackContract=typeof(Client.ServicePortal.IPortalCallback))]
    public interface IPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserRegister", ReplyAction="Server/IPortal/UserRegisterResponse")]
        bool UserRegister(Server.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserRegister", ReplyAction="Server/IPortal/UserRegisterResponse")]
        System.Threading.Tasks.Task<bool> UserRegisterAsync(Server.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/logIn", ReplyAction="Server/IPortal/logInResponse")]
        bool logIn(Server.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/logIn", ReplyAction="Server/IPortal/logInResponse")]
        System.Threading.Tasks.Task<bool> logInAsync(Server.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/InvitePlayer", ReplyAction="Server/IPortal/InvitePlayerResponse")]
        bool InvitePlayer(Server.Player send, Server.Player receive);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/InvitePlayer", ReplyAction="Server/IPortal/InvitePlayerResponse")]
        System.Threading.Tasks.Task<bool> InvitePlayerAsync(Server.Player send, Server.Player receive);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserLogOut", ReplyAction="Server/IPortal/UserLogOutResponse")]
        void UserLogOut(Server.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/UserLogOut", ReplyAction="Server/IPortal/UserLogOutResponse")]
        System.Threading.Tasks.Task UserLogOutAsync(Server.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/ChatMessage", ReplyAction="Server/IPortal/ChatMessageResponse")]
        void ChatMessage(Server.Player p, string m);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/ChatMessage", ReplyAction="Server/IPortal/ChatMessageResponse")]
        System.Threading.Tasks.Task ChatMessageAsync(Server.Player p, string m);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPortalCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnInvitation", ReplyAction="Server/IPortal/OnInvitationResponse")]
        bool OnInvitation(Server.Player sender);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnLoggingIn", ReplyAction="Server/IPortal/OnLoggingInResponse")]
        void OnLoggingIn(Server.Player player);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/OnLoggingOut", ReplyAction="Server/IPortal/OnLoggingOutResponse")]
        void OnLoggingOut(Server.Player p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Server/IPortal/messageReceived", ReplyAction="Server/IPortal/messageReceivedResponse")]
        void messageReceived(string message);
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
        
        public bool UserRegister(Server.Player player) {
            return base.Channel.UserRegister(player);
        }
        
        public System.Threading.Tasks.Task<bool> UserRegisterAsync(Server.Player player) {
            return base.Channel.UserRegisterAsync(player);
        }
        
        public bool logIn(Server.Player p) {
            return base.Channel.logIn(p);
        }
        
        public System.Threading.Tasks.Task<bool> logInAsync(Server.Player p) {
            return base.Channel.logInAsync(p);
        }
        
        public bool InvitePlayer(Server.Player send, Server.Player receive) {
            return base.Channel.InvitePlayer(send, receive);
        }
        
        public System.Threading.Tasks.Task<bool> InvitePlayerAsync(Server.Player send, Server.Player receive) {
            return base.Channel.InvitePlayerAsync(send, receive);
        }
        
        public void UserLogOut(Server.Player p) {
            base.Channel.UserLogOut(p);
        }
        
        public System.Threading.Tasks.Task UserLogOutAsync(Server.Player p) {
            return base.Channel.UserLogOutAsync(p);
        }
        
        public void ChatMessage(Server.Player p, string m) {
            base.Channel.ChatMessage(p, m);
        }
        
        public System.Threading.Tasks.Task ChatMessageAsync(Server.Player p, string m) {
            return base.Channel.ChatMessageAsync(p, m);
        }
    }
}
