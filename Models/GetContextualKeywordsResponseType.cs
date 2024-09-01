    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetContextualKeywordsResponseType : AbstractResponseType
    {
        
        private ContextSearchAssetType[] contextSearchAssetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContextSearchAsset" )]
        public ContextSearchAssetType[] ContextSearchAsset
        {
            get
            {
                return this.contextSearchAssetField;
            }
            set
            {
                this.contextSearchAssetField = value;
            }
        }
    }
