    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerSoldOrderType
    {
        
        private SellingManagerSoldTransactionType[] sellingManagerSoldTransactionField;
        
        private AddressType shippingAddressField;
        
        private ShippingDetailsType shippingDetailsField;
        
        private AmountType cashOnDeliveryCostField;
        
        private AmountType totalAmountField;
        
        private int totalQuantityField;
        
        private bool totalQuantityFieldSpecified;
        
        private AmountType itemCostField;
        
        private VATRateType[] vATRateField;
        
        private AmountType netInsuranceFeeField;
        
        private AmountType vATInsuranceFeeField;
        
        private AmountType vATShippingFeeField;
        
        private AmountType netShippingFeeField;
        
        private AmountType netTotalAmountField;
        
        private AmountType vATTotalAmountField;
        
        private AmountType actualShippingCostField;
        
        private AmountType adjustmentAmountField;
        
        private string notesToBuyerField;
        
        private string notesFromBuyerField;
        
        private string notesToSellerField;
        
        private SellingManagerOrderStatusType orderStatusField;
        
        private UnpaidItemStatusTypeCodeType unpaidItemStatusField;
        
        private bool unpaidItemStatusFieldSpecified;
        
        private AmountType salePriceField;
        
        private int emailsSentField;
        
        private bool emailsSentFieldSpecified;
        
        private int daysSinceSaleField;
        
        private bool daysSinceSaleFieldSpecified;
        
        private string buyerIDField;
        
        private string buyerEmailField;
        
        private long saleRecordIDField;
        
        private bool saleRecordIDFieldSpecified;
        
        private System.DateTime creationTimeField;
        
        private bool creationTimeFieldSpecified;
        
        private AmountType refundAmountField;
        
        private string refundStatusField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellingManagerSoldTransaction" )]
        public SellingManagerSoldTransactionType[] SellingManagerSoldTransaction
        {
            get
            {
                return this.sellingManagerSoldTransactionField;
            }
            set
            {
                this.sellingManagerSoldTransactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingDetailsType ShippingDetails
        {
            get
            {
                return this.shippingDetailsField;
            }
            set
            {
                this.shippingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CashOnDeliveryCost
        {
            get
            {
                return this.cashOnDeliveryCostField;
            }
            set
            {
                this.cashOnDeliveryCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalQuantity
        {
            get
            {
                return this.totalQuantityField;
            }
            set
            {
                this.totalQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalQuantitySpecified
        {
            get
            {
                return this.totalQuantityFieldSpecified;
            }
            set
            {
                this.totalQuantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ItemCost
        {
            get
            {
                return this.itemCostField;
            }
            set
            {
                this.itemCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VATRate" )]
        public VATRateType[] VATRate
        {
            get
            {
                return this.vATRateField;
            }
            set
            {
                this.vATRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType NetInsuranceFee
        {
            get
            {
                return this.netInsuranceFeeField;
            }
            set
            {
                this.netInsuranceFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType VATInsuranceFee
        {
            get
            {
                return this.vATInsuranceFeeField;
            }
            set
            {
                this.vATInsuranceFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType VATShippingFee
        {
            get
            {
                return this.vATShippingFeeField;
            }
            set
            {
                this.vATShippingFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType NetShippingFee
        {
            get
            {
                return this.netShippingFeeField;
            }
            set
            {
                this.netShippingFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType NetTotalAmount
        {
            get
            {
                return this.netTotalAmountField;
            }
            set
            {
                this.netTotalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType VATTotalAmount
        {
            get
            {
                return this.vATTotalAmountField;
            }
            set
            {
                this.vATTotalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ActualShippingCost
        {
            get
            {
                return this.actualShippingCostField;
            }
            set
            {
                this.actualShippingCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType AdjustmentAmount
        {
            get
            {
                return this.adjustmentAmountField;
            }
            set
            {
                this.adjustmentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NotesToBuyer
        {
            get
            {
                return this.notesToBuyerField;
            }
            set
            {
                this.notesToBuyerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NotesFromBuyer
        {
            get
            {
                return this.notesFromBuyerField;
            }
            set
            {
                this.notesFromBuyerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NotesToSeller
        {
            get
            {
                return this.notesToSellerField;
            }
            set
            {
                this.notesToSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerOrderStatusType OrderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UnpaidItemStatusTypeCodeType UnpaidItemStatus
        {
            get
            {
                return this.unpaidItemStatusField;
            }
            set
            {
                this.unpaidItemStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnpaidItemStatusSpecified
        {
            get
            {
                return this.unpaidItemStatusFieldSpecified;
            }
            set
            {
                this.unpaidItemStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType SalePrice
        {
            get
            {
                return this.salePriceField;
            }
            set
            {
                this.salePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int EmailsSent
        {
            get
            {
                return this.emailsSentField;
            }
            set
            {
                this.emailsSentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailsSentSpecified
        {
            get
            {
                return this.emailsSentFieldSpecified;
            }
            set
            {
                this.emailsSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DaysSinceSale
        {
            get
            {
                return this.daysSinceSaleField;
            }
            set
            {
                this.daysSinceSaleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysSinceSaleSpecified
        {
            get
            {
                return this.daysSinceSaleFieldSpecified;
            }
            set
            {
                this.daysSinceSaleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerID
        {
            get
            {
                return this.buyerIDField;
            }
            set
            {
                this.buyerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerEmail
        {
            get
            {
                return this.buyerEmailField;
            }
            set
            {
                this.buyerEmailField = value;
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
        public System.DateTime CreationTime
        {
            get
            {
                return this.creationTimeField;
            }
            set
            {
                this.creationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationTimeSpecified
        {
            get
            {
                return this.creationTimeFieldSpecified;
            }
            set
            {
                this.creationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType RefundAmount
        {
            get
            {
                return this.refundAmountField;
            }
            set
            {
                this.refundAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RefundStatus
        {
            get
            {
                return this.refundStatusField;
            }
            set
            {
                this.refundStatusField = value;
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
