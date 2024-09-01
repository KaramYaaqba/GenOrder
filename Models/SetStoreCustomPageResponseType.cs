    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetStoreCustomPageResponseType : AbstractResponseType
    {
        
        private StoreCustomPageType customPageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomPageType CustomPage
        {
            get
            {
                return this.customPageField;
            }
            set
            {
                this.customPageField = value;
            }
        }
    }
