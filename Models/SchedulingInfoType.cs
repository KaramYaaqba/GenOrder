    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SchedulingInfoType
    {
        
        private int maxScheduledMinutesField;
        
        private bool maxScheduledMinutesFieldSpecified;
        
        private int minScheduledMinutesField;
        
        private bool minScheduledMinutesFieldSpecified;
        
        private int maxScheduledItemsField;
        
        private bool maxScheduledItemsFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxScheduledMinutes
        {
            get
            {
                return this.maxScheduledMinutesField;
            }
            set
            {
                this.maxScheduledMinutesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxScheduledMinutesSpecified
        {
            get
            {
                return this.maxScheduledMinutesFieldSpecified;
            }
            set
            {
                this.maxScheduledMinutesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MinScheduledMinutes
        {
            get
            {
                return this.minScheduledMinutesField;
            }
            set
            {
                this.minScheduledMinutesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinScheduledMinutesSpecified
        {
            get
            {
                return this.minScheduledMinutesFieldSpecified;
            }
            set
            {
                this.minScheduledMinutesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxScheduledItems
        {
            get
            {
                return this.maxScheduledItemsField;
            }
            set
            {
                this.maxScheduledItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxScheduledItemsSpecified
        {
            get
            {
                return this.maxScheduledItemsFieldSpecified;
            }
            set
            {
                this.maxScheduledItemsFieldSpecified = value;
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
