    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReturnPolicyDetailsType
    {
        
        private RefundDetailsType[] refundField;
        
        private ReturnsWithinDetailsType[] returnsWithinField;
        
        private ReturnsAcceptedDetailsType[] returnsAcceptedField;
        
        private bool descriptionField;
        
        private bool descriptionFieldSpecified;
        
        private WarrantyOfferedDetailsType[] warrantyOfferedField;
        
        private WarrantyTypeDetailsType[] warrantyTypeField;
        
        private WarrantyDurationDetailsType[] warrantyDurationField;
        
        private bool eANField;
        
        private bool eANFieldSpecified;
        
        private ShippingCostPaidByDetailsType[] shippingCostPaidByField;
        
        private RestockingFeeValueDetailsType[] restockingFeeValueField;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Refund" )]
        public RefundDetailsType[] Refund
        {
            get
            {
                return this.refundField;
            }
            set
            {
                this.refundField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnsWithin" )]
        public ReturnsWithinDetailsType[] ReturnsWithin
        {
            get
            {
                return this.returnsWithinField;
            }
            set
            {
                this.returnsWithinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnsAccepted" )]
        public ReturnsAcceptedDetailsType[] ReturnsAccepted
        {
            get
            {
                return this.returnsAcceptedField;
            }
            set
            {
                this.returnsAcceptedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return this.descriptionFieldSpecified;
            }
            set
            {
                this.descriptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyOffered" )]
        public WarrantyOfferedDetailsType[] WarrantyOffered
        {
            get
            {
                return this.warrantyOfferedField;
            }
            set
            {
                this.warrantyOfferedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyType" )]
        public WarrantyTypeDetailsType[] WarrantyType
        {
            get
            {
                return this.warrantyTypeField;
            }
            set
            {
                this.warrantyTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyDuration" )]
        public WarrantyDurationDetailsType[] WarrantyDuration
        {
            get
            {
                return this.warrantyDurationField;
            }
            set
            {
                this.warrantyDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EAN
        {
            get
            {
                return this.eANField;
            }
            set
            {
                this.eANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EANSpecified
        {
            get
            {
                return this.eANFieldSpecified;
            }
            set
            {
                this.eANFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingCostPaidBy" )]
        public ShippingCostPaidByDetailsType[] ShippingCostPaidBy
        {
            get
            {
                return this.shippingCostPaidByField;
            }
            set
            {
                this.shippingCostPaidByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RestockingFeeValue" )]
        public RestockingFeeValueDetailsType[] RestockingFeeValue
        {
            get
            {
                return this.restockingFeeValueField;
            }
            set
            {
                this.restockingFeeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
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
