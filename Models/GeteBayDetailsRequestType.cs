    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GeteBayDetailsRequestType : AbstractRequestType
    {
        
        private DetailNameCodeType[] detailNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DetailName" )]
        public DetailNameCodeType[] DetailName
        {
            get
            {
                return this.detailNameField;
            }
            set
            {
                this.detailNameField = value;
            }
        }
    }
