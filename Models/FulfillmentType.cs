    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FulfillmentType
    {
        
        private string fulfillmentByField;
        
        private string fulfillmentRefIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FulfillmentBy
        {
            get
            {
                return this.fulfillmentByField;
            }
            set
            {
                this.fulfillmentByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FulfillmentRefId
        {
            get
            {
                return this.fulfillmentRefIdField;
            }
            set
            {
                this.fulfillmentRefIdField = value;
            }
        }
    }
