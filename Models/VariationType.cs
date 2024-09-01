    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VariationType
    {
        
        private string sKUField;
        
        private AmountType startPriceField;
        
        private int quantityField;
        
        private bool quantityFieldSpecified;
        
        private NameValueListType[] variationSpecificsField;
        
        private int unitsAvailableField;
        
        private bool unitsAvailableFieldSpecified;
        
        private AmountType unitCostField;
        
        private SellingStatusType sellingStatusField;
        
        private string variationTitleField;
        
        private string variationViewItemURLField;
        
        private bool deleteField;
        
        private SellingManagerProductInventoryStatusType sellingManagerProductInventoryStatusField;
        
        private long watchCountField;
        
        private bool watchCountFieldSpecified;
        
        private string privateNotesField;
        
        private DiscountPriceInfoType discountPriceInfoField;
        
        private VariationProductListingDetailsType variationProductListingDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        public VariationType()
        {
            this.deleteField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType StartPrice
        {
            get
            {
                return this.startPriceField;
            }
            set
            {
                this.startPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NameValueList", IsNullable=false)]
        public NameValueListType[] VariationSpecifics
        {
            get
            {
                return this.variationSpecificsField;
            }
            set
            {
                this.variationSpecificsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int UnitsAvailable
        {
            get
            {
                return this.unitsAvailableField;
            }
            set
            {
                this.unitsAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitsAvailableSpecified
        {
            get
            {
                return this.unitsAvailableFieldSpecified;
            }
            set
            {
                this.unitsAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType UnitCost
        {
            get
            {
                return this.unitCostField;
            }
            set
            {
                this.unitCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingStatusType SellingStatus
        {
            get
            {
                return this.sellingStatusField;
            }
            set
            {
                this.sellingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VariationTitle
        {
            get
            {
                return this.variationTitleField;
            }
            set
            {
                this.variationTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string VariationViewItemURL
        {
            get
            {
                return this.variationViewItemURLField;
            }
            set
            {
                this.variationViewItemURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductInventoryStatusType SellingManagerProductInventoryStatus
        {
            get
            {
                return this.sellingManagerProductInventoryStatusField;
            }
            set
            {
                this.sellingManagerProductInventoryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long WatchCount
        {
            get
            {
                return this.watchCountField;
            }
            set
            {
                this.watchCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WatchCountSpecified
        {
            get
            {
                return this.watchCountFieldSpecified;
            }
            set
            {
                this.watchCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PrivateNotes
        {
            get
            {
                return this.privateNotesField;
            }
            set
            {
                this.privateNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DiscountPriceInfoType DiscountPriceInfo
        {
            get
            {
                return this.discountPriceInfoField;
            }
            set
            {
                this.discountPriceInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationProductListingDetailsType VariationProductListingDetails
        {
            get
            {
                return this.variationProductListingDetailsField;
            }
            set
            {
                this.variationProductListingDetailsField = value;
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
