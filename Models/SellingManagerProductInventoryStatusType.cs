    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerProductInventoryStatusType
    {
        
        private int quantityScheduledField;
        
        private bool quantityScheduledFieldSpecified;
        
        private int quantityActiveField;
        
        private bool quantityActiveFieldSpecified;
        
        private int quantitySoldField;
        
        private bool quantitySoldFieldSpecified;
        
        private int quantityUnsoldField;
        
        private bool quantityUnsoldFieldSpecified;
        
        private float successPercentField;
        
        private bool successPercentFieldSpecified;
        
        private AmountType averageSellingPriceField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityScheduled
        {
            get
            {
                return this.quantityScheduledField;
            }
            set
            {
                this.quantityScheduledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityScheduledSpecified
        {
            get
            {
                return this.quantityScheduledFieldSpecified;
            }
            set
            {
                this.quantityScheduledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityActive
        {
            get
            {
                return this.quantityActiveField;
            }
            set
            {
                this.quantityActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityActiveSpecified
        {
            get
            {
                return this.quantityActiveFieldSpecified;
            }
            set
            {
                this.quantityActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantitySold
        {
            get
            {
                return this.quantitySoldField;
            }
            set
            {
                this.quantitySoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySoldSpecified
        {
            get
            {
                return this.quantitySoldFieldSpecified;
            }
            set
            {
                this.quantitySoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityUnsold
        {
            get
            {
                return this.quantityUnsoldField;
            }
            set
            {
                this.quantityUnsoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityUnsoldSpecified
        {
            get
            {
                return this.quantityUnsoldFieldSpecified;
            }
            set
            {
                this.quantityUnsoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float SuccessPercent
        {
            get
            {
                return this.successPercentField;
            }
            set
            {
                this.successPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuccessPercentSpecified
        {
            get
            {
                return this.successPercentFieldSpecified;
            }
            set
            {
                this.successPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType AverageSellingPrice
        {
            get
            {
                return this.averageSellingPriceField;
            }
            set
            {
                this.averageSellingPriceField = value;
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
