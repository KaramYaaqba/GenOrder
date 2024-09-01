    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class EndItemsRequestType : AbstractRequestType
    {
        
        private EndItemRequestContainerType[] endItemRequestContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndItemRequestContainer" )]
        public EndItemRequestContainerType[] EndItemRequestContainer
        {
            get
            {
                return this.endItemRequestContainerField;
            }
            set
            {
                this.endItemRequestContainerField = value;
            }
        }
    }
