    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FeedbackSummaryType
    {
        
        private FeedbackPeriodType[] bidRetractionFeedbackPeriodArrayField;
        
        private FeedbackPeriodType[] negativeFeedbackPeriodArrayField;
        
        private FeedbackPeriodType[] neutralFeedbackPeriodArrayField;
        
        private FeedbackPeriodType[] positiveFeedbackPeriodArrayField;
        
        private FeedbackPeriodType[] totalFeedbackPeriodArrayField;
        
        private int neutralCommentCountFromSuspendedUsersField;
        
        private bool neutralCommentCountFromSuspendedUsersFieldSpecified;
        
        private int uniqueNegativeFeedbackCountField;
        
        private bool uniqueNegativeFeedbackCountFieldSpecified;
        
        private int uniquePositiveFeedbackCountField;
        
        private bool uniquePositiveFeedbackCountFieldSpecified;
        
        private int uniqueNeutralFeedbackCountField;
        
        private bool uniqueNeutralFeedbackCountFieldSpecified;
        
        private AverageRatingSummaryType[] sellerRatingSummaryArrayField;
        
        private SellerRoleMetricsType sellerRoleMetricsField;
        
        private BuyerRoleMetricsType buyerRoleMetricsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackPeriod", IsNullable=false)]
        public FeedbackPeriodType[] BidRetractionFeedbackPeriodArray
        {
            get
            {
                return this.bidRetractionFeedbackPeriodArrayField;
            }
            set
            {
                this.bidRetractionFeedbackPeriodArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackPeriod", IsNullable=false)]
        public FeedbackPeriodType[] NegativeFeedbackPeriodArray
        {
            get
            {
                return this.negativeFeedbackPeriodArrayField;
            }
            set
            {
                this.negativeFeedbackPeriodArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackPeriod", IsNullable=false)]
        public FeedbackPeriodType[] NeutralFeedbackPeriodArray
        {
            get
            {
                return this.neutralFeedbackPeriodArrayField;
            }
            set
            {
                this.neutralFeedbackPeriodArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackPeriod", IsNullable=false)]
        public FeedbackPeriodType[] PositiveFeedbackPeriodArray
        {
            get
            {
                return this.positiveFeedbackPeriodArrayField;
            }
            set
            {
                this.positiveFeedbackPeriodArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("FeedbackPeriod", IsNullable=false)]
        public FeedbackPeriodType[] TotalFeedbackPeriodArray
        {
            get
            {
                return this.totalFeedbackPeriodArrayField;
            }
            set
            {
                this.totalFeedbackPeriodArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NeutralCommentCountFromSuspendedUsers
        {
            get
            {
                return this.neutralCommentCountFromSuspendedUsersField;
            }
            set
            {
                this.neutralCommentCountFromSuspendedUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NeutralCommentCountFromSuspendedUsersSpecified
        {
            get
            {
                return this.neutralCommentCountFromSuspendedUsersFieldSpecified;
            }
            set
            {
                this.neutralCommentCountFromSuspendedUsersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int UniqueNegativeFeedbackCount
        {
            get
            {
                return this.uniqueNegativeFeedbackCountField;
            }
            set
            {
                this.uniqueNegativeFeedbackCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueNegativeFeedbackCountSpecified
        {
            get
            {
                return this.uniqueNegativeFeedbackCountFieldSpecified;
            }
            set
            {
                this.uniqueNegativeFeedbackCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int UniquePositiveFeedbackCount
        {
            get
            {
                return this.uniquePositiveFeedbackCountField;
            }
            set
            {
                this.uniquePositiveFeedbackCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniquePositiveFeedbackCountSpecified
        {
            get
            {
                return this.uniquePositiveFeedbackCountFieldSpecified;
            }
            set
            {
                this.uniquePositiveFeedbackCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int UniqueNeutralFeedbackCount
        {
            get
            {
                return this.uniqueNeutralFeedbackCountField;
            }
            set
            {
                this.uniqueNeutralFeedbackCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueNeutralFeedbackCountSpecified
        {
            get
            {
                return this.uniqueNeutralFeedbackCountFieldSpecified;
            }
            set
            {
                this.uniqueNeutralFeedbackCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("AverageRatingSummary", IsNullable=false)]
        public AverageRatingSummaryType[] SellerRatingSummaryArray
        {
            get
            {
                return this.sellerRatingSummaryArrayField;
            }
            set
            {
                this.sellerRatingSummaryArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerRoleMetricsType SellerRoleMetrics
        {
            get
            {
                return this.sellerRoleMetricsField;
            }
            set
            {
                this.sellerRoleMetricsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerRoleMetricsType BuyerRoleMetrics
        {
            get
            {
                return this.buyerRoleMetricsField;
            }
            set
            {
                this.buyerRoleMetricsField = value;
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
