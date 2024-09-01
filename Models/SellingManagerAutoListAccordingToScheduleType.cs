    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAutoListAccordingToScheduleType
    {
        
        private DayOfWeekCodeType[] dayOfWeekField;
        
        private int listingPeriodInWeeksField;
        
        private bool listingPeriodInWeeksFieldSpecified;
        
        private System.DateTime listAtSpecificTimeOfDayField;
        
        private bool listAtSpecificTimeOfDayFieldSpecified;
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private int maxActiveItemCountField;
        
        private bool maxActiveItemCountFieldSpecified;
        
        private int listingHoldInventoryLevelField;
        
        private bool listingHoldInventoryLevelFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DayOfWeek" )]
        public DayOfWeekCodeType[] DayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ListingPeriodInWeeks
        {
            get
            {
                return this.listingPeriodInWeeksField;
            }
            set
            {
                this.listingPeriodInWeeksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingPeriodInWeeksSpecified
        {
            get
            {
                return this.listingPeriodInWeeksFieldSpecified;
            }
            set
            {
                this.listingPeriodInWeeksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime ListAtSpecificTimeOfDay
        {
            get
            {
                return this.listAtSpecificTimeOfDayField;
            }
            set
            {
                this.listAtSpecificTimeOfDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListAtSpecificTimeOfDaySpecified
        {
            get
            {
                return this.listAtSpecificTimeOfDayFieldSpecified;
            }
            set
            {
                this.listAtSpecificTimeOfDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeSpecified
        {
            get
            {
                return this.endTimeFieldSpecified;
            }
            set
            {
                this.endTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxActiveItemCount
        {
            get
            {
                return this.maxActiveItemCountField;
            }
            set
            {
                this.maxActiveItemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxActiveItemCountSpecified
        {
            get
            {
                return this.maxActiveItemCountFieldSpecified;
            }
            set
            {
                this.maxActiveItemCountFieldSpecified = value;
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
