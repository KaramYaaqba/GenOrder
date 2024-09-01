    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSellingManagerProductRequestType : AbstractRequestType
    {
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
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
        public long FolderID
        {
            get
            {
                return this.folderIDField;
            }
            set
            {
                this.folderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolderIDSpecified
        {
            get
            {
                return this.folderIDFieldSpecified;
            }
            set
            {
                this.folderIDFieldSpecified = value;
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
