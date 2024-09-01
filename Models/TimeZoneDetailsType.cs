    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TimeZoneDetailsType
    {
        
        private string timeZoneIDField;
        
        private string standardLabelField;
        
        private string standardOffsetField;
        
        private string daylightSavingsLabelField;
        
        private string daylightSavingsOffsetField;
        
        private bool daylightSavingsInEffectField;
        
        private bool daylightSavingsInEffectFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TimeZoneID
        {
            get
            {
                return this.timeZoneIDField;
            }
            set
            {
                this.timeZoneIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StandardLabel
        {
            get
            {
                return this.standardLabelField;
            }
            set
            {
                this.standardLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StandardOffset
        {
            get
            {
                return this.standardOffsetField;
            }
            set
            {
                this.standardOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DaylightSavingsLabel
        {
            get
            {
                return this.daylightSavingsLabelField;
            }
            set
            {
                this.daylightSavingsLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DaylightSavingsOffset
        {
            get
            {
                return this.daylightSavingsOffsetField;
            }
            set
            {
                this.daylightSavingsOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DaylightSavingsInEffect
        {
            get
            {
                return this.daylightSavingsInEffectField;
            }
            set
            {
                this.daylightSavingsInEffectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaylightSavingsInEffectSpecified
        {
            get
            {
                return this.daylightSavingsInEffectFieldSpecified;
            }
            set
            {
                this.daylightSavingsInEffectFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
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
