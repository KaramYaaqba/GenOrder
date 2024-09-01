    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerTemplatesRequestType : AbstractRequestType
    {
        
        private long[] saleTemplateIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleTemplateID" )]
        public long[] SaleTemplateID
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
    }
