    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VeROReportItemType
    {
        
        private string itemIDField;
        
        private long veROReasonCodeIDField;
        
        private bool veROReasonCodeIDFieldSpecified;
        
        private string messageToSellerField;
        
        private bool copyEmailToRightsOwnerField;
        
        private bool copyEmailToRightsOwnerFieldSpecified;
        
        private ShippingRegionCodeType[] regionField;
        
        private CountryCodeType[] countryField;
        
        private string patentField;
        
        private string detailedMessageField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public long VeROReasonCodeID
        {
            get
            {
                return this.veROReasonCodeIDField;
            }
            set
            {
                this.veROReasonCodeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeROReasonCodeIDSpecified
        {
            get
            {
                return this.veROReasonCodeIDFieldSpecified;
            }
            set
            {
                this.veROReasonCodeIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MessageToSeller
        {
            get
            {
                return this.messageToSellerField;
            }
            set
            {
                this.messageToSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CopyEmailToRightsOwner
        {
            get
            {
                return this.copyEmailToRightsOwnerField;
            }
            set
            {
                this.copyEmailToRightsOwnerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CopyEmailToRightsOwnerSpecified
        {
            get
            {
                return this.copyEmailToRightsOwnerFieldSpecified;
            }
            set
            {
                this.copyEmailToRightsOwnerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Region" )]
        public ShippingRegionCodeType[] Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Country" )]
        public CountryCodeType[] Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Patent
        {
            get
            {
                return this.patentField;
            }
            set
            {
                this.patentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailedMessage
        {
            get
            {
                return this.detailedMessageField;
            }
            set
            {
                this.detailedMessageField = value;
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
