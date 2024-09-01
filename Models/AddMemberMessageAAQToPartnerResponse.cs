    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMemberMessageAAQToPartnerResponse
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
        public CustomSecurityHeaderType RequesterCredentials;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMemberMessageAAQToPartnerResponse", Namespace="urn:ebay:apis:eBLBaseComponents" )]
        public AddMemberMessageAAQToPartnerResponseType AddMemberMessageAAQToPartnerResponse1;
        
        public AddMemberMessageAAQToPartnerResponse()
        {
        }
        
        public AddMemberMessageAAQToPartnerResponse(CustomSecurityHeaderType RequesterCredentials,AddMemberMessageAAQToPartnerResponseType AddMemberMessageAAQToPartnerResponse1)
        {
            this.RequesterCredentials = RequesterCredentials;
            this.AddMemberMessageAAQToPartnerResponse1 = AddMemberMessageAAQToPartnerResponse1;
        }
    }
