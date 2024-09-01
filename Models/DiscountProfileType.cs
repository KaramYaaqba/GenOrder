    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DiscountProfileType
    {
        
        private string discountProfileIDField;
        
        private string discountProfileNameField;
        
        private AmountType eachAdditionalAmountField;
        
        private AmountType eachAdditionalAmountOffField;
        
        private float eachAdditionalPercentOffField;
        
        private bool eachAdditionalPercentOffFieldSpecified;
        
        private MeasureType weightOffField;
        
        private string mappedDiscountProfileIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DiscountProfileID
        {
            get
            {
                return this.discountProfileIDField;
            }
            set
            {
                this.discountProfileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DiscountProfileName
        {
            get
            {
                return this.discountProfileNameField;
            }
            set
            {
                this.discountProfileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType EachAdditionalAmount
        {
            get
            {
                return this.eachAdditionalAmountField;
            }
            set
            {
                this.eachAdditionalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType EachAdditionalAmountOff
        {
            get
            {
                return this.eachAdditionalAmountOffField;
            }
            set
            {
                this.eachAdditionalAmountOffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float EachAdditionalPercentOff
        {
            get
            {
                return this.eachAdditionalPercentOffField;
            }
            set
            {
                this.eachAdditionalPercentOffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EachAdditionalPercentOffSpecified
        {
            get
            {
                return this.eachAdditionalPercentOffFieldSpecified;
            }
            set
            {
                this.eachAdditionalPercentOffFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasureType WeightOff
        {
            get
            {
                return this.weightOffField;
            }
            set
            {
                this.weightOffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MappedDiscountProfileID
        {
            get
            {
                return this.mappedDiscountProfileIDField;
            }
            set
            {
                this.mappedDiscountProfileIDField = value;
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
