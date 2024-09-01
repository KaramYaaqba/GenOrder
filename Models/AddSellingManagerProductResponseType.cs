    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSellingManagerProductResponseType : AbstractResponseType
    {
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductDetailsType SellingManagerProductDetails
        {
            get
            {
                return this.sellingManagerProductDetailsField;
            }
            set
            {
                this.sellingManagerProductDetailsField = value;
            }
        }
    }
