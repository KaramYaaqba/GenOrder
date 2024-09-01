    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RelistFixedPriceItemRequestType : AbstractRequestType
    {
        
        private ItemType itemField;
        
        private string[] deletedFieldField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeletedField" )]
        public string[] DeletedField
        {
            get
            {
                return this.deletedFieldField;
            }
            set
            {
                this.deletedFieldField = value;
            }
        }
    }
