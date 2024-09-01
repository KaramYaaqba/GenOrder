    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class EndFixedPriceItemResponseType : AbstractResponseType
    {
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private string sKUField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeSpecified
        {
            get
            {
                return this.endTimeFieldSpecified;
            }
            set
            {
                this.endTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
    }
