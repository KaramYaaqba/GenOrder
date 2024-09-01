    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerTemplateAutomationRuleRequestType : AbstractRequestType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleTemplateID
        {
            get
            {
                return this.saleTemplateIDField;
            }
            set
            {
                this.saleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleTemplateIDSpecified
        {
            get
            {
                return this.saleTemplateIDFieldSpecified;
            }
            set
            {
                this.saleTemplateIDFieldSpecified = value;
            }
        }
    }
