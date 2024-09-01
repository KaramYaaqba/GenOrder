    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class EndItemsResponseType : AbstractResponseType
    {
        
        private EndItemResponseContainerType[] endItemResponseContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndItemResponseContainer" )]
        public EndItemResponseContainerType[] EndItemResponseContainer
        {
            get
            {
                return this.endItemResponseContainerField;
            }
            set
            {
                this.endItemResponseContainerField = value;
            }
        }
    }
