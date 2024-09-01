    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddOrderResponseType : AbstractResponseType
    {
        
        private string orderIDField;
        
        private System.DateTime createdTimeField;
        
        private bool createdTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedTimeSpecified
        {
            get
            {
                return this.createdTimeFieldSpecified;
            }
            set
            {
                this.createdTimeFieldSpecified = value;
            }
        }
    }
