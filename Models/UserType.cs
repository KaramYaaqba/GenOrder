    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UserType
    {
        
        private bool aboutMePageField;
        
        private bool aboutMePageFieldSpecified;
        
        private string eIASTokenField;
        
        private string emailField;
        
        private int feedbackScoreField;
        
        private bool feedbackScoreFieldSpecified;
        
        private int uniqueNegativeFeedbackCountField;
        
        private bool uniqueNegativeFeedbackCountFieldSpecified;
        
        private int uniquePositiveFeedbackCountField;
        
        private bool uniquePositiveFeedbackCountFieldSpecified;
        
        private float positiveFeedbackPercentField;
        
        private bool positiveFeedbackPercentFieldSpecified;
        
        private bool feedbackPrivateField;
        
        private bool feedbackPrivateFieldSpecified;
        
        private FeedbackRatingStarCodeType feedbackRatingStarField;
        
        private bool feedbackRatingStarFieldSpecified;
        
        private bool iDVerifiedField;
        
        private bool iDVerifiedFieldSpecified;
        
        private bool eBayGoodStandingField;
        
        private bool eBayGoodStandingFieldSpecified;
        
        private bool newUserField;
        
        private bool newUserFieldSpecified;
        
        private AddressType registrationAddressField;
        
        private System.DateTime registrationDateField;
        
        private bool registrationDateFieldSpecified;
        
        private SiteCodeType siteField;
        
        private bool siteFieldSpecified;
        
        private UserStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private string userIDField;
        
        private bool userIDChangedField;
        
        private bool userIDChangedFieldSpecified;
        
        private System.DateTime userIDLastChangedField;
        
        private bool userIDLastChangedFieldSpecified;
        
        private VATStatusCodeType vATStatusField;
        
        private bool vATStatusFieldSpecified;
        
        private BuyerType buyerInfoField;
        
        private SellerType sellerInfoField;
        
        private BusinessRoleType businessRoleField;
        
        private bool businessRoleFieldSpecified;
        
        private CharityAffiliationsType charityAffiliationsField;
        
        private PayPalAccountLevelCodeType payPalAccountLevelField;
        
        private bool payPalAccountLevelFieldSpecified;
        
        private PayPalAccountTypeCodeType payPalAccountTypeField;
        
        private bool payPalAccountTypeFieldSpecified;
        
        private PayPalAccountStatusCodeType payPalAccountStatusField;
        
        private bool payPalAccountStatusFieldSpecified;
        
        private EBaySubscriptionTypeCodeType[] userSubscriptionField;
        
        private bool siteVerifiedField;
        
        private bool siteVerifiedFieldSpecified;
        
        private string[] skypeIDField;
        
        private bool eBayWikiReadOnlyField;
        
        private bool eBayWikiReadOnlyFieldSpecified;
        
        private int tUVLevelField;
        
        private bool tUVLevelFieldSpecified;
        
        private string vATIDField;
        
        private SellerPaymentMethodCodeType sellerPaymentMethodField;
        
        private bool sellerPaymentMethodFieldSpecified;
        
        private BiddingSummaryType biddingSummaryField;
        
        private bool userAnonymizedField;
        
        private bool userAnonymizedFieldSpecified;
        
        private int uniqueNeutralFeedbackCountField;
        
        private bool uniqueNeutralFeedbackCountFieldSpecified;
        
        private bool enterpriseSellerField;
        
        private bool enterpriseSellerFieldSpecified;
        
        private string billingEmailField;
        
        private bool qualifiesForSellingField;
        
        private bool qualifiesForSellingFieldSpecified;
        
        private string staticAliasField;
        
        private AddressType shippingAddressField;
        
        private MembershipDetailType[] membershipField;
        
        private string userFirstNameField;
        
        private string userLastNameField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AboutMePage
        {
            get
            {
                return this.aboutMePageField;
            }
            set
            {
                this.aboutMePageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AboutMePageSpecified
        {
            get
            {
                return this.aboutMePageFieldSpecified;
            }
            set
            {
                this.aboutMePageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EIASToken
        {
            get
            {
                return this.eIASTokenField;
            }
            set
            {
                this.eIASTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FeedbackScore
        {
            get
            {
                return this.feedbackScoreField;
            }
            set
            {
                this.feedbackScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackScoreSpecified
        {
            get
            {
                return this.feedbackScoreFieldSpecified;
            }
            set
            {
                this.feedbackScoreFieldSpecified = value;
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
        public float PositiveFeedbackPercent
        {
            get
            {
                return this.positiveFeedbackPercentField;
            }
            set
            {
                this.positiveFeedbackPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PositiveFeedbackPercentSpecified
        {
            get
            {
                return this.positiveFeedbackPercentFieldSpecified;
            }
            set
            {
                this.positiveFeedbackPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool FeedbackPrivate
        {
            get
            {
                return this.feedbackPrivateField;
            }
            set
            {
                this.feedbackPrivateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackPrivateSpecified
        {
            get
            {
                return this.feedbackPrivateFieldSpecified;
            }
            set
            {
                this.feedbackPrivateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackRatingStarCodeType FeedbackRatingStar
        {
            get
            {
                return this.feedbackRatingStarField;
            }
            set
            {
                this.feedbackRatingStarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackRatingStarSpecified
        {
            get
            {
                return this.feedbackRatingStarFieldSpecified;
            }
            set
            {
                this.feedbackRatingStarFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IDVerified
        {
            get
            {
                return this.iDVerifiedField;
            }
            set
            {
                this.iDVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDVerifiedSpecified
        {
            get
            {
                return this.iDVerifiedFieldSpecified;
            }
            set
            {
                this.iDVerifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool eBayGoodStanding
        {
            get
            {
                return this.eBayGoodStandingField;
            }
            set
            {
                this.eBayGoodStandingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eBayGoodStandingSpecified
        {
            get
            {
                return this.eBayGoodStandingFieldSpecified;
            }
            set
            {
                this.eBayGoodStandingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool NewUser
        {
            get
            {
                return this.newUserField;
            }
            set
            {
                this.newUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewUserSpecified
        {
            get
            {
                return this.newUserFieldSpecified;
            }
            set
            {
                this.newUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType RegistrationAddress
        {
            get
            {
                return this.registrationAddressField;
            }
            set
            {
                this.registrationAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RegistrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistrationDateSpecified
        {
            get
            {
                return this.registrationDateFieldSpecified;
            }
            set
            {
                this.registrationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SiteCodeType Site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteSpecified
        {
            get
            {
                return this.siteFieldSpecified;
            }
            set
            {
                this.siteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserStatusCodeType Status
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
        public bool UserIDChanged
        {
            get
            {
                return this.userIDChangedField;
            }
            set
            {
                this.userIDChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserIDChangedSpecified
        {
            get
            {
                return this.userIDChangedFieldSpecified;
            }
            set
            {
                this.userIDChangedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UserIDLastChanged
        {
            get
            {
                return this.userIDLastChangedField;
            }
            set
            {
                this.userIDLastChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserIDLastChangedSpecified
        {
            get
            {
                return this.userIDLastChangedFieldSpecified;
            }
            set
            {
                this.userIDLastChangedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VATStatusCodeType VATStatus
        {
            get
            {
                return this.vATStatusField;
            }
            set
            {
                this.vATStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VATStatusSpecified
        {
            get
            {
                return this.vATStatusFieldSpecified;
            }
            set
            {
                this.vATStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerType BuyerInfo
        {
            get
            {
                return this.buyerInfoField;
            }
            set
            {
                this.buyerInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerType SellerInfo
        {
            get
            {
                return this.sellerInfoField;
            }
            set
            {
                this.sellerInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BusinessRoleType BusinessRole
        {
            get
            {
                return this.businessRoleField;
            }
            set
            {
                this.businessRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BusinessRoleSpecified
        {
            get
            {
                return this.businessRoleFieldSpecified;
            }
            set
            {
                this.businessRoleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CharityAffiliationsType CharityAffiliations
        {
            get
            {
                return this.charityAffiliationsField;
            }
            set
            {
                this.charityAffiliationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PayPalAccountLevelCodeType PayPalAccountLevel
        {
            get
            {
                return this.payPalAccountLevelField;
            }
            set
            {
                this.payPalAccountLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalAccountLevelSpecified
        {
            get
            {
                return this.payPalAccountLevelFieldSpecified;
            }
            set
            {
                this.payPalAccountLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PayPalAccountTypeCodeType PayPalAccountType
        {
            get
            {
                return this.payPalAccountTypeField;
            }
            set
            {
                this.payPalAccountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalAccountTypeSpecified
        {
            get
            {
                return this.payPalAccountTypeFieldSpecified;
            }
            set
            {
                this.payPalAccountTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PayPalAccountStatusCodeType PayPalAccountStatus
        {
            get
            {
                return this.payPalAccountStatusField;
            }
            set
            {
                this.payPalAccountStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalAccountStatusSpecified
        {
            get
            {
                return this.payPalAccountStatusFieldSpecified;
            }
            set
            {
                this.payPalAccountStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserSubscription" )]
        public EBaySubscriptionTypeCodeType[] UserSubscription
        {
            get
            {
                return this.userSubscriptionField;
            }
            set
            {
                this.userSubscriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SiteVerified
        {
            get
            {
                return this.siteVerifiedField;
            }
            set
            {
                this.siteVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteVerifiedSpecified
        {
            get
            {
                return this.siteVerifiedFieldSpecified;
            }
            set
            {
                this.siteVerifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SkypeID" )]
        public string[] SkypeID
        {
            get
            {
                return this.skypeIDField;
            }
            set
            {
                this.skypeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool eBayWikiReadOnly
        {
            get
            {
                return this.eBayWikiReadOnlyField;
            }
            set
            {
                this.eBayWikiReadOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eBayWikiReadOnlySpecified
        {
            get
            {
                return this.eBayWikiReadOnlyFieldSpecified;
            }
            set
            {
                this.eBayWikiReadOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TUVLevel
        {
            get
            {
                return this.tUVLevelField;
            }
            set
            {
                this.tUVLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TUVLevelSpecified
        {
            get
            {
                return this.tUVLevelFieldSpecified;
            }
            set
            {
                this.tUVLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VATID
        {
            get
            {
                return this.vATIDField;
            }
            set
            {
                this.vATIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerPaymentMethodCodeType SellerPaymentMethod
        {
            get
            {
                return this.sellerPaymentMethodField;
            }
            set
            {
                this.sellerPaymentMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerPaymentMethodSpecified
        {
            get
            {
                return this.sellerPaymentMethodFieldSpecified;
            }
            set
            {
                this.sellerPaymentMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BiddingSummaryType BiddingSummary
        {
            get
            {
                return this.biddingSummaryField;
            }
            set
            {
                this.biddingSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UserAnonymized
        {
            get
            {
                return this.userAnonymizedField;
            }
            set
            {
                this.userAnonymizedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserAnonymizedSpecified
        {
            get
            {
                return this.userAnonymizedFieldSpecified;
            }
            set
            {
                this.userAnonymizedFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool EnterpriseSeller
        {
            get
            {
                return this.enterpriseSellerField;
            }
            set
            {
                this.enterpriseSellerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnterpriseSellerSpecified
        {
            get
            {
                return this.enterpriseSellerFieldSpecified;
            }
            set
            {
                this.enterpriseSellerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BillingEmail
        {
            get
            {
                return this.billingEmailField;
            }
            set
            {
                this.billingEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiesForSelling
        {
            get
            {
                return this.qualifiesForSellingField;
            }
            set
            {
                this.qualifiesForSellingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiesForSellingSpecified
        {
            get
            {
                return this.qualifiesForSellingFieldSpecified;
            }
            set
            {
                this.qualifiesForSellingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StaticAlias
        {
            get
            {
                return this.staticAliasField;
            }
            set
            {
                this.staticAliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AddressType ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Program", IsNullable=false)]
        public MembershipDetailType[] Membership
        {
            get
            {
                return this.membershipField;
            }
            set
            {
                this.membershipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserFirstName
        {
            get
            {
                return this.userFirstNameField;
            }
            set
            {
                this.userFirstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserLastName
        {
            get
            {
                return this.userLastNameField;
            }
            set
            {
                this.userLastNameField = value;
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
