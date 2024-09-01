    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetApiAccessRulesResponseType : AbstractResponseType
    {
        
        private ApiAccessRuleType[] apiAccessRuleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApiAccessRule" )]
        public ApiAccessRuleType[] ApiAccessRule
        {
            get
            {
                return this.apiAccessRuleField;
            }
            set
            {
                this.apiAccessRuleField = value;
            }
        }
    }
