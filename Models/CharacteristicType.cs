    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CharacteristicType
    {
        
        private int attributeIDField;
        
        private string dateFormatField;
        
        private string displaySequenceField;
        
        private string displayUOMField;
        
        private LabelType labelField;
        
        private SortOrderCodeType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        private ValType[] valueListField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int AttributeID
        {
            get
            {
                return this.attributeIDField;
            }
            set
            {
                this.attributeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DateFormat
        {
            get
            {
                return this.dateFormatField;
            }
            set
            {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DisplaySequence
        {
            get
            {
                return this.displaySequenceField;
            }
            set
            {
                this.displaySequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DisplayUOM
        {
            get
            {
                return this.displayUOMField;
            }
            set
            {
                this.displayUOMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public LabelType Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SortOrderCodeType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueList" )]
        public ValType[] ValueList
        {
            get
            {
                return this.valueListField;
            }
            set
            {
                this.valueListField = value;
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
