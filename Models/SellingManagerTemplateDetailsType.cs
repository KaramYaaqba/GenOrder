    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerTemplateDetailsType
    {
        
        private string saleTemplateIDField;
        
        private string saleTemplateNameField;
        
        private float successPercentField;
        
        private bool successPercentFieldSpecified;
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private ItemType templateField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SaleTemplateID
        {
            get
            {
                return this.saleTemplateIDField;
            }
            set
            {
                this.saleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SaleTemplateName
        {
            get
            {
                return this.saleTemplateNameField;
            }
            set
            {
                this.saleTemplateNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float SuccessPercent
        {
            get
            {
                return this.successPercentField;
            }
            set
            {
                this.successPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuccessPercentSpecified
        {
            get
            {
                return this.successPercentFieldSpecified;
            }
            set
            {
                this.successPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductDetailsType SellingManagerProductDetails
        {
            get
            {
                return this.sellingManagerProductDetailsField;
            }
            set
            {
                this.sellingManagerProductDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Template
        {
            get
            {
                return this.templateField;
            }
            set
            {
                this.templateField = value;
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
