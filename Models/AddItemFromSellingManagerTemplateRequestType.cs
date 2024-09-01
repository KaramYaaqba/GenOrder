    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddItemFromSellingManagerTemplateRequestType : AbstractRequestType
    {
        
        private long saleTemplateIDField;
        
        private bool saleTemplateIDFieldSpecified;
        
        private System.DateTime scheduleTimeField;
        
        private bool scheduleTimeFieldSpecified;
        
        private ItemType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SaleTemplateID
        {
            get
            {
                return this.saleTemplateIDField;
            }
            set
            {
                this.saleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaleTemplateIDSpecified
        {
            get
            {
                return this.saleTemplateIDFieldSpecified;
            }
            set
            {
                this.saleTemplateIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ScheduleTime
        {
            get
            {
                return this.scheduleTimeField;
            }
            set
            {
                this.scheduleTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduleTimeSpecified
        {
            get
            {
                return this.scheduleTimeFieldSpecified;
            }
            set
            {
                this.scheduleTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
