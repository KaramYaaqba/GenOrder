    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreVacationPreferencesType
    {
        
        private bool onVacationField;
        
        private bool onVacationFieldSpecified;
        
        private System.DateTime returnDateField;
        
        private bool returnDateFieldSpecified;
        
        private bool hideFixedPriceStoreItemsField;
        
        private bool hideFixedPriceStoreItemsFieldSpecified;
        
        private bool messageItemField;
        
        private bool messageItemFieldSpecified;
        
        private bool messageStoreField;
        
        private bool messageStoreFieldSpecified;
        
        private bool displayMessageStoreCustomTextField;
        
        private bool displayMessageStoreCustomTextFieldSpecified;
        
        private string messageStoreCustomTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool OnVacation
        {
            get
            {
                return this.onVacationField;
            }
            set
            {
                this.onVacationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnVacationSpecified
        {
            get
            {
                return this.onVacationFieldSpecified;
            }
            set
            {
                this.onVacationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ReturnDate
        {
            get
            {
                return this.returnDateField;
            }
            set
            {
                this.returnDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnDateSpecified
        {
            get
            {
                return this.returnDateFieldSpecified;
            }
            set
            {
                this.returnDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HideFixedPriceStoreItems
        {
            get
            {
                return this.hideFixedPriceStoreItemsField;
            }
            set
            {
                this.hideFixedPriceStoreItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HideFixedPriceStoreItemsSpecified
        {
            get
            {
                return this.hideFixedPriceStoreItemsFieldSpecified;
            }
            set
            {
                this.hideFixedPriceStoreItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool MessageItem
        {
            get
            {
                return this.messageItemField;
            }
            set
            {
                this.messageItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageItemSpecified
        {
            get
            {
                return this.messageItemFieldSpecified;
            }
            set
            {
                this.messageItemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool MessageStore
        {
            get
            {
                return this.messageStoreField;
            }
            set
            {
                this.messageStoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageStoreSpecified
        {
            get
            {
                return this.messageStoreFieldSpecified;
            }
            set
            {
                this.messageStoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DisplayMessageStoreCustomText
        {
            get
            {
                return this.displayMessageStoreCustomTextField;
            }
            set
            {
                this.displayMessageStoreCustomTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayMessageStoreCustomTextSpecified
        {
            get
            {
                return this.displayMessageStoreCustomTextFieldSpecified;
            }
            set
            {
                this.displayMessageStoreCustomTextFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MessageStoreCustomText
        {
            get
            {
                return this.messageStoreCustomTextField;
            }
            set
            {
                this.messageStoreCustomTextField = value;
            }
        }
    }
