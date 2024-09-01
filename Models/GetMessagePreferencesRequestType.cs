    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMessagePreferencesRequestType : AbstractRequestType
    {
        
        private string sellerIDField;
        
        private bool includeASQPreferencesField;
        
        private bool includeASQPreferencesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerID
        {
            get
            {
                return this.sellerIDField;
            }
            set
            {
                this.sellerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeASQPreferences
        {
            get
            {
                return this.includeASQPreferencesField;
            }
            set
            {
                this.includeASQPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeASQPreferencesSpecified
        {
            get
            {
                return this.includeASQPreferencesFieldSpecified;
            }
            set
            {
                this.includeASQPreferencesFieldSpecified = value;
            }
        }
    }
