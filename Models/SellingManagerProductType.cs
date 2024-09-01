    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerProductType
    {
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private SellingManagerTemplateDetailsType[] sellingManagerTemplateDetailsArrayField;
        
        private SellingManagerProductInventoryStatusType sellingManagerProductInventoryStatusField;
        
        private SellingManagerProductSpecificsType sellingManagerProductSpecificsField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        [System.Xml.Serialization.XmlArrayItemAttribute("SellingManagerTemplateDetails", IsNullable=false)]
        public SellingManagerTemplateDetailsType[] SellingManagerTemplateDetailsArray
        {
            get
            {
                return this.sellingManagerTemplateDetailsArrayField;
            }
            set
            {
                this.sellingManagerTemplateDetailsArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductInventoryStatusType SellingManagerProductInventoryStatus
        {
            get
            {
                return this.sellingManagerProductInventoryStatusField;
            }
            set
            {
                this.sellingManagerProductInventoryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductSpecificsType SellingManagerProductSpecifics
        {
            get
            {
                return this.sellingManagerProductSpecificsField;
            }
            set
            {
                this.sellingManagerProductSpecificsField = value;
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
