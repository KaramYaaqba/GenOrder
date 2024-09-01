    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class OrderType
    {
        
        private string orderIDField;
        
        private OrderStatusCodeType orderStatusField;
        
        private bool orderStatusFieldSpecified;
        
        private AmountType adjustmentAmountField;
        
        private AmountType amountPaidField;
        
        private AmountType amountSavedField;
        
        private CheckoutStatusType checkoutStatusField;
        
        private ShippingDetailsType shippingDetailsField;
        
        private TradingRoleCodeType creatingUserRoleField;
        
        private bool creatingUserRoleFieldSpecified;
        
        private System.DateTime createdTimeField;
        
        private bool createdTimeFieldSpecified;
        
        private BuyerPaymentMethodCodeType[] paymentMethodsField;
        
        private string sellerEmailField;
        
        private AddressType shippingAddressField;
        
        private ShippingServiceOptionsType shippingServiceSelectedField;
        
        private AmountType subtotalField;
        
        private AmountType totalField;
        
        private ExternalTransactionType[] externalTransactionField;
        
        private TransactionType[] transactionArrayField;
        
        private string buyerUserIDField;
        
        private System.DateTime paidTimeField;
        
        private bool paidTimeFieldSpecified;
        
        private System.DateTime shippedTimeField;
        
        private bool shippedTimeFieldSpecified;
        
        private bool integratedMerchantCreditCardEnabledField;
        
        private bool integratedMerchantCreditCardEnabledFieldSpecified;
        
        private bool bundlePurchaseField;
        
        private bool bundlePurchaseFieldSpecified;
        
        private string buyerCheckoutMessageField;
        
        private string eIASTokenField;
        
        private PaymentHoldStatusCodeType paymentHoldStatusField;
        
        private bool paymentHoldStatusFieldSpecified;
        
        private PaymentHoldDetailType paymentHoldDetailsField;
        
        private AmountType refundAmountField;
        
        private string refundStatusField;
        
        private RefundType[] refundArrayField;
        
        private bool isMultiLegShippingField;
        
        private bool isMultiLegShippingFieldSpecified;
        
        private MultiLegShippingDetailsType multiLegShippingDetailsField;
        
        private PaymentsInformationType monetaryDetailsField;
        
        private PickupDetailsType pickupDetailsField;
        
        private PickupMethodSelectedType pickupMethodSelectedField;
        
        private string sellerUserIDField;
        
        private string sellerEIASTokenField;
        
        private string cancelReasonField;
        
        private CancelStatusCodeType cancelStatusField;
        
        private bool cancelStatusFieldSpecified;
        
        private string cancelReasonDetailsField;
        
        private AmountType shippingConvenienceChargeField;
        
        private CancelDetailType[] cancelDetailField;
        
        private string logisticsPlanTypeField;
        
        private TaxIdentifierType[] buyerTaxIdentifierField;
        
        private BuyerPackageEnclosuresType buyerPackageEnclosuresField;
        
        private string extendedOrderIDField;
        
        private bool containseBayPlusTransactionField;
        
        private bool containseBayPlusTransactionFieldSpecified;
        
        private bool eBayCollectAndRemitTaxField;
        
        private bool eBayCollectAndRemitTaxFieldSpecified;
        
        private long orderLineItemCountField;
        
        private bool orderLineItemCountFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public OrderStatusCodeType OrderStatus
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStatusSpecified
        {
            get
            {
                return this.orderStatusFieldSpecified;
            }
            set
            {
                this.orderStatusFieldSpecified = value;
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
        public AmountType AmountSaved
        {
            get
            {
                return this.amountSavedField;
            }
            set
            {
                this.amountSavedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CheckoutStatusType CheckoutStatus
        {
            get
            {
                return this.checkoutStatusField;
            }
            set
            {
                this.checkoutStatusField = value;
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
        public TradingRoleCodeType CreatingUserRole
        {
            get
            {
                return this.creatingUserRoleField;
            }
            set
            {
                this.creatingUserRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatingUserRoleSpecified
        {
            get
            {
                return this.creatingUserRoleFieldSpecified;
            }
            set
            {
                this.creatingUserRoleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField;
            }
            set
            {
                this.createdTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedTimeSpecified
        {
            get
            {
                return this.createdTimeFieldSpecified;
            }
            set
            {
                this.createdTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMethods" )]
        public BuyerPaymentMethodCodeType[] PaymentMethods
        {
            get
            {
                return this.paymentMethodsField;
            }
            set
            {
                this.paymentMethodsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerEmail
        {
            get
            {
                return this.sellerEmailField;
            }
            set
            {
                this.sellerEmailField = value;
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
        public AmountType Subtotal
        {
            get
            {
                return this.subtotalField;
            }
            set
            {
                this.subtotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
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
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transaction", IsNullable=false)]
        public TransactionType[] TransactionArray
        {
            get
            {
                return this.transactionArrayField;
            }
            set
            {
                this.transactionArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BuyerUserID
        {
            get
            {
                return this.buyerUserIDField;
            }
            set
            {
                this.buyerUserIDField = value;
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
        public bool IntegratedMerchantCreditCardEnabled
        {
            get
            {
                return this.integratedMerchantCreditCardEnabledField;
            }
            set
            {
                this.integratedMerchantCreditCardEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntegratedMerchantCreditCardEnabledSpecified
        {
            get
            {
                return this.integratedMerchantCreditCardEnabledFieldSpecified;
            }
            set
            {
                this.integratedMerchantCreditCardEnabledFieldSpecified = value;
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
        public string EIASToken
        {
            get
            {
                return this.eIASTokenField;
            }
            set
            {
                this.eIASTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentHoldStatusCodeType PaymentHoldStatus
        {
            get
            {
                return this.paymentHoldStatusField;
            }
            set
            {
                this.paymentHoldStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentHoldStatusSpecified
        {
            get
            {
                return this.paymentHoldStatusFieldSpecified;
            }
            set
            {
                this.paymentHoldStatusFieldSpecified = value;
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
        public string SellerUserID
        {
            get
            {
                return this.sellerUserIDField;
            }
            set
            {
                this.sellerUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerEIASToken
        {
            get
            {
                return this.sellerEIASTokenField;
            }
            set
            {
                this.sellerEIASTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string CancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CancelStatusCodeType CancelStatus
        {
            get
            {
                return this.cancelStatusField;
            }
            set
            {
                this.cancelStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelStatusSpecified
        {
            get
            {
                return this.cancelStatusFieldSpecified;
            }
            set
            {
                this.cancelStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CancelReasonDetails
        {
            get
            {
                return this.cancelReasonDetailsField;
            }
            set
            {
                this.cancelReasonDetailsField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CancelDetail" )]
        public CancelDetailType[] CancelDetail
        {
            get
            {
                return this.cancelDetailField;
            }
            set
            {
                this.cancelDetailField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("BuyerTaxIdentifier" )]
        public TaxIdentifierType[] BuyerTaxIdentifier
        {
            get
            {
                return this.buyerTaxIdentifierField;
            }
            set
            {
                this.buyerTaxIdentifierField = value;
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
        public bool ContainseBayPlusTransaction
        {
            get
            {
                return this.containseBayPlusTransactionField;
            }
            set
            {
                this.containseBayPlusTransactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContainseBayPlusTransactionSpecified
        {
            get
            {
                return this.containseBayPlusTransactionFieldSpecified;
            }
            set
            {
                this.containseBayPlusTransactionFieldSpecified = value;
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
        public long OrderLineItemCount
        {
            get
            {
                return this.orderLineItemCountField;
            }
            set
            {
                this.orderLineItemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderLineItemCountSpecified
        {
            get
            {
                return this.orderLineItemCountFieldSpecified;
            }
            set
            {
                this.orderLineItemCountFieldSpecified = value;
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
