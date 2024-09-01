    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetBidderListResponseType : AbstractResponseType
    {
        
        private UserType bidderField;
        
        private ItemType[] bidItemArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType Bidder
        {
            get
            {
                return this.bidderField;
            }
            set
            {
                this.bidderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public ItemType[] BidItemArray
        {
            get
            {
                return this.bidItemArrayField;
            }
            set
            {
                this.bidItemArrayField = value;
            }
        }
    }
