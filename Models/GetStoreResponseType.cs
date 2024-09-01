    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreResponseType : AbstractResponseType
    {
        
        private StoreType storeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreType Store
        {
            get
            {
                return this.storeField;
            }
            set
            {
                this.storeField = value;
            }
        }
    }
