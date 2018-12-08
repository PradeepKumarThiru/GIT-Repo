﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobListingClient.JobListingSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobListingSvc.IJobListingService")]
    public interface IJobListingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobListingService/OpeningJobs", ReplyAction="http://tempuri.org/IJobListingService/OpeningJobsResponse")]
        string[] OpeningJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobListingService/OpeningJobs", ReplyAction="http://tempuri.org/IJobListingService/OpeningJobsResponse")]
        System.Threading.Tasks.Task<string[]> OpeningJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobListingService/OpeningJobsByRole", ReplyAction="http://tempuri.org/IJobListingService/OpeningJobsByRoleResponse")]
        string[] OpeningJobsByRole(string Role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobListingService/OpeningJobsByRole", ReplyAction="http://tempuri.org/IJobListingService/OpeningJobsByRoleResponse")]
        System.Threading.Tasks.Task<string[]> OpeningJobsByRoleAsync(string Role);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobListingServiceChannel : JobListingClient.JobListingSvc.IJobListingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobListingServiceClient : System.ServiceModel.ClientBase<JobListingClient.JobListingSvc.IJobListingService>, JobListingClient.JobListingSvc.IJobListingService {
        
        public JobListingServiceClient() {
        }
        
        public JobListingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobListingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobListingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobListingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] OpeningJobs() {
            return base.Channel.OpeningJobs();
        }
        
        public System.Threading.Tasks.Task<string[]> OpeningJobsAsync() {
            return base.Channel.OpeningJobsAsync();
        }
        
        public string[] OpeningJobsByRole(string Role) {
            return base.Channel.OpeningJobsByRole(Role);
        }
        
        public System.Threading.Tasks.Task<string[]> OpeningJobsByRoleAsync(string Role) {
            return base.Channel.OpeningJobsByRoleAsync(Role);
        }
    }
}
