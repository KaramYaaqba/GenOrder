    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseSellingManagerTemplateResponseType : AbstractResponseType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private FeeType[] feesField;
        
        private string categoryIDField;
        
        private string category2IDField;
        
        private bool verifyOnlyField;
        
        private bool verifyOnlyFieldSpecified;
        
        private string saleTemplateNameField;
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleTemplateID
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleTemplateIDSpecified
        {
            get
            {
                return this.saleTemplateIDFieldSpecified;
            }
            set
            {
                this.saleTemplateIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Category2ID
        {
            get
            {
                return this.category2IDField;
            }
            set
            {
                this.category2IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool VerifyOnly
        {
            get
            {
                return this.verifyOnlyField;
            }
            set
            {
                this.verifyOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VerifyOnlySpecified
        {
            get
            {
                return this.verifyOnlyFieldSpecified;
            }
            set
            {
                this.verifyOnlyFieldSpecified = value;
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
    }
