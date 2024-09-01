    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UnpaidItemAssistancePreferencesType
    {
        
        private int delayBeforeOpeningDisputeField;
        
        private bool delayBeforeOpeningDisputeFieldSpecified;
        
        private bool optInStatusField;
        
        private bool optInStatusFieldSpecified;
        
        private bool autoRelistField;
        
        private bool removeAllExcludedUsersField;
        
        private string[] excludedUserField;
        
        private bool autoOptDonationRefundField;
        
        private bool autoOptDonationRefundFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        public UnpaidItemAssistancePreferencesType()
        {
            this.autoRelistField = false;
            this.removeAllExcludedUsersField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DelayBeforeOpeningDispute
        {
            get
            {
                return this.delayBeforeOpeningDisputeField;
            }
            set
            {
                this.delayBeforeOpeningDisputeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DelayBeforeOpeningDisputeSpecified
        {
            get
            {
                return this.delayBeforeOpeningDisputeFieldSpecified;
            }
            set
            {
                this.delayBeforeOpeningDisputeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool OptInStatus
        {
            get
            {
                return this.optInStatusField;
            }
            set
            {
                this.optInStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptInStatusSpecified
        {
            get
            {
                return this.optInStatusFieldSpecified;
            }
            set
            {
                this.optInStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AutoRelist
        {
            get
            {
                return this.autoRelistField;
            }
            set
            {
                this.autoRelistField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RemoveAllExcludedUsers
        {
            get
            {
                return this.removeAllExcludedUsersField;
            }
            set
            {
                this.removeAllExcludedUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExcludedUser" )]
        public string[] ExcludedUser
        {
            get
            {
                return this.excludedUserField;
            }
            set
            {
                this.excludedUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AutoOptDonationRefund
        {
            get
            {
                return this.autoOptDonationRefundField;
            }
            set
            {
                this.autoOptDonationRefundField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoOptDonationRefundSpecified
        {
            get
            {
                return this.autoOptDonationRefundFieldSpecified;
            }
            set
            {
                this.autoOptDonationRefundFieldSpecified = value;
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
