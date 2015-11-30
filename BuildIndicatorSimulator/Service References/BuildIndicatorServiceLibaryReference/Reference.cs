﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Light.Color", Namespace="http://schemas.datacontract.org/2004/07/BuildIndicatorControl")]
    public enum LightColor : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Red = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Yellow = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Green = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuildIndicatorServiceLibaryReference.IBuildIndicator")]
    public interface IBuildIndicator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOn", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOnResponse")]
        void TurnOn(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOn", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOnResponse")]
        System.Threading.Tasks.Task TurnOnAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOff", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOffResponse")]
        void TurnOff(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOff", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOffResponse")]
        System.Threading.Tasks.Task TurnOffAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOnFlash", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOnFlashResponse")]
        void TurnOnFlash(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOnFlash", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOnFlashResponse")]
        System.Threading.Tasks.Task TurnOnFlashAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOffAllLights", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOffAllLightsResponse")]
        void TurnOffAllLights();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/TurnOffAllLights", ReplyAction="http://tempuri.org/IBuildIndicator/TurnOffAllLightsResponse")]
        System.Threading.Tasks.Task TurnOffAllLightsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetBuildState", ReplyAction="http://tempuri.org/IBuildIndicator/GetBuildStateResponse")]
        void GetBuildState(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetBuildState", ReplyAction="http://tempuri.org/IBuildIndicator/GetBuildStateResponse")]
        System.Threading.Tasks.Task GetBuildStateAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/ResetBuildSource", ReplyAction="http://tempuri.org/IBuildIndicator/ResetBuildSourceResponse")]
        void ResetBuildSource();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/ResetBuildSource", ReplyAction="http://tempuri.org/IBuildIndicator/ResetBuildSourceResponse")]
        System.Threading.Tasks.Task ResetBuildSourceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/Run", ReplyAction="http://tempuri.org/IBuildIndicator/RunResponse")]
        void Run();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/Run", ReplyAction="http://tempuri.org/IBuildIndicator/RunResponse")]
        System.Threading.Tasks.Task RunAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetBuildServiceState", ReplyAction="http://tempuri.org/IBuildIndicator/GetBuildServiceStateResponse")]
        string GetBuildServiceState();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetBuildServiceState", ReplyAction="http://tempuri.org/IBuildIndicator/GetBuildServiceStateResponse")]
        System.Threading.Tasks.Task<string> GetBuildServiceStateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetCurrentSource", ReplyAction="http://tempuri.org/IBuildIndicator/GetCurrentSourceResponse")]
        string GetCurrentSource();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildIndicator/GetCurrentSource", ReplyAction="http://tempuri.org/IBuildIndicator/GetCurrentSourceResponse")]
        System.Threading.Tasks.Task<string> GetCurrentSourceAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBuildIndicatorChannel : BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.IBuildIndicator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BuildIndicatorClient : System.ServiceModel.ClientBase<BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.IBuildIndicator>, BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.IBuildIndicator {
        
        public BuildIndicatorClient() {
        }
        
        public BuildIndicatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BuildIndicatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildIndicatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildIndicatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void TurnOn(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            base.Channel.TurnOn(color);
        }
        
        public System.Threading.Tasks.Task TurnOnAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            return base.Channel.TurnOnAsync(color);
        }
        
        public void TurnOff(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            base.Channel.TurnOff(color);
        }
        
        public System.Threading.Tasks.Task TurnOffAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            return base.Channel.TurnOffAsync(color);
        }
        
        public void TurnOnFlash(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            base.Channel.TurnOnFlash(color);
        }
        
        public System.Threading.Tasks.Task TurnOnFlashAsync(BuildIndicatorSimulator.BuildIndicatorServiceLibaryReference.LightColor color) {
            return base.Channel.TurnOnFlashAsync(color);
        }
        
        public void TurnOffAllLights() {
            base.Channel.TurnOffAllLights();
        }
        
        public System.Threading.Tasks.Task TurnOffAllLightsAsync() {
            return base.Channel.TurnOffAllLightsAsync();
        }
        
        public void GetBuildState(string path) {
            base.Channel.GetBuildState(path);
        }
        
        public System.Threading.Tasks.Task GetBuildStateAsync(string path) {
            return base.Channel.GetBuildStateAsync(path);
        }
        
        public void ResetBuildSource() {
            base.Channel.ResetBuildSource();
        }
        
        public System.Threading.Tasks.Task ResetBuildSourceAsync() {
            return base.Channel.ResetBuildSourceAsync();
        }
        
        public void Run() {
            base.Channel.Run();
        }
        
        public System.Threading.Tasks.Task RunAsync() {
            return base.Channel.RunAsync();
        }
        
        public string GetBuildServiceState() {
            return base.Channel.GetBuildServiceState();
        }
        
        public System.Threading.Tasks.Task<string> GetBuildServiceStateAsync() {
            return base.Channel.GetBuildServiceStateAsync();
        }
        
        public string GetCurrentSource() {
            return base.Channel.GetCurrentSource();
        }
        
        public System.Threading.Tasks.Task<string> GetCurrentSourceAsync() {
            return base.Channel.GetCurrentSourceAsync();
        }
    }
}