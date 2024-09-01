    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSellingManagerTemplateResponseType : AbstractResponseType
    {
        
        private long categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private long category2IDField;
        
        private bool category2IDFieldSpecified;
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private long saleTemplateGroupIDField;
        
        private bool saleTemplateGroupIDFieldSpecified;
        
        private string saleTemplateNameField;
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private FeeType[] feesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long CategoryID
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryIDSpecified
        {
            get
            {
                return this.categoryIDFieldSpecified;
            }
            set
            {
                this.categoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long Category2ID
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Category2IDSpecified
        {
            get
            {
                return this.category2IDFieldSpecified;
            }
            set
            {
                this.category2IDFieldSpecified = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleTemplateGroupID
        {
            get
            {
                return this.saleTemplateGroupIDField;
            }
            set
            {
                this.saleTemplateGroupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleTemplateGroupIDSpecified
        {
            get
            {
                return this.saleTemplateGroupIDFieldSpecified;
            }
            set
            {
                this.saleTemplateGroupIDFieldSpecified = value;
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
    }
