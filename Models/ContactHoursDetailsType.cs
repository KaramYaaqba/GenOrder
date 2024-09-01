    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ContactHoursDetailsType
    {
        
        private string timeZoneIDField;
        
        private DaysCodeType hours1DaysField;
        
        private bool hours1DaysFieldSpecified;
        
        private bool hours1AnyTimeField;
        
        private bool hours1AnyTimeFieldSpecified;
        
        private System.DateTime hours1FromField;
        
        private bool hours1FromFieldSpecified;
        
        private System.DateTime hours1ToField;
        
        private bool hours1ToFieldSpecified;
        
        private DaysCodeType hours2DaysField;
        
        private bool hours2DaysFieldSpecified;
        
        private bool hours2AnyTimeField;
        
        private bool hours2AnyTimeFieldSpecified;
        
        private System.DateTime hours2FromField;
        
        private bool hours2FromFieldSpecified;
        
        private System.DateTime hours2ToField;
        
        private bool hours2ToFieldSpecified;
        
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
        public DaysCodeType Hours1Days
        {
            get
            {
                return this.hours1DaysField;
            }
            set
            {
                this.hours1DaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours1DaysSpecified
        {
            get
            {
                return this.hours1DaysFieldSpecified;
            }
            set
            {
                this.hours1DaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Hours1AnyTime
        {
            get
            {
                return this.hours1AnyTimeField;
            }
            set
            {
                this.hours1AnyTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours1AnyTimeSpecified
        {
            get
            {
                return this.hours1AnyTimeFieldSpecified;
            }
            set
            {
                this.hours1AnyTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime Hours1From
        {
            get
            {
                return this.hours1FromField;
            }
            set
            {
                this.hours1FromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours1FromSpecified
        {
            get
            {
                return this.hours1FromFieldSpecified;
            }
            set
            {
                this.hours1FromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime Hours1To
        {
            get
            {
                return this.hours1ToField;
            }
            set
            {
                this.hours1ToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours1ToSpecified
        {
            get
            {
                return this.hours1ToFieldSpecified;
            }
            set
            {
                this.hours1ToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DaysCodeType Hours2Days
        {
            get
            {
                return this.hours2DaysField;
            }
            set
            {
                this.hours2DaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours2DaysSpecified
        {
            get
            {
                return this.hours2DaysFieldSpecified;
            }
            set
            {
                this.hours2DaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Hours2AnyTime
        {
            get
            {
                return this.hours2AnyTimeField;
            }
            set
            {
                this.hours2AnyTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours2AnyTimeSpecified
        {
            get
            {
                return this.hours2AnyTimeFieldSpecified;
            }
            set
            {
                this.hours2AnyTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime Hours2From
        {
            get
            {
                return this.hours2FromField;
            }
            set
            {
                this.hours2FromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours2FromSpecified
        {
            get
            {
                return this.hours2FromFieldSpecified;
            }
            set
            {
                this.hours2FromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime Hours2To
        {
            get
            {
                return this.hours2ToField;
            }
            set
            {
                this.hours2ToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Hours2ToSpecified
        {
            get
            {
                return this.hours2ToFieldSpecified;
            }
            set
            {
                this.hours2ToFieldSpecified = value;
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
