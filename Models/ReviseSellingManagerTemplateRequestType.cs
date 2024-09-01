    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseSellingManagerTemplateRequestType : AbstractRequestType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private long productIDField;
        
        private bool productIDFieldSpecified;
        
        private string saleTemplateNameField;
        
        private ItemType itemField;
        
        private string[] deletedFieldField;
        
        private bool verifyOnlyField;
        
        private bool verifyOnlyFieldSpecified;
        
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
        public long ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductIDSpecified
        {
            get
            {
                return this.productIDFieldSpecified;
            }
            set
            {
                this.productIDFieldSpecified = value;
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
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeletedField" )]
        public string[] DeletedField
        {
            get
            {
                return this.deletedFieldField;
            }
            set
            {
                this.deletedFieldField = value;
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
    }
