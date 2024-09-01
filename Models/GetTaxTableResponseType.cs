    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetTaxTableResponseType : AbstractResponseType
    {
        
        private System.DateTime lastUpdateTimeField;
        
        private bool lastUpdateTimeFieldSpecified;
        
        private TaxJurisdictionType[] taxTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdateTimeSpecified
        {
            get
            {
                return this.lastUpdateTimeFieldSpecified;
            }
            set
            {
                this.lastUpdateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxJurisdiction", IsNullable=false)]
        public TaxJurisdictionType[] TaxTable
        {
            get
            {
                return this.taxTableField;
            }
            set
            {
                this.taxTableField = value;
            }
        }
    }
