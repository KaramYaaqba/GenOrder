    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PromotedItemType
    {
        
        private string itemIDField;
        
        private string pictureURLField;
        
        private int positionField;
        
        private bool positionFieldSpecified;
        
        private PromotionItemSelectionCodeType selectionTypeField;
        
        private bool selectionTypeFieldSpecified;
        
        private string titleField;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private PromotionDetailsType[] promotionDetailsField;
        
        private string timeLeftField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public string PictureURL
        {
            get
            {
                return this.pictureURLField;
            }
            set
            {
                this.pictureURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PositionSpecified
        {
            get
            {
                return this.positionFieldSpecified;
            }
            set
            {
                this.positionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionItemSelectionCodeType SelectionType
        {
            get
            {
                return this.selectionTypeField;
            }
            set
            {
                this.selectionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectionTypeSpecified
        {
            get
            {
                return this.selectionTypeFieldSpecified;
            }
            set
            {
                this.selectionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingTypeCodeType ListingType
        {
            get
            {
                return this.listingTypeField;
            }
            set
            {
                this.listingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingTypeSpecified
        {
            get
            {
                return this.listingTypeFieldSpecified;
            }
            set
            {
                this.listingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionDetails" )]
        public PromotionDetailsType[] PromotionDetails
        {
            get
            {
                return this.promotionDetailsField;
            }
            set
            {
                this.promotionDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration" )]
        public string TimeLeft
        {
            get
            {
                return this.timeLeftField;
            }
            set
            {
                this.timeLeftField = value;
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
