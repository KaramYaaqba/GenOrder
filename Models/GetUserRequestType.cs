    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetUserRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string userIDField;
        
        private bool includeExpressRequirementsField;
        
        private bool includeExpressRequirementsFieldSpecified;
        
        private bool includeFeatureEligibilityField;
        
        private bool includeFeatureEligibilityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeExpressRequirements
        {
            get
            {
                return this.includeExpressRequirementsField;
            }
            set
            {
                this.includeExpressRequirementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeExpressRequirementsSpecified
        {
            get
            {
                return this.includeExpressRequirementsFieldSpecified;
            }
            set
            {
                this.includeExpressRequirementsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeFeatureEligibility
        {
            get
            {
                return this.includeFeatureEligibilityField;
            }
            set
            {
                this.includeFeatureEligibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFeatureEligibilitySpecified
        {
            get
            {
                return this.includeFeatureEligibilityFieldSpecified;
            }
            set
            {
                this.includeFeatureEligibilityFieldSpecified = value;
            }
        }
    }
