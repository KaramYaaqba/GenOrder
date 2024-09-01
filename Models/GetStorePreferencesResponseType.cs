    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStorePreferencesResponseType : AbstractResponseType
    {
        
        private StorePreferencesType storePreferencesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StorePreferencesType StorePreferences
        {
            get
            {
                return this.storePreferencesField;
            }
            set
            {
                this.storePreferencesField = value;
            }
        }
    }
