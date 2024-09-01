    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShipmentType
    {
        
        private System.DateTime estimatedDeliveryDateField;
        
        private bool estimatedDeliveryDateFieldSpecified;
        
        private AmountType insuredValueField;
        
        private MeasureType packageDepthField;
        
        private MeasureType packageLengthField;
        
        private MeasureType packageWidthField;
        
        private string payPalShipmentIDField;
        
        private long shipmentIDField;
        
        private bool shipmentIDFieldSpecified;
        
        private AmountType postageTotalField;
        
        private System.DateTime printedTimeField;
        
        private bool printedTimeFieldSpecified;
        
        private AddressType shipFromAddressField;
        
        private AddressType shippingAddressField;
        
        private string shippingCarrierUsedField;
        
        private ShippingFeatureCodeType[] shippingFeatureField;
        
        private ShippingPackageCodeType shippingPackageField;
        
        private bool shippingPackageFieldSpecified;
        
        private string shippingServiceUsedField;
        
        private string shipmentTrackingNumberField;
        
        private MeasureType weightMajorField;
        
        private MeasureType weightMinorField;
        
        private ItemTransactionIDType[] itemTransactionIDField;
        
        private System.DateTime deliveryDateField;
        
        private bool deliveryDateFieldSpecified;
        
        private ShipmentDeliveryStatusCodeType deliveryStatusField;
        
        private bool deliveryStatusFieldSpecified;
        
        private System.DateTime refundGrantedTimeField;
        
        private bool refundGrantedTimeFieldSpecified;
        
        private System.DateTime refundRequestedTimeField;
        
        private bool refundRequestedTimeFieldSpecified;
        
        private ShipmentStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private System.DateTime shippedTimeField;
        
        private bool shippedTimeFieldSpecified;
        
        private string notesField;
        
        private ShipmentTrackingDetailsType[] shipmentTrackingDetailsField;
        
        private ShipmentLineItemType shipmentLineItemField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EstimatedDeliveryDate
        {
            get
            {
                return this.estimatedDeliveryDateField;
            }
            set
            {
                this.estimatedDeliveryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstimatedDeliveryDateSpecified
        {
            get
            {
                return this.estimatedDeliveryDateFieldSpecified;
            }
            set
            {
                this.estimatedDeliveryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InsuredValue
        {
            get
            {
                return this.insuredValueField;
            }
            set
            {
                this.insuredValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageDepth
        {
            get
            {
                return this.packageDepthField;
            }
            set
            {
                this.packageDepthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageLength
        {
            get
            {
                return this.packageLengthField;
            }
            set
            {
                this.packageLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType PackageWidth
        {
            get
            {
                return this.packageWidthField;
            }
            set
            {
                this.packageWidthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PayPalShipmentID
        {
            get
            {
                return this.payPalShipmentIDField;
            }
            set
            {
                this.payPalShipmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ShipmentID
        {
            get
            {
                return this.shipmentIDField;
            }
            set
            {
                this.shipmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShipmentIDSpecified
        {
            get
            {
                return this.shipmentIDFieldSpecified;
            }
            set
            {
                this.shipmentIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PostageTotal
        {
            get
            {
                return this.postageTotalField;
            }
            set
            {
                this.postageTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PrintedTime
        {
            get
            {
                return this.printedTimeField;
            }
            set
            {
                this.printedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintedTimeSpecified
        {
            get
            {
                return this.printedTimeFieldSpecified;
            }
            set
            {
                this.printedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ShipFromAddress
        {
            get
            {
                return this.shipFromAddressField;
            }
            set
            {
                this.shipFromAddressField = value;
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
        public string ShippingCarrierUsed
        {
            get
            {
                return this.shippingCarrierUsedField;
            }
            set
            {
                this.shippingCarrierUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingFeature" )]
        public ShippingFeatureCodeType[] ShippingFeature
        {
            get
            {
                return this.shippingFeatureField;
            }
            set
            {
                this.shippingFeatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingPackageCodeType ShippingPackage
        {
            get
            {
                return this.shippingPackageField;
            }
            set
            {
                this.shippingPackageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingPackageSpecified
        {
            get
            {
                return this.shippingPackageFieldSpecified;
            }
            set
            {
                this.shippingPackageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string ShippingServiceUsed
        {
            get
            {
                return this.shippingServiceUsedField;
            }
            set
            {
                this.shippingServiceUsedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ShipmentTrackingNumber
        {
            get
            {
                return this.shipmentTrackingNumberField;
            }
            set
            {
                this.shipmentTrackingNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType WeightMajor
        {
            get
            {
                return this.weightMajorField;
            }
            set
            {
                this.weightMajorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType WeightMinor
        {
            get
            {
                return this.weightMinorField;
            }
            set
            {
                this.weightMinorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemTransactionID" )]
        public ItemTransactionIDType[] ItemTransactionID
        {
            get
            {
                return this.itemTransactionIDField;
            }
            set
            {
                this.itemTransactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime DeliveryDate
        {
            get
            {
                return this.deliveryDateField;
            }
            set
            {
                this.deliveryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateSpecified
        {
            get
            {
                return this.deliveryDateFieldSpecified;
            }
            set
            {
                this.deliveryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShipmentDeliveryStatusCodeType DeliveryStatus
        {
            get
            {
                return this.deliveryStatusField;
            }
            set
            {
                this.deliveryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryStatusSpecified
        {
            get
            {
                return this.deliveryStatusFieldSpecified;
            }
            set
            {
                this.deliveryStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RefundGrantedTime
        {
            get
            {
                return this.refundGrantedTimeField;
            }
            set
            {
                this.refundGrantedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundGrantedTimeSpecified
        {
            get
            {
                return this.refundGrantedTimeFieldSpecified;
            }
            set
            {
                this.refundGrantedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RefundRequestedTime
        {
            get
            {
                return this.refundRequestedTimeField;
            }
            set
            {
                this.refundRequestedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundRequestedTimeSpecified
        {
            get
            {
                return this.refundRequestedTimeFieldSpecified;
            }
            set
            {
                this.refundRequestedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShipmentStatusCodeType Status
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
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
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentTrackingDetails" )]
        public ShipmentTrackingDetailsType[] ShipmentTrackingDetails
        {
            get
            {
                return this.shipmentTrackingDetailsField;
            }
            set
            {
                this.shipmentTrackingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShipmentLineItemType ShipmentLineItem
        {
            get
            {
                return this.shipmentLineItemField;
            }
            set
            {
                this.shipmentLineItemField = value;
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
