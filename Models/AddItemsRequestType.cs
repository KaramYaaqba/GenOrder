    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddItemsRequestType : AbstractRequestType
    {
        
        private AddItemRequestContainerType[] addItemRequestContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddItemRequestContainer" )]
        public AddItemRequestContainerType[] AddItemRequestContainer
        {
            get
            {
                return this.addItemRequestContainerField;
            }
            set
            {
                this.addItemRequestContainerField = value;
            }
        }
    }
