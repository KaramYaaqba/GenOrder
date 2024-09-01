    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellerDashboardResponseType : AbstractResponseType
    {
        
        private SearchStandingDashboardType searchStandingField;
        
        private SellerFeeDiscountDashboardType sellerFeeDiscountField;
        
        private PowerSellerDashboardType powerSellerStatusField;
        
        private PolicyComplianceDashboardType policyComplianceField;
        
        private BuyerSatisfactionDashboardType buyerSatisfactionField;
        
        private SellerAccountDashboardType sellerAccountField;
        
        private PerformanceDashboardType[] performanceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SearchStandingDashboardType SearchStanding
        {
            get
            {
                return this.searchStandingField;
            }
            set
            {
                this.searchStandingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerFeeDiscountDashboardType SellerFeeDiscount
        {
            get
            {
                return this.sellerFeeDiscountField;
            }
            set
            {
                this.sellerFeeDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PowerSellerDashboardType PowerSellerStatus
        {
            get
            {
                return this.powerSellerStatusField;
            }
            set
            {
                this.powerSellerStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PolicyComplianceDashboardType PolicyCompliance
        {
            get
            {
                return this.policyComplianceField;
            }
            set
            {
                this.policyComplianceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyerSatisfactionDashboardType BuyerSatisfaction
        {
            get
            {
                return this.buyerSatisfactionField;
            }
            set
            {
                this.buyerSatisfactionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerAccountDashboardType SellerAccount
        {
            get
            {
                return this.sellerAccountField;
            }
            set
            {
                this.sellerAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Performance" )]
        public PerformanceDashboardType[] Performance
        {
            get
            {
                return this.performanceField;
            }
            set
            {
                this.performanceField = value;
            }
        }
    }
