    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSessionIDRequestType : AbstractRequestType
    {
        
        private string ruNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RuName
        {
            get
            {
                return this.ruNameField;
            }
            set
            {
                this.ruNameField = value;
            }
        }
    }
