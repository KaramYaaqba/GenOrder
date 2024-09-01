    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MaximumUnpaidItemStrikesInfoDetailsType
    {
        
        private MaximumUnpaidItemStrikesCountDetailsType maximumUnpaidItemStrikesCountField;
        
        private MaximumUnpaidItemStrikesDurationDetailsType[] maximumUnpaidItemStrikesDurationField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MaximumUnpaidItemStrikesCountDetailsType MaximumUnpaidItemStrikesCount
        {
            get
            {
                return this.maximumUnpaidItemStrikesCountField;
            }
            set
            {
                this.maximumUnpaidItemStrikesCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaximumUnpaidItemStrikesDuration" )]
        public MaximumUnpaidItemStrikesDurationDetailsType[] MaximumUnpaidItemStrikesDuration
        {
            get
            {
                return this.maximumUnpaidItemStrikesDurationField;
            }
            set
            {
                this.maximumUnpaidItemStrikesDurationField = value;
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
