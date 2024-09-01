    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DisputeType
    {
        
        private string disputeIDField;
        
        private DisputeRecordTypeCodeType disputeRecordTypeField;
        
        private bool disputeRecordTypeFieldSpecified;
        
        private DisputeStateCodeType disputeStateField;
        
        private bool disputeStateFieldSpecified;
        
        private DisputeStatusCodeType disputeStatusField;
        
        private bool disputeStatusFieldSpecified;
        
        private TradingRoleCodeType otherPartyRoleField;
        
        private bool otherPartyRoleFieldSpecified;
        
        private string otherPartyNameField;
        
        private TradingRoleCodeType userRoleField;
        
        private bool userRoleFieldSpecified;
        
        private string buyerUserIDField;
        
        private string sellerUserIDField;
        
        private string transactionIDField;
        
        private ItemType itemField;
        
        private DisputeReasonCodeType disputeReasonField;
        
        private bool disputeReasonFieldSpecified;
        
        private DisputeExplanationCodeType disputeExplanationField;
        
        private bool disputeExplanationFieldSpecified;
        
        private DisputeCreditEligibilityCodeType disputeCreditEligibilityField;
        
        private bool disputeCreditEligibilityFieldSpecified;
        
        private System.DateTime disputeCreatedTimeField;
        
        private bool disputeCreatedTimeFieldSpecified;
        
        private System.DateTime disputeModifiedTimeField;
        
        private bool disputeModifiedTimeFieldSpecified;
        
        private DisputeResolutionType[] disputeResolutionField;
        
        private DisputeMessageType[] disputeMessageField;
        
        private bool escalationField;
        
        private bool escalationFieldSpecified;
        
        private bool purchaseProtectionField;
        
        private bool purchaseProtectionFieldSpecified;
        
        private string orderLineItemIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DisputeID
        {
            get
            {
                return this.disputeIDField;
            }
            set
            {
                this.disputeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeRecordTypeCodeType DisputeRecordType
        {
            get
            {
                return this.disputeRecordTypeField;
            }
            set
            {
                this.disputeRecordTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeRecordTypeSpecified
        {
            get
            {
                return this.disputeRecordTypeFieldSpecified;
            }
            set
            {
                this.disputeRecordTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeStateCodeType DisputeState
        {
            get
            {
                return this.disputeStateField;
            }
            set
            {
                this.disputeStateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeStateSpecified
        {
            get
            {
                return this.disputeStateFieldSpecified;
            }
            set
            {
                this.disputeStateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeStatusCodeType DisputeStatus
        {
            get
            {
                return this.disputeStatusField;
            }
            set
            {
                this.disputeStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeStatusSpecified
        {
            get
            {
                return this.disputeStatusFieldSpecified;
            }
            set
            {
                this.disputeStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TradingRoleCodeType OtherPartyRole
        {
            get
            {
                return this.otherPartyRoleField;
            }
            set
            {
                this.otherPartyRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherPartyRoleSpecified
        {
            get
            {
                return this.otherPartyRoleFieldSpecified;
            }
            set
            {
                this.otherPartyRoleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OtherPartyName
        {
            get
            {
                return this.otherPartyNameField;
            }
            set
            {
                this.otherPartyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TradingRoleCodeType UserRole
        {
            get
            {
                return this.userRoleField;
            }
            set
            {
                this.userRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserRoleSpecified
        {
            get
            {
                return this.userRoleFieldSpecified;
            }
            set
            {
                this.userRoleFieldSpecified = value;
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
        public DisputeReasonCodeType DisputeReason
        {
            get
            {
                return this.disputeReasonField;
            }
            set
            {
                this.disputeReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeReasonSpecified
        {
            get
            {
                return this.disputeReasonFieldSpecified;
            }
            set
            {
                this.disputeReasonFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeExplanationCodeType DisputeExplanation
        {
            get
            {
                return this.disputeExplanationField;
            }
            set
            {
                this.disputeExplanationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeExplanationSpecified
        {
            get
            {
                return this.disputeExplanationFieldSpecified;
            }
            set
            {
                this.disputeExplanationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeCreditEligibilityCodeType DisputeCreditEligibility
        {
            get
            {
                return this.disputeCreditEligibilityField;
            }
            set
            {
                this.disputeCreditEligibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeCreditEligibilitySpecified
        {
            get
            {
                return this.disputeCreditEligibilityFieldSpecified;
            }
            set
            {
                this.disputeCreditEligibilityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime DisputeCreatedTime
        {
            get
            {
                return this.disputeCreatedTimeField;
            }
            set
            {
                this.disputeCreatedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeCreatedTimeSpecified
        {
            get
            {
                return this.disputeCreatedTimeFieldSpecified;
            }
            set
            {
                this.disputeCreatedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime DisputeModifiedTime
        {
            get
            {
                return this.disputeModifiedTimeField;
            }
            set
            {
                this.disputeModifiedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisputeModifiedTimeSpecified
        {
            get
            {
                return this.disputeModifiedTimeFieldSpecified;
            }
            set
            {
                this.disputeModifiedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisputeResolution" )]
        public DisputeResolutionType[] DisputeResolution
        {
            get
            {
                return this.disputeResolutionField;
            }
            set
            {
                this.disputeResolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisputeMessage" )]
        public DisputeMessageType[] DisputeMessage
        {
            get
            {
                return this.disputeMessageField;
            }
            set
            {
                this.disputeMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Escalation
        {
            get
            {
                return this.escalationField;
            }
            set
            {
                this.escalationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EscalationSpecified
        {
            get
            {
                return this.escalationFieldSpecified;
            }
            set
            {
                this.escalationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PurchaseProtection
        {
            get
            {
                return this.purchaseProtectionField;
            }
            set
            {
                this.purchaseProtectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurchaseProtectionSpecified
        {
            get
            {
                return this.purchaseProtectionFieldSpecified;
            }
            set
            {
                this.purchaseProtectionFieldSpecified = value;
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
