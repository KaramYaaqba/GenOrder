    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SearchDetailsType
    {
        
        private bool buyItNowEnabledField;
        
        private bool buyItNowEnabledFieldSpecified;
        
        private bool pictureField;
        
        private bool pictureFieldSpecified;
        
        private bool recentListingField;
        
        private bool recentListingFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BuyItNowEnabled
        {
            get
            {
                return this.buyItNowEnabledField;
            }
            set
            {
                this.buyItNowEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyItNowEnabledSpecified
        {
            get
            {
                return this.buyItNowEnabledFieldSpecified;
            }
            set
            {
                this.buyItNowEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Picture
        {
            get
            {
                return this.pictureField;
            }
            set
            {
                this.pictureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PictureSpecified
        {
            get
            {
                return this.pictureFieldSpecified;
            }
            set
            {
                this.pictureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool RecentListing
        {
            get
            {
                return this.recentListingField;
            }
            set
            {
                this.recentListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecentListingSpecified
        {
            get
            {
                return this.recentListingFieldSpecified;
            }
            set
            {
                this.recentListingFieldSpecified = value;
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
