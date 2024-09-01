    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class InternationalReturnsAcceptedCodeType
    {
        
        private ReturnsAcceptedCodeType[] internationalReturnsAcceptedField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InternationalReturnsAccepted" )]
        public ReturnsAcceptedCodeType[] InternationalReturnsAccepted
        {
            get
            {
                return this.internationalReturnsAcceptedField;
            }
            set
            {
                this.internationalReturnsAcceptedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
