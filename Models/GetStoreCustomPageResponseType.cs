    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreCustomPageResponseType : AbstractResponseType
    {
        
        private StoreCustomPageType[] customPageArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomPage", IsNullable=false)]
        public StoreCustomPageType[] CustomPageArray
        {
            get
            {
                return this.customPageArrayField;
            }
            set
            {
                this.customPageArrayField = value;
            }
        }
    }
