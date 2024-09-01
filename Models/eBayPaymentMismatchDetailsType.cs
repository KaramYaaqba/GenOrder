    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class eBayPaymentMismatchDetailsType
    {
        
        private MismatchTypeCodeType mismatchTypeField;
        
        private bool mismatchTypeFieldSpecified;
        
        private System.DateTime actionRequiredByField;
        
        private bool actionRequiredByFieldSpecified;
        
        private AmountType mismatchAmountField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MismatchTypeCodeType MismatchType
        {
            get
            {
                return this.mismatchTypeField;
            }
            set
            {
                this.mismatchTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MismatchTypeSpecified
        {
            get
            {
                return this.mismatchTypeFieldSpecified;
            }
            set
            {
                this.mismatchTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ActionRequiredBy
        {
            get
            {
                return this.actionRequiredByField;
            }
            set
            {
                this.actionRequiredByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionRequiredBySpecified
        {
            get
            {
                return this.actionRequiredByFieldSpecified;
            }
            set
            {
                this.actionRequiredByFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MismatchAmount
        {
            get
            {
                return this.mismatchAmountField;
            }
            set
            {
                this.mismatchAmountField = value;
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
