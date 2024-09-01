    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBaySellingResponseType : AbstractResponseType
    {
        
        private SellingSummaryType sellingSummaryField;
        
        private PaginatedItemArrayType scheduledListField;
        
        private PaginatedItemArrayType activeListField;
        
        private PaginatedOrderTransactionArrayType soldListField;
        
        private PaginatedItemArrayType unsoldListField;
        
        private MyeBaySellingSummaryType summaryField;
        
        private PaginatedItemArrayType bidListField;
        
        private PaginatedOrderTransactionArrayType deletedFromSoldListField;
        
        private PaginatedItemArrayType deletedFromUnsoldListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingSummaryType SellingSummary
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
        public PaginatedItemArrayType ScheduledList
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
        public PaginatedItemArrayType ActiveList
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
        public PaginatedOrderTransactionArrayType SoldList
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
        public PaginatedItemArrayType UnsoldList
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
        public MyeBaySellingSummaryType Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType BidList
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
        public PaginatedOrderTransactionArrayType DeletedFromSoldList
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
        public PaginatedItemArrayType DeletedFromUnsoldList
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
    }
