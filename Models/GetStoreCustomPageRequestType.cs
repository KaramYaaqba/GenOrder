    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreCustomPageRequestType : AbstractRequestType
    {
        
        private long pageIDField;
        
        private bool pageIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PageID
        {
            get
            {
                return this.pageIDField;
            }
            set
            {
                this.pageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageIDSpecified
        {
            get
            {
                return this.pageIDFieldSpecified;
            }
            set
            {
                this.pageIDFieldSpecified = value;
            }
        }
    }
