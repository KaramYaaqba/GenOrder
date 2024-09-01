    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerTemplatesResponseType : AbstractResponseType
    {
        
        private SellingManagerTemplateDetailsType[] sellingManagerTemplateDetailsArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("SellingManagerTemplateDetails", IsNullable=false)]
        public SellingManagerTemplateDetailsType[] SellingManagerTemplateDetailsArray
        {
            get
            {
                return this.sellingManagerTemplateDetailsArrayField;
            }
            set
            {
                this.sellingManagerTemplateDetailsArrayField = value;
            }
        }
    }
