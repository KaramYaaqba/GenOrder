    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerReturnProfileType
    {
        
        private long returnProfileIDField;
        
        private bool returnProfileIDFieldSpecified;
        
        private string returnProfileNameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ReturnProfileID
        {
            get
            {
                return this.returnProfileIDField;
            }
            set
            {
                this.returnProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnProfileIDSpecified
        {
            get
            {
                return this.returnProfileIDFieldSpecified;
            }
            set
            {
                this.returnProfileIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ReturnProfileName
        {
            get
            {
                return this.returnProfileNameField;
            }
            set
            {
                this.returnProfileNameField = value;
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
