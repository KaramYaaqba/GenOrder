    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RateTableDetailsType
    {
        
        private string domesticRateTableField;
        
        private string internationalRateTableField;
        
        private string domesticRateTableIdField;
        
        private string internationalRateTableIdField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DomesticRateTable
        {
            get
            {
                return this.domesticRateTableField;
            }
            set
            {
                this.domesticRateTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalRateTable
        {
            get
            {
                return this.internationalRateTableField;
            }
            set
            {
                this.internationalRateTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DomesticRateTableId
        {
            get
            {
                return this.domesticRateTableIdField;
            }
            set
            {
                this.domesticRateTableIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InternationalRateTableId
        {
            get
            {
                return this.internationalRateTableIdField;
            }
            set
            {
                this.internationalRateTableIdField = value;
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
