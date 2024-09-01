    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerSoldTransactionType
    {
        
        private string invoiceNumberField;
        
        private long transactionIDField;
        
        private bool transactionIDFieldSpecified;
        
        private long saleRecordIDField;
        
        private bool saleRecordIDFieldSpecified;
        
        private string itemIDField;
        
        private int quantitySoldField;
        
        private bool quantitySoldFieldSpecified;
        
        private AmountType itemPriceField;
        
        private AmountType subtotalAmountField;
        
        private string itemTitleField;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private bool relistedField;
        
        private bool relistedFieldSpecified;
        
        private int watchCountField;
        
        private bool watchCountFieldSpecified;
        
        private AmountType startPriceField;
        
        private AmountType reservePriceField;
        
        private bool secondChanceOfferSentField;
        
        private bool secondChanceOfferSentFieldSpecified;
        
        private string customLabelField;
        
        private TransactionPlatformCodeType soldOnField;
        
        private bool soldOnFieldSpecified;
        
        private TransactionPlatformCodeType[] listedOnField;
        
        private ShipmentType shipmentField;
        
        private bool charityListingField;
        
        private bool charityListingFieldSpecified;
        
        private VariationType variationField;
        
        private string orderLineItemIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumberField;
            }
            set
            {
                this.invoiceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionIDSpecified
        {
            get
            {
                return this.transactionIDFieldSpecified;
            }
            set
            {
                this.transactionIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleRecordID
        {
            get
            {
                return this.saleRecordIDField;
            }
            set
            {
                this.saleRecordIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleRecordIDSpecified
        {
            get
            {
                return this.saleRecordIDFieldSpecified;
            }
            set
            {
                this.saleRecordIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantitySold
        {
            get
            {
                return this.quantitySoldField;
            }
            set
            {
                this.quantitySoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySoldSpecified
        {
            get
            {
                return this.quantitySoldFieldSpecified;
            }
            set
            {
                this.quantitySoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ItemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingTypeCodeType ListingType
        {
            get
            {
                return this.listingTypeField;
            }
            set
            {
                this.listingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingTypeSpecified
        {
            get
            {
                return this.listingTypeFieldSpecified;
            }
            set
            {
                this.listingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Relisted
        {
            get
            {
                return this.relistedField;
            }
            set
            {
                this.relistedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelistedSpecified
        {
            get
            {
                return this.relistedFieldSpecified;
            }
            set
            {
                this.relistedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WatchCount
        {
            get
            {
                return this.watchCountField;
            }
            set
            {
                this.watchCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WatchCountSpecified
        {
            get
            {
                return this.watchCountFieldSpecified;
            }
            set
            {
                this.watchCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType StartPrice
        {
            get
            {
                return this.startPriceField;
            }
            set
            {
                this.startPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ReservePrice
        {
            get
            {
                return this.reservePriceField;
            }
            set
            {
                this.reservePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SecondChanceOfferSent
        {
            get
            {
                return this.secondChanceOfferSentField;
            }
            set
            {
                this.secondChanceOfferSentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecondChanceOfferSentSpecified
        {
            get
            {
                return this.secondChanceOfferSentFieldSpecified;
            }
            set
            {
                this.secondChanceOfferSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CustomLabel
        {
            get
            {
                return this.customLabelField;
            }
            set
            {
                this.customLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionPlatformCodeType SoldOn
        {
            get
            {
                return this.soldOnField;
            }
            set
            {
                this.soldOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoldOnSpecified
        {
            get
            {
                return this.soldOnFieldSpecified;
            }
            set
            {
                this.soldOnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListedOn" )]
        public TransactionPlatformCodeType[] ListedOn
        {
            get
            {
                return this.listedOnField;
            }
            set
            {
                this.listedOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CharityListing
        {
            get
            {
                return this.charityListingField;
            }
            set
            {
                this.charityListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharityListingSpecified
        {
            get
            {
                return this.charityListingFieldSpecified;
            }
            set
            {
                this.charityListingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationType Variation
        {
            get
            {
                return this.variationField;
            }
            set
            {
                this.variationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderLineItemID
        {
            get
            {
                return this.orderLineItemIDField;
            }
            set
            {
                this.orderLineItemIDField = value;
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
