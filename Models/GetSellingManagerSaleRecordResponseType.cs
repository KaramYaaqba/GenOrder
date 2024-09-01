    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerSaleRecordResponseType : AbstractResponseType
    {
        
        private SellingManagerSoldOrderType sellingManagerSoldOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerSoldOrderType SellingManagerSoldOrder
        {
            get
            {
                return this.sellingManagerSoldOrderField;
            }
            set
            {
                this.sellingManagerSoldOrderField = value;
            }
        }
    }
