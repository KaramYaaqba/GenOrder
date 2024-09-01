    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetPromotionalSaleDetailsResponseType : AbstractResponseType
    {
        
        private PromotionalSaleType[] promotionalSaleDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("PromotionalSale", IsNullable=false)]
        public PromotionalSaleType[] PromotionalSaleDetails
        {
            get
            {
                return this.promotionalSaleDetailsField;
            }
            set
            {
                this.promotionalSaleDetailsField = value;
            }
        }
    }
