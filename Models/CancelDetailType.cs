    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CancelDetailType
    {
        
        private string cancelReasonField;
        
        private string cancelReasonDetailsField;
        
        private string cancelIntiatorField;
        
        private System.DateTime cancelIntiationDateField;
        
        private bool cancelIntiationDateFieldSpecified;
        
        private System.DateTime cancelCompleteDateField;
        
        private bool cancelCompleteDateFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string CancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CancelReasonDetails
        {
            get
            {
                return this.cancelReasonDetailsField;
            }
            set
            {
                this.cancelReasonDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string CancelIntiator
        {
            get
            {
                return this.cancelIntiatorField;
            }
            set
            {
                this.cancelIntiatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CancelIntiationDate
        {
            get
            {
                return this.cancelIntiationDateField;
            }
            set
            {
                this.cancelIntiationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelIntiationDateSpecified
        {
            get
            {
                return this.cancelIntiationDateFieldSpecified;
            }
            set
            {
                this.cancelIntiationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CancelCompleteDate
        {
            get
            {
                return this.cancelCompleteDateField;
            }
            set
            {
                this.cancelCompleteDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelCompleteDateSpecified
        {
            get
            {
                return this.cancelCompleteDateFieldSpecified;
            }
            set
            {
                this.cancelCompleteDateFieldSpecified = value;
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
