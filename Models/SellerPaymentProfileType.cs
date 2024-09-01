    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerPaymentProfileType
    {
        
        private long paymentProfileIDField;
        
        private bool paymentProfileIDFieldSpecified;
        
        private string paymentProfileNameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PaymentProfileID
        {
            get
            {
                return this.paymentProfileIDField;
            }
            set
            {
                this.paymentProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentProfileIDSpecified
        {
            get
            {
                return this.paymentProfileIDFieldSpecified;
            }
            set
            {
                this.paymentProfileIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PaymentProfileName
        {
            get
            {
                return this.paymentProfileNameField;
            }
            set
            {
                this.paymentProfileNameField = value;
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
