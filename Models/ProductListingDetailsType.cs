    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ProductListingDetailsType
    {
        
        private bool includeStockPhotoURLField;
        
        private bool includeStockPhotoURLFieldSpecified;
        
        private bool useStockPhotoURLAsGalleryField;
        
        private bool useStockPhotoURLAsGalleryFieldSpecified;
        
        private string stockPhotoURLField;
        
        private string[] copyrightField;
        
        private string productReferenceIDField;
        
        private string detailsURLField;
        
        private string productDetailsURLField;
        
        private bool returnSearchResultOnDuplicatesField;
        
        private bool returnSearchResultOnDuplicatesFieldSpecified;
        
        private string iSBNField;
        
        private string uPCField;
        
        private string eANField;
        
        private BrandMPNType brandMPNField;
        
        private TicketListingDetailsType ticketListingDetailsField;
        
        private bool useFirstProductField;
        
        private bool useFirstProductFieldSpecified;
        
        private bool includeeBayProductDetailsField;
        
        private bool includeeBayProductDetailsFieldSpecified;
        
        private NameValueListType[] nameValueListField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeStockPhotoURL
        {
            get
            {
                return this.includeStockPhotoURLField;
            }
            set
            {
                this.includeStockPhotoURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeStockPhotoURLSpecified
        {
            get
            {
                return this.includeStockPhotoURLFieldSpecified;
            }
            set
            {
                this.includeStockPhotoURLFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UseStockPhotoURLAsGallery
        {
            get
            {
                return this.useStockPhotoURLAsGalleryField;
            }
            set
            {
                this.useStockPhotoURLAsGalleryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseStockPhotoURLAsGallerySpecified
        {
            get
            {
                return this.useStockPhotoURLAsGalleryFieldSpecified;
            }
            set
            {
                this.useStockPhotoURLAsGalleryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string StockPhotoURL
        {
            get
            {
                return this.stockPhotoURLField;
            }
            set
            {
                this.stockPhotoURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Copyright" )]
        public string[] Copyright
        {
            get
            {
                return this.copyrightField;
            }
            set
            {
                this.copyrightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProductReferenceID
        {
            get
            {
                return this.productReferenceIDField;
            }
            set
            {
                this.productReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string DetailsURL
        {
            get
            {
                return this.detailsURLField;
            }
            set
            {
                this.detailsURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string ProductDetailsURL
        {
            get
            {
                return this.productDetailsURLField;
            }
            set
            {
                this.productDetailsURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReturnSearchResultOnDuplicates
        {
            get
            {
                return this.returnSearchResultOnDuplicatesField;
            }
            set
            {
                this.returnSearchResultOnDuplicatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnSearchResultOnDuplicatesSpecified
        {
            get
            {
                return this.returnSearchResultOnDuplicatesFieldSpecified;
            }
            set
            {
                this.returnSearchResultOnDuplicatesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ISBN
        {
            get
            {
                return this.iSBNField;
            }
            set
            {
                this.iSBNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UPC
        {
            get
            {
                return this.uPCField;
            }
            set
            {
                this.uPCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EAN
        {
            get
            {
                return this.eANField;
            }
            set
            {
                this.eANField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BrandMPNType BrandMPN
        {
            get
            {
                return this.brandMPNField;
            }
            set
            {
                this.brandMPNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TicketListingDetailsType TicketListingDetails
        {
            get
            {
                return this.ticketListingDetailsField;
            }
            set
            {
                this.ticketListingDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UseFirstProduct
        {
            get
            {
                return this.useFirstProductField;
            }
            set
            {
                this.useFirstProductField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseFirstProductSpecified
        {
            get
            {
                return this.useFirstProductFieldSpecified;
            }
            set
            {
                this.useFirstProductFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeeBayProductDetails
        {
            get
            {
                return this.includeeBayProductDetailsField;
            }
            set
            {
                this.includeeBayProductDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeeBayProductDetailsSpecified
        {
            get
            {
                return this.includeeBayProductDetailsFieldSpecified;
            }
            set
            {
                this.includeeBayProductDetailsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameValueList" )]
        public NameValueListType[] NameValueList
        {
            get
            {
                return this.nameValueListField;
            }
            set
            {
                this.nameValueListField = value;
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
