    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseInventoryStatusRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseInventoryStatusRequest", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseInventoryStatusRequestType ReviseInventoryStatusRequest1;
        
        public ReviseInventoryStatusRequest()
        {
        }
        
        public ReviseInventoryStatusRequest(CustomSecurityHeaderType RequesterCredentials,ReviseInventoryStatusRequestType ReviseInventoryStatusRequest1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseInventoryStatusRequest1 = ReviseInventoryStatusRequest1;
        }
    }
