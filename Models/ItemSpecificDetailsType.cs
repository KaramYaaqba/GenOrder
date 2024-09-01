    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemSpecificDetailsType
    {
        
        private int maxItemSpecificsPerItemField;
        
        private bool maxItemSpecificsPerItemFieldSpecified;
        
        private int maxValuesPerNameField;
        
        private bool maxValuesPerNameFieldSpecified;
        
        private int maxCharactersPerValueField;
        
        private bool maxCharactersPerValueFieldSpecified;
        
        private int maxCharactersPerNameField;
        
        private bool maxCharactersPerNameFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxItemSpecificsPerItem
        {
            get
            {
                return this.maxItemSpecificsPerItemField;
            }
            set
            {
                this.maxItemSpecificsPerItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxItemSpecificsPerItemSpecified
        {
            get
            {
                return this.maxItemSpecificsPerItemFieldSpecified;
            }
            set
            {
                this.maxItemSpecificsPerItemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxValuesPerName
        {
            get
            {
                return this.maxValuesPerNameField;
            }
            set
            {
                this.maxValuesPerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxValuesPerNameSpecified
        {
            get
            {
                return this.maxValuesPerNameFieldSpecified;
            }
            set
            {
                this.maxValuesPerNameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxCharactersPerValue
        {
            get
            {
                return this.maxCharactersPerValueField;
            }
            set
            {
                this.maxCharactersPerValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxCharactersPerValueSpecified
        {
            get
            {
                return this.maxCharactersPerValueFieldSpecified;
            }
            set
            {
                this.maxCharactersPerValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxCharactersPerName
        {
            get
            {
                return this.maxCharactersPerNameField;
            }
            set
            {
                this.maxCharactersPerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxCharactersPerNameSpecified
        {
            get
            {
                return this.maxCharactersPerNameFieldSpecified;
            }
            set
            {
                this.maxCharactersPerNameFieldSpecified = value;
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
