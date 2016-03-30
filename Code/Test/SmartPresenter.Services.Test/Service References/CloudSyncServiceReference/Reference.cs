﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartPresenter.Services.Test.CloudSyncServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CloudSyncServiceReference.ICloudSyncService")]
    public interface ICloudSyncService {
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (DownloadDocument)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadDocument", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadDocumentResponse")]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData DownloadDocument(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadDocument", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadDocumentResponse")]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadDocumentAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (UploadDocument)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadDocument")]
        void UploadDocument(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadDocument")]
        System.Threading.Tasks.Task UploadDocumentAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (UploadImageFile)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadImageFile")]
        void UploadImageFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadImageFile")]
        System.Threading.Tasks.Task UploadImageFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (DownloadImageFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadImageFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadImageFileResponse")]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData DownloadImageFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadImageFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadImageFileResponse")]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadImageFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (UploadAudioFile)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadAudioFile")]
        void UploadAudioFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadAudioFile")]
        System.Threading.Tasks.Task UploadAudioFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (DownloadAudioFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadAudioFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadAudioFileResponse")]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData DownloadAudioFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadAudioFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadAudioFileResponse")]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadAudioFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (UploadVideoFile)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadVideoFile")]
        void UploadVideoFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadVideoFile")]
        System.Threading.Tasks.Task UploadVideoFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (DownloadVideoFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadVideoFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadVideoFileResponse")]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData DownloadVideoFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadVideoFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadVideoFileResponse")]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadVideoFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (UploadSettingsFile)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadSettingsFile")]
        void UploadSettingsFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICloudSyncService/UploadSettingsFile")]
        System.Threading.Tasks.Task UploadSettingsFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        // CODEGEN: Generating message contract since the wrapper name (LibraryStreamData) of message LibraryStreamData does not match the default value (DownloadSettingsFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadSettingsFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadSettingsFileResponse")]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData DownloadSettingsFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICloudSyncService/DownloadSettingsFile", ReplyAction="http://tempuri.org/ICloudSyncService/DownloadSettingsFileResponse")]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadSettingsFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LibraryStreamData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LibraryStreamData {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public System.Guid LibraryId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public System.Guid UserAccountId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public System.Guid UserProfileId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream ByteStream;
        
        public LibraryStreamData() {
        }
        
        public LibraryStreamData(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            this.FileName = FileName;
            this.LibraryId = LibraryId;
            this.UserAccountId = UserAccountId;
            this.UserProfileId = UserProfileId;
            this.ByteStream = ByteStream;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICloudSyncServiceChannel : SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CloudSyncServiceClient : System.ServiceModel.ClientBase<SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService>, SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService {
        
        public CloudSyncServiceClient() {
        }
        
        public CloudSyncServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CloudSyncServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CloudSyncServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CloudSyncServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadDocument(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadDocument(request);
        }
        
        public void DownloadDocument(ref string FileName, ref System.Guid LibraryId, ref System.Guid UserAccountId, ref System.Guid UserProfileId, ref System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData retVal = ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadDocument(inValue);
            FileName = retVal.FileName;
            LibraryId = retVal.LibraryId;
            UserAccountId = retVal.UserAccountId;
            UserProfileId = retVal.UserProfileId;
            ByteStream = retVal.ByteStream;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadDocumentAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadDocumentAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadDocument(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            base.Channel.UploadDocument(request);
        }
        
        public void UploadDocument(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadDocument(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadDocumentAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.UploadDocumentAsync(request);
        }
        
        public System.Threading.Tasks.Task UploadDocumentAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadDocumentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadImageFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            base.Channel.UploadImageFile(request);
        }
        
        public void UploadImageFile(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadImageFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadImageFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.UploadImageFileAsync(request);
        }
        
        public System.Threading.Tasks.Task UploadImageFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadImageFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadImageFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadImageFile(request);
        }
        
        public void DownloadImageFile(ref string FileName, ref System.Guid LibraryId, ref System.Guid UserAccountId, ref System.Guid UserProfileId, ref System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData retVal = ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadImageFile(inValue);
            FileName = retVal.FileName;
            LibraryId = retVal.LibraryId;
            UserAccountId = retVal.UserAccountId;
            UserProfileId = retVal.UserProfileId;
            ByteStream = retVal.ByteStream;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadImageFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadImageFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadImageFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadImageFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadAudioFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            base.Channel.UploadAudioFile(request);
        }
        
        public void UploadAudioFile(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadAudioFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadAudioFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.UploadAudioFileAsync(request);
        }
        
        public System.Threading.Tasks.Task UploadAudioFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadAudioFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadAudioFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadAudioFile(request);
        }
        
        public void DownloadAudioFile(ref string FileName, ref System.Guid LibraryId, ref System.Guid UserAccountId, ref System.Guid UserProfileId, ref System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData retVal = ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadAudioFile(inValue);
            FileName = retVal.FileName;
            LibraryId = retVal.LibraryId;
            UserAccountId = retVal.UserAccountId;
            UserProfileId = retVal.UserProfileId;
            ByteStream = retVal.ByteStream;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadAudioFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadAudioFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadAudioFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadAudioFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadVideoFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            base.Channel.UploadVideoFile(request);
        }
        
        public void UploadVideoFile(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadVideoFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadVideoFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.UploadVideoFileAsync(request);
        }
        
        public System.Threading.Tasks.Task UploadVideoFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadVideoFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadVideoFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadVideoFile(request);
        }
        
        public void DownloadVideoFile(ref string FileName, ref System.Guid LibraryId, ref System.Guid UserAccountId, ref System.Guid UserProfileId, ref System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData retVal = ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadVideoFile(inValue);
            FileName = retVal.FileName;
            LibraryId = retVal.LibraryId;
            UserAccountId = retVal.UserAccountId;
            UserProfileId = retVal.UserProfileId;
            ByteStream = retVal.ByteStream;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadVideoFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadVideoFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadVideoFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadVideoFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadSettingsFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            base.Channel.UploadSettingsFile(request);
        }
        
        public void UploadSettingsFile(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadSettingsFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.UploadSettingsFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.UploadSettingsFileAsync(request);
        }
        
        public System.Threading.Tasks.Task UploadSettingsFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).UploadSettingsFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadSettingsFile(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadSettingsFile(request);
        }
        
        public void DownloadSettingsFile(ref string FileName, ref System.Guid LibraryId, ref System.Guid UserAccountId, ref System.Guid UserProfileId, ref System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData retVal = ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadSettingsFile(inValue);
            FileName = retVal.FileName;
            LibraryId = retVal.LibraryId;
            UserAccountId = retVal.UserAccountId;
            UserProfileId = retVal.UserProfileId;
            ByteStream = retVal.ByteStream;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService.DownloadSettingsFileAsync(SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData request) {
            return base.Channel.DownloadSettingsFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData> DownloadSettingsFileAsync(string FileName, System.Guid LibraryId, System.Guid UserAccountId, System.Guid UserProfileId, System.IO.Stream ByteStream) {
            SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData inValue = new SmartPresenter.Services.Test.CloudSyncServiceReference.LibraryStreamData();
            inValue.FileName = FileName;
            inValue.LibraryId = LibraryId;
            inValue.UserAccountId = UserAccountId;
            inValue.UserProfileId = UserProfileId;
            inValue.ByteStream = ByteStream;
            return ((SmartPresenter.Services.Test.CloudSyncServiceReference.ICloudSyncService)(this)).DownloadSettingsFileAsync(inValue);
        }
    }
}