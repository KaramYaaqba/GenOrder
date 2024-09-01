    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetUserNotesRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private SetUserNotesActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private string noteTextField;
        
        private string transactionIDField;
        
        private NameValueListType[] variationSpecificsField;
        
        private string sKUField;
        
        private string orderLineItemIDField;
        
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
        public SetUserNotesActionCodeType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NoteText
        {
            get
            {
                return this.noteTextField;
            }
            set
            {
                this.noteTextField = value;
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
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NameValueList", IsNullable=false)]
        public NameValueListType[] VariationSpecifics
        {
            get
            {
                return this.variationSpecificsField;
            }
            set
            {
                this.variationSpecificsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
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
    }
