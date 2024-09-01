    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerProductResponseType : AbstractResponseType
    {
        
        private SellingManagerProductDetailsType deletedSellingManagerProductDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductDetailsType DeletedSellingManagerProductDetails
        {
            get
            {
                return this.deletedSellingManagerProductDetailsField;
            }
            set
            {
                this.deletedSellingManagerProductDetailsField = value;
            }
        }
    }
