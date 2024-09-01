    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAdFormatLeadsResponseType : AbstractResponseType
    {
        
        private AdFormatLeadType[] adFormatLeadField;
        
        private int adFormatLeadCountField;
        
        private bool adFormatLeadCountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdFormatLead" )]
        public AdFormatLeadType[] AdFormatLead
        {
            get
            {
                return this.adFormatLeadField;
            }
            set
            {
                this.adFormatLeadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int AdFormatLeadCount
        {
            get
            {
                return this.adFormatLeadCountField;
            }
            set
            {
                this.adFormatLeadCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdFormatLeadCountSpecified
        {
            get
            {
                return this.adFormatLeadCountFieldSpecified;
            }
            set
            {
                this.adFormatLeadCountFieldSpecified = value;
            }
        }
    }
