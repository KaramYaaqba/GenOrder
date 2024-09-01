    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PromotionalSaleType
    {
        
        private long promotionalSaleIDField;
        
        private bool promotionalSaleIDFieldSpecified;
        
        private string promotionalSaleNameField;
        
        private ItemIDArrayType promotionalSaleItemIDArrayField;
        
        private PromotionalSaleStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private DiscountCodeType discountTypeField;
        
        private bool discountTypeFieldSpecified;
        
        private double discountValueField;
        
        private bool discountValueFieldSpecified;
        
        private System.DateTime promotionalSaleStartTimeField;
        
        private bool promotionalSaleStartTimeFieldSpecified;
        
        private System.DateTime promotionalSaleEndTimeField;
        
        private bool promotionalSaleEndTimeFieldSpecified;
        
        private PromotionalSaleTypeCodeType promotionalSaleType1Field;
        
        private bool promotionalSaleType1FieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PromotionalSaleID
        {
            get
            {
                return this.promotionalSaleIDField;
            }
            set
            {
                this.promotionalSaleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleIDSpecified
        {
            get
            {
                return this.promotionalSaleIDFieldSpecified;
            }
            set
            {
                this.promotionalSaleIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PromotionalSaleName
        {
            get
            {
                return this.promotionalSaleNameField;
            }
            set
            {
                this.promotionalSaleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemIDArrayType PromotionalSaleItemIDArray
        {
            get
            {
                return this.promotionalSaleItemIDArrayField;
            }
            set
            {
                this.promotionalSaleItemIDArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalSaleStatusCodeType Status
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
        public DiscountCodeType DiscountType
        {
            get
            {
                return this.discountTypeField;
            }
            set
            {
                this.discountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountTypeSpecified
        {
            get
            {
                return this.discountTypeFieldSpecified;
            }
            set
            {
                this.discountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public double DiscountValue
        {
            get
            {
                return this.discountValueField;
            }
            set
            {
                this.discountValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountValueSpecified
        {
            get
            {
                return this.discountValueFieldSpecified;
            }
            set
            {
                this.discountValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PromotionalSaleStartTime
        {
            get
            {
                return this.promotionalSaleStartTimeField;
            }
            set
            {
                this.promotionalSaleStartTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleStartTimeSpecified
        {
            get
            {
                return this.promotionalSaleStartTimeFieldSpecified;
            }
            set
            {
                this.promotionalSaleStartTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PromotionalSaleEndTime
        {
            get
            {
                return this.promotionalSaleEndTimeField;
            }
            set
            {
                this.promotionalSaleEndTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleEndTimeSpecified
        {
            get
            {
                return this.promotionalSaleEndTimeFieldSpecified;
            }
            set
            {
                this.promotionalSaleEndTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalSaleType" )]
        public PromotionalSaleTypeCodeType PromotionalSaleType1
        {
            get
            {
                return this.promotionalSaleType1Field;
            }
            set
            {
                this.promotionalSaleType1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleType1Specified
        {
            get
            {
                return this.promotionalSaleType1FieldSpecified;
            }
            set
            {
                this.promotionalSaleType1FieldSpecified = value;
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
