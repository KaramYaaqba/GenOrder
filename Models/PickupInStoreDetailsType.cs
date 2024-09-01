    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PickupInStoreDetailsType
    {
        
        private bool eligibleForPickupInStoreField;
        
        private bool eligibleForPickupInStoreFieldSpecified;
        
        private bool eligibleForPickupDropOffField;
        
        private bool eligibleForPickupDropOffFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EligibleForPickupInStore
        {
            get
            {
                return this.eligibleForPickupInStoreField;
            }
            set
            {
                this.eligibleForPickupInStoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EligibleForPickupInStoreSpecified
        {
            get
            {
                return this.eligibleForPickupInStoreFieldSpecified;
            }
            set
            {
                this.eligibleForPickupInStoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EligibleForPickupDropOff
        {
            get
            {
                return this.eligibleForPickupDropOffField;
            }
            set
            {
                this.eligibleForPickupDropOffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EligibleForPickupDropOffSpecified
        {
            get
            {
                return this.eligibleForPickupDropOffFieldSpecified;
            }
            set
            {
                this.eligibleForPickupDropOffFieldSpecified = value;
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
