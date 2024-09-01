    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VariationProductListingDetailsType
    {
        
        private string iSBNField;
        
        private string uPCField;
        
        private string eANField;
        
        private string productReferenceIDField;
        
        private NameValueListType[] nameValueListField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ISBN
        {
            get
            {
                return this.iSBNField;
            }
            set
            {
                this.iSBNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UPC
        {
            get
            {
                return this.uPCField;
            }
            set
            {
                this.uPCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EAN
        {
            get
            {
                return this.eANField;
            }
            set
            {
                this.eANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProductReferenceID
        {
            get
            {
                return this.productReferenceIDField;
            }
            set
            {
                this.productReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameValueList" )]
        public NameValueListType[] NameValueList
        {
            get
            {
                return this.nameValueListField;
            }
            set
            {
                this.nameValueListField = value;
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
