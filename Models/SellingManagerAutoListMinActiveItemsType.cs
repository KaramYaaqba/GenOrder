    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAutoListMinActiveItemsType
    {
        
        private int minActiveItemCountField;
        
        private bool minActiveItemCountFieldSpecified;
        
        private System.DateTime listTimeFromField;
        
        private bool listTimeFromFieldSpecified;
        
        private System.DateTime listTimeToField;
        
        private bool listTimeToFieldSpecified;
        
        private int spacingIntervalInMinutesField;
        
        private bool spacingIntervalInMinutesFieldSpecified;
        
        private int listingHoldInventoryLevelField;
        
        private bool listingHoldInventoryLevelFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MinActiveItemCount
        {
            get
            {
                return this.minActiveItemCountField;
            }
            set
            {
                this.minActiveItemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinActiveItemCountSpecified
        {
            get
            {
                return this.minActiveItemCountFieldSpecified;
            }
            set
            {
                this.minActiveItemCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime ListTimeFrom
        {
            get
            {
                return this.listTimeFromField;
            }
            set
            {
                this.listTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListTimeFromSpecified
        {
            get
            {
                return this.listTimeFromFieldSpecified;
            }
            set
            {
                this.listTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime ListTimeTo
        {
            get
            {
                return this.listTimeToField;
            }
            set
            {
                this.listTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListTimeToSpecified
        {
            get
            {
                return this.listTimeToFieldSpecified;
            }
            set
            {
                this.listTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int SpacingIntervalInMinutes
        {
            get
            {
                return this.spacingIntervalInMinutesField;
            }
            set
            {
                this.spacingIntervalInMinutesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpacingIntervalInMinutesSpecified
        {
            get
            {
                return this.spacingIntervalInMinutesFieldSpecified;
            }
            set
            {
                this.spacingIntervalInMinutesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ListingHoldInventoryLevel
        {
            get
            {
                return this.listingHoldInventoryLevelField;
            }
            set
            {
                this.listingHoldInventoryLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingHoldInventoryLevelSpecified
        {
            get
            {
                return this.listingHoldInventoryLevelFieldSpecified;
            }
            set
            {
                this.listingHoldInventoryLevelFieldSpecified = value;
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
