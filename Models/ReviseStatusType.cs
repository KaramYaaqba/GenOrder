    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseStatusType
    {
        
        private bool itemRevisedField;
        
        private bool buyItNowAddedField;
        
        private bool buyItNowAddedFieldSpecified;
        
        private bool buyItNowLoweredField;
        
        private bool buyItNowLoweredFieldSpecified;
        
        private bool reserveLoweredField;
        
        private bool reserveLoweredFieldSpecified;
        
        private bool reserveRemovedField;
        
        private bool reserveRemovedFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ItemRevised
        {
            get
            {
                return this.itemRevisedField;
            }
            set
            {
                this.itemRevisedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BuyItNowAdded
        {
            get
            {
                return this.buyItNowAddedField;
            }
            set
            {
                this.buyItNowAddedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyItNowAddedSpecified
        {
            get
            {
                return this.buyItNowAddedFieldSpecified;
            }
            set
            {
                this.buyItNowAddedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool BuyItNowLowered
        {
            get
            {
                return this.buyItNowLoweredField;
            }
            set
            {
                this.buyItNowLoweredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuyItNowLoweredSpecified
        {
            get
            {
                return this.buyItNowLoweredFieldSpecified;
            }
            set
            {
                this.buyItNowLoweredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReserveLowered
        {
            get
            {
                return this.reserveLoweredField;
            }
            set
            {
                this.reserveLoweredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReserveLoweredSpecified
        {
            get
            {
                return this.reserveLoweredFieldSpecified;
            }
            set
            {
                this.reserveLoweredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReserveRemoved
        {
            get
            {
                return this.reserveRemovedField;
            }
            set
            {
                this.reserveRemovedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReserveRemovedSpecified
        {
            get
            {
                return this.reserveRemovedFieldSpecified;
            }
            set
            {
                this.reserveRemovedFieldSpecified = value;
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
