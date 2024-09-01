    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBaySellingRequestType : AbstractRequestType
    {
        
        private ItemListCustomizationType scheduledListField;
        
        private ItemListCustomizationType activeListField;
        
        private ItemListCustomizationType soldListField;
        
        private ItemListCustomizationType unsoldListField;
        
        private ItemListCustomizationType bidListField;
        
        private ItemListCustomizationType deletedFromSoldListField;
        
        private ItemListCustomizationType deletedFromUnsoldListField;
        
        private ItemListCustomizationType sellingSummaryField;
        
        private bool hideVariationsField;
        
        private bool hideVariationsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType ScheduledList
        {
            get
            {
                return this.scheduledListField;
            }
            set
            {
                this.scheduledListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType ActiveList
        {
            get
            {
                return this.activeListField;
            }
            set
            {
                this.activeListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType SoldList
        {
            get
            {
                return this.soldListField;
            }
            set
            {
                this.soldListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType UnsoldList
        {
            get
            {
                return this.unsoldListField;
            }
            set
            {
                this.unsoldListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType BidList
        {
            get
            {
                return this.bidListField;
            }
            set
            {
                this.bidListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType DeletedFromSoldList
        {
            get
            {
                return this.deletedFromSoldListField;
            }
            set
            {
                this.deletedFromSoldListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType DeletedFromUnsoldList
        {
            get
            {
                return this.deletedFromUnsoldListField;
            }
            set
            {
                this.deletedFromUnsoldListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType SellingSummary
        {
            get
            {
                return this.sellingSummaryField;
            }
            set
            {
                this.sellingSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HideVariations
        {
            get
            {
                return this.hideVariationsField;
            }
            set
            {
                this.hideVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HideVariationsSpecified
        {
            get
            {
                return this.hideVariationsFieldSpecified;
            }
            set
            {
                this.hideVariationsFieldSpecified = value;
            }
        }
    }
