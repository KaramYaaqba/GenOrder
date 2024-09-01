    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReviseInventoryStatusResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReviseInventoryStatusResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public ReviseInventoryStatusResponseType ReviseInventoryStatusResponse1;
        
        public ReviseInventoryStatusResponse()
        {
        }
        
        public ReviseInventoryStatusResponse(CustomSecurityHeaderType RequesterCredentials,ReviseInventoryStatusResponseType ReviseInventoryStatusResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.ReviseInventoryStatusResponse1 = ReviseInventoryStatusResponse1;
        }
    }
