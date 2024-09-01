    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetBidderListRequestType : AbstractRequestType
    {
        
        private bool activeItemsOnlyField;
        
        private bool activeItemsOnlyFieldSpecified;
        
        private System.DateTime endTimeFromField;
        
        private bool endTimeFromFieldSpecified;
        
        private System.DateTime endTimeToField;
        
        private bool endTimeToFieldSpecified;
        
        private string userIDField;
        
        private GranularityLevelCodeType granularityLevelField;
        
        private bool granularityLevelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ActiveItemsOnly
        {
            get
            {
                return this.activeItemsOnlyField;
            }
            set
            {
                this.activeItemsOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveItemsOnlySpecified
        {
            get
            {
                return this.activeItemsOnlyFieldSpecified;
            }
            set
            {
                this.activeItemsOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeFrom
        {
            get
            {
                return this.endTimeFromField;
            }
            set
            {
                this.endTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeFromSpecified
        {
            get
            {
                return this.endTimeFromFieldSpecified;
            }
            set
            {
                this.endTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeTo
        {
            get
            {
                return this.endTimeToField;
            }
            set
            {
                this.endTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeToSpecified
        {
            get
            {
                return this.endTimeToFieldSpecified;
            }
            set
            {
                this.endTimeToFieldSpecified = value;
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
        public GranularityLevelCodeType GranularityLevel
        {
            get
            {
                return this.granularityLevelField;
            }
            set
            {
                this.granularityLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GranularityLevelSpecified
        {
            get
            {
                return this.granularityLevelFieldSpecified;
            }
            set
            {
                this.granularityLevelFieldSpecified = value;
            }
        }
    }
