    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAutoListType
    {
        
        private long sourceSaleTemplateIDField;
        
        private bool sourceSaleTemplateIDFieldSpecified;
        
        private SellingManagerAutoListMinActiveItemsType keepMinActiveField;
        
        private SellingManagerAutoListAccordingToScheduleType listAccordingToScheduleField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long SourceSaleTemplateID
        {
            get
            {
                return this.sourceSaleTemplateIDField;
            }
            set
            {
                this.sourceSaleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceSaleTemplateIDSpecified
        {
            get
            {
                return this.sourceSaleTemplateIDFieldSpecified;
            }
            set
            {
                this.sourceSaleTemplateIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoListMinActiveItemsType KeepMinActive
        {
            get
            {
                return this.keepMinActiveField;
            }
            set
            {
                this.keepMinActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoListAccordingToScheduleType ListAccordingToSchedule
        {
            get
            {
                return this.listAccordingToScheduleField;
            }
            set
            {
                this.listAccordingToScheduleField = value;
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
