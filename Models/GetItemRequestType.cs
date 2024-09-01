    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private bool includeWatchCountField;
        
        private bool includeWatchCountFieldSpecified;
        
        private bool includeCrossPromotionField;
        
        private bool includeCrossPromotionFieldSpecified;
        
        private bool includeItemSpecificsField;
        
        private bool includeItemSpecificsFieldSpecified;
        
        private bool includeTaxTableField;
        
        private bool includeTaxTableFieldSpecified;
        
        private string sKUField;
        
        private string variationSKUField;
        
        private NameValueListType[] variationSpecificsField;
        
        private string transactionIDField;
        
        private bool includeItemCompatibilityListField;
        
        private bool includeItemCompatibilityListFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeWatchCount
        {
            get
            {
                return this.includeWatchCountField;
            }
            set
            {
                this.includeWatchCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeWatchCountSpecified
        {
            get
            {
                return this.includeWatchCountFieldSpecified;
            }
            set
            {
                this.includeWatchCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeCrossPromotion
        {
            get
            {
                return this.includeCrossPromotionField;
            }
            set
            {
                this.includeCrossPromotionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeCrossPromotionSpecified
        {
            get
            {
                return this.includeCrossPromotionFieldSpecified;
            }
            set
            {
                this.includeCrossPromotionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeItemSpecifics
        {
            get
            {
                return this.includeItemSpecificsField;
            }
            set
            {
                this.includeItemSpecificsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeItemSpecificsSpecified
        {
            get
            {
                return this.includeItemSpecificsFieldSpecified;
            }
            set
            {
                this.includeItemSpecificsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeTaxTable
        {
            get
            {
                return this.includeTaxTableField;
            }
            set
            {
                this.includeTaxTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeTaxTableSpecified
        {
            get
            {
                return this.includeTaxTableFieldSpecified;
            }
            set
            {
                this.includeTaxTableFieldSpecified = value;
            }
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
        public string VariationSKU
        {
            get
            {
                return this.variationSKUField;
            }
            set
            {
                this.variationSKUField = value;
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
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeItemCompatibilityList
        {
            get
            {
                return this.includeItemCompatibilityListField;
            }
            set
            {
                this.includeItemCompatibilityListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeItemCompatibilityListSpecified
        {
            get
            {
                return this.includeItemCompatibilityListFieldSpecified;
            }
            set
            {
                this.includeItemCompatibilityListFieldSpecified = value;
            }
        }
    }
