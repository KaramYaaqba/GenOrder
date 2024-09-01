    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PaymentHoldDetailType
    {
        
        private System.DateTime expectedReleaseDateField;
        
        private bool expectedReleaseDateFieldSpecified;
        
        private RequiredSellerActionCodeType[] requiredSellerActionArrayField;
        
        private int numOfReqSellerActionsField;
        
        private bool numOfReqSellerActionsFieldSpecified;
        
        private PaymentHoldReasonCodeType paymentHoldReasonField;
        
        private bool paymentHoldReasonFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ExpectedReleaseDate
        {
            get
            {
                return this.expectedReleaseDateField;
            }
            set
            {
                this.expectedReleaseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedReleaseDateSpecified
        {
            get
            {
                return this.expectedReleaseDateFieldSpecified;
            }
            set
            {
                this.expectedReleaseDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("RequiredSellerAction", IsNullable=false)]
        public RequiredSellerActionCodeType[] RequiredSellerActionArray
        {
            get
            {
                return this.requiredSellerActionArrayField;
            }
            set
            {
                this.requiredSellerActionArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NumOfReqSellerActions
        {
            get
            {
                return this.numOfReqSellerActionsField;
            }
            set
            {
                this.numOfReqSellerActionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumOfReqSellerActionsSpecified
        {
            get
            {
                return this.numOfReqSellerActionsFieldSpecified;
            }
            set
            {
                this.numOfReqSellerActionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentHoldReasonCodeType PaymentHoldReason
        {
            get
            {
                return this.paymentHoldReasonField;
            }
            set
            {
                this.paymentHoldReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentHoldReasonSpecified
        {
            get
            {
                return this.paymentHoldReasonFieldSpecified;
            }
            set
            {
                this.paymentHoldReasonFieldSpecified = value;
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
