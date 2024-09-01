    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TaxDetailsType
    {
        
        private TaxTypeCodeType impositionField;
        
        private bool impositionFieldSpecified;
        
        private TaxDescriptionCodeType taxDescriptionField;
        
        private bool taxDescriptionFieldSpecified;
        
        private AmountType taxAmountField;
        
        private AmountType taxOnSubtotalAmountField;
        
        private AmountType taxOnShippingAmountField;
        
        private AmountType taxOnHandlingAmountField;
        
        private string taxCodeField;
        
        private CollectionMethodCodeType collectionMethodField;
        
        private bool collectionMethodFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TaxTypeCodeType Imposition
        {
            get
            {
                return this.impositionField;
            }
            set
            {
                this.impositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpositionSpecified
        {
            get
            {
                return this.impositionFieldSpecified;
            }
            set
            {
                this.impositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TaxDescriptionCodeType TaxDescription
        {
            get
            {
                return this.taxDescriptionField;
            }
            set
            {
                this.taxDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxDescriptionSpecified
        {
            get
            {
                return this.taxDescriptionFieldSpecified;
            }
            set
            {
                this.taxDescriptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TaxOnSubtotalAmount
        {
            get
            {
                return this.taxOnSubtotalAmountField;
            }
            set
            {
                this.taxOnSubtotalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TaxOnShippingAmount
        {
            get
            {
                return this.taxOnShippingAmountField;
            }
            set
            {
                this.taxOnShippingAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType TaxOnHandlingAmount
        {
            get
            {
                return this.taxOnHandlingAmountField;
            }
            set
            {
                this.taxOnHandlingAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CollectionMethodCodeType CollectionMethod
        {
            get
            {
                return this.collectionMethodField;
            }
            set
            {
                this.collectionMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectionMethodSpecified
        {
            get
            {
                return this.collectionMethodFieldSpecified;
            }
            set
            {
                this.collectionMethodFieldSpecified = value;
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
