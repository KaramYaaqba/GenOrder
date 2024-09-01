    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class LeaveFeedbackRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string commentTextField;
        
        private CommentTypeCodeType commentTypeField;
        
        private bool commentTypeFieldSpecified;
        
        private string transactionIDField;
        
        private string targetUserField;
        
        private ItemRatingDetailsType[] sellerItemRatingDetailArrayField;
        
        private string orderLineItemIDField;
        
        private ItemArrivedWithinEDDCodeType itemArrivedWithinEDDTypeField;
        
        private bool itemArrivedWithinEDDTypeFieldSpecified;
        
        private bool itemDeliveredWithinEDDField;
        
        private bool itemDeliveredWithinEDDFieldSpecified;
        
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
        public string CommentText
        {
            get
            {
                return this.commentTextField;
            }
            set
            {
                this.commentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CommentTypeCodeType CommentType
        {
            get
            {
                return this.commentTypeField;
            }
            set
            {
                this.commentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommentTypeSpecified
        {
            get
            {
                return this.commentTypeFieldSpecified;
            }
            set
            {
                this.commentTypeFieldSpecified = value;
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
        public string TargetUser
        {
            get
            {
                return this.targetUserField;
            }
            set
            {
                this.targetUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ItemRatingDetails", IsNullable=false)]
        public ItemRatingDetailsType[] SellerItemRatingDetailArray
        {
            get
            {
                return this.sellerItemRatingDetailArrayField;
            }
            set
            {
                this.sellerItemRatingDetailArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderLineItemID
        {
            get
            {
                return this.orderLineItemIDField;
            }
            set
            {
                this.orderLineItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemArrivedWithinEDDCodeType ItemArrivedWithinEDDType
        {
            get
            {
                return this.itemArrivedWithinEDDTypeField;
            }
            set
            {
                this.itemArrivedWithinEDDTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemArrivedWithinEDDTypeSpecified
        {
            get
            {
                return this.itemArrivedWithinEDDTypeFieldSpecified;
            }
            set
            {
                this.itemArrivedWithinEDDTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ItemDeliveredWithinEDD
        {
            get
            {
                return this.itemDeliveredWithinEDDField;
            }
            set
            {
                this.itemDeliveredWithinEDDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDeliveredWithinEDDSpecified
        {
            get
            {
                return this.itemDeliveredWithinEDDFieldSpecified;
            }
            set
            {
                this.itemDeliveredWithinEDDFieldSpecified = value;
            }
        }
    }
