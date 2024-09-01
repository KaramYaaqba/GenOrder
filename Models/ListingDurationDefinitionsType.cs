    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ListingDurationDefinitionsType
    {
        
        private ListingDurationDefinitionType[] listingDurationField;
        
        private int versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListingDuration" )]
        public ListingDurationDefinitionType[] ListingDuration
        {
            get
            {
                return this.listingDurationField;
            }
            set
            {
                this.listingDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VersionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }
    }
