    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RespondToBestOfferResponseType : AbstractResponseType
    {
        
        private BestOfferType[] respondToBestOfferField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("BestOffer", IsNullable=false)]
        public BestOfferType[] RespondToBestOffer
        {
            get
            {
                return this.respondToBestOfferField;
            }
            set
            {
                this.respondToBestOfferField = value;
            }
        }
    }
