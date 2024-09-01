    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AdFormatLeadType
    {
        
        private string additionalInformationField;
        
        private AddressType addressField;
        
        private string bestTimeToCallField;
        
        private string emailField;
        
        private System.DateTime submittedTimeField;
        
        private bool submittedTimeFieldSpecified;
        
        private string itemIDField;
        
        private string itemTitleField;
        
        private string userIDField;
        
        private MemberMessageExchangeType[] memberMessageField;
        
        private AdFormatLeadStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private AmountType leadFeeField;
        
        private string externalEmailField;
        
        private string purchaseTimeFrameField;
        
        private string tradeInYearField;
        
        private string tradeInMakeField;
        
        private string tradeInModelField;
        
        private bool financingAnswerField;
        
        private bool financingAnswerFieldSpecified;
        
        private bool answer1Field;
        
        private bool answer1FieldSpecified;
        
        private bool answer2Field;
        
        private bool answer2FieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BestTimeToCall
        {
            get
            {
                return this.bestTimeToCallField;
            }
            set
            {
                this.bestTimeToCallField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime SubmittedTime
        {
            get
            {
                return this.submittedTimeField;
            }
            set
            {
                this.submittedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubmittedTimeSpecified
        {
            get
            {
                return this.submittedTimeFieldSpecified;
            }
            set
            {
                this.submittedTimeFieldSpecified = value;
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
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("MemberMessageExchange", IsNullable=false)]
        public MemberMessageExchangeType[] MemberMessage
        {
            get
            {
                return this.memberMessageField;
            }
            set
            {
                this.memberMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AdFormatLeadStatusCodeType Status
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
        public AmountType LeadFee
        {
            get
            {
                return this.leadFeeField;
            }
            set
            {
                this.leadFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalEmail
        {
            get
            {
                return this.externalEmailField;
            }
            set
            {
                this.externalEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PurchaseTimeFrame
        {
            get
            {
                return this.purchaseTimeFrameField;
            }
            set
            {
                this.purchaseTimeFrameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TradeInYear
        {
            get
            {
                return this.tradeInYearField;
            }
            set
            {
                this.tradeInYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TradeInMake
        {
            get
            {
                return this.tradeInMakeField;
            }
            set
            {
                this.tradeInMakeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TradeInModel
        {
            get
            {
                return this.tradeInModelField;
            }
            set
            {
                this.tradeInModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FinancingAnswer
        {
            get
            {
                return this.financingAnswerField;
            }
            set
            {
                this.financingAnswerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinancingAnswerSpecified
        {
            get
            {
                return this.financingAnswerFieldSpecified;
            }
            set
            {
                this.financingAnswerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Answer1
        {
            get
            {
                return this.answer1Field;
            }
            set
            {
                this.answer1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Answer1Specified
        {
            get
            {
                return this.answer1FieldSpecified;
            }
            set
            {
                this.answer1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Answer2
        {
            get
            {
                return this.answer2Field;
            }
            set
            {
                this.answer2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Answer2Specified
        {
            get
            {
                return this.answer2FieldSpecified;
            }
            set
            {
                this.answer2FieldSpecified = value;
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
