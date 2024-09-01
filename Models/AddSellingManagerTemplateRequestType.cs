    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSellingManagerTemplateRequestType : AbstractRequestType
    {
        
        private ItemType itemField;
        
        private string saleTemplateNameField;
        
        private long productIDField;
        
        private bool productIDFieldSpecified;
        
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
    }
