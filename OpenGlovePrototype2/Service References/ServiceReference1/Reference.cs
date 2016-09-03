﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenGlovePrototype2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOGService")]
    public interface IOGService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetMappingsArray", ReplyAction="http://tempuri.org/IOGService/GetMappingsArrayResponse")]
        int[] GetMappingsArray();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetMappingsArray", ReplyAction="http://tempuri.org/IOGService/GetMappingsArrayResponse")]
        System.Threading.Tasks.Task<int[]> GetMappingsArrayAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetCore", ReplyAction="http://tempuri.org/IOGService/GetCoreResponse")]
        OpenGlove.OGCore GetCore();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetCore", ReplyAction="http://tempuri.org/IOGService/GetCoreResponse")]
        System.Threading.Tasks.Task<OpenGlove.OGCore> GetCoreAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/SetConfiguration", ReplyAction="http://tempuri.org/IOGService/SetConfigurationResponse")]
        void SetConfiguration(int BaudRate, int[] positivePins, int[] negativePins, string[] positiveInit, string[] negativeInit, string gloveHash, string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/SetConfiguration", ReplyAction="http://tempuri.org/IOGService/SetConfigurationResponse")]
        System.Threading.Tasks.Task SetConfigurationAsync(int BaudRate, int[] positivePins, int[] negativePins, string[] positiveInit, string[] negativeInit, string gloveHash, string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetBaudRate", ReplyAction="http://tempuri.org/IOGService/GetBaudRateResponse")]
        int GetBaudRate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetBaudRate", ReplyAction="http://tempuri.org/IOGService/GetBaudRateResponse")]
        System.Threading.Tasks.Task<int> GetBaudRateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPositivePins", ReplyAction="http://tempuri.org/IOGService/GetPositivePinsResponse")]
        int[] GetPositivePins();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPositivePins", ReplyAction="http://tempuri.org/IOGService/GetPositivePinsResponse")]
        System.Threading.Tasks.Task<int[]> GetPositivePinsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetNegativePins", ReplyAction="http://tempuri.org/IOGService/GetNegativePinsResponse")]
        int[] GetNegativePins();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetNegativePins", ReplyAction="http://tempuri.org/IOGService/GetNegativePinsResponse")]
        System.Threading.Tasks.Task<int[]> GetNegativePinsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPositiveInit", ReplyAction="http://tempuri.org/IOGService/GetPositiveInitResponse")]
        string[] GetPositiveInit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPositiveInit", ReplyAction="http://tempuri.org/IOGService/GetPositiveInitResponse")]
        System.Threading.Tasks.Task<string[]> GetPositiveInitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetNegativeInit", ReplyAction="http://tempuri.org/IOGService/GetNegativeInitResponse")]
        string[] GetNegativeInit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetNegativeInit", ReplyAction="http://tempuri.org/IOGService/GetNegativeInitResponse")]
        System.Threading.Tasks.Task<string[]> GetNegativeInitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetGloveHash", ReplyAction="http://tempuri.org/IOGService/GetGloveHashResponse")]
        string GetGloveHash();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetGloveHash", ReplyAction="http://tempuri.org/IOGService/GetGloveHashResponse")]
        System.Threading.Tasks.Task<string> GetGloveHashAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetGloveName", ReplyAction="http://tempuri.org/IOGService/GetGloveNameResponse")]
        string GetGloveName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetGloveName", ReplyAction="http://tempuri.org/IOGService/GetGloveNameResponse")]
        System.Threading.Tasks.Task<string> GetGloveNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/SetProfile", ReplyAction="http://tempuri.org/IOGService/SetProfileResponse")]
        void SetProfile(string profileName, string gloveHash, System.Collections.Generic.Dictionary<string, string> mappings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/SetProfile", ReplyAction="http://tempuri.org/IOGService/SetProfileResponse")]
        System.Threading.Tasks.Task SetProfileAsync(string profileName, string gloveHash, System.Collections.Generic.Dictionary<string, string> mappings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetProfileName", ReplyAction="http://tempuri.org/IOGService/GetProfileNameResponse")]
        string GetProfileName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetProfileName", ReplyAction="http://tempuri.org/IOGService/GetProfileNameResponse")]
        System.Threading.Tasks.Task<string> GetProfileNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetProfileGloveHash", ReplyAction="http://tempuri.org/IOGService/GetProfileGloveHashResponse")]
        string GetProfileGloveHash();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetProfileGloveHash", ReplyAction="http://tempuri.org/IOGService/GetProfileGloveHashResponse")]
        System.Threading.Tasks.Task<string> GetProfileGloveHashAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetMappingsDictionary", ReplyAction="http://tempuri.org/IOGService/GetMappingsDictionaryResponse")]
        System.Collections.Generic.Dictionary<string, string> GetMappingsDictionary();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetMappingsDictionary", ReplyAction="http://tempuri.org/IOGService/GetMappingsDictionaryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetMappingsDictionaryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/getGloves", ReplyAction="http://tempuri.org/IOGService/getGlovesResponse")]
        System.Collections.Generic.Dictionary<string, string> getGloves();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/getGloves", ReplyAction="http://tempuri.org/IOGService/getGlovesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> getGlovesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPortNames", ReplyAction="http://tempuri.org/IOGService/GetPortNamesResponse")]
        string[] GetPortNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/GetPortNames", ReplyAction="http://tempuri.org/IOGService/GetPortNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetPortNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/Connect", ReplyAction="http://tempuri.org/IOGService/ConnectResponse")]
        string Connect(string port, bool right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/Connect", ReplyAction="http://tempuri.org/IOGService/ConnectResponse")]
        System.Threading.Tasks.Task<string> ConnectAsync(string port, bool right);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/Disconnect", ReplyAction="http://tempuri.org/IOGService/DisconnectResponse")]
        void Disconnect(string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/Disconnect", ReplyAction="http://tempuri.org/IOGService/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/StartTest", ReplyAction="http://tempuri.org/IOGService/StartTestResponse")]
        void StartTest(string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/StartTest", ReplyAction="http://tempuri.org/IOGService/StartTestResponse")]
        System.Threading.Tasks.Task StartTestAsync(string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/StopTest", ReplyAction="http://tempuri.org/IOGService/StopTestResponse")]
        void StopTest(string gloveName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOGService/StopTest", ReplyAction="http://tempuri.org/IOGService/StopTestResponse")]
        System.Threading.Tasks.Task StopTestAsync(string gloveName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOGServiceChannel : OpenGlovePrototype2.ServiceReference1.IOGService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OGServiceClient : System.ServiceModel.ClientBase<OpenGlovePrototype2.ServiceReference1.IOGService>, OpenGlovePrototype2.ServiceReference1.IOGService {
        
        public OGServiceClient() {
        }
        
        public OGServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OGServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OGServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OGServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] GetMappingsArray() {
            return base.Channel.GetMappingsArray();
        }
        
        public System.Threading.Tasks.Task<int[]> GetMappingsArrayAsync() {
            return base.Channel.GetMappingsArrayAsync();
        }
        
        public OpenGlove.OGCore GetCore() {
            return base.Channel.GetCore();
        }
        
        public System.Threading.Tasks.Task<OpenGlove.OGCore> GetCoreAsync() {
            return base.Channel.GetCoreAsync();
        }
        
        public void SetConfiguration(int BaudRate, int[] positivePins, int[] negativePins, string[] positiveInit, string[] negativeInit, string gloveHash, string gloveName) {
            base.Channel.SetConfiguration(BaudRate, positivePins, negativePins, positiveInit, negativeInit, gloveHash, gloveName);
        }
        
        public System.Threading.Tasks.Task SetConfigurationAsync(int BaudRate, int[] positivePins, int[] negativePins, string[] positiveInit, string[] negativeInit, string gloveHash, string gloveName) {
            return base.Channel.SetConfigurationAsync(BaudRate, positivePins, negativePins, positiveInit, negativeInit, gloveHash, gloveName);
        }
        
        public int GetBaudRate() {
            return base.Channel.GetBaudRate();
        }
        
        public System.Threading.Tasks.Task<int> GetBaudRateAsync() {
            return base.Channel.GetBaudRateAsync();
        }
        
        public int[] GetPositivePins() {
            return base.Channel.GetPositivePins();
        }
        
        public System.Threading.Tasks.Task<int[]> GetPositivePinsAsync() {
            return base.Channel.GetPositivePinsAsync();
        }
        
        public int[] GetNegativePins() {
            return base.Channel.GetNegativePins();
        }
        
        public System.Threading.Tasks.Task<int[]> GetNegativePinsAsync() {
            return base.Channel.GetNegativePinsAsync();
        }
        
        public string[] GetPositiveInit() {
            return base.Channel.GetPositiveInit();
        }
        
        public System.Threading.Tasks.Task<string[]> GetPositiveInitAsync() {
            return base.Channel.GetPositiveInitAsync();
        }
        
        public string[] GetNegativeInit() {
            return base.Channel.GetNegativeInit();
        }
        
        public System.Threading.Tasks.Task<string[]> GetNegativeInitAsync() {
            return base.Channel.GetNegativeInitAsync();
        }
        
        public string GetGloveHash() {
            return base.Channel.GetGloveHash();
        }
        
        public System.Threading.Tasks.Task<string> GetGloveHashAsync() {
            return base.Channel.GetGloveHashAsync();
        }
        
        public string GetGloveName() {
            return base.Channel.GetGloveName();
        }
        
        public System.Threading.Tasks.Task<string> GetGloveNameAsync() {
            return base.Channel.GetGloveNameAsync();
        }
        
        public void SetProfile(string profileName, string gloveHash, System.Collections.Generic.Dictionary<string, string> mappings) {
            base.Channel.SetProfile(profileName, gloveHash, mappings);
        }
        
        public System.Threading.Tasks.Task SetProfileAsync(string profileName, string gloveHash, System.Collections.Generic.Dictionary<string, string> mappings) {
            return base.Channel.SetProfileAsync(profileName, gloveHash, mappings);
        }
        
        public string GetProfileName() {
            return base.Channel.GetProfileName();
        }
        
        public System.Threading.Tasks.Task<string> GetProfileNameAsync() {
            return base.Channel.GetProfileNameAsync();
        }
        
        public string GetProfileGloveHash() {
            return base.Channel.GetProfileGloveHash();
        }
        
        public System.Threading.Tasks.Task<string> GetProfileGloveHashAsync() {
            return base.Channel.GetProfileGloveHashAsync();
        }
        
        public System.Collections.Generic.Dictionary<string, string> GetMappingsDictionary() {
            return base.Channel.GetMappingsDictionary();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetMappingsDictionaryAsync() {
            return base.Channel.GetMappingsDictionaryAsync();
        }
        
        public System.Collections.Generic.Dictionary<string, string> getGloves() {
            return base.Channel.getGloves();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> getGlovesAsync() {
            return base.Channel.getGlovesAsync();
        }
        
        public string[] GetPortNames() {
            return base.Channel.GetPortNames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetPortNamesAsync() {
            return base.Channel.GetPortNamesAsync();
        }
        
        public string Connect(string port, bool right) {
            return base.Channel.Connect(port, right);
        }
        
        public System.Threading.Tasks.Task<string> ConnectAsync(string port, bool right) {
            return base.Channel.ConnectAsync(port, right);
        }
        
        public void Disconnect(string gloveName) {
            base.Channel.Disconnect(gloveName);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(string gloveName) {
            return base.Channel.DisconnectAsync(gloveName);
        }
        
        public void StartTest(string gloveName) {
            base.Channel.StartTest(gloveName);
        }
        
        public System.Threading.Tasks.Task StartTestAsync(string gloveName) {
            return base.Channel.StartTestAsync(gloveName);
        }
        
        public void StopTest(string gloveName) {
            base.Channel.StopTest(gloveName);
        }
        
        public System.Threading.Tasks.Task StopTestAsync(string gloveName) {
            return base.Channel.StopTestAsync(gloveName);
        }
    }
}