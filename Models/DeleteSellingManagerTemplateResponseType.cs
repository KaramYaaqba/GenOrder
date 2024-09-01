    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteSellingManagerTemplateResponseType : AbstractResponseType
    {
        
        private string deletedSaleTemplateIDField;
        
        private string deletedSaleTemplateNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DeletedSaleTemplateID
        {
            get
            {
                return this.deletedSaleTemplateIDField;
            }
            set
            {
                this.deletedSaleTemplateIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DeletedSaleTemplateName
        {
            get
            {
                return this.deletedSaleTemplateNameField;
            }
            set
            {
                this.deletedSaleTemplateNameField = value;
            }
        }
    }
