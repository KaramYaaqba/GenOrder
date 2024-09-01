    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DispatchTimeMaxDetailsType
    {
        
        private int dispatchTimeMaxField;
        
        private bool dispatchTimeMaxFieldSpecified;
        
        private string descriptionField;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private bool extendedHandlingField;
        
        private bool extendedHandlingFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DispatchTimeMax
        {
            get
            {
                return this.dispatchTimeMaxField;
            }
            set
            {
                this.dispatchTimeMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DispatchTimeMaxSpecified
        {
            get
            {
                return this.dispatchTimeMaxFieldSpecified;
            }
            set
            {
                this.dispatchTimeMaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExtendedHandling
        {
            get
            {
                return this.extendedHandlingField;
            }
            set
            {
                this.extendedHandlingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtendedHandlingSpecified
        {
            get
            {
                return this.extendedHandlingFieldSpecified;
            }
            set
            {
                this.extendedHandlingFieldSpecified = value;
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
