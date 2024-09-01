    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SaveItemToSellingManagerTemplateResponseType : AbstractResponseType
    {
        
        private long templateIDField;
        
        private bool templateIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long TemplateID
        {
            get
            {
                return this.templateIDField;
            }
            set
            {
                this.templateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemplateIDSpecified
        {
            get
            {
                return this.templateIDFieldSpecified;
            }
            set
            {
                this.templateIDFieldSpecified = value;
            }
        }
    }
