    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SupportedSellerProfileType
    {
        
        private long profileIDField;
        
        private bool profileIDFieldSpecified;
        
        private string profileTypeField;
        
        private string profileNameField;
        
        private string shortSummaryField;
        
        private CategoryGroupType categoryGroupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ProfileID
        {
            get
            {
                return this.profileIDField;
            }
            set
            {
                this.profileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfileIDSpecified
        {
            get
            {
                return this.profileIDFieldSpecified;
            }
            set
            {
                this.profileIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProfileType
        {
            get
            {
                return this.profileTypeField;
            }
            set
            {
                this.profileTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProfileName
        {
            get
            {
                return this.profileNameField;
            }
            set
            {
                this.profileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShortSummary
        {
            get
            {
                return this.shortSummaryField;
            }
            set
            {
                this.shortSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CategoryGroupType CategoryGroup
        {
            get
            {
                return this.categoryGroupField;
            }
            set
            {
                this.categoryGroupField = value;
            }
        }
    }
