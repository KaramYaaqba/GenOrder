    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellerListRequestType : AbstractRequestType
    {
        
        private string userIDField;
        
        private UserIDArrayType motorsDealerUsersField;
        
        private System.DateTime endTimeFromField;
        
        private bool endTimeFromFieldSpecified;
        
        private System.DateTime endTimeToField;
        
        private bool endTimeToFieldSpecified;
        
        private int sortField;
        
        private bool sortFieldSpecified;
        
        private System.DateTime startTimeFromField;
        
        private bool startTimeFromFieldSpecified;
        
        private System.DateTime startTimeToField;
        
        private bool startTimeToFieldSpecified;
        
        private PaginationType paginationField;
        
        private GranularityLevelCodeType granularityLevelField;
        
        private bool granularityLevelFieldSpecified;
        
        private string[] sKUArrayField;
        
        private bool includeWatchCountField;
        
        private bool includeWatchCountFieldSpecified;
        
        private bool adminEndedItemsOnlyField;
        
        private bool adminEndedItemsOnlyFieldSpecified;
        
        private int categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private bool includeVariationsField;
        
        private bool includeVariationsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserIDArrayType MotorsDealerUsers
        {
            get
            {
                return this.motorsDealerUsersField;
            }
            set
            {
                this.motorsDealerUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeFrom
        {
            get
            {
                return this.endTimeFromField;
            }
            set
            {
                this.endTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeFromSpecified
        {
            get
            {
                return this.endTimeFromFieldSpecified;
            }
            set
            {
                this.endTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeTo
        {
            get
            {
                return this.endTimeToField;
            }
            set
            {
                this.endTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeToSpecified
        {
            get
            {
                return this.endTimeToFieldSpecified;
            }
            set
            {
                this.endTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Sort
        {
            get
            {
                return this.sortField;
            }
            set
            {
                this.sortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortSpecified
        {
            get
            {
                return this.sortFieldSpecified;
            }
            set
            {
                this.sortFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartTimeFrom
        {
            get
            {
                return this.startTimeFromField;
            }
            set
            {
                this.startTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeFromSpecified
        {
            get
            {
                return this.startTimeFromFieldSpecified;
            }
            set
            {
                this.startTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartTimeTo
        {
            get
            {
                return this.startTimeToField;
            }
            set
            {
                this.startTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeToSpecified
        {
            get
            {
                return this.startTimeToFieldSpecified;
            }
            set
            {
                this.startTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GranularityLevelCodeType GranularityLevel
        {
            get
            {
                return this.granularityLevelField;
            }
            set
            {
                this.granularityLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GranularityLevelSpecified
        {
            get
            {
                return this.granularityLevelFieldSpecified;
            }
            set
            {
                this.granularityLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("SKU", IsNullable=false)]
        public string[] SKUArray
        {
            get
            {
                return this.sKUArrayField;
            }
            set
            {
                this.sKUArrayField = value;
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
        public bool AdminEndedItemsOnly
        {
            get
            {
                return this.adminEndedItemsOnlyField;
            }
            set
            {
                this.adminEndedItemsOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdminEndedItemsOnlySpecified
        {
            get
            {
                return this.adminEndedItemsOnlyFieldSpecified;
            }
            set
            {
                this.adminEndedItemsOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryIDSpecified
        {
            get
            {
                return this.categoryIDFieldSpecified;
            }
            set
            {
                this.categoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeVariations
        {
            get
            {
                return this.includeVariationsField;
            }
            set
            {
                this.includeVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeVariationsSpecified
        {
            get
            {
                return this.includeVariationsFieldSpecified;
            }
            set
            {
                this.includeVariationsFieldSpecified = value;
            }
        }
    }
