    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategoriesResponseType : AbstractResponseType
    {
        
        private CategoryType[] categoryArrayField;
        
        private int categoryCountField;
        
        private bool categoryCountFieldSpecified;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private string categoryVersionField;
        
        private bool reservePriceAllowedField;
        
        private bool reservePriceAllowedFieldSpecified;
        
        private double minimumReservePriceField;
        
        private bool minimumReservePriceFieldSpecified;
        
        private bool reduceReserveAllowedField;
        
        private bool reduceReserveAllowedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable=false)]
        public CategoryType[] CategoryArray
        {
            get
            {
                return this.categoryArrayField;
            }
            set
            {
                this.categoryArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CategoryCount
        {
            get
            {
                return this.categoryCountField;
            }
            set
            {
                this.categoryCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryCountSpecified
        {
            get
            {
                return this.categoryCountFieldSpecified;
            }
            set
            {
                this.categoryCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryVersion
        {
            get
            {
                return this.categoryVersionField;
            }
            set
            {
                this.categoryVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReservePriceAllowed
        {
            get
            {
                return this.reservePriceAllowedField;
            }
            set
            {
                this.reservePriceAllowedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReservePriceAllowedSpecified
        {
            get
            {
                return this.reservePriceAllowedFieldSpecified;
            }
            set
            {
                this.reservePriceAllowedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public double MinimumReservePrice
        {
            get
            {
                return this.minimumReservePriceField;
            }
            set
            {
                this.minimumReservePriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumReservePriceSpecified
        {
            get
            {
                return this.minimumReservePriceFieldSpecified;
            }
            set
            {
                this.minimumReservePriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReduceReserveAllowed
        {
            get
            {
                return this.reduceReserveAllowedField;
            }
            set
            {
                this.reduceReserveAllowedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReduceReserveAllowedSpecified
        {
            get
            {
                return this.reduceReserveAllowedFieldSpecified;
            }
            set
            {
                this.reduceReserveAllowedFieldSpecified = value;
            }
        }
    }
