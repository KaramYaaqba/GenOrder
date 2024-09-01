    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellerEventsRequestType : AbstractRequestType
    {
        
        private string userIDField;
        
        private System.DateTime startTimeFromField;
        
        private bool startTimeFromFieldSpecified;
        
        private System.DateTime startTimeToField;
        
        private bool startTimeToFieldSpecified;
        
        private System.DateTime endTimeFromField;
        
        private bool endTimeFromFieldSpecified;
        
        private System.DateTime endTimeToField;
        
        private bool endTimeToFieldSpecified;
        
        private System.DateTime modTimeFromField;
        
        private bool modTimeFromFieldSpecified;
        
        private System.DateTime modTimeToField;
        
        private bool modTimeToFieldSpecified;
        
        private bool newItemFilterField;
        
        private bool newItemFilterFieldSpecified;
        
        private bool includeWatchCountField;
        
        private bool includeWatchCountFieldSpecified;
        
        private bool includeVariationSpecificsField;
        
        private bool includeVariationSpecificsFieldSpecified;
        
        private bool hideVariationsField;
        
        private bool hideVariationsFieldSpecified;
        
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
        public System.DateTime ModTimeFrom
        {
            get
            {
                return this.modTimeFromField;
            }
            set
            {
                this.modTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeFromSpecified
        {
            get
            {
                return this.modTimeFromFieldSpecified;
            }
            set
            {
                this.modTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ModTimeTo
        {
            get
            {
                return this.modTimeToField;
            }
            set
            {
                this.modTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeToSpecified
        {
            get
            {
                return this.modTimeToFieldSpecified;
            }
            set
            {
                this.modTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool NewItemFilter
        {
            get
            {
                return this.newItemFilterField;
            }
            set
            {
                this.newItemFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewItemFilterSpecified
        {
            get
            {
                return this.newItemFilterFieldSpecified;
            }
            set
            {
                this.newItemFilterFieldSpecified = value;
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
        public bool IncludeVariationSpecifics
        {
            get
            {
                return this.includeVariationSpecificsField;
            }
            set
            {
                this.includeVariationSpecificsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeVariationSpecificsSpecified
        {
            get
            {
                return this.includeVariationSpecificsFieldSpecified;
            }
            set
            {
                this.includeVariationSpecificsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HideVariations
        {
            get
            {
                return this.hideVariationsField;
            }
            set
            {
                this.hideVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HideVariationsSpecified
        {
            get
            {
                return this.hideVariationsFieldSpecified;
            }
            set
            {
                this.hideVariationsFieldSpecified = value;
            }
        }
    }
