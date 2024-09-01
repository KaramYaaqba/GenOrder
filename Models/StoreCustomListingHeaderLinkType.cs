    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreCustomListingHeaderLinkType
    {
        
        private int linkIDField;
        
        private int orderField;
        
        private StoreCustomListingHeaderLinkCodeType linkTypeField;
        
        private bool linkTypeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int LinkID
        {
            get
            {
                return this.linkIDField;
            }
            set
            {
                this.linkIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomListingHeaderLinkCodeType LinkType
        {
            get
            {
                return this.linkTypeField;
            }
            set
            {
                this.linkTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkTypeSpecified
        {
            get
            {
                return this.linkTypeFieldSpecified;
            }
            set
            {
                this.linkTypeFieldSpecified = value;
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
