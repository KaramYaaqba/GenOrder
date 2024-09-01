    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PaymentDetailsType
    {
        
        private int hoursToDepositField;
        
        private bool hoursToDepositFieldSpecified;
        
        private int daysToFullPaymentField;
        
        private bool daysToFullPaymentFieldSpecified;
        
        private AmountType depositAmountField;
        
        private DepositTypeCodeType depositTypeField;
        
        private bool depositTypeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int HoursToDeposit
        {
            get
            {
                return this.hoursToDepositField;
            }
            set
            {
                this.hoursToDepositField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HoursToDepositSpecified
        {
            get
            {
                return this.hoursToDepositFieldSpecified;
            }
            set
            {
                this.hoursToDepositFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DaysToFullPayment
        {
            get
            {
                return this.daysToFullPaymentField;
            }
            set
            {
                this.daysToFullPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DaysToFullPaymentSpecified
        {
            get
            {
                return this.daysToFullPaymentFieldSpecified;
            }
            set
            {
                this.daysToFullPaymentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType DepositAmount
        {
            get
            {
                return this.depositAmountField;
            }
            set
            {
                this.depositAmountField = value;
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
