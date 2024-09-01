    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerDiscountType
    {
        
        private long campaignIDField;
        
        private bool campaignIDFieldSpecified;
        
        private string campaignDisplayNameField;
        
        private AmountType itemDiscountAmountField;
        
        private AmountType shippingDiscountAmountField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long CampaignID
        {
            get
            {
                return this.campaignIDField;
            }
            set
            {
                this.campaignIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CampaignIDSpecified
        {
            get
            {
                return this.campaignIDFieldSpecified;
            }
            set
            {
                this.campaignIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CampaignDisplayName
        {
            get
            {
                return this.campaignDisplayNameField;
            }
            set
            {
                this.campaignDisplayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ItemDiscountAmount
        {
            get
            {
                return this.itemDiscountAmountField;
            }
            set
            {
                this.itemDiscountAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingDiscountAmount
        {
            get
            {
                return this.shippingDiscountAmountField;
            }
            set
            {
                this.shippingDiscountAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
