﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDPTassign2Client.worldScramblerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Word", Namespace="http://schemas.datacontract.org/2004/07/NDPTassignment2")]
    [System.SerializableAttribute()]
    public partial class Word : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string scrambledWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unscrambledWordField;
        
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
        public string scrambledWord {
            get {
                return this.scrambledWordField;
            }
            set {
                if ((object.ReferenceEquals(this.scrambledWordField, value) != true)) {
                    this.scrambledWordField = value;
                    this.RaisePropertyChanged("scrambledWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unscrambledWord {
            get {
                return this.unscrambledWordField;
            }
            set {
                if ((object.ReferenceEquals(this.unscrambledWordField, value) != true)) {
                    this.unscrambledWordField = value;
                    this.RaisePropertyChanged("unscrambledWord");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="worldScramblerServiceReference.IWordScramblerService")]
    public interface IWordScramblerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScramblerService/getScrambledWord", ReplyAction="http://tempuri.org/IWordScramblerService/getScrambledWordResponse")]
        NDPTassign2Client.worldScramblerServiceReference.Word getScrambledWord();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScramblerService/getScrambledWord", ReplyAction="http://tempuri.org/IWordScramblerService/getScrambledWordResponse")]
        System.Threading.Tasks.Task<NDPTassign2Client.worldScramblerServiceReference.Word> getScrambledWordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScramblerService/guessWord", ReplyAction="http://tempuri.org/IWordScramblerService/guessWordResponse")]
        bool guessWord(string guessedWord, string unscrambledWord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWordScramblerService/guessWord", ReplyAction="http://tempuri.org/IWordScramblerService/guessWordResponse")]
        System.Threading.Tasks.Task<bool> guessWordAsync(string guessedWord, string unscrambledWord);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWordScramblerServiceChannel : NDPTassign2Client.worldScramblerServiceReference.IWordScramblerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WordScramblerServiceClient : System.ServiceModel.ClientBase<NDPTassign2Client.worldScramblerServiceReference.IWordScramblerService>, NDPTassign2Client.worldScramblerServiceReference.IWordScramblerService {
        
        public WordScramblerServiceClient() {
        }
        
        public WordScramblerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WordScramblerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordScramblerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WordScramblerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NDPTassign2Client.worldScramblerServiceReference.Word getScrambledWord() {
            return base.Channel.getScrambledWord();
        }
        
        public System.Threading.Tasks.Task<NDPTassign2Client.worldScramblerServiceReference.Word> getScrambledWordAsync() {
            return base.Channel.getScrambledWordAsync();
        }
        
        public bool guessWord(string guessedWord, string unscrambledWord) {
            return base.Channel.guessWord(guessedWord, unscrambledWord);
        }
        
        public System.Threading.Tasks.Task<bool> guessWordAsync(string guessedWord, string unscrambledWord) {
            return base.Channel.guessWordAsync(guessedWord, unscrambledWord);
        }
    }
}
