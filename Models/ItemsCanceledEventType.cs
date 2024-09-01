    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemsCanceledEventType : AbstractResponseType
    {
        
        private ItemIDArrayType canceledItemIDArrayField;
        
        private bool eligibleForRelistField;
        
        private bool eligibleForRelistFieldSpecified;
        
        private string sellerIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemIDArrayType CanceledItemIDArray
        {
            get
            {
                return this.canceledItemIDArrayField;
            }
            set
            {
                this.canceledItemIDArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EligibleForRelist
        {
            get
            {
                return this.eligibleForRelistField;
            }
            set
            {
                this.eligibleForRelistField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EligibleForRelistSpecified
        {
            get
            {
                return this.eligibleForRelistFieldSpecified;
            }
            set
            {
                this.eligibleForRelistFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerID
        {
            get
            {
                return this.sellerIDField;
            }
            set
            {
                this.sellerIDField = value;
            }
        }
    }
