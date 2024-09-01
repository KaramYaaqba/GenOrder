    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TransactionType
    {
        
        private AmountType amountPaidField;
        
        private AmountType adjustmentAmountField;
        
        private AmountType convertedAdjustmentAmountField;
        
        private UserType buyerField;
        
        private ShippingDetailsType shippingDetailsField;
        
        private AmountType convertedAmountPaidField;
        
        private AmountType convertedTransactionPriceField;
        
        private System.DateTime createdDateField;
        
        private bool createdDateFieldSpecified;
        
        private DepositTypeCodeType depositTypeField;
        
        private bool depositTypeFieldSpecified;
        
        private ItemType itemField;
        
        private int quantityPurchasedField;
        
        private bool quantityPurchasedFieldSpecified;
        
        private TransactionStatusType statusField;
        
        private string transactionIDField;
        
        private AmountType transactionPriceField;
        
        private bool bestOfferSaleField;
        
        private bool bestOfferSaleFieldSpecified;
        
        private decimal vATPercentField;
        
        private bool vATPercentFieldSpecified;
        
        private ExternalTransactionType[] externalTransactionField;
        
        private SellingManagerProductDetailsType sellingManagerProductDetailsField;
        
        private ShippingServiceOptionsType shippingServiceSelectedField;
        
        private string buyerMessageField;
        
        private AmountType dutchAuctionBidField;
        
        private PaidStatusCodeType buyerPaidStatusField;
        
        private bool buyerPaidStatusFieldSpecified;
        
        private PaidStatusCodeType sellerPaidStatusField;
        
        private bool sellerPaidStatusFieldSpecified;
        
        private System.DateTime paidTimeField;
        
        private bool paidTimeFieldSpecified;
        
        private System.DateTime shippedTimeField;
        
        private bool shippedTimeFieldSpecified;
        
        private AmountType totalPriceField;
        
        private FeedbackInfoType feedbackLeftField;
        
        private FeedbackInfoType feedbackReceivedField;
        
        private OrderType containingOrderField;
        
        private AmountType finalValueFeeField;
        
        private ListingCheckoutRedirectPreferenceType listingCheckoutRedirectPreferenceField;
        
        private RefundType[] refundArrayField;
        
        private SiteCodeType transactionSiteIDField;
        
        private bool transactionSiteIDFieldSpecified;
        
        private TransactionPlatformCodeType platformField;
        
        private bool platformFieldSpecified;
        
        private string cartIDField;
        
        private bool sellerContactBuyerByEmailField;
        
        private bool sellerContactBuyerByEmailFieldSpecified;
        
        private string payPalEmailAddressField;
        
        private string paisaPayIDField;
        
        private AmountType buyerGuaranteePriceField;
        
        private VariationType variationField;
        
        private string buyerCheckoutMessageField;
        
        private AmountType totalTransactionPriceField;
        
        private TaxesType taxesField;
        
        private bool bundlePurchaseField;
        
        private bool bundlePurchaseFieldSpecified;
        
        private AmountType actualShippingCostField;
        
        private AmountType actualHandlingCostField;
        
        private string orderLineItemIDField;
        
        private string eBayPaymentIDField;
        
        private PaymentHoldDetailType paymentHoldDetailsField;
        
        private SellerDiscountsType sellerDiscountsField;
        
        private AmountType refundAmountField;
        
        private string refundStatusField;
        
        private string codiceFiscaleField;
        
        private bool isMultiLegShippingField;
        
        private bool isMultiLegShippingFieldSpecified;
        
        private MultiLegShippingDetailsType multiLegShippingDetailsField;
        
        private System.DateTime invoiceSentTimeField;
        
        private bool invoiceSentTimeFieldSpecified;
        
        private UnpaidItemType unpaidItemField;
        
        private bool intangibleItemField;
        
        private bool intangibleItemFieldSpecified;
        
        private PaymentsInformationType monetaryDetailsField;
        
        private PickupDetailsType pickupDetailsField;
        
        private PickupMethodSelectedType pickupMethodSelectedField;
        
        private AmountType shippingConvenienceChargeField;
        
        private string logisticsPlanTypeField;
        
        private BuyerPackageEnclosuresType buyerPackageEnclosuresField;
        
        private string inventoryReservationIDField;
        
        private string extendedOrderIDField;
        
        private bool eBayPlusTransactionField;
        
        private bool eBayPlusTransactionFieldSpecified;
        
        private GiftSummaryType giftSummaryField;
        
        private DigitalDeliverySelectedType digitalDeliverySelectedField;
        
        private bool giftField;
        
        private bool giftFieldSpecified;
        
        private bool guaranteedShippingField;
        
        private bool guaranteedShippingFieldSpecified;
        
        private bool guaranteedDeliveryField;
        
        private bool guaranteedDeliveryFieldSpecified;
        
        private bool eBayCollectAndRemitTaxField;
        
        private bool eBayCollectAndRemitTaxFieldSpecified;
        
        private TaxesType eBayCollectAndRemitTaxesField;
        
        private TransactionProgramType programField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType AmountPaid
        {
            get
            {
                return this.amountPaidField;
            }
            set
            {
                this.amountPaidField = value;
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
        public AmountType ConvertedAdjustmentAmount
        {
            get
            {
                return this.convertedAdjustmentAmountField;
            }
            set
            {
                this.convertedAdjustmentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType Buyer
        {
            get
            {
                return this.buyerField;
            }
            set
            {
                this.buyerField = value;
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
        public AmountType ConvertedAmountPaid
        {
            get
            {
                return this.convertedAmountPaidField;
            }
            set
            {
                this.convertedAmountPaidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedTransactionPrice
        {
            get
            {
                return this.convertedTransactionPriceField;
            }
            set
            {
                this.convertedTransactionPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreatedDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedDateSpecified
        {
            get
            {
                return this.createdDateFieldSpecified;
            }
            set
            {
                this.createdDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DepositTypeCodeType DepositType
        {
            get
            {
                return this.depositTypeField;
            }
            set
            {
                this.depositTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositTypeSpecified
        {
            get
            {
                return this.depositTypeFieldSpecified;
            }
            set
            {
                this.depositTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityPurchased
        {
            get
            {
                return this.quantityPurchasedField;
            }
            set
            {
                this.quantityPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityPurchasedSpecified
        {
            get
            {
                return this.quantityPurchasedFieldSpecified;
            }
            set
            {
                this.quantityPurchasedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionStatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TransactionID
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TransactionPrice
        {
            get
            {
                return this.transactionPriceField;
            }
            set
            {
                this.transactionPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BestOfferSale
        {
            get
            {
                return this.bestOfferSaleField;
            }
            set
            {
                this.bestOfferSaleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferSaleSpecified
        {
            get
            {
                return this.bestOfferSaleFieldSpecified;
            }
            set
            {
                this.bestOfferSaleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public decimal VATPercent
        {
            get
            {
                return this.vATPercentField;
            }
            set
            {
                this.vATPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATPercentSpecified
        {
            get
            {
                return this.vATPercentFieldSpecified;
            }
            set
            {
                this.vATPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalTransaction" )]
        public ExternalTransactionType[] ExternalTransaction
        {
            get
            {
                return this.externalTransactionField;
            }
            set
            {
                this.externalTransactionField = value;
            }
        }
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingServiceOptionsType ShippingServiceSelected
        {
            get
            {
                return this.shippingServiceSelectedField;
            }
            set
            {
                this.shippingServiceSelectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerMessage
        {
            get
            {
                return this.buyerMessageField;
            }
            set
            {
                this.buyerMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType DutchAuctionBid
        {
            get
            {
                return this.dutchAuctionBidField;
            }
            set
            {
                this.dutchAuctionBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaidStatusCodeType BuyerPaidStatus
        {
            get
            {
                return this.buyerPaidStatusField;
            }
            set
            {
                this.buyerPaidStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyerPaidStatusSpecified
        {
            get
            {
                return this.buyerPaidStatusFieldSpecified;
            }
            set
            {
                this.buyerPaidStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaidStatusCodeType SellerPaidStatus
        {
            get
            {
                return this.sellerPaidStatusField;
            }
            set
            {
                this.sellerPaidStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerPaidStatusSpecified
        {
            get
            {
                return this.sellerPaidStatusFieldSpecified;
            }
            set
            {
                this.sellerPaidStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PaidTime
        {
            get
            {
                return this.paidTimeField;
            }
            set
            {
                this.paidTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaidTimeSpecified
        {
            get
            {
                return this.paidTimeFieldSpecified;
            }
            set
            {
                this.paidTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ShippedTime
        {
            get
            {
                return this.shippedTimeField;
            }
            set
            {
                this.shippedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedTimeSpecified
        {
            get
            {
                return this.shippedTimeFieldSpecified;
            }
            set
            {
                this.shippedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalPrice
        {
            get
            {
                return this.totalPriceField;
            }
            set
            {
                this.totalPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackInfoType FeedbackLeft
        {
            get
            {
                return this.feedbackLeftField;
            }
            set
            {
                this.feedbackLeftField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackInfoType FeedbackReceived
        {
            get
            {
                return this.feedbackReceivedField;
            }
            set
            {
                this.feedbackReceivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public OrderType ContainingOrder
        {
            get
            {
                return this.containingOrderField;
            }
            set
            {
                this.containingOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType FinalValueFee
        {
            get
            {
                return this.finalValueFeeField;
            }
            set
            {
                this.finalValueFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingCheckoutRedirectPreferenceType ListingCheckoutRedirectPreference
        {
            get
            {
                return this.listingCheckoutRedirectPreferenceField;
            }
            set
            {
                this.listingCheckoutRedirectPreferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Refund", IsNullable=false)]
        public RefundType[] RefundArray
        {
            get
            {
                return this.refundArrayField;
            }
            set
            {
                this.refundArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SiteCodeType TransactionSiteID
        {
            get
            {
                return this.transactionSiteIDField;
            }
            set
            {
                this.transactionSiteIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionSiteIDSpecified
        {
            get
            {
                return this.transactionSiteIDFieldSpecified;
            }
            set
            {
                this.transactionSiteIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionPlatformCodeType Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlatformSpecified
        {
            get
            {
                return this.platformFieldSpecified;
            }
            set
            {
                this.platformFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CartID
        {
            get
            {
                return this.cartIDField;
            }
            set
            {
                this.cartIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SellerContactBuyerByEmail
        {
            get
            {
                return this.sellerContactBuyerByEmailField;
            }
            set
            {
                this.sellerContactBuyerByEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerContactBuyerByEmailSpecified
        {
            get
            {
                return this.sellerContactBuyerByEmailFieldSpecified;
            }
            set
            {
                this.sellerContactBuyerByEmailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PayPalEmailAddress
        {
            get
            {
                return this.payPalEmailAddressField;
            }
            set
            {
                this.payPalEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PaisaPayID
        {
            get
            {
                return this.paisaPayIDField;
            }
            set
            {
                this.paisaPayIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType BuyerGuaranteePrice
        {
            get
            {
                return this.buyerGuaranteePriceField;
            }
            set
            {
                this.buyerGuaranteePriceField = value;
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
        public string BuyerCheckoutMessage
        {
            get
            {
                return this.buyerCheckoutMessageField;
            }
            set
            {
                this.buyerCheckoutMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TotalTransactionPrice
        {
            get
            {
                return this.totalTransactionPriceField;
            }
            set
            {
                this.totalTransactionPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TaxesType Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BundlePurchase
        {
            get
            {
                return this.bundlePurchaseField;
            }
            set
            {
                this.bundlePurchaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BundlePurchaseSpecified
        {
            get
            {
                return this.bundlePurchaseFieldSpecified;
            }
            set
            {
                this.bundlePurchaseFieldSpecified = value;
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
        public AmountType ActualHandlingCost
        {
            get
            {
                return this.actualHandlingCostField;
            }
            set
            {
                this.actualHandlingCostField = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string eBayPaymentID
        {
            get
            {
                return this.eBayPaymentIDField;
            }
            set
            {
                this.eBayPaymentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentHoldDetailType PaymentHoldDetails
        {
            get
            {
                return this.paymentHoldDetailsField;
            }
            set
            {
                this.paymentHoldDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerDiscountsType SellerDiscounts
        {
            get
            {
                return this.sellerDiscountsField;
            }
            set
            {
                this.sellerDiscountsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CodiceFiscale
        {
            get
            {
                return this.codiceFiscaleField;
            }
            set
            {
                this.codiceFiscaleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IsMultiLegShipping
        {
            get
            {
                return this.isMultiLegShippingField;
            }
            set
            {
                this.isMultiLegShippingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsMultiLegShippingSpecified
        {
            get
            {
                return this.isMultiLegShippingFieldSpecified;
            }
            set
            {
                this.isMultiLegShippingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MultiLegShippingDetailsType MultiLegShippingDetails
        {
            get
            {
                return this.multiLegShippingDetailsField;
            }
            set
            {
                this.multiLegShippingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime InvoiceSentTime
        {
            get
            {
                return this.invoiceSentTimeField;
            }
            set
            {
                this.invoiceSentTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceSentTimeSpecified
        {
            get
            {
                return this.invoiceSentTimeFieldSpecified;
            }
            set
            {
                this.invoiceSentTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UnpaidItemType UnpaidItem
        {
            get
            {
                return this.unpaidItemField;
            }
            set
            {
                this.unpaidItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IntangibleItem
        {
            get
            {
                return this.intangibleItemField;
            }
            set
            {
                this.intangibleItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntangibleItemSpecified
        {
            get
            {
                return this.intangibleItemFieldSpecified;
            }
            set
            {
                this.intangibleItemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentsInformationType MonetaryDetails
        {
            get
            {
                return this.monetaryDetailsField;
            }
            set
            {
                this.monetaryDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PickupDetailsType PickupDetails
        {
            get
            {
                return this.pickupDetailsField;
            }
            set
            {
                this.pickupDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PickupMethodSelectedType PickupMethodSelected
        {
            get
            {
                return this.pickupMethodSelectedField;
            }
            set
            {
                this.pickupMethodSelectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ShippingConvenienceCharge
        {
            get
            {
                return this.shippingConvenienceChargeField;
            }
            set
            {
                this.shippingConvenienceChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string LogisticsPlanType
        {
            get
            {
                return this.logisticsPlanTypeField;
            }
            set
            {
                this.logisticsPlanTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerPackageEnclosuresType BuyerPackageEnclosures
        {
            get
            {
                return this.buyerPackageEnclosuresField;
            }
            set
            {
                this.buyerPackageEnclosuresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string InventoryReservationID
        {
            get
            {
                return this.inventoryReservationIDField;
            }
            set
            {
                this.inventoryReservationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExtendedOrderID
        {
            get
            {
                return this.extendedOrderIDField;
            }
            set
            {
                this.extendedOrderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool eBayPlusTransaction
        {
            get
            {
                return this.eBayPlusTransactionField;
            }
            set
            {
                this.eBayPlusTransactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eBayPlusTransactionSpecified
        {
            get
            {
                return this.eBayPlusTransactionFieldSpecified;
            }
            set
            {
                this.eBayPlusTransactionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GiftSummaryType GiftSummary
        {
            get
            {
                return this.giftSummaryField;
            }
            set
            {
                this.giftSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DigitalDeliverySelectedType DigitalDeliverySelected
        {
            get
            {
                return this.digitalDeliverySelectedField;
            }
            set
            {
                this.digitalDeliverySelectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Gift
        {
            get
            {
                return this.giftField;
            }
            set
            {
                this.giftField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GiftSpecified
        {
            get
            {
                return this.giftFieldSpecified;
            }
            set
            {
                this.giftFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool GuaranteedShipping
        {
            get
            {
                return this.guaranteedShippingField;
            }
            set
            {
                this.guaranteedShippingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteedShippingSpecified
        {
            get
            {
                return this.guaranteedShippingFieldSpecified;
            }
            set
            {
                this.guaranteedShippingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool GuaranteedDelivery
        {
            get
            {
                return this.guaranteedDeliveryField;
            }
            set
            {
                this.guaranteedDeliveryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuaranteedDeliverySpecified
        {
            get
            {
                return this.guaranteedDeliveryFieldSpecified;
            }
            set
            {
                this.guaranteedDeliveryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool eBayCollectAndRemitTax
        {
            get
            {
                return this.eBayCollectAndRemitTaxField;
            }
            set
            {
                this.eBayCollectAndRemitTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eBayCollectAndRemitTaxSpecified
        {
            get
            {
                return this.eBayCollectAndRemitTaxFieldSpecified;
            }
            set
            {
                this.eBayCollectAndRemitTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TaxesType eBayCollectAndRemitTaxes
        {
            get
            {
                return this.eBayCollectAndRemitTaxesField;
            }
            set
            {
                this.eBayCollectAndRemitTaxesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionProgramType Program
        {
            get
            {
                return this.programField;
            }
            set
            {
                this.programField = value;
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
