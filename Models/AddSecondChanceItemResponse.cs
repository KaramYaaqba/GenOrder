    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddSecondChanceItemResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddSecondChanceItemResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddSecondChanceItemResponseType AddSecondChanceItemResponse1;
        
        public AddSecondChanceItemResponse()
        {
        }
        
        public AddSecondChanceItemResponse(CustomSecurityHeaderType RequesterCredentials,AddSecondChanceItemResponseType AddSecondChanceItemResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddSecondChanceItemResponse1 = AddSecondChanceItemResponse1;
        }
    }
