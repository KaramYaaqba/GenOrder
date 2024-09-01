    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellerEventsResponseType : AbstractResponseType
    {
        
        private System.DateTime timeToField;
        
        private bool timeToFieldSpecified;
        
        private ItemType[] itemArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeTo
        {
            get
            {
                return this.timeToField;
            }
            set
            {
                this.timeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeToSpecified
        {
            get
            {
                return this.timeToFieldSpecified;
            }
            set
            {
                this.timeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public ItemType[] ItemArray
        {
            get
            {
                return this.itemArrayField;
            }
            set
            {
                this.itemArrayField = value;
            }
        }
    }
