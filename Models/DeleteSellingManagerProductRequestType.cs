    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerProductRequestType : AbstractRequestType
    {
        
        private long productIDField;
        
        private bool productIDFieldSpecified;
        
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
