    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCharitiesRequestType : AbstractRequestType
    {
        
        private string charityIDField;
        
        private string charityNameField;
        
        private string queryField;
        
        private int charityRegionField;
        
        private bool charityRegionFieldSpecified;
        
        private int charityDomainField;
        
        private bool charityDomainFieldSpecified;
        
        private bool includeDescriptionField;
        
        private bool includeDescriptionFieldSpecified;
        
        private StringMatchCodeType matchTypeField;
        
        private bool matchTypeFieldSpecified;
        
        private bool featuredField;
        
        private bool featuredFieldSpecified;
        
        private long campaignIDField;
        
        private bool campaignIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CharityID
        {
            get
            {
                return this.charityIDField;
            }
            set
            {
                this.charityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CharityName
        {
            get
            {
                return this.charityNameField;
            }
            set
            {
                this.charityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CharityRegion
        {
            get
            {
                return this.charityRegionField;
            }
            set
            {
                this.charityRegionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityRegionSpecified
        {
            get
            {
                return this.charityRegionFieldSpecified;
            }
            set
            {
                this.charityRegionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CharityDomain
        {
            get
            {
                return this.charityDomainField;
            }
            set
            {
                this.charityDomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityDomainSpecified
        {
            get
            {
                return this.charityDomainFieldSpecified;
            }
            set
            {
                this.charityDomainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeDescription
        {
            get
            {
                return this.includeDescriptionField;
            }
            set
            {
                this.includeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeDescriptionSpecified
        {
            get
            {
                return this.includeDescriptionFieldSpecified;
            }
            set
            {
                this.includeDescriptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StringMatchCodeType MatchType
        {
            get
            {
                return this.matchTypeField;
            }
            set
            {
                this.matchTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatchTypeSpecified
        {
            get
            {
                return this.matchTypeFieldSpecified;
            }
            set
            {
                this.matchTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Featured
        {
            get
            {
                return this.featuredField;
            }
            set
            {
                this.featuredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeaturedSpecified
        {
            get
            {
                return this.featuredFieldSpecified;
            }
            set
            {
                this.featuredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long CampaignID
        {
            get
            {
                return this.campaignIDField;
            }
            set
            {
                this.campaignIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CampaignIDSpecified
        {
            get
            {
                return this.campaignIDFieldSpecified;
            }
            set
            {
                this.campaignIDFieldSpecified = value;
            }
        }
    }
