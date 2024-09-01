    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddItemFromSellingManagerTemplateResponseType : AbstractResponseType
    {
        
        private string itemIDField;
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime endTimeField;
        
        private bool endTimeFieldSpecified;
        
        private FeeType[] feesField;
        
        private string categoryIDField;
        
        private string category2IDField;
        
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
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeSpecified
        {
            get
            {
                return this.endTimeFieldSpecified;
            }
            set
            {
                this.endTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable=false)]
        public FeeType[] Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryID
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Category2ID
        {
            get
            {
                return this.category2IDField;
            }
            set
            {
                this.category2IDField = value;
            }
        }
    }
