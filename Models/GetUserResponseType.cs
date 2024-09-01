    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetUserResponseType : AbstractResponseType
    {
        
        private UserType userField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }
