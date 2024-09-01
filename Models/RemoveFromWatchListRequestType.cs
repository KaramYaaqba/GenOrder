    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RemoveFromWatchListRequestType : AbstractRequestType
    {
        
        private string[] itemIDField;
        
        private bool removeAllItemsField;
        
        private bool removeAllItemsFieldSpecified;
        
        private VariationKeyType[] variationKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemID" )]
        public string[] ItemID
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
        public bool RemoveAllItems
        {
            get
            {
                return this.removeAllItemsField;
            }
            set
            {
                this.removeAllItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoveAllItemsSpecified
        {
            get
            {
                return this.removeAllItemsFieldSpecified;
            }
            set
            {
                this.removeAllItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VariationKey" )]
        public VariationKeyType[] VariationKey
        {
            get
            {
                return this.variationKeyField;
            }
            set
            {
                this.variationKeyField = value;
            }
        }
    }
