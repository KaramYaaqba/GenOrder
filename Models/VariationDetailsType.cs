    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VariationDetailsType
    {
        
        private int maxVariationsPerItemField;
        
        private bool maxVariationsPerItemFieldSpecified;
        
        private int maxNamesPerVariationSpecificsSetField;
        
        private bool maxNamesPerVariationSpecificsSetFieldSpecified;
        
        private int maxValuesPerVariationSpecificsSetNameField;
        
        private bool maxValuesPerVariationSpecificsSetNameFieldSpecified;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxVariationsPerItem
        {
            get
            {
                return this.maxVariationsPerItemField;
            }
            set
            {
                this.maxVariationsPerItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxVariationsPerItemSpecified
        {
            get
            {
                return this.maxVariationsPerItemFieldSpecified;
            }
            set
            {
                this.maxVariationsPerItemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxNamesPerVariationSpecificsSet
        {
            get
            {
                return this.maxNamesPerVariationSpecificsSetField;
            }
            set
            {
                this.maxNamesPerVariationSpecificsSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxNamesPerVariationSpecificsSetSpecified
        {
            get
            {
                return this.maxNamesPerVariationSpecificsSetFieldSpecified;
            }
            set
            {
                this.maxNamesPerVariationSpecificsSetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxValuesPerVariationSpecificsSetName
        {
            get
            {
                return this.maxValuesPerVariationSpecificsSetNameField;
            }
            set
            {
                this.maxValuesPerVariationSpecificsSetNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxValuesPerVariationSpecificsSetNameSpecified
        {
            get
            {
                return this.maxValuesPerVariationSpecificsSetNameFieldSpecified;
            }
            set
            {
                this.maxValuesPerVariationSpecificsSetNameFieldSpecified = value;
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
