    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseSellingManagerProductRequestType : AbstractRequestType
    {
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private SellingManagerFolderDetailsType sellingManagerFolderDetailsField;
        
        private string[] deletedFieldField;
        
        private SellingManagerProductSpecificsType sellingManagerProductSpecificsField;
        
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
        public SellingManagerFolderDetailsType SellingManagerFolderDetails
        {
            get
            {
                return this.sellingManagerFolderDetailsField;
            }
            set
            {
                this.sellingManagerFolderDetailsField = value;
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
    }
