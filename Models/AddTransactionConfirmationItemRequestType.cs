    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddTransactionConfirmationItemRequestType : AbstractRequestType
    {
        
        private string recipientUserIDField;
        
        private string verifyEligibilityOnlyField;
        
        private string recipientPostalCodeField;
        
        private RecipientRelationCodeType recipientRelationTypeField;
        
        private AmountType negotiatedPriceField;
        
        private SecondChanceOfferDurationCodeType listingDurationField;
        
        private string itemIDField;
        
        private string commentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RecipientUserID
        {
            get
            {
                return this.recipientUserIDField;
            }
            set
            {
                this.recipientUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VerifyEligibilityOnly
        {
            get
            {
                return this.verifyEligibilityOnlyField;
            }
            set
            {
                this.verifyEligibilityOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RecipientPostalCode
        {
            get
            {
                return this.recipientPostalCodeField;
            }
            set
            {
                this.recipientPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RecipientRelationCodeType RecipientRelationType
        {
            get
            {
                return this.recipientRelationTypeField;
            }
            set
            {
                this.recipientRelationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType NegotiatedPrice
        {
            get
            {
                return this.negotiatedPriceField;
            }
            set
            {
                this.negotiatedPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SecondChanceOfferDurationCodeType ListingDuration
        {
            get
            {
                return this.listingDurationField;
            }
            set
            {
                this.listingDurationField = value;
            }
        }
        
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
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }
